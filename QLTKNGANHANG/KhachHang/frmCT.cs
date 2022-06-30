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
    public partial class frmCT : DevExpress.XtraEditors.XtraForm
    {
        private static string connectionString = @"Data Source = MY-DESKTOP\SQLEXPRESS;Initial Catalog = dbo_bankAccount;User ID = sa;Password = 123";
        private static SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand cmd;
        SqlDataAdapter da;
        public frmCT(string soTK)
        {
            InitializeComponent();
            txtSoTK.Text = soTK;
            load_Data();
            load_All();
            load_In();
            load_Out();
        }
        private void load_Data()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "select hoten, soCMND, dienthoai, email, soTK, current_balance, loaiTK_ten, bank_ten, branch_name, date_opened " +
                    "from tbl_customer, tbl_creditCard, tbl_bank, tbl_branch, tbl_loaiTK " +
                    "where tbl_customer.customer_id = tbl_creditCard.customer_id and tbl_creditCard.bank_id = tbl_bank.bank_id and " +
                    "tbl_creditCard.branch_id = tbl_branch.branch_id and tbl_creditCard.loaiTK_id = tbl_loaiTK.loaiTK_id and soTK = N'" + txtSoTK.Text + "'";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null && dt.Rows.Count == 1)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        txtHoten.Text = dr["hoten"].ToString();
                        txtSoCMND.Text = dr["soCMND"].ToString();
                        txtDienthoai.Text = dr["dienthoai"].ToString();
                        txtEmail.Text = dr["email"].ToString();
                        txtSodu.Text = dr["current_balance"].ToString();
                        txtLoaiTK.Text = dr["loaiTK_ten"].ToString();
                        txtNH.Text = dr["bank_ten"].ToString();
                        txtCN.Text = dr["branch_name"].ToString();
                        txtNgaymo.Text = Convert.ToDateTime(dr["date_opened"]).ToString("dd/MM/yyyy");
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

        private void load_All()
        {
            try
            {
                conn.Open();
                string query = "select rut_tien as sotien, rut_ngay as ngay from tbl_rutTien where rut_soTK = '" + txtSoTK.Text + "' " +
                    "union all select gui_tien as sotien, gui_ngay as ngay from tbl_guiTien where gui_soTK = '" + txtSoTK.Text + "' " +
                    "union all select chuyen_tien as sotien, chuyen_ngay as ngay from tbl_chuyenTien where chuyen_soTK = '" + txtSoTK.Text + "' " +
                    "union all select chuyen_tien as sotien, chuyen_ngay as ngay from tbl_chuyenTien where nhan_soTK = '" + txtSoTK.Text + "' order by ngay asc";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvAll.DataSource = dt;
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void load_In()
        {
            try
            {
                conn.Open();
                string query = "select gui_tien as money, gui_ngay as date from tbl_guiTien where gui_soTK = '" + txtSoTK.Text + "' union all select chuyen_tien as money, chuyen_ngay as date from tbl_chuyenTien where nhan_soTK = '" + txtSoTK.Text + "' order by date asc";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvIn.DataSource = dt;
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void load_Out()
        {
            try
            {
                conn.Open();
                string query = "select rut_tien as cash, rut_ngay as datetim from tbl_rutTien where rut_soTK = '" + txtSoTK.Text + "' union all select chuyen_tien as cash, chuyen_ngay as datetim from tbl_chuyenTien where chuyen_soTK = '" + txtSoTK.Text + "' order by datetim asc";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvOut.DataSource = dt;
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}