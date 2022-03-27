using POSService;
using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace POSApplication.KhachHang
{
    public partial class TaoMoiKhachHangForm : Form
    {
        public TaoMoiKhachHangForm()
        {
            InitializeComponent();
            system_Layer = new System_Layer();
            this.themBtn.Click += OnThemKhachHangListener;
            LoadImage(this.anhdaidienPictureBox, "https://media.defense.gov/2020/Feb/19/2002251686/700/465/0/200219-A-QY194-002.JPG");
            
        }

        private POSService.KhachHang khachHangMoiThem;
        public POSService.KhachHang KhachHangMoiThem { get => khachHangMoiThem; set => khachHangMoiThem = value; }


        public event EventHandler themKhachHangThanhCongEvent;
        private System_Layer system_Layer;

        // Hàm này được gán khi người dùng chấp nhận thêm mới khách hàng
        public void OnThemKhachHangListener(object sender, EventArgs e)
        {
            POSService.KhachHang khachHangMoi;
            String tenkh = this.tenTextBox.Text;
            String sdt = this.sdtTextBox.Text;
            String email = this.emailTextBox.Text;
            String diachi = this.diachiTextBox.Text;
            String diachianh = "https://media.defense.gov/2020/Feb/19/2002251686/700/465/0/200219-A-QY194-002.JPG";
            khachHangMoi = new POSService.KhachHang(0, tenkh, email, sdt, diachi, diachianh);
            // TODO: Lấy thông tin người dùng nhập vào và gán váo biến khachHangMoi
            system_Layer.AddNewKhachHang(khachHangMoi);
            KhachHangMoiThem = system_Layer.GetKhachHangByNumPhone(khachHangMoi.SoDienThoai);
            themKhachHangThanhCongEvent(this, new EventArgs());
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
