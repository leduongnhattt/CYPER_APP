using CYPER_SYSTEM.Database;
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
            using (var context = new CYPER_DBEntities())
            {
                var khachHang = context.KHACHHANGs.FirstOrDefault(kh => kh.TenDangNhap == tenDangNhap);
                if (khachHang != null)
                {
                    khachHang.TenDangNhap = txtTenDangNhap.Text.Trim();
                    khachHang.SDT = txtSoDienThoai.Text.Trim();
                    context.SaveChanges();
                    MessageBox.Show("Cập nhật thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn khách hàng cần chỉnh sửa.");
                }
            }
        }
    }
}
