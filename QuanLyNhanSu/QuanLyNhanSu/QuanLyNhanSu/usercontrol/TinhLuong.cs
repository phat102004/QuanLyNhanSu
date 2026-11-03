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

        string chuoiKN = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhanVien;Integrated Security=True;Trust Server Certificate=True";

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

        // ============================================================
        // TÍNH PHỤ CẤP
        // ============================================================
        private void BtnTinhPhuCap_Click(object sender, EventArgs e)
        {
            FormPhuCap f = new FormPhuCap();

            if (f.ShowDialog() == DialogResult.OK)
            {
                TxtPhuCap.Text = f.TongPhuCap.ToString("N0");
            }
        }

        // ============================================================
        // LOAD COMBOBOX CHỨC VỤ
        // ============================================================
        private void Load_CbxChucVu()
        {
            string sql = @"
                SELECT ChucVuID, TenChucVu 
                FROM ChucVu";

            try
            {
                if (ketNoi.State != ConnectionState.Open)
                {
                    ketNoi.Open();
                }

                docGhi = new SqlDataAdapter(sql, ketNoi);

                duLieu = new DataSet();
                docGhi.Fill(duLieu);

                CbxChucVu.SelectedIndexChanged -= CbxChucVu_SelectedIndexChanged;

                CbxChucVu.DataSource = duLieu.Tables[0];
                CbxChucVu.DisplayMember = "TenChucVu";
                CbxChucVu.ValueMember = "ChucVuID";

                CbxChucVu.SelectedIndexChanged += CbxChucVu_SelectedIndexChanged;

                ketNoi.Close();
            }
            catch (Exception ex)
            {
                if (ketNoi.State == ConnectionState.Open)
                {
                    ketNoi.Close();
                }

                MessageBox.Show(
                    "Lỗi khi tải chức vụ: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ============================================================
        // LOAD DANH SÁCH TÍNH LƯƠNG
        // ============================================================
        private void Load_DgvLuong()
        {
            try
            {
                if (ketNoi.State != ConnectionState.Open)
                {
                    ketNoi.Open();
                }

                string sql = @"
                    SELECT 
                        TL.MaLuong,
                        NV.HoTen,
                        TL.SoNgayCong,
                        TL.TongPhuCap,
                        TL.TongLuong,
                        TL.NgayTinhLuong,
                        NV.NhanVienID
                    FROM TinhLuong TL
                    INNER JOIN NhanVien NV 
                        ON TL.NhanVienID = NV.NhanVienID";

                docGhi = new SqlDataAdapter(sql, ketNoi);

                duLieu = new DataSet();
                docGhi.Fill(duLieu);

                DgvTinhLuong.DataSource = duLieu.Tables[0];

                DgvTinhLuong.Columns["NhanVienID"].Visible = false;
                DgvTinhLuong.Columns["TongPhuCap"].DefaultCellStyle.Format = "N0";
                DgvTinhLuong.Columns["TongLuong"].DefaultCellStyle.Format = "N0";

                ketNoi.Close();
            }
            catch (Exception ex)
            {
                if (ketNoi.State == ConnectionState.Open)
                {
                    ketNoi.Close();
                }

                MessageBox.Show(
                    "Lỗi khi tải dữ liệu lương: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ============================================================
        // TÍNH LƯƠNG
        // ============================================================
        private void BtnTinhLuong_Click(object sender, EventArgs e)
        {
            try
            {
                int nhanVienID =
                    int.Parse(CbxTenNhanVien.SelectedValue.ToString());

                decimal tongPhuCap =
                    decimal.Parse(TxtPhuCap.Text);

                decimal luongCoBan =
                    decimal.Parse(TxtLuongCoBan.Text);

                int soNgayCong =
                    string.IsNullOrEmpty(TxtSoNgayCong.Text)
                    ? 26
                    : int.Parse(TxtSoNgayCong.Text);

                decimal tongLuong =
                    (luongCoBan * soNgayCong / 26) + tongPhuCap;

                string maLuong =
                    "ML" + DateTime.Now.ToString("yyMMddHHmmss");

                string query = @"
                    INSERT INTO TinhLuong
                    (
                        MaLuong,
                        NhanVienID,
                        SoNgayCong,
                        TongPhuCap,
                        TongLuong,
                        NgayTinhLuong
                    )
                    VALUES
                    (
                        @MaLuong,
                        @NhanVienID,
                        @SoNgayCong,
                        @TongPhuCap,
                        @TongLuong,
                        GETDATE()
                    )";

                if (ketNoi.State != ConnectionState.Open)
                {
                    ketNoi.Open();
                }

                boLenh = new SqlCommand(query, ketNoi);

                boLenh.Parameters.AddWithValue(
                    "@MaLuong",
                    maLuong
                );

                boLenh.Parameters.AddWithValue(
                    "@NhanVienID",
                    nhanVienID
                );

                boLenh.Parameters.AddWithValue(
                    "@SoNgayCong",
                    soNgayCong
                );

                boLenh.Parameters.AddWithValue(
                    "@TongPhuCap",
                    tongPhuCap
                );

                boLenh.Parameters.AddWithValue(
                    "@TongLuong",
                    tongLuong
                );

                boLenh.ExecuteNonQuery();

                ketNoi.Close();

                Load_DgvLuong();

                MessageBox.Show(
                    "Đã tính và lưu lương thành công!",
                    "Thông báo"
                );
            }
            catch (Exception ex)
            {
                if (ketNoi.State == ConnectionState.Open)
                {
                    ketNoi.Close();
                }

                MessageBox.Show(
                    "Lỗi: " + ex.Message,
                    "Lỗi"
                );
            }
        }

        // ============================================================
        // LOAD USERCONTROL
        // ============================================================
        private void TinhLuong_Load(object sender, EventArgs e)
        {
            ketNoi = new SqlConnection(chuoiKN);

            Load_CbxChucVu();
            Load_DgvLuong();

            CbxChucVu.SelectedIndex = -1;

            CbxTenNhanVien.DataSource = null;
            CbxTenNhanVien.Items.Clear();
            CbxTenNhanVien.Text = "-- Chọn nhân viên --";
        }

        // ============================================================
        // CHỌN CHỨC VỤ
        // ============================================================
        private void CbxChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CbxChucVu.SelectedValue == null ||
                    CbxChucVu.SelectedValue is DataRowView)
                {
                    return;
                }

                if (!int.TryParse(
                    CbxChucVu.SelectedValue.ToString(),
                    out int chucVuID))
                {
                    return;
                }

                // ----------------------------------------------------
                // LOAD NHÂN VIÊN THEO CHỨC VỤ
                // ----------------------------------------------------
                string sqlNhanVien = @"
            SELECT NhanVienID, HoTen 
            FROM NhanVien 
            WHERE ChucVuID = @ChucVuID";

                if (ketNoi.State != ConnectionState.Open)
                {
                    ketNoi.Open();
                }

                boLenh = new SqlCommand(
                    sqlNhanVien,
                    ketNoi
                );

                boLenh.Parameters.AddWithValue(
                    "@ChucVuID",
                    chucVuID
                );

                docGhi = new SqlDataAdapter(boLenh);

                duLieu = new DataSet();
                docGhi.Fill(duLieu);

                // ----------------------------------------------------
                // LOAD LƯƠNG THEO CHỨC VỤ
                // ----------------------------------------------------
                string sqlLuong = @"
            SELECT Luong 
            FROM ChucVu 
            WHERE ChucVuID = @ChucVuID";

                boLenh = new SqlCommand(
                    sqlLuong,
                    ketNoi
                );

                boLenh.Parameters.AddWithValue(
                    "@ChucVuID",
                    chucVuID
                );

                object luong = boLenh.ExecuteScalar();

                if (luong != null && luong != DBNull.Value)
                {
                    TxtLuongCoBan.Text =
                        Convert.ToDecimal(luong).ToString("N0");
                }
                else
                {
                    TxtLuongCoBan.Text = "0";
                }

                ketNoi.Close();

                // ----------------------------------------------------
                // TẠM NGẮT EVENT KHI GÁN DATASOURCE
                // ----------------------------------------------------
                CbxTenNhanVien.SelectedIndexChanged -=
                    CbxTenNhanVien_SelectedIndexChanged;

                CbxTenNhanVien.DataSource = duLieu.Tables[0];
                CbxTenNhanVien.DisplayMember = "HoTen";
                CbxTenNhanVien.ValueMember = "NhanVienID";

                CbxTenNhanVien.SelectedIndexChanged +=
                    CbxTenNhanVien_SelectedIndexChanged;

                // ----------------------------------------------------
                // TỰ ĐỘNG LOAD THÔNG TIN NHÂN VIÊN ĐẦU TIÊN
                // ----------------------------------------------------
                if (CbxTenNhanVien.SelectedValue != null &&
                    int.TryParse(
                        CbxTenNhanVien.SelectedValue.ToString(),
                        out int nhanVienID))
                {
                    LoadSoNgayCong(nhanVienID);
                }
            }
            catch (Exception ex)
            {
                if (ketNoi.State == ConnectionState.Open)
                {
                    ketNoi.Close();
                }

                MessageBox.Show(
                    "Lỗi khi tải nhân viên hoặc lương theo chức vụ: "
                    + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ============================================================
        // CLICK DÒNG TRONG DATAGRIDVIEW
        // ============================================================
        private void DgvTinhLuong_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row =
                DgvTinhLuong.Rows[e.RowIndex];

            TxtMaLuong.Text =
                row.Cells["MaLuong"].Value.ToString();

            CbxTenNhanVien.Text =
                row.Cells["HoTen"].Value.ToString();

            TxtSoNgayCong.Text =
                row.Cells["SoNgayCong"].Value.ToString();

            TxtPhuCap.Text =
                Convert.ToDecimal(
                    row.Cells["TongPhuCap"].Value
                ).ToString("N0");

            TxtTongLuong.Text =
                Convert.ToDecimal(
                    row.Cells["TongLuong"].Value
                ).ToString("N0");

            if (row.Cells["NgayTinhLuong"].Value != DBNull.Value)
            {
                DtpNgayTinhLuong.Value =
                    Convert.ToDateTime(
                        row.Cells["NgayTinhLuong"].Value
                    );
            }

            if (row.Cells["NhanVienID"].Value != null)
            {
                int nhanVienID =
                    Convert.ToInt32(
                        row.Cells["NhanVienID"].Value
                    );

                LayLuongCoBanTheoNhanVien(nhanVienID);
            }
        }

        // ============================================================
        // LẤY LƯƠNG CƠ BẢN THEO NHÂN VIÊN
        // ============================================================
        private void LayLuongCoBanTheoNhanVien(int nhanVienID)
        {
            try
            {
                string sql = @"
                    SELECT c.Luong
                    FROM NhanVien n
                    JOIN ChucVu c 
                        ON n.ChucVuID = c.ChucVuID
                    WHERE n.NhanVienID = @NhanVienID";

                if (ketNoi.State != ConnectionState.Open)
                {
                    ketNoi.Open();
                }

                boLenh = new SqlCommand(
                    sql,
                    ketNoi
                );

                boLenh.Parameters.AddWithValue(
                    "@NhanVienID",
                    nhanVienID
                );

                object result =
                    boLenh.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    TxtLuongCoBan.Text =
                        Convert.ToDecimal(result).ToString("N0");
                }
                else
                {
                    TxtLuongCoBan.Text = "0";
                }

                ketNoi.Close();
            }
            catch (Exception ex)
            {
                if (ketNoi.State == ConnectionState.Open)
                {
                    ketNoi.Close();
                }

                MessageBox.Show(
                    "Lỗi khi lấy lương cơ bản: " + ex.Message
                );
            }
        }

        // ============================================================
        // CHỌN NHÂN VIÊN
        // ============================================================
        private void CbxTenNhanVien_SelectedIndexChanged(
    object sender,
    EventArgs e)
        {
            try
            {
                if (CbxTenNhanVien.SelectedValue == null ||
                    CbxTenNhanVien.SelectedValue is DataRowView ||
                    !int.TryParse(
                        CbxTenNhanVien.SelectedValue.ToString(),
                        out int nhanVienID))
                {
                    return;
                }

                // ----------------------------------------------------
                // LOAD LƯƠNG CƠ BẢN THEO NHÂN VIÊN
                // ----------------------------------------------------
                string sql = @"
            SELECT c.Luong 
            FROM NhanVien n
            INNER JOIN ChucVu c 
                ON n.ChucVuID = c.ChucVuID
            WHERE n.NhanVienID = @NhanVienID";

                if (ketNoi.State != ConnectionState.Open)
                {
                    ketNoi.Open();
                }

                boLenh = new SqlCommand(
                    sql,
                    ketNoi
                );

                boLenh.Parameters.AddWithValue(
                    "@NhanVienID",
                    nhanVienID
                );

                object result =
                    boLenh.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    decimal luongCoBan =
                        Convert.ToDecimal(result);

                    TxtLuongCoBan.Text =
                        luongCoBan.ToString("N0");
                }
                else
                {
                    TxtLuongCoBan.Text = "0";
                }

                ketNoi.Close();

                // ----------------------------------------------------
                // LOAD SỐ NGÀY CÔNG
                // ----------------------------------------------------
                LoadSoNgayCong(nhanVienID);
            }
            catch (Exception ex)
            {
                if (ketNoi.State == ConnectionState.Open)
                {
                    ketNoi.Close();
                }

                MessageBox.Show(
                    "Lỗi khi lấy lương hoặc số ngày công: "
                    + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ============================================================
        // LOAD SỐ NGÀY CÔNG
        // ============================================================
        private void LoadSoNgayCong(int nhanVienID)
        {
            try
            {
                string sql = @"
                    SELECT COUNT(*)
                    FROM ChamCong
                    WHERE NhanVienID = @NhanVienID
                    AND MONTH(NgayChamCong) = @Thang
                    AND YEAR(NgayChamCong) = @Nam";

                if (ketNoi.State != ConnectionState.Open)
                {
                    ketNoi.Open();
                }

                boLenh = new SqlCommand(
                    sql,
                    ketNoi
                );

                boLenh.Parameters.AddWithValue(
                    "@NhanVienID",
                    nhanVienID
                );

                boLenh.Parameters.AddWithValue(
                    "@Thang",
                    DtpNgayTinhLuong.Value.Month
                );

                boLenh.Parameters.AddWithValue(
                    "@Nam",
                    DtpNgayTinhLuong.Value.Year
                );

                int soNgayCong =
                    Convert.ToInt32(
                        boLenh.ExecuteScalar()
                    );

                TxtSoNgayCong.Text =
                    soNgayCong.ToString();

                ketNoi.Close();
            }
            catch (Exception ex)
            {
                if (ketNoi.State == ConnectionState.Open)
                {
                    ketNoi.Close();
                }

                MessageBox.Show(
                    "Lỗi khi lấy số ngày công: "
                    + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ============================================================
        // SỬA LƯƠNG
        // ============================================================
        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtMaLuong.Text))
            {
                MessageBox.Show(
                    "Vui lòng chọn bản ghi cần sửa!",
                    "Thông báo"
                );

                return;
            }

            int nhanVienID;

            if (CbxTenNhanVien.SelectedValue == null ||
                CbxTenNhanVien.SelectedValue is DataRowView ||
                !int.TryParse(
                    CbxTenNhanVien.SelectedValue.ToString(),
                    out nhanVienID))
            {
                if (DgvTinhLuong.CurrentRow != null &&
                    DgvTinhLuong.CurrentRow.Cells["NhanVienID"].Value != null)
                {
                    nhanVienID =
                        Convert.ToInt32(
                            DgvTinhLuong.CurrentRow
                            .Cells["NhanVienID"].Value
                        );
                }
                else
                {
                    MessageBox.Show(
                        "Vui lòng chọn lại nhân viên!",
                        "Thông báo"
                    );

                    return;
                }
            }

            try
            {
                string sql = @"
                    UPDATE TinhLuong 
                    SET 
                        NhanVienID = @NhanVienID,
                        SoNgayCong = @SoNgayCong,
                        TongPhuCap = @TongPhuCap,
                        TongLuong = @TongLuong,
                        NgayTinhLuong = @NgayTinhLuong
                    WHERE MaLuong = @MaLuong";

                if (ketNoi.State != ConnectionState.Open)
                {
                    ketNoi.Open();
                }

                boLenh = new SqlCommand(
                    sql,
                    ketNoi
                );

                int soNgayCong =
                    string.IsNullOrWhiteSpace(TxtSoNgayCong.Text)
                    ? 0
                    : Convert.ToInt32(TxtSoNgayCong.Text);

                decimal tongPhuCap =
                    string.IsNullOrWhiteSpace(TxtPhuCap.Text)
                    ? 0
                    : Convert.ToDecimal(TxtPhuCap.Text);

                decimal luongCoBan =
                    string.IsNullOrWhiteSpace(TxtLuongCoBan.Text)
                    ? 0
                    : Convert.ToDecimal(TxtLuongCoBan.Text);

                decimal tongLuong =
                    (luongCoBan + tongPhuCap)
                    * soNgayCong / 26;

                boLenh.Parameters.AddWithValue(
                    "@NhanVienID",
                    nhanVienID
                );

                boLenh.Parameters.AddWithValue(
                    "@SoNgayCong",
                    soNgayCong
                );

                boLenh.Parameters.AddWithValue(
                    "@TongPhuCap",
                    tongPhuCap
                );

                boLenh.Parameters.AddWithValue(
                    "@TongLuong",
                    tongLuong
                );

                boLenh.Parameters.AddWithValue(
                    "@NgayTinhLuong",
                    DtpNgayTinhLuong.Value
                );

                boLenh.Parameters.AddWithValue(
                    "@MaLuong",
                    TxtMaLuong.Text.Trim()
                );

                int rows =
                    boLenh.ExecuteNonQuery();

                TxtTongLuong.Text =
                    string.Format(
                        "{0:N0} VNĐ",
                        tongLuong
                    );

                ketNoi.Close();

                if (rows > 0)
                {
                    MessageBox.Show(
                        "Cập nhật thành công!",
                        "Thông báo"
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Không tìm thấy bản ghi có mã lương này!",
                        "Thông báo"
                    );
                }

                Load_DgvLuong();
            }
            catch (Exception ex)
            {
                if (ketNoi.State == ConnectionState.Open)
                {
                    ketNoi.Close();
                }

                MessageBox.Show(
                    "Lỗi khi cập nhật: " + ex.Message,
                    "Lỗi"
                );
            }
        }

        // ============================================================
        // LÀM MỚI
        // ============================================================
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

        // ============================================================
        // XÓA LƯƠNG
        // ============================================================
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtMaLuong.Text))
            {
                MessageBox.Show(
                    "Vui lòng chọn bản ghi cần xóa!",
                    "Thông báo"
                );

                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa bản ghi này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                string sql = @"
                    DELETE FROM TinhLuong 
                    WHERE MaLuong = @MaLuong";

                if (ketNoi.State != ConnectionState.Open)
                {
                    ketNoi.Open();
                }

                boLenh = new SqlCommand(
                    sql,
                    ketNoi
                );

                boLenh.Parameters.AddWithValue(
                    "@MaLuong",
                    TxtMaLuong.Text.Trim()
                );

                int rows =
                    boLenh.ExecuteNonQuery();

                ketNoi.Close();

                if (rows > 0)
                {
                    MessageBox.Show(
                        "Xóa thành công!",
                        "Thông báo"
                    );

                    Load_DgvLuong();
                    LamMoiForm();
                }
                else
                {
                    MessageBox.Show(
                        "Không tìm thấy bản ghi để xóa!",
                        "Thông báo"
                    );
                }
            }
            catch (Exception ex)
            {
                if (ketNoi.State == ConnectionState.Open)
                {
                    ketNoi.Close();
                }

                MessageBox.Show(
                    "Lỗi khi xóa: " + ex.Message,
                    "Lỗi"
                );
            }
        }

        // ============================================================
        // LÀM MỚI FORM
        // ============================================================
        private void LamMoiForm()
        {
            TxtMaLuong.Clear();

            CbxTenNhanVien.SelectedIndex = -1;

            TxtSoNgayCong.Clear();
            TxtPhuCap.Clear();
            TxtTongLuong.Clear();
            TxtLuongCoBan.Clear();

            DtpNgayTinhLuong.Value =
                DateTime.Now;
        }

        // ============================================================
        // LƯU LƯƠNG SANG BẢNG LUONG
        // ============================================================
        private void BtnLuuLuong_Click(object sender, EventArgs e)
        {
            string luong = @"
                DECLARE @Prefix NVARCHAR(20);
                DECLARE @SoCuoi INT;

                -- Tạo tiền tố theo ngày hiện tại
                SET @Prefix = 'L' 
                    + CONVERT(NVARCHAR(8), GETDATE(), 112) + '-';

                -- Lấy số thứ tự lớn nhất đã tồn tại trong ngày
                SELECT @SoCuoi = ISNULL(
                    MAX(CAST(RIGHT(MaLuongTong, 3) AS INT)), 
                    0
                )
                FROM Luong
                WHERE MaLuongTong LIKE @Prefix + '%';

                -- Thêm dữ liệu từ TinhLuong sang Luong
                INSERT INTO Luong 
                (
                    MaLuongTong, 
                    NhanVienID, 
                    SoNgayCong, 
                    TongPhuCap, 
                    TongLuong, 
                    NgayTinhLuong
                )
                SELECT 
                    @Prefix + RIGHT(
                        '000' + CAST(
                            @SoCuoi 
                            + ROW_NUMBER() OVER (ORDER BY NhanVienID)
                            AS NVARCHAR(3)
                        ), 
                        3
                    ),
                    NhanVienID,
                    SoNgayCong,
                    TongPhuCap,
                    TongLuong,
                    NgayTinhLuong
                FROM TinhLuong;
            ";

            DialogResult res = MessageBox.Show(
                "Bạn có chắc chắn muốn thêm!",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            try
            {
                if (res == DialogResult.Yes)
                {
                    if (ketNoi.State != ConnectionState.Open)
                    {
                        ketNoi.Open();
                    }

                    boLenh = new SqlCommand(
                        luong,
                        ketNoi
                    );

                    int kq =
                        boLenh.ExecuteNonQuery();

                    if (kq == 0)
                    {
                        MessageBox.Show(
                            "Không có dữ liệu nào để lưu!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        ketNoi.Close();
                        return;
                    }

                    // Sau khi lưu thành công
                    // thì xóa dữ liệu tạm trong TinhLuong
                    string sqldel =
                        "DELETE FROM TinhLuong";

                    boLenh = new SqlCommand(
                        sqldel,
                        ketNoi
                    );

                    boLenh.ExecuteNonQuery();

                    ketNoi.Close();

                    Load_DgvLuong();

                    MessageBox.Show(
                        "Lưu lương thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
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