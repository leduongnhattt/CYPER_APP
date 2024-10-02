namespace CYPER_SYSTEM.Víews
{
    partial class PhanHoi
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TextBox txtPhanHoi;
        private System.Windows.Forms.Button btnGuiPhanHoi;
        private System.Windows.Forms.ComboBox cbKhachHang;
        private System.Windows.Forms.Label lblKhachHang;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.txtPhanHoi = new System.Windows.Forms.TextBox();
            this.btnGuiPhanHoi = new System.Windows.Forms.Button();
            this.cbKhachHang = new System.Windows.Forms.ComboBox();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Location = new System.Drawing.Point(281, 20);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(204, 40);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Phản Hồi Từ Admin";
            // 
            // txtPhanHoi
            // 
            this.txtPhanHoi.Location = new System.Drawing.Point(203, 152);
            this.txtPhanHoi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPhanHoi.Multiline = true;
            this.txtPhanHoi.Name = "txtPhanHoi";
            this.txtPhanHoi.Size = new System.Drawing.Size(394, 201);
            this.txtPhanHoi.TabIndex = 4;
            this.txtPhanHoi.Text = "Nhập phản hồi tại đây...";
            // 
            // btnGuiPhanHoi
            // 
            this.btnGuiPhanHoi.Location = new System.Drawing.Point(315, 376);
            this.btnGuiPhanHoi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGuiPhanHoi.Name = "btnGuiPhanHoi";
            this.btnGuiPhanHoi.Size = new System.Drawing.Size(149, 40);
            this.btnGuiPhanHoi.TabIndex = 5;
            this.btnGuiPhanHoi.Text = "Gửi Phản Hồi";
            this.btnGuiPhanHoi.UseVisualStyleBackColor = true;
            this.btnGuiPhanHoi.Click += new System.EventHandler(this.btnGuiPhanHoi_Click);
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.FormattingEnabled = true;
            this.cbKhachHang.Items.AddRange(new object[] {
            "Khách hàng 1",
            "Khách hàng 2",
            "Khách hàng 3"});
            this.cbKhachHang.Location = new System.Drawing.Point(347, 77);
            this.cbKhachHang.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Size = new System.Drawing.Size(250, 30);
            this.cbKhachHang.TabIndex = 2;
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.Location = new System.Drawing.Point(199, 81);
            this.lblKhachHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(150, 22);
            this.lblKhachHang.TabIndex = 1;
            this.lblKhachHang.Text = "Chọn Khách Hàng:";
            // 
            // PhanHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 520);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblKhachHang);
            this.Controls.Add(this.cbKhachHang);
            this.Controls.Add(this.txtPhanHoi);
            this.Controls.Add(this.btnGuiPhanHoi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "PhanHoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phản Hồi Từ Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
