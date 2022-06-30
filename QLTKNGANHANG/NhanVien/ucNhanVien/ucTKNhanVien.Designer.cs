namespace QLTKNGANHANG.ucNhanVien
{
    partial class ucTKNhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.nmrQuyen = new System.Windows.Forms.NumericUpDown();
            this.lblError = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboNamSinh = new System.Windows.Forms.ComboBox();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dtgQLTKNV = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hoten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.soCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.namsinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gioitinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dienthoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.staff_username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.staff_password = new DevExpress.XtraGrid.Columns.GridColumn();
            this.permit = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgQLTKNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnGhi,
            this.btnHuy});
            this.barManager1.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = global::QLTKNGANHANG.Properties.Resources.actions_addcircled;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.SvgImage = global::QLTKNGANHANG.Properties.Resources.actions_edit;
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.SvgImage = global::QLTKNGANHANG.Properties.Resources.close;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi dữ liệu";
            this.btnGhi.Id = 3;
            this.btnGhi.ImageOptions.SvgImage = global::QLTKNGANHANG.Properties.Resources.save_as;
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy bỏ";
            this.btnHuy.Id = 4;
            this.btnHuy.ImageOptions.SvgImage = global::QLTKNGANHANG.Properties.Resources.bo_audit_changehistory;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1394, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 787);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1394, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 757);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1394, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 757);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.nmrQuyen);
            this.groupControl1.Controls.Add(this.lblError);
            this.groupControl1.Controls.Add(this.lblStatus);
            this.groupControl1.Controls.Add(this.lblTong);
            this.groupControl1.Controls.Add(this.txtMK);
            this.groupControl1.Controls.Add(this.txtTK);
            this.groupControl1.Controls.Add(this.txtSDT);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.cboNamSinh);
            this.groupControl1.Controls.Add(this.rdoNu);
            this.groupControl1.Controls.Add(this.rdoNam);
            this.groupControl1.Controls.Add(this.txtCMND);
            this.groupControl1.Controls.Add(this.txtHoTen);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Location = new System.Drawing.Point(3, 36);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1388, 271);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Quản lý tài khoản nhân viên";
            // 
            // nmrQuyen
            // 
            this.nmrQuyen.Location = new System.Drawing.Point(591, 198);
            this.nmrQuyen.Name = "nmrQuyen";
            this.nmrQuyen.Size = new System.Drawing.Size(64, 23);
            this.nmrQuyen.TabIndex = 9;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(513, 240);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(31, 21);
            this.lblError.TabIndex = 38;
            this.lblError.Text = "Lỗi";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStatus.ForeColor = System.Drawing.Color.LightCoral;
            this.lblStatus.Location = new System.Drawing.Point(255, 240);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(86, 21);
            this.lblStatus.TabIndex = 37;
            this.lblStatus.Text = "Trạng thái";
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTong.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTong.Location = new System.Drawing.Point(27, 246);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(47, 21);
            this.lblTong.TabIndex = 36;
            this.lblTong.Text = "Tổng";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(591, 151);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.ReadOnly = true;
            this.txtMK.Size = new System.Drawing.Size(236, 23);
            this.txtMK.TabIndex = 8;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(591, 102);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(236, 23);
            this.txtTK.TabIndex = 7;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(591, 56);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(236, 23);
            this.txtSDT.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(514, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Quyền:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(514, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mật khẩu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(514, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tài khoản:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Giới tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Năm sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "CMND:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Họ tên:";
            // 
            // cboNamSinh
            // 
            this.cboNamSinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNamSinh.FormattingEnabled = true;
            this.cboNamSinh.Location = new System.Drawing.Point(105, 144);
            this.cboNamSinh.Name = "cboNamSinh";
            this.cboNamSinh.Size = new System.Drawing.Size(236, 24);
            this.cboNamSinh.TabIndex = 3;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(294, 194);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(47, 21);
            this.rdoNu.TabIndex = 5;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(105, 196);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(57, 21);
            this.rdoNam.TabIndex = 4;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(105, 102);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(236, 23);
            this.txtCMND.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(105, 56);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(236, 23);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(779, 198);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(48, 23);
            this.txtID.TabIndex = 0;
            this.txtID.Visible = false;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.dtgQLTKNV);
            this.groupControl2.Location = new System.Drawing.Point(3, 313);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1388, 471);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Danh sách tài khoản nhân viên";
            // 
            // dtgQLTKNV
            // 
            this.dtgQLTKNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgQLTKNV.Location = new System.Drawing.Point(5, 31);
            this.dtgQLTKNV.MainView = this.gridView1;
            this.dtgQLTKNV.MenuManager = this.barManager1;
            this.dtgQLTKNV.Name = "dtgQLTKNV";
            this.dtgQLTKNV.Size = new System.Drawing.Size(1383, 440);
            this.dtgQLTKNV.TabIndex = 10;
            this.dtgQLTKNV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dtgQLTKNV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtgQLTKNV_MouseDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.hoten,
            this.soCMND,
            this.namsinh,
            this.gioitinh,
            this.dienthoai,
            this.staff_username,
            this.staff_password,
            this.permit});
            this.gridView1.GridControl = this.dtgQLTKNV;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // STT
            // 
            this.STT.AppearanceCell.Options.UseTextOptions = true;
            this.STT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.AppearanceHeader.Options.UseTextOptions = true;
            this.STT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.MinWidth = 25;
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 94;
            // 
            // hoten
            // 
            this.hoten.AppearanceCell.Options.UseTextOptions = true;
            this.hoten.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.hoten.AppearanceHeader.Options.UseTextOptions = true;
            this.hoten.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.hoten.Caption = "Họ tên";
            this.hoten.FieldName = "hoten";
            this.hoten.MinWidth = 25;
            this.hoten.Name = "hoten";
            this.hoten.Visible = true;
            this.hoten.VisibleIndex = 1;
            this.hoten.Width = 179;
            // 
            // soCMND
            // 
            this.soCMND.AppearanceCell.Options.UseTextOptions = true;
            this.soCMND.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.soCMND.AppearanceHeader.Options.UseTextOptions = true;
            this.soCMND.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.soCMND.Caption = "CMND";
            this.soCMND.FieldName = "soCMND";
            this.soCMND.MinWidth = 25;
            this.soCMND.Name = "soCMND";
            this.soCMND.Visible = true;
            this.soCMND.VisibleIndex = 2;
            this.soCMND.Width = 179;
            // 
            // namsinh
            // 
            this.namsinh.AppearanceCell.Options.UseTextOptions = true;
            this.namsinh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.namsinh.AppearanceHeader.Options.UseTextOptions = true;
            this.namsinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.namsinh.Caption = "Năm sinh";
            this.namsinh.FieldName = "namsinh";
            this.namsinh.MinWidth = 25;
            this.namsinh.Name = "namsinh";
            this.namsinh.Visible = true;
            this.namsinh.VisibleIndex = 3;
            this.namsinh.Width = 179;
            // 
            // gioitinh
            // 
            this.gioitinh.AppearanceCell.Options.UseTextOptions = true;
            this.gioitinh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gioitinh.AppearanceHeader.Options.UseTextOptions = true;
            this.gioitinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gioitinh.Caption = "Giới tính";
            this.gioitinh.FieldName = "gioitinh";
            this.gioitinh.MinWidth = 25;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Visible = true;
            this.gioitinh.VisibleIndex = 4;
            this.gioitinh.Width = 179;
            // 
            // dienthoai
            // 
            this.dienthoai.AppearanceCell.Options.UseTextOptions = true;
            this.dienthoai.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dienthoai.AppearanceHeader.Options.UseTextOptions = true;
            this.dienthoai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dienthoai.Caption = "SĐT";
            this.dienthoai.FieldName = "dienthoai";
            this.dienthoai.MinWidth = 25;
            this.dienthoai.Name = "dienthoai";
            this.dienthoai.Visible = true;
            this.dienthoai.VisibleIndex = 5;
            this.dienthoai.Width = 179;
            // 
            // staff_username
            // 
            this.staff_username.AppearanceCell.Options.UseTextOptions = true;
            this.staff_username.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.staff_username.AppearanceHeader.Options.UseTextOptions = true;
            this.staff_username.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.staff_username.Caption = "Tài khoản";
            this.staff_username.FieldName = "staff_username";
            this.staff_username.MinWidth = 25;
            this.staff_username.Name = "staff_username";
            this.staff_username.Visible = true;
            this.staff_username.VisibleIndex = 6;
            this.staff_username.Width = 179;
            // 
            // staff_password
            // 
            this.staff_password.AppearanceCell.Options.UseTextOptions = true;
            this.staff_password.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.staff_password.AppearanceHeader.Options.UseTextOptions = true;
            this.staff_password.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.staff_password.Caption = "Mật khẩu";
            this.staff_password.FieldName = "staff_password";
            this.staff_password.MinWidth = 25;
            this.staff_password.Name = "staff_password";
            this.staff_password.Width = 94;
            // 
            // permit
            // 
            this.permit.AppearanceCell.Options.UseTextOptions = true;
            this.permit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.permit.AppearanceHeader.Options.UseTextOptions = true;
            this.permit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.permit.Caption = "Quyền";
            this.permit.FieldName = "permit";
            this.permit.MinWidth = 25;
            this.permit.Name = "permit";
            this.permit.Visible = true;
            this.permit.VisibleIndex = 7;
            this.permit.Width = 185;
            // 
            // ucTKNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucTKNhanVien";
            this.Size = new System.Drawing.Size(1394, 787);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgQLTKNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cboNamSinh;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl dtgQLTKNV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblError;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn hoten;
        private DevExpress.XtraGrid.Columns.GridColumn soCMND;
        private DevExpress.XtraGrid.Columns.GridColumn namsinh;
        private DevExpress.XtraGrid.Columns.GridColumn gioitinh;
        private DevExpress.XtraGrid.Columns.GridColumn dienthoai;
        private DevExpress.XtraGrid.Columns.GridColumn staff_username;
        private DevExpress.XtraGrid.Columns.GridColumn staff_password;
        private DevExpress.XtraGrid.Columns.GridColumn permit;
        private System.Windows.Forms.NumericUpDown nmrQuyen;
    }
}
