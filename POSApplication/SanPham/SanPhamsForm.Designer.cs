
namespace POSApplication.SanPham
{
    partial class SanPhamsForm
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
            this.sanphamsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // sanphamsPanel
            // 
            this.sanphamsPanel.AutoScroll = true;
            this.sanphamsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.sanphamsPanel.Location = new System.Drawing.Point(0, -1);
            this.sanphamsPanel.Name = "sanphamsPanel";
            this.sanphamsPanel.Size = new System.Drawing.Size(1250, 1040);
            this.sanphamsPanel.TabIndex = 0;
            // 
            // SanPhamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1230, 1039);
            this.Controls.Add(this.sanphamsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SanPhamsForm";
            this.Text = "SanPhamsForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel sanphamsPanel;
    }
}