using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLTKNGANHANG.KhachHang
{
    public partial class frmKhachhang : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        #region VARIABLE
        private static string connectionString = @"Data Source = MY-DESKTOP\SQLEXPRESS;Initial Catalog = dbo_bankAccount;User ID = sa;Password = 123";
        private static SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        #endregion
        public frmKhachhang(int customerID)
        {
            InitializeComponent();
            txtMaKH.Text = customerID.ToString();
            load_cbbCreditCard();
            load_Data();
            setState("Reset");
        }
        #region FUNCTION
        private void setState(string State)
        {
            switch (State)
            {
                case "Reset":
                    txtNamsinh.Enabled = false;
                    txtDienthoai.Enabled = false;
                    txtEmail.Enabled = false;

                    btnChuyenTien.Visible = true;
                    btnRutTien.Visible = true;
                    btnCTTK.Visible = true;
                    btnLuu.Visible = false;
                    btnHuy.Visible = false;

                    btnChuyenTien.Enabled = true;
                    btnRutTien.Enabled = true;
                    btnCTTK.Enabled = true;
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                    break;

                case "Update":
                    txtNamsinh.Enabled = true;
                    txtDienthoai.Enabled = true;
                    txtEmail.Enabled = true;

                    btnChuyenTien.Visible = false;
                    btnRutTien.Visible = false;
                    btnCTTK.Visible = false;
                    btnLuu.Visible = true;
                    btnHuy.Visible = true;

                    btnChuyenTien.Enabled = false;
                    btnRutTien.Enabled = false;
                    btnCTTK.Enabled = false;
                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;
                    break;
            }
        }

        private void load_cbbCreditCard()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "select soTK from tbl_creditCard where customer_id = '" + int.Parse(txtMaKH.Text) + "'";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                if (dt != null && dt.Rows.Count > 0)
                {
                    cbbThe.DataSource = dt;
                    cbbThe.ValueMember = "soTK";
                    cbbThe.DisplayMember = "soTK";
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void load_Balance()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "select current_balance from tbl_creditCard where soTK = '" + cbbThe.SelectedValue.ToString() + "'";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
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

        private void load_Data()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "select hoten, soCMND, namsinh, dienthoai, email from tbl_customer where customer_id = '" + int.Parse(txtMaKH.Text) + "'";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        labHoten.Text = dr["hoten"].ToString();
                        txtSoCMND.Text = dr["soCMND"].ToString();
                        txtNamsinh.Text = dr["namsinh"].ToString();
                        txtDienthoai.Text = dr["dienthoai"].ToString();
                        txtEmail.Text = dr["email"].ToString();
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

        private void update_Infor()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "update tbl_customer set namsinh = " + txtNamsinh.Text + ", dienthoai = N'" + txtDienthoai.Text + "', email = N'" + txtEmail.Text + "' " +
                    "where customer_id = " + int.Parse(txtMaKH.Text) + "";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                load_Data();
                setState("Reset");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region EVENTS
        private void cbbThe_Leave(object sender, EventArgs e)
        {
            load_Balance();
        }

        private void aceDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChuyenTien_Click(object sender, EventArgs e)
        {
            string so_tk = cbbThe.SelectedValue.ToString();
            frmchuyen fc = new frmchuyen(so_tk);
            fc.ShowDialog();
        }

        private void btnRutTien_Click(object sender, EventArgs e)
        {
            string so_tk = cbbThe.SelectedValue.ToString();
            frmrut fr = new frmrut(so_tk);
            fr.ShowDialog();
        }

        private void btnCTTK_Click(object sender, EventArgs e)
        {
            string so_tk = cbbThe.SelectedValue.ToString();
            frmCT frm_ct = new frmCT(so_tk);
            frm_ct.ShowDialog();
        }

        private void aceDoiThongTin_Click(object sender, EventArgs e)
        {
            setState("Update");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            load_Data();
            setState("Reset");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            update_Infor();
        }

        private void aceDoiMaPin_Click(object sender, EventArgs e)
        {
            string so_tk = cbbThe.SelectedValue.ToString();
            frmDoiPin fdp = new frmDoiPin(so_tk);
            fdp.ShowDialog();
        }

        private void aceDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMK fdmk = new frmDoiMK(int.Parse(txtMaKH.Text));
            fdmk.ShowDialog();
        }
        #endregion
    }
}
