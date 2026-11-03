namespace QuanLyNhanSu.usercontrol
{
    partial class ChiTietChamCong
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
            label1 = new Label();
            DtpNgayChamCong = new DateTimePicker();
            DgvChiTietChamCong = new DataGridView();
            groupBox2 = new GroupBox();
            BtnLocNgay = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvChiTietChamCong).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.FromArgb(60, 60, 60);
            label1.Location = new Point(30, 58);
            label1.Name = "label1";
            label1.Size = new Size(250, 41);
            label1.TabIndex = 35;
            label1.Text = "Ngày chấm công:";
            // 
            // DtpNgayChamCong
            // 
            DtpNgayChamCong.Font = new Font("Segoe UI", 11F);
            DtpNgayChamCong.Format = DateTimePickerFormat.Short;
            DtpNgayChamCong.Location = new Point(286, 58);
            DtpNgayChamCong.Name = "DtpNgayChamCong";
            DtpNgayChamCong.Size = new Size(250, 47);
            DtpNgayChamCong.TabIndex = 34;
            // 
            // DgvChiTietChamCong
            // 
            DgvChiTietChamCong.AllowUserToAddRows = false;
            DgvChiTietChamCong.AllowUserToDeleteRows = false;
            DgvChiTietChamCong.AllowUserToResizeRows = false;
            DgvChiTietChamCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvChiTietChamCong.BackgroundColor = Color.White;
            DgvChiTietChamCong.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvChiTietChamCong.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DgvChiTietChamCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvChiTietChamCong.ColumnHeadersHeight = 50;
            DgvChiTietChamCong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DgvChiTietChamCong.Dock = DockStyle.Bottom;
            DgvChiTietChamCong.EnableHeadersVisualStyles = false;
            DgvChiTietChamCong.GridColor = Color.FromArgb(220, 225, 230);
            DgvChiTietChamCong.Location = new Point(0, 307);
            DgvChiTietChamCong.MultiSelect = false;
            DgvChiTietChamCong.Name = "DgvChiTietChamCong";
            DgvChiTietChamCong.ReadOnly = true;
            DgvChiTietChamCong.RowHeadersVisible = false;
            DgvChiTietChamCong.RowHeadersWidth = 82;
            DgvChiTietChamCong.RowTemplate.Height = 42;
            DgvChiTietChamCong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvChiTietChamCong.Size = new Size(2088, 1320);
            DgvChiTietChamCong.TabIndex = 17;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(BtnLocNgay);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(DtpNgayChamCong);
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox2.ForeColor = Color.FromArgb(44, 62, 80);
            groupBox2.Location = new Point(35, 90);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(2018, 150);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lọc chấm công";
            // 
            // BtnLocNgay
            // 
            BtnLocNgay.BackColor = Color.FromArgb(52, 152, 219);
            BtnLocNgay.Cursor = Cursors.Hand;
            BtnLocNgay.FlatAppearance.BorderSize = 0;
            BtnLocNgay.FlatStyle = FlatStyle.Flat;
            BtnLocNgay.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BtnLocNgay.ForeColor = Color.White;
            BtnLocNgay.Location = new Point(583, 60);
            BtnLocNgay.Name = "BtnLocNgay";
            BtnLocNgay.Size = new Size(136, 46);
            BtnLocNgay.TabIndex = 36;
            BtnLocNgay.Text = "Lọc";
            BtnLocNgay.UseVisualStyleBackColor = false;
            BtnLocNgay.Click += BtnLocNgay_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(44, 62, 80);
            label3.Location = new Point(35, 25);
            label3.Name = "label3";
            label3.Size = new Size(484, 65);
            label3.TabIndex = 16;
            label3.Text = "Quản Lý Chấm Công";
            // 
            // ChiTietChamCong
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(DgvChiTietChamCong);
            Controls.Add(groupBox2);
            Controls.Add(label3);
            Name = "ChiTietChamCong";
            Size = new Size(2088, 1627);
            Load += ChiTietChamCong_Load_1;
            ((System.ComponentModel.ISupportInitialize)DgvChiTietChamCong).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker DtpNgayChamCong;
        private DataGridView DgvChiTietChamCong;
        private GroupBox groupBox2;
        private Label label3;
        private Button BtnLocNgay;
    }
}
