
namespace POSApplication.KhachHang
{
    partial class TimKiemKhachHangForm
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
            this.timkiembtn = new System.Windows.Forms.Button();
            this.sdttextbox = new System.Windows.Forms.TextBox();
            this.sdtlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timkiembtn
            // 
            this.timkiembtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.timkiembtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.timkiembtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timkiembtn.Location = new System.Drawing.Point(635, 58);
            this.timkiembtn.Name = "timkiembtn";
            this.timkiembtn.Size = new System.Drawing.Size(80, 30);
            this.timkiembtn.TabIndex = 36;
            this.timkiembtn.Text = "Tìm kiếm";
            this.timkiembtn.UseVisualStyleBackColor = false;
            // 
            // sdttextbox
            // 
            this.sdttextbox.Location = new System.Drawing.Point(162, 58);
            this.sdttextbox.Multiline = true;
            this.sdttextbox.Name = "sdttextbox";
            this.sdttextbox.Size = new System.Drawing.Size(452, 30);
            this.sdttextbox.TabIndex = 35;
            // 
            // sdtlabel
            // 
            this.sdtlabel.AutoSize = true;
            this.sdtlabel.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sdtlabel.Location = new System.Drawing.Point(37, 61);
            this.sdtlabel.Name = "sdtlabel";
            this.sdtlabel.Size = new System.Drawing.Size(119, 25);
            this.sdtlabel.TabIndex = 34;
            this.sdtlabel.Text = "Số điện thoại:";
            // 
            // TimKiemKhachHangForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 150);
            this.Controls.Add(this.timkiembtn);
            this.Controls.Add(this.sdttextbox);
            this.Controls.Add(this.sdtlabel);
            this.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimKiemKhachHangForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button timkiembtn;
        private System.Windows.Forms.TextBox sdttextbox;
        private System.Windows.Forms.Label sdtlabel;
    }
}