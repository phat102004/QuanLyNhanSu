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
            // label1 - Tiêu đề
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 71, 160);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(700, 70);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ NHÂN SỰ";
            label1.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // label2 - Tên đăng nhập
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            label2.Location = new Point(35, 30);
            label2.Name = "label2";
            label2.Size = new Size(120, 19);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập:";

            // 
            // label3 - Mật khẩu
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            label3.Location = new Point(35, 78);
            label3.Name = "label3";
            label3.Size = new Size(82, 19);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu:";

            // 
            // TxtUsername
            // 
            TxtUsername.Font = new Font("Segoe UI", 11F);
            TxtUsername.Location = new Point(170, 25);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(360, 27);
            TxtUsername.TabIndex = 3;

            // 
            // TxtPassword
            // 
            TxtPassword.Font = new Font("Segoe UI", 11F);
            TxtPassword.Location = new Point(170, 73);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '●';
            TxtPassword.Size = new Size(360, 27);
            TxtPassword.TabIndex = 4;
            TxtPassword.KeyDown += TxtPassword_KeyDown;

            // 
            // BtnDangNhap
            // 
            BtnDangNhap.BackColor = Color.FromArgb(0, 71, 160);
            BtnDangNhap.FlatAppearance.BorderSize = 0;
            BtnDangNhap.FlatStyle = FlatStyle.Flat;
            BtnDangNhap.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            BtnDangNhap.ForeColor = Color.White;
            BtnDangNhap.Location = new Point(170, 125);
            BtnDangNhap.Name = "BtnDangNhap";
            BtnDangNhap.Size = new Size(175, 42);
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
            BtnThoat.Font = new Font("Segoe UI", 10.5F);
            BtnThoat.ForeColor = Color.White;
            BtnThoat.Location = new Point(355, 125);
            BtnThoat.Name = "BtnThoat";
            BtnThoat.Size = new Size(175, 42);
            BtnThoat.TabIndex = 6;
            BtnThoat.Text = "THOÁT";
            BtnThoat.UseVisualStyleBackColor = false;

            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.White;
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(TxtUsername);
            panelLogin.Controls.Add(label3);
            panelLogin.Controls.Add(TxtPassword);
            panelLogin.Controls.Add(BtnDangNhap);
            panelLogin.Controls.Add(BtnThoat);
            panelLogin.Location = new Point(50, 90);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(600, 200);
            panelLogin.TabIndex = 7;

            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(700, 340);
            Controls.Add(panelLogin);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
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
        private System.Windows.Forms.Panel panelLogin;
    }
}