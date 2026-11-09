namespace QuanLyNhanSu.usercontrol
{
    partial class TrinhDo
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
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle alternateStyle = new DataGridViewCellStyle();

            TxtMaTrinhDo = new TextBox();
            TxtTenTrinhDo = new TextBox();

            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();

            BtnTaoTrinhDo = new Button();
            BtnSuaTrinhDo = new Button();
            BtnXoaTrinhDo = new Button();

            label1 = new Label();
            label2 = new Label();
            label3 = new Label();

            DgvTrinhDo = new DataGridView();
            MaTrinhDo = new DataGridViewTextBoxColumn();
            TenTrinhDo = new DataGridViewTextBoxColumn();

            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvTrinhDo).BeginInit();
            SuspendLayout();

            //
            // label3 - Tiêu đề
            //
            label3.AutoSize = false;
            label3.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(25, 48, 80);
            label3.Location = new Point(35, 20);
            label3.Name = "label3";
            label3.Size = new Size(1800, 75);
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.TabIndex = 0;
            label3.Text = "QUẢN LÝ TRÌNH ĐỘ NHÂN VIÊN";
            label3.TextAlign = ContentAlignment.MiddleLeft;

            //
            // groupBox1 - Khung nhập liệu
            //
            groupBox1.BackColor = Color.White;
            groupBox1.ForeColor = Color.FromArgb(25, 48, 80);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.Location = new Point(35, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(2018, 365);
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin trình độ";

            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TxtMaTrinhDo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtTenTrinhDo);
            groupBox1.Controls.Add(groupBox2);

            //
            // label1 - Mã trình độ
            //
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(55, 65, 81);
            label1.Location = new Point(35, 62);
            label1.Name = "label1";
            label1.TabIndex = 0;
            label1.Text = "Mã trình độ";

            //
            // TxtMaTrinhDo
            //
            TxtMaTrinhDo.BackColor = Color.FromArgb(250, 252, 255);
            TxtMaTrinhDo.BorderStyle = BorderStyle.FixedSingle;
            TxtMaTrinhDo.Font = new Font("Segoe UI", 12F);
            TxtMaTrinhDo.Location = new Point(35, 112);
            TxtMaTrinhDo.Name = "TxtMaTrinhDo";
            TxtMaTrinhDo.Size = new Size(945, 50);
            TxtMaTrinhDo.TabIndex = 1;

            //
            // label2 - Tên trình độ
            //
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(55, 65, 81);
            label2.Location = new Point(1035, 62);
            label2.Name = "label2";
            label2.TabIndex = 2;
            label2.Text = "Tên trình độ";

            //
            // TxtTenTrinhDo
            //
            TxtTenTrinhDo.BackColor = Color.FromArgb(250, 252, 255);
            TxtTenTrinhDo.BorderStyle = BorderStyle.FixedSingle;
            TxtTenTrinhDo.Font = new Font("Segoe UI", 12F);
            TxtTenTrinhDo.Location = new Point(1035, 112);
            TxtTenTrinhDo.Name = "TxtTenTrinhDo";
            TxtTenTrinhDo.Size = new Size(945, 50);
            TxtTenTrinhDo.Anchor = AnchorStyles.Top |
                AnchorStyles.Left | AnchorStyles.Right;
            TxtTenTrinhDo.TabIndex = 3;

            //
            // groupBox2 - Các nút thao tác
            //
            groupBox2.BackColor = Color.FromArgb(248, 250, 253);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox2.ForeColor = Color.FromArgb(25, 48, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(2012, 135);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao tác";

            groupBox2.Controls.Add(BtnTaoTrinhDo);
            groupBox2.Controls.Add(BtnSuaTrinhDo);
            groupBox2.Controls.Add(BtnXoaTrinhDo);

            //
            // BtnTaoTrinhDo
            //
            BtnTaoTrinhDo.BackColor = Color.FromArgb(35, 91, 155);
            BtnTaoTrinhDo.ForeColor = Color.White;
            BtnTaoTrinhDo.FlatStyle = FlatStyle.Flat;
            BtnTaoTrinhDo.FlatAppearance.BorderSize = 0;
            BtnTaoTrinhDo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnTaoTrinhDo.Location = new Point(35, 46);
            BtnTaoTrinhDo.Name = "BtnTaoTrinhDo";
            BtnTaoTrinhDo.Size = new Size(260, 62);
            BtnTaoTrinhDo.TabIndex = 0;
            BtnTaoTrinhDo.Text = "＋  Tạo trình độ";
            BtnTaoTrinhDo.UseVisualStyleBackColor = false;
            BtnTaoTrinhDo.Cursor = Cursors.Hand;
            BtnTaoTrinhDo.Click += BtnTaoTrinhDo_Click;

            //
            // BtnSuaTrinhDo
            //
            BtnSuaTrinhDo.BackColor = Color.White;
            BtnSuaTrinhDo.ForeColor = Color.FromArgb(25, 48, 80);
            BtnSuaTrinhDo.FlatStyle = FlatStyle.Flat;
            BtnSuaTrinhDo.FlatAppearance.BorderSize = 1;
            BtnSuaTrinhDo.FlatAppearance.BorderColor =
                Color.FromArgb(203, 213, 225);
            BtnSuaTrinhDo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnSuaTrinhDo.Location = new Point(315, 46);
            BtnSuaTrinhDo.Name = "BtnSuaTrinhDo";
            BtnSuaTrinhDo.Size = new Size(260, 62);
            BtnSuaTrinhDo.TabIndex = 1;
            BtnSuaTrinhDo.Text = "Sửa trình độ";
            BtnSuaTrinhDo.UseVisualStyleBackColor = false;
            BtnSuaTrinhDo.Cursor = Cursors.Hand;
            BtnSuaTrinhDo.Click += BtnSuaTrinhDo_Click;

            //
            // BtnXoaTrinhDo
            //
            BtnXoaTrinhDo.BackColor = Color.White;
            BtnXoaTrinhDo.ForeColor = Color.FromArgb(180, 55, 55);
            BtnXoaTrinhDo.FlatStyle = FlatStyle.Flat;
            BtnXoaTrinhDo.FlatAppearance.BorderSize = 1;
            BtnXoaTrinhDo.FlatAppearance.BorderColor =
                Color.FromArgb(230, 205, 205);
            BtnXoaTrinhDo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnXoaTrinhDo.Location = new Point(595, 46);
            BtnXoaTrinhDo.Name = "BtnXoaTrinhDo";
            BtnXoaTrinhDo.Size = new Size(260, 62);
            BtnXoaTrinhDo.TabIndex = 2;
            BtnXoaTrinhDo.Text = "Xóa trình độ";
            BtnXoaTrinhDo.UseVisualStyleBackColor = false;
            BtnXoaTrinhDo.Cursor = Cursors.Hand;
            BtnXoaTrinhDo.Click += BtnXoaTrinhDo_Click;

            //
            // DgvTrinhDo - Danh sách trình độ
            //
            DgvTrinhDo.AllowUserToAddRows = false;
            DgvTrinhDo.AllowUserToDeleteRows = false;
            DgvTrinhDo.AllowUserToResizeRows = false;
            DgvTrinhDo.AutoGenerateColumns = false;
            DgvTrinhDo.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            DgvTrinhDo.BackgroundColor = Color.White;
            DgvTrinhDo.BorderStyle = BorderStyle.FixedSingle;
            DgvTrinhDo.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;
            DgvTrinhDo.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;

            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = Color.FromArgb(25, 48, 80);
            headerStyle.ForeColor = Color.White;
            headerStyle.SelectionBackColor = Color.FromArgb(25, 48, 80);
            headerStyle.SelectionForeColor = Color.White;
            headerStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            headerStyle.WrapMode = DataGridViewTriState.False;

            DgvTrinhDo.ColumnHeadersDefaultCellStyle = headerStyle;
            DgvTrinhDo.ColumnHeadersHeight = 58;
            DgvTrinhDo.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            cellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cellStyle.BackColor = Color.White;
            cellStyle.ForeColor = Color.FromArgb(40, 55, 75);
            cellStyle.SelectionBackColor = Color.FromArgb(220, 235, 250);
            cellStyle.SelectionForeColor = Color.FromArgb(25, 48, 80);
            cellStyle.Font = new Font("Segoe UI", 11F);
            cellStyle.Padding = new Padding(12, 0, 12, 0);

            DgvTrinhDo.DefaultCellStyle = cellStyle;

            alternateStyle.BackColor = Color.FromArgb(247, 250, 253);
            alternateStyle.ForeColor = Color.FromArgb(40, 55, 75);
            alternateStyle.SelectionBackColor =
                Color.FromArgb(220, 235, 250);
            alternateStyle.SelectionForeColor =
                Color.FromArgb(25, 48, 80);

            DgvTrinhDo.AlternatingRowsDefaultCellStyle = alternateStyle;

            DgvTrinhDo.EnableHeadersVisualStyles = false;
            DgvTrinhDo.GridColor = Color.FromArgb(225, 230, 237);
            DgvTrinhDo.Location = new Point(35, 510);
            DgvTrinhDo.Name = "DgvTrinhDo";
            DgvTrinhDo.Size = new Size(2018, 1082);
            DgvTrinhDo.Anchor = AnchorStyles.Top |
                AnchorStyles.Bottom | AnchorStyles.Left |
                AnchorStyles.Right;
            DgvTrinhDo.MultiSelect = false;
            DgvTrinhDo.ReadOnly = true;
            DgvTrinhDo.RowHeadersVisible = false;
            DgvTrinhDo.RowTemplate.Height = 48;
            DgvTrinhDo.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            DgvTrinhDo.TabIndex = 2;

            //
            // MaTrinhDo
            //
            MaTrinhDo.DataPropertyName = "MaTrinhDo";
            MaTrinhDo.HeaderText = "Mã trình độ";
            MaTrinhDo.MinimumWidth = 120;
            MaTrinhDo.Name = "MaTrinhDo";
            MaTrinhDo.ReadOnly = true;
            MaTrinhDo.FillWeight = 35F;

            //
            // TenTrinhDo
            //
            TenTrinhDo.DataPropertyName = "TenTrinhDo";
            TenTrinhDo.HeaderText = "Tên trình độ";
            TenTrinhDo.MinimumWidth = 200;
            TenTrinhDo.Name = "TenTrinhDo";
            TenTrinhDo.ReadOnly = true;
            TenTrinhDo.FillWeight = 65F;

            DgvTrinhDo.Columns.AddRange(
                new DataGridViewColumn[]
                {
            MaTrinhDo,
            TenTrinhDo
                });

            DgvTrinhDo.CellContentClick +=
                DgvTrinhDo_CellContentClick;

            //
            // TrinhDo
            //
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(245, 247, 251);
            Controls.Add(groupBox1);
            Controls.Add(DgvTrinhDo);
            Controls.Add(label3);
            Name = "TrinhDo";
            Size = new Size(2088, 1627);
            Load += TrinhDo_Load;

            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvTrinhDo).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private TextBox TxtMaTrinhDo;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button BtnXoaTrinhDo;
        private Button BtnSuaTrinhDo;
        private Button BtnTaoTrinhDo;
        private Label label2;
        private TextBox TxtTenTrinhDo;
        private Label label1;
        private DataGridView DgvTrinhDo;
        private Label label3;
        private DataGridViewTextBoxColumn MaTrinhDo;
        private DataGridViewTextBoxColumn TenTrinhDo;
    }
}
