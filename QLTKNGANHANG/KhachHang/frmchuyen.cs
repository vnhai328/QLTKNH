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
    public partial class frmchuyen : DevExpress.XtraEditors.XtraForm
    {
        #region VARIABLE
        private static string connectionString = @"Data Source = MY-DESKTOP\SQLEXPRESS;Initial Catalog = dbo_bankAccount;User ID = sa;Password = 123";
        private static SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand cmd;
        SqlDataAdapter da;
        #endregion
        public frmchuyen(string soTK)
        {
            InitializeComponent();
            txtChuyen.Text = soTK;
            load_Chuyen();
        }
        #region Functions
        private void load_Chuyen()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "select hoten, current_balance from tbl_customer, tbl_creditCard where tbl_customer.customer_id = tbl_creditCard.customer_id and soTK = N'" + txtChuyen.Text + "'";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        txtHoten1.Text = dr["hoten"].ToString();
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

        private void load_Nhan()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "select hoten from tbl_customer, tbl_creditCard where tbl_customer.customer_id = tbl_creditCard.customer_id and soTK = N'" + txtNhan.Text + "'";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        txtHoten2.Text = dr["hoten"].ToString();
                    }
                }
                else
                {
                    txtNhan.Text = "";
                    txtHoten2.Text = "";
                    MessageBox.Show("Không tìm thấy số tài khoản vừa nhập!");
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chuyen_Tien()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "insert into tbl_chuyenTien values" +
                    " (N'" + txtChuyen.Text + "', N'" + txtNhan.Text + "', " + Convert.ToDouble(txtSotien.Text) + " , getdate(), N'" + txtNoidung.Text + "', null)";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Chuyển tiền thành công");
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region EVENTS
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

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "select pin from tbl_creditCard where soTK = N'" + txtChuyen.Text + "'";
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
                            chuyen_Tien();
                        }
                        else
                        {
                            MessageBox.Show("Nhập mã pin sai. Vui lòng kiểm tra lại!");
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

        private void txtNhan_Leave(object sender, EventArgs e)
        {
            load_Nhan();
        }
        #endregion
    }
}