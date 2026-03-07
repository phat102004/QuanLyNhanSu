using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing; // Dùng cho Color
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyNhanSu.usercontrol
{
    public partial class BaoCaoPhanCong : UserControl
    {
        SqlDataAdapter docGhi;
        DataSet duLieu;

        SqlConnection ketNoi;
        string chuoiKN = "Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhanVienMain;Integrated Security=True;TrustServerCertificate=True;";

        private int loggedInUserID = 0;
        public BaoCaoPhanCong()
        {
            InitializeComponent();
            if (DgvPhanCong != null)
            {
                DgvPhanCong.CellClick += DgvPhanCong_CellClick;
            }
            if (BtnHoanThanh != null)
            {
                BtnHoanThanh.Click += BtnHoanThanh_Click;
            }
            this.Load += BaoCaoPhanCong_Load;
        }

        public BaoCaoPhanCong(int nhanVienID) : this()
        {
            this.loggedInUserID = nhanVienID;
        }

        // -----------------------------------------------------------------
        // ## 1. Xử Lý Sự Kiện Load Chính
        // -----------------------------------------------------------------
        private void BaoCaoPhanCong_Load(object sender, EventArgs e)
        {
            ketNoi = new SqlConnection(chuoiKN);

            if (DtpNgayTruoc != null) DtpNgayTruoc.Value = DateTime.Now.AddMonths(-1);
            if (DtpNgaySau != null) DtpNgaySau.Value = DateTime.Now;

            if (DgvPhanCong == null)
            {
                MessageBox.Show("LỖI UI: DataGridView DgvPhanCong chưa được khởi tạo (null).", "Lỗi Cấu hình", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ApplyUIAccess(); 
            Load_Data();      
        }

        // -----------------------------------------------------------------
        // ## 2. Phân Quyền Giao Diện
        // -----------------------------------------------------------------
        private void ApplyUIAccess()
        {
            if (this.loggedInUserID > 0) 
            {
                if (BtnTimKiem != null) BtnTimKiem.Visible = false;
                if (BtnLamMoi != null) BtnLamMoi.Visible = false;
                if (BtnXuatExcel != null) BtnXuatExcel.Visible = false;
                if (TxtTimKiem != null) TxtTimKiem.Visible = false;
                if (DtpNgayTruoc != null) DtpNgayTruoc.Visible = false;
                if (DtpNgaySau != null) DtpNgaySau.Visible = false;
                if (label1 != null) label1.Visible = false;
                if (label2 != null) label2.Visible = false;
                if (label4 != null) label4.Visible = false;
                if (groupBox1 != null) groupBox1.Visible = false;

                // Nút Hoàn thành: Mặc định ẩn, chỉ hiện khi click vào dòng "Chưa hoàn thành"
                if (BtnHoanThanh != null) BtnHoanThanh.Visible = false;

                if (DgvPhanCong != null) DgvPhanCong.ReadOnly = true;
            }
        }

        // -----------------------------------------------------------------
        // ## 3. Hàm Tải Dữ Liệu
        // -----------------------------------------------------------------
        private void Load_Data()
        {
            string sql = @"
                SELECT cv.CongViecID, nv.MaNhanVien, nv.HoTen, cv.TenCongViec, cv.NgayGiao, 	
                       cv.HanHoanThanh, cv.TrangThai, cv.NhanVienID	
                FROM CongViec cv
                JOIN NhanVien nv ON cv.NhanVienID = nv.NhanVienID	
                WHERE 1 = 1 ";

            if (this.loggedInUserID > 0)
            {
                sql += " AND cv.NhanVienID = @UserID ";
                sql += " ORDER BY CASE WHEN cv.TrangThai = N'Chưa hoàn thành' THEN 0 ELSE 1 END, cv.HanHoanThanh ASC";
            }
            else
            {
                sql += " ORDER BY cv.NgayGiao DESC, cv.TrangThai ASC";
            }

            try
            {
                if (DgvPhanCong != null) DgvPhanCong.DataSource = null;
                if (ketNoi.State == ConnectionState.Closed) ketNoi.Open();

                docGhi = new SqlDataAdapter(sql, ketNoi);

                if (this.loggedInUserID > 0)
                {
                    docGhi.SelectCommand.Parameters.AddWithValue("@UserID", this.loggedInUserID);
                }

                duLieu = new DataSet();
                docGhi.Fill(duLieu);

                if (duLieu.Tables.Count > 0 && DgvPhanCong != null)
                {
                    DgvPhanCong.DataSource = duLieu.Tables[0];
                    SetupDataGridViewColumns(); // Định dạng sau khi tải
                }

                if (ketNoi.State == ConnectionState.Open) ketNoi.Close();
            }
            catch (Exception ex)
            {
                if (ketNoi.State == ConnectionState.Open) ketNoi.Close();
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // -----------------------------------------------------------------
        // ## 4. Cài Đặt Cột và Tô Màu Trạng Thái
        // -----------------------------------------------------------------
        private void SetupDataGridViewColumns()
        {
            if (DgvPhanCong == null || DgvPhanCong.Columns.Count == 0) return;

            try
            {
                if (DgvPhanCong.Columns.Contains("CongViecID")) DgvPhanCong.Columns["CongViecID"].Visible = false;
                if (DgvPhanCong.Columns.Contains("NhanVienID")) DgvPhanCong.Columns["NhanVienID"].Visible = false;
                if (DgvPhanCong.Columns.Contains("MaNhanVien")) DgvPhanCong.Columns["MaNhanVien"].HeaderText = "Mã NV";
                if (DgvPhanCong.Columns.Contains("HoTen")) DgvPhanCong.Columns["HoTen"].HeaderText = "Họ Tên";
                if (DgvPhanCong.Columns.Contains("TenCongViec")) DgvPhanCong.Columns["TenCongViec"].HeaderText = "Tên Công Việc";
                if (DgvPhanCong.Columns.Contains("NgayGiao")) DgvPhanCong.Columns["NgayGiao"].HeaderText = "Ngày Giao";
                if (DgvPhanCong.Columns.Contains("HanHoanThanh")) DgvPhanCong.Columns["HanHoanThanh"].HeaderText = "Hạn Hoàn Thành";
                if (DgvPhanCong.Columns.Contains("TrangThai")) DgvPhanCong.Columns["TrangThai"].HeaderText = "Trạng Thái";

                if (DgvPhanCong.Columns.Contains("NgayGiao")) DgvPhanCong.Columns["NgayGiao"].DefaultCellStyle.Format = "dd/MM/yyyy";
                if (DgvPhanCong.Columns.Contains("HanHoanThanh")) DgvPhanCong.Columns["HanHoanThanh"].DefaultCellStyle.Format = "dd/MM/yyyy";

                if (DgvPhanCong.Columns.Contains("TenCongViec")) DgvPhanCong.Columns["TenCongViec"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                if (DgvPhanCong.Columns.Contains("HoTen")) DgvPhanCong.Columns["HoTen"].Width = 150;
                if (DgvPhanCong.Columns.Contains("TrangThai")) DgvPhanCong.Columns["TrangThai"].Width = 120;
                foreach (DataGridViewRow row in DgvPhanCong.Rows)
                {
                    string status = row.Cells["TrangThai"].Value?.ToString();
                    if (status == "Chưa hoàn thành")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                    else if (status == "Hoàn thành")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = DgvPhanCong.DefaultCellStyle.BackColor;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cấu hình cột DataGridView: " + ex.Message, "Lỗi Cấu hình", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // -----------------------------------------------------------------
        // ## 5. Xử Lý Sự Kiện Click Cell (Ẩn/Hiện Nút)
        // -----------------------------------------------------------------
        private void DgvPhanCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.loggedInUserID == 0) return;

            if (e.RowIndex < 0 || e.RowIndex >= DgvPhanCong.Rows.Count)
            {
                if (BtnHoanThanh != null) BtnHoanThanh.Visible = false;
                return;
            }

            try
            {
                DgvPhanCong.ClearSelection();
                DgvPhanCong.Rows[e.RowIndex].Selected = true;

                object statusValue = DgvPhanCong.Rows[e.RowIndex].Cells["TrangThai"].Value;

                if (BtnHoanThanh != null)
                {
                    // HIỂN THỊ nút nếu trạng thái là "Chưa hoàn thành"
                    if (statusValue != null && statusValue.ToString() == "Chưa hoàn thành")
                    {
                        BtnHoanThanh.Visible = true;
                    }
                    else
                    {
                        BtnHoanThanh.Visible = false;
                    }
                }
            }
            catch (Exception)
            {
                if (BtnHoanThanh != null) BtnHoanThanh.Visible = false;
            }
        }

        // -----------------------------------------------------------------
        // ## 6. Xử Lý Sự Kiện Click Nút Hoàn Thành
        // -----------------------------------------------------------------
        private void BtnHoanThanh_Click(object sender, EventArgs e)
        {
            if (DgvPhanCong.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DgvPhanCong.SelectedRows[0];

                if (selectedRow.Cells["CongViecID"].Value != null)
                {
                    int congViecID = Convert.ToInt32(selectedRow.Cells["CongViecID"].Value);
                    string trangThaiHienTai = selectedRow.Cells["TrangThai"].Value?.ToString();

                    if (trangThaiHienTai == "Hoàn thành")
                    {
                        MessageBox.Show("Công việc này đã được đánh dấu là Hoàn thành trước đó.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    DialogResult dialogResult = MessageBox.Show(
                        $"Xác nhận đánh dấu Công việc ID {congViecID} là Đã hoàn thành?",
                        "Xác nhận Hoàn thành",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (dialogResult == DialogResult.Yes)
                    {
                        UpdateTrangThaiCongViec(congViecID);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy ID công việc.", "Lỗi Dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một công việc cần hoàn thành.", "Thiếu chọn dòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // -----------------------------------------------------------------
        // ## 7. Hàm Cập Nhật Trạng Thái trong CSDL
        // -----------------------------------------------------------------
        private void UpdateTrangThaiCongViec(int congViecID)
        {
            string query = "UPDATE CongViec SET TrangThai = @TrangThai WHERE CongViecID = @ID AND NhanVienID = @NhanVienID";

            try
            {
                if (ketNoi.State == ConnectionState.Closed) ketNoi.Open();

                using (SqlCommand cmd = new SqlCommand(query, ketNoi))
                {
                    cmd.Parameters.AddWithValue("@TrangThai", "Hoàn thành");
                    cmd.Parameters.AddWithValue("@ID", congViecID);
                    cmd.Parameters.AddWithValue("@NhanVienID", this.loggedInUserID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật trạng thái công việc thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Load_Data();
                        if (BtnHoanThanh != null) BtnHoanThanh.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật trạng thái (ID Công việc không tồn tại hoặc bạn không được phân công).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (ketNoi.State == ConnectionState.Open) ketNoi.Close();
            }
            catch (Exception ex)
            {
                if (ketNoi.State == ConnectionState.Open) ketNoi.Close();
                MessageBox.Show($"Lỗi CSDL khi cập nhật trạng thái: {ex.Message}", "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTimKiem_Click(object sender, EventArgs e) { }
        private void TxtTimKiem_TextChanged(object sender, EventArgs e) { }
        private void BtnLamMoi_Click(object sender, EventArgs e) { }
        private void BtnXuatExcel_Click(object sender, EventArgs e) { }
    }
}