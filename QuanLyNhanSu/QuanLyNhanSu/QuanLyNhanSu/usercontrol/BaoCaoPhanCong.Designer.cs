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
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle rowStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle alternateStyle = new DataGridViewCellStyle();

            DgvPhanCong = new DataGridView();
            groupBox1 = new GroupBox();
            filterLayout = new TableLayoutPanel();

            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();

            DtpNgayTruoc = new DateTimePicker();
            DtpNgaySau = new DateTimePicker();
            TxtTimKiem = new TextBox();

            buttonPanel = new FlowLayoutPanel();
            BtnTimKiem = new Button();
            BtnLamMoi = new Button();
            BtnXuatExcel = new Button();
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
            DgvPhanCong.AutoGenerateColumns = true;
            DgvPhanCong.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            DgvPhanCong.BackgroundColor = Color.White;
            DgvPhanCong.BorderStyle = BorderStyle.None;
            DgvPhanCong.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;
            DgvPhanCong.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;

            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = Color.FromArgb(25, 48, 80);
            headerStyle.ForeColor = Color.White;
            headerStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            headerStyle.SelectionBackColor = Color.FromArgb(25, 48, 80);
            headerStyle.SelectionForeColor = Color.White;
            headerStyle.WrapMode = DataGridViewTriState.True;

            DgvPhanCong.ColumnHeadersDefaultCellStyle = headerStyle;
            DgvPhanCong.ColumnHeadersHeight = 56;
            DgvPhanCong.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            rowStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            rowStyle.BackColor = Color.White;
            rowStyle.Font = new Font("Segoe UI", 10F);
            rowStyle.ForeColor = Color.FromArgb(40, 55, 75);
            rowStyle.SelectionBackColor = Color.FromArgb(220, 235, 250);
            rowStyle.SelectionForeColor = Color.FromArgb(25, 48, 80);
            rowStyle.Padding = new Padding(8, 0, 8, 0);

            DgvPhanCong.DefaultCellStyle = rowStyle;

            alternateStyle.BackColor = Color.FromArgb(247, 250, 253);
            alternateStyle.ForeColor = Color.FromArgb(40, 55, 75);
            alternateStyle.SelectionBackColor =
                Color.FromArgb(220, 235, 250);
            alternateStyle.SelectionForeColor = Color.FromArgb(25, 48, 80);

            DgvPhanCong.AlternatingRowsDefaultCellStyle = alternateStyle;

            DgvPhanCong.Dock = DockStyle.Fill;
            DgvPhanCong.EnableHeadersVisualStyles = false;
            DgvPhanCong.GridColor = Color.FromArgb(225, 230, 237);
            DgvPhanCong.Margin = new Padding(0);
            DgvPhanCong.MultiSelect = false;
            DgvPhanCong.Name = "DgvPhanCong";
            DgvPhanCong.ReadOnly = true;
            DgvPhanCong.RowHeadersVisible = false;
            DgvPhanCong.RowTemplate.Height = 46;
            DgvPhanCong.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            DgvPhanCong.TabIndex = 3;
            //
            // groupBox1
            //
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(filterLayout);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(25, 48, 80);
            groupBox1.Margin = new Padding(0, 0, 0, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(18, 30, 18, 14);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm và lọc công việc";

            //
            // filterLayout
            //
            filterLayout.BackColor = Color.White;
            filterLayout.ColumnCount = 4;
            filterLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Absolute, 225F));
            filterLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Absolute, 340F));
            filterLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Absolute, 115F));
            filterLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F));

            filterLayout.Controls.Add(label4, 0, 0);
            filterLayout.Controls.Add(DtpNgayTruoc, 1, 0);
            filterLayout.Controls.Add(label1, 2, 0);
            filterLayout.Controls.Add(DtpNgaySau, 3, 0);

            filterLayout.Controls.Add(label2, 0, 1);
            filterLayout.Controls.Add(TxtTimKiem, 1, 1);

            filterLayout.Controls.Add(buttonPanel, 1, 2);
            filterLayout.SetColumnSpan(TxtTimKiem, 3);
            filterLayout.SetColumnSpan(buttonPanel, 3);

            filterLayout.Dock = DockStyle.Fill;
            filterLayout.Margin = new Padding(0);
            filterLayout.Name = "filterLayout";
            filterLayout.Padding = new Padding(12, 8, 12, 8);
            filterLayout.RowCount = 3;
            filterLayout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 65F));
            filterLayout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 65F));
            filterLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F));
            filterLayout.TabIndex = 0;

            //
            // label4 - Từ ngày
            //
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(25, 48, 80);
            label4.Name = "label4";
            label4.Text = "Từ ngày:";

            //
            // DtpNgayTruoc
            //
            DtpNgayTruoc.Anchor = AnchorStyles.Left;
            DtpNgayTruoc.CustomFormat = "dd/MM/yyyy";
            DtpNgayTruoc.Font = new Font("Segoe UI", 10F);
            DtpNgayTruoc.Format = DateTimePickerFormat.Custom;
            DtpNgayTruoc.Margin = new Padding(0, 5, 12, 5);
            DtpNgayTruoc.Name = "DtpNgayTruoc";
            DtpNgayTruoc.Size = new Size(295, 43);
            DtpNgayTruoc.TabIndex = 1;

            //
            // label1 - Đến ngày
            //
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(25, 48, 80);
            label1.Name = "label1";
            label1.Text = "Đến:";

            //
            // DtpNgaySau
            //
            DtpNgaySau.Anchor = AnchorStyles.Left;
            DtpNgaySau.CustomFormat = "dd/MM/yyyy";
            DtpNgaySau.Font = new Font("Segoe UI", 10F);
            DtpNgaySau.Format = DateTimePickerFormat.Custom;
            DtpNgaySau.Margin = new Padding(0, 5, 0, 5);
            DtpNgaySau.Name = "DtpNgaySau";
            DtpNgaySau.Size = new Size(295, 43);
            DtpNgaySau.TabIndex = 2;

            //
            // label2 - Tìm kiếm
            //
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(25, 48, 80);
            label2.Name = "label2";
            label2.Text = "Tìm kiếm:";

            //
            // TxtTimKiem
            //
            TxtTimKiem.Anchor = AnchorStyles.Left;
            TxtTimKiem.BackColor = Color.FromArgb(250, 252, 255);
            TxtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            TxtTimKiem.Font = new Font("Segoe UI", 10F);
            TxtTimKiem.Margin = new Padding(0, 5, 0, 5);
            TxtTimKiem.Name = "TxtTimKiem";
            TxtTimKiem.Size = new Size(750, 43);
            TxtTimKiem.TabIndex = 3;
            TxtTimKiem.TextChanged += TxtTimKiem_TextChanged;

            //
            // buttonPanel
            //
            buttonPanel.AutoScroll = true;
            buttonPanel.Controls.Add(BtnTimKiem);
            buttonPanel.Controls.Add(BtnLamMoi);
            buttonPanel.Controls.Add(BtnXuatExcel);
            buttonPanel.Dock = DockStyle.Fill;
            buttonPanel.FlowDirection = FlowDirection.LeftToRight;
            buttonPanel.Margin = new Padding(0);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Padding = new Padding(0, 9, 0, 0);
            buttonPanel.WrapContents = false;

            //
            // BtnTimKiem
            //
            BtnTimKiem.BackColor = Color.FromArgb(35, 91, 155);
            BtnTimKiem.FlatAppearance.BorderSize = 0;
            BtnTimKiem.FlatStyle = FlatStyle.Flat;
            BtnTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnTimKiem.ForeColor = Color.White;
            BtnTimKiem.Margin = new Padding(0, 0, 15, 0);
            BtnTimKiem.Name = "BtnTimKiem";
            BtnTimKiem.Size = new Size(190, 54);
            BtnTimKiem.TabIndex = 4;
            BtnTimKiem.Text = "Tìm kiếm";
            BtnTimKiem.UseVisualStyleBackColor = false;
            BtnTimKiem.Click += BtnTimKiem_Click;

            //
            // BtnLamMoi
            //
            BtnLamMoi.BackColor = Color.White;
            BtnLamMoi.FlatAppearance.BorderColor =
                Color.FromArgb(205, 215, 225);
            BtnLamMoi.FlatStyle = FlatStyle.Flat;
            BtnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnLamMoi.ForeColor = Color.FromArgb(25, 48, 80);
            BtnLamMoi.Margin = new Padding(0, 0, 15, 0);
            BtnLamMoi.Name = "BtnLamMoi";
            BtnLamMoi.Size = new Size(190, 54);
            BtnLamMoi.TabIndex = 5;
            BtnLamMoi.Text = "Làm mới";
            BtnLamMoi.UseVisualStyleBackColor = false;
            BtnLamMoi.Click += BtnLamMoi_Click;

            //
            // BtnXuatExcel
            //
            BtnXuatExcel.BackColor = Color.FromArgb(22, 101, 75);
            BtnXuatExcel.FlatAppearance.BorderSize = 0;
            BtnXuatExcel.FlatStyle = FlatStyle.Flat;
            BtnXuatExcel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnXuatExcel.ForeColor = Color.White;
            BtnXuatExcel.Margin = new Padding(0);
            BtnXuatExcel.Name = "BtnXuatExcel";
            BtnXuatExcel.Size = new Size(190, 54);
            BtnXuatExcel.TabIndex = 6;
            BtnXuatExcel.Text = "Xuất Excel";
            BtnXuatExcel.UseVisualStyleBackColor = false;
            BtnXuatExcel.Click += BtnXuatExcel_Click;

            //
            // label3 - Tiêu đề
            //
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(25, 48, 80);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Padding = new Padding(6, 0, 0, 0);
            label3.TabIndex = 0;
            label3.Text = "BÁO CÁO PHÂN CÔNG";
            label3.TextAlign = ContentAlignment.MiddleLeft;

            //
            // BtnHoanThanh
            //
            BtnHoanThanh.Anchor = AnchorStyles.None;
            BtnHoanThanh.BackColor = Color.FromArgb(35, 91, 155);
            BtnHoanThanh.FlatAppearance.BorderSize = 0;
            BtnHoanThanh.FlatStyle = FlatStyle.Flat;
            BtnHoanThanh.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnHoanThanh.ForeColor = Color.White;
            BtnHoanThanh.Name = "BtnHoanThanh";
            BtnHoanThanh.Size = new Size(210, 54);
            BtnHoanThanh.TabIndex = 7;
            BtnHoanThanh.Text = "Hoàn thành";
            BtnHoanThanh.UseVisualStyleBackColor = false;
            BtnHoanThanh.Visible = false;

            // Không gán Click ở đây:
            // BaoCaoPhanCong.cs đã đăng ký sự kiện trong constructor.

            //
            // mainLayout
            //
            mainLayout.BackColor = Color.FromArgb(245, 247, 251);
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(label3, 0, 0);
            mainLayout.Controls.Add(groupBox1, 0, 1);
            mainLayout.Controls.Add(actionPanel, 0, 2);
            mainLayout.Controls.Add(DgvPhanCong, 0, 3);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Margin = new Padding(0);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(24);
            mainLayout.RowCount = 4;
            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 95F));
            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 300F));
            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 0F));
            mainLayout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F));
            mainLayout.TabIndex = 0;

            //
            // actionPanel
            //
            actionPanel.ColumnCount = 2;
            actionPanel.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F));
            actionPanel.ColumnStyles.Add(
                new ColumnStyle(SizeType.Absolute, 230F));
            actionPanel.Controls.Add(BtnHoanThanh, 1, 0);
            actionPanel.Dock = DockStyle.Fill;
            actionPanel.Margin = new Padding(0);
            actionPanel.Name = "actionPanel";
            actionPanel.RowCount = 1;
            actionPanel.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F));
            actionPanel.TabIndex = 2;

            //
            // BaoCaoPhanCong
            //
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(245, 247, 251);
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