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
    public partial class TinhLuong : UserControl
    {
        SqlCommand boLenh;
        SqlDataAdapter docGhi;
        SqlConnection ketNoi;
        DataSet duLieu;

        private int _nhanVienID;
        private DataTable dtLuong;
        public TinhLuong()
        {
            InitializeComponent();
        }

        public TinhLuong(int nhanVienID)
        {
            InitializeComponent();
            _nhanVienID = nhanVienID;
        }
        private void BtnTinhPhuCap_Click(object sender, EventArgs e)
        {
            FormPhuCap f = new FormPhuCap();
            if (f.ShowDialog() == DialogResult.OK)
            {
                TxtPhuCap.Text = f.TongPhuCap.ToString("N0");
            }
        }

        private void Load_CbxChucVu()
        {
            string sql = "SELECT ChucVuID, TenChucVu FROM ChucVu";
            docGhi = new SqlDataAdapter(sql, ketNoi);
            duLieu = new DataSet();
            docGhi.Fill(duLieu);
            CbxChucVu.SelectedIndexChanged -= CbxChucVu_SelectedIndexChanged;
            CbxChucVu.DataSource = duLieu.Tables[0];
            CbxChucVu.DisplayMember = "TenChucVu";
            CbxChucVu.ValueMember = "ChucVuID";
            CbxChucVu.SelectedIndexChanged += CbxChucVu_SelectedIndexChanged;
        }

        private void Load_DgvLuong()
        {
            try
            {
                ketNoi.Open();
                string sql = @"SELECT TL.MaLuong, NV.HoTen, TL.SoNgayCong, TL.TongPhuCap,
                              TL.TongLuong, TL.NgayTinhLuong, NV.NhanVienID
                       FROM TinhLuong TL
                       INNER JOIN NhanVien NV ON TL.NhanVienID = NV.NhanVienID";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, ketNoi);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                DgvTinhLuong.DataSource = dt;
                DgvTinhLuong.Columns["NhanVienID"].Visible = false;
                DgvTinhLuong.Columns["TongPhuCap"].DefaultCellStyle.Format = "N0";
                DgvTinhLuong.Columns["TongLuong"].DefaultCellStyle.Format = "N0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu lương: " + ex.Message);
            }
            finally
            {
                ketNoi.Close();
            }
        }

        private void BtnTinhLuong_Click(object sender, EventArgs e)
        {
            try
            {
                int nhanVienID = int.Parse(CbxTenNhanVien.SelectedValue.ToString());
                decimal tongPhuCap = decimal.Parse(TxtPhuCap.Text);
                decimal luongCoBan = decimal.Parse(TxtLuongCoBan.Text);
                int soNgayCong = string.IsNullOrEmpty(TxtSoNgayCong.Text) ? 26 : int.Parse(TxtSoNgayCong.Text);
                decimal tongLuong = (luongCoBan + tongPhuCap) * soNgayCong / 26;
                string maLuong = "ML" + DateTime.Now.ToString("yyMMddHHmmss");
                using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhanVien;Integrated Security=True;Trust Server Certificate=True"))
                {
                    conn.Open();
                    string query = @"INSERT INTO TinhLuong (MaLuong, NhanVienID, SoNgayCong, TongPhuCap, TongLuong, NgayTinhLuong)
                             VALUES (@MaLuong, @NhanVienID, @SoNgayCong, @TongPhuCap, @TongLuong, GETDATE())";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaLuong", maLuong);
                        cmd.Parameters.AddWithValue("@NhanVienID", nhanVienID);
                        cmd.Parameters.AddWithValue("@SoNgayCong", soNgayCong);
                        cmd.Parameters.AddWithValue("@TongPhuCap", tongPhuCap);
                        cmd.Parameters.AddWithValue("@TongLuong", tongLuong);
                        cmd.ExecuteNonQuery();
                        Load_DgvLuong();
                    }
                }

                MessageBox.Show("Đã tính và lưu lương thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void TinhLuong_Load(object sender, EventArgs e)
        {
            string chuoiKN = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhanVien;Integrated Security=True;Trust Server Certificate=True";
            ketNoi = new SqlConnection(chuoiKN);
            Load_CbxChucVu();
            Load_DgvLuong();

            CbxChucVu.SelectedIndex = -1;
            CbxTenNhanVien.DataSource = null;
            CbxTenNhanVien.Items.Clear();
            CbxTenNhanVien.Text = "-- Chọn nhân viên --";
        }

        private void CbxChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CbxChucVu.SelectedValue == null || CbxChucVu.SelectedValue is DataRowView)
                    return;

                if (!int.TryParse(CbxChucVu.SelectedValue.ToString(), out int chucVuID))
                    return;

                using (SqlConnection conn = new SqlConnection(ketNoi.ConnectionString))
                {
                    conn.Open();

                    string sqlNhanVien = "SELECT NhanVienID, HoTen FROM NhanVien WHERE ChucVuID = @ChucVuID";
                    SqlCommand cmdNV = new SqlCommand(sqlNhanVien, conn);
                    cmdNV.Parameters.AddWithValue("@ChucVuID", chucVuID);
                    SqlDataAdapter da = new SqlDataAdapter(cmdNV);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    CbxTenNhanVien.DataSource = dt;
                    CbxTenNhanVien.DisplayMember = "HoTen";
                    CbxTenNhanVien.ValueMember = "NhanVienID";

                    string sqlLuong = "SELECT Luong FROM ChucVu WHERE ChucVuID = @ChucVuID";
                    SqlCommand cmdLuong = new SqlCommand(sqlLuong, conn);
                    cmdLuong.Parameters.AddWithValue("@ChucVuID", chucVuID);
                    object luong = cmdLuong.ExecuteScalar();

                    if (luong != null && luong != DBNull.Value)
                        TxtLuongCoBan.Text = string.Format("{0:N0}", luong);
                    else
                        TxtLuongCoBan.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải nhân viên hoặc lương theo chức vụ: " + ex.Message);
            }
        }

        private void DgvTinhLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DgvTinhLuong.Rows[e.RowIndex];

            TxtMaLuong.Text = row.Cells["MaLuong"].Value.ToString();
            CbxTenNhanVien.Text = row.Cells["HoTen"].Value.ToString();
            TxtSoNgayCong.Text = row.Cells["SoNgayCong"].Value.ToString();
            TxtPhuCap.Text = Convert.ToDecimal(row.Cells["TongPhuCap"].Value).ToString("N0");
            TxtTongLuong.Text = Convert.ToDecimal(row.Cells["TongLuong"].Value).ToString("N0");

            if (row.Cells["NgayTinhLuong"].Value != DBNull.Value)
                DtpNgayTinhLuong.Value = Convert.ToDateTime(row.Cells["NgayTinhLuong"].Value);

            if (row.Cells["NhanVienID"].Value != null)
            {
                int nhanVienID = Convert.ToInt32(row.Cells["NhanVienID"].Value);
                LayLuongCoBanTheoNhanVien(nhanVienID);
            }
        }
        private void LayLuongCoBanTheoNhanVien(int nhanVienID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ketNoi.ConnectionString))
                {
                    conn.Open();

                    string sql = @"
                SELECT c.Luong
                FROM NhanVien n
                JOIN ChucVu c ON n.ChucVuID = c.ChucVuID
                WHERE n.NhanVienID = @NhanVienID";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@NhanVienID", nhanVienID);
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                            TxtLuongCoBan.Text = Convert.ToDecimal(result).ToString("N0");
                        else
                            TxtLuongCoBan.Text = "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy lương cơ bản: " + ex.Message);
            }
        }
        private void CbxTenNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CbxTenNhanVien.SelectedValue == null
                    || CbxTenNhanVien.SelectedValue is DataRowView
                    || !int.TryParse(CbxTenNhanVien.SelectedValue.ToString(), out int nhanVienID))
                {
                    return;
                }

                using (SqlConnection conn = new SqlConnection(ketNoi.ConnectionString))
                {
                    conn.Open();

                    string sql = @"
                SELECT c.Luong
                FROM NhanVien n
                INNER JOIN ChucVu c ON n.ChucVuID = c.ChucVuID
                WHERE n.NhanVienID = @NhanVienID";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@NhanVienID", nhanVienID);

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            decimal luongCoBan = Convert.ToDecimal(result);
                            TxtLuongCoBan.Text = luongCoBan.ToString("N0");
                        }
                        else
                        {
                            TxtLuongCoBan.Text = "0";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy lương cơ bản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtMaLuong.Text))
            {
                MessageBox.Show("Vui lòng chọn bản ghi cần sửa!", "Thông báo");
                return;
            }

            int nhanVienID;

            if (CbxTenNhanVien.SelectedValue == null ||
                CbxTenNhanVien.SelectedValue is DataRowView ||
                !int.TryParse(CbxTenNhanVien.SelectedValue.ToString(), out nhanVienID))
            {
                if (DgvTinhLuong.CurrentRow != null && DgvTinhLuong.CurrentRow.Cells["NhanVienID"].Value != null)
                {
                    nhanVienID = Convert.ToInt32(DgvTinhLuong.CurrentRow.Cells["NhanVienID"].Value);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn lại nhân viên!", "Thông báo");
                    return;
                }
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(ketNoi.ConnectionString))
                {
                    conn.Open();

                    string sql = @"
                UPDATE TinhLuong
                SET
                    NhanVienID = @NhanVienID,
                    SoNgayCong = @SoNgayCong,
                    TongPhuCap = @TongPhuCap,
                    TongLuong = @TongLuong,
                    NgayTinhLuong = @NgayTinhLuong
                WHERE MaLuong = @MaLuong";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@NhanVienID", nhanVienID);
                        cmd.Parameters.AddWithValue("@SoNgayCong", string.IsNullOrWhiteSpace(TxtSoNgayCong.Text) ? 0 : Convert.ToInt32(TxtSoNgayCong.Text));
                        cmd.Parameters.AddWithValue("@TongPhuCap", string.IsNullOrWhiteSpace(TxtPhuCap.Text) ? 0 : Convert.ToDecimal(TxtPhuCap.Text));
                        decimal luongCoBan = string.IsNullOrWhiteSpace(TxtLuongCoBan.Text) ? 0 : Convert.ToDecimal(TxtLuongCoBan.Text);
                        int soNgayCong = string.IsNullOrWhiteSpace(TxtSoNgayCong.Text) ? 0 : Convert.ToInt32(TxtSoNgayCong.Text);
                        decimal tongPhuCap = string.IsNullOrWhiteSpace(TxtPhuCap.Text) ? 0 : Convert.ToDecimal(TxtPhuCap.Text);

                        decimal tongLuong = (luongCoBan + tongPhuCap) * soNgayCong / 26;

                        TxtTongLuong.Text = string.Format("{0:N0} VNĐ", tongLuong);

                        cmd.Parameters.AddWithValue("@TongLuong", tongLuong); cmd.Parameters.AddWithValue("@NgayTinhLuong", DtpNgayTinhLuong.Value);
                        cmd.Parameters.AddWithValue("@MaLuong", TxtMaLuong.Text.Trim());

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                            MessageBox.Show("Cập nhật thành công!", "Thông báo");
                        else
                            MessageBox.Show("Không tìm thấy bản ghi có mã lương này!", "Thông báo");
                    }
                }

                Load_DgvLuong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi");
            }
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            TxtMaLuong.Clear();
            CbxTenNhanVien.SelectedIndex = -1;
            TxtSoNgayCong.Clear();
            TxtPhuCap.Clear();
            TxtTongLuong.Clear();
            TxtLuongCoBan.Clear();
            DtpNgayTinhLuong.Value = DateTime.Now;

            CbxTenNhanVien.Focus();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtMaLuong.Text))
            {
                MessageBox.Show("Vui lòng chọn bản ghi cần xóa!", "Thông báo");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa bản ghi này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(ketNoi.ConnectionString))
                {
                    conn.Open();

                    string sql = "DELETE FROM TinhLuong WHERE MaLuong = @MaLuong";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaLuong", TxtMaLuong.Text.Trim());

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Xóa thành công!", "Thông báo");

                            Load_DgvLuong();
                            LamMoiForm();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy bản ghi để xóa!", "Thông báo");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi");
            }
        }
        private void LamMoiForm()
        {
            TxtMaLuong.Clear();
            CbxTenNhanVien.SelectedIndex = -1;
            TxtSoNgayCong.Clear();
            TxtPhuCap.Clear();
            TxtTongLuong.Clear();
            TxtLuongCoBan.Clear();
            DtpNgayTinhLuong.Value = DateTime.Now;
        }

        private void BtnLuuLuong_Click(object sender, EventArgs e)
        {
            string luong = @"
                        INSERT INTO Luong (MaLuongTong, NhanVienID, SoNgayCong, TongPhuCap, TongLuong, NgayTinhLuong)
                        SELECT
                            'L' + CONVERT(NVARCHAR(8), GETDATE(), 112) + '-' +
                            RIGHT('000' + CAST(ROW_NUMBER() OVER (ORDER BY NhanVienID) AS NVARCHAR(3)), 3),
                            NhanVienID,
                            SoNgayCong,
                            TongPhuCap,
                            TongLuong,
                            NgayTinhLuong
                        FROM TinhLuong";
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn thêm!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (res == DialogResult.Yes)
                {
                    if(ketNoi.State != ConnectionState.Open)
                    {
                        ketNoi.Open();
                    }
                    boLenh = new SqlCommand(luong, ketNoi);
                    int kq = boLenh.ExecuteNonQuery();
                    if (kq == 0)
                    {
                        MessageBox.Show("Không có dữ liệu nào để lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    string sqldel = "DELETE FROM TinhLuong";
                    boLenh = new SqlCommand(sqldel, ketNoi);
                    boLenh.ExecuteNonQuery();
                    Load_DgvLuong();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi" + ex.Message);
            }

            finally
            {
                ketNoi.Close();
            }
        }
    }
}
