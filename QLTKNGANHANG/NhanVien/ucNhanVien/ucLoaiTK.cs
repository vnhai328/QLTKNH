using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Columns;

namespace QLTKNGANHANG.ucNhanVien
{
    public partial class ucLoaiTK : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucLoaiTK _instance;
        public static ucLoaiTK Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucLoaiTK();
                return _instance;
            }
        }
        #region variable
        public static string connectionString = @"Data Source = MY-DESKTOP\SQLEXPRESS;Initial Catalog = dbo_bankAccount;User ID = sa;Password = 123";
        DataSet ds;
        public static string Status = "";
        public static string Error = "";
        SqlConnection conn;
        #endregion
        public ucLoaiTK()
        {
            InitializeComponent();
            GetData();
            SetControlStatus("Reset");
        }
        public void GetData()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "SELECT ROW_NUMBER() OVER (ORDER BY loaiTK_id) AS STT, loaiTK_id, loaiTK_ten,ghichu  FROM tbl_loaiTK ";
                SqlCommand cmd = new SqlCommand(query, conn);
                ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    //dtgMain.AutoGenerateColumns = false;
                    dtgLoaiTK.DataSource = ds.Tables[0];
                    lblTong.Text = "Tổng số: " + ds.Tables[0].Rows.Count + " bản ghi";

                    DataRow dr0 = ds.Tables[0].Rows[0];
                    txtID.Text = dr0["loaiTK_id"].ToString();
                    txtLoaiTK.Text = dr0["loaiTK_ten"].ToString();
                    txtGhiChu.Text = dr0["ghichu"].ToString();
                }
                else
                {
                    dtgLoaiTK.DataSource = null;
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

                    txtLoaiTK.Enabled = false;
                    txtGhiChu.Enabled = false;

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhi.Enabled = false;
                    btnHuy.Enabled = false;

                    break;
                case "Insert":
                    lblError.Text = "";
                    lblStatus.Text = "";

                    txtLoaiTK.Enabled = true;
                    txtGhiChu.Enabled = true;

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuy.Enabled = true;

                    txtLoaiTK.Text = "";
                    txtGhiChu.Text = "";
                    txtID.Text = "";
                    txtLoaiTK.Focus();
                    break;
                case "Update":
                    lblError.Text = "";
                    lblStatus.Text = "";

                    txtLoaiTK.Enabled = true;
                    txtGhiChu.Enabled = true;

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuy.Enabled = true;

                    txtLoaiTK.Focus();
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
                string LoaiTK = txtLoaiTK.Text.Trim();
                string GhiChu = txtGhiChu.Text.Trim();

                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "INSERT INTO tbl_loaiTK VALUES (N'" + LoaiTK + "',N'" + GhiChu + "')";
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
                string LoaiTK = txtLoaiTK.Text.Trim();
                string GhiChu = txtGhiChu.Text.Trim();

                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "UPDATE tbl_loaiTK SET loaiTK_ten = N'" + LoaiTK + "',ghichu = N'" + GhiChu + "' WHERE loaiTK_id = '" + txtID.Text + "' ";
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
                string query = "DELETE FROM tbl_loaiTK WHERE loaiTK_id = '" + txtID.Text.Trim() + "'";
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
            if (txtLoaiTK != null && txtLoaiTK.Text.Trim() != "")
            {

            }
            else
            {
                MessageBox.Show("Chưa nhập loại tài khoản");
                txtLoaiTK.Focus();
                return false;
            }
            return true;
        }
        #endregion
        #region EVENTS
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
                drNew["loaiTK_ten"] = txtLoaiTK.Text.Trim();
                drNew["ghichu"] = txtGhiChu.Text.Trim();
                ds.AcceptChanges();
                dtgLoaiTK.DataSource = ds.Tables[0];
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
                    drNew["loaiTK_ten"] = txtLoaiTK.Text.Trim();
                    drNew["ghichu"] = txtGhiChu.Text.Trim();
                    ds.Tables[0].Rows.Add(drNew);
                    ds.AcceptChanges();
                    dtgLoaiTK.DataSource = ds.Tables[0];
                    lblTong.Text = "Tổng số: " + ds.Tables[0].Rows.Count + " bản ghi";
                    dtgLoaiTK.Refresh();
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
                    drNew["loaiTK_ten"] = txtLoaiTK.Text.Trim();
                    drNew["ghichu"] = txtGhiChu.Text.Trim();
                    ds.AcceptChanges();
                    dtgLoaiTK.DataSource = ds.Tables[0];
                    dtgLoaiTK.Refresh();
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

        private void dtgLoaiTK_MouseDown(object sender, MouseEventArgs e)
        {
            GridHitInfo info = gridView1.CalcHitInfo(e.Location);
            if (info.InRowCell)
            {
                int row = info.RowHandle;
                GridColumn column = info.Column;
                txtLoaiTK.Text = gridView1.GetRowCellValue(row, "loaiTK_ten").ToString();
                txtGhiChu.Text = gridView1.GetRowCellValue(row, "ghichu").ToString();
                txtID.Text = gridView1.GetRowCellValue(row, "loaiTK_id").ToString();
            }
        }
        #endregion
    }
}
