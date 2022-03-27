using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace POSApplication.DanhMucSanPham
{
    public partial class DanhMucsForm : Form
    {
        public DanhMucsForm(List<POSService.DanhMucSanPham> danhMucSanPhams)
        {
            InitializeComponent();
            this.DanhMucs = danhMucSanPhams;
            foreach (var danhMuc in DanhMucs)
            {
                // Tạo giao diện cho mỗi danh mục
                DanhMucForm danhMucForm = new DanhMucForm(danhMuc);
                danhMucForm.chonDanhMucEvent += OnChonDanhMucListener;


                // TODO: Load danhMuc lên panel
                danhMucForm.TopLevel = false;
                danhMucForm.AutoScroll = true;
                this.dmPanel.Controls.Add(danhMucForm);
                danhMucForm.Show();
            }
        }

        private List<POSService.DanhMucSanPham> danhMucs;
        public List<POSService.DanhMucSanPham> DanhMucs { get => danhMucs; set => danhMucs = value; }

        private POSService.DanhMucSanPham danhMucDangChon;
        public POSService.DanhMucSanPham DanhMucDangChon { get => danhMucDangChon; set => danhMucDangChon = value; }



        public event EventHandler chonDanhMucEvent;

        public void OnChonDanhMucListener(object sender, EventArgs e)
        {
            DanhMucDangChon = ((DanhMucForm)sender).DanhMuc;
            chonDanhMucEvent(this, new EventArgs());
        }
    }
}
