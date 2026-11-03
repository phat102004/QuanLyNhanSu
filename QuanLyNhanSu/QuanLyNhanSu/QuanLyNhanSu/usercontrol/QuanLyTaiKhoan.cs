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
    public partial class QuanLyTaiKhoan : UserControl
    {
        SqlCommand boLenh;
        SqlConnection ketNoi;
        DataSet duLieu;
        SqlDataAdapter docGhi;

        string chuoiKN = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhanVien;Integrated Security=True;Trust Server Certificate=True";

        public QuanLyTaiKhoan()
        {
            InitializeComponent();

            dgvAccounts.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvAccounts.CellClick +=
                DgvAccounts_CellClick;

            btnThem.Click +=
                BtnThem_Click;

            btnSua.Click +=
                BtnSua_Click;

            btnXoa.Click +=
                BtnXoa_Click;

            btnReset.Click +=
                BtnReset_Click;

            txtPassword.PasswordChar = '●';
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            ketNoi = new SqlConnection(chuoiKN);

            LoadNhanVienComboBox();
            LoadQuyenComboBox();
            LoadTaiKhoanData();
        }

        private void LoadNhanVienComboBox()
        {
            string sql = @"
                SELECT NhanVienID, HoTen
                FROM NhanVien";

            try
            {
                if (ketNoi.State != ConnectionState.Open)
                {
                    ketNoi.Open();
                }

                docGhi = new SqlDataAdapter(
                    sql,
                    ketNoi
                );

                duLieu = new DataSet();

                docGhi.Fill(duLieu);

                cmbNhanVienID.DataSource =
                    duLieu.Tables[0];

                cmbNhanVienID.DisplayMember =
                    "HoTen";

                cmbNhanVienID.ValueMember =
                    "NhanVienID";

                cmbNhanVienID.SelectedIndex = -1;

                ketNoi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi tải danh sách nhân viên: " +
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

        private void LoadQuyenComboBox()
        {
            string sql = @"
                SELECT QuyenID, TenQuyen
                FROM Quyen";

            try
            {
                if (ketNoi.State != ConnectionState.Open)
                {
                    ketNoi.Open();
                }

                docGhi = new SqlDataAdapter(
                    sql,
                    ketNoi
                );

                duLieu = new DataSet();

                docGhi.Fill(duLieu);

                cmbRole.DataSource =
                    duLieu.Tables[0];

                cmbRole.DisplayMember =
                    "TenQuyen";

                cmbRole.ValueMember =
                    "QuyenID";

                cmbRole.SelectedIndex = -1;

                ketNoi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi tải danh sách quyền: " +
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

        private void LoadTaiKhoanData()
        {
            string query = @"
                SELECT 
                    tk.TaiKhoanID,
                    tk.TenDangNhap,
                    '********' AS MatKhauHienThi,
                    nv.HoTen AS TenNhanVien,
                    tk.NhanVienID,
                    tk.QuyenID,
                    q.TenQuyen
                FROM TaiKhoan tk
                JOIN NhanVien nv
                    ON tk.NhanVienID = nv.NhanVienID
                JOIN Quyen q
                    ON tk.QuyenID = q.QuyenID";

            try
            {
                if (ketNoi.State != ConnectionState.Open)
                {
                    ketNoi.Open();
                }

                docGhi = new SqlDataAdapter(
                    query,
                    ketNoi
                );

                duLieu = new DataSet();

                docGhi.Fill(duLieu);

                dgvAccounts.DataSource =
                    duLieu.Tables[0];

                if (dgvAccounts.Columns.Contains(
                    "TaiKhoanID"))
                {
                    dgvAccounts.Columns[
                        "TaiKhoanID"
                    ].Visible = false;
                }

                if (dgvAccounts.Columns.Contains(
                    "NhanVienID"))
                {
                    dgvAccounts.Columns[
                        "NhanVienID"
                    ].Visible = false;
                }

                if (dgvAccounts.Columns.Contains(
                    "QuyenID"))
                {
                    dgvAccounts.Columns[
                        "QuyenID"
                    ].Visible = false;
                }

                if (dgvAccounts.Columns.Contains(
                    "TenNhanVien"))
                {
                    dgvAccounts.Columns[
                        "TenNhanVien"
                    ].HeaderText =
                        "Tên nhân viên";
                }

                if (dgvAccounts.Columns.Contains(
                    "TenDangNhap"))
                {
                    dgvAccounts.Columns[
                        "TenDangNhap"
                    ].HeaderText =
                        "Tên đăng nhập";
                }

                if (dgvAccounts.Columns.Contains(
                    "MatKhauHienThi"))
                {
                    dgvAccounts.Columns[
                        "MatKhauHienThi"
                    ].HeaderText =
                        "Mật khẩu";
                }

                if (dgvAccounts.Columns.Contains(
                    "TenQuyen"))
                {
                    dgvAccounts.Columns[
                        "TenQuyen"
                    ].HeaderText =
                        "Quyền";
                }

                dgvAccounts.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                ketNoi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi tải danh sách tài khoản: " +
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

        private void DgvAccounts_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row =
                dgvAccounts.Rows[e.RowIndex];

            cmbNhanVienID.SelectedValue =
                row.Cells["NhanVienID"].Value;

            cmbRole.SelectedValue =
                row.Cells["QuyenID"].Value;

            txtUsername.Text =
                row.Cells["TenDangNhap"]
                .Value
                .ToString();

            txtPassword.Text = "";
        }

        private bool UsernameExists(string username)
        {
            string sql = @"
                SELECT COUNT(*)
                FROM TaiKhoan
                WHERE TenDangNhap = @User";

            try
            {
                if (ketNoi.State != ConnectionState.Open)
                {
                    ketNoi.Open();
                }

                boLenh =
                    new SqlCommand(
                        sql,
                        ketNoi
                    );

                boLenh.Parameters.AddWithValue(
                    "@User",
                    username
                );

                int count =
                    Convert.ToInt32(
                        boLenh.ExecuteScalar()
                    );

                ketNoi.Close();

                return count > 0;
            }
            catch
            {
                if (ketNoi != null &&
                    ketNoi.State == ConnectionState.Open)
                {
                    ketNoi.Close();
                }

                throw;
            }
        }

        private void BtnThem_Click(
            object sender,
            EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            try
            {
                if (UsernameExists(
                    txtUsername.Text))
                {
                    MessageBox.Show(
                        "Tên đăng nhập đã tồn tại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                string query = @"
                    INSERT INTO TaiKhoan
                    (
                        TenDangNhap,
                        MatKhau,
                        NhanVienID,
                        QuyenID
                    )
                    VALUES
                    (
                        @User,
                        @Pass,
                        @NV,
                        @Role
                    )";

                if (ketNoi.State != ConnectionState.Open)
                {
                    ketNoi.Open();
                }

                boLenh =
                    new SqlCommand(
                        query,
                        ketNoi
                    );

                boLenh.Parameters.AddWithValue(
                    "@User",
                    txtUsername.Text
                );

                boLenh.Parameters.AddWithValue(
                    "@Pass",
                    txtPassword.Text
                );

                boLenh.Parameters.AddWithValue(
                    "@NV",
                    cmbNhanVienID.SelectedValue
                );

                boLenh.Parameters.AddWithValue(
                    "@Role",
                    cmbRole.SelectedValue
                );

                boLenh.ExecuteNonQuery();

                ketNoi.Close();

                MessageBox.Show(
                    "Thêm tài khoản thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadTaiKhoanData();

                BtnReset_Click(null, null);
            }
            catch (Exception ex)
            {
                if (ketNoi != null &&
                    ketNoi.State == ConnectionState.Open)
                {
                    ketNoi.Close();
                }

                MessageBox.Show(
                    "Lỗi khi thêm tài khoản: " +
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

        private void BtnSua_Click(
            object sender,
            EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            if (dgvAccounts.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Hãy chọn tài khoản cần sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            int taiKhoanID =
                Convert.ToInt32(
                    dgvAccounts.SelectedRows[0]
                    .Cells["TaiKhoanID"]
                    .Value
                );

            string query;

            if (txtPassword.Text == "")
            {
                query = @"
                    UPDATE TaiKhoan
                    SET
                        TenDangNhap = @User,
                        NhanVienID = @NV,
                        QuyenID = @Role
                    WHERE TaiKhoanID = @ID";
            }
            else
            {
                query = @"
                    UPDATE TaiKhoan
                    SET
                        TenDangNhap = @User,
                        MatKhau = @Pass,
                        NhanVienID = @NV,
                        QuyenID = @Role
                    WHERE TaiKhoanID = @ID";
            }

            try
            {
                if (ketNoi.State != ConnectionState.Open)
                {
                    ketNoi.Open();
                }

                boLenh =
                    new SqlCommand(
                        query,
                        ketNoi
                    );

                boLenh.Parameters.AddWithValue(
                    "@User",
                    txtUsername.Text
                );

                boLenh.Parameters.AddWithValue(
                    "@NV",
                    cmbNhanVienID.SelectedValue
                );

                boLenh.Parameters.AddWithValue(
                    "@Role",
                    cmbRole.SelectedValue
                );

                boLenh.Parameters.AddWithValue(
                    "@ID",
                    taiKhoanID
                );

                if (txtPassword.Text != "")
                {
                    boLenh.Parameters.AddWithValue(
                        "@Pass",
                        txtPassword.Text
                    );
                }

                boLenh.ExecuteNonQuery();

                ketNoi.Close();

                MessageBox.Show(
                    "Sửa thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadTaiKhoanData();

                BtnReset_Click(null, null);
            }
            catch (Exception ex)
            {
                if (ketNoi != null &&
                    ketNoi.State == ConnectionState.Open)
                {
                    ketNoi.Close();
                }

                MessageBox.Show(
                    "Lỗi khi sửa tài khoản: " +
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

        private void BtnXoa_Click(
            object sender,
            EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Hãy chọn tài khoản cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            int taiKhoanID =
                Convert.ToInt32(
                    dgvAccounts.SelectedRows[0]
                    .Cells["TaiKhoanID"]
                    .Value
                );

            DialogResult result =
                MessageBox.Show(
                    "Xóa tài khoản này?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (result == DialogResult.No)
            {
                return;
            }

            string query = @"
                DELETE FROM TaiKhoan
                WHERE TaiKhoanID = @ID";

            try
            {
                if (ketNoi.State != ConnectionState.Open)
                {
                    ketNoi.Open();
                }

                boLenh =
                    new SqlCommand(
                        query,
                        ketNoi
                    );

                boLenh.Parameters.AddWithValue(
                    "@ID",
                    taiKhoanID
                );

                boLenh.ExecuteNonQuery();

                ketNoi.Close();

                MessageBox.Show(
                    "Xóa thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadTaiKhoanData();

                BtnReset_Click(null, null);
            }
            catch (Exception ex)
            {
                if (ketNoi != null &&
                    ketNoi.State == ConnectionState.Open)
                {
                    ketNoi.Close();
                }

                MessageBox.Show(
                    "Lỗi khi xóa tài khoản: " +
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

        private void BtnReset_Click(
            object sender,
            EventArgs e)
        {
            cmbNhanVienID.SelectedIndex = -1;

            cmbRole.SelectedIndex = -1;

            txtUsername.Clear();

            txtPassword.Clear();

            dgvAccounts.ClearSelection();
        }

        private bool ValidateInput()
        {
            if (cmbNhanVienID.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Chưa chọn nhân viên!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return false;
            }

            if (cmbRole.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Chưa chọn quyền!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return false;
            }

            if (string.IsNullOrWhiteSpace(
                txtUsername.Text))
            {
                MessageBox.Show(
                    "Tên đăng nhập không được để trống!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return false;
            }

            if (string.IsNullOrWhiteSpace(
                txtPassword.Text))
            {
                MessageBox.Show(
                    "Mật khẩu không được để trống!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return false;
            }

            return true;
        }
    }
}