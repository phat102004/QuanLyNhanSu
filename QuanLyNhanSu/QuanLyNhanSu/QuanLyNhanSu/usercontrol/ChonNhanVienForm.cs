
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhanSu.usercontrol
{
    public class ChonNhanVienForm : Form
    {
        private readonly string connectionString;

        private readonly TextBox txtSearch = new TextBox();
        private readonly Button btnSearch = new Button();
        private readonly Button btnSelect = new Button();
        private readonly DataGridView dgv = new DataGridView();

        public object? SelectedEmployeeId { get; private set; }

        public ChonNhanVienForm(string connectionString)
        {
            this.connectionString = connectionString;

            Text = "Tìm và chọn nhân viên";
            StartPosition = FormStartPosition.CenterParent;
            Size = new Size(900, 570);
            MinimumSize = new Size(650, 450);
            BackColor = Color.FromArgb(241, 245, 249);
            Font = new Font("Segoe UI", 10F);

            BuildUI();

            Shown += (s, e) => SearchEmployees();
        }

        private void BuildUI()
        {
            TableLayoutPanel root = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(16),
                ColumnCount = 1,
                RowCount = 3
            };

            root.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100));

            root.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 65));

            root.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100));

            root.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 65));

            TableLayoutPanel searchRow = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 1
            };

            searchRow.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100));

            searchRow.ColumnStyles.Add(
                new ColumnStyle(SizeType.Absolute, 145));

            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Margin = new Padding(4, 8, 8, 8);
            txtSearch.PlaceholderText =
                "Nhập mã nhân viên hoặc họ tên...";

            btnSearch.Text = "Tìm kiếm";
            btnSearch.Dock = DockStyle.Fill;
            btnSearch.BackColor = Color.FromArgb(30, 64, 175);
            btnSearch.ForeColor = Color.White;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.Margin = new Padding(4, 6, 4, 6);
            btnSearch.Cursor = Cursors.Hand;

            btnSearch.Click += (s, e) => SearchEmployees();

            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEmployees();
                    e.SuppressKeyPress = true;
                }
            };

            searchRow.Controls.Add(txtSearch, 0, 0);
            searchRow.Controls.Add(btnSearch, 1, 0);

            dgv.Dock = DockStyle.Fill;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.MultiSelect = false;
            dgv.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgv.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.RowHeadersVisible = false;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersHeight = 45;

            dgv.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(30, 64, 175);

            dgv.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgv.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);

            dgv.DefaultCellStyle.Font =
                new Font("Segoe UI", 10F);

            dgv.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(219, 234, 254);

            dgv.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(15, 23, 42);

            dgv.RowTemplate.Height = 38;
            dgv.CellDoubleClick += (s, e) =>
            {
                if (e.RowIndex >= 0)
                    SelectEmployee();
            };

            btnSelect.Text = "Chọn nhân viên";
            btnSelect.Dock = DockStyle.Right;
            btnSelect.Width = 190;
            btnSelect.BackColor = Color.FromArgb(37, 99, 235);
            btnSelect.ForeColor = Color.White;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.FlatAppearance.BorderSize = 0;
            btnSelect.Cursor = Cursors.Hand;

            btnSelect.Click += (s, e) => SelectEmployee();

            Panel footer = new Panel
            {
                Dock = DockStyle.Fill
            };

            footer.Controls.Add(btnSelect);

            root.Controls.Add(searchRow, 0, 0);
            root.Controls.Add(dgv, 0, 1);
            root.Controls.Add(footer, 0, 2);

            Controls.Add(root);
        }

        private void SearchEmployees()
        {
            string keyword = txtSearch.Text.Trim();

            const string sql = @"
                SELECT TOP (50)
                    NhanVienID,
                    HoTen
                FROM NhanVien
                WHERE
                    @Keyword = N''
                    OR HoTen LIKE @Pattern
                    OR CONVERT(NVARCHAR(50), NhanVienID)
                        LIKE @Pattern
                ORDER BY HoTen, NhanVienID";

            try
            {
                using SqlConnection conn =
                    new SqlConnection(connectionString);

                using SqlCommand cmd =
                    new SqlCommand(sql, conn);

                cmd.Parameters.Add(
                    "@Keyword", SqlDbType.NVarChar, 200)
                    .Value = keyword;

                cmd.Parameters.Add(
                    "@Pattern", SqlDbType.NVarChar, 402)
                    .Value = "%" +
                        keyword.Replace("[", "[[]")
                               .Replace("%", "[%]")
                               .Replace("_", "[_]")
                            + "%";

                using SqlDataAdapter adapter =
                    new SqlDataAdapter(cmd);

                DataTable table = new DataTable();
                adapter.Fill(table);

                dgv.DataSource = table;

                if (dgv.Columns.Contains("NhanVienID"))
                {
                    dgv.Columns["NhanVienID"].HeaderText =
                        "Mã nhân viên";
                }

                if (dgv.Columns.Contains("HoTen"))
                {
                    dgv.Columns["HoTen"].HeaderText =
                        "Họ và tên";
                }

                dgv.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tìm nhân viên:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void SelectEmployee()
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn một nhân viên.");
                return;
            }

            SelectedEmployeeId =
                dgv.SelectedRows[0]
                    .Cells["NhanVienID"].Value;

            if (SelectedEmployeeId == null ||
                SelectedEmployeeId == DBNull.Value)
            {
                MessageBox.Show("Mã nhân viên không hợp lệ.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
