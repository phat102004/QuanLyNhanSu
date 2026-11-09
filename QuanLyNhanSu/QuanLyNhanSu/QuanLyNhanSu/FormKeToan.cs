using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyNhanSu.usercontrol;

namespace QuanLyNhanSu
{
    public partial class FormKeToan : Form1
    {
        private Button btnDangXuat;        // Khai báo nút Đăng xuất
        private Button btnChamCong;        // Nút chấm công (mở FormChamCong)
        private Button btnChiTietChamCong; // Nút mới: Chi tiết chấm công

        // Constructor mặc định (Designer)
        public FormKeToan()
        {
            InitializeComponent();
        }

        // Constructor nhận thông tin đăng nhập
        public FormKeToan(string quyen, int nhanVienID, string tenNV)
            : base(quyen, nhanVienID, tenNV)
        {
            InitializeComponent();
            AttachLogoutButtonHandler(); // Tạo các nút động lên menu
            SetupKeToanUI();
        }

        // Tạo và thêm các nút động (Đăng xuất, Chấm công, Chi tiết chấm công)
        private void AttachLogoutButtonHandler()
        {
            Panel panelMenu = this.Controls.Find("panelMenu", true).FirstOrDefault() as Panel;

            if (panelMenu == null)
            {
                MessageBox.Show("Không tìm thấy panelMenu. Kiểm tra lại Designer.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // --- Nút Đăng xuất ---
            if (this.btnDangXuat == null)
            {
                this.btnDangXuat = new Button() { Name = "btnDangXuat" };
            }
            ConfigureBottomButton(this.btnDangXuat, "  Đăng Xuất");
            this.btnDangXuat.Click -= BtnDangXuat_Click;
            this.btnDangXuat.Click += BtnDangXuat_Click;

            // --- Nút Chấm Công (mở FormChamCong) ---
            if (this.btnChamCong == null)
            {
                this.btnChamCong = new Button() { Name = "btnChamCong" };
            }
            ConfigureMenuButton(this.btnChamCong, "  ⏰ Chấm Công");
            // sử dụng BtnMenuCaNhan_Click theo cấu trúc hiện tại (mở form khi click)
            this.btnChamCong.Click -= BtnMenuCaNhan_Click;
            this.btnChamCong.Click += BtnMenuCaNhan_Click;

            // --- Nút Chi Tiết Chấm Công (mới) ---
            if (this.btnChiTietChamCong == null)
            {
                this.btnChiTietChamCong = new Button() { Name = "btnChiTietChamCong" };
            }
            ConfigureMenuButton(this.btnChiTietChamCong, "📋 Chi Tiết Chấm Công");
            // Bấm vào sẽ tải UserControl ChiTietChamCong vào panelContent
            this.btnChiTietChamCong.Click -= BtnChiTietChamCong_Click;
            this.btnChiTietChamCong.Click += BtnChiTietChamCong_Click;

            // Thêm các nút vào panelMenu nếu chưa có
            if (!panelMenu.Controls.Contains(this.btnChiTietChamCong))
                panelMenu.Controls.Add(this.btnChiTietChamCong);

            if (!panelMenu.Controls.Contains(this.btnChamCong))
                panelMenu.Controls.Add(this.btnChamCong);

            // Đặt nút Đăng xuất ở đáy
            if (panelMenu.Controls.Contains(this.btnDangXuat))
                panelMenu.Controls.Remove(this.btnDangXuat);
            panelMenu.Controls.Add(this.btnDangXuat);

            // Tùy chỉnh thứ tự hiển thị (nếu cần)
            // Muốn đưa ChiTiết trên cùng trong các nút động: đưa chỉ số thấp
            try
            {
                panelMenu.Controls.SetChildIndex(this.btnDangXuat, 0); // đáy
            }
            catch { /* không quan trọng nếu thất bại */ }
        }

        // Hàm tiện ích cấu hình style cho nút menu (ở trên)
        private void ConfigureMenuButton(Button btn, string text)
        {
            btn.Text = text;
            btn.Height = 60;
            btn.Dock = DockStyle.Top;
            btn.BackColor = Color.FromArgb(51, 51, 76);
            btn.ForeColor = Color.Gainsboro;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(16, 0, 0, 0);
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
        }

        // Cấu hình nút đáy (Đăng xuất)
        private void ConfigureBottomButton(Button btn, string text)
        {
            btn.Text = text;
            btn.Dock = DockStyle.Bottom;
            btn.Height = 60;
            btn.BackColor = Color.FromArgb(51, 51, 76);
            btn.ForeColor = Color.Gainsboro;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(16, 0, 0, 0);
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
        }

        private void SetupKeToanUI()
        {
            this.Text = $"Hệ thống Kế toán - {this.userName}";

            // Ẩn nút/thuộc tính không cần thiết cho kế toán (nếu có)
            // Lưu ý: tên btn trong Designer của bạn có thể khác, dùng Controls.Find để tìm
            if (this.Controls.Find("btnHoSo", true).FirstOrDefault() is Button btnHoSo)
                btnHoSo.Visible = false;

            // Mặc định tải giao diện Lương/Hồ sơ cá nhân như bạn muốn
            if (this.Controls.Find("btnHoSoCaNhan", true).FirstOrDefault() is Button defaultBtn)
            {
                BtnMenuCaNhan_Click(defaultBtn, EventArgs.Empty);
            }
            else if (this.Controls.Find("btnQuanLyBangLuong", true).FirstOrDefault() is Button fallbackBtn)
            {
                BtnSubmenu_Click(fallbackBtn, EventArgs.Empty);
            }
        }

        // Ghi đè: Xử lý Menu chính (giữ nguyên)
        protected override void BtnMenu_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;
            this.ToggleSubMenu(btn);
        }

        // Ghi đè: Xử lý Submenu (giữ nguyên, tải UC tương ứng)
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
                    case "btnTinhLuong":
                        uc = new QuanLyNhanSu.usercontrol.TinhLuong();
                        break;
                    case "btnChayBangLuong":
                        uc = new QuanLyNhanSu.usercontrol.BangLuong();
                        break;
                    case "btnQuanLyBangLuong":
                        uc = new QuanLyNhanSu.usercontrol.BaoCaoPhanTich();
                        break;
                    case "btnQuanLyNhanVien":
                        uc = new QuanLyNhanSu.usercontrol.QuanLyNhanVien(0);
                        break;
                    default:
                        MessageBox.Show($"Chức năng '{btn.Text}' chưa có trong FormKeToan.", "Thông báo");
                        break;
                }

