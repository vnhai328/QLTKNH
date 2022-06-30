namespace QLTKNGANHANG
{
    partial class frmDoiMK
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMKmoi2 = new System.Windows.Forms.TextBox();
            this.txtMKmoi1 = new System.Windows.Forms.TextBox();
            this.txtMKcu = new System.Windows.Forms.TextBox();
            this.labCustomerID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OliveDrab;
            this.label5.Location = new System.Drawing.Point(106, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 29);
            this.label5.TabIndex = 30;
            this.label5.Text = "Thay đổi mật khẩu";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHuy.Location = new System.Drawing.Point(218, 286);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(87, 28);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLuu.Location = new System.Drawing.Point(87, 286);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(87, 28);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu ";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nhập lại mật khẩu mới";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nhập mật khẩu mới";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nhập mật khẩu cũ";
            // 
            // txtMKmoi2
            // 
            this.txtMKmoi2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMKmoi2.Location = new System.Drawing.Point(216, 216);
            this.txtMKmoi2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMKmoi2.Name = "txtMKmoi2";
            this.txtMKmoi2.PasswordChar = '*';
            this.txtMKmoi2.Size = new System.Drawing.Size(144, 23);
            this.txtMKmoi2.TabIndex = 3;
            // 
            // txtMKmoi1
            // 
            this.txtMKmoi1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMKmoi1.Location = new System.Drawing.Point(216, 162);
            this.txtMKmoi1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMKmoi1.Name = "txtMKmoi1";
            this.txtMKmoi1.PasswordChar = '*';
            this.txtMKmoi1.Size = new System.Drawing.Size(144, 23);
            this.txtMKmoi1.TabIndex = 2;
            // 
            // txtMKcu
            // 
            this.txtMKcu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMKcu.Location = new System.Drawing.Point(216, 108);
            this.txtMKcu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMKcu.Name = "txtMKcu";
            this.txtMKcu.PasswordChar = '*';
            this.txtMKcu.Size = new System.Drawing.Size(144, 23);
            this.txtMKcu.TabIndex = 1;
            // 
            // labCustomerID
            // 
            this.labCustomerID.AutoSize = true;
            this.labCustomerID.Location = new System.Drawing.Point(22, 29);
            this.labCustomerID.Name = "labCustomerID";
            this.labCustomerID.Size = new System.Drawing.Size(0, 17);
            this.labCustomerID.TabIndex = 31;
            this.labCustomerID.Visible = false;
            // 
            // frmDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 346);
            this.Controls.Add(this.labCustomerID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMKmoi2);
            this.Controls.Add(this.txtMKmoi1);
            this.Controls.Add(this.txtMKcu);
            this.Name = "frmDoiMK";
            this.Text = "frmDoiMK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMKmoi2;
        private System.Windows.Forms.TextBox txtMKmoi1;
        private System.Windows.Forms.TextBox txtMKcu;
        private System.Windows.Forms.Label labCustomerID;
    }
}