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
using ClosedXML.Excel;

namespace QuanLyNhanSu.usercontrol
{
    public partial class BaoCaoPhanTich : UserControl
    {
        SqlCommand boLenh;
        SqlDataAdapter docGhi;
        SqlConnection ketNoi;
        DataSet duLieu;

        string chuoiKN = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhanVien;Integrated Security=True;Trust Server Certificate=True";

        public BaoCaoPhanTich()
        {
            InitializeComponent();
        }

        private void BaoCaoPhanTich_Load(object sender, EventArgs e)
        {
            ketNoi = new SqlConnection(chuoiKN);
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fromDate = new DateTime(
                    DtpNgayTruoc.Value.Year,
                    DtpNgayTruoc.Value.Month,
                    1
                );

                DateTime toDate = new DateTime(
                    DtpNgaySau.Value.Year,
                    DtpNgaySau.Value.Month,
                    DateTime.DaysInMonth(
                        DtpNgaySau.Value.Year,
                        DtpNgaySau.Value.Month
                    )
                );

                string sql = @"
                    SELECT 
                        FORMAT(NgayLap, 'MM/yyyy') AS ThangNam, 
                        SUM(TongLuong) AS TongChiLuong
                    FROM Luong
                    WHERE NgayLap BETWEEN @FromDate AND @ToDate
                    GROUP BY FORMAT(NgayLap, 'MM/yyyy')
                    ORDER BY MIN(NgayLap)";

                if (ketNoi.State != ConnectionState.Open)
                {
                    ketNoi.Open();
                }

                boLenh = new SqlCommand(sql, ketNoi);

                boLenh.Parameters.AddWithValue("@FromDate", fromDate);
                boLenh.Parameters.AddWithValue("@ToDate", toDate);

                docGhi = new SqlDataAdapter(boLenh);

                duLieu = new DataSet();
                docGhi.Fill(duLieu);

                DgvBaoCao.DataSource = duLieu.Tables[0];

                if (DgvBaoCao.Columns.Contains("TongChiLuong"))
                {
                    DgvBaoCao.Columns["TongChiLuong"]
                        .DefaultCellStyle.Format = "N0";

                    DgvBaoCao.Columns["TongChiLuong"]
                        .DefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleRight;
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
                    "Lỗi khi lọc dữ liệu: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            DtpNgayTruoc.Value = DateTime.Now;
            DtpNgaySau.Value = DateTime.Now;

            BtnTimKiem_Click(sender, e);
        }

        private void BtnXuatExcel_Click(object sender, EventArgs e)
        {
            if (DgvBaoCao == null || DgvBaoCao.Rows.Count == 0)
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
                    "Lưu báo cáo phân tích";

                saveFileDialog.FileName =
                    $"BaoCaoPhanTich_{DateTime.Now:ddMMyyyy_HHmmss}.xlsx";

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                using XLWorkbook workbook = new XLWorkbook();

                var worksheet =
                    workbook.Worksheets.Add("Báo cáo phân tích");


                // =====================================================
                // ĐẾM CỘT HIỂN THỊ
                // =====================================================

                int soCot = 0;

                foreach (DataGridViewColumn column in DgvBaoCao.Columns)
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
                    "BÁO CÁO PHÂN TÍCH CHI LƯƠNG";

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

                foreach (DataGridViewColumn column in DgvBaoCao.Columns)
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

                foreach (DataGridViewRow row in DgvBaoCao.Rows)
                {
                    if (row.IsNewRow)
                    {
                        continue;
                    }

                    excelColumn = 1;

                    foreach (DataGridViewColumn column in DgvBaoCao.Columns)
                    {
                        if (!column.Visible)
                        {
                            continue;
                        }

                        object value =
                            row.Cells[column.Index].Value;

                        var cell =
                            worksheet.Cell(excelRow, excelColumn);

                        // Cột tổng chi lương
                        if (
                            value != null &&
                            value != DBNull.Value &&
                            column.Name == "TongChiLuong"
                        )
                        {
                            if (decimal.TryParse(
                                value.ToString(),
                                out decimal tongLuong
                            ))
                            {
                                cell.Value = tongLuong;

                                cell.Style.NumberFormat.Format =
                                    "#,##0";
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

                headerRange.Style.Alignment.Horizontal =
                    XLAlignmentHorizontalValues.Center;

                headerRange.Style.Alignment.Vertical =
                    XLAlignmentVerticalValues.Center;


                // =====================================================
                // AUTO WIDTH
                // =====================================================

                worksheet.Columns().AdjustToContents();

                foreach (var column in worksheet.ColumnsUsed())
                {
                    // Độ rộng tối thiểu
                    if (column.Width < 20)
                    {
                        column.Width = 20;
                    }

                    // Độ rộng tối đa
                    if (column.Width > 45)
                    {
                        column.Width = 45;
                    }
                }

                for (int i = 1; i <= soCot; i++)
                {
                    string tenCot =
                        worksheet.Cell(4, i).Value.ToString();

                    if (tenCot == "Tháng/Năm")
                    {
                        worksheet.Column(i).Width = 20;
                    }
                    else if (tenCot == "Tổng chi lương")
                    {
                        worksheet.Column(i).Width = 28;
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