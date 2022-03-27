using POSApplication.KhachHang;
using POSService;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace POSApplication.HoaDon
{
    public partial class HoaDonForm : Form
    {
        public HoaDonForm()
        {
            InitializeComponent();

            experience_Layer = new Experience_Layer();
            system_Layer = new System_Layer();

            phuongThucThanhToanForm = new PhuongThucThanhToanForm();
            phuongThucThanhToanForm.ChonPhuongThucThanhToanEvent += OnChonPhuongThucThanhToanListener;
            luaChonMailForm = new LuaChonMailForm();
            luaChonMailForm.ChonGuiMailEvent += OnChonGuiMailListener;
            chuaCoKhachHangForm = new ChuaCoKhachHangForm();
            chuaCoKhachHangForm.DaChonKhachHangEvent += OnChonKhachHangListener;

            // Load chua co khach hang form
            chuaCoKhachHangForm.TopLevel = false;
            chuaCoKhachHangForm.AutoScroll = true;
            this.chonkhachhangPanel.Controls.Add(chuaCoKhachHangForm);
            chuaCoKhachHangForm.Show();

            // Load chon phuong thuc thanh toan form
            phuongThucThanhToanForm.TopLevel = false;
            phuongThucThanhToanForm.AutoScroll = true;
            this.phuongthucthanhtoanPanel.Controls.Add(phuongThucThanhToanForm);
            phuongThucThanhToanForm.Show();

            // Load tuy chon guimail
            luaChonMailForm.TopLevel = false;
            luaChonMailForm.AutoScroll = true;
            this.chonemailpanel.Controls.Add(luaChonMailForm);
            luaChonMailForm.Show();

            this.tongtienTextBox.Text = 0 + "Đồng";
            this.thanhtoanButton.Click += OnThanhToanListener;
        }

        private ChuaCoKhachHangForm chuaCoKhachHangForm;

        private DaCoKhachHangForm daCoKhachHangForm;

        private PhuongThucThanhToanForm phuongThucThanhToanForm;

        private LuaChonMailForm luaChonMailForm;

        private POSService.HoaDon hoaDon;
        public POSService.HoaDon HoaDon { get => hoaDon; set => hoaDon = value; }

        private List<POSService.ChiTietHoaDon> chiTietHoaDons;
        public List<ChiTietHoaDon> ChiTietHoaDons { get => chiTietHoaDons; set => chiTietHoaDons = value; }


        private byte phuongThucThanhToan;
        public byte PhuongThucThanhToan { get => phuongThucThanhToan; set => phuongThucThanhToan = value; }


        private bool guiMail;
        public bool GuiMail { get => guiMail; set => guiMail = value; }

        private POSService.KhachHang khachHangDaChon;
        public POSService.KhachHang KhachHangDaChon { get => khachHangDaChon; set => khachHangDaChon = value; }

        public event EventHandler thanhToanThanhCongEvent;

        private POSService.HoaDon hoaDonMoi;
        public POSService.HoaDon HoaDonMoi { get => hoaDonMoi; set => hoaDonMoi = value; }


        private Experience_Layer experience_Layer;
        private System_Layer system_Layer;

        public void ThemSanPham(POSService.SanPham sanPham, int soLuong)
        {
            hoaDon = experience_Layer.ThemSanPhamVaoHoaDon(hoaDon.IdHoaDon, sanPham.IdHangHoa, soLuong);
            CapNhatHoaDon();
            chiTietHoaDons = system_Layer.GetHoaDonItems(hoaDon.IdHoaDon);
            CapNhatChiTietHoaDon();

        }

        public void CapNhatHoaDon()
        {
            this.tongtienTextBox.Text = this.HoaDon.Tongtien.ToString() + "Đồng";
        }

        public void CapNhatChiTietHoaDon()
        {
            if (hoadonitemPanel.Controls.Count > 0)
            {
                int dem = hoadonitemPanel.Controls.Count;
                for (int i = 0; i < dem; i++)
                {
                    hoadonitemPanel.Controls.RemoveAt(0);
                }

            }
            foreach (var cthd in chiTietHoaDons)
            {
                // Tạo giao diện hóa đơn item
                HoaDonItemForm hoaDonItemForm = new HoaDonItemForm(cthd);
                hoaDonItemForm.xoaSanPhamEvent += OnXoaSanPhamListener;
                hoaDonItemForm.TopLevel = false;
                hoaDonItemForm.AutoScroll = true;
                this.hoadonitemPanel.Controls.Add(hoaDonItemForm);
                hoaDonItemForm.Show();
            }
        }

        public void OnXoaSanPhamListener(object sender, EventArgs e)
        {
            POSService.ChiTietHoaDon chiTietHoaDon = ((HoaDonItemForm)sender).ChiTietHoaDon;
            hoaDon = experience_Layer.XoaSanPhamKhoiHoaDon(hoaDon.IdHoaDon, chiTietHoaDon.Idhanghoa.GetValueOrDefault());
            CapNhatHoaDon();
            chiTietHoaDons = system_Layer.GetHoaDonItems(hoaDon.IdHoaDon);
            CapNhatChiTietHoaDon();

        }

        public void OnChonPhuongThucThanhToanListener(object sender, EventArgs e)
        {
            PhuongThucThanhToan = ((PhuongThucThanhToanForm)sender).PhuongThucThanhToan;
        }

        public void OnChonGuiMailListener(object sender, EventArgs e)
        {
            GuiMail = ((LuaChonMailForm)sender).GuiMail;
        }

        public void OnChonKhachHangListener(object sender, EventArgs e)
        {
            KhachHangDaChon = ((ChuaCoKhachHangForm)sender).KhachHangDaChon;
            bool capNhatThanhCong = system_Layer.UpdateKhachHangToHoaDon(HoaDon.IdHoaDon, KhachHangDaChon.IdKhachHang);
            if (capNhatThanhCong)
            {
                capNhatKhachHang();
            }

        }

        public void capNhatKhachHang()
        {
            DaCoKhachHangForm daCoKhachHangForm = new DaCoKhachHangForm(KhachHangDaChon);

            // TODO: Thay thế chuaCoKhachHangForm bằng dacoKhachHangForm
            if (this.chonkhachhangPanel.Controls.Count>0)
            {
                this.chonkhachhangPanel.Controls.RemoveAt(0);
                daCoKhachHangForm.TopLevel = false;
                this.chonkhachhangPanel.Controls.Add(daCoKhachHangForm);

                daCoKhachHangForm.Show();
            }

        }

        // Hàm này được gán vào sự kiện khi người dùng nhấn thanh toán
        public void OnThanhToanListener(object sender, EventArgs e)
        {
            hoaDonMoi = experience_Layer.ThanhToanHoaDon(HoaDon.IdHoaDon, PhuongThucThanhToan, GuiMail);
            thanhToanThanhCongEvent(this, new EventArgs());
        }

        private void tongtienTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
