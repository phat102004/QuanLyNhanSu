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
    public partial class ThemNhanVien : UserControl
    {
        SqlCommand boLenh;
        SqlConnection ketNoi;
        SqlDataAdapter docGhi;
        DataSet duLieu;

        public ThemNhanVien()
        {
            InitializeComponent();

            string chuoiKN = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhanVienMain;Integrated Security=True;Trust Server Certificate=True";
            ketNoi = new SqlConnection(chuoiKN);
        }

        public void Load_CbxPhongBan()
        {
            string them = @"SELECT PhongBanID, TenPhongBan FROM PhongBan";
            docGhi = new SqlDataAdapter(them, ketNoi);
            duLieu = new DataSet();
            docGhi.Fill(duLieu);
            CbxPhongBan.DataSource = duLieu.Tables[0];
            CbxPhongBan.DisplayMember = "TenPhongBan";
            CbxPhongBan.ValueMember = "PhongBanID";
        }

        private void Load_CbxTrinhDo()
        {
            string them = @"SELECT TrinhDoID, TenTrinhDo FROM TrinhDo";
            docGhi = new SqlDataAdapter(them, ketNoi);
            duLieu = new DataSet();
            docGhi.Fill(duLieu);

            CbxTrinhDo.DataSource = duLieu.Tables[0];
            CbxTrinhDo.DisplayMember = "TenTrinhDo";
            CbxTrinhDo.ValueMember = "TrinhDoID";
        }

        private void Load_CbxChucVu()
        {
            string them = @"SELECT ChucVuID, TenChucVu FROM ChucVu";
            docGhi = new SqlDataAdapter(them, ketNoi);
            duLieu = new DataSet();
            docGhi.Fill(duLieu);

            CbxChucVu.DataSource = duLieu.Tables[0];
            CbxChucVu.DisplayMember = "TenChucVu";
            CbxChucVu.ValueMember = "ChucVuID";
        }

        private void ThemNhanVien_Load(object sender, EventArgs e)
        {
            Load_CbxPhongBan();
            Load_CbxTrinhDo();
            Load_CbxChucVu();
        }

        private void BtnThemNhanVien_Click(object sender, EventArgs e)
        {
            string them = @"INSERT INTO NhanVien(MaNhanVien, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, Email, CMND_CCCD, NgayVaoLam, TrinhDoChuyenMon, PhongBanID, ChucVuID)
                            VALUES
                          (@MaNhanVien, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, 
                          @SoDienThoai, @Email, @CMND_CCCD, @NgayVaoLam, 
                          @TrinhDoChuyenMon, @PhongBanID, @ChucVuID)";
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
                    boLenh.Parameters.AddWithValue("@MaNhanVien", TxtMaNhanVien.Text);
                    boLenh.Parameters.AddWithValue("@HoTen", TxtTenNhanVien.Text);
                    boLenh.Parameters.AddWithValue("@NgaySinh", DtpNgaySinh.Value.Date);
                    boLenh.Parameters.AddWithValue("@GioiTinh", TxtGioiTinh.Text);
                    boLenh.Parameters.AddWithValue("@DiaChi", TxtDiaChi.Text);
                    boLenh.Parameters.AddWithValue("@SoDienThoai", TxtSoDienThoai.Text);
                    boLenh.Parameters.AddWithValue("@Email", TxtEmail.Text);
                    boLenh.Parameters.AddWithValue("@CMND_CCCD", TxtCMND_CCCD.Text);
                    boLenh.Parameters.AddWithValue("@NgayVaoLam", DtpNgayVaoLam.Value.Date);

                    boLenh.Parameters.AddWithValue("@TrinhDoChuyenMon", CbxTrinhDo.SelectedValue);

                    boLenh.Parameters.AddWithValue("@PhongBanID", CbxPhongBan.SelectedValue);
                    boLenh.Parameters.AddWithValue("@ChucVuID", CbxChucVu.SelectedValue);
                    boLenh.ExecuteNonQuery();

                    TxtMaNhanVien.Text = null;
                    TxtTenNhanVien.Text = null;
                    DtpNgaySinh.Text = null;
                    TxtGioiTinh.Text = null;
                    TxtDiaChi.Text = null;
                    TxtSoDienThoai.Text = null;
                    TxtEmail.Text = null;
                    TxtCMND_CCCD.Text = null;
                    DtpNgayVaoLam.Text = null;

                    MessageBox.Show("Thêm nhân viên thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message);
            }
            finally
            {
                if (ketNoi.State == ConnectionState.Open)
                {
                    ketNoi.Close();
                }
            }
        }
    }
}