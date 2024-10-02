using System.Drawing;

namespace CYPER_SYSTEM.Views
{
    partial class ThanhToan
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox picBankQR; // PictureBox cho QR Ngân hàng
        private System.Windows.Forms.PictureBox picMoMoQR; // PictureBox cho QR MoMo
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.Label lblTenKhachHang; // Thêm Label để hiển thị tên khách hàng
        private System.Windows.Forms.RadioButton rbtnBankQR;
        private System.Windows.Forms.RadioButton rbtnMoMoQR;
        private System.Windows.Forms.Button btnThanhToan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThanhToan));
            this.lblSoTien = new System.Windows.Forms.Label();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.rbtnBankQR = new System.Windows.Forms.RadioButton();
            this.rbtnMoMoQR = new System.Windows.Forms.RadioButton();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.picBankQR = new System.Windows.Forms.PictureBox();
            this.picMoMoQR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBankQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMoMoQR)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Location = new System.Drawing.Point(56, 98);
            this.lblSoTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(95, 25);
            this.lblSoTien.TabIndex = 1;
            this.lblSoTien.Text = "Số tiền: 0";
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Location = new System.Drawing.Point(56, 51);
            this.lblTenKhachHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(165, 25);
            this.lblTenKhachHang.TabIndex = 0;
            this.lblTenKhachHang.Text = "Tên khách hàng: ";
            // 
            // rbtnBankQR
            // 
            this.rbtnBankQR.AutoSize = true;
            this.rbtnBankQR.Location = new System.Drawing.Point(56, 176);
            this.rbtnBankQR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnBankQR.Name = "rbtnBankQR";
            this.rbtnBankQR.Size = new System.Drawing.Size(163, 29);
            this.rbtnBankQR.TabIndex = 2;
            this.rbtnBankQR.TabStop = true;
            this.rbtnBankQR.Text = "QR Ngân hàng";
            this.rbtnBankQR.UseVisualStyleBackColor = true;
            this.rbtnBankQR.CheckedChanged += new System.EventHandler(this.rbtnBankQR_CheckedChanged);
            // 
            // rbtnMoMoQR
            // 
            this.rbtnMoMoQR.AutoSize = true;
            this.rbtnMoMoQR.Location = new System.Drawing.Point(56, 223);
            this.rbtnMoMoQR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnMoMoQR.Name = "rbtnMoMoQR";
            this.rbtnMoMoQR.Size = new System.Drawing.Size(123, 29);
            this.rbtnMoMoQR.TabIndex = 3;
            this.rbtnMoMoQR.TabStop = true;
            this.rbtnMoMoQR.Text = "QR MoMo";
            this.rbtnMoMoQR.UseVisualStyleBackColor = true;
            this.rbtnMoMoQR.CheckedChanged += new System.EventHandler(this.rbtnMoMoQR_CheckedChanged);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(56, 270);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(180, 47);
            this.btnThanhToan.TabIndex = 4;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // picBankQR
            // 
            this.picBankQR.Image = ((System.Drawing.Image)(resources.GetObject("picBankQR.Image")));
            this.picBankQR.Location = new System.Drawing.Point(350, 51);
            this.picBankQR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBankQR.Name = "picBankQR";
            this.picBankQR.Size = new System.Drawing.Size(518, 481);
            this.picBankQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBankQR.TabIndex = 5;
            this.picBankQR.TabStop = false;
            this.picBankQR.Visible = false;
            // 
            // picMoMoQR
            // 
            this.picMoMoQR.Image = ((System.Drawing.Image)(resources.GetObject("picMoMoQR.Image")));
            this.picMoMoQR.Location = new System.Drawing.Point(350, 51);
            this.picMoMoQR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picMoMoQR.Name = "picMoMoQR";
            this.picMoMoQR.Size = new System.Drawing.Size(518, 481);
            this.picMoMoQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMoMoQR.TabIndex = 6;
            this.picMoMoQR.TabStop = false;
            // 
            // ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 576);
            this.Controls.Add(this.lblTenKhachHang);
            this.Controls.Add(this.lblSoTien);
            this.Controls.Add(this.rbtnBankQR);
            this.Controls.Add(this.rbtnMoMoQR);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.picBankQR);
            this.Controls.Add(this.picMoMoQR);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ThanhToan";
            this.Text = "ThanhToan";
            ((System.ComponentModel.ISupportInitialize)(this.picBankQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMoMoQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
