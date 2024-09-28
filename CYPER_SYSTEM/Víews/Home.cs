using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using FontAwesome.Sharp;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CYPER_SYSTEM.Víews
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Sizable;

            // Actice Button khi blur vào
            btnTongquan.MouseEnter += sidebarButton_MouseEnter;
            btnTongquan.MouseLeave += sidebarButton_MouseLeave;
            btnDichvu.MouseEnter += sidebarButton_MouseEnter;
            btnDichvu.MouseLeave += sidebarButton_MouseLeave;
            btnKhachhang.MouseEnter += sidebarButton_MouseEnter;
            btnKhachhang.MouseLeave += sidebarButton_MouseLeave;
            btnPhanhoi.MouseEnter += sidebarButton_MouseEnter;
            btnPhanhoi.MouseLeave += sidebarButton_MouseLeave;
            btnThoat.MouseEnter += sidebarButton_MouseEnter;
            btnThoat.MouseLeave += sidebarButton_MouseLeave;
            btnThunhap.MouseEnter += sidebarButton_MouseEnter;
            btnThunhap.MouseLeave += sidebarButton_MouseLeave;
        }

        private void sidebarButton_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(100, 100, 255); 
            btn.ForeColor = Color.White; 
        }

        private void sidebarButton_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = SystemColors.ActiveCaption; 
            btn.ForeColor = Color.Black; 
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        bool sidebarExpand = true;
        private void sidebarTransititon_Tick(object sender, EventArgs e)
        {


            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 81)
                {
                    sidebarExpand = false;
                    sidebarTransititon.Stop();

                    panelTongquan.Width = sidebar.Width;
                    panelKhachhang.Width = sidebar.Width;
                    panelDichvu.Width = sidebar.Width;
                    panelPhanhoi.Width = sidebar.Width;
                    panelThunhap.Width = sidebar.Width;
                    panelThunhap.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 260)
                {
                    sidebarExpand = true;
                    sidebarTransititon.Stop();

                    panelTongquan.Width = sidebar.Width;
                    panelKhachhang.Width = sidebar.Width;
                    panelDichvu.Width = sidebar.Width;
                    panelPhanhoi.Width = sidebar.Width;
                    panelThunhap.Width = sidebar.Width;
                    panelThunhap.Width = sidebar.Width;
                }
            }

        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransititon.Start();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát ?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDichvu_Click(object sender, EventArgs e)
        {
            new DichVu().Show();
        }
    }
}
