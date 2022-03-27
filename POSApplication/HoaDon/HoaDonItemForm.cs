using POSService;
using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using POSDataModel;
using System.Linq;


namespace POSApplication.HoaDon
{
    public partial class HoaDonItemForm : Form
    {
        public HoaDonItemForm(POSService.ChiTietHoaDon chiTietHoaDon)
        {
            InitializeComponent();
            this.chiTietHoaDon = chiTietHoaDon;
            this.xoaButton.Click += OnXoaSanPhamListener;
        }

        private POSService.ChiTietHoaDon chiTietHoaDon;

        public ChiTietHoaDon ChiTietHoaDon { get => chiTietHoaDon; set => chiTietHoaDon = value; }

        public event EventHandler xoaSanPhamEvent;

        

        // Hàm này gán cho sự kiện nhấn nút xóa
        public void OnXoaSanPhamListener(object sender, EventArgs e)
        {
            xoaSanPhamEvent(this, new EventArgs());
        }

        private void HoaDonItemForm_Load(object sender, EventArgs e)
        {
            String tenmon, gia, phantramgiam, soluong, thanhtien, diachianh = "";
            using (POSEntities db = new POSEntities())
            {
                tenmon = db.tbl_hanghoa.FirstOrDefault(p => p.idhanghoa == this.ChiTietHoaDon.Idhanghoa).tenhanghoa;
                gia = this.ChiTietHoaDon.Dongia.ToString();
                phantramgiam = (this.ChiTietHoaDon.Phantramgiam * 100) + "%";
                soluong = this.chiTietHoaDon.Soluong.ToString();
                thanhtien = this.ChiTietHoaDon.Tongcong.ToString();
                diachianh = db.tbl_hanghoa.FirstOrDefault(p => p.idhanghoa == this.ChiTietHoaDon.Idhanghoa).diachianh;
            }
            LoadImage(this.anhPictureBox, diachianh);
            this.tenmonTextBox.Text = tenmon;
            this.giaTextBox.Text = gia;
            this.giamgiaTextBox.Text = phantramgiam;
            this.soluongTextBox.Text = soluong;
            this.thanhtienTextBox.Text = thanhtien;
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
