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

namespace QuanLyNhanSu.usercontrol
{
    public partial class PhuCap : UserControl
    {
        SqlConnection ketNoi;
        SqlCommand boLenh;
        SqlDataAdapter docGhi;
        DataSet duLieu;
        public PhuCap()
        {
            InitializeComponent();
        }

        private void Load_Data()
        {
            string sql = "SELECT MaPhuCap, TenPhuCap, SoTien FROM PhuCap";
            docGhi = new SqlDataAdapter(sql, ketNoi);
            duLieu = new DataSet();
            docGhi.Fill(duLieu);

            DgvPhuCap.DataSource = duLieu.Tables[0];
        }

        private void PhuCap_Load(object sender, EventArgs e)
        {
            string chuoiKN = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhanVien;Integrated Security=True;Trust Server Certificate=True";
            ketNoi = new SqlConnection(chuoiKN);
            Load_Data();
        }

        private void DgvPhuCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtMaPhuCap.Text = DgvPhuCap.CurrentRow.Cells[0].Value.ToString();
            TxtTenPhuCap.Text = DgvPhuCap.CurrentRow.Cells[1].Value.ToString();
            TxtSoTienPhuCap.Text = DgvPhuCap.CurrentRow.Cells[2].Value.ToString();
        }

        private void BtnTaoPhuCap_Click(object sender, EventArgs e)
        {
            string them = @"INSERT INTO PhuCap (MaPhuCap ,TenPhuCap, SoTien) VALUES (@MaPhuCap, @TenPhuCap, @SoTien)";
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn Thêm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (result == DialogResult.Yes)
                {
                    if (ketNoi.State != ConnectionState.Open)
                    {
                        ketNoi.Open();
                    }
                    boLenh = new SqlCommand(them, ketNoi);
                    boLenh.Parameters.AddWithValue("@MaPhuCap", TxtMaPhuCap.Text);
                    boLenh.Parameters.AddWithValue("@TenPhuCap", TxtTenPhuCap.Text);
                    boLenh.Parameters.AddWithValue("@SoTien", TxtSoTienPhuCap.Text);
                    boLenh.ExecuteNonQuery();
                    ketNoi.Close();
                    Load_Data();
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

        private void BtnSuaPhuCap_Click(object sender, EventArgs e)
        {
            string sua = @"UPDATE PhuCap SET TenPhuCap=@TenPhuCap, SoTien=@SoTien WHERE MaPhuCap=@MaPhuCap";
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
                    boLenh.Parameters.AddWithValue("@MaPhuCap", TxtMaPhuCap.Text);
                    boLenh.Parameters.AddWithValue("@TenPhuCap", TxtTenPhuCap.Text);
                    boLenh.Parameters.AddWithValue("@SoTien", TxtSoTienPhuCap.Text);
                    boLenh.ExecuteNonQuery();
                    Load_Data();
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

        private void BtnXoaPhuCap_Click(object sender, EventArgs e)
        {
            string xoa = "DELETE FROM PhuCap WHERE MaPhuCap = @MaPhuCap";
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
                    boLenh.Parameters.AddWithValue("@MaPhuCap", TxtMaPhuCap.Text);
                    boLenh.ExecuteNonQuery();
                    Load_Data();
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
