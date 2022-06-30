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
    public partial class frmDoiPin : DevExpress.XtraEditors.XtraForm
    {
        #region VARIABLE
        private static string connectionString = @"Data Source = MY-DESKTOP\SQLEXPRESS;Initial Catalog = dbo_bankAccount;User ID = sa;Password = 123";
        private static SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand cmd;
        SqlDataAdapter da;
        #endregion
        public frmDoiPin(string soTK)
        {
            InitializeComponent();
            txtSoTK.Text = soTK;
        }
        #region FUNCTIONS
        private int check_Pin()
        {
            int check_pin = 0;
            if (txtPinMoi1.Text == "" || txtPinMoi2.Text == "")
            {
                MessageBox.Show("Mã pin gồm 6 số");
                return check_pin;
            }
            else
            {
                if (txtPinMoi1.Text == txtPinMoi2.Text)
                {
                    check_pin = 1;
                    return check_pin;
                }
                else
                {
                    MessageBox.Show("Nhập lại sai mã pin mới");
                    return check_pin;
                }
            }
        }

        private void doi_Pin()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "update tbl_creditCard set pin = N'" + txtPinMoi1.Text + "' where soTK = N'" + txtSoTK.Text + "'";
                if (check_Pin() == 1)
                {
                    cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đổi mã pin thành công");
                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void check_newPIN()
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
                        if (txtPinCu.Text == dr["pin"].ToString())
                        {
                            doi_Pin();
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
        #endregion
        #region EVENTS
        private void btnLuu_Click(object sender, EventArgs e)
        {
            check_newPIN();
        }
        private void txtPinCu_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPinCu.Text, "[^0-9]"))
            {
                MessageBox.Show("Chỉ sử dụng số!!");
                txtPinCu.Text = txtPinCu.Text.Remove(txtPinCu.Text.Length - 1);
            }
        }

        private void txtPinMoi1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPinMoi1.Text, "[^0-9]"))
            {
                MessageBox.Show("Chỉ sử dụng số!!");
                txtPinMoi1.Text = txtPinMoi1.Text.Remove(txtPinMoi1.Text.Length - 1);
            }
        }

        private void txtPinMoi2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPinMoi2.Text, "[^0-9]"))
            {
                MessageBox.Show("Chỉ sử dụng số!!");
                txtPinMoi2.Text = txtPinMoi2.Text.Remove(txtPinMoi2.Text.Length - 1);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}