using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace QuanLyNhanSu
{
    public partial class FormDangNhap : Form
    {
        // Khai báo các biến kết nối CSDL
        SqlConnection ketNoi;
        SqlDataAdapter docGhi;
        DataSet duLieu;
        SqlCommand boLenh;

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            string user = TxtUsername.Text.Trim();
            string pass = TxtPassword.Text.Trim();

            if (user == "" || pass == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (ketNoi == null)
            {
                MessageBox.Show("Lỗi kết nối database. Vui lòng kiểm tra lại FormDangNhap_Load.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (ketNoi.State != ConnectionState.Open)
                    ketNoi.Open();

                string sql = @"
                    SELECT tk.TenDangNhap, tk.MatKhau, tk.NhanVienID, q.TenQuyen, nv.HoTen
                    FROM TaiKhoan tk
                    JOIN Quyen q ON tk.QuyenID = q.QuyenID
                    JOIN NhanVien nv ON nv.NhanVienID = tk.NhanVienID
                    WHERE tk.TenDangNhap = @u AND tk.MatKhau = @p";

                using (SqlCommand cmd = new SqlCommand(sql, ketNoi))
                {
                    cmd.Parameters.AddWithValue("@u", user);
                    cmd.Parameters.AddWithValue("@p", pass);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string quyen = reader["TenQuyen"].ToString();
                            int idNV = reader["NhanVienID"] != DBNull.Value ? Convert.ToInt32(reader["NhanVienID"]) : 0;
                            string hoten = reader["HoTen"].ToString();

                            MessageBox.Show("Đăng nhập thành công!");

                            // Mở form theo quyền và ẩn form hiện tại
                            MoFormTheoQuyen(quyen, idNV, hoten);
                        }
                        else
                        {
                            MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi kiểm tra đăng nhập: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == ConnectionState.Open)
                    ketNoi.Close();
            }
        }

        // --- BỔ SUNG: PHƯƠNG THỨC XỬ LÝ NÚT THOÁT (BtnThoat_Click) ---
        private void BtnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi hệ thống?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // --- BỔ SUNG: PHƯƠNG THỨC XỬ LÝ NHẤN PHÍM ENTER (TxtPassword_KeyDown) ---
        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Gọi sự kiện Click của nút Đăng nhập
                BtnDangNhap.PerformClick();
                e.SuppressKeyPress = true; // Ngăn không cho tiếng bip khi nhấn Enter
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            // Thay đổi chuỗi kết nối của bạn nếu cần
            string chuoiKN = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhanVien;Integrated Security=True;Trust Server Certificate=True";
            ketNoi = new SqlConnection(chuoiKN);
            TxtUsername.Focus(); // Thiết lập focus vào ô Username khi Form được tải
        }

        private void MoFormTheoQuyen(string quyen, int nhanVienID, string tenNV)
        {
            Form formChinh = null;

            // Gọi các Form riêng biệt dựa trên quyền
            switch (quyen)
            {
                case "Admin":
                    // ĐÃ BỎ COMMENT: Khởi tạo FormAdmin.
                    // LƯU Ý: Class FormAdmin phải tồn tại trong project của bạn.
                    formChinh = new FormAdmin(quyen, nhanVienID, tenNV);
                    break;
                case "TruongPhong":
                    // ĐÃ BỎ COMMENT: Khởi tạo FormTruongPhong.
                    formChinh = new FormTruongPhong(quyen, nhanVienID, tenNV);
                    break;
                case "KeToan":
                    // ĐÃ BỎ COMMENT: Khởi tạo FormKeToan.
                    formChinh = new FormKeToan(quyen, nhanVienID, tenNV);
                    break;
                case "NhanVien":
                    // ĐÃ BỎ COMMENT: Khởi tạo FormNhanVien.
                    formChinh = new FormNhanVien(quyen, nhanVienID, tenNV);
                    break;
                default:
                    MessageBox.Show("Quyền không hợp lệ!");
                    this.Show(); // Hiện lại form đăng nhập
                    return;
            }

            // KIỂM TRA: Nếu Form chính được khởi tạo (KHÔNG null), thì hiển thị Form đó
            if (formChinh != null)
            {
                formChinh.Show();
                this.Hide(); // Ẩn Form đăng nhập
            }
            // KHÔNG CẦN ELSE BLOCK ẨN FORM Ở ĐÂY NỮA
            // Nếu formChinh == null (vì class Form tương ứng không tồn tại), Form đăng nhập sẽ vẫn hiển thị
            // để người dùng có thể thấy lỗi hoặc thoát ứng dụng.
        }
    }
}