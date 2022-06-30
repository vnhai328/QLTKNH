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

namespace QLTKNGANHANG
{
    public partial class frmDoiMK : DevExpress.XtraEditors.XtraForm
    {
        #region VAR
        private static string connectionString = @"Data Source = MY-DESKTOP\SQLEXPRESS;Initial Catalog = dbo_bankAccount;User ID = sa;Password = 123";
        private static SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand cmd;
        SqlDataAdapter da;
   
        #endregion
        public frmDoiMK(int customerID)
        {
            InitializeComponent();
            labCustomerID.Text = customerID.ToString();
        }
        #region FUNCTIONS
        private int check_newMK()
        {
            int check_MK = 0;
            if (txtMKmoi1.Text == "" || txtMKmoi2.Text == "")
            {
                return check_MK;
            }
            else if (txtMKmoi1.Text != txtMKmoi2.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu mới không đúng");
                return check_MK;
            }
            else
            {
                check_MK = 1;
                return check_MK;
            }
        }
        private void update_MK()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "update tbl_customer set customer_password = N'" + txtMKmoi1.Text + "' where customer_id = N'" + labCustomerID.Text + "'";
                if (check_newMK() == 1)
                {
                    cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đổi mật khẩu thành công");
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void doi_MK()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "select customer_password from tbl_customer where customer_id = N'" + labCustomerID.Text + "'";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null && dt.Rows.Count == 1)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (txtMKcu.Text == dr["customer_password"].ToString())
                        {
                            update_MK();
                        }
                        else
                        {
                            MessageBox.Show("Nhập mật khẩu sai. Mời nhập lại");
                        }
                    }
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            doi_MK();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}