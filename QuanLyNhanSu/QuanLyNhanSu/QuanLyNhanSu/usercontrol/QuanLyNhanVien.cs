using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.usercontrol
{
    public partial class QuanLyNhanVien : UserControl
    {
        SqlCommand boLenh;
        SqlConnection ketNoi;
        DataSet duLieu;
        SqlDataAdapter docGhi;

        string chuoiKN = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhanVien;Integrated Security=True;Trust Server Certificate=True";

        private int loggedInUserID = 0;
        private string loggedInUserRole = "";
        private Panel personalProfilePanel;

        // Theo luồng hiện tại:
        // ID > 0: hồ sơ cá nhân
        // ID = 0: chế độ quản lý
        private bool IsPersonalMode()
        {
            return loggedInUserID > 0;
        }

        public QuanLyNhanVien() : this(0, "")
        {
        }

        public QuanLyNhanVien(int nhanVienID) : this(nhanVienID, "")
        {
        }

        public QuanLyNhanVien(int nhanVienID, string quyen)
        {
            InitializeComponent();

            this.loggedInUserID = nhanVienID;
            this.loggedInUserRole = quyen;

        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            ketNoi = new SqlConnection(chuoiKN);

            LoadUserRole();
            ApplyUIAccess();
            Load_Data();

            if (IsPersonalMode())
            {
                ShowPersonalProfile();
            }
        }


        private void ShowPersonalProfile()
        {
            if (!IsPersonalMode())
                return;

            if (duLieu == null ||
                duLieu.Tables.Count == 0 ||
                duLieu.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show(
                    "Không tìm thấy hồ sơ của tài khoản hiện tại.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            DataRow nv = duLieu.Tables[0].Rows[0];

            if (personalProfilePanel != null)
            {
                Controls.Remove(personalProfilePanel);
                personalProfilePanel.Dispose();
            }

            personalProfilePanel = new Panel
            {
                Name = "personalProfilePanel",
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = Color.FromArgb(245, 247, 251),
                Padding = new Padding(24)
            };

            TableLayoutPanel layout = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                AutoSize = true,
                ColumnCount = 1,
                RowCount = 0,
                Padding = new Padding(8),
                BackColor = Color.White
            };

            layout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100)
            );

            AddTitle(layout, "HỒ SƠ CÁ NHÂN");

            AddTitle(
                layout,
                GetValue(nv, "HoTen")
            );

            AddField(
                layout,
                "Mã nhân viên",
                GetValue(nv, "MaNhanVien")
            );

            AddTitle(layout, "THÔNG TIN CƠ BẢN");

            AddField(layout, "Họ và tên",
                GetValue(nv, "HoTen"));

            AddField(layout, "Ngày sinh",
                GetDate(nv, "NgaySinh"));

            AddField(layout, "Giới tính",
                GetValue(nv, "GioiTinh"));

            AddField(layout, "Số điện thoại",
                GetValue(nv, "SoDienThoai"));

            AddField(layout, "Email",
                GetValue(nv, "Email"));

            AddField(layout, "Địa chỉ",
                GetValue(nv, "DiaChi"));

            AddTitle(layout, "THÔNG TIN CÔNG VIỆC");

            AddField(layout, "Phòng ban",
                GetValue(nv, "TenPhongBan"));

            AddField(layout, "Chức vụ",
                GetValue(nv, "TenChucVu"));

            AddField(layout, "Trình độ",
                GetValue(nv, "TenTrinhDo"));

            AddField(layout, "Ngày vào làm",
                GetDate(nv, "NgayVaoLam"));

            AddField(layout, "Trạng thái",
                GetValue(nv, "TrangThaiLamViec"));

            personalProfilePanel.Controls.Add(layout);

            // Hiển thị Dashboard phía trước các control cũ.
            Controls.Add(personalProfilePanel);
            personalProfilePanel.BringToFront();
        }

        // Tạo tiêu đề cho từng khu vực.
        private void AddTitle(
            TableLayoutPanel layout,
            string title)
        {
            Label label = new Label
            {
                Text = title,
                Font = new Font(
                    "Segoe UI",
                    15,
                    FontStyle.Bold
                ),
                ForeColor = Color.FromArgb(25, 48, 80),
                Dock = DockStyle.Fill,
                AutoSize = true,
                Padding = new Padding(10, 16, 10, 12)
            };

            layout.RowCount++;
            layout.RowStyles.Add(
                new RowStyle(SizeType.AutoSize)
            );
            layout.Controls.Add(label, 0, layout.RowCount - 1);
        }

        // Tạo một dòng thông tin.
        private void AddField(
            TableLayoutPanel layout,
            string labelText,
            string valueText)
        {
            TableLayoutPanel field = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 65,
                ColumnCount = 2,
                Padding = new Padding(12, 8, 12, 8),
                BackColor = Color.FromArgb(248, 250, 253),
                Margin = new Padding(4, 3, 4, 3)
            };

            field.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 35)
            );

            field.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 65)
            );

            Label label = new Label
            {
                Text = labelText,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.DimGray
            };

            Label value = new Label
            {
                Text = valueText,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold
                ),
                ForeColor = Color.FromArgb(30, 45, 65),
                AutoEllipsis = true
            };

            field.Controls.Add(label, 0, 0);
            field.Controls.Add(value, 1, 0);

            layout.RowCount++;
            layout.RowStyles.Add(
                new RowStyle(SizeType.AutoSize)
            );
            layout.Controls.Add(field, 0, layout.RowCount - 1);
        }

        // Đọc dữ liệu từ DataRow an toàn.
        private string GetValue(DataRow row, string column)
        {
            if (!row.Table.Columns.Contains(column))
                return "Chưa cập nhật";

            if (row.IsNull(column))
                return "Chưa cập nhật";

            string value = row[column].ToString();

            return string.IsNullOrWhiteSpace(value)
                ? "Chưa cập nhật"
                : value;
        }

        // Định dạng ngày tháng.
        private string GetDate(DataRow row, string column)
        {
            if (!row.Table.Columns.Contains(column) ||
                row.IsNull(column))
            {
                return "Chưa cập nhật";
            }

            if (DateTime.TryParse(
                row[column].ToString(),
                out DateTime date))
            {
                return date.ToString("dd/MM/yyyy");
            }

            return "Chưa cập nhật";
        }


        // ============================================================
        // LOAD DỮ LIỆU
        // ============================================================
        private void Load_Data()
        {
            string sql = @"
                SELECT 
                    nv.MaNhanVien,
                    nv.HoTen,
                    nv.NgaySinh,
                    nv.GioiTinh,
                    nv.DiaChi,
                    nv.SoDienThoai,
                    nv.Email,
                    nv.CMND_CCCD,
                    nv.NgayVaoLam,
                    tt.TrangThaiID,
                    tt.TenTrangThai AS TrangThaiLamViec,
                    td.TrinhDoID,
                    td.TenTrinhDo,
                    pb.PhongBanID,
                    pb.TenPhongBan,
                    cv.ChucVuID,
                    cv.TenChucVu,
                    nv.NhanVienID 
                FROM NhanVien nv

                JOIN PhongBan pb 
                    ON nv.PhongBanID = pb.PhongBanID

                JOIN ChucVu cv 
                    ON nv.ChucVuID = cv.ChucVuID

                JOIN TrinhDo td 
                    ON nv.TrinhDoID = td.TrinhDoID

                JOIN TrangThaiNhanVien tt
                    ON nv.TrangThaiID = tt.TrangThaiID";

            if (this.loggedInUserID > 0)
            {
                sql += " WHERE nv.NhanVienID = @UserID";
            }

            try
            {
                if (ketNoi.State != ConnectionState.Open)
                {
                    ketNoi.Open();
                }

                docGhi = new SqlDataAdapter(sql, ketNoi);

                if (this.loggedInUserID > 0)
                {
                    docGhi.SelectCommand.Parameters.AddWithValue(
                        "@UserID",
                        this.loggedInUserID
                    );
                }

                duLieu = new DataSet();

                docGhi.Fill(duLieu);

                DgvDanhSachNhanVien.DataSource =
                    duLieu.Tables[0];

                HideIDColumns();

                ketNoi.Close();
            }
            catch (Exception ex)
            {
                if (ketNoi != null &&
                    ketNoi.State == ConnectionState.Open)
                {
                    ketNoi.Close();
                }

                MessageBox.Show(
                    "Lỗi tải dữ liệu nhân viên: " + ex.Message,
                    "Lỗi SQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ============================================================
        // ẨN CÁC CỘT ID
        // ============================================================
        private void HideIDColumns()
        {
            if (DgvDanhSachNhanVien.Columns.Contains("NhanVienID"))
            {
                DgvDanhSachNhanVien.Columns[
                    "NhanVienID"
                ].Visible = false;
            }

            if (DgvDanhSachNhanVien.Columns.Contains("TrangThaiID"))
            {
                DgvDanhSachNhanVien.Columns[
                    "TrangThaiID"
                ].Visible = false;
            }

            if (DgvDanhSachNhanVien.Columns.Contains("TrinhDoID"))
            {
                DgvDanhSachNhanVien.Columns[
                    "TrinhDoID"
                ].Visible = false;
            }

            if (DgvDanhSachNhanVien.Columns.Contains("PhongBanID"))
            {
                DgvDanhSachNhanVien.Columns[
                    "PhongBanID"
                ].Visible = false;
            }

            if (DgvDanhSachNhanVien.Columns.Contains("ChucVuID"))
            {
                DgvDanhSachNhanVien.Columns[
                    "ChucVuID"
                ].Visible = false;
            }
        }

        // ============================================================
        // PHÂN QUYỀN GIAO DIỆN
        // ============================================================
        private void ApplyUIAccess()
        {
            // ========================================================
            // NHÂN VIÊN + KẾ TOÁN
            // ========================================================
            // ========================================================
            // NHÂN VIÊN + KẾ TOÁN
            // ========================================================
            if (IsPersonalMode())
            {
                // Ẩn toàn bộ khu vực tìm kiếm / sửa / xóa
                if (pntop != null)
                {
                    pntop.Visible = false;
                }

                if (topLayout != null)
                {
                    topLayout.Visible = false;
                }

                if (BtnSuaThongTinNhanVien != null)
                {
                    BtnSuaThongTinNhanVien.Visible = false;
                }

                if (BtnXoaNhanVien != null)
                {
                    BtnXoaNhanVien.Visible = false;
                }

                if (TxtTimKiem != null)
                {
                    TxtTimKiem.Visible = false;
                }

                if (TxtNVCanXoaSua != null)
                {
                    TxtNVCanXoaSua.Visible = false;
                }

                // Đưa DataGridView lên ngay dưới tiêu đề
                if (DgvDanhSachNhanVien != null)
                {
                    DgvDanhSachNhanVien.ReadOnly = true;
                    DgvDanhSachNhanVien.MultiSelect = false;

                    DgvDanhSachNhanVien.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect;
                }

                // Xóa khoảng trống của pntop
                if (mainLayout != null)
                {
                    mainLayout.RowStyles[1].Height = 0;
                }
            }

            // ========================================================
            // ADMIN + TRƯỞNG PHÒNG
            // ========================================================
            else
            {
                // Hiện lại khu vực chức năng
                if (pntop != null)
                {
                    pntop.Visible = true;
                }

                if (topLayout != null)
                {
                    topLayout.Visible = true;
                }

                if (BtnSuaThongTinNhanVien != null)
                {
                    BtnSuaThongTinNhanVien.Visible = true;
                }

                if (BtnXoaNhanVien != null)
                {
                    BtnXoaNhanVien.Visible = true;
                }

                if (TxtTimKiem != null)
                {
                    TxtTimKiem.Visible = true;
                }

                if (TxtNVCanXoaSua != null)
                {
                    TxtNVCanXoaSua.Visible = true;
                }

                if (DgvDanhSachNhanVien != null)
                {
                    DgvDanhSachNhanVien.ReadOnly = false;
                    DgvDanhSachNhanVien.MultiSelect = true;

                    DgvDanhSachNhanVien.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect;
                }

                // Trả lại chiều cao khu vực chức năng
                if (mainLayout != null)
                {
                    mainLayout.RowStyles[1].Height = 95;
                }
            }
        }

        // ============================================================
        // LẤY QUYỀN NGƯỜI DÙNG
        // ============================================================
        private void LoadUserRole()
        {
            if (loggedInUserID <= 0)
            {
                return;
            }

            string sql = @"
                SELECT q.TenQuyen
                FROM TaiKhoan tk
                INNER JOIN Quyen q
                    ON tk.QuyenID = q.QuyenID
                WHERE tk.NhanVienID = @NhanVienID";

            try
            {
                if (ketNoi.State != ConnectionState.Open)
                {
                    ketNoi.Open();
                }

                boLenh = new SqlCommand(sql, ketNoi);

                boLenh.Parameters.AddWithValue(
                    "@NhanVienID",
                    loggedInUserID
                );

                object result =
                    boLenh.ExecuteScalar();

                if (result != null)
                {
                    loggedInUserRole =
                        result.ToString();
                }

                ketNoi.Close();
            }
            catch (Exception ex)
            {
                if (ketNoi.State == ConnectionState.Open)
                {
                    ketNoi.Close();
                }

                MessageBox.Show(
                    "Lỗi lấy quyền người dùng: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ============================================================
        // XÓA NHÂN VIÊN
        // ============================================================
        private void BtnXoaNhanVien_Click(
            object sender,
            EventArgs e)
        {
            if (loggedInUserRole == "NhanVien" ||
                loggedInUserRole == "KeToan")
            {
                MessageBox.Show(
                    "Bạn không có quyền xóa nhân viên.",
                    "Không có quyền",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop
                );

                return;
            }

            if (this.loggedInUserID > 0)
            {
                MessageBox.Show(
                    "Bạn không có quyền xóa nhân viên.",
                    "Không có quyền",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop
                );

                return;
            }

            if (TxtNVCanXoaSua == null ||
                string.IsNullOrEmpty(
                    TxtNVCanXoaSua.Text))
            {
                MessageBox.Show(
                    "Vui lòng chọn nhân viên cần xóa!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string maNVXoa =
                TxtNVCanXoaSua.Text;

            string xoa = @"
                DELETE FROM NhanVien 
                WHERE MaNhanVien = @MaNhanVien";

            DialogResult result =
                MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa nhân viên có Mã: {maNVXoa}?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (ketNoi.State != ConnectionState.Open)
                    {
                        ketNoi.Open();
                    }

                    boLenh =
                        new SqlCommand(
                            xoa,
                            ketNoi
                        );

                    boLenh.Parameters.AddWithValue(
                        "@MaNhanVien",
                        maNVXoa
                    );

                    int rowsAffected =
                        boLenh.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show(
                            "Xóa nhân viên thành công!!"
                        );

                        TxtNVCanXoaSua.Text = "";

                        Load_Data();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Không tìm thấy nhân viên để xóa.",
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Lỗi khi xóa nhân viên: " +
                        ex.Message,
                        "Lỗi Xóa Dữ Liệu",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                finally
                {
                    if (ketNoi.State == ConnectionState.Open)
                    {
                        ketNoi.Close();
                    }
                }
            }
        }

        // ============================================================
        // SỬA THÔNG TIN NHÂN VIÊN
        // ============================================================
        private void BtnSuaThongTinNhanVien_Click(
            object sender,
            EventArgs e)
        {
            if (loggedInUserRole == "NhanVien" ||
                loggedInUserRole == "KeToan")
            {
                MessageBox.Show(
                    "Bạn không có quyền sửa hồ sơ nhân viên.",
                    "Không có quyền",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop
                );

                return;
            }

            if (DgvDanhSachNhanVien.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn nhân viên trong danh sách để sửa!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DataGridViewRow currentRow =
                DgvDanhSachNhanVien.CurrentRow;

            int selectedNhanVienID =
                Convert.ToInt32(
                    currentRow.Cells["NhanVienID"].Value
                );

            if (this.loggedInUserID > 0 &&
                selectedNhanVienID != this.loggedInUserID)
            {
                MessageBox.Show(
                    "Bạn chỉ có thể sửa hồ sơ cá nhân của chính mình.",
                    "Không có quyền",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop
                );

                return;
            }

            if (this.loggedInUserID == 0 &&
                (TxtNVCanXoaSua == null ||
                 string.IsNullOrEmpty(
                     TxtNVCanXoaSua.Text)))
            {
                MessageBox.Show(
                    "Admin/QL vui lòng chọn nhân viên cần sửa bằng cách click vào lưới.",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                string MaNV =
                    currentRow.Cells[
                        "MaNhanVien"
                    ].Value.ToString();

                string HoTenNV =
                    currentRow.Cells[
                        "HoTen"
                    ].Value.ToString();

                string NgaySinhNV =
                    Convert.ToDateTime(
                        currentRow.Cells[
                            "NgaySinh"
                        ].Value
                    ).ToString("yyyy-MM-dd");

                string GioiTinhNV =
                    currentRow.Cells[
                        "GioiTinh"
                    ].Value.ToString();

                string DiaChiNV =
                    currentRow.Cells[
                        "DiaChi"
                    ].Value.ToString();

                string SoDienThoaiNV =
                    currentRow.Cells[
                        "SoDienThoai"
                    ].Value.ToString();

                string EmailNV =
                    currentRow.Cells[
                        "Email"
                    ].Value.ToString();

                string CMND_CCCDNV =
                    currentRow.Cells[
                        "CMND_CCCD"
                    ].Value.ToString();

                string NgayVaoLamNV =
                    Convert.ToDateTime(
                        currentRow.Cells[
                            "NgayVaoLam"
                        ].Value
                    ).ToString("yyyy-MM-dd");

                // Lấy tên trạng thái từ bảng TrangThaiNhanVien
                string TrangThaiLamViecNV =
                    currentRow.Cells[
                        "TrangThaiLamViec"
                    ].Value.ToString();

                int PhongBanID =
                    Convert.ToInt32(
                        currentRow.Cells[
                            "PhongBanID"
                        ].Value
                    );

                int ChucVuID =
                    Convert.ToInt32(
                        currentRow.Cells[
                            "ChucVuID"
                        ].Value
                    );

                int TrinhDoID =
                    Convert.ToInt32(
                        currentRow.Cells[
                            "TrinhDoID"
                        ].Value
                    );

                using (FormSuaNhanVien formsua =
                    new FormSuaNhanVien(
                        MaNV,
                        HoTenNV,
                        NgaySinhNV,
                        GioiTinhNV,
                        DiaChiNV,
                        SoDienThoaiNV,
                        EmailNV,
                        CMND_CCCDNV,
                        NgayVaoLamNV,
                        TrangThaiLamViecNV,
                        TrinhDoID,
                        PhongBanID,
                        ChucVuID))
                {
                    formsua.DuLieuDaCapNhat +=
                        (s, ev) => Load_Data();

                    if (this.loggedInUserID == 0)
                    {
                        formsua.DuLieuDaCapNhat +=
                            (s, ev) =>
                                TxtNVCanXoaSua.Text = "";
                    }

                    this.Visible = false;

                    formsua.ShowDialog(
                        this.ParentForm
                    );

                    this.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi chuẩn bị dữ liệu sửa: " +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ============================================================
        // CLICK DATAGRIDVIEW
        // ============================================================
        private void DgvDanhSachNhanVien_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow selectedRow =
                DgvDanhSachNhanVien.Rows[
                    e.RowIndex
                ];

            if (this.loggedInUserID == 0 &&
                TxtNVCanXoaSua != null)
            {
                TxtNVCanXoaSua.Text =
                    selectedRow.Cells[
                        "MaNhanVien"
                    ].Value.ToString();
            }
        }

        // ============================================================
        // TÌM KIẾM NHÂN VIÊN
        // ============================================================
        private void TxtTimKiem_TextChanged(
            object sender,
            EventArgs e)
        {
            if (loggedInUserRole == "NhanVien" ||
                loggedInUserRole == "KeToan")
            {
                return;
            }

            if (this.loggedInUserID > 0)
            {
                return;
            }

            if (TxtTimKiem == null)
            {
                return;
            }

            if (string.IsNullOrEmpty(
                TxtTimKiem.Text.Trim()))
            {
                Load_Data();

                return;
            }

            string timKiem = @"
                SELECT 
                    nv.MaNhanVien,
                    nv.HoTen,
                    nv.NgaySinh,
                    nv.GioiTinh,
                    nv.DiaChi,
                    nv.SoDienThoai,
                    nv.Email,
                    nv.CMND_CCCD,
                    nv.NgayVaoLam,
                    tt.TrangThaiID,
                    tt.TenTrangThai AS TrangThaiLamViec,
                    td.TenTrinhDo AS TenTrinhDo,
                    pb.TenPhongBan AS TenPhongBan,
                    cv.TenChucVu AS TenChucVu,
                    nv.NhanVienID,
                    td.TrinhDoID,
                    pb.PhongBanID,
                    cv.ChucVuID
                FROM NhanVien nv

                JOIN PhongBan pb 
                    ON pb.PhongBanID = nv.PhongBanID

                JOIN ChucVu cv 
                    ON cv.ChucVuID = nv.ChucVuID

                JOIN TrinhDo td 
                    ON nv.TrinhDoID = td.TrinhDoID

                JOIN TrangThaiNhanVien tt
                    ON nv.TrangThaiID = tt.TrangThaiID

                WHERE nv.HoTen LIKE @HoTen";

            try
            {
                if (ketNoi.State != ConnectionState.Open)
                {
                    ketNoi.Open();
                }

                boLenh =
                    new SqlCommand(
                        timKiem,
                        ketNoi
                    );

                boLenh.Parameters.AddWithValue(
                    "@HoTen",
                    "%" + TxtTimKiem.Text + "%"
                );

                docGhi =
                    new SqlDataAdapter(
                        boLenh
                    );

                duLieu = new DataSet();

                docGhi.Fill(duLieu);

                DgvDanhSachNhanVien.DataSource =
                    duLieu.Tables[0];

                HideIDColumns();

                ketNoi.Close();
            }
            catch (Exception ex)
            {
                if (ketNoi.State == ConnectionState.Open)
                {
                    ketNoi.Close();
                }

                MessageBox.Show(
                    "Lỗi tìm kiếm: " +
                    ex.Message,
                    "Lỗi SQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}