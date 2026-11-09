using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.usercontrol
{
    public partial class ChucVu : UserControl
    {
        SqlCommand boLenh;
        SqlConnection ketNoi;
        DataSet duLieu;
        SqlDataAdapter docGhi;
        public ChucVu()
        {
            InitializeComponent();
        }

        private void Load_Data()
        {
            string sql = @"SELECT MaChucVu, TenChucVu, Luong FROM ChucVu";
            docGhi = new SqlDataAdapter(sql, ketNoi);
            duLieu = new DataSet();
            docGhi.Fill(duLieu);

            DgvChucVu.DataSource = duLieu.Tables[0];
        }

        private void Load_Page()
        {
            TxtMaChucVu.Text = "";
            TxtTenChucVu.Text = "";
            TxtLuongChucVu.Text = "";
        }
        private void ChucVu_Load(object sender, EventArgs e)
        {
            string chuoiKN = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhanVien;Integrated Security=True;Trust Server Certificate=True";
            ketNoi = new SqlConnection(chuoiKN);
            Load_Data();
        }

        private void DgvChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtMaChucVu.Text = DgvChucVu.CurrentRow.Cells[0].Value.ToString();
            TxtTenChucVu.Text = DgvChucVu.CurrentRow.Cells[1].Value.ToString();
            TxtLuongChucVu.Text = DgvChucVu.CurrentRow.Cells[2].Value.ToString();
        }

        private void BtnTaoChucVu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn Thêm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string them = "INSERT INTO ChucVu(MaChucVu, TenChucVu, Luong) values (@MaChucVu, @TenChucVu, @Luong)";
            try
            {
                if (result == DialogResult.Yes)
                {
                    if (ketNoi.State != ConnectionState.Open)
                    {
                        ketNoi.Open();
                    }
                    boLenh = new SqlCommand(them, ketNoi);
                    boLenh.Parameters.AddWithValue("@MaChucVu", TxtMaChucVu.Text);
                    boLenh.Parameters.AddWithValue("@TenChucVu", TxtTenChucVu.Text);
                    boLenh.Parameters.AddWithValue("@Luong", TxtLuongChucVu.Text);
                    boLenh.ExecuteNonQuery();
                    ketNoi.Close();
                    Load_Data();
                    Load_Page();
                    MessageBox.Show("Thêm thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);

            }
            finally
            {
                ketNoi.Close();
            }
        }

        private void BtnSuaChucVu_Click(object sender, EventArgs e)
        {
            string sua = @"UPDATE ChucVu SET TenChucVu=@TenChucVu, Luong=@Luong WHERE MaChucVu=@MaChucVu";
            DialogResult result = MessageBox.Show("Đồng ý sửa?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (result == DialogResult.Yes)
                {
                    if (ketNoi.State != ConnectionState.Open)
                    {
                        ketNoi.Open();
                    }
                    boLenh = new SqlCommand(sua, ketNoi);
                    boLenh.Parameters.AddWithValue("@MaChucVu", TxtMaChucVu.Text);
                    boLenh.Parameters.AddWithValue("@TenChucVu", TxtTenChucVu.Text);
                    boLenh.Parameters.AddWithValue("@Luong", TxtLuongChucVu.Text);
                    boLenh.ExecuteNonQuery();
                    Load_Data();
                    Load_Page();
                    MessageBox.Show("Sửa thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message);
            }
            finally
            {
                ketNoi.Close();
            }
        }

        private void BtnXoaChucVu_Click(object sender, EventArgs e)
        {
            string xoa = @"DELETE FROM ChucVu WHERE MaChucVu=@MaChucVu";
            DialogResult result = MessageBox.Show("Đồng ý xóa?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (result == DialogResult.Yes)
                {
                    if (ketNoi.State != ConnectionState.Open)
                    {
                        ketNoi.Open();
                    }
                    boLenh = new SqlCommand(xoa, ketNoi);
                    boLenh.Parameters.AddWithValue("@MaChucVu", TxtMaChucVu.Text);
                    boLenh.ExecuteNonQuery();
                    Load_Data();
                    Load_Page();
                    MessageBox.Show("Xóa thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
            finally
            {
                ketNoi.Close();
            }
        }
    }
}
