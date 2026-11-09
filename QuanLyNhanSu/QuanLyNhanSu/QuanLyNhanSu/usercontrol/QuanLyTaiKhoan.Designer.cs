namespace QuanLyNhanSu.usercontrol
{
    partial class QuanLyTaiKhoan
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblTitle = new Label();
            dgvAccounts = new DataGridView();
            grpInput = new GroupBox();
            btnReset = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            cmbRole = new ComboBox();
            lblRole = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            cmbNhanVienID = new ComboBox(); // <-- ĐÃ THAY THẾ TỪ TEXTBOX
            lblNhanVienID = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).BeginInit();
            grpInput.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(0, 71, 160);
            lblTitle.Location = new Point(32, 40);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1097, 65);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN ĐĂNG NHẬP";
            // 
            // dgvAccounts
            // 
            dgvAccounts.AllowUserToAddRows = false;
            dgvAccounts.AllowUserToDeleteRows = false;
            dgvAccounts.BackgroundColor = Color.White;
            dgvAccounts.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 71, 160);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccounts.Location = new Point(618, 160);
            dgvAccounts.Margin = new Padding(5, 6, 5, 6);
            dgvAccounts.Name = "dgvAccounts";
            dgvAccounts.ReadOnly = true;
            dgvAccounts.RowHeadersWidth = 51;
            dgvAccounts.RowTemplate.Height = 24;
            dgvAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAccounts.Size = new Size(812, 800);
            dgvAccounts.TabIndex = 1;
            dgvAccounts.CellClick += DgvAccounts_CellClick; // <-- Thêm sự kiện CellClick giả định
            // 
            // grpInput
            // 
            grpInput.BackColor = Color.WhiteSmoke;
            grpInput.Controls.Add(btnReset);
            grpInput.Controls.Add(btnXoa);
            grpInput.Controls.Add(btnSua);
            grpInput.Controls.Add(btnThem);
            grpInput.Controls.Add(cmbRole);
            grpInput.Controls.Add(lblRole);
            grpInput.Controls.Add(txtPassword);
            grpInput.Controls.Add(lblPassword);
            grpInput.Controls.Add(txtUsername);
            grpInput.Controls.Add(lblUsername);
            grpInput.Controls.Add(cmbNhanVienID); // <-- DÙNG COMBOBOX MỚI
            grpInput.Controls.Add(lblNhanVienID);
            grpInput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpInput.Location = new Point(32, 160);
            grpInput.Margin = new Padding(5, 6, 5, 6);
            grpInput.Name = "grpInput";
            grpInput.Padding = new Padding(5, 6, 5, 6);
            grpInput.Size = new Size(569, 800);
            grpInput.TabIndex = 2;
            grpInput.TabStop = false;
            grpInput.Text = "Thông tin Tài khoản";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(108, 117, 125);
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(292, 540);
            btnReset.Margin = new Padding(5, 6, 5, 6);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(244, 80);
            btnReset.TabIndex = 11;
            btnReset.Text = "🔄 Làm mới / Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += BtnReset_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(220, 53, 69);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(32, 540);
            btnXoa.Margin = new Padding(5, 6, 5, 6);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(244, 80);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "🗑️ Xóa Tài khoản";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += BtnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(255, 165, 0);
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(292, 420);
            btnSua.Margin = new Padding(5, 6, 5, 6);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(244, 80);
            btnSua.TabIndex = 9;
            btnSua.Text = "📝 Cập nhật";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += BtnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(0, 150, 136);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(32, 420);
            btnThem.Margin = new Padding(5, 6, 5, 6);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(244, 80);
            btnThem.TabIndex = 8;
            btnThem.Text = "➕ Thêm Tài khoản";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += BtnThem_Click;
            // 
            // cmbRole
            // 
            cmbRole.Font = new Font("Segoe UI", 10F);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Admin", "Trưởng phòng", "Kế toán", "Nhân viên" });
            cmbRole.Location = new Point(211, 320);
            cmbRole.Margin = new Padding(5, 6, 5, 6);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(322, 45);
            cmbRole.TabIndex = 7;
            cmbRole.Text = "Nhân viên";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 10F);
            lblRole.Location = new Point(32, 326);
            lblRole.Margin = new Padding(5, 0, 5, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(151, 37);
            lblRole.TabIndex = 6;
            lblRole.Text = "Quyền hạn:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(211, 240);
            txtPassword.Margin = new Padding(5, 6, 5, 6);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(322, 43);
            txtPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F);
            lblPassword.Location = new Point(32, 246);
            lblPassword.Margin = new Padding(5, 0, 5, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(134, 37);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Mật khẩu:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(211, 160);
            txtUsername.Margin = new Padding(5, 6, 5, 6);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(322, 43);
            txtUsername.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F);
            lblUsername.Location = new Point(32, 166);
            lblUsername.Margin = new Padding(5, 0, 5, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(198, 37);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Tên đăng nhập:";
            // 
            // cmbNhanVienID
            // 
            cmbNhanVienID.Font = new Font("Segoe UI", 10F);
            cmbNhanVienID.FormattingEnabled = true;
            cmbNhanVienID.Location = new Point(211, 80);
            cmbNhanVienID.Margin = new Padding(5, 6, 5, 6);
            cmbNhanVienID.Name = "cmbNhanVienID";
            cmbNhanVienID.Size = new Size(322, 45);
            cmbNhanVienID.TabIndex = 1;
            // 
            // lblNhanVienID
            // 
            lblNhanVienID.AutoSize = true;
            lblNhanVienID.Font = new Font("Segoe UI", 10F);
            lblNhanVienID.Location = new Point(32, 86);
            lblNhanVienID.Margin = new Padding(5, 0, 5, 0);
            lblNhanVienID.Name = "lblNhanVienID";
            lblNhanVienID.Size = new Size(93, 37);
            lblNhanVienID.TabIndex = 0;
            lblNhanVienID.Text = "ID NV:";
            // 
            // QuanLyTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            Controls.Add(grpInput);
            Controls.Add(dgvAccounts);
            Controls.Add(lblTitle);
            Margin = new Padding(5, 6, 5, 6);
            Name = "QuanLyTaiKhoan";
            Size = new Size(1462, 1000);
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).EndInit();
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
            Load += QuanLyTaiKhoan_Load;
        }

        #endregion

        // Khai báo lại các controls ở đây để Designer.cs có thể truy cập
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ComboBox cmbNhanVienID; // <-- ĐÃ THAY THẾ
        private System.Windows.Forms.Label lblNhanVienID;
    }
}