using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyNhanSu.usercontrol
{
    public partial class BangLuong : UserControl
    {
        SqlCommand boLenh;
        SqlDataAdapter docGhi;
        SqlConnection ketNoi;
        DataSet duLieu;

        string chuoiKN = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhanVien;Integrated Security=True;Trust Server Certificate=True";

        private int loggedInUserID = 0;

        public BangLuong()
        {
            InitializeComponent();
        }

        public BangLuong(int nhanVienID) : this()
        {
            this.loggedInUserID = nhanVienID;
        }

        private void Load_Data()
        {
            string sql = @"
                SELECT 
                    l.MaLuongTong, 
                    nv.HoTen, 
                    l.SoNgayCong, 
                    l.TongPhuCap, 
                    l.TongLuong, 
                    l.NgayTinhLuong, 
                    l.NgayLap
                FROM Luong l
                JOIN NhanVien nv 
                    ON nv.NhanVienID = l.NhanVienID";

            if (this.loggedInUserID > 0)
            {
                sql += " WHERE l.NhanVienID = @UserID";
            }

            try
            {
                if (ketNoi.State != ConnectionState.Open)
                {
                    ketNoi.Open();
                }

                docGhi = new SqlDataAdapter(sql, ketNoi);

                if (this.loggedInUserID > 0)
                {
                    docGhi.SelectCommand.Parameters.AddWithValue(
                        "@UserID",
                        this.loggedInUserID
                    );
                }

                duLieu = new DataSet();

                docGhi.Fill(duLieu);

                DgvLuong.DataSource = duLieu.Tables[0];

                if (DgvLuong.Columns.Contains("TongPhuCap"))
                    DgvLuong.Columns["TongPhuCap"].DefaultCellStyle.Format = "N0";

                if (DgvLuong.Columns.Contains("TongLuong"))
                    DgvLuong.Columns["TongLuong"].DefaultCellStyle.Format = "N0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải dữ liệu: " + ex.Message,
                    "Lỗi Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                ketNoi.Close();
            }
        }

        private void LoadLuongTheoThangNam()
        {
            if (this.loggedInUserID > 0)
                return;

            if (DtpNgayLuong == null)
            {
                MessageBox.Show(
                    "Lỗi: Control DtpNgayLuong không được tìm thấy. Vui lòng kiểm tra Designer."
                );
                return;
            }

            try
            {
                int thang = DtpNgayLuong.Value.Month;
                int nam = DtpNgayLuong.Value.Year;

                if (ketNoi.State != ConnectionState.Open)
                {
                    ketNoi.Open();
                }

                string sql = @"
                    SELECT 
                        l.MaLuongTong,
                        nv.HoTen,
                        l.SoNgayCong,
                        l.TongPhuCap,
                        l.TongLuong,
                        l.NgayTinhLuong,
                        l.NgayLap
                    FROM Luong l
                    JOIN NhanVien nv 
                        ON nv.NhanVienID = l.NhanVienID
                    WHERE MONTH(l.NgayTinhLuong) = @Thang
                    AND YEAR(l.NgayTinhLuong) = @Nam";

                boLenh = new SqlCommand(sql, ketNoi);

                boLenh.Parameters.AddWithValue("@Thang", thang);
                boLenh.Parameters.AddWithValue("@Nam", nam);

                docGhi = new SqlDataAdapter(boLenh);

                duLieu = new DataSet();

                docGhi.Fill(duLieu);

                DgvLuong.DataSource = duLieu.Tables[0];

                if (DgvLuong.Columns.Contains("TongPhuCap"))
                    DgvLuong.Columns["TongPhuCap"].DefaultCellStyle.Format = "N0";

                if (DgvLuong.Columns.Contains("TongLuong"))
                    DgvLuong.Columns["TongLuong"].DefaultCellStyle.Format = "N0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải dữ liệu lương theo tháng: " + ex.Message,
                    "Lỗi Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                ketNoi.Close();
            }
        }

        private void ApplyUIAccess()
        {
            if (this.loggedInUserID > 0)
            {
                if (DtpNgayLuong != null)
                    DtpNgayLuong.Visible = false;

                if (BtnTimKiem != null)
                    BtnTimKiem.Visible = false;

                if (BtnLamMoi != null)
                    BtnLamMoi.Visible = false;

                if (TxtTimKiem != null)
                    TxtTimKiem.Visible = false;

                if (CbxPhongBan != null)
                    CbxPhongBan.Visible = false;

                DgvLuong.ReadOnly = true;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            ketNoi = new SqlConnection(chuoiKN);

            Load_CbxPhongBan();

            ApplyUIAccess();

            if (this.loggedInUserID > 0)
            {
                Load_Data();
            }
            else
            {
                LoadLuongTheoThangNam();
            }
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            if (this.loggedInUserID > 0)
                return;

            LoadLuongTheoThangNam();
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            if (this.loggedInUserID > 0)
                return;

            if (DtpNgayLuong != null)
                DtpNgayLuong.Value = DateTime.Now;

            CbxPhongBan.SelectedIndex = -1;
            TxtTimKiem.Clear();

            LoadLuongTheoThangNam();
        }

        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (this.loggedInUserID > 0)
                return;

            string tuKhoa = TxtTimKiem.Text.Trim();

            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                LoadLuongTheoThangNam();
                return;
            }

            string sql = @"
                SELECT 
                    l.MaLuongTong, 
                    nv.HoTen, 
                    l.SoNgayCong, 
                    l.TongPhuCap, 
                    l.TongLuong, 
                    l.NgayTinhLuong, 
                    l.NgayLap
                FROM Luong l
                JOIN NhanVien nv 
                    ON nv.NhanVienID = l.NhanVienID
                WHERE nv.HoTen LIKE @TuKhoa";

            try
            {
                if (ketNoi.State != ConnectionState.Open)
                {
                    ketNoi.Open();
                }

                boLenh = new SqlCommand(sql, ketNoi);

                boLenh.Parameters.AddWithValue(
                    "@TuKhoa",
                    "%" + tuKhoa + "%"
                );

                docGhi = new SqlDataAdapter(boLenh);

                duLieu = new DataSet();

                docGhi.Fill(duLieu);

                DgvLuong.DataSource = duLieu.Tables[0];

                if (DgvLuong.Columns.Contains("TongPhuCap"))
                    DgvLuong.Columns["TongPhuCap"].DefaultCellStyle.Format = "N0";

                if (DgvLuong.Columns.Contains("TongLuong"))
                    DgvLuong.Columns["TongLuong"].DefaultCellStyle.Format = "N0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tìm kiếm theo tên: " + ex.Message,
                    "Lỗi Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                ketNoi.Close();
            }
        }

        private void Load_CbxPhongBan()
        {
            string sql = "SELECT PhongBanID, TenPhongBan FROM PhongBan";

            try
            {
                if (ketNoi.State != ConnectionState.Open)
                {
                    ketNoi.Open();
                }

                docGhi = new SqlDataAdapter(sql, ketNoi);

                duLieu = new DataSet();

                docGhi.Fill(duLieu);

                CbxPhongBan.DataSource = duLieu.Tables[0];
                CbxPhongBan.DisplayMember = "TenPhongBan";
                CbxPhongBan.ValueMember = "PhongBanID";
                CbxPhongBan.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi tải phòng ban: " + ex.Message,
                    "Lỗi Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                ketNoi.Close();
            }
        }

        private void CbxPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loggedInUserID > 0)
                return;

            if (CbxPhongBan.SelectedValue == null)
                return;

            if (CbxPhongBan.SelectedValue is DataRowView)
                return;

            if (!int.TryParse(
                CbxPhongBan.SelectedValue.ToString(),
                out int phongBanID))
            {
                return;
            }

            try
            {
                if (ketNoi.State != ConnectionState.Open)
                {
                    ketNoi.Open();
                }

                string sql = @"
                    SELECT 
                        l.MaLuongTong,
                        nv.HoTen,
                        l.SoNgayCong,
                        l.TongPhuCap,
                        l.TongLuong,
                        l.NgayTinhLuong,
                        l.NgayLap
                    FROM Luong l
                    INNER JOIN NhanVien nv 
                        ON nv.NhanVienID = l.NhanVienID
                    INNER JOIN PhongBan pb 
                        ON pb.PhongBanID = nv.PhongBanID
                    WHERE pb.PhongBanID = @PhongBanID";

                boLenh = new SqlCommand(sql, ketNoi);

                boLenh.Parameters.AddWithValue(
                    "@PhongBanID",
                    phongBanID
                );

                docGhi = new SqlDataAdapter(boLenh);

                duLieu = new DataSet();

                docGhi.Fill(duLieu);

                DgvLuong.DataSource = duLieu.Tables[0];

                if (DgvLuong.Columns.Contains("TongPhuCap"))
                    DgvLuong.Columns["TongPhuCap"].DefaultCellStyle.Format = "N0";

                if (DgvLuong.Columns.Contains("TongLuong"))
                    DgvLuong.Columns["TongLuong"].DefaultCellStyle.Format = "N0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi lọc lương theo phòng ban: " + ex.Message,
                    "Lỗi Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                ketNoi.Close();
            }
        }
    }
}