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
    public partial class QuanLyNhanVien : UserControl
    {

        private const string ConnectionString = "Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhanVien;Integrated Security=True;TrustServerCertificate=True;";
        private SqlConnection ketNoi;
        private SqlCommand boLenh;
        private SqlDataAdapter docGhi;
        private DataSet duLieu;
        private int loggedInUserID = 0;

        public QuanLyNhanVien() : this(0)
        {
        }
        public QuanLyNhanVien(int nhanVienID)
        {
            InitializeComponent();
            this.loggedInUserID = nhanVienID;
            this.ketNoi = new SqlConnection(ConnectionString);
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            ApplyUIAccess();
            Load_Data();
        }

        private void Load_Data()
        {
            string sql = @"SELECT nv.MaNhanVien, nv.HoTen, nv.NgaySinh, nv.GioiTinh,
                             nv.DiaChi, nv.SoDienThoai, nv.Email, nv.CMND_CCCD,
                             nv.NgayVaoLam, nv.TrangThaiLamViec,
                             td.TrinhDoID, td.TenTrinhDo,
                             pb.PhongBanID, pb.TenPhongBan,
                             cv.ChucVuID, cv.TenChucVu,
                             nv.NhanVienID
                           FROM NhanVien nv
                           JOIN PhongBan pb ON nv.PhongBanID = pb.PhongBanID
                           JOIN ChucVu cv ON nv.ChucVuID = cv.ChucVuID
                           JOIN TrinhDo td ON nv.TrinhDoID = td.TrinhDoID";

            if (this.loggedInUserID > 0)
            {
                sql += " WHERE nv.NhanVienID = @UserID";
            }

            try
            {
                docGhi = new SqlDataAdapter(sql, ketNoi);

                if (this.loggedInUserID > 0)
                {
                    docGhi.SelectCommand.Parameters.AddWithValue("@UserID", this.loggedInUserID);
                }

                duLieu = new DataSet();
                docGhi.Fill(duLieu);
                DgvDanhSachNhanVien.DataSource = duLieu.Tables[0];

                HideIDColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu nhân viên: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HideIDColumns()
        {
            if (DgvDanhSachNhanVien.Columns.Contains("NhanVienID")) DgvDanhSachNhanVien.Columns["NhanVienID"].Visible = false;
            if (DgvDanhSachNhanVien.Columns.Contains("TrinhDoID")) DgvDanhSachNhanVien.Columns["TrinhDoID"].Visible = false;
            if (DgvDanhSachNhanVien.Columns.Contains("PhongBanID")) DgvDanhSachNhanVien.Columns["PhongBanID"].Visible = false;
            if (DgvDanhSachNhanVien.Columns.Contains("ChucVuID")) DgvDanhSachNhanVien.Columns["ChucVuID"].Visible = false;
        }

        private void ApplyUIAccess()
        {
            if (this.loggedInUserID > 0)
            {
                if (BtnSuaThongTinNhanVien != null)
                {
                    BtnSuaThongTinNhanVien.Visible = true;
                    BtnSuaThongTinNhanVien.Text = "Sửa Hồ sơ Cá nhân";
                }

                if (TxtTimKiem != null) TxtTimKiem.Visible = false;
                if (TxtNVCanXoaSua != null) TxtNVCanXoaSua.Visible = false;
                if (DgvDanhSachNhanVien != null)
                {
                    DgvDanhSachNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    DgvDanhSachNhanVien.ReadOnly = true;
                    DgvDanhSachNhanVien.MultiSelect = false;
                }
            }
            else
            {
                if (DgvDanhSachNhanVien != null)
                {
                    DgvDanhSachNhanVien.ReadOnly = false;
                    DgvDanhSachNhanVien.MultiSelect = true;
                }
            }
        }

        private void BtnXoaNhanVien_Click(object sender, EventArgs e)
        {
            if (this.loggedInUserID > 0)
            {
                MessageBox.Show("Bạn không có quyền xóa nhân viên.", "Không có quyền", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (TxtNVCanXoaSua == null || string.IsNullOrEmpty(TxtNVCanXoaSua.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNVXoa = TxtNVCanXoaSua.Text;
            string xoa = @"DELETE FROM NhanVien WHERE MaNhanVien = @MaNhanVien";
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên có Mã: {maNVXoa}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    ketNoi.Open();
                    boLenh = new SqlCommand(xoa, ketNoi);
                    boLenh.Parameters.AddWithValue("@MaNhanVien", maNVXoa);

                    int rowsAffected = boLenh.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa nhân viên thành công!!");
                        TxtNVCanXoaSua.Text = "";
                        Load_Data();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message, "Lỗi Xóa Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void BtnSuaThongTinNhanVien_Click(object sender, EventArgs e)
        {
            if (DgvDanhSachNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên trong danh sách để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow currentRow = DgvDanhSachNhanVien.CurrentRow;
            int selectedNhanVienID = Convert.ToInt32(currentRow.Cells["NhanVienID"].Value);
            if (this.loggedInUserID > 0 && selectedNhanVienID != this.loggedInUserID)
            {
                MessageBox.Show("Bạn chỉ có thể sửa hồ sơ cá nhân của chính mình.", "Không có quyền", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (this.loggedInUserID == 0 && (TxtNVCanXoaSua == null || string.IsNullOrEmpty(TxtNVCanXoaSua.Text)))
            {
                MessageBox.Show("Admin/QL vui lòng chọn nhân viên cần sửa bằng cách click vào lưới.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string MaNV = currentRow.Cells["MaNhanVien"].Value.ToString();
                string HoTenNV = currentRow.Cells["HoTen"].Value.ToString();
                string NgaySinhNV = Convert.ToDateTime(currentRow.Cells["NgaySinh"].Value).ToString("yyyy-MM-dd");
                string GioiTinhNV = currentRow.Cells["GioiTinh"].Value.ToString();
                string DiaChiNV = currentRow.Cells["DiaChi"].Value.ToString();
                string SoDienThoaiNV = currentRow.Cells["SoDienThoai"].Value.ToString();
                string EmailNV = currentRow.Cells["Email"].Value.ToString();
                string CMND_CCCDNV = currentRow.Cells["CMND_CCCD"].Value.ToString();
                string NgayVaoLamNV = Convert.ToDateTime(currentRow.Cells["NgayVaoLam"].Value).ToString("yyyy-MM-dd");
                string TrangThaiLamViecNV = currentRow.Cells["TrangThaiLamViec"].Value.ToString();
                int PhongBanID = Convert.ToInt32(currentRow.Cells["PhongBanID"].Value);
                int ChucVuID = Convert.ToInt32(currentRow.Cells["ChucVuID"].Value);
                int TrinhDoID = Convert.ToInt32(currentRow.Cells["TrinhDoID"].Value);

                using (FormSuaNhanVien formsua = new FormSuaNhanVien(
                     MaNV, HoTenNV, NgaySinhNV, GioiTinhNV, DiaChiNV, SoDienThoaiNV,
                     EmailNV, CMND_CCCDNV, NgayVaoLamNV, TrangThaiLamViecNV,
                     TrinhDoID, PhongBanID, ChucVuID))
                {
                    formsua.DuLieuDaCapNhat += (s, ev) => Load_Data();
                    if (this.loggedInUserID == 0)
                    {
                        formsua.DuLieuDaCapNhat += (s, ev) => TxtNVCanXoaSua.Text = "";
                    }

                    this.Visible = false;
                    formsua.ShowDialog(this.ParentForm);
                    this.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chuẩn bị dữ liệu sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DgvDanhSachNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow selectedRow = DgvDanhSachNhanVien.Rows[e.RowIndex];
            if (this.loggedInUserID == 0 && TxtNVCanXoaSua != null)
            {
                TxtNVCanXoaSua.Text = selectedRow.Cells["MaNhanVien"].Value.ToString();
            }
        }

        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (this.loggedInUserID > 0) return;

            if (TxtTimKiem == null) return;

            if (string.IsNullOrEmpty(TxtTimKiem.Text.Trim()))
            {
                Load_Data();
                return;
            }

            string timKiem = @"SELECT nv.MaNhanVien, nv.HoTen, nv.NgaySinh, nv.GioiTinh, nv.DiaChi, nv.SoDienThoai, nv.Email, nv.CMND_CCCD, nv.NgayVaoLam, nv.TrangThaiLamViec, td.TenTrinhDo AS TenTrinhDo,pb.TenPhongBan AS TenPhongBan, cv.TenChucVu AS TenChucVu, nv.NhanVienID, td.TrinhDoID, pb.PhongBanID, cv.ChucVuID
                                 FROM NhanVien nv
                                 join PhongBan pb on pb.PhongBanID = nv.PhongBanID
                                 join ChucVu cv on cv.ChucVuID = nv.ChucVuID
                                 join TrinhDo td on nv.TrinhDoID = td.TrinhDoID
                                 WHERE nv.HoTen LIKE @HoTen";

            try
            {
                boLenh = new SqlCommand(timKiem, ketNoi);
                boLenh.Parameters.AddWithValue("@HoTen", "%" + TxtTimKiem.Text + "%");

                docGhi = new SqlDataAdapter(boLenh);
                duLieu = new DataSet();
                docGhi.Fill(duLieu);
                DgvDanhSachNhanVien.DataSource = duLieu.Tables[0];
                HideIDColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}