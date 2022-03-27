using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace POSApplication.KhachHang
{
    public partial class DaCoKhachHangForm : Form
    {
        public DaCoKhachHangForm(POSService.KhachHang khachHang)
        {
            InitializeComponent();
            this.khachHang = khachHang;
        }

        private POSService.KhachHang khachHang;

        public POSService.KhachHang KhachHang { get => khachHang; set => khachHang = value; }

        private void DaCoKhachHangForm_Load(object sender, System.EventArgs e)
        {
            LoadImage(this.anhdaidienPictureBox, this.khachHang.DiaChiAnh);
            this.tenTextBox.Text = this.khachHang.TenKhachHang;
            this.sdtTextBox.Text = this.khachHang.SoDienThoai;
            this.diachiTextBox.Text = this.khachHang.DiaChi;
            this.emailTextBox.Text = this.khachHang.Email;
        }

        private void LoadImage(PictureBox pictureBox, String url)
        {
            WebRequest request = WebRequest.Create(url);

            using (var respone = request.GetResponse())
            {
                using (var str = respone.GetResponseStream())
                {
                    pictureBox.Image = Bitmap.FromStream(str);
                }
            }

        }
    }
}
