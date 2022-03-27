
namespace POSApplication.KhachHang
{
    partial class DaCoKhachHangForm
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
            this.anhdaidienPictureBox = new System.Windows.Forms.PictureBox();
            this.tenTextBox = new System.Windows.Forms.TextBox();
            this.sdtTextBox = new System.Windows.Forms.TextBox();
            this.diachiTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.anhdaidienPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // anhdaidienPictureBox
            // 
            this.anhdaidienPictureBox.Location = new System.Drawing.Point(12, 51);
            this.anhdaidienPictureBox.Name = "anhdaidienPictureBox";
            this.anhdaidienPictureBox.Size = new System.Drawing.Size(128, 116);
            this.anhdaidienPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anhdaidienPictureBox.TabIndex = 0;
            this.anhdaidienPictureBox.TabStop = false;
            // 
            // tenTextBox
            // 
            this.tenTextBox.Enabled = false;
            this.tenTextBox.Location = new System.Drawing.Point(146, 51);
            this.tenTextBox.Name = "tenTextBox";
            this.tenTextBox.Size = new System.Drawing.Size(180, 24);
            this.tenTextBox.TabIndex = 6;
            // 
            // sdtTextBox
            // 
            this.sdtTextBox.Enabled = false;
            this.sdtTextBox.Location = new System.Drawing.Point(146, 83);
            this.sdtTextBox.Name = "sdtTextBox";
            this.sdtTextBox.Size = new System.Drawing.Size(180, 24);
            this.sdtTextBox.TabIndex = 7;
            // 
            // diachiTextBox
            // 
            this.diachiTextBox.Enabled = false;
            this.diachiTextBox.Location = new System.Drawing.Point(146, 113);
            this.diachiTextBox.Name = "diachiTextBox";
            this.diachiTextBox.Size = new System.Drawing.Size(180, 24);
            this.diachiTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Enabled = false;
            this.emailTextBox.Location = new System.Drawing.Point(146, 143);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(180, 24);
            this.emailTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Khách hàng";
            // 
            // DaCoKhachHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(338, 188);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.diachiTextBox);
            this.Controls.Add(this.sdtTextBox);
            this.Controls.Add(this.tenTextBox);
            this.Controls.Add(this.anhdaidienPictureBox);
            this.Font = new System.Drawing.Font("Quicksand", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DaCoKhachHangForm";
            this.Text = "DaCoKhachHangForm";
            this.Load += new System.EventHandler(this.DaCoKhachHangForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anhdaidienPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox anhdaidienPictureBox;
        private System.Windows.Forms.TextBox tenTextBox;
        private System.Windows.Forms.TextBox sdtTextBox;
        private System.Windows.Forms.TextBox diachiTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label1;
    }
}