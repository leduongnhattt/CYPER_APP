using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CYPER_SYSTEM.Víews
{
    public partial class QuanityForm : Form
    {
        public int Quantity { get; private set; }
        public QuanityForm()
        {
            InitializeComponent();
        }

        private void btnMua_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuanity.Text, out int quantity) && quantity > 0)
            {
                Quantity = quantity;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Số lượng không hợp lệ, vui lòng nhập số lớn hơn 0.");
            }
        }
    }
}
