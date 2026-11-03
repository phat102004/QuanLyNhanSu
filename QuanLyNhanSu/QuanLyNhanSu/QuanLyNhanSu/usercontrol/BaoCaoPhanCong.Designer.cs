namespace QuanLyNhanSu.usercontrol
{
    partial class BaoCaoPhanCong
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DgvPhanCong = new DataGridView();
            groupBox1 = new GroupBox();
            filterLayout = new TableLayoutPanel();
            label4 = new Label();
            DtpNgayTruoc = new DateTimePicker();
            label1 = new Label();
            DtpNgaySau = new DateTimePicker();
            label2 = new Label();
            TxtTimKiem = new TextBox();
            buttonPanel = new FlowLayoutPanel();
            BtnTimKiem = new Button();
            BtnLamMoi = new Button();
            BtnXuatExcel = new Button();
            label3 = new Label();
            BtnHoanThanh = new Button();
            mainLayout = new TableLayoutPanel();
            actionPanel = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)DgvPhanCong).BeginInit();
            groupBox1.SuspendLayout();
            filterLayout.SuspendLayout();
            buttonPanel.SuspendLayout();
            mainLayout.SuspendLayout();
            actionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // DgvPhanCong
            // 
            DgvPhanCong.AllowUserToAddRows = false;
            DgvPhanCong.AllowUserToDeleteRows = false;
            DgvPhanCong.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(220, 235, 250);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            DgvPhanCong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvPhanCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPhanCong.BackgroundColor = Color.White;
            DgvPhanCong.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DgvPhanCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DgvPhanCong.ColumnHeadersHeight = 52;
            DgvPhanCong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle3.Padding = new Padding(5, 0, 5, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(220, 235, 250);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DgvPhanCong.DefaultCellStyle = dataGridViewCellStyle3;
            DgvPhanCong.Dock = DockStyle.Fill;
            DgvPhanCong.EnableHeadersVisualStyles = false;
            DgvPhanCong.GridColor = Color.FromArgb(210, 215, 220);
            DgvPhanCong.Location = new Point(25, 545);
            DgvPhanCong.Margin = new Padding(0);
            DgvPhanCong.MultiSelect = false;
            DgvPhanCong.Name = "DgvPhanCong";
            DgvPhanCong.ReadOnly = true;
            DgvPhanCong.RowHeadersVisible = false;
            DgvPhanCong.RowHeadersWidth = 82;
            DgvPhanCong.RowTemplate.Height = 42;
            DgvPhanCong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvPhanCong.Size = new Size(2038, 1057);
            DgvPhanCong.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(filterLayout);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(25, 110);
            groupBox1.Margin = new Padding(0, 0, 0, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(20, 30, 20, 20);
            groupBox1.Size = new Size(2038, 335);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bộ lọc báo cáo";
            // 
            // filterLayout
            // 
            filterLayout.ColumnCount = 4;
            filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 280F));
            filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            filterLayout.Controls.Add(label4, 0, 0);
            filterLayout.Controls.Add(DtpNgayTruoc, 1, 0);
            filterLayout.Controls.Add(label1, 2, 0);
            filterLayout.Controls.Add(label2, 0, 1);
            filterLayout.Controls.Add(TxtTimKiem, 1, 1);
            filterLayout.Controls.Add(buttonPanel, 1, 2);
            filterLayout.Controls.Add(DtpNgaySau, 3, 0);
            filterLayout.Dock = DockStyle.Fill;
            filterLayout.Location = new Point(20, 66);
            filterLayout.Margin = new Padding(0);
            filterLayout.Name = "filterLayout";
            filterLayout.Padding = new Padding(20);
            filterLayout.RowCount = 3;
            filterLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            filterLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            filterLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            filterLayout.Size = new Size(1998, 249);
            filterLayout.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(20, 39);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(233, 37);
            label4.TabIndex = 0;
            label4.Text = "Ngày phân công:";
            // 
            // DtpNgayTruoc
            // 
            DtpNgayTruoc.Anchor = AnchorStyles.Left;
            DtpNgayTruoc.CustomFormat = "dd/MM/yyyy";
            DtpNgayTruoc.Font = new Font("Segoe UI", 10F);
            DtpNgayTruoc.Format = DateTimePickerFormat.Custom;
            DtpNgayTruoc.Margin = new Padding(0, 10, 20, 10);
            DtpNgayTruoc.Name = "DtpNgayTruoc";
            DtpNgayTruoc.Size = new Size(280, 43);
            DtpNgayTruoc.TabIndex = 34;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(600, 39);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(75, 37);
            label1.TabIndex = 35;
            label1.Text = "Đến:";
            // 
            // DtpNgaySau
            // 
            DtpNgaySau.Anchor = AnchorStyles.Left;
            DtpNgaySau.CustomFormat = "dd/MM/yyyy";
            DtpNgaySau.Font = new Font("Segoe UI", 10F);
            DtpNgaySau.Format = DateTimePickerFormat.Custom;
            DtpNgaySau.Margin = new Padding(0, 10, 0, 10);
            DtpNgaySau.Name = "DtpNgaySau";
            DtpNgaySau.Size = new Size(280, 43);
            DtpNgaySau.TabIndex = 34;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            filterLayout.SetColumnSpan(TxtTimKiem, 3);
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(20, 114);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(143, 37);
            label2.TabIndex = 36;
            label2.Text = "Tìm kiếm:";
            // 
            // TxtTimKiem
            // 
            TxtTimKiem.Anchor = AnchorStyles.Left;
            TxtTimKiem.Font = new Font("Segoe UI", 10F);
            TxtTimKiem.Margin = new Padding(0, 10, 0, 10);
            TxtTimKiem.Name = "TxtTimKiem";
            TxtTimKiem.Size = new Size(720, 43);
            TxtTimKiem.TabIndex = 36;
            TxtTimKiem.TextChanged += TxtTimKiem_TextChanged;
            // 
            // buttonPanel
            // 
            filterLayout.SetColumnSpan(buttonPanel, 3);
            buttonPanel.Controls.Add(BtnTimKiem);
            buttonPanel.Controls.Add(BtnLamMoi);
            buttonPanel.Controls.Add(BtnXuatExcel);
            buttonPanel.Dock = DockStyle.Fill;
            buttonPanel.Location = new Point(300, 170);
            buttonPanel.Margin = new Padding(0);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Padding = new Padding(0, 15, 0, 15);
            buttonPanel.Size = new Size(1678, 110);
            buttonPanel.TabIndex = 37;
            buttonPanel.WrapContents = false;
            // 
            // BtnTimKiem
            // 
            BtnTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnTimKiem.Location = new Point(0, 15);
            BtnTimKiem.Margin = new Padding(0, 0, 15, 0);
            BtnTimKiem.Name = "BtnTimKiem";
            BtnTimKiem.Size = new Size(175, 50);
            BtnTimKiem.TabIndex = 33;
            BtnTimKiem.Text = "Tìm kiếm";
            BtnTimKiem.UseVisualStyleBackColor = true;
            BtnTimKiem.Click += BtnTimKiem_Click;
            // 
            // BtnLamMoi
            // 
            BtnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnLamMoi.Location = new Point(190, 15);
            BtnLamMoi.Margin = new Padding(0, 0, 15, 0);
            BtnLamMoi.Name = "BtnLamMoi";
            BtnLamMoi.Size = new Size(175, 50);
            BtnLamMoi.TabIndex = 33;
            BtnLamMoi.Text = "Làm mới";
            BtnLamMoi.UseVisualStyleBackColor = true;
            BtnLamMoi.Click += BtnLamMoi_Click;
            // 
            // BtnXuatExcel
            // 
            BtnXuatExcel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnXuatExcel.Location = new Point(380, 15);
            BtnXuatExcel.Margin = new Padding(0);
            BtnXuatExcel.Name = "BtnXuatExcel";
            BtnXuatExcel.Size = new Size(175, 50);
            BtnXuatExcel.TabIndex = 33;
            BtnXuatExcel.Text = "Xuất Excel";
            BtnXuatExcel.UseVisualStyleBackColor = true;
            BtnXuatExcel.Click += BtnXuatExcel_Click;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(30, 30, 30);
            label3.Location = new Point(25, 25);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Padding = new Padding(5, 0, 0, 0);
            label3.Size = new Size(2038, 85);
            label3.TabIndex = 0;
            label3.Text = "Báo cáo phân công";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BtnHoanThanh
            // 
            BtnHoanThanh.Anchor = AnchorStyles.None;
            BtnHoanThanh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnHoanThanh.Location = new Point(1848, 17);
            BtnHoanThanh.Margin = new Padding(0);
            BtnHoanThanh.Name = "BtnHoanThanh";
            BtnHoanThanh.Size = new Size(180, 50);
            BtnHoanThanh.TabIndex = 38;
            BtnHoanThanh.Text = "Hoàn thành";
            BtnHoanThanh.UseVisualStyleBackColor = true;
            // 
            // mainLayout
            // 
            mainLayout.BackColor = Color.White;
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(label3, 0, 0);
            mainLayout.Controls.Add(groupBox1, 0, 1);
            mainLayout.Controls.Add(actionPanel, 0, 2);
            mainLayout.Controls.Add(DgvPhanCong, 0, 3);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Margin = new Padding(0);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(25);
            mainLayout.RowCount = 4;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 350F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.Size = new Size(2088, 1627);
            mainLayout.TabIndex = 0;
            // 
            // actionPanel
            // 
            actionPanel.ColumnCount = 2;
            actionPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            actionPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            actionPanel.Controls.Add(BtnHoanThanh, 1, 0);
            actionPanel.Dock = DockStyle.Fill;
            actionPanel.Location = new Point(25, 460);
            actionPanel.Margin = new Padding(0);
            actionPanel.Name = "actionPanel";
            actionPanel.RowCount = 1;
            actionPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            actionPanel.Size = new Size(2038, 85);
            actionPanel.TabIndex = 16;
            // 
            // BaoCaoPhanCong
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(mainLayout);
            Margin = new Padding(0);
            Name = "BaoCaoPhanCong";
            Size = new Size(2088, 1627);
            ((System.ComponentModel.ISupportInitialize)DgvPhanCong).EndInit();
            groupBox1.ResumeLayout(false);
            filterLayout.ResumeLayout(false);
            filterLayout.PerformLayout();
            buttonPanel.ResumeLayout(false);
            mainLayout.ResumeLayout(false);
            actionPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvPhanCong;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox TxtTimKiem;
        private Button BtnXuatExcel;
        private Button BtnLamMoi;
        private Button BtnTimKiem;
        private Label label2;
        private Label label4;
        private DateTimePicker DtpNgaySau;
        private DateTimePicker DtpNgayTruoc;
        private Label label3;
        private Button BtnHoanThanh;
        private TableLayoutPanel filterLayout;
        private FlowLayoutPanel buttonPanel;
        private TableLayoutPanel mainLayout;
        private Panel actionBottomPanel;
        private TableLayoutPanel actionPanel;
    }
}