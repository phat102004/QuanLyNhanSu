using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ClosedXML.Excel;
namespace QuanLyNhanSu.usercontrol
{
    public partial class BaoCaoPhanCong : UserControl
    {
        SqlCommand boLenh;
        SqlConnection ketNoi;
        DataSet duLieu;
        SqlDataAdapter docGhi;

        string chuoiKN = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhanVien;Integrated Security=True;Trust Server Certificate=True";

        private int loggedInUserID = 0;
        private DataTable _duLieuPhanCong;
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

        // ============================================================
        // LOAD
        // ============================================================
        private void BaoCaoPhanCong_Load(object sender, EventArgs e)
        {
            ketNoi = new SqlConnection(chuoiKN);

            if (DtpNgayTruoc != null)
            {
                DtpNgayTruoc.Value = DateTime.Now.AddMonths(-1);
            }

            if (DtpNgaySau != null)
            {
                DtpNgaySau.Value = DateTime.Now;
            }

            if (DgvPhanCong == null)
            {
                MessageBox.Show(
                    "LỖI UI: DataGridView DgvPhanCong chưa được khởi tạo (null).",
                    "Lỗi Cấu hình",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            ApplyUIAccess();
            Load_Data();
        }

        // ============================================================
        // PHÂN QUYỀN GIAO DIỆN
        // ============================================================
       private void ApplyUIAccess()
{
    if (this.loggedInUserID > 0)
    {
        // Nhân viên

        if (BtnTimKiem != null)
            BtnTimKiem.Visible = false;

        if (BtnLamMoi != null)
            BtnLamMoi.Visible = false;

        if (BtnXuatExcel != null)
            BtnXuatExcel.Visible = false;

        if (TxtTimKiem != null)
            TxtTimKiem.Visible = false;

        if (DtpNgayTruoc != null)
            DtpNgayTruoc.Visible = false;

        if (DtpNgaySau != null)
            DtpNgaySau.Visible = false;

        if (label1 != null)
            label1.Visible = false;

        if (label2 != null)
            label2.Visible = false;

        if (label4 != null)
            label4.Visible = false;

        if (groupBox1 != null)
            groupBox1.Visible = false;

        // Nhân viên: mặc định ẩn,
        // chỉ hiện khi click công việc chưa hoàn thành
        if (BtnHoanThanh != null)
            BtnHoanThanh.Visible = false;

        if (DgvPhanCong != null)
            DgvPhanCong.ReadOnly = true;
    }
    else
    {
        // Admin / Quản lý
        // Không được bấm hoàn thành thay nhân viên
        if (BtnHoanThanh != null)
        {
            BtnHoanThanh.Visible = false;
        }
    }
}

        // ============================================================
        // LOAD DỮ LIỆU
        // ============================================================
        private void Load_Data()
        {
            string sql = @"
                SELECT 
                    cv.CongViecID,
                    nv.MaNhanVien,
                    nv.HoTen,
                    cv.TenCongViec,
                    cv.NgayGiao,
                    cv.HanHoanThanh,
                    cv.TrangThai,
                    cv.NhanVienID
                FROM CongViec cv
                JOIN NhanVien nv 
                    ON cv.NhanVienID = nv.NhanVienID
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
                if (DgvPhanCong != null)
                {
                    DgvPhanCong.DataSource = null;
                }

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

                if (duLieu.Tables.Count > 0 && DgvPhanCong != null)
                {
                    // Lưu lại DataTable gốc để dùng cho tìm kiếm/lọc
                    _duLieuPhanCong = duLieu.Tables[0];

                    DgvPhanCong.DataSource = _duLieuPhanCong;

                    SetupDataGridViewColumns();
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
                    "Lỗi tải dữ liệu: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ============================================================
        // CÀI ĐẶT DATAGRIDVIEW
        // ============================================================
        private void SetupDataGridViewColumns()
        {
            if (DgvPhanCong == null || DgvPhanCong.Columns.Count == 0)
            {
                return;
            }

            try
            {
                if (DgvPhanCong.Columns.Contains("CongViecID"))
                {
                    DgvPhanCong.Columns["CongViecID"].Visible = false;
                }

                if (DgvPhanCong.Columns.Contains("NhanVienID"))
                {
                    DgvPhanCong.Columns["NhanVienID"].Visible = false;
                }

                if (DgvPhanCong.Columns.Contains("MaNhanVien"))
                {
                    DgvPhanCong.Columns["MaNhanVien"].HeaderText = "Mã NV";
                }

                if (DgvPhanCong.Columns.Contains("HoTen"))
                {
                    DgvPhanCong.Columns["HoTen"].HeaderText = "Họ Tên";
                }

                if (DgvPhanCong.Columns.Contains("TenCongViec"))
                {
                    DgvPhanCong.Columns["TenCongViec"].HeaderText = "Tên Công Việc";
                }

                if (DgvPhanCong.Columns.Contains("NgayGiao"))
                {
                    DgvPhanCong.Columns["NgayGiao"].HeaderText = "Ngày Giao";
                }

                if (DgvPhanCong.Columns.Contains("HanHoanThanh"))
                {
                    DgvPhanCong.Columns["HanHoanThanh"].HeaderText = "Hạn Hoàn Thành";
                }

                if (DgvPhanCong.Columns.Contains("TrangThai"))
                {
                    DgvPhanCong.Columns["TrangThai"].HeaderText = "Trạng Thái";
                }

                if (DgvPhanCong.Columns.Contains("NgayGiao"))
                {
                    DgvPhanCong.Columns["NgayGiao"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }

                if (DgvPhanCong.Columns.Contains("HanHoanThanh"))
                {
                    DgvPhanCong.Columns["HanHoanThanh"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }

                if (DgvPhanCong.Columns.Contains("TenCongViec"))
                {
                    DgvPhanCong.Columns["TenCongViec"].AutoSizeMode =
                        DataGridViewAutoSizeColumnMode.Fill;
                }

                if (DgvPhanCong.Columns.Contains("HoTen"))
                {
                    DgvPhanCong.Columns["HoTen"].Width = 150;
                }

                if (DgvPhanCong.Columns.Contains("TrangThai"))
                {
                    DgvPhanCong.Columns["TrangThai"].Width = 120;
                }

                foreach (DataGridViewRow row in DgvPhanCong.Rows)
                {
                    string status = row.Cells["TrangThai"].Value?.ToString();

                    if (status == "Chưa hoàn thành")
                    {
                        row.DefaultCellStyle.BackColor =
                            Color.FromArgb(255, 248, 235);

                        row.DefaultCellStyle.ForeColor =
                            Color.FromArgb(140, 85, 10);
                    }
                    else if (status == "Hoàn thành")
                    {
                        row.DefaultCellStyle.BackColor =
                            Color.FromArgb(236, 250, 241);

                        row.DefaultCellStyle.ForeColor =
                            Color.FromArgb(22, 101, 52);
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor =
                            DgvPhanCong.DefaultCellStyle.BackColor;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi cấu hình cột DataGridView: " + ex.Message,
                    "Lỗi Cấu hình",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        // ============================================================
        // CLICK VÀO DÒNG
        // ============================================================
        private void DgvPhanCong_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (this.loggedInUserID == 0)
            {
                return;
            }

            if (e.RowIndex < 0 || e.RowIndex >= DgvPhanCong.Rows.Count)
            {
                if (BtnHoanThanh != null)
                {
                    BtnHoanThanh.Visible = false;
                }

                return;
            }

            try
            {
                DgvPhanCong.ClearSelection();
                DgvPhanCong.Rows[e.RowIndex].Selected = true;

                object statusValue =
                    DgvPhanCong.Rows[e.RowIndex]
                    .Cells["TrangThai"]
                    .Value;

                if (BtnHoanThanh != null)
                {
                    if (statusValue != null &&
                        statusValue.ToString() == "Chưa hoàn thành")
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
                if (BtnHoanThanh != null)
                {
                    BtnHoanThanh.Visible = false;
                }
            }
        }

        // ============================================================
        // NÚT HOÀN THÀNH
        // ============================================================
        private void BtnHoanThanh_Click(object sender, EventArgs e)
        {
            if (loggedInUserID <= 0)
            {
                MessageBox.Show(
                    "Chỉ nhân viên được giao mới có thể xác nhận hoàn thành.",
                    "Không có quyền",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            if (DgvPhanCong.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow =
                    DgvPhanCong.SelectedRows[0];

                if (selectedRow.Cells["CongViecID"].Value != null)
                {
                    int congViecID =
                        Convert.ToInt32(
                            selectedRow.Cells["CongViecID"].Value
                        );

                    string trangThaiHienTai =
                        selectedRow.Cells["TrangThai"].Value?.ToString();

                    if (trangThaiHienTai == "Hoàn thành")
                    {
                        MessageBox.Show(
                            "Công việc này đã được đánh dấu là Hoàn thành trước đó.",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

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
                    MessageBox.Show(
                        "Không tìm thấy ID công việc.",
                        "Lỗi Dữ liệu",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            else
            {
                MessageBox.Show(
                    "Vui lòng chọn một công việc cần hoàn thành.",
                    "Thiếu chọn dòng",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        // ============================================================
        // CẬP NHẬT TRẠNG THÁI
        // ============================================================

        private void UpdateTrangThaiCongViec(int congViecID)
        {
            if (loggedInUserID <= 0)
            {
                MessageBox.Show(
                    "Không xác định được nhân viên được giao.",
                    "Không có quyền",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            string sql = @"
        UPDATE CongViec
        SET TrangThai = N'Hoàn thành'
        WHERE CongViecID = @CongViecID
          AND NhanVienID = @NhanVienID
          AND TrangThai = N'Chưa hoàn thành'";

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(chuoiKN))
                using (SqlCommand cmd =
                    new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(
                        "@CongViecID",
                        SqlDbType.Int
                    ).Value = congViecID;

                    cmd.Parameters.Add(
                        "@NhanVienID",
                        SqlDbType.Int
                    ).Value = loggedInUserID;

                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        MessageBox.Show(
                            "Công việc đã hoàn thành hoặc không thuộc về bạn.",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        Load_Data();
                        BtnHoanThanh.Visible = false;
                        return;
                    }
                }

                MessageBox.Show(
                    "Đã cập nhật công việc thành Hoàn thành!",
                    "Thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Tải lại dữ liệu nhân viên
                Load_Data();

                // Ẩn nút sau khi hoàn thành
                BtnHoanThanh.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể cập nhật công việc: " + ex.Message,
                    "Lỗi SQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void LocDuLieu()
        {
            if (_duLieuPhanCong == null)
            {
                return;
            }

            try
            {
                DateTime ngayBatDau = DtpNgayTruoc.Value.Date;
                DateTime ngayKetThuc = DtpNgaySau.Value.Date;

                if (ngayBatDau > ngayKetThuc)
                {
                    MessageBox.Show(
                        "Ngày bắt đầu không được lớn hơn ngày kết thúc.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                string tuKhoa = TxtTimKiem.Text.Trim();

                // Escape dấu nháy đơn để tránh lỗi RowFilter
                tuKhoa = tuKhoa.Replace("'", "''");

                string dieuKienNgay =
                    $"NgayGiao >= #{ngayBatDau:MM/dd/yyyy}# " +
                    $"AND NgayGiao < #{ngayKetThuc.AddDays(1):MM/dd/yyyy}#";

                string dieuKien = dieuKienNgay;

                if (!string.IsNullOrWhiteSpace(tuKhoa))
                {
                    dieuKien +=
                        " AND (" +
                        $"Convert(MaNhanVien, 'System.String') LIKE '%{tuKhoa}%' OR " +
                        $"Convert(HoTen, 'System.String') LIKE '%{tuKhoa}%' OR " +
                        $"Convert(TenCongViec, 'System.String') LIKE '%{tuKhoa}%' OR " +
                        $"Convert(TrangThai, 'System.String') LIKE '%{tuKhoa}%'" +
                        ")";
                }

                _duLieuPhanCong.DefaultView.RowFilter = dieuKien;

                DgvPhanCong.DataSource =
                    _duLieuPhanCong.DefaultView;

                SetupDataGridViewColumns();

                DgvPhanCong.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi lọc dữ liệu: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ============================================================
        // CÁC SỰ KIỆN KHÁC
        // ============================================================
        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            LocDuLieu();
        }

        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (_duLieuPhanCong == null)
            {
                return;
            }

            LocDuLieu();
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                // Reset ô tìm kiếm
                TxtTimKiem.Clear();

                // Reset khoảng thời gian
                DtpNgayTruoc.Value =
                    DateTime.Now.AddMonths(-1);

                DtpNgaySau.Value =
                    DateTime.Now;

                // Xóa filter hiện tại nếu có
                if (_duLieuPhanCong != null)
                {
                    _duLieuPhanCong.DefaultView.RowFilter =
                        string.Empty;
                }

                // Load lại dữ liệu mới nhất từ database
                Load_Data();

                if (DgvPhanCong != null)
                {
                    DgvPhanCong.ClearSelection();
                }

                TxtTimKiem.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi làm mới dữ liệu: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void BtnXuatExcel_Click(object sender, EventArgs e)
        {
            if (DgvPhanCong == null || DgvPhanCong.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Không có dữ liệu để xuất Excel.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }

            try
            {
                using SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Filter =
                    "Excel Workbook (*.xlsx)|*.xlsx";

                saveFileDialog.Title =
                    "Lưu báo cáo phân công";

                saveFileDialog.FileName =
                    $"BaoCaoPhanCong_{DateTime.Now:ddMMyyyy_HHmmss}.xlsx";

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                using XLWorkbook workbook = new XLWorkbook();

                var worksheet =
                    workbook.Worksheets.Add("Báo cáo phân công");


                // =====================================================
                // ĐẾM CỘT HIỂN THỊ
                // =====================================================

                int soCot = 0;

                foreach (DataGridViewColumn column in DgvPhanCong.Columns)
                {
                    if (column.Visible)
                    {
                        soCot++;
                    }
                }

                if (soCot == 0)
                {
                    MessageBox.Show(
                        "Không có cột dữ liệu để xuất.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }


                // =====================================================
                // TIÊU ĐỀ
                // =====================================================

                worksheet.Cell(1, 1).Value =
                    "BÁO CÁO PHÂN CÔNG CÔNG VIỆC";

                worksheet.Range(
                    1,
                    1,
                    1,
                    soCot
                ).Merge();

                worksheet.Cell(1, 1).Style.Font.Bold =
                    true;

                worksheet.Cell(1, 1).Style.Font.FontSize =
                    16;

                worksheet.Cell(1, 1).Style.Alignment.Horizontal =
                    XLAlignmentHorizontalValues.Center;


                // =====================================================
                // THỜI GIAN
                // =====================================================

                worksheet.Cell(2, 1).Value =
                    $"Từ ngày: {DtpNgayTruoc.Value:dd/MM/yyyy} " +
                    $"đến ngày: {DtpNgaySau.Value:dd/MM/yyyy}";

                worksheet.Range(
                    2,
                    1,
                    2,
                    soCot
                ).Merge();

                worksheet.Cell(2, 1).Style.Alignment.Horizontal =
                    XLAlignmentHorizontalValues.Center;


                // =====================================================
                // HEADER
                // =====================================================

                int excelColumn = 1;

                foreach (DataGridViewColumn column in DgvPhanCong.Columns)
                {
                    if (!column.Visible)
                    {
                        continue;
                    }

                    var cell =
                        worksheet.Cell(4, excelColumn);

                    cell.Value =
                        column.HeaderText;

                    cell.Style.Font.Bold =
                        true;

                    cell.Style.Alignment.Horizontal =
                        XLAlignmentHorizontalValues.Center;

                    cell.Style.Alignment.Vertical =
                        XLAlignmentVerticalValues.Center;

                    excelColumn++;
                }


                // =====================================================
                // DỮ LIỆU
                // =====================================================

                int excelRow = 5;

                foreach (DataGridViewRow row in DgvPhanCong.Rows)
                {
                    if (row.IsNewRow)
                    {
                        continue;
                    }

                    excelColumn = 1;

                    foreach (DataGridViewColumn column in DgvPhanCong.Columns)
                    {
                        if (!column.Visible)
                        {
                            continue;
                        }

                        object value =
                            row.Cells[column.Index].Value;

                        var cell =
                            worksheet.Cell(excelRow, excelColumn);

                        if (
                            value != null &&
                            value != DBNull.Value &&
                            (
                                column.Name == "NgayGiao" ||
                                column.Name == "HanHoanThanh"
                            )
                        )
                        {
                            if (DateTime.TryParse(
                                value.ToString(),
                                out DateTime ngay
                            ))
                            {
                                cell.Value =
                                    ngay;

                                cell.Style.DateFormat.Format =
                                    "dd/MM/yyyy";
                            }
                            else
                            {
                                cell.Value =
                                    value.ToString();
                            }
                        }
                        else
                        {
                            cell.Value =
                                value?.ToString() ?? "";
                        }

                        excelColumn++;
                    }

                    excelRow++;
                }


                // =====================================================
                // VIỀN BẢNG
                // =====================================================

                if (excelRow > 5)
                {
                    var tableRange =
                        worksheet.Range(
                            4,
                            1,
                            excelRow - 1,
                            soCot
                        );

                    tableRange.Style.Border.OutsideBorder =
                        XLBorderStyleValues.Thin;

                    tableRange.Style.Border.InsideBorder =
                        XLBorderStyleValues.Thin;
                }


                // =====================================================
                // FORMAT HEADER
                // =====================================================

                var headerRange =
                    worksheet.Range(
                        4,
                        1,
                        4,
                        soCot
                    );

                headerRange.Style.Fill.BackgroundColor =
                    XLColor.FromArgb(44, 62, 80);

                headerRange.Style.Font.FontColor =
                    XLColor.White;

                headerRange.Style.Font.Bold =
                    true;


                // =====================================================
                // AUTO WIDTH
                // =====================================================

                worksheet.Columns().AdjustToContents();

                foreach (var column in worksheet.ColumnsUsed())
                {
                    if (column.Width > 40)
                    {
                        column.Width = 40;
                    }
                }

                worksheet.Rows().AdjustToContents();


                // =====================================================
                // FREEZE HEADER
                // =====================================================

                worksheet.SheetView.FreezeRows(4);


                // =====================================================
                // SAVE FILE
                // =====================================================

                workbook.SaveAs(
                    saveFileDialog.FileName
                );

                MessageBox.Show(
                    "Xuất Excel thành công!",
                    "Thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi xuất Excel:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}