namespace QLTKNGANHANG.KhachHang
{
    partial class frmCT
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
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvAll = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sotien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvIn = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.money = new DevExpress.XtraGrid.Columns.GridColumn();
            this.date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvOut = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cash = new DevExpress.XtraGrid.Columns.GridColumn();
            this.datetim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtNgaymo = new System.Windows.Forms.TextBox();
            this.txtCN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNH = new System.Windows.Forms.TextBox();
            this.txtLoaiTK = new System.Windows.Forms.TextBox();
            this.txtSodu = new System.Windows.Forms.TextBox();
            this.txtSoTK = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDienthoai = new System.Windows.Forms.TextBox();
            this.txtSoCMND = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Olive;
            this.label11.Location = new System.Drawing.Point(377, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 29);
            this.label11.TabIndex = 43;
            this.label11.Text = "Chi tiết tài khoản";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(461, 80);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(472, 380);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvAll);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(464, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Toàn bộ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvAll
            // 
            this.dgvAll.Location = new System.Drawing.Point(3, 3);
            this.dgvAll.MainView = this.gridView1;
            this.dgvAll.Name = "dgvAll";
            this.dgvAll.Size = new System.Drawing.Size(455, 341);
            this.dgvAll.TabIndex = 12;
            this.dgvAll.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.sotien,
            this.ngay});
            this.gridView1.GridControl = this.dgvAll;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView1.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel;
            // 
            // sotien
            // 
            this.sotien.AppearanceCell.Options.UseTextOptions = true;
            this.sotien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.sotien.AppearanceHeader.Options.UseTextOptions = true;
            this.sotien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.sotien.Caption = "Số tiền";
            this.sotien.FieldName = "sotien";
            this.sotien.MinWidth = 25;
            this.sotien.Name = "sotien";
            this.sotien.OptionsFilter.AllowFilter = false;
            this.sotien.Visible = true;
            this.sotien.VisibleIndex = 0;
            this.sotien.Width = 94;
            // 
            // ngay
            // 
            this.ngay.AppearanceCell.Options.UseTextOptions = true;
            this.ngay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngay.AppearanceHeader.Options.UseTextOptions = true;
            this.ngay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ngay.Caption = "Ngày";
            this.ngay.FieldName = "ngay";
            this.ngay.MinWidth = 25;
            this.ngay.Name = "ngay";
            this.ngay.Visible = true;
            this.ngay.VisibleIndex = 1;
            this.ngay.Width = 94;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvIn);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(464, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tiền vào";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvIn
            // 
            this.dgvIn.Location = new System.Drawing.Point(3, 7);
            this.dgvIn.MainView = this.gridView2;
            this.dgvIn.Name = "dgvIn";
            this.dgvIn.Size = new System.Drawing.Size(455, 337);
            this.dgvIn.TabIndex = 14;
            this.dgvIn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.money,
            this.date});
            this.gridView2.GridControl = this.dgvIn;
            this.gridView2.Name = "gridView2";
            // 
            // money
            // 
            this.money.AppearanceCell.Options.UseTextOptions = true;
            this.money.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.money.AppearanceHeader.Options.UseTextOptions = true;
            this.money.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.money.Caption = "Số tiền";
            this.money.FieldName = "money";
            this.money.MinWidth = 25;
            this.money.Name = "money";
            this.money.Visible = true;
            this.money.VisibleIndex = 0;
            this.money.Width = 94;
            // 
            // date
            // 
            this.date.AppearanceCell.Options.UseTextOptions = true;
            this.date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.date.AppearanceHeader.Options.UseTextOptions = true;
            this.date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.date.Caption = "Ngày";
            this.date.FieldName = "date";
            this.date.MinWidth = 25;
            this.date.Name = "date";
            this.date.Visible = true;
            this.date.VisibleIndex = 1;
            this.date.Width = 94;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvOut);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(464, 351);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tiền ra";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvOut
            // 
            this.dgvOut.Location = new System.Drawing.Point(3, 3);
            this.dgvOut.MainView = this.gridView3;
            this.dgvOut.Name = "dgvOut";
            this.dgvOut.Size = new System.Drawing.Size(458, 345);
            this.dgvOut.TabIndex = 15;
            this.dgvOut.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cash,
            this.datetim});
            this.gridView3.GridControl = this.dgvOut;
            this.gridView3.Name = "gridView3";
            // 
            // cash
            // 
            this.cash.AppearanceCell.Options.UseTextOptions = true;
            this.cash.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cash.AppearanceHeader.Options.UseTextOptions = true;
            this.cash.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cash.Caption = "Số tiền";
            this.cash.FieldName = "cash";
            this.cash.MinWidth = 25;
            this.cash.Name = "cash";
            this.cash.Visible = true;
            this.cash.VisibleIndex = 0;
            this.cash.Width = 94;
            // 
            // datetim
            // 
            this.datetim.AppearanceCell.Options.UseTextOptions = true;
            this.datetim.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.datetim.AppearanceHeader.Options.UseTextOptions = true;
            this.datetim.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.datetim.Caption = "Ngày";
            this.datetim.FieldName = "datetim";
            this.datetim.MinWidth = 25;
            this.datetim.Name = "datetim";
            this.datetim.Visible = true;
            this.datetim.VisibleIndex = 1;
            this.datetim.Width = 94;
            // 
            // txtNgaymo
            // 
            this.txtNgaymo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNgaymo.Enabled = false;
            this.txtNgaymo.Location = new System.Drawing.Point(193, 435);
            this.txtNgaymo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNgaymo.Name = "txtNgaymo";
            this.txtNgaymo.ReadOnly = true;
            this.txtNgaymo.Size = new System.Drawing.Size(193, 23);
            this.txtNgaymo.TabIndex = 10;
            // 
            // txtCN
            // 
            this.txtCN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCN.Enabled = false;
            this.txtCN.Location = new System.Drawing.Point(193, 395);
            this.txtCN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCN.Name = "txtCN";
            this.txtCN.ReadOnly = true;
            this.txtCN.Size = new System.Drawing.Size(193, 23);
            this.txtCN.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 438);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 17);
            this.label10.TabIndex = 39;
            this.label10.Text = "Ngày mở tài khoản";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "Loại tài khoản";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Số dư tài khoản";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Chi nhánh";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Ngân hàng";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Điện thoại";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Số CMND";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Số tài khoản";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Chủ tài khoản";
            // 
            // txtNH
            // 
            this.txtNH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNH.Enabled = false;
            this.txtNH.Location = new System.Drawing.Point(193, 356);
            this.txtNH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNH.Name = "txtNH";
            this.txtNH.ReadOnly = true;
            this.txtNH.Size = new System.Drawing.Size(193, 23);
            this.txtNH.TabIndex = 8;
            // 
            // txtLoaiTK
            // 
            this.txtLoaiTK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLoaiTK.Enabled = false;
            this.txtLoaiTK.Location = new System.Drawing.Point(193, 317);
            this.txtLoaiTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLoaiTK.Name = "txtLoaiTK";
            this.txtLoaiTK.ReadOnly = true;
            this.txtLoaiTK.Size = new System.Drawing.Size(193, 23);
            this.txtLoaiTK.TabIndex = 7;
            // 
            // txtSodu
            // 
            this.txtSodu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSodu.Enabled = false;
            this.txtSodu.Location = new System.Drawing.Point(193, 277);
            this.txtSodu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSodu.Name = "txtSodu";
            this.txtSodu.ReadOnly = true;
            this.txtSodu.Size = new System.Drawing.Size(193, 23);
            this.txtSodu.TabIndex = 6;
            // 
            // txtSoTK
            // 
            this.txtSoTK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoTK.Enabled = false;
            this.txtSoTK.Location = new System.Drawing.Point(193, 238);
            this.txtSoTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoTK.Name = "txtSoTK";
            this.txtSoTK.ReadOnly = true;
            this.txtSoTK.Size = new System.Drawing.Size(193, 23);
            this.txtSoTK.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(193, 198);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(193, 23);
            this.txtEmail.TabIndex = 4;
            // 
            // txtDienthoai
            // 
            this.txtDienthoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDienthoai.Enabled = false;
            this.txtDienthoai.Location = new System.Drawing.Point(193, 159);
            this.txtDienthoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDienthoai.Name = "txtDienthoai";
            this.txtDienthoai.ReadOnly = true;
            this.txtDienthoai.Size = new System.Drawing.Size(193, 23);
            this.txtDienthoai.TabIndex = 3;
            // 
            // txtSoCMND
            // 
            this.txtSoCMND.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoCMND.Enabled = false;
            this.txtSoCMND.Location = new System.Drawing.Point(193, 120);
            this.txtSoCMND.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoCMND.Name = "txtSoCMND";
            this.txtSoCMND.ReadOnly = true;
            this.txtSoCMND.Size = new System.Drawing.Size(193, 23);
            this.txtSoCMND.TabIndex = 2;
            // 
            // txtHoten
            // 
            this.txtHoten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHoten.Enabled = false;
            this.txtHoten.Location = new System.Drawing.Point(193, 80);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.ReadOnly = true;
            this.txtHoten.Size = new System.Drawing.Size(193, 23);
            this.txtHoten.TabIndex = 1;
            // 
            // frmCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 545);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtNgaymo);
            this.Controls.Add(this.txtCN);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNH);
            this.Controls.Add(this.txtLoaiTK);
            this.Controls.Add(this.txtSodu);
            this.Controls.Add(this.txtSoTK);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDienthoai);
            this.Controls.Add(this.txtSoCMND);
            this.Controls.Add(this.txtHoten);
            this.Name = "frmCT";
            this.Text = "         ";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtNgaymo;
        private System.Windows.Forms.TextBox txtCN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNH;
        private System.Windows.Forms.TextBox txtLoaiTK;
        private System.Windows.Forms.TextBox txtSodu;
        private System.Windows.Forms.TextBox txtSoTK;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDienthoai;
        private System.Windows.Forms.TextBox txtSoCMND;
        private System.Windows.Forms.TextBox txtHoten;
        private DevExpress.XtraGrid.GridControl dgvAll;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl dgvIn;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl dgvOut;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn sotien;
        private DevExpress.XtraGrid.Columns.GridColumn ngay;
        private DevExpress.XtraGrid.Columns.GridColumn money;
        private DevExpress.XtraGrid.Columns.GridColumn date;
        private DevExpress.XtraGrid.Columns.GridColumn cash;
        private DevExpress.XtraGrid.Columns.GridColumn datetim;
    }
}