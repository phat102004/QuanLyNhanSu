using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.usercontrol
{
    public partial class heThong : UserControl
    {
        // === ĐỊNH NGHĨA CÁC SỰ KIỆN CHO MỖI NÚT ===
        public event EventHandler QLTaiKhoanClicked;
        public event EventHandler CoCauToChucClicked;
        public event EventHandler CauHinhChamCongClicked;
        public event EventHandler CauHinhLuongClicked;
        public event EventHandler CauHinhNghiPhepClicked;
        public event EventHandler NhatKyHeThongClicked; 
        public event EventHandler SaoLuuClicked;       

        public heThong()
        {
            InitializeComponent();
            ConnectClickEvents();
        }

        private void ConnectClickEvents()
        {
            this.btnQLTaiKhoan.Click += BtnQLTaiKhoan_Click;
            this.btnCoCauToChuc.Click += BtnCoCauToChuc_Click;
            this.btnCauHinhChamCong.Click += BtnCauHinhChamCong_Click;
            this.btnCauHinhLuong.Click += BtnCauHinhLuong_Click;
            this.btnCauHinhNghiPhep.Click += BtnCauHinhNghiPhep_Click;
            this.btnNhatKyHeThong.Click += BtnNhatKyHeThong_Click; 
            this.btnSaoLuu.Click += BtnSaoLuu_Click;            
        }

        private void BtnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            if (QLTaiKhoanClicked != null)
            {
                QLTaiKhoanClicked(this, EventArgs.Empty);
            }
        }

        private void BtnCoCauToChuc_Click(object sender, EventArgs e)
        {
            CoCauToChucClicked?.Invoke(this, EventArgs.Empty);
        }

        private void BtnCauHinhChamCong_Click(object sender, EventArgs e)
        {
            CauHinhChamCongClicked?.Invoke(this, EventArgs.Empty);
        }

        private void BtnCauHinhLuong_Click(object sender, EventArgs e)
        {
            CauHinhLuongClicked?.Invoke(this, EventArgs.Empty);
        }

        private void BtnCauHinhNghiPhep_Click(object sender, EventArgs e)
        {
            CauHinhNghiPhepClicked?.Invoke(this, EventArgs.Empty);
        }

        // --- THÊM CÁC HÀM XỬ LÝ CHO SỰ KIỆN MỚI ---
        private void BtnNhatKyHeThong_Click(object sender, EventArgs e)
        {
            NhatKyHeThongClicked?.Invoke(this, EventArgs.Empty);
        }

        private void BtnSaoLuu_Click(object sender, EventArgs e)
        {
            SaoLuuClicked?.Invoke(this, EventArgs.Empty);
        }
        // --- KẾT THÚC PHẦN THÊM MỚI ---
    }
}