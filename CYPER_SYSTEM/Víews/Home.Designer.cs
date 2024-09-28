namespace CYPER_SYSTEM.Víews
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTongquan = new System.Windows.Forms.Panel();
            this.btnTongquan = new System.Windows.Forms.Button();
            this.panelDichvu = new System.Windows.Forms.Panel();
            this.btnDichvu = new System.Windows.Forms.Button();
            this.sidebarTransititon = new System.Windows.Forms.Timer(this.components);
            this.panelKhachhang = new System.Windows.Forms.Panel();
            this.btnKhachhang = new System.Windows.Forms.Button();
            this.panelThunhap = new System.Windows.Forms.Panel();
            this.btnThunhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.button16 = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btnPhanhoi = new System.Windows.Forms.Button();
            this.panelPhanhoi = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panelTongquan.SuspendLayout();
            this.panelDichvu.SuspendLayout();
            this.panelKhachhang.SuspendLayout();
            this.panelThunhap.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panelPhanhoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1355, 61);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "CYPER SYSTEM";
            // 
            // btnHam
            // 
            this.btnHam.BackColor = System.Drawing.Color.White;
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(21, 4);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(46, 42);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHam.TabIndex = 1;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sidebar.Controls.Add(this.panelTongquan);
            this.sidebar.Controls.Add(this.panelDichvu);
            this.sidebar.Controls.Add(this.panelKhachhang);
            this.sidebar.Controls.Add(this.panelThunhap);
            this.sidebar.Controls.Add(this.panelPhanhoi);
            this.sidebar.Controls.Add(this.panel12);
            this.sidebar.Controls.Add(this.panel15);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 61);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(256, 562);
            this.sidebar.TabIndex = 1;
            // 
            // panelTongquan
            // 
            this.panelTongquan.Controls.Add(this.btnTongquan);
            this.panelTongquan.Location = new System.Drawing.Point(0, 0);
            this.panelTongquan.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.panelTongquan.Name = "panelTongquan";
            this.panelTongquan.Size = new System.Drawing.Size(260, 53);
            this.panelTongquan.TabIndex = 4;
            // 
            // btnTongquan
            // 
            this.btnTongquan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTongquan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongquan.Image = ((System.Drawing.Image)(resources.GetObject("btnTongquan.Image")));
            this.btnTongquan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTongquan.Location = new System.Drawing.Point(-11, -23);
            this.btnTongquan.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.btnTongquan.Name = "btnTongquan";
            this.btnTongquan.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnTongquan.Size = new System.Drawing.Size(288, 104);
            this.btnTongquan.TabIndex = 2;
            this.btnTongquan.Text = "Tổng quan";
            this.btnTongquan.UseVisualStyleBackColor = false;
            this.btnTongquan.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelDichvu
            // 
            this.panelDichvu.Controls.Add(this.btnDichvu);
            this.panelDichvu.Location = new System.Drawing.Point(0, 83);
            this.panelDichvu.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.panelDichvu.Name = "panelDichvu";
            this.panelDichvu.Size = new System.Drawing.Size(260, 53);
            this.panelDichvu.TabIndex = 5;
            // 
            // btnDichvu
            // 
            this.btnDichvu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDichvu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDichvu.Image = ((System.Drawing.Image)(resources.GetObject("btnDichvu.Image")));
            this.btnDichvu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDichvu.Location = new System.Drawing.Point(-11, -23);
            this.btnDichvu.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.btnDichvu.Name = "btnDichvu";
            this.btnDichvu.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDichvu.Size = new System.Drawing.Size(288, 104);
            this.btnDichvu.TabIndex = 2;
            this.btnDichvu.Text = "Dịch vụ";
            this.btnDichvu.UseVisualStyleBackColor = false;
            this.btnDichvu.Click += new System.EventHandler(this.btnDichvu_Click);
            // 
            // sidebarTransititon
            // 
            this.sidebarTransititon.Interval = 10;
            this.sidebarTransititon.Tick += new System.EventHandler(this.sidebarTransititon_Tick);
            // 
            // panelKhachhang
            // 
            this.panelKhachhang.Controls.Add(this.btnKhachhang);
            this.panelKhachhang.Location = new System.Drawing.Point(0, 166);
            this.panelKhachhang.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.panelKhachhang.Name = "panelKhachhang";
            this.panelKhachhang.Size = new System.Drawing.Size(260, 53);
            this.panelKhachhang.TabIndex = 13;
            // 
            // btnKhachhang
            // 
            this.btnKhachhang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKhachhang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachhang.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachhang.Image")));
            this.btnKhachhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachhang.Location = new System.Drawing.Point(-11, -23);
            this.btnKhachhang.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.btnKhachhang.Name = "btnKhachhang";
            this.btnKhachhang.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnKhachhang.Size = new System.Drawing.Size(288, 104);
            this.btnKhachhang.TabIndex = 2;
            this.btnKhachhang.Text = "Khách hàng";
            this.btnKhachhang.UseVisualStyleBackColor = false;
            // 
            // panelThunhap
            // 
            this.panelThunhap.Controls.Add(this.btnThunhap);
            this.panelThunhap.Location = new System.Drawing.Point(0, 249);
            this.panelThunhap.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.panelThunhap.Name = "panelThunhap";
            this.panelThunhap.Size = new System.Drawing.Size(260, 53);
            this.panelThunhap.TabIndex = 17;
            // 
            // btnThunhap
            // 
            this.btnThunhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThunhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThunhap.Image = ((System.Drawing.Image)(resources.GetObject("btnThunhap.Image")));
            this.btnThunhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThunhap.Location = new System.Drawing.Point(-11, -23);
            this.btnThunhap.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.btnThunhap.Name = "btnThunhap";
            this.btnThunhap.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnThunhap.Size = new System.Drawing.Size(288, 104);
            this.btnThunhap.TabIndex = 2;
            this.btnThunhap.Text = "Thu nhập";
            this.btnThunhap.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(-11, -23);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnThoat.Size = new System.Drawing.Size(288, 104);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnThoat);
            this.panel12.Location = new System.Drawing.Point(0, 415);
            this.panel12.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(260, 53);
            this.panel12.TabIndex = 21;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Image = ((System.Drawing.Image)(resources.GetObject("button16.Image")));
            this.button16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button16.Location = new System.Drawing.Point(-11, -23);
            this.button16.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.button16.Name = "button16";
            this.button16.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button16.Size = new System.Drawing.Size(288, 104);
            this.button16.TabIndex = 2;
            this.button16.Text = "Dịch vụ";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.button16);
            this.panel15.Location = new System.Drawing.Point(260, 0);
            this.panel15.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(260, 53);
            this.panel15.TabIndex = 20;
            // 
            // btnPhanhoi
            // 
            this.btnPhanhoi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPhanhoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanhoi.Image = ((System.Drawing.Image)(resources.GetObject("btnPhanhoi.Image")));
            this.btnPhanhoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhanhoi.Location = new System.Drawing.Point(-11, -23);
            this.btnPhanhoi.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.btnPhanhoi.Name = "btnPhanhoi";
            this.btnPhanhoi.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnPhanhoi.Size = new System.Drawing.Size(288, 104);
            this.btnPhanhoi.TabIndex = 2;
            this.btnPhanhoi.Text = "Phản hồi";
            this.btnPhanhoi.UseVisualStyleBackColor = false;
            // 
            // panelPhanhoi
            // 
            this.panelPhanhoi.Controls.Add(this.btnPhanhoi);
            this.panelPhanhoi.Location = new System.Drawing.Point(0, 332);
            this.panelPhanhoi.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.panelPhanhoi.Name = "panelPhanhoi";
            this.panelPhanhoi.Size = new System.Drawing.Size(260, 53);
            this.panelPhanhoi.TabIndex = 19;
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1355, 623);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Home";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panelTongquan.ResumeLayout(false);
            this.panelDichvu.ResumeLayout(false);
            this.panelKhachhang.ResumeLayout(false);
            this.panelThunhap.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panelPhanhoi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button btnTongquan;
        private System.Windows.Forms.Panel panelTongquan;
        private System.Windows.Forms.Timer sidebarTransititon;
        private System.Windows.Forms.Panel panelDichvu;
        private System.Windows.Forms.Button btnDichvu;
        private System.Windows.Forms.Panel panelKhachhang;
        private System.Windows.Forms.Button btnKhachhang;
        private System.Windows.Forms.Panel panelThunhap;
        private System.Windows.Forms.Button btnThunhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button btnPhanhoi;
        private System.Windows.Forms.Panel panelPhanhoi;
    }
}