namespace QLTKNGANHANG.ucNhanVien
{
    partial class ucLogRutTien
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblTong = new System.Windows.Forms.Label();
            this.dtgLogRutTien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rut_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rut_soTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rut_tien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rut_ngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ghichu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLogRutTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.lblTong);
            this.groupControl1.Controls.Add(this.dtgLogRutTien);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1269, 836);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Log lịch sử rút tiền";
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTong.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTong.Location = new System.Drawing.Point(5, 28);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(47, 21);
            this.lblTong.TabIndex = 37;
            this.lblTong.Text = "Tổng";
            // 
            // dtgLogRutTien
            // 
            this.dtgLogRutTien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgLogRutTien.Location = new System.Drawing.Point(5, 98);
            this.dtgLogRutTien.MainView = this.gridView1;
            this.dtgLogRutTien.Name = "dtgLogRutTien";
            this.dtgLogRutTien.Size = new System.Drawing.Size(1259, 733);
            this.dtgLogRutTien.TabIndex = 0;
            this.dtgLogRutTien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.rut_id,
            this.rut_soTK,
            this.rut_tien,
            this.rut_ngay,
            this.ghichu});
            this.gridView1.GridControl = this.dtgLogRutTien;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // rut_id
            // 
            this.rut_id.AppearanceCell.Options.UseTextOptions = true;
            this.rut_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rut_id.AppearanceHeader.Options.UseTextOptions = true;
            this.rut_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rut_id.Caption = "ID";
            this.rut_id.FieldName = "rut_id";
            this.rut_id.MinWidth = 25;
            this.rut_id.Name = "rut_id";
            this.rut_id.Visible = true;
            this.rut_id.VisibleIndex = 0;
            this.rut_id.Width = 94;
            // 
            // rut_soTK
            // 
            this.rut_soTK.AppearanceCell.Options.UseTextOptions = true;
            this.rut_soTK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rut_soTK.AppearanceHeader.Options.UseTextOptions = true;
            this.rut_soTK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rut_soTK.Caption = "Số tài khoản";
            this.rut_soTK.FieldName = "rut_soTK";
            this.rut_soTK.MinWidth = 25;
            this.rut_soTK.Name = "rut_soTK";
            this.rut_soTK.Visible = true;
            this.rut_soTK.VisibleIndex = 1;
            this.rut_soTK.Width = 282;
            // 
            // rut_tien
            // 
            this.rut_tien.AppearanceCell.Options.UseTextOptions = true;
            this.rut_tien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.rut_tien.AppearanceHeader.Options.UseTextOptions = true;
            this.rut_tien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rut_tien.Caption = "Số tiền rút (VND)";
            this.rut_tien.FieldName = "rut_tien";
            this.rut_tien.MinWidth = 25;
            this.rut_tien.Name = "rut_tien";
            this.rut_tien.Visible = true;
            this.rut_tien.VisibleIndex = 2;
            this.rut_tien.Width = 282;
            // 
            // rut_ngay
            // 
            this.rut_ngay.AppearanceCell.Options.UseTextOptions = true;
            this.rut_ngay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rut_ngay.AppearanceHeader.Options.UseTextOptions = true;
            this.rut_ngay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rut_ngay.Caption = "Ngày ";
            this.rut_ngay.FieldName = "rut_ngay";
            this.rut_ngay.MinWidth = 25;
            this.rut_ngay.Name = "rut_ngay";
            this.rut_ngay.Visible = true;
            this.rut_ngay.VisibleIndex = 3;
            this.rut_ngay.Width = 282;
            // 
            // ghichu
            // 
            this.ghichu.AppearanceHeader.Options.UseTextOptions = true;
            this.ghichu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ghichu.Caption = "Ghi chú";
            this.ghichu.FieldName = "ghichu";
            this.ghichu.MinWidth = 25;
            this.ghichu.Name = "ghichu";
            this.ghichu.Visible = true;
            this.ghichu.VisibleIndex = 4;
            this.ghichu.Width = 289;
            // 
            // ucLogRutTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ucLogRutTien";
            this.Size = new System.Drawing.Size(1275, 842);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLogRutTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl dtgLogRutTien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label lblTong;
        private DevExpress.XtraGrid.Columns.GridColumn rut_id;
        private DevExpress.XtraGrid.Columns.GridColumn rut_soTK;
        private DevExpress.XtraGrid.Columns.GridColumn rut_tien;
        private DevExpress.XtraGrid.Columns.GridColumn rut_ngay;
        private DevExpress.XtraGrid.Columns.GridColumn ghichu;
    }
}
