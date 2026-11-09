namespace QuanLyNhanSu
{
    partial class FormDangNhap
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtUsername = new TextBox();
            TxtPassword = new TextBox();
            BtnDangNhap = new Button();
            BtnThoat = new Button();
            panelLogin = new Panel();
            panelLogin.SuspendLayout();
            SuspendLayout();
            //
            // label1
            //
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 71, 160);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 30, 0, 0);
            label1.Size = new Size(874, 121);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ NHÂN SỰ";
            label1.TextAlign = ContentAlignment.TopCenter;
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(-2, 52);
            label2.Name = "label2";
            label2.Size = new Size(250, 45);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập:";
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(3, 119);
            label3.Name = "label3";
            label3.Size = new Size(171, 45);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu:";
            //
            // TxtUsername
            //
            TxtUsername.Font = new Font("Segoe UI", 13.8F);
            TxtUsername.Location = new Point(254, 52);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(350, 56);
            TxtUsername.TabIndex = 3;
            //
            // TxtPassword
            //
            TxtPassword.Font = new Font("Segoe UI", 13.8F);
            TxtPassword.Location = new Point(254, 112);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '●';
            TxtPassword.Size = new Size(350, 56);
            TxtPassword.TabIndex = 4;
            TxtPassword.KeyDown += TxtPassword_KeyDown;
            //
            // BtnDangNhap
            //
            BtnDangNhap.BackColor = Color.FromArgb(0, 71, 160);
            BtnDangNhap.FlatAppearance.BorderSize = 0;
            BtnDangNhap.FlatStyle = FlatStyle.Flat;
            BtnDangNhap.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            BtnDangNhap.ForeColor = Color.White;
            BtnDangNhap.Location = new Point(77, 180);
            BtnDangNhap.Name = "BtnDangNhap";
            BtnDangNhap.Size = new Size(271, 60);
            BtnDangNhap.TabIndex = 5;
            BtnDangNhap.Text = "ĐĂNG NHẬP";
            BtnDangNhap.UseVisualStyleBackColor = false;
            BtnDangNhap.Click += BtnDangNhap_Click;
            //
            // BtnThoat
            //
            BtnThoat.BackColor = Color.Gray;
            BtnThoat.FlatAppearance.BorderSize = 0;
            BtnThoat.FlatStyle = FlatStyle.Flat;
            BtnThoat.Font = new Font("Segoe UI", 14F);
            BtnThoat.ForeColor = Color.White;
            BtnThoat.Location = new Point(349, 180);
            BtnThoat.Name = "BtnThoat";
            BtnThoat.Size = new Size(271, 60);
            BtnThoat.TabIndex = 6;
            BtnThoat.Text = "Thoát";
            BtnThoat.UseVisualStyleBackColor = false;
            //
            // panelLogin
            //
            panelLogin.BackColor = Color.White;
            panelLogin.BorderStyle = BorderStyle.Fixed3D;
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(TxtUsername);
            panelLogin.Controls.Add(label3);
            panelLogin.Controls.Add(TxtPassword);
            panelLogin.Controls.Add(BtnDangNhap);
            panelLogin.Controls.Add(BtnThoat);
            panelLogin.Location = new Point(100, 124);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(673, 281);
            panelLogin.TabIndex = 7;
            //
            // FormDangNhap
            //
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(874, 529);
            Controls.Add(panelLogin);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập hệ thống";
            Load += FormDangNhap_Load;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnDangNhap;
        private System.Windows.Forms.Button BtnThoat;
        private System.Windows.Forms.Panel panelLogin; // Thêm Panel mới
    }
}