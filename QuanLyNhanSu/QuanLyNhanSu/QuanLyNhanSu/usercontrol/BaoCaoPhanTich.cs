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
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyNhanSu.usercontrol
{
    public partial class BaoCaoPhanTich : UserControl
    {
        SqlCommand boLenh;
        SqlDataAdapter docGhi;
        SqlConnection ketNoi;
        DataSet duLieu;
        public BaoCaoPhanTich()
        {
            InitializeComponent();
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhanVienMain;Integrated Security=True;Trust Server Certificate=True"))
                {
                    conn.Open();

                    // Lấy tháng/năm từ Dtp
                    DateTime fromDate = new DateTime(DtpNgayTruoc.Value.Year, DtpNgayTruoc.Value.Month, 1);
                    DateTime toDate = new DateTime(DtpNgaySau.Value.Year, DtpNgaySau.Value.Month, DateTime.DaysInMonth(DtpNgaySau.Value.Year, DtpNgaySau.Value.Month));

                    string sql = @"SELECT 
                                FORMAT(NgayLap, 'MM/yyyy') AS ThangNam, 
                                SUM(TongLuong) AS TongChiLuong
                           FROM Luong
                           WHERE NgayLap BETWEEN @FromDate AND @ToDate
                           GROUP BY FORMAT(NgayLap, 'MM/yyyy')
                           ORDER BY MIN(NgayLap)";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@FromDate", fromDate);
                    cmd.Parameters.AddWithValue("@ToDate", toDate);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DgvBaoCao.DataSource = dt;

                    // Định dạng cột tiền đẹp hơn
                    if (DgvBaoCao.Columns.Contains("TongChiLuong"))
                    {
                        DgvBaoCao.Columns["TongChiLuong"].DefaultCellStyle.Format = "N0";
                        DgvBaoCao.Columns["TongChiLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lọc dữ liệu: " + ex.Message);
            }
        }

        private void BaoCaoPhanTich_Load(object sender, EventArgs e)
        {
            string chuoiKN = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhanVienMain;Integrated Security=True;Trust Server Certificate=True";
            ketNoi = new SqlConnection(chuoiKN);
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            DtpNgayTruoc.Value = DateTime.Now;
            DtpNgaySau.Value = DateTime.Now;
            BtnTimKiem_Click(sender, e);
        }

        private void BtnXuatExcel_Click(object sender, EventArgs e)
        {

        }
    }
}
