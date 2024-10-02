using CYPER_SYSTEM.Database;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CYPER_SYSTEM.Views
{
    public partial class TongQuan : Form
    {
        public TongQuan()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; 

            cbMonth.SelectedIndex = 0;
            cbYear.SelectedIndex = 3; 
            LoadDefaultData();
        }

        private void LoadDefaultData()
        {
            chart1.Series[0].Points.Clear();
            decimal[] monthlyRevenue = new decimal[] { 1200, 1500, 1800, 2100, 2500, 3000, 3200, 2800, 3400, 4000, 4500, 5000 };

            for (int month = 0; month < monthlyRevenue.Length; month++)
            {
                chart1.Series[0].Points.AddXY(month + 1, monthlyRevenue[month]);
            }
            lblTongDoanhThu.Text = $"Tổng doanh thu: {monthlyRevenue.Sum():C}"; 
            lblSoLuongKhachHang.Text = $"Số lượng khách hàng: {monthlyRevenue.Length}"; 
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new CYPER_DBEntities())
            {
                int selectedMonth = int.Parse(cbMonth.SelectedItem?.ToString() ?? "0");
                int selectedYear = int.Parse(cbYear.SelectedItem?.ToString() ?? DateTime.Now.Year.ToString());

                var napTienQuery = context.NAPTIENs.AsQueryable();

                if (selectedMonth > 0)
                {
                    napTienQuery = napTienQuery.Where(x => x.NgayNapTien.HasValue && x.NgayNapTien.Value.Month == selectedMonth && x.NgayNapTien.Value.Year == selectedYear);
                }
                else if (selectedYear > 0)
                {
                    napTienQuery = napTienQuery.Where(x => x.NgayNapTien.HasValue && x.NgayNapTien.Value.Year == selectedYear);
                }

                var totalNapTienRevenue = napTienQuery.Sum(x => x.SoTien) ?? 0; // Sửa lỗi ở đây
                var napTienCustomerCount = napTienQuery.Select(x => x.MaKhachHang).Distinct().Count();

                // Lấy doanh thu từ đơn hàng
                var donHangQuery = context.DONHANGs.AsQueryable();

                if (selectedMonth > 0)
                {
                    donHangQuery = donHangQuery.Where(x => x.NgayDat.HasValue && x.NgayDat.Value.Month == selectedMonth && x.NgayDat.Value.Year == selectedYear);
                }
                else if (selectedYear > 0)
                {
                    donHangQuery = donHangQuery.Where(x => x.NgayDat.HasValue && x.NgayDat.Value.Year == selectedYear);
                }

                var totalDonHangRevenue = donHangQuery.Sum(x => x.ThanhTien) ?? 0; // Sửa lỗi ở đây
                var donHangCustomerCount = donHangQuery.Select(x => x.MaKhachHang).Distinct().Count();

                // Tính tổng doanh thu và số lượng khách hàng
                decimal totalRevenue = totalNapTienRevenue + totalDonHangRevenue;
                int totalCustomerCount = napTienCustomerCount + donHangCustomerCount;

                lblTongDoanhThu.Text = $"Tổng doanh thu: {totalRevenue:C}";
                lblSoLuongKhachHang.Text = $"Số lượng khách hàng: {totalCustomerCount}";

                // Hiển thị biểu đồ
                var monthlyRevenue = napTienQuery
                    .GroupBy(x => x.NgayNapTien.Value.Month)
                    .Select(g => new { Month = g.Key, Total = g.Sum(x => x.SoTien) })
                    .ToList();

                var monthlyDonHangRevenue = donHangQuery
                    .GroupBy(x => x.NgayDat.Value.Month)
                    .Select(g => new { Month = g.Key, Total = g.Sum(x => x.ThanhTien) })
                    .ToList();

                chart1.Series[0].Points.Clear();
                foreach (var data in monthlyRevenue)
                {
                    chart1.Series[0].Points.AddXY(data.Month, data.Total);
                }
                foreach (var data in monthlyDonHangRevenue)
                {
                    chart1.Series[0].Points.AddXY(data.Month, data.Total);
                }
            }
        }
    }
}
