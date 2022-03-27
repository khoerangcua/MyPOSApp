
namespace POSApplication.KhachHang
{
    partial class ChuaCoKhachHangForm
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
            this.themkhachhangButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // themkhachhangButton
            // 
            this.themkhachhangButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.themkhachhangButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themkhachhangButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themkhachhangButton.ForeColor = System.Drawing.Color.White;
            this.themkhachhangButton.Location = new System.Drawing.Point(0, 0);
            this.themkhachhangButton.Name = "themkhachhangButton";
            this.themkhachhangButton.Size = new System.Drawing.Size(338, 188);
            this.themkhachhangButton.TabIndex = 38;
            this.themkhachhangButton.Text = "Thêm khách hàng";
            this.themkhachhangButton.UseVisualStyleBackColor = false;
            this.themkhachhangButton.Click += new System.EventHandler(this.themkhachhangButton_Click);
            // 
            // ChuaCoKhachHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 188);
            this.Controls.Add(this.themkhachhangButton);
            this.Font = new System.Drawing.Font("Quicksand", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChuaCoKhachHangForm";
            this.Text = "ChuaCoKhachHangForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button themkhachhangButton;
    }
}