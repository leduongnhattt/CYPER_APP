using CYPER_SYSTEM.Database;
using CYPER_SYSTEM.Validation;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CYPER_SYSTEM.Víews
{
    public partial class EditKhachHang : Form
    {
        private string tenDangNhap;

        public EditKhachHang(string tenDangNhap, string soDienThoai)
        {
            InitializeComponent();
            this.tenDangNhap = tenDangNhap;
            txtTenDangNhap.Text = tenDangNhap;
            txtSoDienThoai.Text = soDienThoai;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var newTenDangNhap = txtTenDangNhap.Text.Trim();
            var newSoDienThoai = txtSoDienThoai.Text.Trim();

            if (!ValidationHelper.ValidateInput(newTenDangNhap, newSoDienThoai))
            {
                return; 
            }

            using (var context = new CYPER_DBEntities())
            {
                if (ValidationHelper.CheckUserExists(context, newTenDangNhap, newSoDienThoai))
                {
                    MessageBox.Show("Tên đăng nhập hoặc số điện thoại đã tồn tại!");
                    return;
                }

                var khachHang = context.KHACHHANGs.FirstOrDefault(kh => kh.TenDangNhap == tenDangNhap);
                if (khachHang != null)
                {
                    khachHang.TenDangNhap = newTenDangNhap;
                    khachHang.SDT = newSoDienThoai;
                    context.SaveChanges();
                    MessageBox.Show("Cập nhật thành công!");
                    this.DialogResult = DialogResult.OK; 
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng cần chỉnh sửa.");
                }
            }
        }
    }
}
