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
    public partial class frmrut : DevExpress.XtraEditors.XtraForm
    {
        #region VARIABLE
        private static string connectionString = @"Data Source = MY-DESKTOP\SQLEXPRESS;Initial Catalog = dbo_bankAccount;User ID = sa;Password = 123";
        private static SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand cmd;
        SqlDataAdapter da;
        #endregion
        public frmrut(string soTK)
        {
            InitializeComponent();
            txtSoTK.Text = soTK;
            load_chuTK();
        }
        #region FUNCTIONS
        private void load_chuTK()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "select hoten, current_balance from tbl_customer, tbl_creditCard where tbl_customer.customer_id = tbl_creditCard.customer_id and soTK = N'" + txtSoTK.Text + "'";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        txtHoten.Text = dr["hoten"].ToString();
                        txtSodu.Text = dr["current_balance"].ToString();
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

        private void rut_Tien()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "insert into tbl_rutTien values (N'" + txtSoTK.Text + "', " + Convert.ToDouble(txtSotien.Text) + ", getdate(), null)";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Rút tiền thành công");
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region EVETNS
        private void txtSotien_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSotien.Text, "[^0-9]"))
            {
                MessageBox.Show("Số tiền chỉ sử dụng số!!");
                txtSotien.Text = txtSotien.Text.Remove(txtSotien.Text.Length - 1);
            }
        }

        private void txtPin_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPin.Text, "[^0-9]"))
            {
                MessageBox.Show("Mã pin chỉ sử dụng số!!");
                txtPin.Text = txtPin.Text.Remove(txtPin.Text.Length - 1);
            }
        }

        private void btnRut_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "select pin from tbl_creditCard where soTK = N'" + txtSoTK.Text + "'";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null && dt.Rows.Count == 1)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (txtPin.Text == dr["pin"].ToString())
                        {
                            rut_Tien();
                        }
                        else
                        {
                            MessageBox.Show("Nhập mã pin sai. Mời nhập lại");
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}