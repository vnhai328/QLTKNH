namespace QLTKNGANHANG.KhachHang
{
    partial class frmLogin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLoginNV = new System.Windows.Forms.Button();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.txtUsername1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLoginKH = new System.Windows.Forms.Button();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.txtUsername2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(483, 321);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(475, 292);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nhân viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLoginNV
            // 
            this.btnLoginNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoginNV.Location = new System.Drawing.Point(110, 210);
            this.btnLoginNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoginNV.Name = "btnLoginNV";
            this.btnLoginNV.Size = new System.Drawing.Size(93, 28);
            this.btnLoginNV.TabIndex = 3;
            this.btnLoginNV.Text = "Đăng nhập";
            this.btnLoginNV.UseVisualStyleBackColor = true;
            this.btnLoginNV.Click += new System.EventHandler(this.btnLoginNV_Click);
            // 
            // txtPassword1
            // 
            this.txtPassword1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword1.Location = new System.Drawing.Point(227, 156);
            this.txtPassword1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.PasswordChar = '*';
            this.txtPassword1.Size = new System.Drawing.Size(126, 23);
            this.txtPassword1.TabIndex = 2;
            this.txtPassword1.Text = "1";
            // 
            // txtUsername1
            // 
            this.txtUsername1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername1.Location = new System.Drawing.Point(227, 105);
            this.txtUsername1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername1.Name = "txtUsername1";
            this.txtUsername1.Size = new System.Drawing.Size(126, 23);
            this.txtUsername1.TabIndex = 1;
            this.txtUsername1.Text = "admin";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mật khẩu";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên đăng nhập";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OliveDrab;
            this.label6.Location = new System.Drawing.Point(104, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 33);
            this.label6.TabIndex = 4;
            this.label6.Text = "Đăng nhập nhân viên";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(475, 292);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Khách hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLoginKH
            // 
            this.btnLoginKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoginKH.Location = new System.Drawing.Point(107, 214);
            this.btnLoginKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoginKH.Name = "btnLoginKH";
            this.btnLoginKH.Size = new System.Drawing.Size(93, 28);
            this.btnLoginKH.TabIndex = 3;
            this.btnLoginKH.Text = "Đăng nhập";
            this.btnLoginKH.UseVisualStyleBackColor = true;
            this.btnLoginKH.Click += new System.EventHandler(this.btnLoginKH_Click);
            // 
            // txtPassword2
            // 
            this.txtPassword2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword2.Location = new System.Drawing.Point(230, 147);
            this.txtPassword2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '*';
            this.txtPassword2.Size = new System.Drawing.Size(126, 23);
            this.txtPassword2.TabIndex = 2;
            this.txtPassword2.Text = "1";
            // 
            // txtUsername2
            // 
            this.txtUsername2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername2.Location = new System.Drawing.Point(230, 99);
            this.txtUsername2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername2.Name = "txtUsername2";
            this.txtUsername2.Size = new System.Drawing.Size(126, 23);
            this.txtUsername2.TabIndex = 1;
            this.txtUsername2.Text = "hoangnh";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(89, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập khách hàng";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.txtPassword1);
            this.groupControl1.Controls.Add(this.btnLoginNV);
            this.groupControl1.Controls.Add(this.txtUsername1);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(475, 296);
            this.groupControl1.TabIndex = 9;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.btnLoginKH);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.txtPassword2);
            this.groupControl2.Controls.Add(this.txtUsername2);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Location = new System.Drawing.Point(-4, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(479, 293);
            this.groupControl2.TabIndex = 4;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 329);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnLoginNV;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.TextBox txtUsername1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnLoginKH;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.TextBox txtUsername2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}