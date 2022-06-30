namespace QLTKNGANHANG.ucNhanVien.ucBaoCao
{
    partial class ucLSGD
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnXem = new System.Windows.Forms.Button();
            this.dtpTGBD = new System.Windows.Forms.DateTimePicker();
            this.dtpTGKT = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Control = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.Control)).BeginInit();
            this.Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1320, 800);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(3, 174);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(118, 34);
            this.btnXem.TabIndex = 1;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // dtpTGBD
            // 
            this.dtpTGBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTGBD.Location = new System.Drawing.Point(4, 57);
            this.dtpTGBD.Name = "dtpTGBD";
            this.dtpTGBD.Size = new System.Drawing.Size(186, 23);
            this.dtpTGBD.TabIndex = 2;
            this.dtpTGBD.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // dtpTGKT
            // 
            this.dtpTGKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTGKT.Location = new System.Drawing.Point(5, 119);
            this.dtpTGKT.Name = "dtpTGKT";
            this.dtpTGKT.Size = new System.Drawing.Size(185, 23);
            this.dtpTGKT.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thời gian bắt đầu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thời gian kết thúc:";
            // 
            // Control
            // 
            this.Control.Controls.Add(this.dtpTGKT);
            this.Control.Controls.Add(this.btnXem);
            this.Control.Controls.Add(this.dtpTGBD);
            this.Control.Controls.Add(this.label1);
            this.Control.Controls.Add(this.label2);
            this.Control.Location = new System.Drawing.Point(3, 37);
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(193, 215);
            this.Control.TabIndex = 6;
            this.Control.Text = "Control";
            // 
            // ucLSGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Control);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "ucLSGD";
            this.Size = new System.Drawing.Size(1320, 800);
            ((System.ComponentModel.ISupportInitialize)(this.Control)).EndInit();
            this.Control.ResumeLayout(false);
            this.Control.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DateTimePicker dtpTGBD;
        private System.Windows.Forms.DateTimePicker dtpTGKT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GroupControl Control;
    }
}
