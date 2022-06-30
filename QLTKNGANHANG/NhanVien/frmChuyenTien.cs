using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using QLTKNGANHANG.ucQuanLy;

namespace QLTKNGANHANG.ucNhanVien
{
    public partial class frmChuyenTien : DevExpress.XtraEditors.XtraForm
    {
        private string hoten;
        private int staff_id;
        int permit;
        #region VARIABLE
        public static string connectionString = @"Data Source = MY-DESKTOP\SQLEXPRESS;Initial Catalog = dbo_bankAccount;User ID = sa;Password = 123";
        DataSet ds;
        public static string Status = "";
        public static string Error = "";
        SqlConnection conn;
        #endregion
        public frmChuyenTien(int staff_id,string hoten, int permit)
        {
            this.staff_id = staff_id;
            this.hoten = hoten;
            this.permit = permit;
            InitializeComponent();
            LoadChiNhanh();
            lblStatus.Text = "";
        }

        public void load_TK()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "select hoten from tbl_customer, tbl_creditCard where tbl_customer.customer_id = tbl_creditCard.customer_id and soTK = N'"+ txtsoTK.Text +"'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        txtChuTK.Text = dr["hoten"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại");
                    txtsoTK.Text = "";
                }
                cmd.Dispose();
                conn.Close();
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
        #region FUNCTION
        public bool InsertData(ref string strError)
        {
            try
            {
                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query2 = "INSERT_tbl_guiTien";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);

                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@gui_hoten", txtHoten.Text);
                cmd2.Parameters.AddWithValue("@soCMND", txtCMND.Text);
                cmd2.Parameters.AddWithValue("@gui_tien", txtSoTien.Text);
                cmd2.Parameters.AddWithValue("@gui_soTK", txtsoTK.Text);
                cmd2.Parameters.AddWithValue("@noidung", txtND.Text);
                cmd2.Parameters.AddWithValue("@gui_ngay", DateTime.Now);
                cmd2.Parameters.AddWithValue("@staff_id", staff_id);
                cmd2.Parameters.AddWithValue("@branch_id", cboChiNhanh.SelectedValue);

                cmd2.ExecuteNonQuery();
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
            if (txtHoten != null && txtHoten.Text.Trim() != "")
            {

            }
            else
            {
                MessageBox.Show("Chưa tên khách hàng!");
                txtHoten.Focus();
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
            if (txtSoTien != null && txtSoTien.Text.Trim() != "")
            {

            }
            else
            {
                MessageBox.Show("Chưa nhập số tiền!");
                txtSoTien.Focus();
                return false;
            }
            return true;
        }
        #endregion
        #region EVENTS
        private void btnGui_Click(object sender, EventArgs e)
        {
            var cResult = IsValid();
            if (cResult == false)
            {
                return;
            }
            var dResult = InsertData(ref Error);
            if (dResult == false)
            {
                lblStatus.Text = "Chuyển tiền thất bại";
            }
            else
            {
                Status = "Reset";
                ds.AcceptChanges();
                ds.Reset();
                lblStatus.Text = "Chuyển tiền thành công";

            }
        }
        private void txtsoTK_Leave(object sender, EventArgs e)
        {
            load_TK();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}