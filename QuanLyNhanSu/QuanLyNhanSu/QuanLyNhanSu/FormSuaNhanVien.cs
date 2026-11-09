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

namespace QuanLyNhanSu
{
    public partial class FormSuaNhanVien : Form
    {
        private int _phongBanID;
        private int _chucVuID;
        private int _trinhDo;
        SqlCommand boLenh;
        SqlDataAdapter docGhi;
        DataSet duLieu;
        SqlConnection ketNoi;
        public event EventHandler DuLieuDaCapNhat;
        public FormSuaNhanVien(
        string maNV, string hoTen, string ngaySinh, string gioiTinh,
        string diaChi, string soDienThoai, string email, string cmnd,
        string ngayVaoLam, string trangThai, int trinhDo,
        int tenPhongBan, int tenChucVu)
        {
            InitializeComponent();
            TxtMaNhanVien.Text = maNV;
            TxtTenNhanVien.Text = hoTen;
            DtpNgaySinh.Value = DateTime.Parse(ngaySinh);
            TxtGioiTinh.Text = gioiTinh;
            TxtDiaChi.Text = diaChi;
            TxtSoDienThoai.Text = soDienThoai;
            TxtEmail.Text = email;
            TxtCMND_CCCD.Text = cmnd;
            DtpNgayVaoLam.Value = DateTime.Parse(ngayVaoLam);
            TxtTrangThaiLamVien.Text = trangThai;
            _phongBanID = tenPhongBan;
            _chucVuID = tenChucVu;
            _trinhDo = trinhDo;
        }

        private void CbxTrinhDoCM()
        {
            string sql = @"SELECT TrinhDoID, TenTrinhDo FROM TrinhDo";
            docGhi = new SqlDataAdapter(sql, ketNoi);
            duLieu = new DataSet();
            docGhi.Fill(duLieu);

            CbxTrinhDo.DataSource = duLieu.Tables[0];
            CbxTrinhDo.DisplayMember = "TenTrinhDo";
            CbxTrinhDo.ValueMember = "TrinhDoID";
        }

        private void CbxPhongBanNV()
        {
            string sql = @"SELECT PhongBanID, TenPhongBan
                           FROM PhongBan";
            docGhi = new SqlDataAdapter(sql, ketNoi);
            duLieu = new DataSet();
            docGhi.Fill(duLieu);

            CbxPhongBan.DataSource = duLieu.Tables[0];
            CbxPhongBan.DisplayMember = "TenPhongBan";
            CbxPhongBan.ValueMember = "PhongBanID";
        }

        private void CbxChucVuNV()
        {
            string sql = @"SELECT ChucVuID, TenChucVu
                           FROM ChucVu";
            docGhi = new SqlDataAdapter(sql, ketNoi);
            duLieu = new DataSet();
            docGhi.Fill(duLieu);

            CbxChucVu.DataSource = duLieu.Tables[0];
            CbxChucVu.DisplayMember = "TenChucVu";
            CbxChucVu.ValueMember = "ChucVuID";
        }
        private void BtnSuaNhanVien_Click(object sender, EventArgs e)
        {
            string sua = @"UPDATE NhanVien SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai, Email = @Email, CMND_CCCD = @CMND, NgayVaoLam = @NgayVaoLam, TrangThaiLamViec = @TrangThai, TrinhDoID = @TenTrinhDo, PhongBanID=@TenPhongBan, ChucVuID=@TenChucVu
                           WHERE MaNhanVien = @MaNhanVien";
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
                    boLenh.Parameters.AddWithValue("@MaNhanVien", TxtMaNhanVien.Text);
                    boLenh.Parameters.AddWithValue("@HoTen", TxtTenNhanVien.Text);
                    boLenh.Parameters.AddWithValue("@NgaySinh", DtpNgaySinh.Value.Date);
                    boLenh.Parameters.AddWithValue("@GioiTinh", TxtGioiTinh.Text);
                    boLenh.Parameters.AddWithValue("@DiaChi", TxtDiaChi.Text);
                    boLenh.Parameters.AddWithValue("@SoDienThoai", TxtSoDienThoai.Text);
                    boLenh.Parameters.AddWithValue("@Email", TxtEmail.Text);
                    boLenh.Parameters.AddWithValue("@CMND", TxtCMND_CCCD.Text);
                    boLenh.Parameters.AddWithValue("@NgayVaoLam", DtpNgayVaoLam.Value.Date);
                    boLenh.Parameters.AddWithValue("@TrangThai", TxtTrangThaiLamVien.Text);
                    boLenh.Parameters.AddWithValue("@TenTrinhDo", CbxTrinhDo.SelectedValue);
                    boLenh.Parameters.AddWithValue("@TenPhongBan", CbxPhongBan.SelectedValue);
                    boLenh.Parameters.AddWithValue("@TenChucVu", CbxChucVu.SelectedValue);
                    boLenh.ExecuteNonQuery();
                    MessageBox.Show("Sửa nhân viên thành công!");
                    DuLieuDaCapNhat?.Invoke(this, EventArgs.Empty); // Báo form cha
                    this.Close(); // Đóng form
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa lỗi nhân viên: " + ex.Message);
            }
            finally
            {
                ketNoi.Close();
            }
        }

        private void FormSuaNhanVien_Load(object sender, EventArgs e)
        {
            string chuoiKN = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhanVien;Integrated Security=True;Trust Server Certificate=True";
            ketNoi = new SqlConnection(chuoiKN);
            CbxTrinhDoCM();
            CbxPhongBanNV();
            CbxChucVuNV();
            CbxPhongBan.SelectedValue = _phongBanID;
            CbxChucVu.SelectedValue = _chucVuID;
            CbxTrinhDo.SelectedValue = _trinhDo;
        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
