using System;
using System.Windows.Forms;
using System.Linq;
using QuanLyNhanSu.usercontrol;
using System.Drawing;

namespace QuanLyNhanSu
{
    public partial class FormTruongPhong : Form1
    {
        private Button btnDangXuat; // Khai báo nút Đăng xuất
        private Button btnChamCong; // Chấm công

        // 1. Constructor mặc định
        public FormTruongPhong()
        {
            InitializeComponent();
        }

        // 2. Constructor 3 tham số
        public FormTruongPhong(string quyen, int nhanVienID, string tenNV)
            : base(quyen, nhanVienID, tenNV)
        {
            InitializeComponent();

            AttachLogoutButtonHandler();
            SetupTruongPhongUI();
        }

        private void SetupTruongPhongUI()
        {
            this.Text = $"Hệ thống Trưởng Phòng - {this.userName}";

            if (this.Controls.Find("btnHoSoCaNhan", true).FirstOrDefault() is Button defaultBtn)
            {
                BtnMenuCaNhan_Click(defaultBtn, EventArgs.Empty);
            }
        }

        private void AttachLogoutButtonHandler()
        {
            Panel panelMenu = this.Controls.Find("panelMenu", true).FirstOrDefault() as Panel;

            if (panelMenu != null)
            {
                // --- NÚT CHẤM CÔNG ---
                if (this.btnChamCong == null)
                {
                    this.btnChamCong = new Button();
                    this.btnChamCong.Name = "btnChamCong";
                }

                this.btnChamCong.Text = "  ⏰ Chấm Công";
                this.btnChamCong.Height = 60;
                this.btnChamCong.TabIndex = 4;
                SetMenuButtonStyle(this.btnChamCong);
                this.btnChamCong.Click -= BtnMenuCaNhan_Click;
                this.btnChamCong.Click += BtnMenuCaNhan_Click;

                if (!panelMenu.Controls.Contains(this.btnChamCong))
                    panelMenu.Controls.Add(this.btnChamCong);

                // --- NÚT ĐĂNG XUẤT ---
                if (this.btnDangXuat == null)
                {
                    this.btnDangXuat = new Button();
                    this.btnDangXuat.Name = "btnDangXuat";
                }

                this.btnDangXuat.Text = "  Đăng Xuất";
                this.btnDangXuat.Dock = DockStyle.Bottom;
                this.btnDangXuat.Height = 60;
                this.btnDangXuat.TabIndex = 99;
                this.btnDangXuat.BackColor = Color.FromArgb(51, 51, 76);
                this.btnDangXuat.ForeColor = Color.Gainsboro;
                this.btnDangXuat.FlatStyle = FlatStyle.Flat;
                this.btnDangXuat.FlatAppearance.BorderSize = 0;
                this.btnDangXuat.TextAlign = ContentAlignment.MiddleLeft;
                this.btnDangXuat.Padding = new Padding(10, 0, 0, 0);
                this.btnDangXuat.Click -= BtnDangXuat_Click;
                this.btnDangXuat.Click += BtnDangXuat_Click;

                if (!panelMenu.Controls.Contains(this.btnDangXuat))
                    panelMenu.Controls.Add(this.btnDangXuat);

                panelMenu.Controls.SetChildIndex(this.btnDangXuat, 0);
            }
            else
            {
                MessageBox.Show("Không tìm thấy Panel chứa menu (panelMenu). Không thể thêm các nút động.", "Lỗi Thiết lập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetMenuButtonStyle(Button btn)
        {
            btn.Dock = DockStyle.Top;
            btn.BackColor = Color.FromArgb(0, 150, 136);
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(10, 0, 0, 0);
        }

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
                    case "btnThemNhanVien":
                        uc = new ThemNhanVien();
                        break;
                    case "btnQuanLyNhanVien":
                        uc = new QuanLyNhanVien(0);
                        break;
                    case "btnPhanCongCongViec":
                        uc = new PhanCong(0);
                        break;
                    case "btnBaoCaoPhanCong":
                        uc = new BaoCaoPhanCong(0);
                        break;
                    case "btnQuanLyBangLuong":
                        uc = new BangLuong(0);
                        break;
                    case "btnQuanLyPhongBan":
                        uc = new Uc_phongBan();
                        break;
                    case "btnTrinhDo":
                        uc = new TrinhDo();
                        break;
                    default:
                        base.BtnSubmenu_Click(sender, e);
                        break;
                }

                if (uc != null)
                    LoadControlToPanel(uc);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải giao diện Trưởng phòng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void BtnMenuCaNhan_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            UserControl uc = null;
            this.HideSubMenus();

            try
            {
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
                        LoadControlToPanel(new QuanLyNhanSu.usercontrol.CongViecCaNhan(this.userID));
                        break;
                    case "btnChamCong":
                        FormChamCong chamCongForm = new FormChamCong(this.userID, this.userName);
                        chamCongForm.Show();
                        return;
                    case "btnDangXuat":
                        BtnDangXuat_Click(sender, e);
                        return;
                    default:
                        MessageBox.Show($"Chức năng cá nhân '{btn.Text}' chưa được cài đặt UserControl.", "Thông báo");
                        break;
                }

                if (uc != null)
                    LoadControlToPanel(uc);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải giao diện cá nhân: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                this.Close();
            }
        }
    }
}
