namespace QuanLyNhanSu
{
    partial class Form1
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

        private void InitializeComponent()
        {
            btnTinhLuong = new Button();
            btnHoSoCaNhan = new Button();
            btnLuongCaNhan = new Button();
            btnCongViecCaNhan = new Button();
            panelMenu = new Panel();
            panelPhanCongSubmenu = new Panel();
            btnBaoCaoPhanCong = new Button();
            btnPhanCongCongViec = new Button();
            btnPhanCong = new Button();
            btnChucVu = new Button();
            panelLuongSubmenu = new Panel();
            btnQuanLyBangLuong = new Button();
            btnChayBangLuong = new Button();
            btnLuong = new Button();
            panelHoSoSubmenu = new Panel();
            btnTrinhDo = new Button();
            btnQuanLyPhongBan = new Button();
            btnQuanLyNhanVien = new Button();
            btnThemNhanVien = new Button();
            btnHoSo = new Button();
            btnHeThong = new Button();
            panelContent = new Panel();
            panelMenu.SuspendLayout();
            panelPhanCongSubmenu.SuspendLayout();
            panelLuongSubmenu.SuspendLayout();
            panelHoSoSubmenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnTinhLuong
            // 
            btnTinhLuong.BackColor = Color.FromArgb(17, 24, 39);
            btnTinhLuong.Dock = DockStyle.Top;
            btnTinhLuong.FlatAppearance.BorderSize = 0;
            btnTinhLuong.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 65, 81);
            btnTinhLuong.FlatStyle = FlatStyle.Flat;
            btnTinhLuong.Font = new Font("Segoe UI", 9.5F);
            btnTinhLuong.ForeColor = Color.FromArgb(209, 213, 219);
            btnTinhLuong.Location = new Point(0, 128);
            btnTinhLuong.Margin = new Padding(0);
            btnTinhLuong.Name = "btnTinhLuong";
            btnTinhLuong.Padding = new Padding(55, 0, 10, 0);
            btnTinhLuong.Size = new Size(406, 64);
            btnTinhLuong.TabIndex = 2;
            btnTinhLuong.Tag = "Admin,KeToan";
            btnTinhLuong.Text = "Tính Lương & Chấm Công";
            btnTinhLuong.TextAlign = ContentAlignment.MiddleLeft;
            btnTinhLuong.UseVisualStyleBackColor = false;
            btnTinhLuong.Click += BtnSubmenu_Click;
            // 
            // btnHoSoCaNhan
            // 
            btnHoSoCaNhan.BackColor = Color.FromArgb(31, 41, 55);
            btnHoSoCaNhan.Dock = DockStyle.Top;
            btnHoSoCaNhan.FlatAppearance.BorderSize = 0;
            btnHoSoCaNhan.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 85, 99);
            btnHoSoCaNhan.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 65, 81);
            btnHoSoCaNhan.FlatStyle = FlatStyle.Flat;
            btnHoSoCaNhan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHoSoCaNhan.ForeColor = Color.FromArgb(243, 244, 246);
            btnHoSoCaNhan.Location = new Point(0, 936);
            btnHoSoCaNhan.Margin = new Padding(0);
            btnHoSoCaNhan.Name = "btnHoSoCaNhan";
            btnHoSoCaNhan.Padding = new Padding(24, 0, 0, 0);
            btnHoSoCaNhan.Size = new Size(406, 72);
            btnHoSoCaNhan.TabIndex = 12;
            btnHoSoCaNhan.Tag = "NhanVien,TruongPhong,KeToan";
            btnHoSoCaNhan.Text = "👤  Hồ Sơ Của Tôi";
            btnHoSoCaNhan.TextAlign = ContentAlignment.MiddleLeft;
            btnHoSoCaNhan.UseVisualStyleBackColor = false;
            btnHoSoCaNhan.Click += BtnMenuCaNhan_Click;
            // 
            // btnLuongCaNhan
            // 
            btnLuongCaNhan.BackColor = Color.FromArgb(31, 41, 55);
            btnLuongCaNhan.Dock = DockStyle.Top;
            btnLuongCaNhan.FlatAppearance.BorderSize = 0;
            btnLuongCaNhan.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 85, 99);
            btnLuongCaNhan.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 65, 81);
            btnLuongCaNhan.FlatStyle = FlatStyle.Flat;
            btnLuongCaNhan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLuongCaNhan.ForeColor = Color.FromArgb(243, 244, 246);
            btnLuongCaNhan.Location = new Point(0, 1008);
            btnLuongCaNhan.Margin = new Padding(0);
            btnLuongCaNhan.Name = "btnLuongCaNhan";
            btnLuongCaNhan.Padding = new Padding(24, 0, 0, 0);
            btnLuongCaNhan.Size = new Size(406, 72);
            btnLuongCaNhan.TabIndex = 13;
            btnLuongCaNhan.Tag = "NhanVien,TruongPhong,KeToan";
            btnLuongCaNhan.Text = "💰  Lương Của Tôi";
            btnLuongCaNhan.TextAlign = ContentAlignment.MiddleLeft;
            btnLuongCaNhan.UseVisualStyleBackColor = false;
            btnLuongCaNhan.Click += BtnMenuCaNhan_Click;
            // 
            // btnCongViecCaNhan
            // 
            btnCongViecCaNhan.BackColor = Color.FromArgb(31, 41, 55);
            btnCongViecCaNhan.Dock = DockStyle.Top;
            btnCongViecCaNhan.FlatAppearance.BorderSize = 0;
            btnCongViecCaNhan.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 85, 99);
            btnCongViecCaNhan.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 65, 81);
            btnCongViecCaNhan.FlatStyle = FlatStyle.Flat;
            btnCongViecCaNhan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCongViecCaNhan.ForeColor = Color.FromArgb(243, 244, 246);
            btnCongViecCaNhan.Location = new Point(0, 1080);
            btnCongViecCaNhan.Margin = new Padding(0);
            btnCongViecCaNhan.Name = "btnCongViecCaNhan";
            btnCongViecCaNhan.Padding = new Padding(24, 0, 0, 0);
            btnCongViecCaNhan.Size = new Size(406, 72);
            btnCongViecCaNhan.TabIndex = 14;
            btnCongViecCaNhan.Tag = "NhanVien,TruongPhong";
            btnCongViecCaNhan.Text = "📝  Công Việc Của Tôi";
            btnCongViecCaNhan.TextAlign = ContentAlignment.MiddleLeft;
            btnCongViecCaNhan.UseVisualStyleBackColor = false;
            btnCongViecCaNhan.Click += BtnMenuCaNhan_Click;
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.FromArgb(31, 41, 55);
            panelMenu.Controls.Add(btnCongViecCaNhan);
            panelMenu.Controls.Add(btnLuongCaNhan);
            panelMenu.Controls.Add(btnHoSoCaNhan);
            panelMenu.Controls.Add(panelPhanCongSubmenu);
            panelMenu.Controls.Add(btnPhanCong);
            panelMenu.Controls.Add(btnChucVu);
            panelMenu.Controls.Add(panelLuongSubmenu);
            panelMenu.Controls.Add(btnLuong);
            panelMenu.Controls.Add(panelHoSoSubmenu);
            panelMenu.Controls.Add(btnHoSo);
            panelMenu.Controls.Add(btnHeThong);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(406, 1627);
            panelMenu.TabIndex = 0;
            // 
            // panelPhanCongSubmenu
            // 
            panelPhanCongSubmenu.BackColor = Color.FromArgb(17, 24, 39);
            panelPhanCongSubmenu.Controls.Add(btnBaoCaoPhanCong);
            panelPhanCongSubmenu.Controls.Add(btnPhanCongCongViec);
            panelPhanCongSubmenu.Dock = DockStyle.Top;
            panelPhanCongSubmenu.Location = new Point(0, 808);
            panelPhanCongSubmenu.Margin = new Padding(0);
            panelPhanCongSubmenu.Name = "panelPhanCongSubmenu";
            panelPhanCongSubmenu.Size = new Size(406, 128);
            panelPhanCongSubmenu.TabIndex = 11;
            // 
            // btnBaoCaoPhanCong
            // 
            btnBaoCaoPhanCong.BackColor = Color.FromArgb(17, 24, 39);
            btnBaoCaoPhanCong.Dock = DockStyle.Top;
            btnBaoCaoPhanCong.FlatAppearance.BorderSize = 0;
            btnBaoCaoPhanCong.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 65, 81);
            btnBaoCaoPhanCong.FlatStyle = FlatStyle.Flat;
            btnBaoCaoPhanCong.Font = new Font("Segoe UI", 9.5F);
            btnBaoCaoPhanCong.ForeColor = Color.FromArgb(209, 213, 219);
            btnBaoCaoPhanCong.Location = new Point(0, 64);
            btnBaoCaoPhanCong.Margin = new Padding(0);
            btnBaoCaoPhanCong.Name = "btnBaoCaoPhanCong";
            btnBaoCaoPhanCong.Padding = new Padding(55, 0, 10, 0);
            btnBaoCaoPhanCong.Size = new Size(406, 64);
            btnBaoCaoPhanCong.TabIndex = 1;
            btnBaoCaoPhanCong.Tag = "Admin,TruongPhong,NhanVien";
            btnBaoCaoPhanCong.Text = "Bảng Phân Công";
            btnBaoCaoPhanCong.TextAlign = ContentAlignment.MiddleLeft;
            btnBaoCaoPhanCong.UseVisualStyleBackColor = false;
            btnBaoCaoPhanCong.Click += BtnSubmenu_Click;
            // 
            // btnPhanCongCongViec
            // 
            btnPhanCongCongViec.BackColor = Color.FromArgb(17, 24, 39);
            btnPhanCongCongViec.Dock = DockStyle.Top;
            btnPhanCongCongViec.FlatAppearance.BorderSize = 0;
            btnPhanCongCongViec.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 65, 81);
            btnPhanCongCongViec.FlatStyle = FlatStyle.Flat;
            btnPhanCongCongViec.Font = new Font("Segoe UI", 9.5F);
            btnPhanCongCongViec.ForeColor = Color.FromArgb(209, 213, 219);
            btnPhanCongCongViec.Location = new Point(0, 0);
            btnPhanCongCongViec.Margin = new Padding(0);
            btnPhanCongCongViec.Name = "btnPhanCongCongViec";
            btnPhanCongCongViec.Padding = new Padding(55, 0, 10, 0);
            btnPhanCongCongViec.Size = new Size(406, 64);
            btnPhanCongCongViec.TabIndex = 0;
            btnPhanCongCongViec.Tag = "Admin,TruongPhong";
            btnPhanCongCongViec.Text = "Phân Công Công Việc";
            btnPhanCongCongViec.TextAlign = ContentAlignment.MiddleLeft;
            btnPhanCongCongViec.UseVisualStyleBackColor = false;
            btnPhanCongCongViec.Click += BtnSubmenu_Click;
            // 
            // btnPhanCong
            // 
            btnPhanCong.BackColor = Color.FromArgb(31, 41, 55);
            btnPhanCong.Dock = DockStyle.Top;
            btnPhanCong.FlatAppearance.BorderSize = 0;
            btnPhanCong.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 85, 99);
            btnPhanCong.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 65, 81);
            btnPhanCong.FlatStyle = FlatStyle.Flat;
            btnPhanCong.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPhanCong.ForeColor = Color.FromArgb(243, 244, 246);
            btnPhanCong.Location = new Point(0, 736);
            btnPhanCong.Margin = new Padding(0);
            btnPhanCong.Name = "btnPhanCong";
            btnPhanCong.Padding = new Padding(24, 0, 0, 0);
            btnPhanCong.Size = new Size(406, 72);
            btnPhanCong.TabIndex = 10;
            btnPhanCong.Tag = "Admin,TruongPhong";
            btnPhanCong.Text = "📋  Quản Lý Phân Công";
            btnPhanCong.TextAlign = ContentAlignment.MiddleLeft;
            btnPhanCong.UseVisualStyleBackColor = false;
            btnPhanCong.Click += BtnMenu_Click;
            // 
            // btnChucVu
            // 
            btnChucVu.BackColor = Color.FromArgb(31, 41, 55);
            btnChucVu.Dock = DockStyle.Top;
            btnChucVu.FlatAppearance.BorderSize = 0;
            btnChucVu.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 85, 99);
            btnChucVu.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 65, 81);
            btnChucVu.FlatStyle = FlatStyle.Flat;
            btnChucVu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnChucVu.ForeColor = Color.FromArgb(243, 244, 246);
            btnChucVu.Location = new Point(0, 664);
            btnChucVu.Margin = new Padding(0);
            btnChucVu.Name = "btnChucVu";
            btnChucVu.Padding = new Padding(24, 0, 0, 0);
            btnChucVu.Size = new Size(406, 72);
            btnChucVu.TabIndex = 9;
            btnChucVu.Tag = "Admin,TruongPhong,KeToan";
            btnChucVu.Text = "▣  Quản Lý Chức Vụ";
            btnChucVu.TextAlign = ContentAlignment.MiddleLeft;
            btnChucVu.UseVisualStyleBackColor = false;
            btnChucVu.Click += BtnSubmenu_Click;
            // 
            // panelLuongSubmenu
            // 
            panelLuongSubmenu.BackColor = Color.FromArgb(17, 24, 39);
            panelLuongSubmenu.Controls.Add(btnTinhLuong);
            panelLuongSubmenu.Controls.Add(btnQuanLyBangLuong);
            panelLuongSubmenu.Controls.Add(btnChayBangLuong);
            panelLuongSubmenu.Dock = DockStyle.Top;
            panelLuongSubmenu.Location = new Point(0, 472);
            panelLuongSubmenu.Margin = new Padding(0);
            panelLuongSubmenu.Name = "panelLuongSubmenu";
            panelLuongSubmenu.Size = new Size(406, 192);
            panelLuongSubmenu.TabIndex = 8;
            // 
            // btnQuanLyBangLuong
            // 
            btnQuanLyBangLuong.BackColor = Color.FromArgb(17, 24, 39);
            btnQuanLyBangLuong.Dock = DockStyle.Top;
            btnQuanLyBangLuong.FlatAppearance.BorderSize = 0;
            btnQuanLyBangLuong.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 65, 81);
            btnQuanLyBangLuong.FlatStyle = FlatStyle.Flat;
            btnQuanLyBangLuong.Font = new Font("Segoe UI", 9.5F);
            btnQuanLyBangLuong.ForeColor = Color.FromArgb(209, 213, 219);
            btnQuanLyBangLuong.Location = new Point(0, 64);
            btnQuanLyBangLuong.Margin = new Padding(0);
            btnQuanLyBangLuong.Name = "btnQuanLyBangLuong";
            btnQuanLyBangLuong.Padding = new Padding(55, 0, 10, 0);
            btnQuanLyBangLuong.Size = new Size(406, 64);
            btnQuanLyBangLuong.TabIndex = 1;
            btnQuanLyBangLuong.Tag = "Admin,KeToan";
            btnQuanLyBangLuong.Text = "Quản Lý Bảng Lương";
            btnQuanLyBangLuong.TextAlign = ContentAlignment.MiddleLeft;
            btnQuanLyBangLuong.UseVisualStyleBackColor = false;
            btnQuanLyBangLuong.Click += BtnSubmenu_Click;
            // 
            // btnChayBangLuong
            // 
            btnChayBangLuong.BackColor = Color.FromArgb(17, 24, 39);
            btnChayBangLuong.Dock = DockStyle.Top;
            btnChayBangLuong.FlatAppearance.BorderSize = 0;
            btnChayBangLuong.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 65, 81);
            btnChayBangLuong.FlatStyle = FlatStyle.Flat;
            btnChayBangLuong.Font = new Font("Segoe UI", 9.5F);
            btnChayBangLuong.ForeColor = Color.FromArgb(209, 213, 219);
            btnChayBangLuong.Location = new Point(0, 0);
            btnChayBangLuong.Margin = new Padding(0);
            btnChayBangLuong.Name = "btnChayBangLuong";
            btnChayBangLuong.Padding = new Padding(55, 0, 10, 0);
            btnChayBangLuong.Size = new Size(406, 64);
            btnChayBangLuong.TabIndex = 0;
            btnChayBangLuong.Tag = "Admin,KeToan";
            btnChayBangLuong.Text = "Chạy Bảng Lương";
            btnChayBangLuong.TextAlign = ContentAlignment.MiddleLeft;
            btnChayBangLuong.UseVisualStyleBackColor = false;
            btnChayBangLuong.Click += BtnSubmenu_Click;
            // 
            // btnLuong
            // 
            btnLuong.BackColor = Color.FromArgb(31, 41, 55);
            btnLuong.Dock = DockStyle.Top;
            btnLuong.FlatAppearance.BorderSize = 0;
            btnLuong.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 85, 99);
            btnLuong.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 65, 81);
            btnLuong.FlatStyle = FlatStyle.Flat;
            btnLuong.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLuong.ForeColor = Color.FromArgb(243, 244, 246);
            btnLuong.Location = new Point(0, 400);
            btnLuong.Margin = new Padding(0);
            btnLuong.Name = "btnLuong";
            btnLuong.Padding = new Padding(24, 0, 0, 0);
            btnLuong.Size = new Size(406, 72);
            btnLuong.TabIndex = 7;
            btnLuong.Tag = "Admin,KeToan";
            btnLuong.Text = "💰  Quản Lý Lương";
            btnLuong.TextAlign = ContentAlignment.MiddleLeft;
            btnLuong.UseVisualStyleBackColor = false;
            btnLuong.Click += BtnMenu_Click;
            // 
            // panelHoSoSubmenu
            // 
            panelHoSoSubmenu.BackColor = Color.FromArgb(17, 24, 39);
            panelHoSoSubmenu.Controls.Add(btnTrinhDo);
            panelHoSoSubmenu.Controls.Add(btnQuanLyPhongBan);
            panelHoSoSubmenu.Controls.Add(btnQuanLyNhanVien);
            panelHoSoSubmenu.Controls.Add(btnThemNhanVien);
            panelHoSoSubmenu.Dock = DockStyle.Top;
            panelHoSoSubmenu.Location = new Point(0, 144);
            panelHoSoSubmenu.Margin = new Padding(0);
            panelHoSoSubmenu.Name = "panelHoSoSubmenu";
            panelHoSoSubmenu.Size = new Size(406, 256);
            panelHoSoSubmenu.TabIndex = 6;
            // 
            // btnTrinhDo
            // 
            btnTrinhDo.BackColor = Color.FromArgb(17, 24, 39);
            btnTrinhDo.Dock = DockStyle.Top;
            btnTrinhDo.FlatAppearance.BorderSize = 0;
            btnTrinhDo.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 65, 81);
            btnTrinhDo.FlatStyle = FlatStyle.Flat;
            btnTrinhDo.Font = new Font("Segoe UI", 9.5F);
            btnTrinhDo.ForeColor = Color.FromArgb(209, 213, 219);
            btnTrinhDo.Location = new Point(0, 192);
            btnTrinhDo.Margin = new Padding(0);
            btnTrinhDo.Name = "btnTrinhDo";
            btnTrinhDo.Padding = new Padding(55, 0, 10, 0);
            btnTrinhDo.Size = new Size(406, 64);
            btnTrinhDo.TabIndex = 3;
            btnTrinhDo.Tag = "Admin";
            btnTrinhDo.Text = "Quản Lý Trình Độ";
            btnTrinhDo.TextAlign = ContentAlignment.MiddleLeft;
            btnTrinhDo.UseVisualStyleBackColor = false;
            btnTrinhDo.Click += BtnSubmenu_Click;
            // 
            // btnQuanLyPhongBan
            // 
            btnQuanLyPhongBan.BackColor = Color.FromArgb(17, 24, 39);
            btnQuanLyPhongBan.Dock = DockStyle.Top;
            btnQuanLyPhongBan.FlatAppearance.BorderSize = 0;
            btnQuanLyPhongBan.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 65, 81);
            btnQuanLyPhongBan.FlatStyle = FlatStyle.Flat;
            btnQuanLyPhongBan.Font = new Font("Segoe UI", 9.5F);
            btnQuanLyPhongBan.ForeColor = Color.FromArgb(209, 213, 219);
            btnQuanLyPhongBan.Location = new Point(0, 128);
            btnQuanLyPhongBan.Margin = new Padding(0);
            btnQuanLyPhongBan.Name = "btnQuanLyPhongBan";
            btnQuanLyPhongBan.Padding = new Padding(55, 0, 10, 0);
            btnQuanLyPhongBan.Size = new Size(406, 64);
            btnQuanLyPhongBan.TabIndex = 2;
            btnQuanLyPhongBan.Tag = "Admin";
            btnQuanLyPhongBan.Text = "Quản Lý Phòng Ban";
            btnQuanLyPhongBan.TextAlign = ContentAlignment.MiddleLeft;
            btnQuanLyPhongBan.UseVisualStyleBackColor = false;
            btnQuanLyPhongBan.Click += BtnSubmenu_Click;
            // 
            // btnQuanLyNhanVien
            // 
            btnQuanLyNhanVien.BackColor = Color.FromArgb(17, 24, 39);
            btnQuanLyNhanVien.Dock = DockStyle.Top;
            btnQuanLyNhanVien.FlatAppearance.BorderSize = 0;
            btnQuanLyNhanVien.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 65, 81);
            btnQuanLyNhanVien.FlatStyle = FlatStyle.Flat;
            btnQuanLyNhanVien.Font = new Font("Segoe UI", 9.5F);
            btnQuanLyNhanVien.ForeColor = Color.FromArgb(209, 213, 219);
            btnQuanLyNhanVien.Location = new Point(0, 64);
            btnQuanLyNhanVien.Margin = new Padding(0);
            btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            btnQuanLyNhanVien.Padding = new Padding(55, 0, 10, 0);
            btnQuanLyNhanVien.Size = new Size(406, 64);
            btnQuanLyNhanVien.TabIndex = 1;
            btnQuanLyNhanVien.Tag = "Admin,TruongPhong,KeToan";
            btnQuanLyNhanVien.Text = "Danh Sách Hồ Sơ";
            btnQuanLyNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            btnQuanLyNhanVien.UseVisualStyleBackColor = false;
            btnQuanLyNhanVien.Click += BtnSubmenu_Click;
            // 
            // btnThemNhanVien
            // 
            btnThemNhanVien.BackColor = Color.FromArgb(17, 24, 39);
            btnThemNhanVien.Dock = DockStyle.Top;
            btnThemNhanVien.FlatAppearance.BorderSize = 0;
            btnThemNhanVien.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 65, 81);
            btnThemNhanVien.FlatStyle = FlatStyle.Flat;
            btnThemNhanVien.Font = new Font("Segoe UI", 9.5F);
            btnThemNhanVien.ForeColor = Color.FromArgb(209, 213, 219);
            btnThemNhanVien.Location = new Point(0, 0);
            btnThemNhanVien.Margin = new Padding(0);
            btnThemNhanVien.Name = "btnThemNhanVien";
            btnThemNhanVien.Padding = new Padding(55, 0, 10, 0);
            btnThemNhanVien.Size = new Size(406, 64);
            btnThemNhanVien.TabIndex = 0;
            btnThemNhanVien.Tag = "Admin,TruongPhong";
            btnThemNhanVien.Text = "Thêm Nhân Viên";
            btnThemNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            btnThemNhanVien.UseVisualStyleBackColor = false;
            btnThemNhanVien.Click += BtnSubmenu_Click;
            // 
            // btnHoSo
            // 
            btnHoSo.BackColor = Color.FromArgb(31, 41, 55);
            btnHoSo.Dock = DockStyle.Top;
            btnHoSo.FlatAppearance.BorderSize = 0;
            btnHoSo.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 85, 99);
            btnHoSo.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 65, 81);
            btnHoSo.FlatStyle = FlatStyle.Flat;
            btnHoSo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHoSo.ForeColor = Color.FromArgb(243, 244, 246);
            btnHoSo.Location = new Point(0, 72);
            btnHoSo.Margin = new Padding(0);
            btnHoSo.Name = "btnHoSo";
            btnHoSo.Padding = new Padding(24, 0, 0, 0);
            btnHoSo.Size = new Size(406, 72);
            btnHoSo.TabIndex = 5;
            btnHoSo.Tag = "Admin,TruongPhong,KeToan";
            btnHoSo.Text = "👤  Quản Lý Hồ Sơ";
            btnHoSo.TextAlign = ContentAlignment.MiddleLeft;
            btnHoSo.UseVisualStyleBackColor = false;
            btnHoSo.Click += BtnMenu_Click;
            // 
            // btnHeThong
            // 
            btnHeThong.BackColor = Color.FromArgb(31, 41, 55);
            btnHeThong.Dock = DockStyle.Top;
            btnHeThong.FlatAppearance.BorderSize = 0;
            btnHeThong.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 85, 99);
            btnHeThong.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 65, 81);
            btnHeThong.FlatStyle = FlatStyle.Flat;
            btnHeThong.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHeThong.ForeColor = Color.FromArgb(243, 244, 246);
            btnHeThong.Location = new Point(0, 0);
            btnHeThong.Margin = new Padding(0);
            btnHeThong.Name = "btnHeThong";
            btnHeThong.Padding = new Padding(24, 0, 0, 0);
            btnHeThong.Size = new Size(406, 72);
            btnHeThong.TabIndex = 4;
            btnHeThong.Tag = "Admin";
            btnHeThong.Text = "⚙  Hệ Thống";
            btnHeThong.TextAlign = ContentAlignment.MiddleLeft;
            btnHeThong.UseVisualStyleBackColor = false;
            btnHeThong.Click += BtnSubmenu_Click;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(248, 250, 252);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(406, 0);
            panelContent.Margin = new Padding(0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(2088, 1627);
            panelContent.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(2494, 1627);
            Controls.Add(panelContent);
            Controls.Add(panelMenu);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(0);
            MinimumSize = new Size(2520, 1698);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Nhân Sự";
            panelMenu.ResumeLayout(false);
            panelPhanCongSubmenu.ResumeLayout(false);
            panelLuongSubmenu.ResumeLayout(false);
            panelHoSoSubmenu.ResumeLayout(false);
            ResumeLayout(false);
        }


        #endregion

        // ... (Giữ nguyên khai báo biến cũ) ...
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnHeThong;
        private System.Windows.Forms.Button btnHoSo;
        private System.Windows.Forms.Panel panelHoSoSubmenu;
        private System.Windows.Forms.Button btnTrinhDo;
        private System.Windows.Forms.Button btnQuanLyPhongBan;
        private System.Windows.Forms.Button btnQuanLyNhanVien;
        private System.Windows.Forms.Button btnThemNhanVien;
        private System.Windows.Forms.Panel panelLuongSubmenu;
        private System.Windows.Forms.Button btnQuanLyBangLuong;
        private System.Windows.Forms.Button btnChayBangLuong;
        private System.Windows.Forms.Button btnLuong;
        private System.Windows.Forms.Button btnChucVu;
        private System.Windows.Forms.Button btnPhanCong;
        private System.Windows.Forms.Panel panelPhanCongSubmenu;
        private System.Windows.Forms.Button btnBaoCaoPhanCong;

        private System.Windows.Forms.Button btnPhanCongCongViec;

        // ⭐ KHAI BÁO BIẾN CHO NÚT MỚI ⭐
        private System.Windows.Forms.Button btnTinhLuong;

        // --- KHAI BÁO CÁC NÚT CÁ NHÂN MỚI ---
        private System.Windows.Forms.Button btnHoSoCaNhan;
        private System.Windows.Forms.Button btnLuongCaNhan;
        private System.Windows.Forms.Button btnCongViecCaNhan;
    }
}