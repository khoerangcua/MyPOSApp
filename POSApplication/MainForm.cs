using POSApplication.DanhMucSanPham;
using POSApplication.HoaDon;
using POSApplication.SanPham;
using POSService;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace POSApplication
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            system_Layer = new System_Layer();




            hoaDonForm = new HoaDonForm();
            //hoaDonForm.thanhToanThanhCongEvent += LoadHoaDonMoi;



            // Load Menu danh mục sản phẩm
            danhMucSanPhams = system_Layer.GetDanhMucSanPham();
            danhMucsForm = new DanhMucsForm(danhMucSanPhams);
            danhMucsForm.chonDanhMucEvent += OnChonDanhMucListener;
            danhMucsForm.TopLevel = false;
            danhMucsForm.AutoScroll = true;
            this.menuPanel.Controls.Add(danhMucsForm);
            danhMucsForm.Show();

            // Load danh sách sản phẩm
            sanPhamsForm = new SanPhamsForm();
            sanPhamsForm.themSanPhamEvent += OnThemSanPhamListener;
            sanPhamsForm.TopLevel = false;
            sanPhamsForm.AutoScroll = true;
            this.contentPanel.Controls.Add(sanPhamsForm);
            sanPhamsForm.Show();




            hoaDonForm.HoaDon = system_Layer.TaoHoaDonMoi();
            hoaDonForm.thanhToanThanhCongEvent += LoadHoaDonMoi;
            hoaDonForm.TopLevel = false;
            hoaDonForm.AutoScroll = true;
            this.hoadonPanel.Controls.Add(hoaDonForm);
            hoaDonForm.Show();


        }

        private DanhMucsForm danhMucsForm;

        private SanPhamsForm sanPhamsForm;

        private HoaDonForm hoaDonForm;

        private List<POSService.DanhMucSanPham> danhMucSanPhams;

        private System_Layer system_Layer;

        private void OnChonDanhMucListener(object sender, EventArgs e)
        {
            POSService.DanhMucSanPham danhMuc = ((DanhMucsForm)sender).DanhMucDangChon;
            List<POSService.SanPham> sanPhams = system_Layer.GetSanPhams(danhMuc.IdDanhMuc);
            sanPhamsForm.LoadSanPhams(sanPhams);
        }

        private void OnThemSanPhamListener(object sender, EventArgs e)
        {
            POSService.SanPham sanPham = ((SanPhamsForm)sender).SanPhamDaChon;
            int soLuong = ((SanPhamsForm)sender).SoLuong;
            hoaDonForm.ThemSanPham(sanPham, soLuong);
        }

        public void LoadHoaDonMoi(object sender, EventArgs e)
        {
            HoaDonForm hoaDonForm1 = new HoaDonForm();
            hoaDonForm1.HoaDon = ((HoaDonForm)sender).HoaDonMoi;
            this.hoaDonForm = hoaDonForm1;
            if (this.hoadonPanel.Controls.Count > 0)
            {
                this.hoadonPanel.Controls.RemoveAt(0);
                hoaDonForm.thanhToanThanhCongEvent += LoadHoaDonMoi;
                hoaDonForm.TopLevel = false;
                hoaDonForm.AutoScroll = true;
                this.hoadonPanel.Controls.Add(hoaDonForm);
                hoaDonForm.Show();
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
