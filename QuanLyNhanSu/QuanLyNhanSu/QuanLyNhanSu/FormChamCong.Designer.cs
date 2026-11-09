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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            lblTitle.ForeColor = Color.FromArgb(35, 55, 80);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1300, 83);
            lblTitle.TabIndex = 16;
            lblTitle.Text = "CHẤM CÔNG NHÂN VIÊN";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNhanVien.ForeColor = Color.FromArgb(55, 65, 80);
            lblNhanVien.Location = new Point(46, 115);
            lblNhanVien.Margin = new Padding(4, 0, 4, 0);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(153, 37);
            lblNhanVien.TabIndex = 15;
            lblNhanVien.Text = "Nhân viên:";
            // 
            // txtNhanVien
            // 
            txtNhanVien.BackColor = Color.FromArgb(240, 243, 247);
            txtNhanVien.Font = new Font("Segoe UI", 10F);
            txtNhanVien.Location = new Point(202, 111);
            txtNhanVien.Margin = new Padding(4, 4, 4, 4);
            txtNhanVien.Name = "txtNhanVien";
            txtNhanVien.ReadOnly = true;
            txtNhanVien.Size = new Size(389, 43);
            txtNhanVien.TabIndex = 14;
            // 
            // lblNgay
            // 
            lblNgay.AutoSize = true;
            lblNgay.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNgay.ForeColor = Color.FromArgb(55, 65, 80);
            lblNgay.Location = new Point(663, 115);
            lblNgay.Margin = new Padding(4, 0, 4, 0);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(168, 37);
            lblNgay.TabIndex = 13;
            lblNgay.Text = "Ngày chấm:";
            // 
            // dtpNgayChamCong
            // 
            dtpNgayChamCong.Font = new Font("Segoe UI", 10F);
            dtpNgayChamCong.Format = DateTimePickerFormat.Short;
            dtpNgayChamCong.Location = new Point(832, 111);
            dtpNgayChamCong.Margin = new Padding(4, 4, 4, 4);
            dtpNgayChamCong.Name = "dtpNgayChamCong";
            dtpNgayChamCong.Size = new Size(389, 43);
            dtpNgayChamCong.TabIndex = 12;
            // 
            // lblGioVao
            // 
            lblGioVao.AutoSize = true;
            lblGioVao.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGioVao.ForeColor = Color.FromArgb(55, 65, 80);
            lblGioVao.Location = new Point(46, 192);
            lblGioVao.Margin = new Padding(4, 0, 4, 0);
            lblGioVao.Name = "lblGioVao";
            lblGioVao.Size = new Size(122, 37);
            lblGioVao.TabIndex = 11;
            lblGioVao.Text = "Giờ vào:";
            // 
            // dtpGioVao
            // 
            dtpGioVao.Font = new Font("Segoe UI", 10F);
            dtpGioVao.Format = DateTimePickerFormat.Time;
            dtpGioVao.Location = new Point(202, 188);
            dtpGioVao.Margin = new Padding(4, 4, 4, 4);
            dtpGioVao.Name = "dtpGioVao";
            dtpGioVao.ShowUpDown = true;
            dtpGioVao.Size = new Size(389, 43);
            dtpGioVao.TabIndex = 10;
            // 
            // lblGioRa
            // 
            lblGioRa.AutoSize = true;
            lblGioRa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGioRa.ForeColor = Color.FromArgb(55, 65, 80);
            lblGioRa.Location = new Point(663, 192);
            lblGioRa.Margin = new Padding(4, 0, 4, 0);
            lblGioRa.Name = "lblGioRa";
            lblGioRa.Size = new Size(101, 37);
            lblGioRa.TabIndex = 9;
            lblGioRa.Text = "Giờ ra:";
            // 
            // dtpGioRa
            // 
            dtpGioRa.Font = new Font("Segoe UI", 10F);
            dtpGioRa.Format = DateTimePickerFormat.Time;
            dtpGioRa.Location = new Point(832, 188);
            dtpGioRa.Margin = new Padding(4, 4, 4, 4);
            dtpGioRa.Name = "dtpGioRa";
            dtpGioRa.ShowUpDown = true;
            dtpGioRa.Size = new Size(389, 43);
            dtpGioRa.TabIndex = 8;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTrangThai.ForeColor = Color.FromArgb(55, 65, 80);
            lblTrangThai.Location = new Point(46, 269);
            lblTrangThai.Margin = new Padding(4, 0, 4, 0);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(154, 37);
            lblTrangThai.TabIndex = 7;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Font = new Font("Segoe UI", 10F);
            cboTrangThai.Items.AddRange(new object[] { "Đang làm việc", "Đủ công", "Trễ", "Vắng", "Nghỉ phép" });
            cboTrangThai.Location = new Point(202, 265);
            cboTrangThai.Margin = new Padding(4, 4, 4, 4);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(389, 45);
            cboTrangThai.TabIndex = 6;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGhiChu.ForeColor = Color.FromArgb(55, 65, 80);
            lblGhiChu.Location = new Point(663, 269);
            lblGhiChu.Margin = new Padding(4, 0, 4, 0);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(119, 37);
            lblGhiChu.TabIndex = 5;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Font = new Font("Segoe UI", 10F);
            txtGhiChu.Location = new Point(832, 265);
            txtGhiChu.Margin = new Padding(4, 4, 4, 4);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(389, 43);
            txtGhiChu.TabIndex = 4;
            // 
            // btnChamCong
            // 
            btnChamCong.BackColor = Color.FromArgb(46, 125, 80);
            btnChamCong.FlatAppearance.BorderSize = 0;
            btnChamCong.FlatStyle = FlatStyle.Flat;
            btnChamCong.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnChamCong.ForeColor = Color.White;
            btnChamCong.Location = new Point(202, 352);
            btnChamCong.Margin = new Padding(4, 4, 4, 4);
            btnChamCong.Name = "btnChamCong";
            btnChamCong.Size = new Size(234, 58);
            btnChamCong.TabIndex = 3;
            btnChamCong.Text = "Chấm công";
            btnChamCong.UseVisualStyleBackColor = false;
            btnChamCong.Click += btnChamCong_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = Color.FromArgb(41, 113, 170);
            btnCheckOut.FlatAppearance.BorderSize = 0;
            btnCheckOut.FlatStyle = FlatStyle.Flat;
            btnCheckOut.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCheckOut.ForeColor = Color.White;
            btnCheckOut.Location = new Point(474, 352);
            btnCheckOut.Margin = new Padding(4, 4, 4, 4);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(234, 58);
            btnCheckOut.TabIndex = 2;
            btnCheckOut.Text = "Check-out";
            btnCheckOut.UseVisualStyleBackColor = false;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(100, 110, 125);
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(748, 352);
            btnLamMoi.Margin = new Padding(4, 4, 4, 4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(234, 58);
            btnLamMoi.TabIndex = 1;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // dgvChamCong
            // 
            dgvChamCong.AllowUserToAddRows = false;
            dgvChamCong.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 248, 252);
            dgvChamCong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvChamCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChamCong.BackgroundColor = Color.White;
            dgvChamCong.BorderStyle = BorderStyle.None;
            dgvChamCong.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvChamCong.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvChamCong.ColumnHeadersHeight = 48;
            dgvChamCong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(50, 55, 65);
            dataGridViewCellStyle2.Padding = new Padding(8, 4, 8, 4);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(218, 232, 248);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(35, 55, 80);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvChamCong.DefaultCellStyle = dataGridViewCellStyle2;
            dgvChamCong.EnableHeadersVisualStyles = false;
            dgvChamCong.GridColor = Color.FromArgb(230, 234, 240);
            dgvChamCong.Location = new Point(39, 448);
            dgvChamCong.Margin = new Padding(4, 4, 4, 4);
            dgvChamCong.MultiSelect = false;
            dgvChamCong.Name = "dgvChamCong";
            dgvChamCong.ReadOnly = true;
            dgvChamCong.RowHeadersVisible = false;
            dgvChamCong.RowHeadersWidth = 82;
            dgvChamCong.RowTemplate.Height = 42;
            dgvChamCong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChamCong.Size = new Size(1182, 192);
            dgvChamCong.TabIndex = 0;
            // 
            // FormChamCong
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1300, 832);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "FormChamCong";
            StartPosition = FormStartPosition.CenterScreen;
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
