namespace QLTKNGANHANG.KhachHang
{
    partial class frmDoiPin
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPinMoi2 = new System.Windows.Forms.TextBox();
            this.txtPinMoi1 = new System.Windows.Forms.TextBox();
            this.txtPinCu = new System.Windows.Forms.TextBox();
            this.txtSoTK = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OliveDrab;
            this.label5.Location = new System.Drawing.Point(114, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Thay đổi mã pin";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHuy.Location = new System.Drawing.Point(220, 290);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(87, 28);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLuu.Location = new System.Drawing.Point(89, 290);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(87, 28);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu thay đổi";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Số tài khoản/thẻ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nhập lại mã pin mới";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nhập mã pin mới";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nhập mã pin cũ";
            // 
            // txtPinMoi2
            // 
            this.txtPinMoi2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPinMoi2.Location = new System.Drawing.Point(219, 236);
            this.txtPinMoi2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPinMoi2.MaxLength = 6;
            this.txtPinMoi2.Name = "txtPinMoi2";
            this.txtPinMoi2.PasswordChar = '*';
            this.txtPinMoi2.Size = new System.Drawing.Size(116, 23);
            this.txtPinMoi2.TabIndex = 4;
            this.txtPinMoi2.TextChanged += new System.EventHandler(this.txtPinMoi2_TextChanged);
            // 
            // txtPinMoi1
            // 
            this.txtPinMoi1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPinMoi1.Location = new System.Drawing.Point(219, 182);
            this.txtPinMoi1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPinMoi1.MaxLength = 6;
            this.txtPinMoi1.Name = "txtPinMoi1";
            this.txtPinMoi1.PasswordChar = '*';
            this.txtPinMoi1.Size = new System.Drawing.Size(116, 23);
            this.txtPinMoi1.TabIndex = 3;
            this.txtPinMoi1.TextChanged += new System.EventHandler(this.txtPinMoi1_TextChanged);
            // 
            // txtPinCu
            // 
            this.txtPinCu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPinCu.Location = new System.Drawing.Point(219, 128);
            this.txtPinCu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPinCu.MaxLength = 6;
            this.txtPinCu.Name = "txtPinCu";
            this.txtPinCu.PasswordChar = '*';
            this.txtPinCu.Size = new System.Drawing.Size(116, 23);
            this.txtPinCu.TabIndex = 2;
            this.txtPinCu.TextChanged += new System.EventHandler(this.txtPinCu_TextChanged);
            // 
            // txtSoTK
            // 
            this.txtSoTK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoTK.Enabled = false;
            this.txtSoTK.Location = new System.Drawing.Point(219, 74);
            this.txtSoTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoTK.Name = "txtSoTK";
            this.txtSoTK.ReadOnly = true;
            this.txtSoTK.Size = new System.Drawing.Size(116, 23);
            this.txtSoTK.TabIndex = 1;
            // 
            // frmDoiPin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 357);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPinMoi2);
            this.Controls.Add(this.txtPinMoi1);
            this.Controls.Add(this.txtPinCu);
            this.Controls.Add(this.txtSoTK);
            this.Name = "frmDoiPin";
            this.Text = "frmDoiPin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPinMoi2;
        private System.Windows.Forms.TextBox txtPinMoi1;
        private System.Windows.Forms.TextBox txtPinCu;
        private System.Windows.Forms.TextBox txtSoTK;
    }
}