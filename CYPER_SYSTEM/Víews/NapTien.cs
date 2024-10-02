using CYPER_SYSTEM.Database;
using CYPER_SYSTEM.Views;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CYPER_SYSTEM.Víews
{
    public partial class NapTien : Form
    {
        private KHACHHANG khachHang;

        public NapTien()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(tenDangNhap))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập để tìm kiếm!");
                return;
            }

            using (var context = new CYPER_DBEntities())
            {
                khachHang = context.KHACHHANGs.FirstOrDefault(kh => kh.TenDangNhap.Equals(tenDangNhap, StringComparison.OrdinalIgnoreCase));

                if (khachHang == null)
                {
                    MessageBox.Show("Không tìm thấy khách hàng!");
                    return;
                }

                lblMaKhachHang.Text = $"Mã KH: {khachHang.MaKhachHang}";
                lblTenKhachHang.Text = $"Tên KH: {khachHang.TenDangNhap}";
                lblSoDienThoai.Text = $"SĐT: {khachHang.SDT}";
                lblSoDu.Text = $"Số dư: {khachHang.SoDu} VND";
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (khachHang == null)
            {
                MessageBox.Show("Vui lòng tìm kiếm và chọn khách hàng trước khi thanh toán!");
                return;
            }

            decimal soTienNap;
            if (!decimal.TryParse(txtSoTienNap.Text.Trim(), out soTienNap) || soTienNap <= 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền nạp hợp lệ!");
                return;
            }

            var thanhToanForm = new ThanhToan(soTienNap, khachHang.TenDangNhap, khachHang.MaKhachHang);
            thanhToanForm.ShowDialog();
        }
    }
}
