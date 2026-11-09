using System;
using System.Windows.Forms;
using System.Linq;
using QuanLyNhanSu.usercontrol;
using System.Drawing; // Cần thiết cho Color, Point, v.v.

namespace QuanLyNhanSu
{
    public partial class FormAdmin : Form1
    {
        // Khai báo các nút menu
        private Button btnDangXuat;
        private Button btnChamCong;
        private Button btnQuanLyTaiKhoan;
        private Button btnChiTietChamCong;
        private Button btnPhuCap;

        public FormAdmin()
        {
            InitializeComponent();
        }

        public FormAdmin(string quyen, int nhanVienID, string tenNV)
            : base(quyen, nhanVienID, tenNV)
        {
            InitializeComponent();

            // Gán các nút menu
            AttachLogoutButtonHandler();
            AttachAdminExtraButtons();

            SetupAdminUI();
        }

        private void SetupAdminUI()
        {
            this.Text = $"Hệ thống Quản trị (Admin) - {this.userName}";

            // Mặc định hiển thị Hồ sơ cá nhân khi đăng nhập
            if (this.Controls.Find("btnHoSoCaNhan", true).FirstOrDefault() is Button defaultBtn)
            {
                BtnMenuCaNhan_Click(defaultBtn, EventArgs.Empty);
            }
        }

