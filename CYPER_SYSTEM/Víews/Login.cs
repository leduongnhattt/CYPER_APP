using CYPER_SYSTEM.Database;
using CYPER_SYSTEM.Session;
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
            this.StartPosition = FormStartPosition.CenterScreen;
            new PlaceHolder(txtDangnhap, "Tên đăng nhập");
            new PlaceHolder(txtMatkhau, "Mật khẩu");
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register signUpForm = new Register();
            signUpForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
   

            using (var context = new CYPER_DBEntities())
            {
                string tenDangnhap = txtDangnhap.Text.Trim();
                string matKhau = txtMatkhau.Text.Trim();

 
                var user = context.KHACHHANGs
                    .AsEnumerable() 
                    .FirstOrDefault(s => s.TenDangNhap == tenDangnhap && s.MatKhau.ToString() == matKhau);

                if (user != null)
                {
                    UserSession.CurrentUserId = user.MaKhachHang; 
                    UserSession.CurrentUserName = user.TenDangNhap;
                    MessageBox.Show("Đăng nhập thành công");
                    new Home().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công");
                }
            }

        }
    }
}
