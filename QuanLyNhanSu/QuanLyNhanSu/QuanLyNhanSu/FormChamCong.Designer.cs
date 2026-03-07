namespace QuanLyNhanSu
{
    partial class FormChamCong
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblNhanVien = new Label();
            txtNhanVien = new TextBox();
            lblNgay = new Label();
            dtpNgayChamCong = new DateTimePicker();
            lblGioVao = new Label();
            dtpGioVao = new DateTimePicker();
            lblGioRa = new Label();
            dtpGioRa = new DateTimePicker();
            lblTrangThai = new Label();
            cboTrangThai = new ComboBox();
            lblGhiChu = new Label();
            txtGhiChu = new TextBox();
            btnChamCong = new Button();
            btnCheckOut = new Button();
            btnLamMoi = new Button();
            dgvChamCong = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(880, 50);
            lblTitle.TabIndex = 16;
            lblTitle.Text = "CHẤM CÔNG NHÂN VIÊN";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNhanVien
            // 
            lblNhanVien.Location = new Point(30, 70);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(100, 23);
            lblNhanVien.TabIndex = 15;
            lblNhanVien.Text = "Nhân viên:";
            // 
            // txtNhanVien
            // 
            txtNhanVien.Location = new Point(150, 67);
            txtNhanVien.Name = "txtNhanVien";
            txtNhanVien.ReadOnly = true;
            txtNhanVien.Size = new Size(250, 39);
            txtNhanVien.TabIndex = 14;
            // 
            // lblNgay
            // 
            lblNgay.Location = new Point(430, 70);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(100, 23);
            lblNgay.TabIndex = 13;
            lblNgay.Text = "Ngày chấm:";
            // 
            // dtpNgayChamCong
            // 
            dtpNgayChamCong.Format = DateTimePickerFormat.Short;
            dtpNgayChamCong.Location = new Point(530, 67);
            dtpNgayChamCong.Name = "dtpNgayChamCong";
            dtpNgayChamCong.Size = new Size(200, 39);
            dtpNgayChamCong.TabIndex = 12;
            // 
            // lblGioVao
            // 
            lblGioVao.Location = new Point(30, 115);
            lblGioVao.Name = "lblGioVao";
            lblGioVao.Size = new Size(100, 23);
            lblGioVao.TabIndex = 11;
            lblGioVao.Text = "Giờ vào:";
            // 
            // dtpGioVao
            // 
            dtpGioVao.Format = DateTimePickerFormat.Time;
            dtpGioVao.Location = new Point(150, 112);
            dtpGioVao.Name = "dtpGioVao";
            dtpGioVao.ShowUpDown = true;
            dtpGioVao.Size = new Size(200, 39);
            dtpGioVao.TabIndex = 10;
            // 
            // lblGioRa
            // 
            lblGioRa.Location = new Point(430, 115);
            lblGioRa.Name = "lblGioRa";
            lblGioRa.Size = new Size(100, 23);
            lblGioRa.TabIndex = 9;
            lblGioRa.Text = "Giờ ra:";
            // 
            // dtpGioRa
            // 
            dtpGioRa.Format = DateTimePickerFormat.Time;
            dtpGioRa.Location = new Point(530, 112);
            dtpGioRa.Name = "dtpGioRa";
            dtpGioRa.ShowUpDown = true;
            dtpGioRa.Size = new Size(200, 39);
            dtpGioRa.TabIndex = 8;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Location = new Point(30, 160);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(100, 23);
            lblTrangThai.TabIndex = 7;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Items.AddRange(new object[] { "Đang làm việc", "Đủ công", "Trễ", "Vắng", "Nghỉ phép" });
            cboTrangThai.Location = new Point(150, 157);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(250, 40);
            cboTrangThai.TabIndex = 6;
            // 
            // lblGhiChu
            // 
            lblGhiChu.Location = new Point(430, 160);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(100, 23);
            lblGhiChu.TabIndex = 5;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(530, 157);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(300, 39);
            txtGhiChu.TabIndex = 4;
            // 
            // btnChamCong
            // 
            btnChamCong.Location = new Point(150, 205);
            btnChamCong.Name = "btnChamCong";
            btnChamCong.Size = new Size(120, 40);
            btnChamCong.TabIndex = 3;
            btnChamCong.Text = "Chấm công";
            btnChamCong.Click += btnChamCong_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(290, 205);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(120, 40);
            btnCheckOut.TabIndex = 2;
            btnCheckOut.Text = "Check-out";
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(430, 205);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(120, 40);
            btnLamMoi.TabIndex = 1;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // dgvChamCong
            // 
            dgvChamCong.AllowUserToAddRows = false;
            dgvChamCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChamCong.ColumnHeadersHeight = 46;
            dgvChamCong.Location = new Point(30, 265);
            dgvChamCong.Name = "dgvChamCong";
            dgvChamCong.ReadOnly = true;
            dgvChamCong.RowHeadersWidth = 82;
            dgvChamCong.Size = new Size(800, 250);
            dgvChamCong.TabIndex = 0;
            // 
            // FormChamCong
            // 
            ClientSize = new Size(880, 540);
            Controls.Add(dgvChamCong);
            Controls.Add(btnLamMoi);
            Controls.Add(btnCheckOut);
            Controls.Add(btnChamCong);
            Controls.Add(txtGhiChu);
            Controls.Add(lblGhiChu);
            Controls.Add(cboTrangThai);
            Controls.Add(lblTrangThai);
            Controls.Add(dtpGioRa);
            Controls.Add(lblGioRa);
            Controls.Add(dtpGioVao);
            Controls.Add(lblGioVao);
            Controls.Add(dtpNgayChamCong);
            Controls.Add(lblNgay);
            Controls.Add(txtNhanVien);
            Controls.Add(lblNhanVien);
            Controls.Add(lblTitle);
            Name = "FormChamCong";
            Text = "Form Chấm Công";
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.DateTimePicker dtpNgayChamCong;
        private System.Windows.Forms.Label lblGioVao;
        private System.Windows.Forms.DateTimePicker dtpGioVao;
        private System.Windows.Forms.Label lblGioRa;
        private System.Windows.Forms.DateTimePicker dtpGioRa;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnChamCong;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvChamCong;
    }
}
