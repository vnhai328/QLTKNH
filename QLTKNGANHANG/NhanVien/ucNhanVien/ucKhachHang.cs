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

namespace QLTKNGANHANG.ucQuanLy
{
    public partial class ucKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucKhachHang _instance;
        public static ucKhachHang Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucKhachHang();
                return _instance;
            }
        }
        #region variable
        public static string connectionString = @"Data Source = MY-DESKTOP\SQLEXPRESS;Initial Catalog = dbo_bankAccount;User ID = sa;Password = 123";
        DataSet ds;
        public static string Status = "";
        public static string Error = "";
        SqlConnection conn;
        SqlTransaction trans;
        #endregion
        public ucKhachHang()
        {
            InitializeComponent();
            GetData();
            LoadLoaiTK();
            LoadChiNhanh();
            LoadNam();
            SetControlStatus("Reset");
            LoadBank();
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
                string query = "SELECT ROW_NUMBER() OVER (ORDER BY A.customer_id) AS STT, A.customer_id, A.hoten,A.namsinh ,A.soCMND, IIF(A.gioitinh = 1, 'NAM', N'NỮ') AS gioitinh, A.dienthoai, A.email, A.customer_username, A.customer_password, A.ghichu, IIF(B.active = 1,N'Hoạt động',N'Khóa') as active, B.soTK, B.pin, C.loaiTK_ten,E.bank_ten ,D.branch_name , B.current_balance, B.date_opened, B.date_closed FROM tbl_customer A, tbl_creditCard B, tbl_loaiTK C, tbl_branch D, tbl_bank E WHERE A.customer_id = B.customer_id AND B.loaiTK_id = C.loaiTK_id AND B.branch_id = D.branch_id AND B.bank_id = E.bank_id ";
                SqlCommand cmd = new SqlCommand(query, conn);
                ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    //dtgKhachHang.AutoGenerateColumns = false;
                    dtgKhachHang.DataSource = ds.Tables[0];
                    lblTong.Text = "Tổng số: " + ds.Tables[0].Rows.Count + " bản ghi";

                    DataRow dr0 = ds.Tables[0].Rows[0];
                    txtID.Text = dr0["customer_id"].ToString();
                    txtHoTen.Text = dr0["hoten"].ToString();
                    txtCMND.Text = dr0["soCMND"].ToString();
                    cboNamSinh.Text = dr0["namsinh"].ToString();
                    if (dr0["gioitinh"].ToString() == "NAM")
                    {
                        rdoNam.Checked = true;
                    }
                    else
                    {
                        rdoNu.Checked = true;
                    }
                    txtSdt.Text = dr0["dienthoai"].ToString();
                    txtEmail.Text = dr0["email"].ToString();
                    txtTenTK.Text = dr0["customer_username"].ToString();
                    txtMK.Text = dr0["customer_password"].ToString();
                    txtSTK.Text = dr0["soTK"].ToString();
                    txtPin.Text = dr0["pin"].ToString();
                    cboLoaiTK.Text = dr0["loaiTK_ten"].ToString();
                    cboNganhang.Text = dr0["bank_ten"].ToString();
                    cboChiNhanh.Text = dr0["branch_name"].ToString();
                    string sodu = dr0["current_balance"].ToString();
                    string[] arrListStr = sodu.Split(',');
                    txtSoDu.Text = arrListStr[0]; 
                }
                else
                {
                    dtgKhachHang.DataSource = null;
                    lblTong.Text = "Tổng số: 0 bản ghi";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadBank()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "SELECT * FROM tbl_bank";
                SqlCommand cmd = new SqlCommand(query, conn);
                ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    cboNganhang.ValueMember = "bank_id";
                    cboNganhang.DisplayMember = "bank_ten";
                    cboNganhang.DataSource = ds.Tables[0];
                }
                else
                {
                    cboNganhang.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadLoaiTK()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "SELECT * FROM tbl_loaiTK";
                SqlCommand cmd = new SqlCommand(query, conn);
                ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    cboLoaiTK.ValueMember = "loaiTK_id";
                    cboLoaiTK.DisplayMember = "loaiTK_ten";
                    cboLoaiTK.DataSource = ds.Tables[0];
                }
                else
                {
                    cboLoaiTK.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadChiNhanh()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "SELECT * FROM tbl_branch";
                SqlCommand cmd = new SqlCommand(query, conn);
                ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    cboChiNhanh.ValueMember = "branch_id";
                    cboChiNhanh.DisplayMember = "branch_name";
                    cboChiNhanh.DataSource = ds.Tables[0];
                }
                else
                {
                    cboChiNhanh.DataSource = null;
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
                    txtSdt.Enabled = false;
                    txtEmail.Enabled = false;
                    txtTenTK.Enabled = false;
                    txtMK.Enabled = false;
                    txtSTK.Enabled = false;
                    txtPin.Enabled = false;
                    cboLoaiTK.Enabled = false;
                    cboNganhang.Enabled = false;
                    cboChiNhanh.Enabled = false;
                    txtSoDu.Enabled = false;
                    rdoNam.Enabled = false;
                    rdoNu.Enabled = false;
                    txtGhiChu.Enabled = false;

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhi.Enabled = false;
                    btnHuy.Enabled = false;
                    btnRefresh.Enabled = true;

                    break;
                case "Insert":
                    lblError.Text = "";
                    lblStatus.Text = "";


                    txtID.Enabled = false;
                    txtHoTen.Enabled = true;
                    txtCMND.Enabled = true;
                    cboNamSinh.Enabled = true;
                    txtSdt.Enabled = true;
                    txtEmail.Enabled = true;
                    txtTenTK.Enabled = true;
                    txtMK.Enabled = true;
                    txtSTK.Enabled = true;
                    txtPin.Enabled = true;
                    cboLoaiTK.Enabled = true;
                    cboNganhang.Enabled = true;
                    cboChiNhanh.Enabled = true;
                    txtSoDu.Enabled = true;
                    rdoNam.Enabled = true;
                    rdoNu.Enabled = true;
                    txtGhiChu.Enabled = true;

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuy.Enabled = true;
                    btnRefresh.Enabled = false;

                    txtID.Text = "";
                    txtHoTen.Text = "";
                    txtCMND.Text = "";
                    rdoNam.Checked = false;
                    rdoNu.Checked = false;
                    cboNamSinh.Text = "---CHỌN NĂM SINH---";
                    txtSdt.Text = "";
                    txtEmail.Text = "";
                    txtTenTK.Text = "";
                    txtMK.Text = "";
                    txtSTK.Text = "";
                    txtPin.Text = "";
                    cboLoaiTK.Text = "---CHỌN LOẠI TÀI KHOẢN---";
                    cboChiNhanh.Text = "--CHỌN LOẠI CHI NHÁNH---";
                    cboNganhang.Text = "---CHỌN NGÂN HÀNG---";
                    txtSoDu.Text = "";
                    txtGhiChu.Text = "";
                    txtHoTen.Focus();
                    break;
                case "Update":
                    lblError.Text = "";
                    lblStatus.Text = "";


                    txtID.Enabled = false;
                    txtHoTen.Enabled = true;
                    txtCMND.Enabled = true;
                    cboNamSinh.Enabled = true;
                    txtSdt.Enabled = true;
                    txtEmail.Enabled = true;
                    txtTenTK.Enabled = true;
                    txtMK.Enabled = true;
                    txtSTK.Enabled = false;
                    txtPin.Enabled = true;
                    cboLoaiTK.Enabled = true;
                    cboNganhang.Enabled = true;
                    cboChiNhanh.Enabled = true;
                    txtSoDu.Enabled = true;
                    rdoNam.Enabled = true;
                    rdoNu.Enabled = true;
                    txtGhiChu.Enabled = true;

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuy.Enabled = true;
                    btnRefresh.Enabled = false;

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
                trans = conn.BeginTransaction();
                string query = "INSERT_tbl_customer";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Transaction = trans;

                string query2 = "INSERT_tbl_creditCard";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                cmd2.Transaction = trans;

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
                cmd.Parameters.AddWithValue("@dienthoai", txtSdt.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@customer_username", txtTenTK.Text);
                cmd.Parameters.AddWithValue("@customer_password", 1);
                cmd.Parameters.AddWithValue("@ghichu", txtGhiChu.Text);
                int iOut = -1;
                cmd.Parameters.AddWithValue("@ID_OUT", iOut).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                iOut = Convert.ToInt32(cmd.Parameters["@ID_OUT"].Value);


                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@soTK", txtSTK.Text);
                cmd2.Parameters.AddWithValue("@pin", 123456);
                cmd2.Parameters.AddWithValue("@loaiTK_id", cboLoaiTK.SelectedValue);
                cmd2.Parameters.AddWithValue("@customer_id", iOut);
                cmd2.Parameters.AddWithValue("@bank_id", cboNganhang.SelectedValue);
                cmd2.Parameters.AddWithValue("@branch_id", cboChiNhanh.SelectedValue);
                cmd2.Parameters.AddWithValue("@current_balance", txtSoDu.Text);
                cmd2.Parameters.AddWithValue("@date_opened", DateTime.Now);
                cmd2.Parameters.AddWithValue("@active", 1);
                cmd2.Parameters.AddWithValue("@ghichu","CREATE");

                cmd2.ExecuteNonQuery();

                trans.Commit();
                GetData();
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                trans.Rollback();
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
                trans = conn.BeginTransaction();
                string query = "UPDATE_tbl_customer";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Transaction = trans;

                string query2 = "UPDATE_tbl_creditCard";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                cmd2.Transaction = trans;

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
                cmd.Parameters.AddWithValue("@customer_id", txtID.Text);
                cmd.Parameters.AddWithValue("@hoten", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@soCMND", txtCMND.Text);
                cmd.Parameters.AddWithValue("@namsinh", cboNamSinh.Text);
                cmd.Parameters.AddWithValue("@gioitinh", Gioitinh);
                cmd.Parameters.AddWithValue("@dienthoai", txtSdt.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@customer_username", txtTenTK.Text);
                cmd.Parameters.AddWithValue("@customer_password", txtMK.Text);
                cmd.Parameters.AddWithValue("@ghichu", txtGhiChu.Text);
                cmd.ExecuteNonQuery();


                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@soTK", txtSTK.Text);
                cmd2.Parameters.AddWithValue("@pin", txtPin.Text);
                cmd2.Parameters.AddWithValue("@loaiTK_id", cboLoaiTK.SelectedValue);
                cmd2.Parameters.AddWithValue("@bank_id", cboNganhang.SelectedValue);
                cmd2.Parameters.AddWithValue("@branch_id", cboChiNhanh.SelectedValue);
                cmd2.Parameters.AddWithValue("@current_balance", txtSoDu.Text);
                cmd2.Parameters.AddWithValue("@ghichu", "UPDATE");

                cmd2.ExecuteNonQuery();

                trans.Commit();
                GetData();
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                trans.Rollback();
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
                trans = conn.BeginTransaction();
                string query = "DELETE_tbl_customer";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Transaction = trans;

                string query2 = "DELETE_tbl_creditCard";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                cmd2.Transaction = trans;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@customer_id", txtID.Text);
                cmd.Parameters.AddWithValue("@ghichu", txtGhiChu.Text);
                cmd.ExecuteNonQuery();


                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@soTK", txtSTK.Text);
                cmd2.Parameters.AddWithValue("@active", 0);
                cmd2.Parameters.AddWithValue("@date_closed", DateTime.Now);
                cmd2.Parameters.AddWithValue("@ghichu", "DELETE");

                cmd2.ExecuteNonQuery();

                trans.Commit();
                GetData();
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                trans.Rollback();
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
                string query = "SELECT * FROM tbl_customer WHERE customer_username = '" + TaiKhoan + "'";
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
        public bool CheckSTK(string STK, ref string strError)
        {
            try
            {
                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "SELECT * FROM tbl_creditCard WHERE soTK = '" + STK + "'";
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
                MessageBox.Show("Chưa tên khách hàng!");
                txtHoTen.Focus();
                return false;
            }
            if (txtSdt != null && txtSdt.Text.Trim() != "")
            {

            }
            else
            {
                MessageBox.Show("Chưa nhập số điện thoại!");
                txtSdt.Focus();
                return false;
            }
            if (txtEmail != null && txtEmail.Text.Trim() != "")
            {

            }
            else
            {
                MessageBox.Show("Chưa nhập email!");
                txtEmail.Focus();
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
            if (txtTenTK != null && txtTenTK.Text.Trim() != "")
            {

            }
            else
            {
                MessageBox.Show("Chưa nhập tài khoản!");
                txtTenTK.Focus();
                return false;
            }
            if (txtSTK != null && txtSTK.Text.Trim() != "")
            {

            }
            else
            {
                MessageBox.Show("Chưa nhập số tài khoản!");
                txtSTK.Focus();
                return false;
            }
            if (cboLoaiTK != null && cboLoaiTK.Text.Trim() != "---CHỌN LOẠI TÀI KHOẢN---")
            {

            }
            else
            {
                MessageBox.Show("Chưa chọn loại tài khoản!");
                cboLoaiTK.Focus();
                return false;
            }
            if (cboChiNhanh != null && cboChiNhanh.Text.Trim() != "--CHỌN LOẠI CHI NHÁNH---")
            {

            }
            else
            {
                MessageBox.Show("Chưa chọn chi nhánh!");
                cboLoaiTK.Focus();
                return false;
            }
            if (cboNganhang != null && cboNganhang.Text.Trim() != "--CHỌN NGÂN HÀNG---")
            {

            }
            else
            {
                MessageBox.Show("Chưa chọn ngân hàng!");
                cboNganhang.Focus();
                return false;
            }
            if (rdoNam.Checked == false || rdoNu.Checked == false)
            {

            }
            else
            {
                MessageBox.Show("Chưa chọn giới tính!");
                return false;
            }
            return true;
        }
        #endregion

        #region EVENTS
        private void dtgKhachHang_MouseDown(object sender, MouseEventArgs e)
        {
            GridHitInfo info = gridView1.CalcHitInfo(e.Location);
            if (info.InRowCell)
            {
                int row = info.RowHandle;
                GridColumn column = info.Column;
                txtID.Text = gridView1.GetRowCellValue(row, "customer_id").ToString();
                txtHoTen.Text = gridView1.GetRowCellValue(row, "hoten").ToString();
                txtCMND.Text = gridView1.GetRowCellValue(row, "soCMND").ToString();
                cboNamSinh.Text = gridView1.GetRowCellValue(row, "namsinh").ToString();
                txtSdt.Text = gridView1.GetRowCellValue(row, "dienthoai").ToString();
                txtEmail.Text = gridView1.GetRowCellValue(row, "email").ToString();
                txtTenTK.Text = gridView1.GetRowCellValue(row, "customer_username").ToString();
                txtMK.Text = gridView1.GetRowCellValue(row, "customer_password").ToString();
                txtSTK.Text = gridView1.GetRowCellValue(row, "soTK").ToString();
                txtPin.Text = gridView1.GetRowCellValue(row, "pin").ToString();
                string sodu = gridView1.GetRowCellValue(row, "current_balance").ToString();
                string[] arrListStr = sodu.Split(',');
                txtSoDu.Text = arrListStr[0].ToString();
                if (gridView1.GetRowCellValue(row, "gioitinh").ToString() == "NAM")
                {
                    rdoNam.Checked = true;
                }
                else
                {
                    rdoNu.Checked = true;
                }
                cboLoaiTK.Text = gridView1.GetRowCellValue(row, "loaiTK_ten").ToString();
                cboChiNhanh.Text = gridView1.GetRowCellValue(row, "branch_name").ToString();
                cboNganhang.Text = gridView1.GetRowCellValue(row, "bank_ten").ToString();
                txtGhiChu.Text = gridView1.GetRowCellValue(row, "ghichu").ToString();
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
                dtgKhachHang.DataSource = ds.Tables[0];
                dtgKhachHang.Refresh();
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
                var fResult = CheckSTK(txtSTK.Text.Trim(), ref Error);
                if (fResult == false)
                {
                    if (Error != "")
                    {
                        MessageBox.Show(Error);
                    }
                    else
                    {
                        MessageBox.Show("Đã tồn tại số tài khoản " + txtSTK.Text.Trim() + " trong dữ liệu");
                    }
                    return;
                }
                var bResult = CheckTaiKhoan(txtTenTK.Text.Trim(), ref Error);
                if (bResult == false)
                {
                    if (Error != "")
                    {
                        MessageBox.Show(Error);
                    }
                    else
                    {
                        MessageBox.Show("Đã tồn tại tài khoản " + txtTenTK.Text.Trim() + " trong dữ liệu");
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
                    dtgKhachHang.Refresh();
                    dtgKhachHang.DataSource = ds.Tables[0];
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
                    dtgKhachHang.DataSource = ds.Tables[0];
                    dtgKhachHang.Refresh();
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
                ds.AcceptChanges();
                dtgKhachHang.DataSource = ds.Tables[0];
                dtgKhachHang.Refresh();
                SetControlStatus(Status);
                GetData();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ds.AcceptChanges();
            dtgKhachHang.DataSource = ds.Tables[0];
            dtgKhachHang.Refresh();
            GetData();
        }

        #endregion


    }
}
