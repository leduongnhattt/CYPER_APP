using CYPER_SYSTEM.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CYPER_SYSTEM.Validation
{
    public static class ValidationHelper
    {
        public static bool ValidateInput(string tenDangnhap, string sdt, string matKhau = null, string xacNhanMatKhau = null)
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

        public static bool CheckUserExists(CYPER_DBEntities context, string tenDangNhap, string sdt)
        {
            return context.KHACHHANGs.Any(kh => kh.TenDangNhap.Equals(tenDangNhap, StringComparison.OrdinalIgnoreCase) ||
                                                 kh.SDT.Contains(sdt));
        }
    }
}
