using CYPER_SYSTEM.Database;
using CYPER_SYSTEM.Session;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CYPER_SYSTEM.Víews
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (var context = new CYPER_DBEntities())
            {
                var khachHangList = context.KHACHHANGs.ToList();
                int stt = 1;
                dataGridView1.Rows.Clear();
                foreach (var kh in khachHangList)
                {
                    string tinhTrang = IsUserLoggedIn(kh.TenDangNhap) ? "Hoạt Động" : "Không Hoạt Động";
                    dataGridView1.Rows.Add(stt++, kh.TenDangNhap, kh.SDT, tinhTrang, kh.SoDu);
                }
            }
        }

        private bool IsUserLoggedIn(string tenDangNhap)
        {
            return tenDangNhap.Equals(UserSession.CurrentUserName, StringComparison.OrdinalIgnoreCase);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchTerm = txtTimKiem.Text.Trim();

            using (var context = new CYPER_DBEntities())
            {
                var ketQuaTimKiem = context.KHACHHANGs
                    .Where(kh => kh.TenDangNhap.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();
                dataGridView1.Rows.Clear();
                int stt = 1; 
                foreach (var kh in ketQuaTimKiem)
                {
                    dataGridView1.Rows.Add(stt++, kh.TenDangNhap, kh.SDT,
                        kh.SoDu > 0 ? "Hoạt Động" : "Không Hoạt Động", kh.SoDu);
                }
            }
        }


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridViewButtonColumnEdit.Index)
                {
                    var tenDangNhap = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    var soDienThoai = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    var editForm = new EditKhachHang(tenDangNhap, soDienThoai);
                    editForm.ShowDialog();
                    LoadData(); 
                }
                else if (e.ColumnIndex == dataGridViewButtonColumnDelete.Index)
                {
                    var result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        var tenDangNhap = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                        using (var context = new CYPER_DBEntities())
                        {
                            var khachHang = context.KHACHHANGs.FirstOrDefault(kh => kh.TenDangNhap == tenDangNhap);
                            if (khachHang != null)
                            {
                                context.KHACHHANGs.Remove(khachHang);
                                context.SaveChanges();
                            }
                        }
                        LoadData();
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var addForm = new AddKhachHang();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Thêm mới thành công!");
                LoadData();
            }
        }

    }
}
