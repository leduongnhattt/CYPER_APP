using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using CYPER_SYSTEM.Database; 

namespace CYPER_SYSTEM.Víews
{
    public partial class PhanHoi : Form
    {
        private CYPER_DBEntities dbContext; 

        public PhanHoi()
        {
            InitializeComponent();
            dbContext = new CYPER_DBEntities(); 
            LoadDanhSachKhachHang();
        }

        private void LoadDanhSachKhachHang()
        {
            try
            {

                var danhSachKhachHang = dbContext.KHACHHANGs.ToList();
                cbKhachHang.DataSource = danhSachKhachHang;
                cbKhachHang.DisplayMember = "TenDangNhap"; 
                cbKhachHang.ValueMember = "MaKhachHang";  

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi tải danh sách khách hàng: " + ex.Message);
            }
        }

        private void btnGuiPhanHoi_Click(object sender, EventArgs e)
        {

            if (cbKhachHang.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtPhanHoi.Text) || txtPhanHoi.Text == "Nhập phản hồi tại đây...")
            {
                MessageBox.Show("Vui lòng nhập nội dung phản hồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var khachHangId = (int)cbKhachHang.SelectedValue; 
            string khachHangTen = cbKhachHang.Text; 
            string noiDungPhanHoi = txtPhanHoi.Text;

      
            MessageBox.Show($"Phản hồi đã được gửi đến: {khachHangTen}\n",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtPhanHoi.Clear();
            cbKhachHang.SelectedIndex = -1;
        }
    }
}
