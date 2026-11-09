namespace QuanLyNhanSu.usercontrol
{
    partial class BangLuong
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DgvLuong = new DataGridView();
            MaLuongTong = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            SoNgayCong = new DataGridViewTextBoxColumn();
            TongPhuCap = new DataGridViewTextBoxColumn();
            TongLuong = new DataGridViewTextBoxColumn();
            NgayTinhLuong = new DataGridViewTextBoxColumn();
            NgayLap = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            TxtTimKiem = new TextBox();
            CbxPhongBan = new ComboBox();
            BtnLamMoi = new Button();
            BtnTimKiem = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            DtpNgayLuong = new DateTimePicker();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvLuong).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // DgvLuong
            // 
            DgvLuong.AllowUserToAddRows = false;
            DgvLuong.AllowUserToDeleteRows = false;
            DgvLuong.AllowUserToResizeRows = false;
            DgvLuong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgvLuong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvLuong.BackgroundColor = Color.White;
            DgvLuong.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvLuong.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DgvLuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvLuong.ColumnHeadersHeight = 45;
            DgvLuong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DgvLuong.Columns.AddRange(new DataGridViewColumn[] { MaLuongTong, HoTen, SoNgayCong, TongPhuCap, TongLuong, NgayTinhLuong, NgayLap });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(220, 235, 250);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvLuong.DefaultCellStyle = dataGridViewCellStyle2;
            DgvLuong.EnableHeadersVisualStyles = false;
            DgvLuong.GridColor = Color.FromArgb(220, 225, 230);
            DgvLuong.Location = new Point(20, 288);
            DgvLuong.MultiSelect = false;
            DgvLuong.Name = "DgvLuong";
            DgvLuong.ReadOnly = true;
            DgvLuong.RowHeadersVisible = false;
            DgvLuong.RowHeadersWidth = 51;
            DgvLuong.RowTemplate.Height = 34;
            DgvLuong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvLuong.Size = new Size(2048, 1319);
            DgvLuong.TabIndex = 10;
            // 
            // MaLuongTong
            // 
            MaLuongTong.DataPropertyName = "MaLuongTong";
            MaLuongTong.HeaderText = "Mã Lương";
            MaLuongTong.MinimumWidth = 10;
            MaLuongTong.Name = "MaLuongTong";
            MaLuongTong.ReadOnly = true;
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Họ tên";
            HoTen.MinimumWidth = 10;
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            // 
            // SoNgayCong
            // 
            SoNgayCong.DataPropertyName = "SoNgayCong";
            SoNgayCong.HeaderText = "Số ngày công";
            SoNgayCong.MinimumWidth = 10;
            SoNgayCong.Name = "SoNgayCong";
            SoNgayCong.ReadOnly = true;
            // 
            // TongPhuCap
            // 
            TongPhuCap.DataPropertyName = "TongPhuCap";
            TongPhuCap.HeaderText = "Tổng phụ cấp";
            TongPhuCap.MinimumWidth = 10;
            TongPhuCap.Name = "TongPhuCap";
            TongPhuCap.ReadOnly = true;
            // 
            // TongLuong
            // 
            TongLuong.DataPropertyName = "TongLuong";
            TongLuong.HeaderText = "Tổng lương";
            TongLuong.MinimumWidth = 10;
            TongLuong.Name = "TongLuong";
            TongLuong.ReadOnly = true;
            // 
            // NgayTinhLuong
            // 
            NgayTinhLuong.DataPropertyName = "NgayTinhLuong";
            NgayTinhLuong.HeaderText = "Ngày tính lương";
            NgayTinhLuong.MinimumWidth = 10;
            NgayTinhLuong.Name = "NgayTinhLuong";
            NgayTinhLuong.ReadOnly = true;
            // 
            // NgayLap
            // 
            NgayLap.DataPropertyName = "NgayLap";
            NgayLap.HeaderText = "Ngày lập";
            NgayLap.MinimumWidth = 10;
            NgayLap.Name = "NgayLap";
            NgayLap.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(TxtTimKiem);
            groupBox1.Controls.Add(CbxPhongBan);
            groupBox1.Controls.Add(BtnLamMoi);
            groupBox1.Controls.Add(BtnTimKiem);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(DtpNgayLuong);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(20, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(2048, 180);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm và lọc";
            // 
            // TxtTimKiem
            // 
            TxtTimKiem.Font = new Font("Segoe UI", 10F);
            TxtTimKiem.Location = new Point(1094, 59);
            TxtTimKiem.Name = "TxtTimKiem";
            TxtTimKiem.Size = new Size(321, 43);
            TxtTimKiem.TabIndex = 7;
            TxtTimKiem.TextChanged += TxtTimKiem_TextChanged;
            // 
            // CbxPhongBan
            // 
            CbxPhongBan.Font = new Font("Segoe UI", 10F);
            CbxPhongBan.FormattingEnabled = true;
            CbxPhongBan.Location = new Point(580, 58);
            CbxPhongBan.Name = "CbxPhongBan";
            CbxPhongBan.Size = new Size(330, 45);
            CbxPhongBan.TabIndex = 5;
            CbxPhongBan.SelectedIndexChanged += CbxPhongBan_SelectedIndexChanged;
            // 
            // BtnLamMoi
            // 
            BtnLamMoi.BackColor = Color.White;
            BtnLamMoi.FlatStyle = FlatStyle.Flat;
            BtnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnLamMoi.Location = new Point(1640, 52);
            BtnLamMoi.Name = "BtnLamMoi";
            BtnLamMoi.Size = new Size(170, 55);
            BtnLamMoi.TabIndex = 9;
            BtnLamMoi.Text = "Làm mới";
            BtnLamMoi.UseVisualStyleBackColor = false;
            BtnLamMoi.Click += BtnLamMoi_Click;
            // 
            // BtnTimKiem
            // 
            BtnTimKiem.BackColor = Color.White;
            BtnTimKiem.FlatStyle = FlatStyle.Flat;
            BtnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnTimKiem.Location = new Point(1450, 52);
            BtnTimKiem.Name = "BtnTimKiem";
            BtnTimKiem.Size = new Size(170, 55);
            BtnTimKiem.TabIndex = 8;
            BtnTimKiem.Text = "Tìm kiếm";
            BtnTimKiem.UseVisualStyleBackColor = false;
            BtnTimKiem.Click += BtnTimKiem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(412, 62);
            label1.Name = "label1";
            label1.Size = new Size(162, 37);
            label1.TabIndex = 4;
            label1.Text = "Phòng ban:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(945, 62);
            label2.Name = "label2";
            label2.Size = new Size(143, 37);
            label2.TabIndex = 6;
            label2.Text = "Tìm kiếm:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(25, 62);
            label4.Name = "label4";
            label4.Size = new Size(175, 37);
            label4.TabIndex = 2;
            label4.Text = "Ngày lương:";
            // 
            // DtpNgayLuong
            // 
            DtpNgayLuong.CustomFormat = "MM/yyyy";
            DtpNgayLuong.Format = DateTimePickerFormat.Custom;
            DtpNgayLuong.Location = new Point(206, 60);
            DtpNgayLuong.Name = "DtpNgayLuong";
            DtpNgayLuong.ShowUpDown = true;
            DtpNgayLuong.Size = new Size(170, 43);
            DtpNgayLuong.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.Location = new Point(25, 18);
            label3.Name = "label3";
            label3.Size = new Size(292, 65);
            label3.TabIndex = 0;
            label3.Text = "Bảng lương";
            // 
            // BangLuong
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(DgvLuong);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Name = "BangLuong";
            Size = new Size(2088, 1627);
            ((System.ComponentModel.ISupportInitialize)DgvLuong).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private DataGridView DgvLuong;
        private GroupBox groupBox1;
        private Label label3;
        private Label label4;
        private DateTimePicker DtpNgayLuong;
        private TextBox TxtTimKiem;
        private ComboBox CbxPhongBan;
        private Button BtnLamMoi;
        private Button BtnTimKiem;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn MaLuongTong;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn SoNgayCong;
        private DataGridViewTextBoxColumn TongPhuCap;
        private DataGridViewTextBoxColumn TongLuong;
        private DataGridViewTextBoxColumn NgayTinhLuong;
        private DataGridViewTextBoxColumn NgayLap;
    }
}
