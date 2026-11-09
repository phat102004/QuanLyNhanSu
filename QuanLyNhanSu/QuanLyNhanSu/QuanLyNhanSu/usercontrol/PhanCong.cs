using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyNhanSu.usercontrol
{
    public partial class PhanCong : UserControl
    {
        private readonly string connectionString = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhanVien;Integrated Security=True;Trust Server Certificate=True";
        private readonly int nhanVienIDFilter;
        public PhanCong()
        {
            InitializeComponent();
            DtpNgayGiao.Value = DateTime.Now;
            DtpHanHoanThanh.Value = DateTime.Now.AddDays(7);
        }

        public PhanCong(int nhanVienID) : this()
        {
            this.nhanVienIDFilter = nhanVienID;
        }

        // -------------------------------------------------------------------
        // ## 🔄 Tải Dữ liệu Lưới và ComboBox
        // -------------------------------------------------------------------
        private void Load_Data()
        {
            try
            {
                string sql = @"
                SELECT
                    cv.CongViecID,
                    nv.HoTen,
                    cv.TenCongViec,
                    cv.NgayGiao,
                    cv.HanHoanThanh,
                    cv.TrangThai
                FROM CongViec cv
                JOIN NhanVien nv ON nv.NhanVienID = cv.NhanVienID
                ORDER BY cv.HanHoanThanh ASC";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter docGhi = new SqlDataAdapter(sql, conn);
                    DataSet duLieu = new DataSet();
                    docGhi.Fill(duLieu);
                    DgvPhanCong.DataSource = duLieu.Tables[0];
                }
                if (DgvPhanCong.DataSource != null)
                {
                    DgvPhanCong.Columns["CongViecID"].HeaderText = "ID";
                    DgvPhanCong.Columns["HoTen"].HeaderText = "Nhân Viên";
                    DgvPhanCong.Columns["TenCongViec"].HeaderText = "Tên Công Việc";
                    DgvPhanCong.Columns["NgayGiao"].HeaderText = "Ngày Giao";
                    DgvPhanCong.Columns["HanHoanThanh"].HeaderText = "Hạn Hoàn Thành";
                    DgvPhanCong.Columns["TrangThai"].HeaderText = "Trạng Thái";
                    DgvPhanCong.Columns["CongViecID"].Visible = false; // Ẩn ID
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu công việc: " + ex.Message,
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Load_CbxChucVu()
        {
            string sql = "SELECT ChucVuID, TenChucVu FROM ChucVu ORDER BY TenChucVu";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    CbxChucVu.SelectedIndexChanged -= CbxChucVu_SelectedIndexChanged_1;
                    DataRow placeholderRow = dt.NewRow();
                    placeholderRow["ChucVuID"] = -1;
                    placeholderRow["TenChucVu"] = "--- Chọn Chức vụ ---";
                    dt.Rows.InsertAt(placeholderRow, 0);
                    CbxChucVu.DataSource = dt;
                    CbxChucVu.DisplayMember = "TenChucVu";
                    CbxChucVu.ValueMember = "ChucVuID";
                    CbxChucVu.SelectedIndex = 0;

                    CbxChucVu.SelectedIndexChanged += CbxChucVu_SelectedIndexChanged_1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải danh sách chức vụ: " + ex.Message);
                }
            }
        }

        private void PopulateNhanVienPlaceholder()
        {
            DataTable dtEmpty = new DataTable();
            dtEmpty.Columns.Add("NhanVienID", typeof(int));
            dtEmpty.Columns.Add("HoTen", typeof(string));

            DataRow placeholder = dtEmpty.NewRow();
            placeholder["NhanVienID"] = -1;
            placeholder["HoTen"] = "--- Chọn Tên nhân viên ---";
            dtEmpty.Rows.Add(placeholder);

            CbxTenNhanVien.DataSource = dtEmpty;
            CbxTenNhanVien.DisplayMember = "HoTen";
            CbxTenNhanVien.ValueMember = "NhanVienID";
            CbxTenNhanVien.SelectedIndex = 0;
        }

        // -------------------------------------------------------------------
        // ## ⚙️ Sự kiện Load & Chức vụ thay đổi
        // -------------------------------------------------------------------
        private void PhanCong_Load(object sender, EventArgs e)
        {
            Load_CbxChucVu();
            Load_Data();
        }

        private void CbxChucVu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CbxChucVu.SelectedValue == null || CbxChucVu.SelectedValue is DataRowView)
            {
                return;
            }

            if (!int.TryParse(CbxChucVu.SelectedValue.ToString(), out int chucVuID) || chucVuID < 0)
            {
                PopulateNhanVienPlaceholder();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlNhanVien = "SELECT NhanVienID, HoTen FROM NhanVien WHERE ChucVuID = @ChucVuID ORDER BY HoTen";
                    SqlCommand cmd = new SqlCommand(sqlNhanVien, conn);
                    cmd.Parameters.AddWithValue("@ChucVuID", chucVuID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dtNV = new DataTable();
                    da.Fill(dtNV);

                    DataRow placeholderRow = dtNV.NewRow();
                    placeholderRow["NhanVienID"] = -1;
                    placeholderRow["HoTen"] = "--- Chọn Tên nhân viên ---";
                    dtNV.Rows.InsertAt(placeholderRow, 0);

                    CbxTenNhanVien.DataSource = dtNV;
                    CbxTenNhanVien.DisplayMember = "HoTen";
                    CbxTenNhanVien.ValueMember = "NhanVienID";
                    CbxTenNhanVien.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách nhân viên: " + ex.Message);
            }
        }

        // -------------------------------------------------------------------
        // ## ✏️ Thao tác CRUD: Thêm, Xóa, Sửa (Thêm Sửa cho đầy đủ)
        // -------------------------------------------------------------------
        private void BtnPhanCong_Click(object sender, EventArgs e)
        {
            string tenCongViec = TxtTenCongViec.Text.Trim();

            if (string.IsNullOrEmpty(tenCongViec))
            {
                MessageBox.Show("Vui lòng nhập Tên công việc.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CbxTenNhanVien.SelectedValue == null ||
                !int.TryParse(CbxTenNhanVien.SelectedValue.ToString(), out int nhanVienID) ||
                nhanVienID <= 0)
            {
                MessageBox.Show("Vui lòng chọn Tên nhân viên được phân công.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime ngayGiao = DtpNgayGiao.Value.Date;
            DateTime hanHoanThanh = DtpHanHoanThanh.Value.Date;
            string trangThai = "Chưa hoàn thành";
             if (hanHoanThanh < ngayGiao)
            {
                MessageBox.Show("Hạn hoàn thành không thể nhỏ hơn Ngày giao.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string them = @"INSERT INTO CongViec
            (NhanVienID, TenCongViec, NgayGiao, HanHoanThanh, TrangThai)
            VALUES
            (@NhanVienID, @TenCongViec, @NgayGiao, @HanHoanThanh, @TrangThai)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(them, conn))
                    {
                        cmd.Parameters.AddWithValue("@NhanVienID", nhanVienID);
                        cmd.Parameters.AddWithValue("@TenCongViec", tenCongViec);
                        cmd.Parameters.AddWithValue("@NgayGiao", ngayGiao);
                        cmd.Parameters.AddWithValue("@HanHoanThanh", hanHoanThanh);
                        cmd.Parameters.AddWithValue("@TrangThai", trangThai);

                        int ketQua = cmd.ExecuteNonQuery();
                        if (ketQua > 0)
                        {
                            MessageBox.Show("Thêm công việc thành công!");
                            Reload();
                        }
                        else
                            MessageBox.Show("Thêm công việc thất bại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
            }
        }
        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtIDCongViec.Text) || !int.TryParse(TxtIDCongViec.Text, out int congViecID) || congViecID <= 0)
            {
                MessageBox.Show("Vui lòng chọn công việc cần sửa từ bảng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenCongViec = TxtTenCongViec.Text.Trim();
            if (string.IsNullOrEmpty(tenCongViec))
            {
                MessageBox.Show("Vui lòng nhập Tên công việc.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CbxTenNhanVien.SelectedValue == null ||
                !int.TryParse(CbxTenNhanVien.SelectedValue.ToString(), out int nhanVienID) ||
                nhanVienID <= 0)
            {
                MessageBox.Show("Vui lòng chọn lại Tên nhân viên được phân công.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime ngayGiao = DtpNgayGiao.Value.Date;
            DateTime hanHoanThanh = DtpHanHoanThanh.Value.Date;
            string trangThai = "Chưa hoàn thành";

            if (hanHoanThanh < ngayGiao)
            {
                MessageBox.Show("Hạn hoàn thành không thể nhỏ hơn Ngày giao.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sua = @"UPDATE CongViec SET
            NhanVienID = @NhanVienID,
            TenCongViec = @TenCongViec,
            NgayGiao = @NgayGiao,
            HanHoanThanh = @HanHoanThanh,
            TrangThai = @TrangThai
            WHERE CongViecID = @CongViecID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sua, conn))
                    {
                        cmd.Parameters.AddWithValue("@CongViecID", congViecID);
                        cmd.Parameters.AddWithValue("@NhanVienID", nhanVienID);
                        cmd.Parameters.AddWithValue("@TenCongViec", tenCongViec);
                        cmd.Parameters.AddWithValue("@NgayGiao", ngayGiao);
                        cmd.Parameters.AddWithValue("@HanHoanThanh", hanHoanThanh);
                        cmd.Parameters.AddWithValue("@TrangThai", trangThai);

                        int ketQua = cmd.ExecuteNonQuery();
                        if (ketQua > 0)
                        {
                            MessageBox.Show("Cập nhật công việc thành công!");
                            Reload();
                        }
                        else
                            MessageBox.Show("Cập nhật công việc thất bại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message);
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtIDCongViec.Text) || !int.TryParse(TxtIDCongViec.Text, out int congViecID) || congViecID <= 0)
            {
                MessageBox.Show("Vui lòng chọn công việc cần xóa từ bảng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa công việc ID: " + congViecID + " này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            string xoa = @"DELETE FROM CongViec WHERE CongViecID = @CongViecID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(xoa, conn))
                    {
                        cmd.Parameters.AddWithValue("@CongViecID", congViecID);
                        int ketQua = cmd.ExecuteNonQuery();
                        if (ketQua > 0)
                        {
                            MessageBox.Show("Xóa công việc thành công!");
                            Reload();
                        }
                        else
                        {
                            MessageBox.Show("Xóa công việc thất bại hoặc không tìm thấy!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // -------------------------------------------------------------------
        // ## 🖱️ Xử lý Sự kiện DGV & Làm mới
        // -------------------------------------------------------------------
        private void DgvPhanCong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DgvPhanCong.CurrentRow;

                TxtIDCongViec.Text = row.Cells["CongViecID"].Value.ToString();
                TxtTenCongViec.Text = row.Cells["TenCongViec"].Value.ToString();

                if (row.Cells["NgayGiao"].Value != DBNull.Value)
                    DtpNgayGiao.Value = Convert.ToDateTime(row.Cells["NgayGiao"].Value);
                else
                    DtpNgayGiao.Value = DateTime.Now;

                if (row.Cells["HanHoanThanh"].Value != DBNull.Value)
                    DtpHanHoanThanh.Value = Convert.ToDateTime(row.Cells["HanHoanThanh"].Value);
                else
                    DtpHanHoanThanh.Value = DateTime.Now.AddDays(7);

                CbxTenNhanVien.Text = row.Cells["HoTen"].Value.ToString();
            }
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void Reload()
        {
            Load_CbxChucVu();
            Load_Data();

            TxtIDCongViec.Clear();
            TxtTenCongViec.Clear();
            DtpNgayGiao.Value = DateTime.Now;
            DtpHanHoanThanh.Value = DateTime.Now.AddDays(7);
            if (CbxChucVu.Items.Count > 0)
            {
                CbxChucVu.SelectedIndex = 0;
            }
        }
    }
}