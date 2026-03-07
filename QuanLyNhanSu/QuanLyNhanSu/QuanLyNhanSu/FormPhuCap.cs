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

namespace QuanLyNhanSu
{
    public partial class FormPhuCap : Form
    {
        SqlCommand boLenh;
        SqlConnection ketNoi;
        SqlDataAdapter docGhi;
        DataSet duLieu;

        public decimal TongPhuCap { get; private set; } = 0;
        public FormPhuCap()
        {
            InitializeComponent();
        }

        private void Load_PhuCap()
        {
            string sql = "SELECT PhuCapID, TenPhuCap, SoTien FROM PhuCap";
            docGhi = new SqlDataAdapter(sql, ketNoi);
            duLieu = new DataSet();
            docGhi.Fill(duLieu);

            // Hiển thị tên phụ cấp
            CbxPhuCap.DataSource = duLieu.Tables[0];
            CbxPhuCap.DisplayMember = "TenPhuCap";
            CbxPhuCap.ValueMember = "SoTien";
        }

        private void FormPhuCap_Load(object sender, EventArgs e)
        {
            string chuoiKN = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhanVienMain;Integrated Security=True;Trust Server Certificate=True";
            ketNoi = new SqlConnection(chuoiKN);
            Load_PhuCap();

            DgvPhuCap.Columns.Add("TenPhuCap", "Tên phụ cấp");
            DgvPhuCap.Columns.Add("SoTien", "Số tiền (VNĐ)");
            DgvPhuCap.Columns["SoTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void BtnThemPhuCap_Click(object sender, EventArgs e)
        {
            string tenPhuCap = CbxPhuCap.Text;
            decimal soTien = Convert.ToDecimal(CbxPhuCap.SelectedValue);

            // Thêm vào DataGridView
            DgvPhuCap.Rows.Add(tenPhuCap, soTien.ToString("N0"));

            // Cộng vào tổng
            TongPhuCap += soTien;
            TxtTongTien.Text = TongPhuCap.ToString("N0");
        }

        private void BtnXong_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
