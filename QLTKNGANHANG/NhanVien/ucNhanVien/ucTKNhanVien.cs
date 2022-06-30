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
    public partial class ucTKNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucTKNhanVien _instance;
        public static ucTKNhanVien Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucTKNhanVien();
                return _instance;
            }
        }
        #region variable
        public static string connectionString = @"Data Source = MY-DESKTOP\SQLEXPRESS;Initial Catalog = dbo_bankAccount;User ID = sa;Password = 123";
        DataSet ds;
        public static string Status = "";
        public static string Error = "";
        SqlConnection conn;
        //SqlTransaction trans;
        #endregion
        public ucTKNhanVien()
        {
            InitializeComponent();
            GetData();
            LoadNam();
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
                string query = "SELECT ROW_NUMBER() OVER (ORDER BY staff_id) AS STT,staff_id ,hoten, soCMND, namsinh,IIF(gioitinh = 1,'NAM',N'NỮ') AS gioitinh, dienthoai, staff_username ,staff_password, IIF(permit = 1,1,0) AS permit FROM tbl_staff ";
                SqlCommand cmd = new SqlCommand(query, conn);
                ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    //dtgKhachHang.AutoGenerateColumns = false;
                    dtgQLTKNV.DataSource = ds.Tables[0];
                    lblTong.Text = "Tổng số: " + ds.Tables[0].Rows.Count + " bản ghi";

                    DataRow dr0 = ds.Tables[0].Rows[0];
                    txtID.Text = dr0["staff_id"].ToString();
                    txtHoTen.Text = dr0["hoten"].ToString();
                    txtCMND.Text = dr0["soCMND"].ToString();
                    cboNamSinh.Text = dr0["namsinh"].ToString();
                    if (dr0["gioitinh"].ToString() == "NAM")
                    {
                        rdoNam.Checked = true;
                    }
                    else
                    {
                        rdoNu.Checked = false;
                    }
                    txtSDT.Text = dr0["dienthoai"].ToString();
                    txtTK.Text = dr0["staff_username"].ToString();
                    txtMK.Text = dr0["staff_password"].ToString();
                    nmrQuyen.Text = dr0["permit"].ToString();
                }
                else
                {
                    dtgQLTKNV.DataSource = null;
                    lblTong.Text = "Tổng số: 0 bản ghi";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadNam()
        {
            var YearStart = DateTime.Now.AddYears(-3).Year;
            for (int j = 1800; j <= YearStart + 3; j++)
            {
                cboNamSinh.Items.Add(j.ToString());
            }
        }
        #region FUNCTION
        public void SetControlStatus(string Status)
        {
            switch (Status)
            {
                case "Reset":
                    lblError.Text = "";
                    lblStatus.Text = "";

                    txtID.Enabled = false;
                    txtHoTen.Enabled = false;
                    txtCMND.Enabled = false;
                    cboNamSinh.Enabled = false;
                    txtSDT.Enabled = false;
                    txtTK.Enabled = false;
                    txtMK.Enabled = false;
                    txtMK.Enabled = false;
                    rdoNam.Enabled = false;
                    rdoNu.Enabled = false;
                    nmrQuyen.Enabled = false;

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhi.Enabled = false;
                    btnHuy.Enabled = false;

                    break;
                case "Insert":
                    lblError.Text = "";
                    lblStatus.Text = "";


                    txtID.Enabled = false;
                    txtHoTen.Enabled = true;
                    txtCMND.Enabled = true;
                    cboNamSinh.Enabled = true;
                    txtSDT.Enabled = true;
                    txtTK.Enabled = true;
                    txtMK.Enabled = true;
                    txtMK.Enabled = true;
                    rdoNam.Enabled = true;
                    rdoNu.Enabled = true;
                    nmrQuyen.Enabled = true;

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuy.Enabled = true;

                    txtID.Text = "";
                    txtHoTen.Text = "";
                    txtCMND.Text = "";
                    rdoNam.Checked = false;
                    rdoNu.Checked = false;
                    cboNamSinh.Text = "---CHỌN NĂM SINH---";
                    txtSDT.Text = "";
                    txtTK.Text = "";
                    txtMK.Text = "";
                    nmrQuyen.Text = "";
                    txtHoTen.Focus();
                    break;
                case "Update":
                    lblError.Text = "";
                    lblStatus.Text = "";

                    txtID.Enabled = false;
                    txtHoTen.Enabled = true;
                    txtCMND.Enabled = true;
                    cboNamSinh.Enabled = true;
                    txtSDT.Enabled = true;
                    txtTK.Enabled = true;
                    txtMK.Enabled = true;
                    txtMK.Enabled = true;
                    rdoNam.Enabled = true;
                    rdoNu.Enabled = true;
                    nmrQuyen.Enabled = true;

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuy.Enabled = true;

                    txtHoTen.Focus();
                    break;
                default:
                    break;
            }
        }
        public bool InsertData(ref string strError)
        {
            try
            {


                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "INSERT_tbl_staff";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                int Gioitinh = -1;
                if (rdoNam.Checked == true)
                {
                    Gioitinh = 1;
                }
                else
                {
                    Gioitinh = 0;
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@hoten", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@soCMND", txtCMND.Text);
                cmd.Parameters.AddWithValue("@namsinh", cboNamSinh.Text);
                cmd.Parameters.AddWithValue("@gioitinh", Gioitinh);
                cmd.Parameters.AddWithValue("@dienthoai", txtSDT.Text);
                cmd.Parameters.AddWithValue("@staff_username", txtTK.Text);
                cmd.Parameters.AddWithValue("@staff_password", 1);
                cmd.Parameters.AddWithValue("@permit", nmrQuyen.Value);
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
        public bool UpdateData(ref string strError)
        {
            try
            {


                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "UPDATE_tbl_staff";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                int Gioitinh = -1;
                if (rdoNam.Checked == true)
                {
                    Gioitinh = 1;
                }
                else
                {
                    Gioitinh = 0;
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@staff_id", txtID.Text);
                cmd.Parameters.AddWithValue("@hoten", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@soCMND", txtCMND.Text);
                cmd.Parameters.AddWithValue("@namsinh", cboNamSinh.Text);
                cmd.Parameters.AddWithValue("@gioitinh", Gioitinh);
                cmd.Parameters.AddWithValue("@dienthoai", txtSDT.Text);
                cmd.Parameters.AddWithValue("@staff_username", txtTK.Text);
                cmd.Parameters.AddWithValue("@staff_password", txtMK.Text);
                cmd.Parameters.AddWithValue("@permit", nmrQuyen.Value);
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
        public bool DeleteData(ref string strError)
        {
            try
            {
                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "DELETE_tbl_staff";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@staff_id", txtID.Text);
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
        public bool CheckTaiKhoan(string TaiKhoan, ref string strError)
        {
            try
            {
                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "SELECT * FROM tbl_staff WHERE staff_username = '" + TaiKhoan + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return true;
            }
        }
        public bool IsValid()
        {
            //kiem tra co nhap du du lieu k
            if (txtHoTen != null && txtHoTen.Text.Trim() != "")
            {

            }
            else
            {
                MessageBox.Show("Chưa tên nhân viên!");
                txtHoTen.Focus();
                return false;
            }
            if (txtSDT != null && txtSDT.Text.Trim() != "")
            {

            }
            else
            {
                MessageBox.Show("Chưa nhập số điện thoại!");
                txtSDT.Focus();
                return false;
            }
            if (txtCMND != null && txtCMND.Text.Trim() != "")
            {

            }
            else
            {
                MessageBox.Show("Chưa nhập số CMND!");
                txtCMND.Focus();
                return false;
            }
            if (cboNamSinh != null && cboNamSinh.Text.Trim() != "---CHỌN NĂM SINH---")
            {

            }
            else
            {
                MessageBox.Show("Chưa chọn năm sinh!");
                cboNamSinh.Focus();
                return false;
            }
            if (txtTK != null && txtTK.Text.Trim() != "")
            {

            }
            else
            {
                MessageBox.Show("Chưa nhập tài khoản!");
                txtTK.Focus();
                return false;
            }
            if(rdoNam.Checked == false || rdoNu.Checked == false )
            {

            }
            else
            {
                MessageBox.Show("Chưa chọn giới tính!");
                return false;
            }
            if (nmrQuyen.Value == 0 || nmrQuyen.Value == 1 )
            {

            }
            else
            {
                MessageBox.Show("Quyền không tồn tại");
                return false;
            }
            return true;
        }
        #endregion

        #region EVENTS
        private void dtgQLTKNV_MouseDown(object sender, MouseEventArgs e)
        {
            GridHitInfo info = gridView1.CalcHitInfo(e.Location);
            if (info.InRowCell)
            {
                int row = info.RowHandle;
                GridColumn column = info.Column;
                txtID.Text = gridView1.GetRowCellValue(row, "staff_id").ToString();
                txtHoTen.Text = gridView1.GetRowCellValue(row, "hoten").ToString();
                txtCMND.Text = gridView1.GetRowCellValue(row, "soCMND").ToString();
                cboNamSinh.Text = gridView1.GetRowCellValue(row, "namsinh").ToString();
                txtSDT.Text = gridView1.GetRowCellValue(row, "dienthoai").ToString();
                txtTK.Text = gridView1.GetRowCellValue(row, "staff_username").ToString();
                txtMK.Text = gridView1.GetRowCellValue(row, "staff_password").ToString();
                if (gridView1.GetRowCellValue(row, "gioitinh").ToString() == "NAM")
                {
                    rdoNam.Checked = true;
                }
                else
                {
                    rdoNu.Checked = true;
                }
                nmrQuyen.Text = gridView1.GetRowCellValue(row, "permit").ToString();
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

                ds.AcceptChanges();
                dtgQLTKNV.DataSource = ds.Tables[0];
                dtgQLTKNV.Refresh();
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
                string Error = "";
                var bResult = CheckTaiKhoan(txtTK.Text.Trim(), ref Error);
                if (bResult == false)
                {
                    if (Error != "")
                    {
                        MessageBox.Show(Error);
                    }
                    else
                    {
                        MessageBox.Show("Đã tồn tại tài khoản " + txtTK.Text.Trim() + " trong dữ liệu");
                    }
                    return;
                }
                var dResult = InsertData(ref Error);
                if (dResult == false)
                {
                    lblError.Text = Error;
                }
                else
                {
                    Status = "Reset";
                    ds.AcceptChanges();
                    dtgQLTKNV.Refresh();
                    dtgQLTKNV.DataSource = ds.Tables[0];
                    SetControlStatus(Status);

                    lblStatus.Text = "Ghi dữ liệu thành công";
                    GetData();
                }
            }
            else if (Status == "Update")
            {
                var dResult = UpdateData(ref Error);
                if (dResult == false)
                {
                    lblError.Text = Error;
                }
                else
                {
                    Status = "Reset";

                    ds.AcceptChanges();
                    dtgQLTKNV.DataSource = ds.Tables[0];
                    dtgQLTKNV.Refresh();
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
