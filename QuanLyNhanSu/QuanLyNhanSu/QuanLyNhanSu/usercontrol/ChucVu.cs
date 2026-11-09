using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyNhanSu.usercontrol
{
    public partial class ChucVu : UserControl
    {
        SqlCommand boLenh;
        SqlConnection ketNoi;
        DataSet duLieu;
        SqlDataAdapter docGhi;

        string chuoiKN = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhanVien;Integrated Security=True;Trust Server Certificate=True";

        public ChucVu()
        {
            InitializeComponent();
        }

        private void Load_Data()
        {
            string sql = @"
                SELECT 
                    ChucVuID,
                    TenChucVu,
                    Luong
                FROM ChucVu";

            try
            {
                if (ketNoi.State != ConnectionState.Open)
                {
                    ketNoi.Open();
                }

                docGhi = new SqlDataAdapter(sql, ketNoi);

                duLieu = new DataSet();

                docGhi.Fill(duLieu);

                DgvChucVu.DataSource = duLieu.Tables[0];

                ketNoi.Close();
            }
            catch (Exception ex)
            {
                if (ketNoi != null &&
                    ketNoi.State == ConnectionState.Open)
                {
                    ketNoi.Close();
                }

                MessageBox.Show(
                    "Lỗi tải dữ liệu chức vụ: " + ex.Message,
                    "Lỗi SQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void Load_Page()
        {
            TxtMaChucVu.Text = "";
            TxtTenChucVu.Text = "";
            TxtLuongChucVu.Text = "";
        }

        private void ChucVu_Load(object sender, EventArgs e)
        {
            ketNoi = new SqlConnection(chuoiKN);

            Load_Data();
        }

        private void DgvChucVu_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (DgvChucVu.Rows[e.RowIndex].Cells[0].Value != null)
            {
                TxtMaChucVu.Text =
                    DgvChucVu.Rows[e.RowIndex].Cells[0].Value.ToString();
            }

            if (DgvChucVu.Rows[e.RowIndex].Cells[1].Value != null)
            {
                TxtTenChucVu.Text =
                    DgvChucVu.Rows[e.RowIndex].Cells[1].Value.ToString();
            }

            if (DgvChucVu.Rows[e.RowIndex].Cells[2].Value != null)
            {
                TxtLuongChucVu.Text =
                    DgvChucVu.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        // ============================================================
        // THÊM CHỨC VỤ
        // ============================================================
        private void BtnTaoChucVu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thêm chức vụ?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtTenChucVu.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên chức vụ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtTenChucVu.Focus();
                return;
            }

            decimal luong;

            if (!decimal.TryParse(TxtLuongChucVu.Text, out luong))
            {
                MessageBox.Show(
                    "Lương chức vụ phải là số!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtLuongChucVu.Focus();
                return;
            }

            string them = @"
        INSERT INTO ChucVu (TenChucVu, Luong)
        VALUES (@TenChucVu, @Luong)";

            try
            {
                if (ketNoi.State != ConnectionState.Open)
                {
                    ketNoi.Open();
                }

                boLenh = new SqlCommand(them, ketNoi);

                boLenh.Parameters.AddWithValue(
                    "@TenChucVu",
                    TxtTenChucVu.Text.Trim());

                boLenh.Parameters.AddWithValue(
                    "@Luong",
                    luong);

                boLenh.ExecuteNonQuery();

                ketNoi.Close();

                Load_Data();
                Load_Page();

                MessageBox.Show(
                    "Thêm chức vụ thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi thêm chức vụ: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (ketNoi != null &&
                    ketNoi.State == ConnectionState.Open)
                {
                    ketNoi.Close();
                }
            }
        }
        // ============================================================
        // SỬA CHỨC VỤ
        // ============================================================
        private void BtnSuaChucVu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn sửa?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            string sua = @"
                UPDATE ChucVu
                SET
                    TenChucVu = @TenChucVu,
                    Luong = @Luong
                WHERE ChucVuID = @ChucVuID";

            try
            {
                if (ketNoi.State != ConnectionState.Open)
                {
                    ketNoi.Open();
                }

                boLenh = new SqlCommand(sua, ketNoi);

                boLenh.Parameters.AddWithValue(
                    "@ChucVuID",
                    Convert.ToInt32(TxtMaChucVu.Text)
                );

                boLenh.Parameters.AddWithValue(
                    "@TenChucVu",
                    TxtTenChucVu.Text.Trim()
                );

                boLenh.Parameters.AddWithValue(
                    "@Luong",
                    Convert.ToDecimal(TxtLuongChucVu.Text)
                );

                int ketQua = boLenh.ExecuteNonQuery();

                ketNoi.Close();

                if (ketQua > 0)
                {
                    Load_Data();
                    Load_Page();

                    MessageBox.Show("Sửa thành công!");
                }
                else
                {
                    MessageBox.Show(
                        "Không tìm thấy chức vụ cần sửa!"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi sửa: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                if (ketNoi != null &&
                    ketNoi.State == ConnectionState.Open)
                {
                    ketNoi.Close();
                }
            }
        }

        // ============================================================
        // XÓA CHỨC VỤ
        // ============================================================
        private void BtnXoaChucVu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            string xoa = @"
                DELETE FROM ChucVu
                WHERE ChucVuID = @ChucVuID";

            try
            {
                if (ketNoi.State != ConnectionState.Open)
                {
                    ketNoi.Open();
                }

                boLenh = new SqlCommand(xoa, ketNoi);

                boLenh.Parameters.AddWithValue(
                    "@ChucVuID",
                    Convert.ToInt32(TxtMaChucVu.Text)
                );

                int ketQua = boLenh.ExecuteNonQuery();

                ketNoi.Close();

                if (ketQua > 0)
                {
                    Load_Data();
                    Load_Page();

                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show(
                        "Không tìm thấy chức vụ cần xóa!"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi xóa: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                if (ketNoi != null &&
                    ketNoi.State == ConnectionState.Open)
                {
                    ketNoi.Close();
                }
            }
        }
    }
}