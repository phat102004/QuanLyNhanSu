using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace QuanLyNhanSu.usercontrol
{
    public partial class Uc_phongBan : UserControl
    {
        SqlCommand boLenh;
        SqlDataAdapter docGhi;
        DataSet duLieu;
        SqlConnection ketNoi;
        public Uc_phongBan()
        {
            InitializeComponent();
        }

        private void Load_Data()
        {
            string sql = (@"SELECT MaPhongBan, TenPhongBan FROM PhongBan");
            docGhi = new SqlDataAdapter(sql, ketNoi);
            duLieu = new DataSet();
            docGhi.Fill(duLieu);
            Dgv_phongBan.DataSource = duLieu.Tables[0];
        }

        private void Uc_phongBan_Load(object sender, EventArgs e)
        {
            string chuoiKN = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhanVien;Integrated Security=True;Trust Server Certificate=True";
            ketNoi = new SqlConnection(chuoiKN);
            Load_Data();
        }

        private void Dgv_phongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtMaPhongBan.Text = Dgv_phongBan.CurrentRow.Cells[0].Value.ToString();
            TxtTenPhongBan.Text = Dgv_phongBan.CurrentRow.Cells[1].Value.ToString();
        }

        private void BtnTaoPhongBan_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn Thêm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string them = string.Format("INSERT INTO PhongBan(MaPhongBan, TenPhongBan) values ('{0}',N'{1}')", TxtMaPhongBan.Text, TxtTenPhongBan.Text);
            try
            {
                if (result == DialogResult.Yes)
                {
                    if(ketNoi.State != ConnectionState.Open)
                    {
                        ketNoi.Open();
                    }
                    boLenh = new SqlCommand(them, ketNoi);
                    boLenh.ExecuteNonQuery();
                    ketNoi.Close();
                    Load_Data();
                    TxtMaPhongBan.Clear();
                    TxtTenPhongBan.Clear();
                    MessageBox.Show("Thêm phòng ban thành công!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phòng ban: " + ex.Message);

            }
            finally
            {
                ketNoi.Close();
            }
        }

        private void BtnSuaPhongBan_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string sua = string.Format("UPDATE PhongBan SET TenPhongBan = @TenPhongBan WHERE MaPhongBan = @MaPhongBan");
            try
            {
                if (result == DialogResult.Yes)
                {
                    if(ketNoi.State != ConnectionState.Open)
                    {
                        ketNoi.Open();
                    }
                    boLenh = new SqlCommand(sua, ketNoi);
                    boLenh.Parameters.AddWithValue("@MaPhongBan", TxtMaPhongBan.Text);
                    boLenh.Parameters.AddWithValue("TenPhongBan", TxtTenPhongBan.Text);
                    boLenh.ExecuteNonQuery();
                    ketNoi.Close();
                    Load_Data();
                    TxtMaPhongBan.Clear();
                    TxtTenPhongBan.Clear();
                    MessageBox.Show("Sửa phòng ban thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa phòng ban: " + ex.Message);

            }
            finally
            {
                ketNoi.Close();
            }
        }

        private void BtnXoaPhongBan_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn Xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string xoa = string.Format("DELETE FROM PhongBan WHERE MaPhongBan = @MaPhongBan");
            try
            {
                if (result == DialogResult.Yes)
                {
                    if(ketNoi.State != ConnectionState.Open)
                    {
                        ketNoi.Open();
                    }
                    boLenh = new SqlCommand(xoa, ketNoi);
                    boLenh.Parameters.AddWithValue("@MaPhongBan", TxtMaPhongBan.Text);
                    boLenh.ExecuteNonQuery();
                    ketNoi.Close();
                    Load_Data();
                    TxtMaPhongBan.Clear();
                    TxtTenPhongBan.Clear();
                    MessageBox.Show("Xóa phòng ban thành công!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa phòng ban: " + ex.Message);

            }
            finally
            {
                ketNoi.Close();
            }
        }
    }
}
