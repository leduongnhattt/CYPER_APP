using CYPER_SYSTEM.Database;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CYPER_SYSTEM.Views
{
    public partial class ThanhToan : Form
    {
        private decimal soTien;
        private int customerId;

        public ThanhToan(decimal soTienNap, string tenKhachHang, int maKhachHang)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            soTien = soTienNap;
            lblSoTien.Text = $"Số tiền: {soTien}";
            lblTenKhachHang.Text += tenKhachHang;
            customerId = maKhachHang;
        }

        private void rbtnBankQR_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnBankQR.Checked)
            {
                picBankQR.Visible = true;
                picMoMoQR.Visible = false;
            }
        }

        private void rbtnMoMoQR_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMoMoQR.Checked)
            {
                picMoMoQR.Visible = true;
                picBankQR.Visible = false;
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (rbtnBankQR.Checked || rbtnMoMoQR.Checked)
            {
                try
                {
                    using (var context = new CYPER_DBEntities())
                    {
                        var khachHang = context.KHACHHANGs
                            .FirstOrDefault(k => k.MaKhachHang == customerId);

                        if (khachHang != null)
                        {
                            khachHang.SoDu += soTien; 
                            var napTien = new NAPTIEN
                            {
                                MaKhachHang = customerId,
                                SoTien = soTien,
                                NgayNapTien = DateTime.Now, 
                                MaNhanVien = null 
                            };

                            context.NAPTIENs.Add(napTien); 
                            context.SaveChanges();
                            MessageBox.Show($"Thanh toán {soTien:C} thành công qua {(rbtnBankQR.Checked ? "QR Ngân hàng" : "QR MoMo")}!",
                                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Khách hàng không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hình thức thanh toán!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
