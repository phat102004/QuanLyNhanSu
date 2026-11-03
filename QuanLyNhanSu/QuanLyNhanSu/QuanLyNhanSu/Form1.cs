using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class Form1 : Form
    {
        // =========================================================
        // THÔNG TIN NGƯỜI DÙNG ĐĂNG NHẬP
        // =========================================================

        protected string userQuyen = "";
        protected int userID = 0;
        protected string userName = "";


        // =========================================================
        // CONSTRUCTOR MẶC ĐỊNH
        // =========================================================

        public Form1()
        {
            InitializeComponent();

            HideSubMenus();

            /*
             * KHÔNG gọi FixAllButtonsStyle() nữa.
             *
             * Vì Designer mới đã thiết kế:
             * - màu menu
             * - màu hover
             * - màu submenu
             * - font
             *
             * FixAllButtonsStyle() cũ sẽ ghi đè hết.
             */
        }


        // =========================================================
        // CONSTRUCTOR SAU KHI ĐĂNG NHẬP
        // =========================================================

        public Form1(
            string quyen,
            int nhanVienID,
            string tenNV)
        {
            InitializeComponent();

            userQuyen = quyen;
            userID = nhanVienID;
            userName = tenNV;

            HideSubMenus();

            ApplyPermissions();
        }


        // =========================================================
        // CLICK MENU CHÍNH
        // =========================================================

        protected virtual void BtnMenu_Click(
            object sender,
            EventArgs e)
        {
            Button btn = sender as Button;

            if (btn == null)
            {
                return;
            }

            ToggleSubMenu(btn);
        }


        // =========================================================
        // CLICK SUBMENU
        // =========================================================

        protected virtual void BtnSubmenu_Click(
            object sender,
            EventArgs e)
        {
            Button btn = sender as Button;

            if (btn == null)
            {
                return;
            }

            HideSubMenus();

            UserControl uc = null;

            switch (btn.Name)
            {
                // =================================================
                // LƯƠNG
                // =================================================

                case "btnTinhLuong":

                    uc =
                        new QuanLyNhanSu.usercontrol.TinhLuong(
                            this.userID
                        );

                    break;


                case "btnQuanLyBangLuong":

                    uc =
                        new QuanLyNhanSu.usercontrol.BaoCaoPhanTich();

                    break;


                case "btnChayBangLuong":

                    uc =
                        new QuanLyNhanSu.usercontrol.BangLuong();

                    break;


                // =================================================
                // NHÂN VIÊN
                // =================================================

                case "btnThemNhanVien":

                    uc =
                        new QuanLyNhanSu.usercontrol.ThemNhanVien();

                    break;


                case "btnQuanLyNhanVien":

                    uc =
                        new QuanLyNhanSu.usercontrol.QuanLyNhanVien();

                    break;


                case "btnQuanLyPhongBan":

                    uc =
                        new QuanLyNhanSu.usercontrol.Uc_phongBan();

                    break;


                /*
                 * QUAN TRỌNG:
                 *
                 * Designer của bạn tên là:
                 *
                 * btnTrinhDo
                 *
                 * chứ KHÔNG PHẢI:
                 *
                 * btnQuanLyTrinhDo
                 */
                case "btnTrinhDo":

                    uc =
                        new QuanLyNhanSu.usercontrol.TrinhDo();

                    break;


                // =================================================
                // PHÂN CÔNG
                // =================================================

                case "btnPhanCongCongViec":

                    /*
                     * Mình chưa đổi logic UserControl của bạn.
                     *
                     * Nếu bạn đã có UserControl PhanCongCongViec
                     * thì thêm tại đây.
                     *
                     * Hiện code cũ của bạn chưa có phần khởi tạo nó.
                     */

                    MessageBox.Show(
                        "Chức năng Phân Công Công Việc chưa được gắn UserControl trong Form1.cs.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    return;


                /*
                 * Designer hiện tại tên:
                 *
                 * btnBaoCaoPhanCong
                 *
                 * Đây chính là nút mở BaoCaoPhanCong.
                 */
                case "btnBaoCaoPhanCong":

                    uc =
                        new QuanLyNhanSu.usercontrol.BaoCaoPhanCong();

                    break;


                // =================================================
                // QUẢN LÝ CHỨC VỤ
                // =================================================

                case "btnChucVu":

                    uc =
                        new QuanLyNhanSu.usercontrol.ChucVu();

                    break;


                // =================================================
                // HỆ THỐNG
                // =================================================

                case "btnHeThong":
                    uc = new QuanLyNhanSu.usercontrol.HeThong(
                        this.userID,
                        this.userName,
                        this.userQuyen
                    );
                    break;
            }


            // =====================================================
            // LOAD USERCONTROL
            // =====================================================

            if (uc != null)
            {
                LoadControlToPanel(uc);
            }
            else
            {
                MessageBox.Show(
                    $"Chức năng '{btn.Text}' chưa được triển khai UserControl.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }


        // =========================================================
        // MENU CÁ NHÂN
        // =========================================================

        protected virtual void BtnMenuCaNhan_Click(
            object sender,
            EventArgs e)
        {
            Button btn = sender as Button;

            if (btn == null)
            {
                return;
            }

            /*
             * Giữ nguyên để các Form con như FormNhanVien,
             * FormTruongPhong... có thể override.
             */

            MessageBox.Show(
                $"Chức năng cá nhân '{btn.Text}' đã được click. " +
                "Cần triển khai logic tải UserControl trong Form con.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }


        // =========================================================
        // HÀM CŨ - GIỮ LẠI NẾU FORM CON ĐANG OVERRIDE
        // =========================================================

        protected virtual void BtnTinhLuong_Click(
            object sender,
            EventArgs e)
        {
            HideSubMenus();

            MessageBox.Show(
                "Chức năng 'Tính Lương' đã được click.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }


        // =========================================================
        // ẨN TOÀN BỘ SUBMENU
        // =========================================================

        protected void HideSubMenus()
        {
            if (panelHoSoSubmenu != null)
            {
                panelHoSoSubmenu.Visible = false;
            }

            if (panelLuongSubmenu != null)
            {
                panelLuongSubmenu.Visible = false;
            }

            if (panelPhanCongSubmenu != null)
            {
                panelPhanCongSubmenu.Visible = false;
            }
        }


        // =========================================================
        // MỞ / ĐÓNG SUBMENU
        // =========================================================

        protected void ToggleSubMenu(Button menuButton)
        {
            if (menuButton == null)
            {
                return;
            }

            Panel subMenu = null;

            switch (menuButton.Name)
            {
                case "btnHoSo":

                    subMenu =
                        panelHoSoSubmenu;

                    break;


                case "btnLuong":

                    subMenu =
                        panelLuongSubmenu;

                    break;


                case "btnPhanCong":

                    subMenu =
                        panelPhanCongSubmenu;

                    break;
            }


            // Nút không có submenu
            if (subMenu == null)
            {
                return;
            }


            // =====================================================
            // ĐANG MỞ -> ĐÓNG
            // =====================================================

            if (subMenu.Visible)
            {
                subMenu.Visible = false;

                return;
            }


            // =====================================================
            // ĐÓNG MENU KHÁC
            // =====================================================

            HideSubMenus();


            // =====================================================
            // MỞ MENU HIỆN TẠI
            // =====================================================

            subMenu.Visible = true;
        }


        // =========================================================
        // PHÂN QUYỀN
        // =========================================================

        protected void ApplyPermissions()
        {
            if (string.IsNullOrWhiteSpace(userQuyen))
            {
                return;
            }


            // =====================================================
            // GÁN TAG QUYỀN
            //
            // Dùng tên control thật trong Designer.
            // =====================================================

            if (btnThemNhanVien != null)
            {
                btnThemNhanVien.Tag =
                    "Admin,TruongPhong";
            }

            if (btnQuanLyNhanVien != null)
            {
                btnQuanLyNhanVien.Tag =
                    "Admin,TruongPhong";
            }

            if (btnQuanLyPhongBan != null)
            {
                btnQuanLyPhongBan.Tag =
                    "Admin,TruongPhong";
            }

            if (btnTrinhDo != null)
            {
                btnTrinhDo.Tag =
                    "Admin,TruongPhong";
            }


            // =====================================================
            // LƯƠNG
            // =====================================================

            if (btnTinhLuong != null)
            {
                btnTinhLuong.Tag =
                    "Admin,KeToan";
            }

            if (btnQuanLyBangLuong != null)
            {
                btnQuanLyBangLuong.Tag =
                    "Admin,KeToan,TruongPhong";
            }

            if (btnChayBangLuong != null)
            {
                btnChayBangLuong.Tag =
                    "Admin,KeToan";
            }


            // =====================================================
            // PHÂN CÔNG
            // =====================================================

            if (btnPhanCongCongViec != null)
            {
                btnPhanCongCongViec.Tag =
                    "Admin,TruongPhong";
            }

            if (btnBaoCaoPhanCong != null)
            {
                btnBaoCaoPhanCong.Tag =
                    "Admin,TruongPhong,NhanVien";
            }


            // =====================================================
            // ÁP DỤNG TAG CHO TOÀN BỘ BUTTON TRONG MENU
            //
            // Khác code cũ:
            // Code cũ chỉ kiểm tra button trực tiếp trong panelMenu.
            // Các button nằm trong submenu không được kiểm tra.
            //
            // Bản này kiểm tra đệ quy.
            // =====================================================

            ApplyPermissionRecursive(panelMenu);


            // =====================================================
            // QUYỀN NHÂN VIÊN
            // =====================================================

            if (userQuyen == "NhanVien")
            {
                // Không có quyền quản lý hồ sơ
                btnHoSo.Visible = false;

                // Không quản lý lương
                btnLuong.Visible = false;

                // Không quản lý phân công
                btnPhanCong.Visible = false;

                panelHoSoSubmenu.Visible = false;
                panelLuongSubmenu.Visible = false;
                panelPhanCongSubmenu.Visible = false;


                // Chức năng cá nhân
                btnHoSoCaNhan.Visible = true;
                btnLuongCaNhan.Visible = true;
                btnCongViecCaNhan.Visible = true;


                /*
                 * Nhân viên không cần nút Bảng Phân Công
                 * trong menu quản lý vì đã có
                 * Công Việc Của Tôi.
                 */
                btnBaoCaoPhanCong.Visible = false;
            }


            // =====================================================
            // QUYỀN TRƯỞNG PHÒNG
            // =====================================================

            else if (userQuyen == "TruongPhong")
            {
                // Có Hồ sơ
                btnHoSo.Visible = true;

                // Không quản lý lương
                btnLuong.Visible = false;

                // Có phân công
                btnPhanCong.Visible = true;

                panelLuongSubmenu.Visible = false;


                // Cá nhân
                btnHoSoCaNhan.Visible = true;
                btnLuongCaNhan.Visible = true;
                btnCongViecCaNhan.Visible = true;
            }


            // =====================================================
            // KẾ TOÁN
            // =====================================================

            else if (userQuyen == "KeToan")
            {
                // Không quản lý hồ sơ
                btnHoSo.Visible = false;

                // Có menu lương
                btnLuong.Visible = true;

                // Không quản lý phân công
                btnPhanCong.Visible = false;

                panelHoSoSubmenu.Visible = false;
                panelPhanCongSubmenu.Visible = false;


                // Cá nhân
                btnHoSoCaNhan.Visible = true;
                btnLuongCaNhan.Visible = true;
                btnCongViecCaNhan.Visible = true;
            }


            // =====================================================
            // ADMIN
            // =====================================================

            else if (userQuyen == "Admin")
            {
                btnHoSo.Visible = true;

                btnLuong.Visible = true;

                btnPhanCong.Visible = true;


                // Admin có Hồ sơ cá nhân
                btnHoSoCaNhan.Visible = true;


                // Giữ đúng logic cũ của bạn
                btnLuongCaNhan.Visible = false;

                btnCongViecCaNhan.Visible = false;
            }


            // =====================================================
            // SAU KHI PHÂN QUYỀN
            // BAN ĐẦU KHÔNG MỞ SUBMENU
            // =====================================================

            HideSubMenus();
        }


        // =========================================================
        // ÁP DỤNG TAG PHÂN QUYỀN ĐỆ QUY
        // =========================================================

        private void ApplyPermissionRecursive(Control parent)
        {
            if (parent == null)
            {
                return;
            }

            foreach (Control control in parent.Controls)
            {
                // -------------------------------------------------
                // BUTTON
                // -------------------------------------------------

                if (control is Button btn)
                {
                    string tag =
                        btn.Tag?.ToString() ?? "";

                    if (!string.IsNullOrWhiteSpace(tag))
                    {
                        string[] roles =
                            tag.Split(
                                ',',
                                StringSplitOptions.RemoveEmptyEntries
                            );

                        bool duocPhep =
                            roles.Any(
                                role =>
                                    role.Trim().Equals(
                                        userQuyen,
                                        StringComparison.OrdinalIgnoreCase
                                    )
                            );

                        btn.Visible =
                            duocPhep;
                    }
                }


                // -------------------------------------------------
                // CONTROL CON
                // -------------------------------------------------

                if (control.HasChildren)
                {
                    ApplyPermissionRecursive(control);
                }
            }
        }


        // =========================================================
        // LOAD USERCONTROL VÀO PANEL CONTENT
        // =========================================================

        protected void LoadControlToPanel(UserControl uc)
        {
            if (uc == null)
            {
                return;
            }

            if (panelContent == null)
            {
                MessageBox.Show(
                    "Không tìm thấy panelContent.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }


            // =====================================================
            // XÓA USERCONTROL CŨ
            // =====================================================

            panelContent.Controls.Clear();


            // =====================================================
            // USERCONTROL CHIẾM TOÀN BỘ PANEL
            // =====================================================

            uc.Dock =
                DockStyle.Fill;

            uc.Margin =
                new Padding(0);


            // =====================================================
            // THÊM VÀO PANEL
            // =====================================================

            panelContent.Controls.Add(
                uc
            );

            uc.BringToFront();
        }
    }
}