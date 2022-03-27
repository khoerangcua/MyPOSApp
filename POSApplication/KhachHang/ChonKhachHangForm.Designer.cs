
namespace POSApplication.KhachHang
{
    partial class ChonKhachHangForm
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
            this.chonkhachhanhlabel = new System.Windows.Forms.Label();
            this.timkiempanel = new System.Windows.Forms.Panel();
            this.thongtinkhachhangpanel = new System.Windows.Forms.Panel();
            this.chonbtn = new System.Windows.Forms.Button();
            this.taomoibtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chonkhachhanhlabel
            // 
            this.chonkhachhanhlabel.AutoSize = true;
            this.chonkhachhanhlabel.Font = new System.Drawing.Font("Quicksand", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chonkhachhanhlabel.Location = new System.Drawing.Point(248, 9);
            this.chonkhachhanhlabel.Name = "chonkhachhanhlabel";
            this.chonkhachhanhlabel.Size = new System.Drawing.Size(350, 59);
            this.chonkhachhanhlabel.TabIndex = 30;
            this.chonkhachhanhlabel.Text = "Chọn khách hàng";
            // 
            // timkiempanel
            // 
            this.timkiempanel.Location = new System.Drawing.Point(12, 87);
            this.timkiempanel.Name = "timkiempanel";
            this.timkiempanel.Size = new System.Drawing.Size(800, 150);
            this.timkiempanel.TabIndex = 31;
            // 
            // thongtinkhachhangpanel
            // 
            this.thongtinkhachhangpanel.Location = new System.Drawing.Point(12, 243);
            this.thongtinkhachhangpanel.Name = "thongtinkhachhangpanel";
            this.thongtinkhachhangpanel.Size = new System.Drawing.Size(800, 290);
            this.thongtinkhachhangpanel.TabIndex = 32;
            // 
            // chonbtn
            // 
            this.chonbtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.chonbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chonbtn.ForeColor = System.Drawing.Color.White;
            this.chonbtn.Location = new System.Drawing.Point(338, 539);
            this.chonbtn.Name = "chonbtn";
            this.chonbtn.Size = new System.Drawing.Size(80, 30);
            this.chonbtn.TabIndex = 37;
            this.chonbtn.Text = "Chọn";
            this.chonbtn.UseVisualStyleBackColor = false;
            // 
            // taomoibtn
            // 
            this.taomoibtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.taomoibtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taomoibtn.ForeColor = System.Drawing.Color.White;
            this.taomoibtn.Location = new System.Drawing.Point(424, 539);
            this.taomoibtn.Name = "taomoibtn";
            this.taomoibtn.Size = new System.Drawing.Size(80, 30);
            this.taomoibtn.TabIndex = 38;
            this.taomoibtn.Text = "Tạo mới";
            this.taomoibtn.UseVisualStyleBackColor = false;
            // 
            // ChonKhachHangForm
            // 
            this.ClientSize = new System.Drawing.Size(834, 581);
            this.Controls.Add(this.chonbtn);
            this.Controls.Add(this.taomoibtn);
            this.Controls.Add(this.thongtinkhachhangpanel);
            this.Controls.Add(this.timkiempanel);
            this.Controls.Add(this.chonkhachhanhlabel);
            this.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChonKhachHangForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chonkhachhanhlabel;
        private System.Windows.Forms.Panel timkiempanel;
        private System.Windows.Forms.Panel thongtinkhachhangpanel;
        private System.Windows.Forms.Button chonbtn;
        private System.Windows.Forms.Button taomoibtn;
    }
}