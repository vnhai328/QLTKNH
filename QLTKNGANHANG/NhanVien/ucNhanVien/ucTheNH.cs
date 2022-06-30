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
    public partial class ucTheNH : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucTheNH _instance;
        public static ucTheNH Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucTheNH();
                return _instance;
            }
        }
        #region VARIABLE
        public static string connectionString = @"Data Source = MY-DESKTOP\SQLEXPRESS;Initial Catalog = dbo_bankAccount;User ID = sa;Password = 123";
        DataSet ds;
        public static string Status = "";
        public static string Error = "";
        SqlConnection conn;
        #endregion
        public ucTheNH()
        {
            InitializeComponent();
            GetData();
            LoadBank();
            LoadLoaiTK();
            LoadChiNhanh();
            LoadKH();
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
                string query = "SELECT ROW_NUMBER() OVER (ORDER BY A.soTK) AS STT, A.soTK ,A.pin, B.hoten, C.loaiTK_ten, D.bank_ten, E.branch_name, A.current_balance, A.ghichu FROM tbl_creditCard A, tbl_customer B, tbl_loaiTK C, tbl_bank D, tbl_branch E WHERE A.customer_id = B.customer_id AND A.loaiTK_id = C.loaiTK_id AND A.bank_id = D.bank_id AND A.branch_id = E.branch_id";
                SqlCommand cmd = new SqlCommand(query, conn);
                ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    //dtgKhachHang.AutoGenerateColumns = false;
                    dtgTheNH.DataSource = ds.Tables[0];
                    lblTong.Text = "Tổng số: " + ds.Tables[0].Rows.Count + " bản ghi";

                    DataRow dr0 = ds.Tables[0].Rows[0];
                    
                    txtSTK.Text = dr0["soTK"].ToString();
                    txtPin.Text = dr0["pin"].ToString();
                    cboLoaiTK.Text = dr0["loaiTK_ten"].ToString();
                    cboTenNH.Text = dr0["bank_ten"].ToString();
                    cboChiNhanh.Text = dr0["branch_name"].ToString();
                    string sodu = dr0["current_balance"].ToString();
                    string[] arrListStr = sodu.Split(',');
                    txtSodu.Text = arrListStr[0];
                    cboKhachHang.Text = dr0["hoten"].ToString();
                    txtGhiChu.Text = dr0["ghichu"].ToString();
                }
                else
                {
                    dtgTheNH.DataSource = null;
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
                    cboTenNH.ValueMember = "bank_id";
                    cboTenNH.DisplayMember = "bank_ten";
                    cboTenNH.DataSource = ds.Tables[0];
                }
                else
                {
                    cboTenNH.DataSource = null;
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
        public void LoadKH()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "SELECT * FROM tbl_customer";
                SqlCommand cmd = new SqlCommand(query, conn);
                ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    cboKhachHang.ValueMember = "customer_id";
                    cboKhachHang.DisplayMember = "hoten";
                    cboKhachHang.DataSource = ds.Tables[0];
                }
                else
                {
                    cboKhachHang.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

                    txtSTK.Enabled = false;
                    txtPin.Enabled = false;
                    cboLoaiTK.Enabled = false;
                    cboTenNH.Enabled = false;
                    cboChiNhanh.Enabled = false;
                    txtSodu.Enabled = false;
                    cboKhachHang.Enabled = false;
                    txtGhiChu.Enabled = false;

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhi.Enabled = false;
                    btnHuy.Enabled = false;
                    btnRefreshh.Enabled = true;
                     
                    break;
                case "Insert":
                    lblError.Text = "";
                    lblStatus.Text = "";

                    txtSTK.Enabled = true;
                    txtPin.Enabled = true;
                    cboLoaiTK.Enabled = true;
                    cboTenNH.Enabled = true;
                    cboChiNhanh.Enabled = true;
                    txtSodu.Enabled = true;
                    cboKhachHang.Enabled = true;
                    txtGhiChu.Enabled = true;

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuy.Enabled = true;
                    btnRefreshh.Enabled = false;

                    txtSTK.Text = "";
                    txtPin.Text = "";
                    cboLoaiTK.Text = "";
                    cboChiNhanh.Text = "";
                    cboTenNH.Text = "";
                    txtSodu.Text = "";
                    cboKhachHang.Text = "";
                    txtGhiChu.Text = "";
                    txtSTK.Focus();
                    break;
                case "Update":
                    lblError.Text = "";
                    lblStatus.Text = "";

                    txtSTK.Enabled = false;
                    txtPin.Enabled = true;
                    cboLoaiTK.Enabled = true;
                    cboTenNH.Enabled = true;
                    cboChiNhanh.Enabled = true;
                    txtSodu.Enabled = true;
                    cboKhachHang.Enabled = false;
                    txtGhiChu.Enabled = true;

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuy.Enabled = true;
                    btnRefreshh.Enabled = false;

                    txtPin.Focus();
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
                string query2 = "INSERT_tbl_creditCard";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);

                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@soTK", txtSTK.Text);
                cmd2.Parameters.AddWithValue("@pin", 123456);
                cmd2.Parameters.AddWithValue("@loaiTK_id", cboLoaiTK.SelectedValue);
                cmd2.Parameters.AddWithValue("@customer_id", cboKhachHang.SelectedValue);
                cmd2.Parameters.AddWithValue("@bank_id", cboTenNH.SelectedValue);
                cmd2.Parameters.AddWithValue("@branch_id", cboChiNhanh.SelectedValue);
                cmd2.Parameters.AddWithValue("@current_balance", txtSodu.Text);
                cmd2.Parameters.AddWithValue("@date_opened", DateTime.Now);
                cmd2.Parameters.AddWithValue("@active", 1);
                cmd2.Parameters.AddWithValue("@ghichu", "CREATE");

                cmd2.ExecuteNonQuery();
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
                string query2 = "UPDATE_tbl_creditCard";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);

                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@soTK", txtSTK.Text);
                cmd2.Parameters.AddWithValue("@pin", txtPin.Text);
                cmd2.Parameters.AddWithValue("@loaiTK_id", cboLoaiTK.SelectedValue);
                cmd2.Parameters.AddWithValue("@bank_id", cboTenNH.SelectedValue);
                cmd2.Parameters.AddWithValue("@branch_id", cboChiNhanh.SelectedValue);
                cmd2.Parameters.AddWithValue("@current_balance", txtSodu.Text);
                cmd2.Parameters.AddWithValue("@ghichu", "UPDATE");

                cmd2.ExecuteNonQuery();

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
                string query2 = "DELETE_tbl_creditCard";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);

                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@soTK", txtSTK.Text);
                cmd2.Parameters.AddWithValue("@active", 0);
                cmd2.Parameters.AddWithValue("@date_closed", DateTime.Now);
                cmd2.Parameters.AddWithValue("@ghichu", "Closed");
                cmd2.Parameters.AddWithValue("@mota", "Closed");
                cmd2.ExecuteNonQuery();

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
        public bool CheckSTK(string TaiKhoan, ref string strError)
        {
            try
            {
                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "SELECT * FROM tbl_creditCard WHERE soTK = '" + TaiKhoan + "'";
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
            if (txtSTK != null && txtSTK.Text.Trim() != "")
            {

            }
            else
            {
                MessageBox.Show("Chưa nhập số tài khoản!");
                txtSTK.Focus();
                return false;
            }
            if (cboLoaiTK != null && cboLoaiTK.Text.Trim() != "")
            {

            }
            else
            {
                MessageBox.Show("Chưa chọn loại tài khoản!");
                cboLoaiTK.Focus();
                return false;
            }
            if (cboChiNhanh != null && cboChiNhanh.Text.Trim() != "")
            {

            }
            else
            {
                MessageBox.Show("Chưa chọn chi nhánh!");
                cboLoaiTK.Focus();
                return false;
            }
            if (cboTenNH != null && cboTenNH.Text.Trim() != "")
            {

            }
            else
            {
                MessageBox.Show("Chưa chọn ngân hàng!");
                cboTenNH.Focus();
                return false;
            }
            if (cboKhachHang != null && cboKhachHang.Text.Trim() != "")
            {

            }
            else
            {
                MessageBox.Show("Chưa chọn khách hàng!");
                cboKhachHang.Focus();
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

                ds.AcceptChanges();
                dtgTheNH.DataSource = ds.Tables[0];
                dtgTheNH.Refresh();
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
                var bResult = CheckSTK(txtSTK.Text.Trim(), ref Error);
                if (bResult == false)
                {
                    if (Error != "")
                    {
                        MessageBox.Show(Error);
                    }
                    else
                    {
                        MessageBox.Show("Đã tồn tại tài khoản " + txtSTK.Text.Trim() + " trong dữ liệu");
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
                    dtgTheNH.Refresh();
                    dtgTheNH.DataSource = ds.Tables[0];
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
                    dtgTheNH.DataSource = ds.Tables[0];
                    dtgTheNH.Refresh();
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
                dtgTheNH.DataSource = ds.Tables[0];
                dtgTheNH.Refresh();
                SetControlStatus(Status);
                GetData();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void dtgTheNH_MouseDown(object sender, MouseEventArgs e)
        {
            GridHitInfo info = gridView1.CalcHitInfo(e.Location);
            if (info.InRowCell)
            {
                int row = info.RowHandle;
                GridColumn column = info.Column;
                txtSTK.Text = gridView1.GetRowCellValue(row, "soTK").ToString();
                txtPin.Text = gridView1.GetRowCellValue(row, "pin").ToString();
                string sodu = gridView1.GetRowCellValue(row, "current_balance").ToString();
                string[] arrListStr = sodu.Split(',');
                txtSodu.Text = arrListStr[0].ToString();
                cboKhachHang.Text = gridView1.GetRowCellValue(row, "hoten").ToString();
                cboTenNH.Text = gridView1.GetRowCellValue(row, "bank_ten").ToString();
                cboLoaiTK.Text = gridView1.GetRowCellValue(row, "loaiTK_ten").ToString();
                cboChiNhanh.Text = gridView1.GetRowCellValue(row, "branch_name").ToString();
                txtGhiChu.Text = gridView1.GetRowCellValue(row, "ghichu").ToString();
            }
        }
        private void btnRefreshh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ds.AcceptChanges();
            dtgTheNH.DataSource = ds.Tables[0];
            dtgTheNH.Refresh();
            GetData();
        }

        #endregion


    }
}
