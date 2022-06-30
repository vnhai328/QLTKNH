using DevExpress.XtraEditors;
using QLTKNGANHANG.ucDanhMuc;
using QLTKNGANHANG.ucHOME;
using QLTKNGANHANG.ucNhanVien;
using QLTKNGANHANG.ucNhanVien.ucBaoCao;
using QLTKNGANHANG.ucQuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTKNGANHANG
{
    public partial class frmNhanvien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string hoten;
        private int staff_id;
        private int permit;
        public frmNhanvien(int staff_id, string hoten, int permit)
        {
            this.hoten = hoten;
            this.staff_id = staff_id;
            this.permit = permit;
            InitializeComponent();
            LOADHOME();
        }
        public void LOADHOME()
        {
            if(permit == 0)
            {
                btnTKNhanVien.Enabled = true;
            }
            else
            {
                btnTKNhanVien.Enabled = false;
            }
            if (!pnlMain.Controls.Contains(ucTrangChu.Instance))
            {
                pnlMain.Controls.Add(ucTrangChu.Instance);
                ucTrangChu.Instance.Dock = DockStyle.Fill;
                ucTrangChu.Instance.BringToFront();
            }
            else
            {
                ucTrangChu.Instance.BringToFront();
            }
        }
        #region Home
        private void btnTrangChu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!pnlMain.Controls.Contains(ucTrangChu.Instance))
            {
                pnlMain.Controls.Add(ucTrangChu.Instance);
                ucTrangChu.Instance.Dock = DockStyle.Fill;
                ucTrangChu.Instance.BringToFront();
            }
            else
            {
                ucTrangChu.Instance.BringToFront();
            }
        }
        #endregion
        #region NhanVien
        private void btnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!pnlMain.Controls.Contains(ucKhachHang.Instance))
            {
                pnlMain.Controls.Add(ucKhachHang.Instance);
                ucKhachHang.Instance.Dock = DockStyle.Fill;
                ucKhachHang.Instance.BringToFront();
            }
            else
            {
                ucKhachHang.Instance.BringToFront();
            }
        }

        private void btnDiaDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!pnlMain.Controls.Contains(ucDiaDiem.Instance))
            {
                pnlMain.Controls.Add(ucDiaDiem.Instance);
                ucDiaDiem.Instance.Dock = DockStyle.Fill;
                ucDiaDiem.Instance.BringToFront();
            }
            else
            {
                ucDiaDiem.Instance.BringToFront();
            }
        }

        private void btnTKNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!pnlMain.Controls.Contains(ucTKNhanVien.Instance))
            {
                pnlMain.Controls.Add(ucTKNhanVien.Instance);
                ucTKNhanVien.Instance.Dock = DockStyle.Fill;
                ucTKNhanVien.Instance.BringToFront();
            }
            else
            {
                ucTKNhanVien.Instance.BringToFront();
            }
        }
        private void btnTheNH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!pnlMain.Controls.Contains(ucTheNH.Instance))
            {
                pnlMain.Controls.Add(ucTheNH.Instance);
                ucTheNH.Instance.Dock = DockStyle.Fill;
                ucTheNH.Instance.BringToFront();
            }
            else
            {
                ucTheNH.Instance.BringToFront();
            }
        }
        private void btnNganHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!pnlMain.Controls.Contains(ucNganHang.Instance))
            {
                pnlMain.Controls.Add(ucNganHang.Instance);
                ucNganHang.Instance.Dock = DockStyle.Fill;
                ucNganHang.Instance.BringToFront();
            }
            else
            {
                ucNganHang.Instance.BringToFront();
            }
        }
        private void btnChuyenTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChuyenTien fct = new frmChuyenTien(staff_id,hoten,permit);
            fct.ShowDialog();
        }
        private void btnTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!pnlMain.Controls.Contains(ucLogTien.Instance))
            {
                pnlMain.Controls.Add(ucLogTien.Instance);
                ucLogTien.Instance.Dock = DockStyle.Fill;
                ucLogTien.Instance.BringToFront();
            }
            else
            {
                ucLogTien.Instance.BringToFront();
            }
        }
        private void btnLoaiTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!pnlMain.Controls.Contains(ucLoaiTK.Instance))
            {
                pnlMain.Controls.Add(ucLoaiTK.Instance);
                ucLoaiTK.Instance.Dock = DockStyle.Fill;
                ucLoaiTK.Instance.BringToFront();
            }
            else
            {
                ucLoaiTK.Instance.BringToFront();
            }
        }
        private void btnLogRutTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!pnlMain.Controls.Contains(ucLogRutTien.Instance))
            {
                pnlMain.Controls.Add(ucLogRutTien.Instance);
                ucLogRutTien.Instance.Dock = DockStyle.Fill;
                ucLogRutTien.Instance.BringToFront();
            }
            else
            {
                ucLogRutTien.Instance.BringToFront();
            }
        }
        private void btnLSRutTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!pnlMain.Controls.Contains(ucLSGD.Instance))
            {
                ucLSGD ucGD = new ucLSGD(hoten);
                pnlMain.Controls.Add(ucGD);
                ucGD.Dock = DockStyle.Fill;
                ucGD.BringToFront();
            }
            else
            {
                ucLSGD ucGD = new ucLSGD(hoten);
                ucGD.BringToFront();
            }
        }

        #endregion

        private void frmNhanvien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        
        }
    }
}
