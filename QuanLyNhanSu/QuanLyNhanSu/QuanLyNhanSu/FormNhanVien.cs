using System;
using System.Windows.Forms;
using System.Linq;
using QuanLyNhanSu.usercontrol;
using System.Drawing; // Cần thiết cho Color, Point, v.v.

// Đảm bảo FormChamCong có sẵn trong scope.
// Nếu nó nằm trong một namespace khác, hãy thêm 'using [Namespace Của FormChamCong];'
// Ví dụ: using QuanLyNhanSu.Forms;

namespace QuanLyNhanSu
{
    public partial class FormNhanVien : Form1
    {
        private Button btnDangXuat;
        private Button btnChamCong;

        // 1. Constructor mặc định (Bắt buộc cho Designer)
        public FormNhanVien()
        {
            InitializeComponent();
        }

        // 2. Constructor 3 tham số (Bắt buộc để nhận dữ liệu đăng nhập)
        public FormNhanVien(string quyen, int nhanVienID, string tenNV)
            : base(quyen, nhanVienID, tenNV)
        {
            InitializeComponent();

            // 💡 Gọi hàm để tạo, thiết lập và gán các nút Menu động (Đăng Xuất và Chấm Công)
            AttachDynamicMenuButtons();

            SetupNhanVienUI();
        }

        private void SetupNhanVienUI()
        {
            this.Text = $"Hệ thống Nhân viên - {this.userName}";

            // Mặc định vào Hồ sơ Cá nhân (Đảm bảo nút này tồn tại trong Designer)
            if (this.Controls.Find("btnHoSoCaNhan", true).FirstOrDefault() is Button defaultBtn)
            {
                // Gọi hàm xử lý click của nút cá nhân để tải UC mặc định
                BtnMenuCaNhan_Click(defaultBtn, EventArgs.Empty);
            }
        }

        // --- HÀM TẠO VÀ GÁN CÁC NÚT MENU ĐỘNG (Đăng Xuất và Chấm Công) ---
        private void AttachDynamicMenuButtons()
        {
            Panel panelMenu = this.Controls.Find("panelMenu", true).FirstOrDefault() as Panel;

            if (panelMenu != null)
            {
                // --- A. Nút ĐĂNG XUẤT (Vị trí DockStyle.Bottom) ---
                if (this.btnDangXuat == null)
                {
                    this.btnDangXuat = new Button();
                    this.btnDangXuat.Name = "btnDangXuat";
                }

                // Thiết lập thuộc tính cho nút Đăng Xuất
                this.btnDangXuat.Text = "  🔓 Đăng Xuất";
                this.btnDangXuat.Dock = DockStyle.Bottom;
                this.btnDangXuat.Height = 60;
                this.btnDangXuat.TabIndex = 99;

                // Thiết lập kiểu dáng
                this.btnDangXuat.BackColor = Color.FromArgb(51, 51, 76);
                this.btnDangXuat.ForeColor = Color.Gainsboro;
                this.btnDangXuat.FlatStyle = FlatStyle.Flat;
                this.btnDangXuat.FlatAppearance.BorderSize = 0;
                this.btnDangXuat.TextAlign = ContentAlignment.MiddleLeft;
                this.btnDangXuat.Padding = new Padding(10, 0, 0, 0);

                // Gán sự kiện Click
                this.btnDangXuat.Click -= BtnDangXuat_Click;
                this.btnDangXuat.Click += BtnDangXuat_Click;

                // Thêm nút vào Panel Menu
                if (!panelMenu.Controls.Contains(this.btnDangXuat))
                {
                    panelMenu.Controls.Add(this.btnDangXuat);
                }
                panelMenu.Controls.SetChildIndex(this.btnDangXuat, 0);


                // --- B. Nút CHẤM CÔNG (Vị trí DockStyle.Top) ---
                if (this.btnChamCong == null)
                {
                    this.btnChamCong = new Button();
                    this.btnChamCong.Name = "btnChamCong";
                }

                this.btnChamCong.Text = "  ⏰ Chấm Công";
                this.btnChamCong.Height = 60;
                this.btnChamCong.TabIndex = 4;

                // Thiết lập kiểu dáng
                SetMenuButtonStyle(this.btnChamCong);

                // Gán sự kiện Click
                this.btnChamCong.Click -= BtnMenuCaNhan_Click;
                this.btnChamCong.Click += BtnMenuCaNhan_Click;

                // Thêm vào Panel Menu
                if (!panelMenu.Controls.Contains(this.btnChamCong))
                {
                    panelMenu.Controls.Add(this.btnChamCong);
                }

            }
            else
            {
                MessageBox.Show("Không tìm thấy Panel chứa menu (panelMenu). Không thể thêm nút Đăng xuất/Chấm công.", "Lỗi Thiết lập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm hỗ trợ thiết lập style cho các nút Menu chuẩn
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

        // --- XỬ LÝ CLICK NÚT MENU (Ghi đè hàm của Form1) ---
        protected override void BtnMenu_Click(object sender, EventArgs e)
        {
            BtnMenuCaNhan_Click(sender, e);
        }

        protected override void BtnSubmenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng quản lý không khả dụng cho vai trò Nhân viên.", "Không có quyền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // 🎯 Ghi đè hàm XỬ LÝ CÁ NHÂN: Logic tải UserControl hoặc mở Form
        protected override void BtnMenuCaNhan_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            UserControl uc = null;
            int idToPass = this.userID; // ID luôn là ID cá nhân của Nhân viên đang đăng nhập

            try
            {
                switch (btn.Name)
                {
                    case "btnHoSoCaNhan":
                        uc = new QuanLyNhanVien(idToPass);
                        break;
                    case "btnLuongCaNhan":
                        uc = new BangLuong(idToPass);
                        break;
                    case "btnCongViecCaNhan":
                        uc = new BaoCaoPhanCong(idToPass);
                        break;

                    case "btnChamCong":
                        // SỬA LỖI: Gọi FormChamCong VỚI ĐỦ 2 THAM SỐ
                        // (Mở cửa sổ mới thay vì tải vào panel)

                        // FormChamCong chamCongForm = new FormChamCong(idToPass); // <-- Dòng này đã gây lỗi

                        FormChamCong chamCongForm = new FormChamCong(idToPass, this.userName); // <-- ĐÃ SỬA: Thêm this.userName
                        chamCongForm.Show();
                        return; // Rất quan trọng: Thoát để không cố gắng tải Form vào Panel chính

                    case "btnDangXuat":
                        BtnDangXuat_Click(sender, e);
                        return;
                }

                if (uc != null)
                {
                    this.HideSubMenus();
                    LoadControlToPanel(uc);
                }
                else if (btn.Name != "btnDangXuat")
                {
                    MessageBox.Show($"❌ Lỗi Cấu hình Giao diện!\n\nVui lòng kiểm tra: Nút '{btn.Text}' phải có thuộc tính Name khớp chính xác với code.", "Lỗi Tên Nút (Designer)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                string buttonName = btn.Name;
                string errorMessage = $"❌ Lỗi Runtime Tải UC/Form cho nút '{buttonName}':\n\n{ex.Message}";
                if (ex.InnerException != null)
                {
                    errorMessage += $"\n\nChi tiết (Inner Exception): {ex.InnerException.Message}";
                }
                MessageBox.Show(errorMessage, "Lỗi Tải Giao Diện", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- HÀM XỬ LÝ SỰ KIỆN ĐĂNG XUẤT ---
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
    }
}