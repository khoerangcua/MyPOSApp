using System;
using System.Windows.Forms;

namespace POSApplication.DanhMucSanPham
{
    public partial class DanhMucForm : Form
    {
        public DanhMucForm(POSService.DanhMucSanPham danhMuc)
        {
            InitializeComponent();
            this.DanhMuc = danhMuc;
            this.danhmucBtn.Text = danhMuc.TenDanhMuc;
            this.danhmucBtn.Click += OnChonDanhMucListener;
        }

        private POSService.DanhMucSanPham danhMuc;
        public POSService.DanhMucSanPham DanhMuc { get => danhMuc; set => danhMuc = value; }


        public event EventHandler chonDanhMucEvent;
        public void OnChonDanhMucListener(object sender, EventArgs e)
        {
            chonDanhMucEvent(this, new EventArgs());
        }
    }
}
