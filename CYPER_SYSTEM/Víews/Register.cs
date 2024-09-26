using CYPER_SYSTEM.Database;
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

            if (!ValidateInput(tenDangnhap, sdt, matKhau, xacNhanMatKhau))
                return;

            using (var context = new CYPER_DBEntities())
            {

                if (context.KHACHHANGs.Any(kh => kh.TenDangNhap == tenDangnhap && kh.SDT.Contains(sdt)))
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

        private bool ValidateInput(string tenDangnhap, string sdt, string matKhau, string xacNhanMatKhau)
        {
            if (string.IsNullOrEmpty(tenDangnhap) || tenDangnhap == "Tên đăng nhập")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!");
                return false;
            }

            if (string.IsNullOrEmpty(sdt) || sdt == "Số điện thoại")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!");
                return false;
            }

            if (string.IsNullOrEmpty(matKhau) || matKhau == "Mật khẩu")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return false;
            }

            if (string.IsNullOrEmpty(xacNhanMatKhau) || xacNhanMatKhau == "Nhập lại mật khẩu")
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu!");
                return false;
            }

            if (matKhau != xacNhanMatKhau)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp!");
                return false;
            }

            return true;
        }
    }
}
