namespace QuanLyNhanSu.usercontrol
{
    partial class PhuCap
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            label4 = new Label();
            TxtSoTienPhuCap = new TextBox();
            groupBox2 = new GroupBox();
            BtnXoaPhuCap = new Button();
            BtnSuaPhuCap = new Button();
            BtnTaoPhuCap = new Button();
            label2 = new Label();
            TxtTenPhuCap = new TextBox();
            label1 = new Label();
            TxtMaPhuCap = new TextBox();
            DgvPhuCap = new DataGridView();
            MaPhuCap = new DataGridViewTextBoxColumn();
            TenPhuCap = new DataGridViewTextBoxColumn();
            SoTien = new DataGridViewTextBoxColumn();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPhuCap).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxtSoTienPhuCap);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtTenPhuCap);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TxtMaPhuCap);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(45, 65, 90);
            groupBox1.Location = new Point(25, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(15);
            groupBox1.Size = new Size(2038, 510);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phụ cấp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(25, 225);
            label4.Name = "label4";
            label4.Size = new Size(113, 37);
            label4.TabIndex = 7;
            label4.Text = "Số tiền:";
            // 
            // TxtSoTienPhuCap
            // 
            TxtSoTienPhuCap.Font = new Font("Segoe UI", 11F);
            TxtSoTienPhuCap.Location = new Point(25, 260);
            TxtSoTienPhuCap.Name = "TxtSoTienPhuCap";
            TxtSoTienPhuCap.Size = new Size(1980, 47);
            TxtSoTienPhuCap.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnXoaPhuCap);
            groupBox2.Controls.Add(BtnSuaPhuCap);
            groupBox2.Controls.Add(BtnTaoPhuCap);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(15, 363);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(2008, 132);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // BtnXoaPhuCap
            // 
            BtnXoaPhuCap.BackColor = Color.FromArgb(190, 65, 65);
            BtnXoaPhuCap.FlatAppearance.BorderSize = 0;
            BtnXoaPhuCap.FlatStyle = FlatStyle.Flat;
            BtnXoaPhuCap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnXoaPhuCap.ForeColor = Color.White;
            BtnXoaPhuCap.Location = new Point(1120, 42);
            BtnXoaPhuCap.Name = "BtnXoaPhuCap";
            BtnXoaPhuCap.Size = new Size(240, 52);
            BtnXoaPhuCap.TabIndex = 33;
            BtnXoaPhuCap.Text = "Xóa phụ cấp";
            BtnXoaPhuCap.UseVisualStyleBackColor = false;
            BtnXoaPhuCap.Click += BtnXoaPhuCap_Click;
            // 
            // BtnSuaPhuCap
            // 
            BtnSuaPhuCap.BackColor = Color.FromArgb(41, 113, 170);
            BtnSuaPhuCap.FlatAppearance.BorderSize = 0;
            BtnSuaPhuCap.FlatStyle = FlatStyle.Flat;
            BtnSuaPhuCap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnSuaPhuCap.ForeColor = Color.White;
            BtnSuaPhuCap.Location = new Point(860, 42);
            BtnSuaPhuCap.Name = "BtnSuaPhuCap";
            BtnSuaPhuCap.Size = new Size(240, 52);
            BtnSuaPhuCap.TabIndex = 33;
            BtnSuaPhuCap.Text = "Sửa phụ cấp";
            BtnSuaPhuCap.UseVisualStyleBackColor = false;
            BtnSuaPhuCap.Click += BtnSuaPhuCap_Click;
            // 
            // BtnTaoPhuCap
            // 
            BtnTaoPhuCap.BackColor = Color.FromArgb(46, 125, 80);
            BtnTaoPhuCap.FlatAppearance.BorderSize = 0;
            BtnTaoPhuCap.FlatStyle = FlatStyle.Flat;
            BtnTaoPhuCap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnTaoPhuCap.ForeColor = Color.White;
            BtnTaoPhuCap.Location = new Point(600, 42);
            BtnTaoPhuCap.Name = "BtnTaoPhuCap";
            BtnTaoPhuCap.Size = new Size(240, 52);
            BtnTaoPhuCap.TabIndex = 33;
            BtnTaoPhuCap.Text = "Tạo phụ cấp";
            BtnTaoPhuCap.UseVisualStyleBackColor = false;
            BtnTaoPhuCap.Click += BtnTaoPhuCap_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(25, 135);
            label2.Name = "label2";
            label2.Size = new Size(177, 37);
            label2.TabIndex = 5;
            label2.Text = "Tên phụ cấp:";
            // 
            // TxtTenPhuCap
            // 
            TxtTenPhuCap.Font = new Font("Segoe UI", 11F);
            TxtTenPhuCap.Location = new Point(25, 170);
            TxtTenPhuCap.Name = "TxtTenPhuCap";
            TxtTenPhuCap.Size = new Size(1980, 47);
            TxtTenPhuCap.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(25, 45);
            label1.Name = "label1";
            label1.Size = new Size(173, 37);
            label1.TabIndex = 3;
            label1.Text = "Mã phụ cấp:";
            // 
            // TxtMaPhuCap
            // 
            TxtMaPhuCap.Font = new Font("Segoe UI", 11F);
            TxtMaPhuCap.Location = new Point(25, 80);
            TxtMaPhuCap.Name = "TxtMaPhuCap";
            TxtMaPhuCap.Size = new Size(1980, 47);
            TxtMaPhuCap.TabIndex = 2;
            // 
            // DgvPhuCap
            // 
            DgvPhuCap.AllowUserToAddRows = false;
            DgvPhuCap.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 248, 252);
            DgvPhuCap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvPhuCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPhuCap.BackgroundColor = Color.White;
            DgvPhuCap.BorderStyle = BorderStyle.None;
            DgvPhuCap.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvPhuCap.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DgvPhuCap.ColumnHeadersHeight = 50;
            DgvPhuCap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DgvPhuCap.Columns.AddRange(new DataGridViewColumn[] { MaPhuCap, TenPhuCap, SoTien });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(50, 55, 65);
            dataGridViewCellStyle3.Padding = new Padding(10, 5, 10, 5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(218, 232, 248);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(35, 55, 80);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DgvPhuCap.DefaultCellStyle = dataGridViewCellStyle3;
            DgvPhuCap.Dock = DockStyle.Bottom;
            DgvPhuCap.EnableHeadersVisualStyles = false;
            DgvPhuCap.GridColor = Color.FromArgb(230, 234, 240);
            DgvPhuCap.Location = new Point(0, 591);
            DgvPhuCap.MultiSelect = false;
            DgvPhuCap.Name = "DgvPhuCap";
            DgvPhuCap.ReadOnly = true;
            DgvPhuCap.RowHeadersVisible = false;
            DgvPhuCap.RowHeadersWidth = 82;
            DgvPhuCap.RowTemplate.Height = 45;
            DgvPhuCap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvPhuCap.Size = new Size(2088, 1036);
            DgvPhuCap.TabIndex = 11;
            DgvPhuCap.CellContentClick += DgvPhuCap_CellContentClick;
            // 
            // MaPhuCap
            // 
            MaPhuCap.DataPropertyName = "MaPhuCap";
            MaPhuCap.FillWeight = 25F;
            MaPhuCap.HeaderText = "MÃ PHỤ CẤP";
            MaPhuCap.MinimumWidth = 10;
            MaPhuCap.Name = "MaPhuCap";
            MaPhuCap.ReadOnly = true;
            // 
            // TenPhuCap
            // 
            TenPhuCap.DataPropertyName = "TenPhuCap";
            TenPhuCap.FillWeight = 45F;
            TenPhuCap.HeaderText = "TÊN PHỤ CẤP";
            TenPhuCap.MinimumWidth = 10;
            TenPhuCap.Name = "TenPhuCap";
            TenPhuCap.ReadOnly = true;
            // 
            // SoTien
            // 
            SoTien.DataPropertyName = "SoTien";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            SoTien.DefaultCellStyle = dataGridViewCellStyle2;
            SoTien.FillWeight = 30F;
            SoTien.HeaderText = "SỐ TIỀN";
            SoTien.MinimumWidth = 10;
            SoTien.Name = "SoTien";
            SoTien.ReadOnly = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(35, 55, 80);
            label3.Location = new Point(25, 15);
            label3.Name = "label3";
            label3.Size = new Size(740, 65);
            label3.TabIndex = 10;
            label3.Text = "QUẢN LÝ PHỤ CẤP NHÂN VIÊN";
            // 
            // PhuCap
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(groupBox1);
            Controls.Add(DgvPhuCap);
            Controls.Add(label3);
            Name = "PhuCap";
            Size = new Size(2088, 1627);
            Load += PhuCap_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvPhuCap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private TextBox TxtSoTienPhuCap;
        private GroupBox groupBox2;
        private Button BtnXoaPhuCap;
        private Button BtnSuaPhuCap;
        private Button BtnTaoPhuCap;
        private Label label2;
        private TextBox TxtTenPhuCap;
        private Label label1;
        private TextBox TxtMaPhuCap;
        private DataGridView DgvPhuCap;
        private Label label3;
        private DataGridViewTextBoxColumn MaPhuCap;
        private DataGridViewTextBoxColumn TenPhuCap;
        private DataGridViewTextBoxColumn SoTien;
    }
}
