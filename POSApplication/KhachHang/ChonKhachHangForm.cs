using System;
using System.Windows.Forms;

namespace POSApplication.KhachHang
{
    public partial class ChonKhachHangForm : Form
    {
        public ChonKhachHangForm()
        {
            InitializeComponent();
            timKiemKhachHangForm = new TimKiemKhachHangForm();
            timKiemKhachHangForm.TimKiemKhachHangEvent += OnTimKiemKhachHangListener;
            thongTinKhachHangForm = new ThongTinKhachHangForm();
            
            this.chonbtn.Click += OnChonKhachHangListener;
            this.taomoibtn.Click += OnThemMoiKhachHangListener;

            // TODO: Hiển thị 2 form lên 2 panel

            timKiemKhachHangForm.TopLevel = false;
            timKiemKhachHangForm.AutoScroll = true;
            this.timkiempanel.Controls.Add(timKiemKhachHangForm);
            timKiemKhachHangForm.Show();

            thongTinKhachHangForm.TopLevel = false;
            thongTinKhachHangForm.AutoScroll = true;
            this.thongtinkhachhangpanel.Controls.Add(thongTinKhachHangForm);
            thongTinKhachHangForm.Show();
            thongTinKhachHangForm.HienThiGiaoDienMacDinh();

            // TODO: Vô hiệu hóa nút chọn khách hàng
            this.chonbtn.Click += OnChonKhachHangListener;
            this.chonbtn.Enabled = false;
        }

        private TimKiemKhachHangForm timKiemKhachHangForm;

        private TaoMoiKhachHangForm taoMoiKhachHangForm;

        private POSService.KhachHang khachHangTimThay;
        public POSService.KhachHang KhachHangTimThay { get => khachHangTimThay; set => khachHangTimThay = value; }


        private ThongTinKhachHangForm thongTinKhachHangForm;


        public event EventHandler ChonKhachHangEvent;

        public void OnTimKiemKhachHangListener(object sender, EventArgs e)
        {

            if (sender is TimKiemKhachHangForm)
            {
                khachHangTimThay = ((TimKiemKhachHangForm)sender).KhachHangTimThay;
            }
            else
            {
                khachHangTimThay = ((TaoMoiKhachHangForm)sender).KhachHangMoiThem;
            }



            if (KhachHangTimThay == null || khachHangTimThay.IdKhachHang == 0)
            {
                // Nếu không tìm thấy khách hàng
                thongTinKhachHangForm.HienThiGiaoDienMacDinh();
                // Vô hiệu hóa nút chọn khách hàng
                this.chonbtn.Enabled = false;
            }
            else
            {
                // Nếu như tìm thấy khách hàng
                thongTinKhachHangForm.HienThiThongTinKhachHang(KhachHangTimThay);
                // Thôi vô hiệu hóa nút chọn khách hàng
                this.chonbtn.Enabled = true;
            }
        }

        // Hàm này được gán vào sự kiện người dùng nhấn nút chọn khách hàng
        public void OnChonKhachHangListener(object sender, EventArgs e)
        {
            ChonKhachHangEvent(this, new EventArgs());
        }

        // Hàm này được gán vào sự kiện người dùng nhấn nút thêm khách hàng
        public void OnThemMoiKhachHangListener(object sender, EventArgs e)
        {
            taoMoiKhachHangForm = new TaoMoiKhachHangForm();
            taoMoiKhachHangForm.themKhachHangThanhCongEvent += OnTimKiemKhachHangListener;
            taoMoiKhachHangForm.ShowDialog();
        }
    }
}
