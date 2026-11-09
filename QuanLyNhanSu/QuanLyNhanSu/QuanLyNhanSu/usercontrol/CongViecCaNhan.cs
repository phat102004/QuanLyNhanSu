
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhanSu.usercontrol
{
    public partial class CongViecCaNhan : UserControl
    {
        private readonly int loggedInUserID;
        private int? selectedCongViecID;

        private readonly string chuoiKN =
            @"Data Source=LAPTOP-MK554FA4;" +
            @"Initial Catalog=QuanLyNhanVien;" +
            @"Integrated Security=True;" +
            @"Trust Server Certificate=True";

        // Constructor mặc định dành cho Designer
        public CongViecCaNhan()
        {
            InitializeComponent();

            DgvCongViec.CellClick += DgvCongViec_CellClick;
            BtnHoanThanh.Click += BtnHoanThanh_Click;
            BtnLamMoi.Click += BtnLamMoi_Click;
        }

        // Constructor nhận ID nhân viên đăng nhập
        public CongViecCaNhan(int nhanVienID) : this()
        {
            loggedInUserID = nhanVienID;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            if (loggedInUserID <= 0)
            {
                MessageBox.Show(
                    "Không xác định được nhân viên đăng nhập.",
                    "Lỗi phiên đăng nhập",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            LoadCongViec();
        }

        // ==========================================
        // TẢI DANH SÁCH CÔNG VIỆC CÁ NHÂN
        // ==========================================
        private void LoadCongViec()
        {
            selectedCongViecID = null;
            BtnHoanThanh.Visible = false;

            LblHuongDan.Text =
                "Chọn công việc chưa hoàn thành để xác nhận.";

            const string sql = @"
                SELECT
                    cv.CongViecID,
                    nv.MaNhanVien,
                    nv.HoTen,
                    cv.TenCongViec,
                    cv.NgayGiao,
                    cv.HanHoanThanh,
                    cv.TrangThai,
                    cv.NhanVienID
                FROM CongViec AS cv
                INNER JOIN NhanVien AS nv
                    ON nv.NhanVienID = cv.NhanVienID
                WHERE cv.NhanVienID = @NhanVienID
                ORDER BY
                    CASE
                        WHEN cv.TrangThai = N'Chưa hoàn thành'
                        THEN 0 ELSE 1
                    END,
                    cv.HanHoanThanh ASC,
                    cv.NgayGiao DESC";

            try
            {
                using var conn =
                    new SqlConnection(chuoiKN);

                using var cmd =
                    new SqlCommand(sql, conn);

                cmd.Parameters.Add(
                    "@NhanVienID",
                    SqlDbType.Int
                ).Value = loggedInUserID;

                using var adapter =
                    new SqlDataAdapter(cmd);

                DataTable table = new DataTable();

                adapter.Fill(table);

                DgvCongViec.DataSource = table;

                FormatGrid();
                UpdateStats(table);

                DgvCongViec.ClearSelection();

                if (table.Rows.Count == 0)
                {
                    LblHuongDan.Text =
                        "Bạn chưa có công việc được giao.";
                }
            }
            catch (Exception ex)
            {
                DgvCongViec.DataSource = null;

                LblTongCongViec.Text = "—";
                LblChuaHoanThanh.Text = "—";
                LblDaHoanThanh.Text = "—";

                LblHuongDan.Text =
                    "Không tải được danh sách công việc.";

                MessageBox.Show(
                    "Lỗi tải công việc: " + ex.Message,
                    "Lỗi SQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ==========================================
        // CẬP NHẬT BA THẺ THỐNG KÊ
        // ==========================================
        private void UpdateStats(DataTable table)
        {
            int chuaHoanThanh = 0;
            int daHoanThanh = 0;

            foreach (DataRow row in table.Rows)
            {
                string status =
                    Convert.ToString(
                        row["TrangThai"]
                    )?.Trim() ?? "";

                if (status == "Chưa hoàn thành")
                {
                    chuaHoanThanh++;
                }
                else if (status == "Hoàn thành")
                {
                    daHoanThanh++;
                }
            }

            LblTongCongViec.Text =
                table.Rows.Count.ToString();

            LblChuaHoanThanh.Text =
                chuaHoanThanh.ToString();

            LblDaHoanThanh.Text =
                daHoanThanh.ToString();
        }

        // ==========================================
        // CẤU HÌNH DATAGRIDVIEW
        // ==========================================
        private void FormatGrid()
        {
            DgvCongViec.ReadOnly = true;
            DgvCongViec.AllowUserToAddRows = false;
            DgvCongViec.AllowUserToDeleteRows = false;
            DgvCongViec.MultiSelect = false;

            DgvCongViec.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            // Ẩn các cột không cần hiển thị
            foreach (string column in new[]
            {
                "CongViecID",
                "NhanVienID",
                "MaNhanVien",
                "HoTen"
            })
            {
                if (DgvCongViec.Columns.Contains(column))
                {
                    DgvCongViec.Columns[column].Visible =
                        false;
                }
            }

            SetHeader("TenCongViec", "Công việc");
            SetHeader("NgayGiao", "Ngày giao");
            SetHeader("HanHoanThanh", "Hạn hoàn thành");
            SetHeader("TrangThai", "Trạng thái");

            if (DgvCongViec.Columns.Contains("NgayGiao"))
            {
                DgvCongViec.Columns["NgayGiao"]
                    .DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (DgvCongViec.Columns.Contains("HanHoanThanh"))
            {
                DgvCongViec.Columns["HanHoanThanh"]
                    .DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (DgvCongViec.Columns.Contains("TenCongViec"))
            {
                DgvCongViec.Columns["TenCongViec"]
                    .FillWeight = 220;
            }

            // Màu dòng theo trạng thái
            foreach (DataGridViewRow row in DgvCongViec.Rows)
            {
                string status =
                    Convert.ToString(
                        row.Cells["TrangThai"].Value
                    )?.Trim() ?? "";

                if (status == "Hoàn thành")
                {
                    row.DefaultCellStyle.BackColor =
                        Color.FromArgb(236, 250, 241);
                }
                else if (status == "Chưa hoàn thành")
                {
                    row.DefaultCellStyle.BackColor =
                        Color.FromArgb(255, 248, 235);
                }
                else
                {
                    row.DefaultCellStyle.BackColor =
                        Color.White;
                }
            }
        }

        private void SetHeader(string name, string text)
        {
            if (DgvCongViec.Columns.Contains(name))
            {
                DgvCongViec.Columns[name].HeaderText =
                    text;
            }
        }

        // ==========================================
        // CLICK CHỌN CÔNG VIỆC
        // ==========================================
        private void DgvCongViec_CellClick(
            object? sender,
            DataGridViewCellEventArgs e)
        {
            selectedCongViecID = null;
            BtnHoanThanh.Visible = false;

            if (e.RowIndex < 0 ||
                e.RowIndex >= DgvCongViec.Rows.Count)
            {
                return;
            }

            DataGridViewRow row =
                DgvCongViec.Rows[e.RowIndex];

            if (!int.TryParse(
                Convert.ToString(
                    row.Cells["CongViecID"].Value
                ),
                out int id))
            {
                return;
            }

            string status =
                Convert.ToString(
                    row.Cells["TrangThai"].Value
                )?.Trim() ?? "";

            if (status == "Chưa hoàn thành")
            {
                selectedCongViecID = id;

                BtnHoanThanh.Visible = true;

                LblHuongDan.Text =
                    "Đã làm xong? Nhấn Hoàn thành để xác nhận.";
            }
            else if (status == "Hoàn thành")
            {
                LblHuongDan.Text =
                    "Công việc này đã hoàn thành.";
            }
            else
            {
                LblHuongDan.Text =
                    "Không thể xác nhận ở trạng thái hiện tại.";
            }
        }

        // ==========================================
        // CLICK NÚT HOÀN THÀNH
        // ==========================================
        private void BtnHoanThanh_Click(
            object? sender,
            EventArgs e)
        {
            if (loggedInUserID <= 0 ||
                selectedCongViecID is null)
            {
                return;
            }

            DialogResult result = MessageBox.Show(
                "Xác nhận bạn đã hoàn thành công việc này?",
                "Xác nhận hoàn thành",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            const string sql = @"
                UPDATE CongViec
                SET TrangThai = N'Hoàn thành'
                WHERE CongViecID = @CongViecID
                  AND NhanVienID = @NhanVienID
                  AND TrangThai = N'Chưa hoàn thành'";

            try
            {
                using var conn =
                    new SqlConnection(chuoiKN);

                using var cmd =
                    new SqlCommand(sql, conn);

                cmd.Parameters.Add(
                    "@CongViecID",
                    SqlDbType.Int
                ).Value = selectedCongViecID.Value;

                cmd.Parameters.Add(
                    "@NhanVienID",
                    SqlDbType.Int
                ).Value = loggedInUserID;

                conn.Open();

                int changed = cmd.ExecuteNonQuery();

                if (changed == 1)
                {
                    MessageBox.Show(
                        "Đã ghi nhận hoàn thành công việc.",
                        "Thành công",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Công việc đã được cập nhật hoặc không còn thuộc về bạn.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }

                LoadCongViec();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể cập nhật trạng thái: " +
                    ex.Message,
                    "Lỗi SQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ==========================================
        // LÀM MỚI DANH SÁCH
        // ==========================================
        private void BtnLamMoi_Click(
            object? sender,
            EventArgs e)
        {
            LoadCongViec();
        }
    }
}
