
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhanSu.usercontrol
{
    public partial class LuongCaNhan : UserControl
    {
        private readonly int nhanVienID;

        private readonly string chuoiKN =
            @"Data Source=LAPTOP-MK554FA4;" +
            @"Initial Catalog=QuanLyNhanVien;" +
            @"Integrated Security=True;" +
            @"Trust Server Certificate=True";

        // Dành cho Visual Studio Designer
        public LuongCaNhan()
        {
            InitializeComponent();
        }

        // Nhận ID từ Form đăng nhập
        public LuongCaNhan(int id) : this()
        {
            nhanVienID = id;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            DgvLichSuLuong.ReadOnly = true;
            DgvLichSuLuong.AllowUserToAddRows = false;
            DgvLichSuLuong.AllowUserToDeleteRows = false;
            DgvLichSuLuong.AutoGenerateColumns = true;
            DgvLichSuLuong.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            if (nhanVienID <= 0)
            {
                MessageBox.Show(
                    "Không xác định được nhân viên đăng nhập."
                );
                return;
            }

            LoadLuongCaNhan();
        }

        private void LoadLuongCaNhan()
        {
            string sql = @"
                SELECT
                    l.MaLuongTong,
                    nv.HoTen,
                    l.SoNgayCong,
                    l.TongPhuCap,
                    l.TongLuong,
                    l.NgayTinhLuong,
                    l.NgayLap
                FROM Luong l
                INNER JOIN NhanVien nv
                    ON nv.NhanVienID = l.NhanVienID
                WHERE l.NhanVienID = @NhanVienID
                ORDER BY l.NgayTinhLuong DESC,
                         l.NgayLap DESC";

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(chuoiKN))
                using (SqlCommand cmd =
                    new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(
                        "@NhanVienID",
                        SqlDbType.Int
                    ).Value = nhanVienID;

                    using (SqlDataAdapter adapter =
                        new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        DgvLichSuLuong.DataSource = table;

                        if (table.Rows.Count == 0)
                        {
                            ShowEmptyState();
                            return;
                        }

                        // Kỳ lương mới nhất
                        DataRow row = table.Rows[0];

                        decimal tongLuong =
                            GetDecimal(row, "TongLuong");

                        decimal phuCap =
                            GetDecimal(row, "TongPhuCap");

                        string ngayCong =
                            Convert.ToString(
                                row["SoNgayCong"]
                            ) ?? "0";

                        LblTongLuong.Text =
                            tongLuong.ToString("N0") + " VNĐ";

                        LblPhuCap.Text =
                            phuCap.ToString("N0") + " VNĐ";

                        LblNgayCong.Text =
                            ngayCong + " ngày";

                        if (row["NgayTinhLuong"] != DBNull.Value)
                        {
                            DateTime ngayLuong =
                                Convert.ToDateTime(
                                    row["NgayTinhLuong"]
                                );

                            LblKyLuong.Text =
                                "Kỳ lương: " +
                                ngayLuong.ToString("MM/yyyy");
                        }
                        else
                        {
                            LblKyLuong.Text =
                                "Chưa có kỳ lương";
                        }

                        FormatGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải bảng lương: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private decimal GetDecimal(
            DataRow row,
            string column)
        {
            if (row.IsNull(column))
                return 0;

            return Convert.ToDecimal(row[column]);
        }

        private void ShowEmptyState()
        {
            LblTongLuong.Text = "Chưa có dữ liệu";
            LblNgayCong.Text = "—";
            LblPhuCap.Text = "—";
            LblKyLuong.Text = "Chưa có kỳ lương";
        }

        private void FormatGrid()
        {
            DgvLichSuLuong.ReadOnly = true;
            DgvLichSuLuong.RowHeadersVisible = false;
            DgvLichSuLuong.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            if (DgvLichSuLuong.Columns.Contains("TongLuong"))
            {
                DgvLichSuLuong.Columns["TongLuong"]
                    .DefaultCellStyle.Format = "N0";
            }

            if (DgvLichSuLuong.Columns.Contains("TongPhuCap"))
            {
                DgvLichSuLuong.Columns["TongPhuCap"]
                    .DefaultCellStyle.Format = "N0";
            }

            if (DgvLichSuLuong.Columns.Contains("NgayTinhLuong"))
            {
                DgvLichSuLuong.Columns["NgayTinhLuong"]
                    .DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }
    }
}