                if (uc != null)
                {
                    LoadControlToPanel(uc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải giao diện: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Ghi đè: Xử lý Nút Cá Nhân / Nút động
        protected override void BtnMenuCaNhan_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;
            this.HideSubMenus();

            // Nếu là nút động 'btnChamCong' sẽ mở FormChamCong
            if (btn.Name == "btnChamCong")
            {
                int idToPass = this.userID;
                // mở form chấm công — FormChamCong phải có constructor (int id, string ten)
                try
                {
                    var chamCongForm = new FormChamCong(idToPass, this.userName);
                    chamCongForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi mở FormChamCong: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }

            // Các nút cá nhân mặc định (btnHoSoCaNhan, btnLuongCaNhan, btnCongViecCaNhan)
            switch (btn.Name)
            {
                case "btnHoSoCaNhan":
                    LoadControlToPanel(new QuanLyNhanSu.usercontrol.QuanLyNhanVien(this.userID));
                    break;

                case "btnLuongCaNhan":
                    LoadControlToPanel(new QuanLyNhanSu.usercontrol.LuongCaNhan(this.userID)
                    );
                    break;

                case "btnCongViecCaNhan":
                    LoadControlToPanel(new QuanLyNhanSu.usercontrol.CongViecCaNhan(this.userID)
                    );
                    break;
                // Nếu là nút Chi tiết chấm công: tải UC ChiTietChamCong vào panelContent
                case "btnChiTietChamCong":
                    {
                        try
                        {
                            var uc = new QuanLyNhanSu.usercontrol.ChiTietChamCong();
                            LoadControlToPanel(uc);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi tải Chi tiết chấm công: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case "btnDangXuat":
                    BtnDangXuat_Click(sender, e);
                    break;
                default:
                    MessageBox.Show($"Chức năng '{btn.Text}' chưa được cài đặt.", "Thông báo");
                    break;
            }
        }

        // Sự kiện cho nút Chi tiết chấm công (nếu cần dùng riêng)
        private void BtnChiTietChamCong_Click(object sender, EventArgs e)
        {
            // Gọi handler chung để nhất quán
            BtnMenuCaNhan_Click(sender, e);
        }

        // Nút Đăng xuất
        private void BtnDangXuat_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                var login = new FormDangNhap();
                login.Show();
                this.Close();
            }
        }
    }
}
