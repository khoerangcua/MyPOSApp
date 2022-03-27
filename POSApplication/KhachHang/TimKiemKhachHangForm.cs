using POSService;
using System;
using System.Windows.Forms;

namespace POSApplication.KhachHang
{
    public partial class TimKiemKhachHangForm : Form
    {
        public TimKiemKhachHangForm()
        {
            InitializeComponent();
            system_Layer = new System_Layer();
            this.timkiembtn.Click += OnTimKiemKhachHangListener;
        }

        private System_Layer system_Layer;

        private POSService.KhachHang khachHangTimThay;
        public POSService.KhachHang KhachHangTimThay { get => khachHangTimThay; set => khachHangTimThay = value; }


        public event EventHandler TimKiemKhachHangEvent;

        // Hàm này gán cho sự kiện khi người dùng nhấn nút tìm kiếm
        public void OnTimKiemKhachHangListener(object sender, EventArgs e)
        {
            String soDienThoai = this.sdttextbox.Text;
            KhachHangTimThay = system_Layer.GetKhachHangByNumPhone(soDienThoai);
            TimKiemKhachHangEvent(this, new EventArgs());
        }

    }
}
