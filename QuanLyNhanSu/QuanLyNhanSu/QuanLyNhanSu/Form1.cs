using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace QuanLyNhanSu
{
    public partial class Form1 : Form
    {
        // Khai báo các thuộc tính chung
        protected string userQuyen = "";
        protected int userID = 0;
        protected string userName = "";

        // Constructor mặc định
        public Form1()
        {
            InitializeComponent();
            this.HideSubMenus();
            FixAllButtonsStyle();
        }

        // Constructor có tham số để nhận thông tin người dùng đăng nhập
        public Form1(string quyen, int nhanVienID, string tenNV)
        {
            InitializeComponent();
            this.userQuyen = quyen;
            this.userID = nhanVienID;
            this.userName = tenNV;

            this.HideSubMenus();
            this.ApplyPermissions();
        }

        // --- HÀM XỬ LÝ SỰ KIỆN (Dùng protected virtual để Form con ghi đè) ---

        // 1. Hàm xử lý Click cho các nút MENU chính (Submenu)
        protected virtual void BtnMenu_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            this.ToggleSubMenu(btn);
        }

        private void FixAllButtonsStyle()
        {
            foreach (var btn in this.Controls.OfType<Button>())
            {
                btn.UseVisualStyleBackColor = false;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.FromArgb(0, 150, 136);
                btn.ForeColor = Color.White;
            }

            // Fix cho button nằm trong Panel (panelMenu)
            foreach (Panel pnl in this.Controls.OfType<Panel>())
            {
                foreach (var btn in pnl.Controls.OfType<Button>())
                {
                    btn.UseVisualStyleBackColor = false;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = Color.FromArgb(0, 150, 136);
                    btn.ForeColor = Color.White;
                }
            }
        }
        // 2. Hàm xử lý Click cho các nút SUBMENU (Nút con)
        protected virtual void BtnSubmenu_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            this.HideSubMenus();
            System.Windows.Forms.UserControl uc = null;

            switch (btn.Name)
            {
                // --- CHỨC NĂNG LƯƠNG (KeToan, Admin, TruongPhong) ---
                case "btnTinhLuong":
                    // Dành cho Kế toán/Admin
                    uc = new QuanLyNhanSu.usercontrol.TinhLuong(this.userID);
                    break;

                case "btnQuanLyBangLuong":
                    // Lương Chung (Cho TruongPhong, KeToan xem Báo cáo/Quản lý bảng lương)
                    uc = new QuanLyNhanSu.usercontrol.BaoCaoPhanTich();
                    break;

                case "btnChayBangLuong":
                    // Dành cho Kế toán/Admin
                    uc = new QuanLyNhanSu.usercontrol.BangLuong();
                    break;

                // --- CHỨC NĂNG HỒ SƠ/QUẢN LÝ (TruongPhong, Admin) ---

                case "btnThemNhanVien":
                    // KIỂM TRA LẠI: Tên UserControl "ThemNhanVien" có đúng không?
                    // Nếu bạn đặt tên là "UcThemNhanVien" thì phải sửa thành: new QuanLyNhanSu.usercontrol.UcThemNhanVien();
                    uc = new QuanLyNhanSu.usercontrol.ThemNhanVien();
                    break;

                case "btnQuanLyNhanVien":
                    // Quản lý nhân viên (Xem, Sửa, Xóa). Bạn đã sửa thành QuanLyNhanVien() - Tên này phải khớp chính xác với tên file.
                    uc = new QuanLyNhanSu.usercontrol.QuanLyNhanVien();
                    break;

                case "btnQuanLyPhongBan":
                    // Bạn đã sửa thành Uc_phongBan()
                    uc = new QuanLyNhanSu.usercontrol.Uc_phongBan();
                    break;

                case "btnQuanLyTrinhDo":
                    // Bạn đã sửa thành TrinhDo()
                    uc = new QuanLyNhanSu.usercontrol.TrinhDo();
                    break;

                // --- CHỨC NĂNG PHÂN CÔNG (TruongPhong, Admin) ---

                case "btnBangPhanCongQuanLy":
                    // Bảng phân công chung (Không truyền ID, hiển thị tất cả)
                    uc = new QuanLyNhanSu.usercontrol.BaoCaoPhanCong();
                    break;

                // --- CHỨC NĂNG KHÁC ---
                case "btnBaoCaoPhanTich":
                    // Nút này đã bị ẩn trong ApplyPermissions(), ta vẫn giữ logic phòng ngừa.
                    MessageBox.Show($"Chức năng '{btn.Text}' đã bị ẩn và không thể sử dụng.", "Thông báo");
                    break;
            }

            if (uc != null)
            {
                this.LoadControlToPanel(uc);
            }
            else if (btn.Name != "btnBaoCaoPhanTich")
            {
                MessageBox.Show($"Chức năng '{btn.Text}' đã được click nhưng chưa được triển khai UserControl.", "Thông báo");
            }
        }

        // 3. Hàm xử lý Click cho các nút CHỨC NĂNG CÁ NHÂN (Cho FormNhanVien ghi đè)
        protected virtual void BtnMenuCaNhan_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show($"Chức năng cá nhân '{btn.Text}' đã được click. Cần triển khai logic tải UserControl trong Form con.", "Thông báo");
        }

        // 4. HÀM XỬ LÝ CLICK CHO NÚT TÍNH LƯƠNG MỚI (Đã loại bỏ sự kiện cũ)
        protected virtual void BtnTinhLuong_Click(object sender, EventArgs e)
        {
            this.HideSubMenus();
            MessageBox.Show($"Chức năng 'Tính Lương' đã được click. Cần triển khai logic tải UserControl.", "Thông báo");
        }

        // --- CÁC HÀM HỖ TRỢ MENU VÀ PHÂN QUYỀN ---

        // Hàm ẩn tất cả Submenu (Giữ nguyên)
        protected void HideSubMenus()
        {
            var subPanels = this.Controls.Cast<Control>().OfType<Panel>()
                .Where(p => p.Name.EndsWith("Submenu", StringComparison.OrdinalIgnoreCase));

            foreach (var panel in subPanels)
            {
                panel.Visible = false;
            }
        }

        // Hàm bật/tắt Submenu (Giữ nguyên)
        protected void ToggleSubMenu(Button menuButton)
        {
            Panel subMenu = null;
            // Cần thêm logic tìm kiếm Panel Submenu tương ứng nếu bạn có nhiều Panel
            // ... (Giữ nguyên logic ToggleSubMenu của bạn) ...

            if (subMenu != null)
            {
                if (subMenu.Visible == true)
                {
                    subMenu.Visible = false;
                }
                else
                {
                    this.HideSubMenus();
                    subMenu.Visible = true;
                }
            }
        }

        // Hàm Phân quyền hiển thị các nút trên menu
        // Hàm Phân quyền hiển thị các nút trên menu
        protected void ApplyPermissions()
        {
            if (string.IsNullOrEmpty(this.userQuyen)) return;

            // --- KHAI BÁO CÁC NÚT CẦN THIẾT ---
            Button btnHoSoCaNhan = this.Controls.Find("btnHoSoCaNhan", true).FirstOrDefault() as Button;
            Button btnLuongCaNhan = this.Controls.Find("btnLuongCaNhan", true).FirstOrDefault() as Button;
            Button btnCongViecCaNhan = this.Controls.Find("btnCongViecCaNhan", true).FirstOrDefault() as Button;
            Button btnHoSo = this.Controls.Find("btnHoSo", true).FirstOrDefault() as Button;
            Button btnLuong = this.Controls.Find("btnLuong", true).FirstOrDefault() as Button;
            Button btnPhanCong = this.Controls.Find("btnPhanCong", true).FirstOrDefault() as Button;

            // Các nút con
            Button btnTinhLuong = this.Controls.Find("btnTinhLuong", true).FirstOrDefault() as Button;
            Button btnQuanLyBangLuong = this.Controls.Find("btnQuanLyBangLuong", true).FirstOrDefault() as Button;
            Button btnChayBangLuong = this.Controls.Find("btnChayBangLuong", true).FirstOrDefault() as Button;
            Button btnBaoCaoPhanTich = this.Controls.Find("btnBaoCaoPhanTich", true).FirstOrDefault() as Button;
            Button btnBangPhanCongQuanLy = this.Controls.Find("btnBangPhanCongQuanLy", true).FirstOrDefault() as Button;

            // Khai báo các nút con quản lý
            Button btnThemNhanVien = this.Controls.Find("btnThemNhanVien", true).FirstOrDefault() as Button;
            Button btnQuanLyNhanVien = this.Controls.Find("btnQuanLyNhanVien", true).FirstOrDefault() as Button;
            Button btnQuanLyPhongBan = this.Controls.Find("btnQuanLyPhongBan", true).FirstOrDefault() as Button;
            Button btnQuanLyTrinhDo = this.Controls.Find("btnQuanLyTrinhDo", true).FirstOrDefault() as Button;

            Panel panelHoSoSubmenu = this.Controls.Find("panelHoSoSubmenu", true).FirstOrDefault() as Panel;
            Panel panelLuongSubmenu = this.Controls.Find("panelLuongSubmenu", true).FirstOrDefault() as Panel;
            Panel panelPhanCongSubmenu = this.Controls.Find("panelPhanCongSubmenu", true).FirstOrDefault() as Panel;


            // --- BƯỚC 1: LÔ-GIC PHÂN QUYỀN CHUNG DỰA TRÊN TAG (Áp dụng cho nút con) ---
            if (this.Controls.Find("panelMenu", true).FirstOrDefault() is Panel panelMenu)
            {
                var allControls = panelMenu.Controls.Cast<Control>().ToList();

                // --- GÁN TAG CỤ THỂ CHO CÁC NÚT CON ---
                if (btnThemNhanVien != null) btnThemNhanVien.Tag = "Admin,TruongPhong";
                if (btnQuanLyNhanVien != null) btnQuanLyNhanVien.Tag = "Admin,TruongPhong";
                if (btnQuanLyPhongBan != null) btnQuanLyPhongBan.Tag = "Admin,TruongPhong";
                if (btnQuanLyTrinhDo != null) btnQuanLyTrinhDo.Tag = "Admin,TruongPhong"; // Giữ lại cho TruongPhong như code cũ

                if (btnBangPhanCongQuanLy != null) btnBangPhanCongQuanLy.Tag = "Admin,TruongPhong";

                // Lương
                if (btnTinhLuong != null)
                {
                    btnTinhLuong.Click -= BtnTinhLuong_Click; // Gỡ bỏ hàm cũ
                    btnTinhLuong.Click += BtnSubmenu_Click;    // Gán lại hàm chung
                    btnTinhLuong.Tag = "Admin,KeToan";
                }
                if (btnQuanLyBangLuong != null) btnQuanLyBangLuong.Tag = "Admin,KeToan,TruongPhong";
                if (btnChayBangLuong != null) btnChayBangLuong.Tag = "Admin,KeToan";

                // Ẩn nút Báo cáo phân tích
                if (btnBaoCaoPhanTich != null)
                {
                    btnBaoCaoPhanTich.Visible = false;
                }

                // 3. Vòng lặp kiểm tra Tag chung
                foreach (Control control in allControls)
                {
                    string tag = (control.Tag != null) ? control.Tag.ToString() : "";

                    if (!string.IsNullOrEmpty(tag))
                    {
                        // Nếu vai trò HIỆN TẠI có trong Tag, hiển thị nút. Ngược lại, ẩn.
                        control.Visible = tag.Contains(this.userQuyen);
                    }
                }
            }


            // --- BƯỚC 2: LÔ-GIC ĐẶC BIỆT THEO VAI TRÒ ---

            if (this.userQuyen == "NhanVien" || this.userQuyen == "TruongPhong")
            {
                // Ẩn menu Lương và các nút con
                if (btnLuong != null) btnLuong.Visible = false;
                if (panelLuongSubmenu != null) panelLuongSubmenu.Visible = false;

                if (this.userQuyen == "TruongPhong")
                {
                    // Trưởng phòng: HIỆN MENU HỒ SƠ VÀ PHÂN CÔNG (vẫn giữ các nút Quản lý còn lại)
                    if (btnHoSo != null) btnHoSo.Visible = true;
                    if (btnPhanCong != null) btnPhanCong.Visible = true;

                    // **QUAN TRỌNG:** KHÔNG ẨN panelHoSoSubmenu VÀ panelPhanCongSubmenu Ở ĐÂY CHO TRƯỞNG PHÒNG NỮA.
                    // Các nút con bên trong đã được xử lý Visible ở BƯỚC 1.
                }

                if (this.userQuyen == "NhanVien")
                {
                    // Nhân viên: Ẩn các menu quản lý
                    if (btnHoSo != null) btnHoSo.Visible = false;
                    if (btnPhanCong != null) btnPhanCong.Visible = false;
                    // Nhân viên: Ẩn các Submenu quản lý (DÒNG SỬA)
                    if (panelHoSoSubmenu != null) panelHoSoSubmenu.Visible = false;
                    if (panelPhanCongSubmenu != null) panelPhanCongSubmenu.Visible = false;
                    if (btnBangPhanCongQuanLy != null) btnBangPhanCongQuanLy.Visible = false;

                }

                // **GIỮ NGUYÊN LOGIC CHO CÁ NHÂN** (Chung cho NV và TP)
                if (btnHoSoCaNhan != null) btnHoSoCaNhan.Visible = true;
                if (btnLuongCaNhan != null) btnLuongCaNhan.Visible = true;
                if (btnCongViecCaNhan != null) btnCongViecCaNhan.Visible = true;
            }
            else if (this.userQuyen == "KeToan")
            {
                // **GIỮ NGUYÊN LOGIC CHO KẾ TOÁN**
                if (btnHoSo != null) btnHoSo.Visible = false;
                if (btnPhanCong != null) btnPhanCong.Visible = false;
                if (btnLuong != null) btnLuong.Visible = true;

                // Kế toán chỉ cần ẩn các submenu không cần thiết
                if (panelHoSoSubmenu != null) panelHoSoSubmenu.Visible = false;
                if (panelPhanCongSubmenu != null) panelPhanCongSubmenu.Visible = false;
                if (btnBangPhanCongQuanLy != null) btnBangPhanCongQuanLy.Visible = false;

                // **GIỮ NGUYÊN LOGIC CHO CÁ NHÂN**
                if (btnHoSoCaNhan != null) btnHoSoCaNhan.Visible = true;
                if (btnLuongCaNhan != null) btnLuongCaNhan.Visible = true;
                if (btnCongViecCaNhan != null) btnCongViecCaNhan.Visible = true;
            }
            else // Admin (Hiển thị tất cả)
            {
                // 1. Hiển thị Menu Quản lý
                if (btnHoSo != null) btnHoSo.Visible = true;
                if (btnLuong != null) btnLuong.Visible = true;
                if (btnPhanCong != null) btnPhanCong.Visible = true;

                // 2. Hiển thị Nút Cá nhân (Admin cũng là Nhân viên)
                if (btnHoSoCaNhan != null) btnHoSoCaNhan.Visible = true;
                if (btnLuongCaNhan != null) btnLuongCaNhan.Visible = false;
                if (btnCongViecCaNhan != null) btnCongViecCaNhan.Visible = false;
            }
        }

        // Hàm load UserControl vào panelContent (Giữ nguyên)
        protected void LoadControlToPanel(UserControl uc)
        {
            if (uc == null || this.Controls.Find("panelContent", true).FirstOrDefault() is not Panel panelContent) return;

            panelContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Add(uc);
        }

    }
}