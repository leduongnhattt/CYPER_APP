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
                    panelThoat.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 270)
                {
                    sidebarExpand = true;
                    sidebarTransititon.Stop();

                    panelTongquan.Width = sidebar.Width;
                    panelKhachhang.Width = sidebar.Width;
                    panelDichvu.Width = sidebar.Width;
                    panelPhanhoi.Width = sidebar.Width;
                    panelThunhap.Width = sidebar.Width;
                    panelThoat.Width = sidebar.Width;
                }
            }

        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransititon.Start();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
