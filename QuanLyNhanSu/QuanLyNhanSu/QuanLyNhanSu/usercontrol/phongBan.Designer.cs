namespace QuanLyNhanSu.usercontrol
{
    partial class Uc_phongBan
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            BtnXoaPhongBan = new Button();
            BtnSuaPhongBan = new Button();
            BtnTaoPhongBan = new Button();
            label2 = new Label();
            TxtTenPhongBan = new TextBox();
            label1 = new Label();
            TxtMaPhongBan = new TextBox();
            label3 = new Label();
            Dgv_phongBan = new DataGridView();
            MaPhongBan = new DataGridViewTextBoxColumn();
            TenPhongBan = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_phongBan).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtTenPhongBan);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TxtMaPhongBan);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(20, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(2014, 245);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phòng ban";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(BtnXoaPhongBan);
            groupBox2.Controls.Add(BtnSuaPhongBan);
            groupBox2.Controls.Add(BtnTaoPhongBan);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox2.Location = new Point(1480, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(510, 190);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // BtnXoaPhongBan
            // 
            BtnXoaPhongBan.BackColor = Color.White;
            BtnXoaPhongBan.FlatStyle = FlatStyle.Flat;
            BtnXoaPhongBan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnXoaPhongBan.Location = new Point(345, 55);
            BtnXoaPhongBan.Name = "BtnXoaPhongBan";
            BtnXoaPhongBan.Size = new Size(140, 55);
            BtnXoaPhongBan.TabIndex = 9;
            BtnXoaPhongBan.Text = "Xóa";
            BtnXoaPhongBan.UseVisualStyleBackColor = false;
            BtnXoaPhongBan.Click += BtnXoaPhongBan_Click;
            // 
            // BtnSuaPhongBan
            // 
            BtnSuaPhongBan.BackColor = Color.White;
            BtnSuaPhongBan.FlatStyle = FlatStyle.Flat;
            BtnSuaPhongBan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnSuaPhongBan.Location = new Point(185, 55);
            BtnSuaPhongBan.Name = "BtnSuaPhongBan";
            BtnSuaPhongBan.Size = new Size(140, 55);
            BtnSuaPhongBan.TabIndex = 8;
            BtnSuaPhongBan.Text = "Sửa";
            BtnSuaPhongBan.UseVisualStyleBackColor = false;
            BtnSuaPhongBan.Click += BtnSuaPhongBan_Click;
            // 
            // BtnTaoPhongBan
            // 
            BtnTaoPhongBan.BackColor = Color.White;
            BtnTaoPhongBan.FlatStyle = FlatStyle.Flat;
            BtnTaoPhongBan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnTaoPhongBan.Location = new Point(25, 55);
            BtnTaoPhongBan.Name = "BtnTaoPhongBan";
            BtnTaoPhongBan.Size = new Size(140, 55);
            BtnTaoPhongBan.TabIndex = 7;
            BtnTaoPhongBan.Text = "Tạo mới";
            BtnTaoPhongBan.UseVisualStyleBackColor = false;
            BtnTaoPhongBan.Click += BtnTaoPhongBan_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(760, 48);
            label2.Name = "label2";
            label2.Size = new Size(214, 37);
            label2.TabIndex = 4;
            label2.Text = "Tên phòng ban:";
            // 
            // TxtTenPhongBan
            // 
            TxtTenPhongBan.Font = new Font("Segoe UI", 10F);
            TxtTenPhongBan.Location = new Point(760, 88);
            TxtTenPhongBan.Name = "TxtTenPhongBan";
            TxtTenPhongBan.Size = new Size(700, 43);
            TxtTenPhongBan.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(25, 48);
            label1.Name = "label1";
            label1.Size = new Size(210, 37);
            label1.TabIndex = 2;
            label1.Text = "Mã phòng ban:";
            // 
            // TxtMaPhongBan
            // 
            TxtMaPhongBan.Font = new Font("Segoe UI", 10F);
            TxtMaPhongBan.Location = new Point(25, 88);
            TxtMaPhongBan.Name = "TxtMaPhongBan";
            TxtMaPhongBan.Size = new Size(700, 43);
            TxtMaPhongBan.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.Location = new Point(25, 18);
            label3.Name = "label3";
            label3.Size = new Size(459, 65);
            label3.TabIndex = 0;
            label3.Text = "Quản lý phòng ban";
            // 
            // Dgv_phongBan
            // 
            Dgv_phongBan.AllowUserToAddRows = false;
            Dgv_phongBan.AllowUserToDeleteRows = false;
            Dgv_phongBan.AllowUserToResizeRows = false;
            Dgv_phongBan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Dgv_phongBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_phongBan.BackgroundColor = Color.White;
            Dgv_phongBan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Dgv_phongBan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            Dgv_phongBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Dgv_phongBan.ColumnHeadersHeight = 45;
            Dgv_phongBan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            Dgv_phongBan.Columns.AddRange(new DataGridViewColumn[] { MaPhongBan, TenPhongBan });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(220, 235, 250);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            Dgv_phongBan.DefaultCellStyle = dataGridViewCellStyle2;
            Dgv_phongBan.EnableHeadersVisualStyles = false;
            Dgv_phongBan.GridColor = Color.FromArgb(220, 225, 230);
            Dgv_phongBan.Location = new Point(20, 347);
            Dgv_phongBan.MultiSelect = false;
            Dgv_phongBan.Name = "Dgv_phongBan";
            Dgv_phongBan.ReadOnly = true;
            Dgv_phongBan.RowHeadersVisible = false;
            Dgv_phongBan.RowHeadersWidth = 51;
            Dgv_phongBan.RowTemplate.Height = 34;
            Dgv_phongBan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_phongBan.Size = new Size(2014, 1158);
            Dgv_phongBan.TabIndex = 10;
            Dgv_phongBan.CellContentClick += Dgv_phongBan_CellContentClick;
            // 
            // MaPhongBan
            // 
            MaPhongBan.DataPropertyName = "MaPhongBan";
            MaPhongBan.HeaderText = "Mã phòng ban";
            MaPhongBan.MinimumWidth = 10;
            MaPhongBan.Name = "MaPhongBan";
            MaPhongBan.ReadOnly = true;
            // 
            // TenPhongBan
            // 
            TenPhongBan.DataPropertyName = "TenPhongBan";
            TenPhongBan.HeaderText = "Tên phòng ban";
            TenPhongBan.MinimumWidth = 10;
            TenPhongBan.Name = "TenPhongBan";
            TenPhongBan.ReadOnly = true;
            // 
            // Uc_phongBan
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(Dgv_phongBan);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Name = "Uc_phongBan";
            Size = new Size(2054, 1528);
            Load += Uc_phongBan_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Dgv_phongBan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Label label3;
        private Label label1;
        private TextBox TxtMaPhongBan;
        private Label label2;
        private TextBox TxtTenPhongBan;
        private Button BtnXoaPhongBan;
        private Button BtnSuaPhongBan;
        private Button BtnTaoPhongBan;
        private GroupBox groupBox2;
        private DataGridView Dgv_phongBan;
        private DataGridViewTextBoxColumn MaPhongBan;
        private DataGridViewTextBoxColumn TenPhongBan;
    }
}
