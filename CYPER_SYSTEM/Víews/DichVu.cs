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
using System.Windows.Forms;

namespace CYPER_SYSTEM.Víews
{
    public partial class DichVu : Form
    {
        public DichVu()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (var context = new CYPER_DBEntities())
            {
                var services = context.DICHVUs.ToList();

                // Tạo một cột hình ảnh mới nếu chưa có
                if (dataGridViewmMenu.Columns["HinhAnhImage"] == null)
                {
                    DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                    imageColumn.Name = "HinhAnhImage";
                    imageColumn.HeaderText = "Hình Ảnh";
                    imageColumn.ImageLayout = DataGridViewImageCellLayout.Normal; // Đặt chế độ hiển thị hình ảnh
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

                // Thiết lập nguồn dữ liệu cho DataGridView
                dataGridViewmMenu.DataSource = services;

                // Gán hình ảnh vào cột tùy chỉnh
                foreach (DataGridViewRow row in dataGridViewmMenu.Rows)
                {
                    var service = (DICHVU)row.DataBoundItem; // Lấy đối tượng dịch vụ tương ứng
                    row.Cells["HinhAnhImage"].Value = service.HinhAnhImage; // Gán hình ảnh vào cột

                    // Tính toán kích thước cho hàng dựa trên kích thước hình ảnh
                    if (service.HinhAnhImage != null)
                    {
                        row.Height = service.HinhAnhImage.Height; // Đặt chiều cao hàng bằng chiều cao hình ảnh
                        dataGridViewmMenu.Columns["HinhAnhImage"].Width = service.HinhAnhImage.Width; // Đặt chiều rộng cột bằng chiều rộng hình ảnh
                    }
                }
            }
        }




    }
}
