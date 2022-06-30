namespace QLTKNGANHANG.KhachHang
{
    partial class frmrut
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
            this.txtSodu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnRut = new System.Windows.Forms.Button();
            this.txtSotien = new System.Windows.Forms.TextBox();
            this.txtSoTK = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSodu
            // 
            this.txtSodu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSodu.Enabled = false;
            this.txtSodu.Location = new System.Drawing.Point(215, 196);
            this.txtSodu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSodu.Name = "txtSodu";
            this.txtSodu.ReadOnly = true;
            this.txtSodu.Size = new System.Drawing.Size(151, 23);
            this.txtSodu.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Số dư";
            // 
            // txtHoten
            // 
            this.txtHoten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHoten.Enabled = false;
            this.txtHoten.Location = new System.Drawing.Point(215, 140);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.ReadOnly = true;
            this.txtHoten.Size = new System.Drawing.Size(151, 23);
            this.txtHoten.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OliveDrab;
            this.label5.Location = new System.Drawing.Point(126, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 29);
            this.label5.TabIndex = 34;
            this.label5.Text = "Giao diện rút tiền";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Chủ tài khoản";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Mã pin";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Số tiền rút";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Số tài khoản";
            // 
            // txtPin
            // 
            this.txtPin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPin.Location = new System.Drawing.Point(215, 309);
            this.txtPin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPin.MaxLength = 6;
            this.txtPin.Name = "txtPin";
            this.txtPin.PasswordChar = '*';
            this.txtPin.Size = new System.Drawing.Size(151, 23);
            this.txtPin.TabIndex = 5;
            this.txtPin.TextChanged += new System.EventHandler(this.txtPin_TextChanged);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHuy.Location = new System.Drawing.Point(247, 373);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(87, 28);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnRut
            // 
            this.btnRut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRut.Location = new System.Drawing.Point(100, 373);
            this.btnRut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRut.Name = "btnRut";
            this.btnRut.Size = new System.Drawing.Size(87, 28);
            this.btnRut.TabIndex = 6;
            this.btnRut.Text = "Rút tiền";
            this.btnRut.UseVisualStyleBackColor = true;
            this.btnRut.Click += new System.EventHandler(this.btnRut_Click);
            // 
            // txtSotien
            // 
            this.txtSotien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSotien.Location = new System.Drawing.Point(215, 253);
            this.txtSotien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSotien.Name = "txtSotien";
            this.txtSotien.Size = new System.Drawing.Size(151, 23);
            this.txtSotien.TabIndex = 4;
            this.txtSotien.TextChanged += new System.EventHandler(this.txtSotien_TextChanged);
            // 
            // txtSoTK
            // 
            this.txtSoTK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoTK.Enabled = false;
            this.txtSoTK.Location = new System.Drawing.Point(215, 83);
            this.txtSoTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoTK.Name = "txtSoTK";
            this.txtSoTK.ReadOnly = true;
            this.txtSoTK.Size = new System.Drawing.Size(151, 23);
            this.txtSoTK.TabIndex = 1;
            // 
            // frmrut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 434);
            this.Controls.Add(this.txtSodu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnRut);
            this.Controls.Add(this.txtSotien);
            this.Controls.Add(this.txtSoTK);
            this.Name = "frmrut";
            this.Text = "frmrut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSodu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnRut;
        private System.Windows.Forms.TextBox txtSotien;
        private System.Windows.Forms.TextBox txtSoTK;
    }
}