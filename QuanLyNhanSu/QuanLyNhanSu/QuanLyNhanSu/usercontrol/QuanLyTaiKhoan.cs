using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNhanSu.usercontrol
{
    public partial class QuanLyTaiKhoan : UserControl
    {
        private readonly string connectionString =
            @"Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhanVien;Integrated Security=True;TrustServerCertificate=True;";

        public QuanLyTaiKhoan()
        {
            InitializeComponent();
            LoadNhanVienComboBox();
            LoadQuyenComboBox();
            LoadTaiKhoanData();
            SetupLayout();
        }

        private void SetupLayout()
        {
            dgvAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAccounts.CellClick += DgvAccounts_CellClick;

            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnReset.Click += BtnReset_Click;

            txtPassword.PasswordChar = '●';
        }
        private void LoadNhanVienComboBox()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT NhanVienID, HoTen FROM NhanVien", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbNhanVienID.DataSource = dt;
                cmbNhanVienID.DisplayMember = "HoTen";
                cmbNhanVienID.ValueMember = "NhanVienID";
                cmbNhanVienID.SelectedIndex = -1;
            }
        }

        private void LoadQuyenComboBox()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT QuyenID, TenQuyen FROM Quyen", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbRole.DataSource = dt;
                cmbRole.DisplayMember = "TenQuyen";
                cmbRole.ValueMember = "QuyenID";
                cmbRole.SelectedIndex = -1;
            }
        }

        private void LoadTaiKhoanData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT tk.TaiKhoanID, tk.TenDangNhap, '********' AS MatKhauHienThi,
                           nv.HoTen AS TenNhanVien,
                           tk.NhanVienID, tk.QuyenID,
                           q.TenQuyen
                    FROM TaiKhoan tk
                    JOIN NhanVien nv ON tk.NhanVienID = nv.NhanVienID
                    JOIN Quyen q ON tk.QuyenID = q.QuyenID";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvAccounts.DataSource = dt;

                dgvAccounts.Columns["TaiKhoanID"].Visible = false;
                dgvAccounts.Columns["NhanVienID"].Visible = false;
                dgvAccounts.Columns["QuyenID"].Visible = false;

                dgvAccounts.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
                dgvAccounts.Columns["TenDangNhap"].HeaderText = "Tên đăng nhập";
                dgvAccounts.Columns["MatKhauHienThi"].HeaderText = "Mật khẩu";
                dgvAccounts.Columns["TenQuyen"].HeaderText = "Quyền";

                dgvAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }


        private void DgvAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvAccounts.Rows[e.RowIndex];

            cmbNhanVienID.SelectedValue = row.Cells["NhanVienID"].Value;
            cmbRole.SelectedValue = row.Cells["QuyenID"].Value;
            txtUsername.Text = row.Cells["TenDangNhap"].Value.ToString();

            txtPassword.Text = "";
        }


        private bool UsernameExists(string username)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @User", conn);
                cmd.Parameters.AddWithValue("@User", username);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }


        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            if (UsernameExists(txtUsername.Text))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    INSERT INTO TaiKhoan (TenDangNhap, MatKhau, NhanVienID, QuyenID)
                    VALUES (@User, @Pass, @NV, @Role)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@User", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Pass", txtPassword.Text);
                cmd.Parameters.AddWithValue("@NV", cmbNhanVienID.SelectedValue);
                cmd.Parameters.AddWithValue("@Role", cmbRole.SelectedValue);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Thêm tài khoản thành công!");
            LoadTaiKhoanData();
            BtnReset_Click(null, null);
        }


        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            if (dgvAccounts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Hãy chọn tài khoản cần sửa!");
                return;
            }

            int taiKhoanID = Convert.ToInt32(
                dgvAccounts.SelectedRows[0].Cells["TaiKhoanID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query;

                if (txtPassword.Text == "")
                {
                    query = @"
                        UPDATE TaiKhoan
                        SET TenDangNhap=@User,
                            NhanVienID=@NV,
                            QuyenID=@Role
                        WHERE TaiKhoanID=@ID";
                }
                else
                {
                    query = @"
                        UPDATE TaiKhoan
                        SET TenDangNhap=@User,
                            MatKhau=@Pass,
                            NhanVienID=@NV,
                            QuyenID=@Role
                        WHERE TaiKhoanID=@ID";
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@User", txtUsername.Text);
                cmd.Parameters.AddWithValue("@NV", cmbNhanVienID.SelectedValue);
                cmd.Parameters.AddWithValue("@Role", cmbRole.SelectedValue);
                cmd.Parameters.AddWithValue("@ID", taiKhoanID);

                if (txtPassword.Text != "")
                    cmd.Parameters.AddWithValue("@Pass", txtPassword.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Sửa thành công!");
            LoadTaiKhoanData();
            BtnReset_Click(null, null);
        }
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Hãy chọn tài khoản cần xóa!");
                return;
            }

            int taiKhoanID = Convert.ToInt32(
                dgvAccounts.SelectedRows[0].Cells["TaiKhoanID"].Value);

            if (MessageBox.Show("Xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo)
                == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM TaiKhoan WHERE TaiKhoanID=@ID", conn);
                cmd.Parameters.AddWithValue("@ID", taiKhoanID);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Xóa thành công!");
            LoadTaiKhoanData();
            BtnReset_Click(null, null);
        }

        private void BtnReset_Click(object sender, EventArgs e)
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
                MessageBox.Show("Chưa chọn nhân viên!");
                return false;
            }

            if (cmbRole.SelectedIndex < 0)
            {
                MessageBox.Show("Chưa chọn quyền!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Tên đăng nhập không được để trống!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Mật khẩu không được để trống!");
                return false;
            }

            return true;
        }
    }
}
