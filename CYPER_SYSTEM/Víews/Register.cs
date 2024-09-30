using CYPER_SYSTEM.Database;
using CYPER_SYSTEM.Validation;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CYPER_SYSTEM.Víews
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            new PlaceHolder(txtDangnhap, "Tên đăng nhập");
            new PlaceHolder(txtSdt, "Số điện thoại");
            new PlaceHolder(txtMatkhau, "Mật khẩu");
            new PlaceHolder(txtRe_Matkhau, "Nhập lại mật khẩu");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenDangnhap = txtDangnhap.Text.Trim();
            string sdt = txtSdt.Text.Trim();
            string matKhau = txtMatkhau.Text.Trim();
            string xacNhanMatKhau = txtRe_Matkhau.Text.Trim();

            if (!ValidationHelper.ValidateInput(tenDangnhap, sdt, matKhau, xacNhanMatKhau))
                return;

            using (var context = new CYPER_DBEntities())
            {
                if (ValidationHelper.CheckUserExists(context, tenDangnhap, sdt))
                {
                    MessageBox.Show("Tên đăng nhập hoặc số điện thoại đã tồn tại!");
                    return;
                }

                var newUser = new KHACHHANG
                {
                    TenDangNhap = tenDangnhap,
                    MatKhau = matKhau,
                    SDT = sdt,
                    SoDu = 0
                };

                context.KHACHHANGs.Add(newUser);
                context.SaveChanges();

                MessageBox.Show("Đăng ký thành công!");
                this.Close();
                new Login().Show();
            }
        }



    }
}
