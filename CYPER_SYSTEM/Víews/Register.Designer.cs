namespace CYPER_SYSTEM.Víews
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDangnhap = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtRe_Matkhau = new System.Windows.Forms.TextBox();
            this.btnDangki = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 619);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(542, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng kí";
            // 
            // textBox1
            // 
            this.txtDangnhap.ForeColor = System.Drawing.Color.Gray;
            this.txtDangnhap.Location = new System.Drawing.Point(462, 148);
            this.txtDangnhap.Name = "textBox1";
            this.txtDangnhap.Size = new System.Drawing.Size(280, 22);
            this.txtDangnhap.TabIndex = 2;
            this.txtDangnhap.Text = "Tên đăng nhập";
            // 
            // textBox2
            // 
            this.txtSdt.ForeColor = System.Drawing.Color.Gray;
            this.txtSdt.Location = new System.Drawing.Point(462, 223);
            this.txtSdt.Name = "textBox2";
            this.txtSdt.Size = new System.Drawing.Size(280, 22);
            this.txtSdt.TabIndex = 3;
            this.txtSdt.Text = "Số điện thoại";
            // 
            // textBox3
            // 
            this.txtMatkhau.ForeColor = System.Drawing.Color.Gray;
            this.txtMatkhau.Location = new System.Drawing.Point(462, 296);
            this.txtMatkhau.Name = "textBox3";
            this.txtMatkhau.Size = new System.Drawing.Size(280, 22);
            this.txtMatkhau.TabIndex = 4;
            this.txtMatkhau.Text = "Mật khẩu";
            // 
            // textBox4
            // 
            this.txtRe_Matkhau.ForeColor = System.Drawing.Color.Gray;
            this.txtRe_Matkhau.Location = new System.Drawing.Point(462, 375);
            this.txtRe_Matkhau.Name = "textBox4";
            this.txtRe_Matkhau.Size = new System.Drawing.Size(280, 22);
            this.txtRe_Matkhau.TabIndex = 5;
            this.txtRe_Matkhau.Text = "Nhập lại mật khẩu";
            // 
            // button1
            // 
            this.btnDangki.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDangki.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDangki.Location = new System.Drawing.Point(520, 438);
            this.btnDangki.Name = "button1";
            this.btnDangki.Size = new System.Drawing.Size(130, 42);
            this.btnDangki.TabIndex = 4;
            this.btnDangki.Text = "Đăng kí";
            this.btnDangki.UseVisualStyleBackColor = false;
            this.btnDangki.Click += new System.EventHandler(this.button1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 560);
            this.Controls.Add(this.btnDangki);
            this.Controls.Add(this.txtRe_Matkhau);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtDangnhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Register";
            this.Text = "Đăng kí";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDangnhap;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtRe_Matkhau;
        private System.Windows.Forms.Button btnDangki;
    }
}