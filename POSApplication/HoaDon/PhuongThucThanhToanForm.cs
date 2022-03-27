using System;
using System.Windows.Forms;

namespace POSApplication.HoaDon
{
    public partial class PhuongThucThanhToanForm : Form
    {
        public PhuongThucThanhToanForm()
        {
            InitializeComponent();
            this.tienmatRadioButton.Click += TienmatRadioButton_Click; ;
            this.theRadioButotn.Click += TheRadioButotn_Click; ;
            
        }

        

        public event EventHandler ChonPhuongThucThanhToanEvent;

        private byte phuongThucThanhToan;

        public byte PhuongThucThanhToan { get => phuongThucThanhToan; set => phuongThucThanhToan = value; }

        // Hàm này sẽ được gán vào sự kiện chọn phương thức thanh toán
        private void TheRadioButotn_Click(object sender, EventArgs e)
        {
            PhuongThucThanhToan = 1;
            ChonPhuongThucThanhToanEvent(this, new EventArgs());
        }

        private void TienmatRadioButton_Click(object sender, EventArgs e)
        {
            phuongThucThanhToan = 0;
            ChonPhuongThucThanhToanEvent(this, new EventArgs());

        }


    }
}
