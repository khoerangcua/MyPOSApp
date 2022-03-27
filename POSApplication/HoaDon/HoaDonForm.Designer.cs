
namespace POSApplication.HoaDon
{
    partial class HoaDonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chonkhachhangPanel = new System.Windows.Forms.Panel();
            this.hoadonitemPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tongtienlabel = new System.Windows.Forms.Label();
            this.tongtienTextBox = new System.Windows.Forms.TextBox();
            this.thanhtoanButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chonemailpanel = new System.Windows.Forms.Panel();
            this.phuongthucthanhtoanPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chonkhachhangPanel
            // 
            this.chonkhachhangPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chonkhachhangPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.chonkhachhangPanel.Location = new System.Drawing.Point(0, 0);
            this.chonkhachhangPanel.Name = "chonkhachhangPanel";
            this.chonkhachhangPanel.Size = new System.Drawing.Size(338, 188);
            this.chonkhachhangPanel.TabIndex = 0;
            // 
            // hoadonitemPanel
            // 
            this.hoadonitemPanel.AutoScroll = true;
            this.hoadonitemPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hoadonitemPanel.Location = new System.Drawing.Point(0, 188);
            this.hoadonitemPanel.Name = "hoadonitemPanel";
            this.hoadonitemPanel.Size = new System.Drawing.Size(338, 651);
            this.hoadonitemPanel.TabIndex = 1;
            // 
            // tongtienlabel
            // 
            this.tongtienlabel.AutoSize = true;
            this.tongtienlabel.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tongtienlabel.Location = new System.Drawing.Point(12, 3);
            this.tongtienlabel.Name = "tongtienlabel";
            this.tongtienlabel.Size = new System.Drawing.Size(131, 35);
            this.tongtienlabel.TabIndex = 4;
            this.tongtienlabel.Text = "Tổng tiền: ";
            // 
            // tongtienTextBox
            // 
            this.tongtienTextBox.Location = new System.Drawing.Point(149, 12);
            this.tongtienTextBox.Name = "tongtienTextBox";
            this.tongtienTextBox.Size = new System.Drawing.Size(150, 24);
            this.tongtienTextBox.TabIndex = 5;
            this.tongtienTextBox.TextChanged += new System.EventHandler(this.tongtienTextBox_TextChanged);
            // 
            // thanhtoanButton
            // 
            this.thanhtoanButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.thanhtoanButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thanhtoanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thanhtoanButton.Font = new System.Drawing.Font("Quicksand Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thanhtoanButton.ForeColor = System.Drawing.Color.Transparent;
            this.thanhtoanButton.Location = new System.Drawing.Point(0, 0);
            this.thanhtoanButton.Margin = new System.Windows.Forms.Padding(2);
            this.thanhtoanButton.Name = "thanhtoanButton";
            this.thanhtoanButton.Size = new System.Drawing.Size(338, 88);
            this.thanhtoanButton.TabIndex = 9;
            this.thanhtoanButton.Text = "Thanh toán";
            this.thanhtoanButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.thanhtoanButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 751);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 88);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tongtienTextBox);
            this.panel2.Controls.Add(this.tongtienlabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 710);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 41);
            this.panel2.TabIndex = 11;
            // 
            // chonemailpanel
            // 
            this.chonemailpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chonemailpanel.Location = new System.Drawing.Point(0, 598);
            this.chonemailpanel.Name = "chonemailpanel";
            this.chonemailpanel.Size = new System.Drawing.Size(338, 112);
            this.chonemailpanel.TabIndex = 12;
            // 
            // phuongthucthanhtoanPanel
            // 
            this.phuongthucthanhtoanPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.phuongthucthanhtoanPanel.Location = new System.Drawing.Point(0, 486);
            this.phuongthucthanhtoanPanel.Name = "phuongthucthanhtoanPanel";
            this.phuongthucthanhtoanPanel.Size = new System.Drawing.Size(338, 112);
            this.phuongthucthanhtoanPanel.TabIndex = 13;
            // 
            // HoaDonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(338, 839);
            this.Controls.Add(this.phuongthucthanhtoanPanel);
            this.Controls.Add(this.chonemailpanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hoadonitemPanel);
            this.Controls.Add(this.chonkhachhangPanel);
            this.Font = new System.Drawing.Font("Quicksand", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HoaDonForm";
            this.Text = "HoaDonForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel chonkhachhangPanel;
        private System.Windows.Forms.FlowLayoutPanel hoadonitemPanel;
        private System.Windows.Forms.Label tongtienlabel;
        private System.Windows.Forms.TextBox tongtienTextBox;
        private System.Windows.Forms.Button thanhtoanButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel chonemailpanel;
        private System.Windows.Forms.Panel phuongthucthanhtoanPanel;
    }
}