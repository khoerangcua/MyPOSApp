
namespace POSApplication.DanhMucSanPham
{
    partial class DanhMucsForm
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
            this.dmPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // dmPanel
            // 
            this.dmPanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dmPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dmPanel.Location = new System.Drawing.Point(0, 0);
            this.dmPanel.Name = "dmPanel";
            this.dmPanel.Size = new System.Drawing.Size(350, 1033);
            this.dmPanel.TabIndex = 0;
            // 
            // DanhMucsForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(350, 1033);
            this.Controls.Add(this.dmPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DanhMucsForm";
            this.Text = "DanhMucsForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel dmPanel;
    }
}