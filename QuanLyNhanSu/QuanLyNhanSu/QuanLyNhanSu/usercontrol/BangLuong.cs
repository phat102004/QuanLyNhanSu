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
    public partial class BangLuong : UserControl
    {
        private readonly string chuoiKN = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhanVien;Integrated Security=True;Trust Server Certificate=True";
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
            using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
            {
                string sql = @"SELECT l.MaLuongTong, nv.HoTen, l.SoNgayCong, l.TongPhuCap, l.TongLuong, l.NgayTinhLuong, l.NgayLap
                                 FROM Luong l
                                 JOIN NhanVien nv on nv.NhanVienID = l.NhanVienID";
                if (this.loggedInUserID > 0)
                {
                    sql += " WHERE l.NhanVienID = @UserID";
                }
                try
                {
                    using (SqlDataAdapter docGhi = new SqlDataAdapter(sql, ketNoi))
                    {
                        if (this.loggedInUserID > 0)
                        {
                            docGhi.SelectCommand.Parameters.AddWithValue("@UserID", this.loggedInUserID);
                        }

                        DataTable dt = new DataTable();
                        docGhi.Fill(dt);

                        DgvLuong.DataSource = dt;
                    }
                    if (DgvLuong.Columns.Contains("TongPhuCap"))
                        DgvLuong.Columns["TongPhuCap"].DefaultCellStyle.Format = "N0";
                    if (DgvLuong.Columns.Contains("TongLuong"))
                        DgvLuong.Columns["TongLuong"].DefaultCellStyle.Format = "N0";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadLuongTheoThangNam()
        {
            if (this.loggedInUserID > 0) return;

            if (DtpNgayLuong == null)
            {
                MessageBox.Show("Lỗi: Control DtpNgayLuong không được tìm thấy. Vui lòng kiểm tra Designer.");
                return;
            }
            try
            {
                int thang = DtpNgayLuong.Value.Month;
                int nam = DtpNgayLuong.Value.Year;
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
                    JOIN NhanVien nv ON nv.NhanVienID = l.NhanVienID
                    WHERE MONTH(l.NgayTinhLuong) = @Thang
                    AND YEAR(l.NgayTinhLuong) = @Nam";

                using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                using (SqlDataAdapter da = new SqlDataAdapter(sql, ketNoi))
                {
                    da.SelectCommand.Parameters.AddWithValue("@Thang", thang);
                    da.SelectCommand.Parameters.AddWithValue("@Nam", nam);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DgvLuong.DataSource = dt;
                }

                if (DgvLuong.Columns.Contains("TongPhuCap"))
                    DgvLuong.Columns["TongPhuCap"].DefaultCellStyle.Format = "N0";
                if (DgvLuong.Columns.Contains("TongLuong"))
                    DgvLuong.Columns["TongLuong"].DefaultCellStyle.Format = "N0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu lương theo tháng: " + ex.Message, "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ApplyUIAccess()
        {
            if (this.loggedInUserID > 0)
            {
                if (DtpNgayLuong != null) DtpNgayLuong.Visible = false;
                if (BtnTimKiem != null) BtnTimKiem.Visible = false;
                if (BtnLamMoi != null) BtnLamMoi.Visible = false;
                if (TxtTimKiem != null) TxtTimKiem.Visible = false;
                DgvLuong.ReadOnly = true;
            }
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
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
            if (this.loggedInUserID > 0) return;
            LoadLuongTheoThangNam();
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            if (this.loggedInUserID > 0) return;

            if (DtpNgayLuong != null)
                DtpNgayLuong.Value = DateTime.Now;
            LoadLuongTheoThangNam();
        }

        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (this.loggedInUserID > 0) return;

            string tuKhoa = TxtTimKiem.Text.Trim();

            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                LoadLuongTheoThangNam();
                return;
            }

            string sql = @"SELECT l.MaLuongTong, nv.HoTen, l.SoNgayCong, l.TongPhuCap,
                                 l.TongLuong, l.NgayTinhLuong, l.NgayLap
                            FROM Luong l
                            JOIN NhanVien nv ON nv.NhanVienID = l.NhanVienID
                            WHERE nv.HoTen LIKE @TuKhoa";

            try
            {
                using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                {
                    ketNoi.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, ketNoi))
                    {
                        cmd.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%");
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            DgvLuong.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm theo tên: " + ex.Message, "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}