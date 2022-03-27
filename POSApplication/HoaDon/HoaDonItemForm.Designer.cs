
namespace POSApplication.HoaDon
{
    partial class HoaDonItemForm
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
            this.anhPictureBox = new System.Windows.Forms.PictureBox();
            this.tenmonTextBox = new System.Windows.Forms.TextBox();
            this.giaTextBox = new System.Windows.Forms.TextBox();
            this.soluongTextBox = new System.Windows.Forms.TextBox();
            this.giamgiaTextBox = new System.Windows.Forms.TextBox();
            this.thanhtienTextBox = new System.Windows.Forms.TextBox();
            this.xoaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.anhPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // anhPictureBox
            // 
            this.anhPictureBox.Location = new System.Drawing.Point(12, 12);
            this.anhPictureBox.Name = "anhPictureBox";
            this.anhPictureBox.Size = new System.Drawing.Size(155, 129);
            this.anhPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anhPictureBox.TabIndex = 0;
            this.anhPictureBox.TabStop = false;
            // 
            // tenmonTextBox
            // 
            this.tenmonTextBox.Enabled = false;
            this.tenmonTextBox.Location = new System.Drawing.Point(173, 12);
            this.tenmonTextBox.Name = "tenmonTextBox";
            this.tenmonTextBox.Size = new System.Drawing.Size(140, 22);
            this.tenmonTextBox.TabIndex = 5;
            // 
            // giaTextBox
            // 
            this.giaTextBox.Enabled = false;
            this.giaTextBox.Location = new System.Drawing.Point(173, 35);
            this.giaTextBox.Name = "giaTextBox";
            this.giaTextBox.Size = new System.Drawing.Size(140, 22);
            this.giaTextBox.TabIndex = 6;
            // 
            // soluongTextBox
            // 
            this.soluongTextBox.Enabled = false;
            this.soluongTextBox.Location = new System.Drawing.Point(173, 63);
            this.soluongTextBox.Name = "soluongTextBox";
            this.soluongTextBox.Size = new System.Drawing.Size(140, 22);
            this.soluongTextBox.TabIndex = 7;
            // 
            // giamgiaTextBox
            // 
            this.giamgiaTextBox.Enabled = false;
            this.giamgiaTextBox.Location = new System.Drawing.Point(173, 91);
            this.giamgiaTextBox.Name = "giamgiaTextBox";
            this.giamgiaTextBox.Size = new System.Drawing.Size(140, 22);
            this.giamgiaTextBox.TabIndex = 10;
            // 
            // thanhtienTextBox
            // 
            this.thanhtienTextBox.Enabled = false;
            this.thanhtienTextBox.Location = new System.Drawing.Point(173, 119);
            this.thanhtienTextBox.Name = "thanhtienTextBox";
            this.thanhtienTextBox.Size = new System.Drawing.Size(140, 22);
            this.thanhtienTextBox.TabIndex = 12;
            // 
            // xoaButton
            // 
            this.xoaButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.xoaButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.xoaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xoaButton.Font = new System.Drawing.Font("Quicksand Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaButton.ForeColor = System.Drawing.Color.Transparent;
            this.xoaButton.Location = new System.Drawing.Point(0, 146);
            this.xoaButton.Margin = new System.Windows.Forms.Padding(2);
            this.xoaButton.Name = "xoaButton";
            this.xoaButton.Size = new System.Drawing.Size(440, 46);
            this.xoaButton.TabIndex = 15;
            this.xoaButton.Text = "Xóa";
            this.xoaButton.UseVisualStyleBackColor = false;
            // 
            // HoaDonItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 192);
            this.Controls.Add(this.xoaButton);
            this.Controls.Add(this.thanhtienTextBox);
            this.Controls.Add(this.giamgiaTextBox);
            this.Controls.Add(this.soluongTextBox);
            this.Controls.Add(this.giaTextBox);
            this.Controls.Add(this.tenmonTextBox);
            this.Controls.Add(this.anhPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HoaDonItemForm";
            this.Text = "HoaDonItemForm";
            this.Load += new System.EventHandler(this.HoaDonItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anhPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox anhPictureBox;
        private System.Windows.Forms.TextBox tenmonTextBox;
        private System.Windows.Forms.TextBox giaTextBox;
        private System.Windows.Forms.TextBox soluongTextBox;
        private System.Windows.Forms.TextBox giamgiaTextBox;
        private System.Windows.Forms.TextBox thanhtienTextBox;
        private System.Windows.Forms.Button xoaButton;
    }
}