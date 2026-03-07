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
            // ⭐ KHAI BÁO NÚT TÍNH LƯƠNG MỚI ⭐
            this.btnTinhLuong = new System.Windows.Forms.Button();

            // Khai báo các nút cá nhân mới
            this.btnHoSoCaNhan = new System.Windows.Forms.Button();
            this.btnLuongCaNhan = new System.Windows.Forms.Button();
            this.btnCongViecCaNhan = new System.Windows.Forms.Button();

            // Khai báo các control cũ
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelPhanCongSubmenu = new System.Windows.Forms.Panel();
            this.btnBaoCaoPhanCong = new System.Windows.Forms.Button();
            this.btnPhanCongCongViec = new System.Windows.Forms.Button();
            this.btnPhanCong = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.panelLuongSubmenu = new System.Windows.Forms.Panel();
            this.btnQuanLyBangLuong = new System.Windows.Forms.Button();
            this.btnChayBangLuong = new System.Windows.Forms.Button();
            this.btnLuong = new System.Windows.Forms.Button();
            this.panelHoSoSubmenu = new System.Windows.Forms.Panel();
            this.btnTrinhDo = new System.Windows.Forms.Button();
            this.btnQuanLyPhongBan = new System.Windows.Forms.Button();
            this.btnQuanLyNhanVien = new System.Windows.Forms.Button();
            this.btnThemNhanVien = new System.Windows.Forms.Button();
            this.btnHoSo = new System.Windows.Forms.Button();
            this.btnHeThong = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();

            this.panelMenu.SuspendLayout();
            this.panelPhanCongSubmenu.SuspendLayout();
            this.panelLuongSubmenu.SuspendLayout();
            this.panelHoSoSubmenu.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            // Đã thêm các nút cá nhân mới vào đây
            this.panelMenu.Controls.Add(this.btnCongViecCaNhan);
            this.panelMenu.Controls.Add(this.btnLuongCaNhan);
            this.panelMenu.Controls.Add(this.btnHoSoCaNhan);

            // Các nút cũ được giữ lại
            this.panelMenu.Controls.Add(this.panelPhanCongSubmenu);
            this.panelMenu.Controls.Add(this.btnPhanCong);
            this.panelMenu.Controls.Add(this.btnBaoCao);
            this.panelMenu.Controls.Add(this.panelLuongSubmenu);
            this.panelMenu.Controls.Add(this.btnLuong);
            this.panelMenu.Controls.Add(this.panelHoSoSubmenu);
            this.panelMenu.Controls.Add(this.btnHoSo);
            this.panelMenu.Controls.Add(this.btnHeThong);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(406, 1627);
            this.panelMenu.TabIndex = 0;

            // --- CÁC NÚT CÁ NHÂN (Được thêm mới vào Menu chính) ---
            // 
            // btnCongViecCaNhan (Nút cuối cùng của NV)
            // 
            this.btnCongViecCaNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCongViecCaNhan.FlatAppearance.BorderSize = 0;
            this.btnCongViecCaNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCongViecCaNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCongViecCaNhan.ForeColor = System.Drawing.Color.White;
            this.btnCongViecCaNhan.Location = new System.Drawing.Point(0, 1040); // Điều chỉnh vị trí sau Submenu Phân Công
            this.btnCongViecCaNhan.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCongViecCaNhan.Name = "btnCongViecCaNhan";
            this.btnCongViecCaNhan.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnCongViecCaNhan.Size = new System.Drawing.Size(406, 80);
            this.btnCongViecCaNhan.TabIndex = 14;
            this.btnCongViecCaNhan.Tag = "NhanVien,TruongPhong"; // Nhân viên và Trưởng phòng đều xem được
            this.btnCongViecCaNhan.Text = "📝 Công Việc Của Tôi";
            this.btnCongViecCaNhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCongViecCaNhan.UseVisualStyleBackColor = true;
            this.btnCongViecCaNhan.Click += new System.EventHandler(this.BtnMenuCaNhan_Click);

            // 
            // btnLuongCaNhan
            // 
            this.btnLuongCaNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLuongCaNhan.FlatAppearance.BorderSize = 0;
            this.btnLuongCaNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuongCaNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuongCaNhan.ForeColor = System.Drawing.Color.White;
            this.btnLuongCaNhan.Location = new System.Drawing.Point(0, 1120); // Điều chỉnh vị trí sau btnCongViecCaNhan
            this.btnLuongCaNhan.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnLuongCaNhan.Name = "btnLuongCaNhan";
            this.btnLuongCaNhan.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnLuongCaNhan.Size = new System.Drawing.Size(406, 80);
            this.btnLuongCaNhan.TabIndex = 13;
            this.btnLuongCaNhan.Tag = "NhanVien,TruongPhong,KeToan";
            this.btnLuongCaNhan.Text = "💰 Lương Của Tôi";
            this.btnLuongCaNhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuongCaNhan.UseVisualStyleBackColor = true;
            this.btnLuongCaNhan.Click += new System.EventHandler(this.BtnMenuCaNhan_Click);

            // 
            // btnHoSoCaNhan
            // 
            this.btnHoSoCaNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoSoCaNhan.FlatAppearance.BorderSize = 0;
            this.btnHoSoCaNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoSoCaNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoSoCaNhan.ForeColor = System.Drawing.Color.White;
            this.btnHoSoCaNhan.Location = new System.Drawing.Point(0, 1200); // Điều chỉnh vị trí sau btnLuongCaNhan
            this.btnHoSoCaNhan.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnHoSoCaNhan.Name = "btnHoSoCaNhan";
            this.btnHoSoCaNhan.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnHoSoCaNhan.Size = new System.Drawing.Size(406, 80);
            this.btnHoSoCaNhan.TabIndex = 12;
            this.btnHoSoCaNhan.Tag = "NhanVien,TruongPhong,KeToan";
            this.btnHoSoCaNhan.Text = "🧑 Hồ Sơ Của Tôi";
            this.btnHoSoCaNhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoSoCaNhan.UseVisualStyleBackColor = true;
            this.btnHoSoCaNhan.Click += new System.EventHandler(this.BtnMenuCaNhan_Click);

            // --- CÁC NÚT VÀ SUBMENU CŨ (Giữ nguyên cấu trúc) ---

            // 
            // panelPhanCongSubmenu
            // 
            this.panelPhanCongSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelPhanCongSubmenu.Controls.Add(this.btnBaoCaoPhanCong);
            this.panelPhanCongSubmenu.Controls.Add(this.btnPhanCongCongViec);
            this.panelPhanCongSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPhanCongSubmenu.Location = new System.Drawing.Point(0, 880);
            this.panelPhanCongSubmenu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelPhanCongSubmenu.Name = "panelPhanCongSubmenu";
            this.panelPhanCongSubmenu.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.panelPhanCongSubmenu.Size = new System.Drawing.Size(406, 160);
            this.panelPhanCongSubmenu.TabIndex = 11;

            // 
            // btnBaoCaoPhanCong
            // 
            this.btnBaoCaoPhanCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnBaoCaoPhanCong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaoCaoPhanCong.FlatAppearance.BorderSize = 0;
            this.btnBaoCaoPhanCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCaoPhanCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCaoPhanCong.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBaoCaoPhanCong.Location = new System.Drawing.Point(16, 80);
            this.btnBaoCaoPhanCong.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnBaoCaoPhanCong.Name = "btnBaoCaoPhanCong";
            this.btnBaoCaoPhanCong.Padding = new System.Windows.Forms.Padding(49, 0, 0, 0);
            this.btnBaoCaoPhanCong.Size = new System.Drawing.Size(390, 80);
            this.btnBaoCaoPhanCong.TabIndex = 1;
            this.btnBaoCaoPhanCong.Tag = "Admin,TruongPhong,NhanVien";
            this.btnBaoCaoPhanCong.Text = "Bảng Phân Công (Quản lý)";
            this.btnBaoCaoPhanCong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCaoPhanCong.UseVisualStyleBackColor = false;
            this.btnBaoCaoPhanCong.Click += new System.EventHandler(this.BtnSubmenu_Click);

            // 
            // btnPhanCongCongViec
            // 
            this.btnPhanCongCongViec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnPhanCongCongViec.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhanCongCongViec.FlatAppearance.BorderSize = 0;
            this.btnPhanCongCongViec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhanCongCongViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanCongCongViec.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPhanCongCongViec.Location = new System.Drawing.Point(16, 0);
            this.btnPhanCongCongViec.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnPhanCongCongViec.Name = "btnPhanCongCongViec";
            this.btnPhanCongCongViec.Padding = new System.Windows.Forms.Padding(49, 0, 0, 0);
            this.btnPhanCongCongViec.Size = new System.Drawing.Size(390, 80);
            this.btnPhanCongCongViec.TabIndex = 0;
            this.btnPhanCongCongViec.Tag = "Admin,TruongPhong";
            this.btnPhanCongCongViec.Text = "Phân Công Công Việc";
            this.btnPhanCongCongViec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhanCongCongViec.UseVisualStyleBackColor = false;
            this.btnPhanCongCongViec.Click += new System.EventHandler(this.BtnSubmenu_Click);

            // 
            // btnPhanCong
            // 
            this.btnPhanCong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhanCong.FlatAppearance.BorderSize = 0;
            this.btnPhanCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhanCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanCong.ForeColor = System.Drawing.Color.White;
            this.btnPhanCong.Location = new System.Drawing.Point(0, 800);
            this.btnPhanCong.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnPhanCong.Size = new System.Drawing.Size(406, 80);
            this.btnPhanCong.TabIndex = 10;
            this.btnPhanCong.Tag = "Admin,TruongPhong"; // Nút cha, không cần cho NhanVien
            this.btnPhanCong.Text = "📋 Quản Lý Phân Công";
            this.btnPhanCong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhanCong.UseVisualStyleBackColor = true;
            this.btnPhanCong.Click += new System.EventHandler(this.BtnMenu_Click);

            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaoCao.FlatAppearance.BorderSize = 0;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnBaoCao.Location = new System.Drawing.Point(0, 720);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnBaoCao.Size = new System.Drawing.Size(406, 80);
            this.btnBaoCao.TabIndex = 9;
            this.btnBaoCao.Tag = "Admin,TruongPhong,KeToan";
            this.btnBaoCao.Text = "📈 Báo Cáo Phân Tích";
            this.btnBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.BtnSubmenu_Click);

            // 
            // panelLuongSubmenu
            // 
            this.panelLuongSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));

            // ⭐ ĐẢO NGƯỢC THỨ TỰ THÊM NÚT ĐỂ btnTinhLuong NẰM TRÊN CÙNG KHI DÙNG DockStyle.Top ⭐
            // (Các nút thêm sau DockStyle.Top sẽ nằm ở vị trí cao hơn)
            this.panelLuongSubmenu.Controls.Add(this.btnTinhLuong);         // 1. Tính Lương (Nằm trên cùng)
            this.panelLuongSubmenu.Controls.Add(this.btnQuanLyBangLuong);   // 2. Quản Lý Bảng Lương
            this.panelLuongSubmenu.Controls.Add(this.btnChayBangLuong);     // 3. Chạy Bảng Lương (Nằm dưới cùng)

            this.panelLuongSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLuongSubmenu.Location = new System.Drawing.Point(0, 560);
            this.panelLuongSubmenu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelLuongSubmenu.Name = "panelLuongSubmenu";
            this.panelLuongSubmenu.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.panelLuongSubmenu.Size = new System.Drawing.Size(406, 240); // 3 nút * 80px = 240px
            this.panelLuongSubmenu.TabIndex = 8;

            // ⭐ CẤU HÌNH NÚT TÍNH LƯƠNG MỚI ⭐
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnTinhLuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTinhLuong.FlatAppearance.BorderSize = 0;
            this.btnTinhLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinhLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhLuong.ForeColor = System.Drawing.Color.WhiteSmoke;
            // Không cần đặt Location thủ công, Dock.Top sẽ tự tính
            this.btnTinhLuong.Location = new System.Drawing.Point(16, 160); // Vị trí này sẽ là vị trí cao nhất (160)
            this.btnTinhLuong.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Padding = new System.Windows.Forms.Padding(49, 0, 0, 0);
            this.btnTinhLuong.Size = new System.Drawing.Size(390, 80);
            this.btnTinhLuong.TabIndex = 2;
            this.btnTinhLuong.Tag = "Admin,KeToan";
            this.btnTinhLuong.Text = "Tính Lương & Chấm Công";
            this.btnTinhLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTinhLuong.UseVisualStyleBackColor = false;

            // ⭐ GÁN SỰ KIỆN CLICK ĐÚNG CHO NÚT TÍNH LƯƠNG ⭐
            this.btnTinhLuong.Click += new System.EventHandler(this.BtnSubmenu_Click);
            // ⭐ CẤU HÌNH NÚT TÍNH LƯƠNG MỚI (Vị trí đầu tiên: Dock.Top, Location 0) ⭐
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnTinhLuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTinhLuong.FlatAppearance.BorderSize = 0;
            this.btnTinhLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinhLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhLuong.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTinhLuong.Location = new System.Drawing.Point(16, 160); // Vị trí này sẽ nằm trên cùng vì Controls được thêm theo thứ tự ngược lại (bottom-up)
            this.btnTinhLuong.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Padding = new System.Windows.Forms.Padding(49, 0, 0, 0);
            this.btnTinhLuong.Size = new System.Drawing.Size(390, 80);
            this.btnTinhLuong.TabIndex = 2; // Gán TabIndex khác
            this.btnTinhLuong.Tag = "Admin,KeToan";
            this.btnTinhLuong.Text = "Tính Lương & Chấm Công";
            this.btnTinhLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTinhLuong.UseVisualStyleBackColor = false;
            this.btnTinhLuong.Click += new System.EventHandler(this.BtnSubmenu_Click);

            // 
            // btnQuanLyBangLuong (Vị trí đã được điều chỉnh)
            // 
            this.btnQuanLyBangLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnQuanLyBangLuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyBangLuong.FlatAppearance.BorderSize = 0;
            this.btnQuanLyBangLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyBangLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyBangLuong.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuanLyBangLuong.Location = new System.Drawing.Point(16, 80); // Vị trí 80 (Thứ hai)
            this.btnQuanLyBangLuong.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnQuanLyBangLuong.Name = "btnQuanLyBangLuong";
            this.btnQuanLyBangLuong.Padding = new System.Windows.Forms.Padding(49, 0, 0, 0);
            this.btnQuanLyBangLuong.Size = new System.Drawing.Size(390, 80);
            this.btnQuanLyBangLuong.TabIndex = 1;
            this.btnQuanLyBangLuong.Tag = "Admin,KeToan";
            this.btnQuanLyBangLuong.Text = "Quản Lý Bảng Lương (Chung)";
            this.btnQuanLyBangLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyBangLuong.UseVisualStyleBackColor = false;
            this.btnQuanLyBangLuong.Click += new System.EventHandler(this.BtnSubmenu_Click);

            // 
            // btnChayBangLuong (Vị trí đã được điều chỉnh)
            // 
            this.btnChayBangLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnChayBangLuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChayBangLuong.FlatAppearance.BorderSize = 0;
            this.btnChayBangLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChayBangLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChayBangLuong.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnChayBangLuong.Location = new System.Drawing.Point(16, 0); // Vị trí 0 (Thứ ba)
            this.btnChayBangLuong.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnChayBangLuong.Name = "btnChayBangLuong";
            this.btnChayBangLuong.Padding = new System.Windows.Forms.Padding(49, 0, 0, 0);
            this.btnChayBangLuong.Size = new System.Drawing.Size(390, 80);
            this.btnChayBangLuong.TabIndex = 0;
            this.btnChayBangLuong.Tag = "Admin,KeToan";
            this.btnChayBangLuong.Text = "Chạy Bảng Lương";
            this.btnChayBangLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChayBangLuong.UseVisualStyleBackColor = false;
            this.btnChayBangLuong.Click += new System.EventHandler(this.BtnSubmenu_Click);

            // 
            // btnLuong
            // 
            this.btnLuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLuong.FlatAppearance.BorderSize = 0;
            this.btnLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuong.ForeColor = System.Drawing.Color.White;
            this.btnLuong.Location = new System.Drawing.Point(0, 480);
            this.btnLuong.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnLuong.Name = "btnLuong";
            this.btnLuong.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnLuong.Size = new System.Drawing.Size(406, 80);
            this.btnLuong.TabIndex = 7;
            this.btnLuong.Tag = "Admin,KeToan"; // Nút cha, không cần cho NhanVien
            this.btnLuong.Text = "💸 Quản Lý Lương";
            this.btnLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuong.UseVisualStyleBackColor = true;
            this.btnLuong.Click += new System.EventHandler(this.BtnMenu_Click);

            // ... (Giữ nguyên các Panel HoSo, Nút HoSo, Nút HeThong và panelContent) ...

            // 
            // panelHoSoSubmenu
            // 
            this.panelHoSoSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelHoSoSubmenu.Controls.Add(this.btnTrinhDo);
            this.panelHoSoSubmenu.Controls.Add(this.btnQuanLyPhongBan);
            this.panelHoSoSubmenu.Controls.Add(this.btnQuanLyNhanVien);
            this.panelHoSoSubmenu.Controls.Add(this.btnThemNhanVien);
            this.panelHoSoSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHoSoSubmenu.Location = new System.Drawing.Point(0, 160);
            this.panelHoSoSubmenu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelHoSoSubmenu.Name = "panelHoSoSubmenu";
            this.panelHoSoSubmenu.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.panelHoSoSubmenu.Size = new System.Drawing.Size(406, 320);
            this.panelHoSoSubmenu.TabIndex = 6;
            // 
            // btnTrinhDo
            // 
            this.btnTrinhDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnTrinhDo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrinhDo.FlatAppearance.BorderSize = 0;
            this.btnTrinhDo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrinhDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrinhDo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTrinhDo.Location = new System.Drawing.Point(16, 240);
            this.btnTrinhDo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnTrinhDo.Name = "btnTrinhDo";
            this.btnTrinhDo.Padding = new System.Windows.Forms.Padding(49, 0, 0, 0);
            this.btnTrinhDo.Size = new System.Drawing.Size(390, 80);
            this.btnTrinhDo.TabIndex = 3;
            this.btnTrinhDo.Tag = "Admin"; // Trưởng phòng chỉ quản lý nhân viên, không quản lý Trình độ/Phòng ban
            this.btnTrinhDo.Text = "Quản Lý Trình Độ";
            this.btnTrinhDo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrinhDo.UseVisualStyleBackColor = false;
            this.btnTrinhDo.Click += new System.EventHandler(this.BtnSubmenu_Click);
            // 
            // btnQuanLyPhongBan
            // 
            this.btnQuanLyPhongBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnQuanLyPhongBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyPhongBan.FlatAppearance.BorderSize = 0;
            this.btnQuanLyPhongBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyPhongBan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuanLyPhongBan.Location = new System.Drawing.Point(16, 160);
            this.btnQuanLyPhongBan.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnQuanLyPhongBan.Name = "btnQuanLyPhongBan";
            this.btnQuanLyPhongBan.Padding = new System.Windows.Forms.Padding(49, 0, 0, 0);
            this.btnQuanLyPhongBan.Size = new System.Drawing.Size(390, 80);
            this.btnQuanLyPhongBan.TabIndex = 2;
            this.btnQuanLyPhongBan.Tag = "Admin"; // Trưởng phòng chỉ quản lý nhân viên, không quản lý Phòng Ban
            this.btnQuanLyPhongBan.Text = "Quản Lý Phòng Ban";
            this.btnQuanLyPhongBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyPhongBan.UseVisualStyleBackColor = false;
            this.btnQuanLyPhongBan.Click += new System.EventHandler(this.BtnSubmenu_Click);
            // 
            // btnQuanLyNhanVien
            // 
            this.btnQuanLyNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnQuanLyNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyNhanVien.FlatAppearance.BorderSize = 0;
            this.btnQuanLyNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyNhanVien.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuanLyNhanVien.Location = new System.Drawing.Point(16, 80);
            this.btnQuanLyNhanVien.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            this.btnQuanLyNhanVien.Padding = new System.Windows.Forms.Padding(49, 0, 0, 0);
            this.btnQuanLyNhanVien.Size = new System.Drawing.Size(390, 80);
            this.btnQuanLyNhanVien.TabIndex = 1;
            this.btnQuanLyNhanVien.Tag = "Admin,TruongPhong,KeToan";
            this.btnQuanLyNhanVien.Text = "Danh Sách Hồ Sơ (Xem/Sửa/Xóa)";
            this.btnQuanLyNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyNhanVien.UseVisualStyleBackColor = false;
            this.btnQuanLyNhanVien.Click += new System.EventHandler(this.BtnSubmenu_Click);
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnThemNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThemNhanVien.FlatAppearance.BorderSize = 0;
            this.btnThemNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNhanVien.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnThemNhanVien.Location = new System.Drawing.Point(16, 0);
            this.btnThemNhanVien.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Padding = new System.Windows.Forms.Padding(49, 0, 0, 0);
            this.btnThemNhanVien.Size = new System.Drawing.Size(390, 80);
            this.btnThemNhanVien.TabIndex = 0;
            this.btnThemNhanVien.Tag = "Admin,TruongPhong";
            this.btnThemNhanVien.Text = "Thêm Nhân Viên (Thao tác Thêm)";
            this.btnThemNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemNhanVien.UseVisualStyleBackColor = false;
            this.btnThemNhanVien.Click += new System.EventHandler(this.BtnSubmenu_Click);
            // 
            // btnHoSo
            // 
            this.btnHoSo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoSo.FlatAppearance.BorderSize = 0;
            this.btnHoSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoSo.ForeColor = System.Drawing.Color.White;
            this.btnHoSo.Location = new System.Drawing.Point(0, 80);
            this.btnHoSo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnHoSo.Name = "btnHoSo";
            this.btnHoSo.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnHoSo.Size = new System.Drawing.Size(406, 80);
            this.btnHoSo.TabIndex = 5;
            this.btnHoSo.Tag = "Admin,TruongPhong,KeToan"; // Nút cha
            this.btnHoSo.Text = "👤 Quản Lý Hồ Sơ";
            this.btnHoSo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoSo.UseVisualStyleBackColor = true;
            this.btnHoSo.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // btnHeThong
            // 
            this.btnHeThong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHeThong.FlatAppearance.BorderSize = 0;
            this.btnHeThong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeThong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeThong.ForeColor = System.Drawing.Color.White;
            this.btnHeThong.Location = new System.Drawing.Point(0, 0);
            this.btnHeThong.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnHeThong.Size = new System.Drawing.Size(406, 80);
            this.btnHeThong.TabIndex = 4;
            this.btnHeThong.Tag = "Admin"; // Chỉ Admin quản lý hệ thống
            this.btnHeThong.Text = "⚙️ Hệ Thống";
            this.btnHeThong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHeThong.UseVisualStyleBackColor = true;
            this.btnHeThong.Click += new System.EventHandler(this.BtnSubmenu_Click);

            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(406, 0);
            this.panelContent.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(2088, 1627);
            this.panelContent.TabIndex = 1;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2494, 1627);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimumSize = new System.Drawing.Size(1934, 1329);
            this.Name = "Form1";
            this.Text = "Quản Lý Nhân Sự";
            this.panelMenu.ResumeLayout(false);
            this.panelPhanCongSubmenu.ResumeLayout(false);
            this.panelLuongSubmenu.ResumeLayout(false);
            this.panelHoSoSubmenu.ResumeLayout(false);
            this.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnBaoCao;
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