        // =================== NÚT ĐĂNG XUẤT ===================
        private void AttachLogoutButtonHandler()
        {
            Panel panelMenu = this.Controls.Find("panelMenu", true).FirstOrDefault() as Panel;
            if (panelMenu == null)
            {
                MessageBox.Show("Không tìm thấy panelMenu để thêm nút.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btnDangXuat == null)
            {
                btnDangXuat = new Button();
                btnDangXuat.Name = "btnDangXuat";
            }

            btnDangXuat.Text = "  Đăng Xuất";
            btnDangXuat.Dock = DockStyle.Bottom;
            btnDangXuat.Height = 60;
            btnDangXuat.TabIndex = 99;
            btnDangXuat.BackColor = Color.FromArgb(51, 51, 76);
            btnDangXuat.ForeColor = Color.Gainsboro;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.Padding = new Padding(10, 0, 0, 0);
            btnDangXuat.Click -= BtnDangXuat_Click;
            btnDangXuat.Click += BtnDangXuat_Click;
            if (btnChiTietChamCong == null)
            {
                btnChiTietChamCong = new Button();
                btnChiTietChamCong.Name = "btnChiTietChamCong";
            }
            btnChiTietChamCong.Text = "  Chi tiết Chấm Công";
            btnChiTietChamCong.Dock = DockStyle.Top;
            btnChiTietChamCong.Height = 50;
            btnChiTietChamCong.BackColor = Color.FromArgb(51, 51, 76);
            btnChiTietChamCong.ForeColor = Color.Gainsboro;
            btnChiTietChamCong.FlatStyle = FlatStyle.Flat;
            btnChiTietChamCong.FlatAppearance.BorderSize = 0;
            btnChiTietChamCong.TextAlign = ContentAlignment.MiddleLeft;
            btnChiTietChamCong.Padding = new Padding(10, 0, 0, 0);
            btnChiTietChamCong.Click -= BtnChiTietChamCong_Click;
            btnChiTietChamCong.Click += BtnChiTietChamCong_Click;

            if (!panelMenu.Controls.Contains(btnChiTietChamCong))
                panelMenu.Controls.Add(btnChiTietChamCong);

            panelMenu.Controls.SetChildIndex(btnChiTietChamCong, 0);
            if (!panelMenu.Controls.Contains(btnDangXuat))
                panelMenu.Controls.Add(btnDangXuat);

            panelMenu.Controls.SetChildIndex(btnDangXuat, 0);
            if (btnPhuCap == null)
            {
                btnPhuCap = new Button();
                btnPhuCap.Name = "btnPhuCap";
            }
            btnPhuCap.Text = "  Phụ Cấp";
            btnPhuCap.Dock = DockStyle.Top;
            btnPhuCap.Height = 50;
            btnPhuCap.BackColor = Color.FromArgb(51, 51, 76);
            btnPhuCap.ForeColor = Color.Gainsboro;
            btnPhuCap.FlatStyle = FlatStyle.Flat;
            btnPhuCap.FlatAppearance.BorderSize = 0;
            btnPhuCap.TextAlign = ContentAlignment.MiddleLeft;
            btnPhuCap.Padding = new Padding(10, 0, 0, 0);
            btnPhuCap.Click -= BtnPhuCap_Click;
            btnPhuCap.Click += BtnPhuCap_Click;

            if (!panelMenu.Controls.Contains(btnPhuCap))
                panelMenu.Controls.Add(btnPhuCap);

            // Đặt ChildIndex để nút hiển thị đúng thứ tự (bên dưới Trình Độ)
            panelMenu.Controls.SetChildIndex(btnPhuCap, 0);
        }

        private void BtnPhuCap_Click(object sender, EventArgs e)
        {
            try
            {
                UserControl uc = new PhuCap(); // UserControl Phụ Cấp
                LoadControlToPanel(uc);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải giao diện Phụ Cấp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnChiTietChamCong_Click(object sender, EventArgs e)
        {
            try
            {
                // Nếu constructor Form chi tiết cần ID nhân viên
                UserControl uc = new ChiTietChamCong(); // Tạo UserControl cho Quản lý Tài khoản
                LoadControlToPanel(uc);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi mở Form Chi tiết Chấm Công: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất khỏi hệ thống không?",
                "Xác nhận Đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.Yes)
            {
                FormDangNhap loginForm = new FormDangNhap();
                this.Hide();
                loginForm.Show();
            }
        }

        // =================== NÚT BỔ SUNG ADMIN ===================
        private void AttachAdminExtraButtons()
        {
            Panel panelMenu = this.Controls.Find("panelMenu", true).FirstOrDefault() as Panel;
            if (panelMenu == null) return;

            // --- NÚT CHẤM CÔNG ---
            if (btnChamCong == null)
            {
                btnChamCong = new Button();
                btnChamCong.Name = "btnChamCong";
            }
            btnChamCong.Text = "  Chấm Công";
            btnChamCong.Dock = DockStyle.Top;
            btnChamCong.Height = 50;
            btnChamCong.BackColor = Color.FromArgb(51, 51, 76);
            btnChamCong.ForeColor = Color.Gainsboro;
            btnChamCong.FlatStyle = FlatStyle.Flat;
            btnChamCong.FlatAppearance.BorderSize = 0;
            btnChamCong.TextAlign = ContentAlignment.MiddleLeft;
            btnChamCong.Padding = new Padding(10, 0, 0, 0);
            btnChamCong.Click -= BtnChamCong_Click;
            btnChamCong.Click += BtnChamCong_Click;

            if (!panelMenu.Controls.Contains(btnChamCong))
                panelMenu.Controls.Add(btnChamCong);
            panelMenu.Controls.SetChildIndex(btnChamCong, 0);

            // --- NÚT QUẢN LÝ TÀI KHOẢN ---
            if (btnQuanLyTaiKhoan == null)
            {
                btnQuanLyTaiKhoan = new Button();
                btnQuanLyTaiKhoan.Name = "btnQuanLyTaiKhoan";
            }
            btnQuanLyTaiKhoan.Text = "  Quản lý Tài khoản";
            btnQuanLyTaiKhoan.Dock = DockStyle.Top;
            btnQuanLyTaiKhoan.Height = 50;
            btnQuanLyTaiKhoan.BackColor = Color.FromArgb(51, 51, 76);
            btnQuanLyTaiKhoan.ForeColor = Color.Gainsboro;
            btnQuanLyTaiKhoan.FlatStyle = FlatStyle.Flat;
            btnQuanLyTaiKhoan.FlatAppearance.BorderSize = 0;
            btnQuanLyTaiKhoan.TextAlign = ContentAlignment.MiddleLeft;
            btnQuanLyTaiKhoan.Padding = new Padding(10, 0, 0, 0);
            btnQuanLyTaiKhoan.Click -= BtnQuanLyTaiKhoan_Click;
            btnQuanLyTaiKhoan.Click += BtnQuanLyTaiKhoan_Click;

            if (!panelMenu.Controls.Contains(btnQuanLyTaiKhoan))
                panelMenu.Controls.Add(btnQuanLyTaiKhoan);
            panelMenu.Controls.SetChildIndex(btnQuanLyTaiKhoan, 0);
        }

        private void BtnChamCong_Click(object sender, EventArgs e)
        {
            try
            {
                // Truyền ID và tên nhân viên đang login
                FormChamCong frmChamCong = new FormChamCong(this.userID, this.userName);
                frmChamCong.Show(); // Hoặc ShowDialog() nếu muốn modal
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi mở Form Chấm Công: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                UserControl uc = new QuanLyTaiKhoan(); // Tạo UserControl cho Quản lý Tài khoản
                LoadControlToPanel(uc);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải giao diện Quản lý Tài khoản: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =================== GHI ĐÈ HÀM CỦA FORM1 ===================
        protected override void BtnMenu_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;
            this.ToggleSubMenu(btn);
        }

        protected override void BtnSubmenu_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            this.HideSubMenus();
            UserControl uc = null;

            try
            {
                switch (btn.Name)
                {
                    case "btnThemNhanVien": uc = new ThemNhanVien(); break;
                    case "btnQuanLyNhanVien": uc = new QuanLyNhanVien(0); break;
                    case "btnPhanCongCongViec": uc = new PhanCong(0); break;
                    case "btnBangPhanCongQuanLy":
                    case "btnBaoCaoPhanCong": uc = new BaoCaoPhanCong(); break;
                    case "btnQuanLyBangLuong": uc = new BaoCaoPhanTich(); break;
                    case "btnQuanLyPhongBan": uc = new Uc_phongBan(); break;
                    case "btnQuanLyTrinhDo":uc = new TrinhDo(); break;

                    case "btnTrinhDo": uc = new TrinhDo(); break;
                    case "btnChayBangLuong": uc = new BangLuong(); break;
                    case "btnTinhLuong": uc = new TinhLuong(); break;
                    default: base.BtnSubmenu_Click(sender, e); break;
                }

                if (uc != null)
                {
                    LoadControlToPanel(uc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải giao diện quản lý: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void BtnMenuCaNhan_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            this.HideSubMenus();

            UserControl uc = null;

            try
            {
                Panel panelSubMenu = this.Controls.Find("panelSubMenuHoSoCaNhan", true).FirstOrDefault() as Panel;
                if (panelSubMenu != null)
                {
                    // Kiểm tra xem nút Phụ Cấp đã được thêm chưa
                    if (panelSubMenu.Controls.Find("btnPhuCapCaNhan", false).FirstOrDefault() == null)
                    {
                        Button btnPhuCapCaNhan = new Button();
                        btnPhuCapCaNhan.Name = "btnPhuCapCaNhan";
                        btnPhuCapCaNhan.Text = "  Phụ Cấp";
                        btnPhuCapCaNhan.Dock = DockStyle.Top;
                        btnPhuCapCaNhan.Height = 40;
                        btnPhuCapCaNhan.BackColor = Color.FromArgb(35, 32, 39); // màu submenu
                        btnPhuCapCaNhan.ForeColor = Color.Gainsboro;
                        btnPhuCapCaNhan.FlatStyle = FlatStyle.Flat;
                        btnPhuCapCaNhan.FlatAppearance.BorderSize = 0;
                        btnPhuCapCaNhan.TextAlign = ContentAlignment.MiddleLeft;
                        btnPhuCapCaNhan.Padding = new Padding(35, 0, 0, 0);
                        btnPhuCapCaNhan.Click += (s, ev) =>
                        {
                            try
                            {
                                UserControl ucPhuCap = new PhuCap(); // UserControl Phụ Cấp
                                LoadControlToPanel(ucPhuCap);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Lỗi tải giao diện Phụ Cấp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        };

                        // Thêm nút vào panelSubMenu, đặt ChildIndex để nằm dưới nút Trình Độ
                        panelSubMenu.Controls.Add(btnPhuCapCaNhan);
                        panelSubMenu.Controls.SetChildIndex(btnPhuCapCaNhan, 0); // index 0 để nằm trên cùng, tùy bạn sắp xếp
                    }
                }

                // Load các UserControl cá nhân khác
                switch (btn.Name)
                {
                    case "btnHoSoCaNhan": uc = new QuanLyNhanVien(this.userID); break;
                    case "btnLuongCaNhan": uc = new BangLuong(this.userID); break;
                    case "btnCongViecCaNhan": uc = new BaoCaoPhanCong(this.userID); break;
                }

                if (uc != null)
                {
                    LoadControlToPanel(uc);
                }
                else
                {
                    MessageBox.Show($"Chức năng cá nhân '{btn.Text}' chưa được cài đặt UserControl.", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải giao diện cá nhân: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
