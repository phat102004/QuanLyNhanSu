using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhanSu.usercontrol
{
    partial class QuanLyTaiKhoan
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private Label lblTitle;
        private DataGridView dgvAccounts;
        private GroupBox grpInput;
        private Button btnReset, btnXoa, btnSua, btnThem, btnChonNhanVien;
        private ComboBox cmbRole, cmbNhanVienID;
        private Label lblRole, lblPassword, lblUsername, lblNhanVienID;
        private TextBox txtPassword, txtUsername;

        private void InitializeComponent()
        {
            lblTitle = new Label();
            dgvAccounts = new DataGridView();
            grpInput = new GroupBox();
            btnReset = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnChonNhanVien = new Button();
            cmbRole = new ComboBox();
            lblRole = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            cmbNhanVienID = new ComboBox();
            lblNhanVienID = new Label();

            Color navy = Color.FromArgb(30, 64, 175);
            Color blue = Color.FromArgb(37, 99, 235);
            Color dark = Color.FromArgb(15, 23, 42);
            Color light = Color.FromArgb(241, 245, 249);
            Color muted = Color.FromArgb(100, 116, 139);

            SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).BeginInit();

            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = light;
            Name = "QuanLyTaiKhoan";
            Size = new Size(1462, 1000);

            TableLayoutPanel root = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 3,
                Padding = new Padding(18),
                BackColor = light,
                MinimumSize = new Size(900, 720)
            };
            root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 105));
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 335));
            root.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            TableLayoutPanel header = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 2,
                Margin = new Padding(0, 0, 0, 10)
            };
            header.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            header.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 215));
            header.RowStyles.Add(new RowStyle(SizeType.Absolute, 58));
            header.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            lblTitle.Name = "lblTitle";
            lblTitle.Text = "QUẢN LÝ TÀI KHOẢN";
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblTitle.ForeColor = dark;
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            lblTitle.AutoSize = false;

            Label subtitle = new Label
            {
                Dock = DockStyle.Fill,
                AutoSize = false,
                Text = "Tìm nhân viên theo mã hoặc họ tên để cấp tài khoản đăng nhập",
                Font = new Font("Segoe UI", 10F),
                ForeColor = muted,
                TextAlign = ContentAlignment.MiddleLeft
            };

            StyleButton(btnChonNhanVien, "Tìm nhân viên", navy);
            btnChonNhanVien.Name = "btnChonNhanVien";
            btnChonNhanVien.Margin = new Padding(5, 6, 0, 6);
            btnChonNhanVien.Click += BtnChonNhanVien_Click;
            header.Controls.Add(lblTitle, 0, 0);
            header.Controls.Add(subtitle, 0, 1);
            header.Controls.Add(btnChonNhanVien, 1, 0);
            header.SetRowSpan(btnChonNhanVien, 2);

            grpInput.Name = "grpInput";
            grpInput.Text = "THÔNG TIN TÀI KHOẢN";
            grpInput.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpInput.ForeColor = navy;
            grpInput.BackColor = Color.White;
            grpInput.Dock = DockStyle.Fill;
            grpInput.Margin = new Padding(0, 0, 0, 14);
            grpInput.Padding = new Padding(14, 36, 14, 14);

            TableLayoutPanel form = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 4,
                RowCount = 3,
                Margin = new Padding(0)
            };
            form.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17));
            form.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33));
            form.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17));
            form.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33));
            form.RowStyles.Add(new RowStyle(SizeType.Percent, 31));
            form.RowStyles.Add(new RowStyle(SizeType.Percent, 31));
            form.RowStyles.Add(new RowStyle(SizeType.Percent, 38));

            ConfigureLabel(lblNhanVienID, "Nhân viên:", dark);
            ConfigureLabel(lblUsername, "Tên đăng nhập:", dark);
            ConfigureLabel(lblPassword, "Mật khẩu:", dark);
            ConfigureLabel(lblRole, "Quyền hạn:", dark);

            ConfigureInput(cmbNhanVienID);
            cmbNhanVienID.Name = "cmbNhanVienID";
            cmbNhanVienID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNhanVienID.Enabled = false; // Chọn bằng cửa sổ tìm kiếm

            ConfigureInput(cmbRole);
            cmbRole.Name = "cmbRole";
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            // Quyền được nạp từ SQL trong LoadQuyenComboBox

            ConfigureInput(txtUsername);
            txtUsername.Name = "txtUsername";
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            ConfigureInput(txtPassword);
            txtPassword.Name = "txtPassword";
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.PasswordChar = '●';

            form.Controls.Add(lblNhanVienID, 0, 0);
            form.Controls.Add(cmbNhanVienID, 1, 0);
            form.Controls.Add(lblUsername, 2, 0);
            form.Controls.Add(txtUsername, 3, 0);
            form.Controls.Add(lblPassword, 0, 1);
            form.Controls.Add(txtPassword, 1, 1);
            form.Controls.Add(lblRole, 2, 1);
            form.Controls.Add(cmbRole, 3, 1);

            TableLayoutPanel actions = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 4,
                RowCount = 1,
                Margin = new Padding(5, 4, 5, 0)
            };
            for (int i = 0; i < 4; i++)
                actions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            actions.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            StyleButton(btnThem, "Thêm tài khoản", navy);
            StyleButton(btnSua, "Cập nhật", blue);
            StyleButton(btnXoa, "Xóa tài khoản", Color.FromArgb(185, 28, 28));
            StyleButton(btnReset, "Làm mới", Color.FromArgb(71, 85, 105));
            btnThem.Name = "btnThem";
            btnSua.Name = "btnSua";
            btnXoa.Name = "btnXoa";
            btnReset.Name = "btnReset";
            actions.Controls.Add(btnThem, 0, 0);
            actions.Controls.Add(btnSua, 1, 0);
            actions.Controls.Add(btnXoa, 2, 0);
            actions.Controls.Add(btnReset, 3, 0);
            form.Controls.Add(actions, 0, 2);
            form.SetColumnSpan(actions, 4);
            grpInput.Controls.Add(form);

            TableLayoutPanel gridCard = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                ColumnCount = 1,
                RowCount = 2,
                Padding = new Padding(14),
                Margin = new Padding(0)
            };
            gridCard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            gridCard.RowStyles.Add(new RowStyle(SizeType.Absolute, 52));
            gridCard.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            Label gridTitle = new Label
            {
                Text = "DANH SÁCH TÀI KHOẢN",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = navy,
                TextAlign = ContentAlignment.MiddleLeft
            };
            dgvAccounts.Name = "dgvAccounts";
            dgvAccounts.Dock = DockStyle.Fill;
            dgvAccounts.ReadOnly = true;
            dgvAccounts.AllowUserToAddRows = false;
            dgvAccounts.AllowUserToDeleteRows = false;
            dgvAccounts.AllowUserToResizeRows = false;
            dgvAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAccounts.MultiSelect = false;
            dgvAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAccounts.RowHeadersWidth = 42;
            dgvAccounts.RowTemplate.Height = 38;
            dgvAccounts.ColumnHeadersHeight = 48;
            dgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAccounts.EnableHeadersVisualStyles = false;
            dgvAccounts.ColumnHeadersDefaultCellStyle.BackColor = navy;
            dgvAccounts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAccounts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvAccounts.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvAccounts.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvAccounts.DefaultCellStyle.ForeColor = dark;
            dgvAccounts.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvAccounts.DefaultCellStyle.SelectionForeColor = dark;
            dgvAccounts.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvAccounts.BackgroundColor = Color.White;
            dgvAccounts.BorderStyle = BorderStyle.None;
            dgvAccounts.GridColor = Color.FromArgb(203, 213, 225);
            gridCard.Controls.Add(gridTitle, 0, 0);
            gridCard.Controls.Add(dgvAccounts, 0, 1);

            root.Controls.Add(header, 0, 0);
            root.Controls.Add(grpInput, 0, 1);
            root.Controls.Add(gridCard, 0, 2);
            Controls.Add(root);

            // Các Click/CellClick khác đã gắn trong constructor QuanLyTaiKhoan.cs.
            // Không đăng ký trùng tại Designer.
            Load += QuanLyTaiKhoan_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).EndInit();
            ResumeLayout(false);
        }

        private static void ConfigureLabel(Label label, string text, Color color)
        {
            label.Text = text;
            label.AutoSize = false;
            label.Dock = DockStyle.Fill;
            label.Font = new Font("Segoe UI", 10F);
            label.ForeColor = color;
            label.TextAlign = ContentAlignment.MiddleLeft;
            label.Margin = new Padding(8);
        }

        private static void ConfigureInput(Control input)
        {
            input.Dock = DockStyle.Fill;
            input.Margin = new Padding(5, 17, 12, 17);
            input.Font = new Font("Segoe UI", 11F);
            input.BackColor = Color.FromArgb(239, 246, 255);
            input.ForeColor = Color.FromArgb(15, 23, 42);
        }

        private static void StyleButton(Button button, string text, Color color)
        {
            button.Text = text;
            button.BackColor = color;
            button.ForeColor = Color.White;
            button.Dock = DockStyle.Fill;
            button.Margin = new Padding(7, 12, 7, 12);
            button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Cursor = Cursors.Hand;
            button.UseVisualStyleBackColor = false;
        }
    }
}
