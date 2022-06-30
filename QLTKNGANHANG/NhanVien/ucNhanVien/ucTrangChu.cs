using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLTKNGANHANG.ucHOME
{
    public partial class ucTrangChu : UserControl
    {
        private static ucTrangChu _instance;
        public static ucTrangChu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucTrangChu();
                return _instance;
            }
        }
        #region variable
        public static string connectionString = @"Data Source = MY-DESKTOP\SQLEXPRESS;Initial Catalog = dbo_bankAccount;User ID = sa;Password = 123";
        DataSet ds;
        public static string Status = "";
        public static string Error = "";
        SqlConnection conn;
        #endregion
        public ucTrangChu()
        {
            InitializeComponent();
            GetData();

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
                string query = "SELECT soTK, sodu, MONTH (logBalance_date) AS THANG, logBalance_date FROM tbl_logBalance WHERE logBalance_date BETWEEN '2020-1-1' AND '2020-12-31'";
                SqlCommand cmd = new SqlCommand(query, conn);
                ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    chartControl1.DataSource = ds.Tables[0];
 
                    // VẼ BIỂU ĐỒ THỐNG KÊ SỐ LƯỢNG HỌC VIÊN
                    for (int i = 0; i < 12; i++)
                    {               
                        DataRow drNew = ds.Tables[0].NewRow();
                        drNew["THANG"] = (i + 1).ToString();
                        drNew["sodu"] = 0;
                    }
                    ds.Tables[0].AcceptChanges();

                    //Lấy dữ liệu trong sql

                    DataTable dtDb = new DataTable();
                    foreach (DataRow dr1 in ds.Tables[0].Rows)
                    {
                        {
                            foreach (DataRow dr2 in dtDb.Rows)
                            {
                                if (dr1["THANG"].ToString() == dr2["THANG"].ToString())
                                {
                                    dr1["sodu"] = dr2["sodu"];
                                }
                            }
                        }
                    }
                    chartControl1.DataSource = ds.Tables[0];
                }
                else
                {
                    chartControl1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
