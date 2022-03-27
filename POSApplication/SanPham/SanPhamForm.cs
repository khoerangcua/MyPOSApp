using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace POSApplication.SanPham
{
    public partial class SanPhamForm : Form
    {
        public SanPhamForm(POSService.SanPham sanPham)
        {
            InitializeComponent();
            this.SanPham = sanPham;

            // TODO: Load dữ liệu lên giao diện
            LoadImage(this.spPictureBox, sanPham.DiaChiAnh);
            this.tenspLabel.Text = sanPham.TenHangHoa;
            this.giasLabel.Text = sanPham.Dongia.ToString();
            SoLuong = 0;
            this.soluongTextBox.Text = SoLuong.ToString();
            this.themBtn.Click += OnThemSanPhamListener;
        }



        private POSService.SanPham sanPham;
        public POSService.SanPham SanPham { get => sanPham; set => sanPham = value; }

        private int soLuong;
        public int SoLuong { get => soLuong; set => soLuong = value; }


        public event EventHandler themSanPhamEvent;
        public void OnThemSanPhamListener(Object sender, EventArgs e)
        {
            themSanPhamEvent(this, new EventArgs());
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

        private void truBtn_Click(object sender, EventArgs e)
        {
            this.SoLuong--;
            this.soluongTextBox.Text = SoLuong.ToString();
        }

        private void congBtn_Click(object sender, EventArgs e)
        {
            this.SoLuong++;
            this.soluongTextBox.Text = soLuong.ToString();
        }


    }
}
