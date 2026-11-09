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
    public partial class TrinhDo : UserControl
    {
        SqlCommand boLenh;
        SqlDataAdapter docGhi;
        DataSet duLieu;
        SqlConnection ketNoi;
        public TrinhDo()
        {
            InitializeComponent();
        }
        public void Load_Data()
        {
            string sql = @"SELECT MaTrinhDo, TenTrinhDo FROM TrinhDo";
            docGhi = new SqlDataAdapter(sql, ketNoi);
            duLieu = new DataSet();
            docGhi.Fill(duLieu);
            DgvTrinhDo.DataSource = duLieu.Tables[0];
        }

        private void TrinhDo_Load(object sender, EventArgs e)
        {
            string chuoiKN = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhanVien;Integrated Security=True;Trust Server Certificate=True";
            ketNoi = new SqlConnection(chuoiKN);
            Load_Data();
        }

        private void DgvTrinhDo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtMaTrinhDo.Text = DgvTrinhDo.CurrentRow.Cells[0].Value.ToString();
            TxtTenTrinhDo.Text = DgvTrinhDo.CurrentRow.Cells[1].Value.ToString();
        }

        private void BtnTaoTrinhDo_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string them = @"INSERT INTO TrinhDo(MaTrinhDo, TenTrinhDo) VALUES (@MaTrinhDo, @TenTrinhDo)";
            try
            {
                if (result == DialogResult.Yes)
                {
                    if (ketNoi.State != ConnectionState.Open)
                    {
                        ketNoi.Open();
                    }
                    boLenh = new SqlCommand(them, ketNoi);
                    boLenh.Parameters.AddWithValue("@MaTrinhDo", TxtMaTrinhDo.Text);
                    boLenh.Parameters.AddWithValue("@TenTrinhDo", TxtTenTrinhDo.Text);
                    boLenh.ExecuteNonQuery();
                    MessageBox.Show("Thêm trình độ thành công");
                    Load_Data();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm " + ex.Message);
            }
            finally
            {
                ketNoi.Close();
            }
        }

        private void BtnSuaTrinhDo_Click(object sender, EventArgs e)
        {
            string sua = @"UPDATE TrinhDo SET TenTrinhDo = @TenTrinhDo WHERE MaTrinhDo = @MaTrinhDo";
            DialogResult result = MessageBox.Show("Bạn có chắn chắn cập nhật?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (result == DialogResult.Yes)
                {
                    if (ketNoi.State != ConnectionState.Open)
                    {
                        ketNoi.Open();
                    }
                    boLenh = new SqlCommand(sua, ketNoi);
                    boLenh.Parameters.AddWithValue("@MaTrinhDo", TxtMaTrinhDo.Text);
                    boLenh.Parameters.AddWithValue("@TenTrinhDo", TxtTenTrinhDo.Text);
                    boLenh.ExecuteNonQuery();
                    Load_Data();
                    MessageBox.Show("Sửa thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa lỗi trình độ: " + ex.Message);
            }
            finally
            {
                ketNoi.Close();
            }
        }

        private void BtnXoaTrinhDo_Click(object sender, EventArgs e)
        {
            string xoa = @"DELETE FROM TrinhDo WHERE MaTrinhDo=@MaTrinhDo";
            DialogResult result = MessageBox.Show("Bạn có chắn chắn Xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (result == DialogResult.Yes)
                {
                    if (ketNoi.State != ConnectionState.Open)
                    {
                        ketNoi.Open();
                    }
                    boLenh = new SqlCommand(xoa, ketNoi);
                    boLenh.Parameters.AddWithValue("@MaTrinhDo", TxtMaTrinhDo.Text);
                    boLenh.ExecuteNonQuery();
                    Load_Data();
                    MessageBox.Show("Xóa thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa lỗi trình độ: " + ex.Message);
            }
            finally
            {
                ketNoi.Close();
            }
        }
    }
}
