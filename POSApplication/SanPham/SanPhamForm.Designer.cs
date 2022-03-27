
namespace POSApplication.SanPham
{
    partial class SanPhamForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tenspLabel = new System.Windows.Forms.Label();
            this.giasLabel = new System.Windows.Forms.Label();
            this.soluongTextBox = new System.Windows.Forms.TextBox();
            this.congBtn = new System.Windows.Forms.Button();
            this.truBtn = new System.Windows.Forms.Button();
            this.themBtn = new System.Windows.Forms.Button();
            this.spPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tenspLabel);
            this.panel1.Controls.Add(this.giasLabel);
            this.panel1.Controls.Add(this.soluongTextBox);
            this.panel1.Controls.Add(this.congBtn);
            this.panel1.Controls.Add(this.truBtn);
            this.panel1.Controls.Add(this.themBtn);
            this.panel1.Controls.Add(this.spPictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 359);
            this.panel1.TabIndex = 0;
            // 
            // tenspLabel
            // 
            this.tenspLabel.AutoSize = true;
            this.tenspLabel.Location = new System.Drawing.Point(98, 200);
            this.tenspLabel.Name = "tenspLabel";
            this.tenspLabel.Size = new System.Drawing.Size(69, 30);
            this.tenspLabel.TabIndex = 13;
            this.tenspLabel.Text = "Name";
            this.tenspLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // giasLabel
            // 
            this.giasLabel.AutoSize = true;
            this.giasLabel.Location = new System.Drawing.Point(116, 266);
            this.giasLabel.Name = "giasLabel";
            this.giasLabel.Size = new System.Drawing.Size(35, 30);
            this.giasLabel.TabIndex = 12;
            this.giasLabel.Text = "4$";
            this.giasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // soluongTextBox
            // 
            this.soluongTextBox.Font = new System.Drawing.Font("Quicksand", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soluongTextBox.Location = new System.Drawing.Point(88, 239);
            this.soluongTextBox.Name = "soluongTextBox";
            this.soluongTextBox.Size = new System.Drawing.Size(88, 24);
            this.soluongTextBox.TabIndex = 11;
            // 
            // congBtn
            // 
            this.congBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.congBtn.Font = new System.Drawing.Font("Quicksand", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.congBtn.Location = new System.Drawing.Point(182, 235);
            this.congBtn.Name = "congBtn";
            this.congBtn.Size = new System.Drawing.Size(43, 32);
            this.congBtn.TabIndex = 10;
            this.congBtn.Text = "+";
            this.congBtn.UseVisualStyleBackColor = true;
            this.congBtn.Click += new System.EventHandler(this.congBtn_Click);
            // 
            // truBtn
            // 
            this.truBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.truBtn.Font = new System.Drawing.Font("Quicksand", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.truBtn.Location = new System.Drawing.Point(46, 237);
            this.truBtn.Name = "truBtn";
            this.truBtn.Size = new System.Drawing.Size(38, 29);
            this.truBtn.TabIndex = 9;
            this.truBtn.Text = "-";
            this.truBtn.UseVisualStyleBackColor = true;
            this.truBtn.Click += new System.EventHandler(this.truBtn_Click);
            // 
            // themBtn
            // 
            this.themBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.themBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.themBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themBtn.Font = new System.Drawing.Font("Quicksand Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themBtn.ForeColor = System.Drawing.Color.Transparent;
            this.themBtn.Location = new System.Drawing.Point(79, 314);
            this.themBtn.Margin = new System.Windows.Forms.Padding(2);
            this.themBtn.Name = "themBtn";
            this.themBtn.Size = new System.Drawing.Size(97, 34);
            this.themBtn.TabIndex = 8;
            this.themBtn.Text = "Add";
            this.themBtn.UseVisualStyleBackColor = false;
            // 
            // spPictureBox
            // 
            this.spPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spPictureBox.BackColor = System.Drawing.Color.BlueViolet;
            this.spPictureBox.Location = new System.Drawing.Point(22, 17);
            this.spPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.spPictureBox.Name = "spPictureBox";
            this.spPictureBox.Size = new System.Drawing.Size(209, 174);
            this.spPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spPictureBox.TabIndex = 7;
            this.spPictureBox.TabStop = false;
            // 
            // SanPhamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 359);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "SanPhamForm";
            this.Text = "SanPhamForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tenspLabel;
        private System.Windows.Forms.Label giasLabel;
        private System.Windows.Forms.TextBox soluongTextBox;
        private System.Windows.Forms.Button congBtn;
        public System.Windows.Forms.Button truBtn;
        private System.Windows.Forms.Button themBtn;
        private System.Windows.Forms.PictureBox spPictureBox;
    }
}