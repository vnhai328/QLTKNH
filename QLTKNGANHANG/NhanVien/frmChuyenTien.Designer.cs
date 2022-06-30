namespace QLTKNGANHANG.ucNhanVien
{
    partial class frmChuyenTien
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
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.txtND = new System.Windows.Forms.TextBox();
            this.cboChiNhanh = new System.Windows.Forms.ComboBox();
            this.btnGui = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsoTK = new System.Windows.Forms.TextBox();
            this.txtChuTK = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHoten
            // 
            this.txtHoten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHoten.Location = new System.Drawing.Point(229, 239);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(339, 23);
            this.txtHoten.TabIndex = 3;
            // 
            // txtCMND
            // 
            this.txtCMND.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCMND.Location = new System.Drawing.Point(229, 297);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(339, 23);
            this.txtCMND.TabIndex = 4;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoTien.Location = new System.Drawing.Point(229, 356);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(339, 23);
            this.txtSoTien.TabIndex = 5;
            // 
            // txtND
            // 
            this.txtND.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtND.Location = new System.Drawing.Point(229, 485);
            this.txtND.Multiline = true;
            this.txtND.Name = "txtND";
            this.txtND.Size = new System.Drawing.Size(339, 83);
            this.txtND.TabIndex = 7;
            // 
            // cboChiNhanh
            // 
            this.cboChiNhanh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboChiNhanh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboChiNhanh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChiNhanh.FormattingEnabled = true;
            this.cboChiNhanh.Location = new System.Drawing.Point(229, 423);
            this.cboChiNhanh.Name = "cboChiNhanh";
            this.cboChiNhanh.Size = new System.Drawing.Size(339, 24);
            this.cboChiNhanh.TabIndex = 6;
            // 
            // btnGui
            // 
            this.btnGui.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGui.Location = new System.Drawing.Point(77, 607);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(119, 36);
            this.btnGui.TabIndex = 8;
            this.btnGui.Text = "Gửi";
            this.btnGui.UseVisualStyleBackColor = true;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(449, 607);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Họ tên người gửi:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "CMND:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Số tiền:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Chi nhánh:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 507);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nội dung:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label7.Location = new System.Drawing.Point(221, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 46);
            this.label7.TabIndex = 15;
            this.label7.Text = "Chuyển tiền";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStatus.ForeColor = System.Drawing.Color.LightCoral;
            this.lblStatus.Location = new System.Drawing.Point(225, 698);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(86, 21);
            this.lblStatus.TabIndex = 37;
            this.lblStatus.Text = "Trạng thái";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Số tài khoản:";
            // 
            // txtsoTK
            // 
            this.txtsoTK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtsoTK.Location = new System.Drawing.Point(229, 126);
            this.txtsoTK.Name = "txtsoTK";
            this.txtsoTK.Size = new System.Drawing.Size(339, 23);
            this.txtsoTK.TabIndex = 1;
            this.txtsoTK.Leave += new System.EventHandler(this.txtsoTK_Leave);
            // 
            // txtChuTK
            // 
            this.txtChuTK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtChuTK.Enabled = false;
            this.txtChuTK.Location = new System.Drawing.Point(229, 181);
            this.txtChuTK.Name = "txtChuTK";
            this.txtChuTK.Size = new System.Drawing.Size(339, 23);
            this.txtChuTK.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 17);
            this.label8.TabIndex = 42;
            this.label8.Text = "Tên chủ tài khoản:";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.lblStatus);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.btnGui);
            this.groupControl1.Controls.Add(this.button2);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.txtsoTK);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.txtChuTK);
            this.groupControl1.Controls.Add(this.txtND);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.cboChiNhanh);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtHoten);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtCMND);
            this.groupControl1.Controls.Add(this.txtSoTien);
            this.groupControl1.Location = new System.Drawing.Point(2, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(640, 781);
            this.groupControl1.TabIndex = 43;
            // 
            // frmChuyenTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 785);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmChuyenTien";
            this.Text = "Chuyển tiền";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.TextBox txtND;
        private System.Windows.Forms.ComboBox cboChiNhanh;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsoTK;
        private System.Windows.Forms.TextBox txtChuTK;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}