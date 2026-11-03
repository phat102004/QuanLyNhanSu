using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; 

namespace QuanLyNhanSu.usercontrol
{
    public partial class ChiTietChamCong : UserControl
    {
        private string connectionString = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhanVien;Integrated Security=True;Trust Server Certificate=True";

        public ChiTietChamCong()
        {
            InitializeComponent();
        }

        private void ChiTietChamCong_Load(object sender, EventArgs e)
        {
            LoadNgayCong();
        }

        /// <summary>
        /// Cấu hình các cột cho DataGridView (Hiển thị TenNV)
        /// </summary>
        private void SetupDataGridViewColumns()
        {
            if (DgvChiTietChamCong.DataSource == null) return;

            if (DgvChiTietChamCong.Columns.Contains("NgayCongThangID"))
                DgvChiTietChamCong.Columns["NgayCongThangID"].Visible = false;
            if (DgvChiTietChamCong.Columns.Contains("HoTen"))
                DgvChiTietChamCong.Columns["HoTen"].HeaderText = "Tên Nhân Viên";

            if (DgvChiTietChamCong.Columns.Contains("Thang"))
                DgvChiTietChamCong.Columns["Thang"].HeaderText = "Tháng";

            if (DgvChiTietChamCong.Columns.Contains("Nam"))
                DgvChiTietChamCong.Columns["Nam"].HeaderText = "Năm";

            if (DgvChiTietChamCong.Columns.Contains("SoNgayCong"))
                DgvChiTietChamCong.Columns["SoNgayCong"].HeaderText = "Số Ngày Công";

            DgvChiTietChamCong.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        /// <summary>
        /// Tải dữ liệu tổng số ngày công từ bảng NgayCongThang theo Tháng và Năm
        /// </summary>
        private void LoadNgayCongTheoThangNam(int thang, int nam)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // ĐÃ SỬA: Sửa liên kết SQL dùng NhanVienID như bạn đã chỉ ra
                    string sql = @"
                        SELECT
                            NCT.NgayCongThangID,
                            NV.HoTen, -- Lấy tên nhân viên
                            NCT.Thang,
                            NCT.Nam,
                            NCT.SoNgayCong
                        FROM NgayCongThang NCT
                        INNER JOIN NhanVien NV ON NCT.NhanVienID = NV.NhanVienID -- <-- SỬA TẠI ĐÂY
                        WHERE NCT.Thang = @Thang AND NCT.Nam = @Nam";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Thang", thang);
                    cmd.Parameters.AddWithValue("@Nam", nam);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DgvChiTietChamCong.DataSource = dt;
                    SetupDataGridViewColumns(); 

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show($"Không tìm thấy dữ liệu tổng kết công cho tháng {thang}/{nam}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lọc dữ liệu ngày công: {ex.Message}", "Lỗi DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Tải tất cả dữ liệu tổng số ngày công
        /// </summary>
        private void LoadNgayCong()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = @"
                        SELECT
                            NCT.NgayCongThangID,
                            NV.HoTen, -- Lấy tên nhân viên
                            NCT.Thang,
                            NCT.Nam,
                            NCT.SoNgayCong
                        FROM NgayCongThang NCT
                        INNER JOIN NhanVien NV ON NCT.NhanVienID = NV.NhanVienID -- <-- SỬA TẠI ĐÂY
                        ORDER BY NCT.Nam DESC, NCT.Thang DESC";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DgvChiTietChamCong.DataSource = dt;
                    SetupDataGridViewColumns(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu ngày công: {ex.Message}", "Lỗi DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChiTietChamCong_Load_1(object sender, EventArgs e)
        {
            LoadNgayCong();
        }

        private void BtnLocNgay_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = DtpNgayChamCong.Value;
            int selectedThang = selectedDate.Month;
            int selectedNam = selectedDate.Year;
            LoadNgayCongTheoThangNam(selectedThang, selectedNam);
        }
    }
}