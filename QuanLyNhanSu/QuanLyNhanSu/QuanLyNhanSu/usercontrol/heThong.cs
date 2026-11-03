using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhanSu.usercontrol
{
    public partial class HeThong : UserControl
    {
        // =========================================================
        // CONNECTION STRING
        // =========================================================

        private readonly string chuoiKN =
            @"Data Source=LAPTOP-MK554FA4;" +
            @"Initial Catalog=QuanLyNhanVien;" +
            @"Integrated Security=True;" +
            @"Trust Server Certificate=True";


        // =========================================================
        // THÔNG TIN NGƯỜI ĐĂNG NHẬP
        // =========================================================

        private int userID = 0;

        private string userName = "";

        private string userQuyen = "";


        // =========================================================
        // CONSTRUCTOR CHO DESIGNER
        // =========================================================

        public HeThong()
        {
            InitializeComponent();
        }


        // =========================================================
        // CONSTRUCTOR CHÍNH
        // =========================================================

        public HeThong(
            int userID,
            string userName,
            string userQuyen)
        {
            InitializeComponent();

            this.userID =
                userID;

            this.userName =
                userName;

            this.userQuyen =
                userQuyen;
        }


        // =========================================================
        // LOAD
        // =========================================================

        private void HeThong_Load(object sender, EventArgs e)
        {
            HienThiThongTinAdmin();
            HienThiThongTinDatabase();
            LoadThongKe();
        }


        // =========================================================
        // THÔNG TIN ADMIN
        // =========================================================

        private string LayMaNhanVien(int nhanVienID)
        {
            if (nhanVienID <= 0)
            {
                return "Không có";
            }

            string sql = @"
        SELECT MaNhanVien
        FROM NhanVien
        WHERE NhanVienID = @NhanVienID
    ";

            try
            {
                using SqlConnection ketNoi =
                    new SqlConnection(chuoiKN);

                using SqlCommand cmd =
                    new SqlCommand(sql, ketNoi);

                cmd.Parameters.AddWithValue(
                    "@NhanVienID",
                    nhanVienID
                );

                ketNoi.Open();

                object result =
                    cmd.ExecuteScalar();

                if (result == null ||
                    result == DBNull.Value)
                {
                    return "Không tìm thấy";
                }

                return result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi lấy mã nhân viên: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return "Lỗi";
            }
        }

        private void HienThiThongTinAdmin()
        {
            lblTenAdmin.Text =
                string.IsNullOrWhiteSpace(userName)
                    ? "Không xác định"
                    : userName;

            lblQuyen.Text =
                string.IsNullOrWhiteSpace(userQuyen)
                    ? "Không xác định"
                    : userQuyen;

            lblUserID.Text =
                LayMaNhanVien(userID);
        }


        // =========================================================
        // THÔNG TIN DATABASE
        // =========================================================

        private void HienThiThongTinDatabase()
        {
            SqlConnectionStringBuilder builder =
                new SqlConnectionStringBuilder(chuoiKN);

            lblServer.Text =
                builder.DataSource;

            lblDatabaseName.Text =
                builder.InitialCatalog;
        }


        // =========================================================
        // LOAD THỐNG KÊ
        // =========================================================

        private void LoadThongKe()
        {
            try
            {
                using SqlConnection ketNoi =
                    new SqlConnection(chuoiKN);

                ketNoi.Open();


                // =================================================
                // NHÂN VIÊN
                // =================================================

                lblSoNhanVien.Text =
                    LaySoLuong(
                        ketNoi,
                        "NhanVien"
                    ).ToString();


                // =================================================
                // PHÒNG BAN
                // =================================================

                lblSoPhongBan.Text =
                    LaySoLuong(
                        ketNoi,
                        "PhongBan"
                    ).ToString();


                // =================================================
                // CÔNG VIỆC
                // =================================================

                lblSoCongViec.Text =
                    LaySoLuong(
                        ketNoi,
                        "CongViec"
                    ).ToString();


                // =================================================
                // DATABASE STATUS
                // =================================================

                HienThiKetNoiThanhCong();
            }
            catch (Exception ex)
            {
                HienThiKetNoiThatBai();

                MessageBox.Show(
                    "Không thể tải thông tin hệ thống.\n\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // LẤY COUNT THEO TABLE
        // =========================================================

        private int LaySoLuong(
            SqlConnection ketNoi,
            string tenBang)
        {
            /*
             * Không cho truyền tùy ý tên bảng.
             * Chỉ cho đúng các bảng hệ thống đang sử dụng.
             */

            if (
                tenBang != "NhanVien" &&
                tenBang != "PhongBan" &&
                tenBang != "CongViec"
            )
            {
                return 0;
            }


            string sql =
                $"SELECT COUNT(*) FROM {tenBang}";


            using SqlCommand cmd =
                new SqlCommand(
                    sql,
                    ketNoi
                );


            object result =
                cmd.ExecuteScalar();


            if (
                result == null ||
                result == DBNull.Value
            )
            {
                return 0;
            }


            return Convert.ToInt32(
                result
            );
        }


        // =========================================================
        // KIỂM TRA KẾT NỐI
        // =========================================================

        private void BtnKiemTraKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection ketNoi =
                    new SqlConnection(chuoiKN);

                ketNoi.Open();

                string sql =
                    "SELECT COUNT(*) FROM NhanVien";

                using SqlCommand cmd =
                    new SqlCommand(sql, ketNoi);

                int soNhanVien =
                    Convert.ToInt32(cmd.ExecuteScalar());

                HienThiKetNoiThanhCong();

                MessageBox.Show(
                    $"Kết nối Database thành công!\n\n" +
                    $"Database: {ketNoi.Database}\n" +
                    $"Server: {ketNoi.DataSource}\n" +
                    $"Số nhân viên: {soNhanVien}",
                    "Kiểm tra Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                HienThiKetNoiThatBai();

                MessageBox.Show(
                    "Kết nối Database thất bại!\n\n" +
                    ex.Message,
                    "Lỗi Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // LÀM MỚI
        // =========================================================

        private void BtnLamMoi_Click(
            object sender,
            EventArgs e)
        {
            HienThiThongTinAdmin();

            HienThiThongTinDatabase();

            LoadThongKe();
        }


        // =========================================================
        // HIỂN THỊ KẾT NỐI THÀNH CÔNG
        // =========================================================

        private void HienThiKetNoiThanhCong()
        {
            lblTrangThaiDatabase.Text =
                "Đã kết nối";

            lblTrangThaiDatabase.ForeColor =
                Color.FromArgb(
                    22,
                    163,
                    74
                );


            lblConnection.Text =
                "Hoạt động bình thường";

            lblConnection.ForeColor =
                Color.FromArgb(
                    22,
                    163,
                    74
                );


            lblLastCheck.Text =
                DateTime.Now.ToString(
                    "dd/MM/yyyy HH:mm:ss"
                );
        }


        // =========================================================
        // HIỂN THỊ KẾT NỐI THẤT BẠI
        // =========================================================

        private void HienThiKetNoiThatBai()
        {
            lblTrangThaiDatabase.Text =
                "Mất kết nối";

            lblTrangThaiDatabase.ForeColor =
                Color.FromArgb(
                    220,
                    38,
                    38
                );


            lblConnection.Text =
                "Không thể kết nối";

            lblConnection.ForeColor =
                Color.FromArgb(
                    220,
                    38,
                    38
                );


            lblLastCheck.Text =
                DateTime.Now.ToString(
                    "dd/MM/yyyy HH:mm:ss"
                );
        }
    }
}