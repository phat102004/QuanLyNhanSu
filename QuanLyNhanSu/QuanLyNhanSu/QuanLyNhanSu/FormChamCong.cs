using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class FormChamCong : Form
    {
        private int nhanVienID;
        private string tenNhanVien;

        // Chuỗi kết nối của bạn
        private string connectionString = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhanVien;Integrated Security=True;Trust Server Certificate=True";

        public FormChamCong(int idNV, string hoTenNV)
        {
            InitializeComponent();

            nhanVienID = idNV;
            tenNhanVien = hoTenNV;

            // Hiển thị tên nhân viên
            txtNhanVien.Text = tenNhanVien;

            LoadChamCong();
        }

        private void LoadChamCong()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT ChamCongID, NgayChamCong, GioVao, GioRa, TongGioLam, TrangThai, GhiChu
                                 FROM ChamCong
                                 WHERE NhanVienID = @NhanVienID
                                 ORDER BY NgayChamCong DESC";

                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@NhanVienID", nhanVienID);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvChamCong.DataSource = dt;
                }
            }
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            DateTime ngayCham = dtpNgayChamCong.Value.Date;
            DateTime gioVao = dtpGioVao.Value;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO ChamCong (NhanVienID, NgayChamCong, GioVao, TrangThai, GhiChu)
                                 VALUES (@NhanVienID, @NgayChamCong, @GioVao, @TrangThai, @GhiChu)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NhanVienID", nhanVienID);
                    cmd.Parameters.AddWithValue("@NgayChamCong", ngayCham);
                    cmd.Parameters.AddWithValue("@GioVao", gioVao);

                    // Tự động tính trạng thái: "Đủ công" nếu trước 8h, "Trễ" nếu sau 8h
                    string trangThai = (gioVao.Hour < 8) ? "Đủ công" : "Trễ";
                    cmd.Parameters.AddWithValue("@TrangThai", trangThai);

                    cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text.Trim());

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Chấm công thành công!");
                        LoadChamCong();
                        CapNhatNgayCongThang(ngayCham);
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627) // Vi phạm UNIQUE
                            MessageBox.Show("Bạn đã chấm công hôm nay!");
                        else
                            MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            DateTime ngayCham = dtpNgayChamCong.Value.Date;
            DateTime gioRa = dtpGioRa.Value;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"UPDATE ChamCong
                                 SET GioRa = @GioRa,
                                     TongGioLam = DATEDIFF(MINUTE, GioVao, @GioRa)/60.0
                                 WHERE NhanVienID = @NhanVienID AND NgayChamCong = @NgayChamCong";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@GioRa", gioRa);
                    cmd.Parameters.AddWithValue("@NhanVienID", nhanVienID);
                    cmd.Parameters.AddWithValue("@NgayChamCong", ngayCham);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Check-out thành công!");
                        LoadChamCong();
                    }
                    else
                        MessageBox.Show("Chưa chấm công hôm nay, không thể check-out.");
                }
            }
        }

        private void CapNhatNgayCongThang(DateTime ngayCham)
        {
            int thang = ngayCham.Month;
            int nam = ngayCham.Year;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string checkQuery = @"SELECT COUNT(*) FROM NgayCongThang 
                                      WHERE NhanVienID=@NhanVienID AND Thang=@Thang AND Nam=@Nam";
                using (SqlCommand cmdCheck = new SqlCommand(checkQuery, conn))
                {
                    cmdCheck.Parameters.AddWithValue("@NhanVienID", nhanVienID);
                    cmdCheck.Parameters.AddWithValue("@Thang", thang);
                    cmdCheck.Parameters.AddWithValue("@Nam", nam);

                    int count = (int)cmdCheck.ExecuteScalar();
                    if (count > 0)
                    {
                        string updateQuery = @"UPDATE NgayCongThang
                                               SET SoNgayCong = SoNgayCong + 1
                                               WHERE NhanVienID=@NhanVienID AND Thang=@Thang AND Nam=@Nam";
                        using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn))
                        {
                            cmdUpdate.Parameters.AddWithValue("@NhanVienID", nhanVienID);
                            cmdUpdate.Parameters.AddWithValue("@Thang", thang);
                            cmdUpdate.Parameters.AddWithValue("@Nam", nam);
                            cmdUpdate.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        string insertQuery = @"INSERT INTO NgayCongThang (NhanVienID, Thang, Nam, SoNgayCong)
                                               VALUES (@NhanVienID, @Thang, @Nam, 1)";
                        using (SqlCommand cmdInsert = new SqlCommand(insertQuery, conn))
                        {
                            cmdInsert.Parameters.AddWithValue("@NhanVienID", nhanVienID);
                            cmdInsert.Parameters.AddWithValue("@Thang", thang);
                            cmdInsert.Parameters.AddWithValue("@Nam", nam);
                            cmdInsert.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dtpNgayChamCong.Value = DateTime.Now;
            dtpGioVao.Value = DateTime.Now;
            dtpGioRa.Value = DateTime.Now;
            txtGhiChu.Clear();
            LoadChamCong();
        }
    }
}
