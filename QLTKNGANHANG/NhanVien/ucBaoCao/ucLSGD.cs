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
using QLTKNGANHANG.NhanVien.ucBaoCao;

namespace QLTKNGANHANG.ucNhanVien.ucBaoCao
{
    public partial class ucLSGD : DevExpress.XtraEditors.XtraUserControl
    {
        private string hoten;
        private static ucLSGD _instance;
        public static ucLSGD Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucLSGD();
                return _instance;
            }
        }
        #region VARIABLE
        public static string connectionString = @"Data Source = MY-DESKTOP\SQLEXPRESS;Initial Catalog = dbo_bankAccount;User ID = sa;Password = 123";
        DataSet ds;
        SqlConnection conn;
        #endregion
        public ucLSGD()
        {
            InitializeComponent();
        }
        public ucLSGD(string hoten)
        {
            InitializeComponent();
            this.hoten = hoten;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "BAOCAO_DAYS";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TGIAN_BDAU", dtpTGBD.Value);
                cmd.Parameters.AddWithValue("@TGIAN_KTHUC", dtpTGKT.Value);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);

                crpLSGD crs = new crpLSGD();
                crs.SetDataSource(ds.Tables[0]);
                crystalReportViewer1.ReportSource = crs;
                crs.SetParameterValue("NGAYBD", dtpTGBD.Value);
                crs.SetParameterValue("NGAYKT", dtpTGKT.Value);
                crs.SetParameterValue("NGUOITAO", hoten);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
