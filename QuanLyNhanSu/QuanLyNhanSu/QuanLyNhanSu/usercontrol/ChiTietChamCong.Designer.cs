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
            label1 = new Label();
            DtpNgayChamCong = new DateTimePicker();
            DgvChiTietChamCong = new DataGridView();
            groupBox2 = new GroupBox();
            label3 = new Label();
            BtnLocNgay = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvChiTietChamCong).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 43);
            label1.Name = "label1";
            label1.Size = new Size(200, 32);
            label1.TabIndex = 35;
            label1.Text = "Ngày chấm công:";
            // 
            // DtpNgayChamCong
            // 
            DtpNgayChamCong.Location = new Point(364, 43);
            DtpNgayChamCong.Name = "DtpNgayChamCong";
            DtpNgayChamCong.Size = new Size(389, 39);
            DtpNgayChamCong.TabIndex = 34;
            // 
            // DgvChiTietChamCong
            // 
            DgvChiTietChamCong.AllowUserToAddRows = false;
            DgvChiTietChamCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvChiTietChamCong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvChiTietChamCong.Dock = DockStyle.Bottom;
            DgvChiTietChamCong.Location = new Point(0, 307);
            DgvChiTietChamCong.Name = "DgvChiTietChamCong";
            DgvChiTietChamCong.RowHeadersVisible = false;
            DgvChiTietChamCong.RowHeadersWidth = 82;
            DgvChiTietChamCong.Size = new Size(2088, 1320);
            DgvChiTietChamCong.TabIndex = 17;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnLocNgay);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(DtpNgayChamCong);
            groupBox2.Location = new Point(35, 72);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(2014, 164);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(35, 3);
            label3.Name = "label3";
            label3.Size = new Size(322, 45);
            label3.TabIndex = 16;
            label3.Text = "Quản Lý Chấm Công";
            // 
            // BtnLocNgay
            // 
            BtnLocNgay.Location = new Point(780, 41);
            BtnLocNgay.Name = "BtnLocNgay";
            BtnLocNgay.Size = new Size(202, 46);
            BtnLocNgay.TabIndex = 36;
            BtnLocNgay.Text = "Lọc";
            BtnLocNgay.UseVisualStyleBackColor = true;
            BtnLocNgay.Click += BtnLocNgay_Click;
            // 
            // ChiTietChamCong
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
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
