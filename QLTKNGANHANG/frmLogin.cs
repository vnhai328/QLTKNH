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

namespace QLTKNGANHANG.KhachHang
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private static string connectionString = @"Data Source = MY-DESKTOP\SQLEXPRESS;Initial Catalog = dbo_bankAccount;User ID = sa;Password = 123";
        private static SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand cmd;
        SqlDataAdapter da;
        public frmLogin()
        {
            InitializeComponent();
        }
        #region FUNCTION
        private void login_Staff()
        {
            try
            {
                conn.Open();
                string query = "select staff_id, hoten, staff_username, staff_password, permit from tbl_staff " +
                    "where staff_username = N'" + txtUsername1.Text + "' and staff_password = N'" + txtPassword1.Text + "'";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null && dt.Rows.Count == 1)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        int staff_id = Convert.ToInt32(dr["staff_id"]);
                        string ho_ten = dr["hoten"].ToString();
                        int permit = Convert.ToInt32(dr["permit"]);
                        MessageBox.Show("Đăng nhập thành công!");
                        this.Hide();
                        frmNhanvien fnv = new frmNhanvien(staff_id, ho_ten,permit);
                        fnv.ShowDialog();
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng kiểm tra lại!");
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void login_Customer()
        {
            try
            {
                conn.Open();
                string query = "select customer_id, customer_username, customer_password from tbl_customer " +
                    "where customer_username = N'" + txtUsername2.Text + "' and customer_password = N'" + txtPassword2.Text + "'";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null && dt.Rows.Count == 1)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        int customer_id = Convert.ToInt32(dr["customer_id"]);
                        MessageBox.Show("Đăng nhập thành công!");
                        this.Hide();
                        frmKhachhang fkh = new frmKhachhang(customer_id);
                        fkh.ShowDialog();
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng kiểm tra lại!");
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Events
        private void btnLoginNV_Click(object sender, EventArgs e)
        {
            login_Staff();
        }

        private void btnLoginKH_Click(object sender, EventArgs e)
        {
            login_Customer();
        }
        #endregion
    }
}