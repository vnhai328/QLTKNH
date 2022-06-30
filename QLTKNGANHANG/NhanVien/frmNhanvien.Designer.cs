namespace QLTKNGANHANG
{
    partial class frmNhanvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnTrangChu = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnDiaDiem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.btnTKNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnNganHang = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnTheNH = new DevExpress.XtraBars.BarButtonItem();
            this.btnChuyenTien = new DevExpress.XtraBars.BarButtonItem();
            this.btnLSRutTien = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiTK = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogRutTien = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.galleryDropDown1 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnTrangChu,
            this.btnKhachHang,
            this.btnDiaDiem,
            this.barButtonItem7,
            this.btnTKNhanVien,
            this.btnNganHang,
            this.barButtonItem1,
            this.btnTheNH,
            this.btnChuyenTien,
            this.btnLSRutTien,
            this.btnLoaiTK,
            this.btnLogRutTien});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 21;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1343, 193);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Caption = "Trang chủ";
            this.btnTrangChu.Id = 1;
            this.btnTrangChu.ImageOptions.SvgImage = global::QLTKNGANHANG.Properties.Resources.actions_home;
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTrangChu_ItemClick);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Caption = "Khách hàng";
            this.btnKhachHang.Id = 6;
            this.btnKhachHang.ImageOptions.SvgImage = global::QLTKNGANHANG.Properties.Resources.bo_department;
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhachHang_ItemClick);
            // 
            // btnDiaDiem
            // 
            this.btnDiaDiem.Caption = "Địa điểm";
            this.btnDiaDiem.Id = 9;
            this.btnDiaDiem.ImageOptions.SvgImage = global::QLTKNGANHANG.Properties.Resources.customerquicklocations1;
            this.btnDiaDiem.Name = "btnDiaDiem";
            this.btnDiaDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDiaDiem_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Đăng xuất";
            this.barButtonItem7.Id = 11;
            this.barButtonItem7.ImageOptions.SvgImage = global::QLTKNGANHANG.Properties.Resources.encrypt;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // btnTKNhanVien
            // 
            this.btnTKNhanVien.Caption = "Tài khoản nhân viên";
            this.btnTKNhanVien.Id = 12;
            this.btnTKNhanVien.ImageOptions.SvgImage = global::QLTKNGANHANG.Properties.Resources.bo_user1;
            this.btnTKNhanVien.Name = "btnTKNhanVien";
            this.btnTKNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTKNhanVien_ItemClick);
            // 
            // btnNganHang
            // 
            this.btnNganHang.Caption = "Ngân hàng";
            this.btnNganHang.Id = 13;
            this.btnNganHang.ImageOptions.SvgImage = global::QLTKNGANHANG.Properties.Resources.business_bank;
            this.btnNganHang.Name = "btnNganHang";
            this.btnNganHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNganHang_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Trang chủ";
            this.barButtonItem1.Id = 14;
            this.barButtonItem1.ImageOptions.SvgImage = global::QLTKNGANHANG.Properties.Resources.actions_home1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnTheNH
            // 
            this.btnTheNH.Caption = "Thẻ ngân hàng";
            this.btnTheNH.Id = 15;
            this.btnTheNH.ImageOptions.SvgImage = global::QLTKNGANHANG.Properties.Resources.business_creditcard;
            this.btnTheNH.Name = "btnTheNH";
            this.btnTheNH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTheNH_ItemClick);
            // 
            // btnChuyenTien
            // 
            this.btnChuyenTien.Caption = "Chuyển tiền";
            this.btnChuyenTien.Id = 16;
            this.btnChuyenTien.ImageOptions.SvgImage = global::QLTKNGANHANG.Properties.Resources.currency2;
            this.btnChuyenTien.Name = "btnChuyenTien";
            this.btnChuyenTien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChuyenTien_ItemClick);
            // 
            // btnLSRutTien
            // 
            this.btnLSRutTien.Caption = "Lịch sử rút tiền";
            this.btnLSRutTien.Id = 18;
            this.btnLSRutTien.ImageOptions.SvgImage = global::QLTKNGANHANG.Properties.Resources.business_report;
            this.btnLSRutTien.Name = "btnLSRutTien";
            this.btnLSRutTien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLSRutTien_ItemClick);
            // 
            // btnLoaiTK
            // 
            this.btnLoaiTK.Caption = "Loại tài khoản";
            this.btnLoaiTK.Id = 19;
            this.btnLoaiTK.ImageOptions.SvgImage = global::QLTKNGANHANG.Properties.Resources.accounting;
            this.btnLoaiTK.Name = "btnLoaiTK";
            this.btnLoaiTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoaiTK_ItemClick);
            // 
            // btnLogRutTien
            // 
            this.btnLogRutTien.Caption = "Log rút tiền";
            this.btnLogRutTien.Id = 20;
            this.btnLogRutTien.ImageOptions.SvgImage = global::QLTKNGANHANG.Properties.Resources.business_money;
            this.btnLogRutTien.Name = "btnLogRutTien";
            this.btnLogRutTien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogRutTien_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup5,
            this.ribbonPageGroup3,
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Nhân viên";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTrangChu);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTKNhanVien);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnKhachHang);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTheNH);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Quản lý";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnDiaDiem);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnNganHang);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnLoaiTK);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Danh mục";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnChuyenTien);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnLogRutTien);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Giao dịch";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnLSRutTien);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Báo cáo";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.barButtonItem7);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 757);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1343, 30);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // galleryDropDown1
            // 
            // 
            // 
            // 
            galleryItemGroup1.Caption = "Group1";
            this.galleryDropDown1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.galleryDropDown1.Name = "galleryDropDown1";
            this.galleryDropDown1.Ribbon = this.ribbonControl1;
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Location = new System.Drawing.Point(0, 199);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1343, 552);
            this.pnlMain.TabIndex = 2;
            // 
            // frmNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 787);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmNhanvien";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Quản lý tài khoản ngân hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhanvien_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btnTrangChu;
        private DevExpress.XtraBars.BarButtonItem btnKhachHang;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown1;
        private DevExpress.XtraBars.BarButtonItem btnDiaDiem;
        private System.Windows.Forms.Panel pnlMain;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnTKNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnNganHang;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnTheNH;
        private DevExpress.XtraBars.BarButtonItem btnChuyenTien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnLSRutTien;
        private DevExpress.XtraBars.BarButtonItem btnLoaiTK;
        private DevExpress.XtraBars.BarButtonItem btnLogRutTien;
    }
}