
namespace POSApplication.DanhMucSanPham
{
    partial class DanhMucForm
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
            this.danhmucBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // danhmucBtn
            // 
            this.danhmucBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.danhmucBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.danhmucBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.danhmucBtn.Font = new System.Drawing.Font("Quicksand SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhmucBtn.ForeColor = System.Drawing.Color.CadetBlue;
            this.danhmucBtn.Location = new System.Drawing.Point(0, 0);
            this.danhmucBtn.Name = "danhmucBtn";
            this.danhmucBtn.Size = new System.Drawing.Size(344, 70);
            this.danhmucBtn.TabIndex = 0;
            this.danhmucBtn.Text = "NUOC UONG";
            this.danhmucBtn.UseVisualStyleBackColor = false;
            // 
            // DanhMucForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 70);
            this.Controls.Add(this.danhmucBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DanhMucForm";
            this.Text = "DanhMucForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button danhmucBtn;
    }
}