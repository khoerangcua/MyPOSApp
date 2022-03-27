using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace POSApplication.SanPham
{
    public partial class SanPhamsForm : Form
    {
        public SanPhamsForm()
        {
            InitializeComponent();

        }

        public void LoadSanPhams(List<POSService.SanPham> sanPhams)
        {

            if (this.sanphamsPanel.Controls.Count > 0)
            {
                int dem = this.sanphamsPanel.Controls.Count;
                for (int i = 0; i < dem; i++)
                {
                    this.sanphamsPanel.Controls.RemoveAt(0);
                }
            }
            this.SanPhams = sanPhams;
            foreach (var sanPham in sanPhams)
            {
                SanPhamForm sanPhamForm = new SanPhamForm(sanPham);
                sanPhamForm.themSanPhamEvent += OnThemSanPhamLintener;

                sanPhamForm.TopLevel = false;
                sanPhamForm.AutoScroll = true;
                this.sanphamsPanel.Controls.Add(sanPhamForm);
                sanPhamForm.Show();
            }
        }

        private List<POSService.SanPham> sanPhams;
        public List<POSService.SanPham> SanPhams { get => sanPhams; set => sanPhams = value; }


        private POSService.SanPham sanPhamDaChon;
        public POSService.SanPham SanPhamDaChon { get => sanPhamDaChon; set => sanPhamDaChon = value; }


        private int soLuong;
        public int SoLuong { get => soLuong; set => soLuong = value; }



        public event EventHandler themSanPhamEvent;

        public void OnThemSanPhamLintener(object sender, EventArgs e)
        {
            SanPhamDaChon = ((SanPhamForm)sender).SanPham;
            SoLuong = ((SanPhamForm)sender).SoLuong;
            themSanPhamEvent(this, new EventArgs());
        }
    }
}
