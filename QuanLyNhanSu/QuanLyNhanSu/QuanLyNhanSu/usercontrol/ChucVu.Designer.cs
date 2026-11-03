namespace QuanLyNhanSu.usercontrol
{
    partial class ChucVu
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

            groupBox1 = new GroupBox();
            label4 = new Label();
            TxtLuongChucVu = new TextBox();

            groupBox2 = new GroupBox();
            BtnXoaChucVu = new Button();
            BtnSuaChucVu = new Button();
            BtnTaoChucVu = new Button();

            label2 = new Label();
            TxtTenChucVu = new TextBox();

            label1 = new Label();
            TxtMaChucVu = new TextBox();

            label3 = new Label();

            DgvChucVu = new DataGridView();

            ChucVuID = new DataGridViewTextBoxColumn();
            TenChucVu = new DataGridViewTextBoxColumn();
            Luong = new DataGridViewTextBoxColumn();

            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvChucVu).BeginInit();
            SuspendLayout();

            // 
            // groupBox1
            // 
            groupBox1.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            groupBox1.BackColor = Color.FromArgb(245, 247, 250);

            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxtLuongChucVu);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtTenChucVu);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TxtMaChucVu);

            groupBox1.Location = new Point(25, 85);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(15);
            groupBox1.Size = new Size(2038, 445);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;

            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font(
                "Segoe UI",
                10.5F,
                FontStyle.Bold
            );

            label4.ForeColor = Color.FromArgb(40, 40, 40);
            label4.Location = new Point(20, 191);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(220, 38);
            label4.TabIndex = 6;
            label4.Text = "Lương chức vụ:";

            // 
            // TxtLuongChucVu
            // 
            TxtLuongChucVu.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            TxtLuongChucVu.Font =
                new Font("Segoe UI", 10.5F);

            TxtLuongChucVu.Location = new Point(20, 226);
            TxtLuongChucVu.Margin = new Padding(0);
            TxtLuongChucVu.Name = "TxtLuongChucVu";
            TxtLuongChucVu.Size = new Size(1998, 45);
            TxtLuongChucVu.TabIndex = 7;

            // 
            // groupBox2
            // 
            groupBox2.Anchor =
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            groupBox2.BackColor = Color.Transparent;

            groupBox2.Controls.Add(BtnXoaChucVu);
            groupBox2.Controls.Add(BtnSuaChucVu);
            groupBox2.Controls.Add(BtnTaoChucVu);

            groupBox2.Location = new Point(20, 295);
            groupBox2.Margin = new Padding(0);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(0);
            groupBox2.Size = new Size(1998, 125);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;

            // 
            // BtnXoaChucVu
            // 
            BtnXoaChucVu.Anchor = AnchorStyles.Top;

            BtnXoaChucVu.BackColor = Color.White;

            BtnXoaChucVu.FlatAppearance.BorderColor =
                Color.FromArgb(190, 195, 200);

            BtnXoaChucVu.FlatStyle = FlatStyle.Flat;

            BtnXoaChucVu.Font =
                new Font("Segoe UI", 10.5F, FontStyle.Bold);

            BtnXoaChucVu.ForeColor =
                Color.FromArgb(40, 40, 40);

            BtnXoaChucVu.Location =
                new Point(1120, 32);

            BtnXoaChucVu.Margin = new Padding(0);
            BtnXoaChucVu.Name = "BtnXoaChucVu";
            BtnXoaChucVu.Size = new Size(250, 50);
            BtnXoaChucVu.TabIndex = 11;
            BtnXoaChucVu.Text = "Xóa chức vụ";
            BtnXoaChucVu.UseVisualStyleBackColor = false;
            BtnXoaChucVu.Click += BtnXoaChucVu_Click;

            // 
            // BtnSuaChucVu
            // 
            BtnSuaChucVu.Anchor = AnchorStyles.Top;

            BtnSuaChucVu.BackColor = Color.White;

            BtnSuaChucVu.FlatAppearance.BorderColor =
                Color.FromArgb(190, 195, 200);

            BtnSuaChucVu.FlatStyle = FlatStyle.Flat;

            BtnSuaChucVu.Font =
                new Font("Segoe UI", 10.5F, FontStyle.Bold);

            BtnSuaChucVu.ForeColor =
                Color.FromArgb(40, 40, 40);

            BtnSuaChucVu.Location =
                new Point(850, 32);

            BtnSuaChucVu.Margin = new Padding(0);
            BtnSuaChucVu.Name = "BtnSuaChucVu";
            BtnSuaChucVu.Size = new Size(250, 50);
            BtnSuaChucVu.TabIndex = 10;
            BtnSuaChucVu.Text = "Sửa chức vụ";
            BtnSuaChucVu.UseVisualStyleBackColor = false;
            BtnSuaChucVu.Click += BtnSuaChucVu_Click;

            // 
            // BtnTaoChucVu
            // 
            BtnTaoChucVu.Anchor = AnchorStyles.Top;

            BtnTaoChucVu.BackColor = Color.White;

            BtnTaoChucVu.FlatAppearance.BorderColor =
                Color.FromArgb(190, 195, 200);

            BtnTaoChucVu.FlatStyle = FlatStyle.Flat;

            BtnTaoChucVu.Font =
                new Font("Segoe UI", 10.5F, FontStyle.Bold);

            BtnTaoChucVu.ForeColor =
                Color.FromArgb(40, 40, 40);

            BtnTaoChucVu.Location =
                new Point(580, 32);

            BtnTaoChucVu.Margin = new Padding(0);
            BtnTaoChucVu.Name = "BtnTaoChucVu";
            BtnTaoChucVu.Size = new Size(250, 50);
            BtnTaoChucVu.TabIndex = 9;
            BtnTaoChucVu.Text = "Tạo chức vụ";
            BtnTaoChucVu.UseVisualStyleBackColor = false;
            BtnTaoChucVu.Click += BtnTaoChucVu_Click;

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font =
                new Font("Segoe UI", 10.5F, FontStyle.Bold);

            label2.ForeColor =
                Color.FromArgb(40, 40, 40);

            label2.Location = new Point(20, 108);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(180, 38);
            label2.TabIndex = 4;
            label2.Text = "Tên chức vụ:";

            // 
            // TxtTenChucVu
            // 
            TxtTenChucVu.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            TxtTenChucVu.Font =
                new Font("Segoe UI", 10.5F);

            TxtTenChucVu.Location = new Point(20, 143);
            TxtTenChucVu.Margin = new Padding(0);
            TxtTenChucVu.Name = "TxtTenChucVu";
            TxtTenChucVu.Size = new Size(1998, 45);
            TxtTenChucVu.TabIndex = 5;

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font =
                new Font("Segoe UI", 10.5F, FontStyle.Bold);

            label1.ForeColor =
                Color.FromArgb(40, 40, 40);

            label1.Location = new Point(20, 25);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(177, 38);
            label1.TabIndex = 2;
            label1.Text = "Mã chức vụ:";

            // 
            // TxtMaChucVu
            // 
            TxtMaChucVu.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            TxtMaChucVu.BackColor =
                Color.FromArgb(235, 235, 235);

            TxtMaChucVu.Font =
                new Font("Segoe UI", 10.5F);

            TxtMaChucVu.Location =
                new Point(20, 60);

            TxtMaChucVu.Margin =
                new Padding(0);

            TxtMaChucVu.Name =
                "TxtMaChucVu";

            TxtMaChucVu.ReadOnly = true;

            TxtMaChucVu.Size =
                new Size(1998, 45);

            TxtMaChucVu.TabIndex = 3;

            TxtMaChucVu.TabStop = false;

            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font =
                new Font("Segoe UI", 22F, FontStyle.Bold);

            label3.ForeColor =
                Color.FromArgb(30, 30, 30);

            label3.Location = new Point(25, 18);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(767, 78);
            label3.TabIndex = 0;
            label3.Text = "Quản lý chức vụ nhân viên";
            label3.TextAlign = ContentAlignment.MiddleLeft;

            // 
            // DgvChucVu
            // 
            DgvChucVu.AllowUserToAddRows = false;
            DgvChucVu.AllowUserToDeleteRows = false;
            DgvChucVu.AllowUserToResizeRows = false;

            dataGridViewCellStyle1.BackColor =
                Color.FromArgb(248, 250, 252);

            dataGridViewCellStyle1.ForeColor =
                Color.FromArgb(40, 40, 40);

            dataGridViewCellStyle1.SelectionBackColor =
                Color.FromArgb(220, 235, 250);

            dataGridViewCellStyle1.SelectionForeColor =
                Color.Black;

            DgvChucVu.AlternatingRowsDefaultCellStyle =
                dataGridViewCellStyle1;

            // FULL NGANG VÀ DỌC PHẦN CÒN LẠI
            DgvChucVu.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            DgvChucVu.BackgroundColor = Color.White;

            DgvChucVu.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            DgvChucVu.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;

            dataGridViewCellStyle2.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dataGridViewCellStyle2.BackColor =
                Color.FromArgb(44, 62, 80);

            dataGridViewCellStyle2.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);

            dataGridViewCellStyle2.ForeColor =
                Color.White;

            dataGridViewCellStyle2.SelectionBackColor =
                Color.FromArgb(44, 62, 80);

            dataGridViewCellStyle2.SelectionForeColor =
                Color.White;

            dataGridViewCellStyle2.WrapMode =
                DataGridViewTriState.False;

            DgvChucVu.ColumnHeadersDefaultCellStyle =
                dataGridViewCellStyle2;

            DgvChucVu.ColumnHeadersHeight = 50;

            DgvChucVu.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            DgvChucVu.Columns.AddRange(
                new DataGridViewColumn[]
                {
            ChucVuID,
            TenChucVu,
            Luong
                });

            dataGridViewCellStyle3.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            dataGridViewCellStyle3.BackColor =
                Color.White;

            dataGridViewCellStyle3.Font =
                new Font("Segoe UI", 10F);

            dataGridViewCellStyle3.ForeColor =
                Color.FromArgb(40, 40, 40);

            dataGridViewCellStyle3.Padding =
                new Padding(8, 0, 8, 0);

            dataGridViewCellStyle3.SelectionBackColor =
                Color.FromArgb(220, 235, 250);

            dataGridViewCellStyle3.SelectionForeColor =
                Color.Black;

            dataGridViewCellStyle3.WrapMode =
                DataGridViewTriState.False;

            DgvChucVu.DefaultCellStyle =
                dataGridViewCellStyle3;

            DgvChucVu.EnableHeadersVisualStyles = false;

            DgvChucVu.GridColor =
                Color.FromArgb(220, 225, 230);

            // CÁC CỘT TỰ CHIA ĐỀU FULL NGANG
            DgvChucVu.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            DgvChucVu.Location =
                new Point(25, 555);

            DgvChucVu.Margin =
                new Padding(0);

            DgvChucVu.MultiSelect = false;

            DgvChucVu.Name =
                "DgvChucVu";

            DgvChucVu.ReadOnly = true;

            DgvChucVu.RowHeadersVisible = false;

            DgvChucVu.RowTemplate.Height = 40;

            DgvChucVu.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            // Chiều rộng sẽ được Anchor tự kéo
            DgvChucVu.Size =
                new Size(2038, 1047);

            DgvChucVu.TabIndex = 12;

            DgvChucVu.CellContentClick +=
                DgvChucVu_CellContentClick;

            // 
            // ChucVuID
            // 
            ChucVuID.DataPropertyName = "ChucVuID";
            ChucVuID.HeaderText = "Mã chức vụ";
            ChucVuID.MinimumWidth = 120;
            ChucVuID.Name = "ChucVuID";
            ChucVuID.ReadOnly = true;
            ChucVuID.FillWeight = 20F;

            // 
            // TenChucVu
            // 
            TenChucVu.DataPropertyName = "TenChucVu";
            TenChucVu.HeaderText = "Tên chức vụ";
            TenChucVu.MinimumWidth = 200;
            TenChucVu.Name = "TenChucVu";
            TenChucVu.ReadOnly = true;
            TenChucVu.FillWeight = 50F;

            // 
            // Luong
            // 
            Luong.DataPropertyName = "Luong";
            Luong.HeaderText = "Lương";
            Luong.MinimumWidth = 200;
            Luong.Name = "Luong";
            Luong.ReadOnly = true;
            Luong.FillWeight = 30F;

            // 
            // ChucVu
            // 
            AutoScaleMode = AutoScaleMode.None;

            BackColor = Color.White;

            Controls.Add(DgvChucVu);
            Controls.Add(groupBox1);
            Controls.Add(label3);

            Margin = new Padding(0);

            Name = "ChucVu";

            Size = new Size(2088, 1627);

            Load += ChucVu_Load;

            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();

            groupBox2.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)DgvChucVu).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button BtnXoaChucVu;
        private Button BtnSuaChucVu;
        private Button BtnTaoChucVu;
        private Label label2;
        private TextBox TxtTenChucVu;
        private Label label1;
        private TextBox TxtMaChucVu;
        private Label label3;
        private DataGridView DgvChucVu;
        private Label label4;
        private TextBox TxtLuongChucVu;
        private DataGridViewTextBoxColumn ChucVuID;
        private DataGridViewTextBoxColumn TenChucVu;
        private DataGridViewTextBoxColumn Luong;
    }
}
