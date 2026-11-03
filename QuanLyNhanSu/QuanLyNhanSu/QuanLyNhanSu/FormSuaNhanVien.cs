using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class FormSuaNhanVien : Form
    {
        private int _phongBanID;
        private int _chucVuID;
        private int _trinhDo;

        private string _gioiTinh;
        private string _trangThai;

        SqlCommand boLenh;
        SqlDataAdapter docGhi;
        DataSet duLieu;
        SqlConnection ketNoi;

        public event EventHandler DuLieuDaCapNhat;

        public FormSuaNhanVien(
            string maNV,
            string hoTen,
            string ngaySinh,
            string gioiTinh,
            string diaChi,
            string soDienThoai,
            string email,
            string cmnd,
            string ngayVaoLam,
            string trangThai,
            int trinhDo,
            int tenPhongBan,
            int tenChucVu)
        {
            InitializeComponent();

            TxtMaNhanVien.Text = maNV;
            TxtTenNhanVien.Text = hoTen;

            DtpNgaySinh.Value = DateTime.Parse(ngaySinh);

            _gioiTinh = gioiTinh;
            _trangThai = trangThai;

            TxtDiaChi.Text = diaChi;
            TxtSoDienThoai.Text = soDienThoai;
            TxtEmail.Text = email;
            TxtCMND_CCCD.Text = cmnd;

            DtpNgayVaoLam.Value = DateTime.Parse(ngayVaoLam);

            _phongBanID = tenPhongBan;
            _chucVuID = tenChucVu;
            _trinhDo = trinhDo;
        }

        private void CbxTrinhDoCM()
        {
            string sql = @"
                SELECT TrinhDoID, TenTrinhDo
                FROM TrinhDo";

            docGhi = new SqlDataAdapter(sql, ketNoi);

            duLieu = new DataSet();

            docGhi.Fill(duLieu);

            CbxTrinhDo.DataSource = duLieu.Tables[0];
            CbxTrinhDo.DisplayMember = "TenTrinhDo";
            CbxTrinhDo.ValueMember = "TrinhDoID";
        }

        private void CbxPhongBanNV()
        {
            string sql = @"
                SELECT PhongBanID, TenPhongBan
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
            string sql = @"
                SELECT ChucVuID, TenChucVu
                FROM ChucVu";

            docGhi = new SqlDataAdapter(sql, ketNoi);

            duLieu = new DataSet();

            docGhi.Fill(duLieu);

            CbxChucVu.DataSource = duLieu.Tables[0];
            CbxChucVu.DisplayMember = "TenChucVu";
            CbxChucVu.ValueMember = "ChucVuID";
        }

        private void CbxTrangThaiNV()
        {
            string sql = @"
                SELECT TrangThaiID, TenTrangThai
                FROM TrangThaiNhanVien";

            docGhi = new SqlDataAdapter(sql, ketNoi);

            duLieu = new DataSet();

            docGhi.Fill(duLieu);

            CbxTrangThaiLamViec.DataSource = duLieu.Tables[0];
            CbxTrangThaiLamViec.DisplayMember = "TenTrangThai";
            CbxTrangThaiLamViec.ValueMember = "TrangThaiID";
        }

        private void FormSuaNhanVien_Load(object sender, EventArgs e)
        {
            string chuoiKN =
                @"Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhanVien;Integrated Security=True;Trust Server Certificate=True";

            ketNoi = new SqlConnection(chuoiKN);

            // Load dữ liệu ComboBox
            CbxTrinhDoCM();

            CbxPhongBanNV();

            CbxChucVuNV();

            CbxTrangThaiNV();

            // Load lại giới tính cũ
            int viTriGioiTinh =
                CbxGioiTinh.FindStringExact(_gioiTinh);

            if (viTriGioiTinh >= 0)
            {
                CbxGioiTinh.SelectedIndex =
                    viTriGioiTinh;
            }

            // Load lại trạng thái cũ
            int viTriTrangThai =
                CbxTrangThaiLamViec.FindStringExact(_trangThai);

            if (viTriTrangThai >= 0)
            {
                CbxTrangThaiLamViec.SelectedIndex =
                    viTriTrangThai;
            }

            // Load lại phòng ban
            CbxPhongBan.SelectedValue =
                _phongBanID;

            // Load lại chức vụ
            CbxChucVu.SelectedValue =
                _chucVuID;

            // Load lại trình độ
            CbxTrinhDo.SelectedValue =
                _trinhDo;
        }

        private void BtnSuaNhanVien_Click(object sender, EventArgs e)
        {
            string sua = @"
                UPDATE NhanVien
                SET
                    HoTen = @HoTen,
                    NgaySinh = @NgaySinh,
                    GioiTinh = @GioiTinh,
                    DiaChi = @DiaChi,
                    SoDienThoai = @SoDienThoai,
                    Email = @Email,
                    CMND_CCCD = @CMND,
                    NgayVaoLam = @NgayVaoLam,
                    TrangThaiID = @TrangThaiID,
                    TrinhDoID = @TenTrinhDo,
                    PhongBanID = @TenPhongBan,
                    ChucVuID = @TenChucVu
                WHERE MaNhanVien = @MaNhanVien";

            DialogResult result = MessageBox.Show(
                "Đồng ý sửa?",
                "Xác Nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            try
            {
                if (result == DialogResult.Yes)
                {
                    if (ketNoi.State != ConnectionState.Open)
                    {
                        ketNoi.Open();
                    }

                    boLenh = new SqlCommand(
                        sua,
                        ketNoi
                    );

                    boLenh.Parameters.AddWithValue(
                        "@MaNhanVien",
                        TxtMaNhanVien.Text
                    );

                    boLenh.Parameters.AddWithValue(
                        "@HoTen",
                        TxtTenNhanVien.Text
                    );

                    boLenh.Parameters.AddWithValue(
                        "@NgaySinh",
                        DtpNgaySinh.Value.Date
                    );

                    boLenh.Parameters.AddWithValue(
                        "@GioiTinh",
                        CbxGioiTinh.SelectedItem?.ToString() ?? ""
                    );

                    boLenh.Parameters.AddWithValue(
                        "@DiaChi",
                        TxtDiaChi.Text
                    );

                    boLenh.Parameters.AddWithValue(
                        "@SoDienThoai",
                        TxtSoDienThoai.Text
                    );

                    boLenh.Parameters.AddWithValue(
                        "@Email",
                        TxtEmail.Text
                    );

                    boLenh.Parameters.AddWithValue(
                        "@CMND",
                        TxtCMND_CCCD.Text
                    );

                    boLenh.Parameters.AddWithValue(
                        "@NgayVaoLam",
                        DtpNgayVaoLam.Value.Date
                    );

                    boLenh.Parameters.AddWithValue(
                        "@TrangThaiID",
                        CbxTrangThaiLamViec.SelectedValue
                    );

                    boLenh.Parameters.AddWithValue(
                        "@TenTrinhDo",
                        CbxTrinhDo.SelectedValue
                    );

                    boLenh.Parameters.AddWithValue(
                        "@TenPhongBan",
                        CbxPhongBan.SelectedValue
                    );

                    boLenh.Parameters.AddWithValue(
                        "@TenChucVu",
                        CbxChucVu.SelectedValue
                    );

                    boLenh.ExecuteNonQuery();

                    MessageBox.Show(
                        "Sửa nhân viên thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    DuLieuDaCapNhat?.Invoke(
                        this,
                        EventArgs.Empty
                    );

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi sửa nhân viên: " +
                    ex.Message,
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

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}