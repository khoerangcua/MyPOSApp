using System;
using System.Windows.Forms;

namespace POSApplication.KhachHang
{
    public partial class ChuaCoKhachHangForm : Form
    {
        public ChuaCoKhachHangForm()
        {
            InitializeComponent();
            this.themkhachhangButton.Click += OnChonKhachHangListener;
        }

        private POSService.KhachHang khachHangDaChon;

        public POSService.KhachHang KhachHangDaChon { get => khachHangDaChon; set => khachHangDaChon = value; }

        public event EventHandler DaChonKhachHangEvent;

        // Hàm này được gán vào sự kiện nhân viên chọn khách hàng
        public void OnChonKhachHangListener(object sender, EventArgs e)
        {
            ChonKhachHangForm chonKhachHangForm = new ChonKhachHangForm();
            chonKhachHangForm.ChonKhachHangEvent += OnDaChonKhachHangListener;
            chonKhachHangForm.ShowDialog();
        }


        public void OnDaChonKhachHangListener(object sender, EventArgs e)
        {
            KhachHangDaChon = ((ChonKhachHangForm)sender).KhachHangTimThay;
            DaChonKhachHangEvent(this, new EventArgs());
        }

        private void themkhachhangButton_Click(object sender, EventArgs e)
        {

        }
    }
}
