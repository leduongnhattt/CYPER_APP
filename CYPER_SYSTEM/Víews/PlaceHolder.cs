using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CYPER_SYSTEM.Víews
{
    public class PlaceHolder
    {
        private TextBox _textBox;
        private string _placeholder;

        public PlaceHolder(TextBox textBox, string placeholder)
        {
            _textBox = textBox;
            _placeholder = placeholder;

            _textBox.Text = _placeholder;
            _textBox.ForeColor = Color.Gray;

            _textBox.Enter += TextBox_Enter;
            _textBox.Leave += TextBox_Leave;
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            if (_textBox.Text == _placeholder)
            {
                _textBox.Text = "";
                _textBox.ForeColor = Color.Black;
                _textBox.PasswordChar = _textBox.Name.Contains("MatKhau") ? '*' : '\0'; 
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_textBox.Text))
            {
                _textBox.Text = _placeholder;
                _textBox.ForeColor = Color.Gray;
                _textBox.PasswordChar = '\0'; 
            }
        }
    }
}
