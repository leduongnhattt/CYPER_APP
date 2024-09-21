using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CYPER_SYSTEM.Víews
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.textBox1.Enter += (sender, e) =>
            {
                if (this.textBox1.Text == "Tên đăng nhập")
                {
                    this.textBox1.Text = "";
                    this.textBox1.ForeColor = System.Drawing.Color.Black;
                }
            };

            this.textBox1.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(this.textBox1.Text))
                {
                    this.textBox1.Text = "Tên đăng nhập";
                    this.textBox1.ForeColor = System.Drawing.Color.Gray;
                }
            };

            // Thêm sự kiện cho textBox2
            this.textBox2.Enter += (sender, e) =>
            {
                if (this.textBox2.Text == "Mật khẩu")
                {
                    this.textBox2.Text = "";
                    this.textBox2.ForeColor = System.Drawing.Color.Black;
                    this.textBox2.PasswordChar = '*'; // Ẩn mật khẩu
                }
            };

            this.textBox2.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(this.textBox2.Text))
                {
                    this.textBox2.Text = "Mật khẩu";
                    this.textBox2.ForeColor = System.Drawing.Color.Gray;
                    this.textBox2.PasswordChar = '\0'; // Không ẩn mật khẩu khi gợi ý hiển thị
                }
            };
        }

  
    }
}
