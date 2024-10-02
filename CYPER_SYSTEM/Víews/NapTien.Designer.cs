using System;

namespace CYPER_SYSTEM.Víews
{
    partial class NapTien
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblMaKhachHang;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblSoDu;
        private System.Windows.Forms.TextBox txtSoTienNap;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThanhToan;

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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblMaKhachHang = new System.Windows.Forms.Label();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblSoDu = new System.Windows.Forms.Label();
            this.txtSoTienNap = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(58, 62);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(347, 34);
            this.txtTimKiem.TabIndex = 0;
            // 
            // lblMaKhachHang
            // 
            this.lblMaKhachHang.Location = new System.Drawing.Point(53, 139);
            this.lblMaKhachHang.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMaKhachHang.Name = "lblMaKhachHang";
            this.lblMaKhachHang.Size = new System.Drawing.Size(560, 40);
            this.lblMaKhachHang.TabIndex = 2;
            this.lblMaKhachHang.Text = "Mã KH:";
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.Location = new System.Drawing.Point(53, 212);
            this.lblTenKhachHang.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(560, 40);
            this.lblTenKhachHang.TabIndex = 3;
            this.lblTenKhachHang.Text = "Tên KH:";
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.Location = new System.Drawing.Point(53, 284);
            this.lblSoDienThoai.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(560, 40);
            this.lblSoDienThoai.TabIndex = 4;
            this.lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // lblSoDu
            // 
            this.lblSoDu.Location = new System.Drawing.Point(53, 357);
            this.lblSoDu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSoDu.Name = "lblSoDu";
            this.lblSoDu.Size = new System.Drawing.Size(560, 40);
            this.lblSoDu.TabIndex = 5;
            this.lblSoDu.Text = "Số dư:";
            // 
            // txtSoTienNap
            // 
            this.txtSoTienNap.Location = new System.Drawing.Point(58, 431);
            this.txtSoTienNap.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoTienNap.Name = "txtSoTienNap";
            this.txtSoTienNap.Size = new System.Drawing.Size(347, 34);
            this.txtSoTienNap.TabIndex = 6;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(438, 58);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(5);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(175, 42);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(443, 429);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(5);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(175, 39);
            this.btnThanhToan.TabIndex = 7;
            this.btnThanhToan.Text = "Nạp tiền";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // NapTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 942);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.lblMaKhachHang);
            this.Controls.Add(this.lblTenKhachHang);
            this.Controls.Add(this.lblSoDienThoai);
            this.Controls.Add(this.lblSoDu);
            this.Controls.Add(this.txtSoTienNap);
            this.Controls.Add(this.btnThanhToan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "NapTien";
            this.Text = "NapTien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     


        #endregion
    }
}
