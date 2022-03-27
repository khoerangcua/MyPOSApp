using System;
using System.Windows.Forms;

namespace POSApplication.HoaDon
{
    public partial class LuaChonMailForm : Form
    {
        public LuaChonMailForm()
        {
            InitializeComponent();
            this.GuiMail = false;
            this.guimailCheckBox.CheckedChanged += OnChonGuiMailListener;
            
            
        }
        private bool guiMail;

        public bool GuiMail { get => guiMail; set => guiMail = value; }

        public event EventHandler ChonGuiMailEvent;


        // Hàm này được gán với sự kiện chọn gửi mail
        public void OnChonGuiMailListener(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            // Nếu như có chọn gửi mail
            if (checkBox.CheckState == CheckState.Checked)
            {
                GuiMail = true;
            }
            else
            {
                GuiMail = false;
            }

            ChonGuiMailEvent(this, new EventArgs());
        }

    }
}
