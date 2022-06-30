namespace QLTKNGANHANG.ucNhanVien
{
    partial class ucLogTien
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
            this.dtgLogTien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.logBalance_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.soTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.logBalance_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ghichu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLogTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.lblTong);
            this.groupControl1.Controls.Add(this.dtgLogTien);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1098, 813);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Log Tiền";
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTong.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTong.Location = new System.Drawing.Point(5, 28);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(47, 21);
            this.lblTong.TabIndex = 36;
            this.lblTong.Text = "Tổng";
            // 
            // dtgLogTien
            // 
            this.dtgLogTien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgLogTien.Location = new System.Drawing.Point(5, 52);
            this.dtgLogTien.MainView = this.gridView1;
            this.dtgLogTien.Name = "dtgLogTien";
            this.dtgLogTien.Size = new System.Drawing.Size(1088, 756);
            this.dtgLogTien.TabIndex = 0;
            this.dtgLogTien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.logBalance_id,
            this.soTK,
            this.sodu,
            this.logBalance_date,
            this.ghichu});
            this.gridView1.GridControl = this.dtgLogTien;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.logBalance_date, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // logBalance_id
            // 
            this.logBalance_id.Caption = "Log ID";
            this.logBalance_id.FieldName = "logBalance_id";
            this.logBalance_id.MinWidth = 25;
            this.logBalance_id.Name = "logBalance_id";
            this.logBalance_id.Visible = true;
            this.logBalance_id.VisibleIndex = 0;
            this.logBalance_id.Width = 94;
            // 
            // soTK
            // 
            this.soTK.Caption = "Số tài khoản";
            this.soTK.FieldName = "soTK";
            this.soTK.MinWidth = 25;
            this.soTK.Name = "soTK";
            this.soTK.Visible = true;
            this.soTK.VisibleIndex = 1;
            this.soTK.Width = 94;
            // 
            // sodu
            // 
            this.sodu.Caption = "Số dư (VND)";
            this.sodu.FieldName = "sodu";
            this.sodu.MinWidth = 25;
            this.sodu.Name = "sodu";
            this.sodu.Visible = true;
            this.sodu.VisibleIndex = 2;
            this.sodu.Width = 94;
            // 
            // logBalance_date
            // 
            this.logBalance_date.Caption = "Ngày";
            this.logBalance_date.FieldName = "logBalance_date";
            this.logBalance_date.MinWidth = 25;
            this.logBalance_date.Name = "logBalance_date";
            this.logBalance_date.Visible = true;
            this.logBalance_date.VisibleIndex = 3;
            this.logBalance_date.Width = 94;
            // 
            // ghichu
            // 
            this.ghichu.Caption = "Ghi chú";
            this.ghichu.FieldName = "ghichu";
            this.ghichu.MinWidth = 25;
            this.ghichu.Name = "ghichu";
            this.ghichu.Visible = true;
            this.ghichu.VisibleIndex = 3;
            this.ghichu.Width = 94;
            // 
            // ucLogTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ucLogTien";
            this.Size = new System.Drawing.Size(1104, 819);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLogTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl dtgLogTien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label lblTong;
        private DevExpress.XtraGrid.Columns.GridColumn logBalance_id;
        private DevExpress.XtraGrid.Columns.GridColumn soTK;
        private DevExpress.XtraGrid.Columns.GridColumn sodu;
        private DevExpress.XtraGrid.Columns.GridColumn logBalance_date;
        private DevExpress.XtraGrid.Columns.GridColumn ghichu;
    }
}
