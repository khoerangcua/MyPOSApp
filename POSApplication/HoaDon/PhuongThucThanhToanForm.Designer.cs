
namespace POSApplication.HoaDon
{
    partial class PhuongThucThanhToanForm
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
            this.tienmatRadioButton = new System.Windows.Forms.RadioButton();
            this.theRadioButotn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tienmatRadioButton
            // 
            this.tienmatRadioButton.AutoSize = true;
            this.tienmatRadioButton.Location = new System.Drawing.Point(17, 43);
            this.tienmatRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tienmatRadioButton.Name = "tienmatRadioButton";
            this.tienmatRadioButton.Size = new System.Drawing.Size(88, 25);
            this.tienmatRadioButton.TabIndex = 0;
            this.tienmatRadioButton.TabStop = true;
            this.tienmatRadioButton.Text = "Tiền mặt";
            this.tienmatRadioButton.UseVisualStyleBackColor = true;
            // 
            // theRadioButotn
            // 
            this.theRadioButotn.AutoSize = true;
            this.theRadioButotn.Location = new System.Drawing.Point(17, 74);
            this.theRadioButotn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.theRadioButotn.Name = "theRadioButotn";
            this.theRadioButotn.Size = new System.Drawing.Size(55, 25);
            this.theRadioButotn.TabIndex = 1;
            this.theRadioButotn.TabStop = true;
            this.theRadioButotn.Text = "Thẻ";
            this.theRadioButotn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phương thức thanh toán";
            // 
            // PhuongThucThanhToanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(338, 112);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.theRadioButotn);
            this.Controls.Add(this.tienmatRadioButton);
            this.Font = new System.Drawing.Font("Quicksand", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PhuongThucThanhToanForm";
            this.Text = "PhuongThucThanhToanForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton tienmatRadioButton;
        private System.Windows.Forms.RadioButton theRadioButotn;
        private System.Windows.Forms.Label label1;
    }
}