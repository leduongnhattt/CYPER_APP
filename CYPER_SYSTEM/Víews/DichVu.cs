using CYPER_SYSTEM.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using CYPER_SYSTEM.Session;

namespace CYPER_SYSTEM.Víews
{
    public partial class DichVu : Form
    {
        public DichVu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadData();
        }

        private void LoadData()
        {
            using (var context = new CYPER_DBEntities())
            {
                var services = context.DICHVUs.ToList();
                if (dataGridViewmMenu.Columns["HinhAnhImage"] == null)
                {
                    DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                    imageColumn.Name = "HinhAnhImage";
                    imageColumn.HeaderText = "Hình Ảnh";
                    imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    dataGridViewmMenu.Columns.Add(imageColumn);
                }

                foreach (var service in services)
                {
                    if (!string.IsNullOrEmpty(service.HinhAnh))
                    {
                        try
                        {
                            using (var webClient = new WebClient())
                            {
                                byte[] imageData = webClient.DownloadData(service.HinhAnh);
                                using (var stream = new MemoryStream(imageData))
                                {
                                    service.HinhAnhImage = Image.FromStream(stream);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error loading image: {ex.Message}");
                            service.HinhAnhImage = null;
                        }
                    }
                    else
                    {
                        service.HinhAnhImage = null;
                    }
                }
                dataGridViewmMenu.DataSource = services;

                foreach (DataGridViewRow row in dataGridViewmMenu.Rows)
                {
                    var service = (DICHVU)row.DataBoundItem;
                    if (service.HinhAnhImage != null)
                    {
                        row.Cells["HinhAnhImage"].Value = service.HinhAnhImage;
                        row.Height = 100;  
                        dataGridViewmMenu.Columns["HinhAnhImage"].Width = 500;
                    }
                }
            }
        }


        private void dataGridViewmMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewmMenu.Rows[e.RowIndex];
                string tenDichVu = selectedRow.Cells["tenDichVuDataGridViewTextBoxColumn"].Value.ToString();
                string donGia = selectedRow.Cells["donGiaDataGridViewTextBoxColumn"].Value.ToString();
                int maDichVu = (int)selectedRow.Cells["maDichVuDataGridViewTextBoxColumn"].Value;
                DialogResult result = MessageBox.Show($"Bạn có muốn mua {tenDichVu} với giá {donGia} không?",
                                                       "Xác nhận mua hàng", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (QuanityForm quantityForm = new QuanityForm())
                    {
                        if (quantityForm.ShowDialog() == DialogResult.OK)
                        {
                            int soLuong = quantityForm.Quantity;
                            double gia = double.Parse(donGia);
                            SaveOrder(soLuong, gia, maDichVu);
                            MessageBox.Show("Mua hàng thành công");
                        }
                    }
                }
            }
        }


        private void dataGridViewmMenu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewmMenu.Columns[e.ColumnIndex].Name == "HinhAnhImage")
            {
                var service = (DICHVU)dataGridViewmMenu.Rows[e.RowIndex].DataBoundItem;
                if (service.HinhAnhImage != null)
                {
                    e.Value = service.HinhAnhImage;
                    e.FormattingApplied = true;
                }
            }
        }
        private void SaveOrder(int soLuong, double donGia, int maDichVu)
        {
            try
            {
                using (var context = new CYPER_DBEntities())
                {
                    var order = new DONHANG
                    {
                        MaDichVu = maDichVu,
                        NgayDat = DateTime.Now,
                        SoLuong = soLuong,
                        DonGia = (decimal)donGia,
                        ThanhTien = (decimal)(donGia * soLuong),
                        MaKhachHang = GetLoggedCustomerId() 
                    };

                    context.DONHANGs.Add(order);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi lưu đơn hàng: {ex.Message}");
            }
        }
        private int GetLoggedCustomerId()
        {
            if (UserSession.CurrentUserId.HasValue)
            {
                return UserSession.CurrentUserId.Value; 
            }
            else
            {
                MessageBox.Show("Người dùng chưa đăng nhập. Bạn sẽ được chuyển đến trang đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Login loginForm = new Login();
                loginForm.Show();
                this.Hide(); 

                return 0; 
            }
        }



    }
}
