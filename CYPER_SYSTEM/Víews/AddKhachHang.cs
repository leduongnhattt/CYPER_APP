using CYPER_SYSTEM.Database;
using CYPER_SYSTEM.Validation;
using System;
using System.Windows.Forms;

namespace CYPER_SYSTEM.Víews
{
    public partial class AddKhachHang : Form
    {
        public AddKhachHang()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var tenDangNhap = txtTenDangNhap.Text.Trim();
            var matKhau = txtMatKhau.Text.Trim();
            var sdt = txtSoDienThoai.Text.Trim();
            var xacNhanMatKhau = txtXacNhanMatKhau.Text.Trim(); 
            if (!ValidationHelper.ValidateInput(tenDangNhap, sdt, matKhau, xacNhanMatKhau))
                return;

            using (var context = new CYPER_DBEntities())
            {
                if (ValidationHelper.CheckUserExists(context, tenDangNhap, sdt))
                {
                    MessageBox.Show("Tên đăng nhập hoặc số điện thoại đã tồn tại!");
                    return;
                }

                var khachHang = new KHACHHANG
                {
                    TenDangNhap = tenDangNhap,
                    MatKhau = matKhau,
                    SDT = sdt,
                    SoDu = 0
                };

                context.KHACHHANGs.Add(khachHang);
                context.SaveChanges();
            }

            MessageBox.Show("Thêm khách hàng thành công!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
