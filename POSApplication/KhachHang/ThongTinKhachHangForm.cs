using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace POSApplication.KhachHang
{
    public partial class ThongTinKhachHangForm : Form
    {
        public ThongTinKhachHangForm()
        {
            InitializeComponent();
        }

        public void HienThiGiaoDienMacDinh()
        {
            this.idTextBox.Text = "";
            this.tenTextBox.Text = "";
            this.sdtTextBox.Text = "";
            this.emailTextBox.Text = "";
            this.diachiTextBox.Text = "";
            LoadImage(this.anhdaidienPictureBox, "https://media.defense.gov/2020/Feb/19/2002251686/700/465/0/200219-A-QY194-002.JPG");
        }

        public void HienThiThongTinKhachHang(POSService.KhachHang khachHang)
        {
            this.idTextBox.Text = khachHang.IdKhachHang.ToString();
            this.tenTextBox.Text = khachHang.TenKhachHang;
            this.sdtTextBox.Text = khachHang.SoDienThoai;
            this.emailTextBox.Text = khachHang.Email;
            this.diachiTextBox.Text = khachHang.DiaChi;
            LoadImage(this.anhdaidienPictureBox, khachHang.DiaChiAnh);
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
