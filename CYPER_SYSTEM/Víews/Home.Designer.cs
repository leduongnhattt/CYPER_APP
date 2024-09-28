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
            this.btnTongquan = new System.Windows.Forms.Button();
            this.panelTongquan = new System.Windows.Forms.Panel();
            this.panelDichvu = new System.Windows.Forms.Panel();
            this.btnDichvu = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panelKhachhang = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.btnKhachhang = new System.Windows.Forms.Button();
            this.panelThunhap = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnThunhap = new System.Windows.Forms.Button();
            this.panelPhanhoi = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.btnPhanhoi = new System.Windows.Forms.Button();
            this.sidebarTransititon = new System.Windows.Forms.Timer(this.components);
            this.panelThoat = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panelTongquan.SuspendLayout();
            this.panelDichvu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelKhachhang.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panelThunhap.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panelPhanhoi.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panelThoat.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1355, 49);
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
            this.sidebar.Controls.Add(this.panelThoat);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 49);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(277, 574);
            this.sidebar.TabIndex = 1;
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
            // panelTongquan
            // 
            this.panelTongquan.Controls.Add(this.btnTongquan);
            this.panelTongquan.Location = new System.Drawing.Point(0, 0);
            this.panelTongquan.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.panelTongquan.Name = "panelTongquan";
            this.panelTongquan.Size = new System.Drawing.Size(195, 53);
            this.panelTongquan.TabIndex = 4;
            // 
            // panelDichvu
            // 
            this.panelDichvu.Controls.Add(this.panel4);
            this.panelDichvu.Controls.Add(this.panel5);
            this.panelDichvu.Controls.Add(this.btnDichvu);
            this.panelDichvu.Location = new System.Drawing.Point(3, 86);
            this.panelDichvu.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.panelDichvu.Name = "panelDichvu";
            this.panelDichvu.Size = new System.Drawing.Size(195, 53);
            this.panelDichvu.TabIndex = 6;
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
            this.btnDichvu.Size = new System.Drawing.Size(285, 104);
            this.btnDichvu.TabIndex = 2;
            this.btnDichvu.Text = "Dịch vụ";
            this.btnDichvu.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Location = new System.Drawing.Point(0, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(195, 53);
            this.panel4.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-11, -23);
            this.button2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(256, 104);
            this.button2.TabIndex = 2;
            this.button2.Text = "Service";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button4);
            this.panel5.Location = new System.Drawing.Point(0, -47);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(195, 53);
            this.panel5.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-11, -23);
            this.button4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(256, 104);
            this.button4.TabIndex = 2;
            this.button4.Text = "Dashboard";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panelKhachhang
            // 
            this.panelKhachhang.Controls.Add(this.panel7);
            this.panelKhachhang.Controls.Add(this.panel8);
            this.panelKhachhang.Controls.Add(this.btnKhachhang);
            this.panelKhachhang.Location = new System.Drawing.Point(3, 172);
            this.panelKhachhang.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.panelKhachhang.Name = "panelKhachhang";
            this.panelKhachhang.Size = new System.Drawing.Size(195, 53);
            this.panelKhachhang.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button5);
            this.panel7.Location = new System.Drawing.Point(0, 47);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(195, 53);
            this.panel7.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-11, -23);
            this.button5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(256, 104);
            this.button5.TabIndex = 2;
            this.button5.Text = "Service";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button6);
            this.panel8.Location = new System.Drawing.Point(0, -47);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(195, 53);
            this.panel8.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(-11, -23);
            this.button6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(256, 104);
            this.button6.TabIndex = 2;
            this.button6.Text = "Dashboard";
            this.button6.UseVisualStyleBackColor = false;
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
            this.btnKhachhang.Size = new System.Drawing.Size(285, 104);
            this.btnKhachhang.TabIndex = 2;
            this.btnKhachhang.Text = "Khách hàng";
            this.btnKhachhang.UseVisualStyleBackColor = false;
            // 
            // panelThunhap
            // 
            this.panelThunhap.Controls.Add(this.panel10);
            this.panelThunhap.Controls.Add(this.panel11);
            this.panelThunhap.Controls.Add(this.btnThunhap);
            this.panelThunhap.Location = new System.Drawing.Point(3, 258);
            this.panelThunhap.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.panelThunhap.Name = "panelThunhap";
            this.panelThunhap.Size = new System.Drawing.Size(195, 53);
            this.panelThunhap.TabIndex = 8;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.button1);
            this.panel10.Location = new System.Drawing.Point(0, 47);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(195, 53);
            this.panel10.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-11, -23);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(256, 104);
            this.button1.TabIndex = 2;
            this.button1.Text = "Service";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.button3);
            this.panel11.Location = new System.Drawing.Point(0, -47);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(195, 53);
            this.panel11.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-11, -23);
            this.button3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(256, 104);
            this.button3.TabIndex = 2;
            this.button3.Text = "Dashboard";
            this.button3.UseVisualStyleBackColor = false;
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
            this.btnThunhap.Size = new System.Drawing.Size(285, 104);
            this.btnThunhap.TabIndex = 2;
            this.btnThunhap.Text = "Thu nhập";
            this.btnThunhap.UseVisualStyleBackColor = false;
            // 
            // panelPhanhoi
            // 
            this.panelPhanhoi.Controls.Add(this.panel13);
            this.panelPhanhoi.Controls.Add(this.panel14);
            this.panelPhanhoi.Controls.Add(this.btnPhanhoi);
            this.panelPhanhoi.Location = new System.Drawing.Point(3, 344);
            this.panelPhanhoi.Margin = new System.Windows.Forms.Padding(3, 3, 3, 40);
            this.panelPhanhoi.Name = "panelPhanhoi";
            this.panelPhanhoi.Size = new System.Drawing.Size(195, 53);
            this.panelPhanhoi.TabIndex = 9;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.button7);
            this.panel13.Location = new System.Drawing.Point(0, 47);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(195, 53);
            this.panel13.TabIndex = 8;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(-11, -23);
            this.button7.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(256, 104);
            this.button7.TabIndex = 2;
            this.button7.Text = "Service";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.button8);
            this.panel14.Location = new System.Drawing.Point(0, -47);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(195, 53);
            this.panel14.TabIndex = 7;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(-11, -23);
            this.button8.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(256, 104);
            this.button8.TabIndex = 2;
            this.button8.Text = "Dashboard";
            this.button8.UseVisualStyleBackColor = false;
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
            this.btnPhanhoi.Size = new System.Drawing.Size(285, 104);
            this.btnPhanhoi.TabIndex = 2;
            this.btnPhanhoi.Text = "Phản hồi";
            this.btnPhanhoi.UseVisualStyleBackColor = false;
            // 
            // sidebarTransititon
            // 
            this.sidebarTransititon.Interval = 10;
            this.sidebarTransititon.Tick += new System.EventHandler(this.sidebarTransititon_Tick);
            // 
            // panelThoat
            // 
            this.panelThoat.Controls.Add(this.panel16);
            this.panelThoat.Controls.Add(this.panel17);
            this.panelThoat.Controls.Add(this.btnThoat);
            this.panelThoat.Location = new System.Drawing.Point(0, 437);
            this.panelThoat.Margin = new System.Windows.Forms.Padding(0);
            this.panelThoat.Name = "panelThoat";
            this.panelThoat.Size = new System.Drawing.Size(195, 53);
            this.panelThoat.TabIndex = 10;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.button9);
            this.panel16.Location = new System.Drawing.Point(0, 47);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(195, 53);
            this.panel16.TabIndex = 8;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(-11, -23);
            this.button9.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(256, 104);
            this.button9.TabIndex = 2;
            this.button9.Text = "Service";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.button10);
            this.panel17.Location = new System.Drawing.Point(0, -47);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(195, 53);
            this.panel17.TabIndex = 7;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(-11, -23);
            this.button10.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(256, 104);
            this.button10.TabIndex = 2;
            this.button10.Text = "Dashboard";
            this.button10.UseVisualStyleBackColor = false;
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
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
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
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panelKhachhang.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panelThunhap.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panelPhanhoi.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panelThoat.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelDichvu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDichvu;
        private System.Windows.Forms.Panel panelKhachhang;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnKhachhang;
        private System.Windows.Forms.Panel panelThunhap;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnThunhap;
        private System.Windows.Forms.Panel panelPhanhoi;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnPhanhoi;
        private System.Windows.Forms.Timer sidebarTransititon;
        private System.Windows.Forms.Panel panelThoat;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnThoat;
    }
}