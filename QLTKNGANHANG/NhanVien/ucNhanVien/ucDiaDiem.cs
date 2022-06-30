using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Columns;

namespace QLTKNGANHANG.ucDanhMuc
{
    public partial class ucDiaDiem : System.Windows.Forms.UserControl
    {
        private static ucDiaDiem _instance;
        public static ucDiaDiem Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucDiaDiem();
                return _instance;
            }
        }
        public ucDiaDiem()
        {
            InitializeComponent();
            GetData();
            SetControlStatus("Reset");
        }
        #region variable
        public static string connectionString = @"Data Source = MY-DESKTOP\SQLEXPRESS;Initial Catalog = dbo_bankAccount;User ID = sa;Password = 123";
        DataSet ds;
        public static string Status = "";
        public static string Error = "";
        SqlConnection conn;
        #endregion
        public void GetData()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "SELECT ROW_NUMBER() OVER (ORDER BY branch_name) AS STT, branch_name, ghichu AS diadiem, branch_id FROM tbl_branch ";
                SqlCommand cmd = new SqlCommand(query, conn);
                ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    //dtgMain.AutoGenerateColumns = false;
                    dtgDiaDiem.DataSource = ds.Tables[0];
                    lblTong.Text = "Tổng số: " + ds.Tables[0].Rows.Count + " bản ghi";

                    DataRow dr0 = ds.Tables[0].Rows[0];
                    txtID.Text = dr0["branch_id"].ToString();
                    txtTenDiaDiem.Text = dr0["branch_name"].ToString();
                    txtDiaChi.Text = dr0["diadiem"].ToString();
                }
                else
                {
                    dtgDiaDiem.DataSource = null;
                    lblTong.Text = "Tổng số: 0 bản ghi";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region function
        public void SetControlStatus(string Status)
        {
            switch (Status)
            {
                case "Reset":
                    lblError.Text = "";
                    lblStatus.Text = "";

                    txtTenDiaDiem.Enabled = false;
                    txtDiaChi.Enabled = false;

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhi.Enabled = false;
                    btnHuy.Enabled = false;

                    break;
                case "Insert":
                    lblError.Text = "";
                    lblStatus.Text = "";

                    txtTenDiaDiem.Enabled = true;
                    txtDiaChi.Enabled = true;

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuy.Enabled = true;

                    txtTenDiaDiem.Text = "";
                    txtDiaChi.Text = "";
                    txtTenDiaDiem.Focus();
                    break;
                case "Update":
                    lblError.Text = "";
                    lblStatus.Text = "";

                    txtTenDiaDiem.Enabled = true;
                    txtDiaChi.Enabled = true;

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuy.Enabled = true;

                    txtTenDiaDiem.Focus();
                    break;
                default:
                    break;
            }
        }
        public bool InsertData(ref string strError)
        {
            try
            {
                //Lay du lieu trong csdl               
                string TEN_DIADIEM = txtTenDiaDiem.Text.Trim();
                string DIA_CHI = txtDiaChi.Text.Trim();

                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "INSERT INTO tbl_branch VALUES (N'" + TEN_DIADIEM + "',N'" + DIA_CHI + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool UpdateData(ref string strError)
        {
            try
            {
                //Lay du lieu trong csdl               
                string TEN_DIADIEM = txtTenDiaDiem.Text.Trim();
                string DIA_CHI = txtDiaChi.Text.Trim();

                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "UPDATE tbl_branch SET branch_name = N'" + TEN_DIADIEM + "',ghichu = N'" + DIA_CHI + "' WHERE branch_id = '" + txtID.Text + "' ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
            finally
            {
                conn.Close();
            }

        }
        public bool DeleteData(ref string strError)
        {
            try
            {
                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "DELETE FROM tbl_branch WHERE branch_id = '" + txtID.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                GetData();
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool IsValid()
        {
            //kiem tra co nhap du du lieu k
            if (txtTenDiaDiem != null && txtTenDiaDiem.Text.Trim() != "")
            {

            }
            else
            {
                MessageBox.Show("Chưa nhập địa điểm");
                txtTenDiaDiem.Focus();
                return false;
            }
            if (txtDiaChi != null && txtDiaChi.Text.Trim() != "")
            {

            }
            else
            {
                MessageBox.Show("Chưa nhâp địa chỉ!");
                txtDiaChi.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region Events
        private void dtgDiaDiem_MouseDown(object sender, MouseEventArgs e)
        {
            GridHitInfo info = gridView1.CalcHitInfo(e.Location);
            if (info.InRowCell)
            {
                int row = info.RowHandle;
                GridColumn column = info.Column;
                txtTenDiaDiem.Text = gridView1.GetRowCellValue(row, "branch_name").ToString();
                txtDiaChi.Text = gridView1.GetRowCellValue(row, "diadiem").ToString();
                txtID.Text = gridView1.GetRowCellValue(row, "branch_id").ToString();
            }
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Status = "Insert";
                SetControlStatus(Status);
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Status = "Update";
                SetControlStatus(Status);
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var bResult = DeleteData(ref Error);
            if (bResult == false)
            {
                lblError.Text = Error;
            }
            else
            {
                Status = "Reset";
                DataRow drNew = ds.Tables[0].NewRow();
                drNew["branch_name"] = txtTenDiaDiem.Text.Trim();
                drNew["diadiem"] = txtDiaChi.Text.Trim();
                ds.AcceptChanges();
                dtgDiaDiem.DataSource = ds.Tables[0];
                ds.Tables[0].Rows.Add(drNew);
                SetControlStatus(Status);
                GetData();

                lblStatus.Text = "Xóa dữ liệu thành công";
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var cResult = IsValid();
            if (cResult == false)
            {
                return;
            }
            if (Status == "Insert")
            {
                //Them du lieu
                var bResult = InsertData(ref Error);
                if (bResult == false)
                {
                    lblError.Text = Error;
                }
                else
                {
                    Status = "Reset";
                    DataRow drNew = ds.Tables[0].NewRow();
                    drNew["branch_name"] = txtTenDiaDiem.Text.Trim();
                    drNew["diadiem"] = txtDiaChi.Text.Trim();
                    ds.Tables[0].Rows.Add(drNew);
                    ds.AcceptChanges();
                    dtgDiaDiem.DataSource = ds.Tables[0];
                    lblTong.Text = "Tổng số: " + ds.Tables[0].Rows.Count + " bản ghi";
                    dtgDiaDiem.Refresh();
                    SetControlStatus(Status);

                    GetData();
                    lblStatus.Text = "Ghi dữ liệu thành công";
                }
            }
            else if (Status == "Update")
            {
                var bResult = UpdateData(ref Error);
                if (bResult == false)
                {
                    lblError.Text = Error;
                }
                else
                {
                    Status = "Reset";
                    DataRow drNew = ds.Tables[0].NewRow();
                    drNew["branch_name"] = txtTenDiaDiem.Text.Trim();
                    drNew["diadiem"] = txtDiaChi.Text.Trim();
                    ds.AcceptChanges();
                    dtgDiaDiem.DataSource = ds.Tables[0];
                    dtgDiaDiem.Refresh();
                    SetControlStatus(Status);
                    GetData();

                    lblStatus.Text = "Sửa dữ liệu thành công";
                }
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Status = "Reset";
                SetControlStatus(Status);
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        #endregion


    }
}
