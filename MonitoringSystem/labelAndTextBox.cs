using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitoringSystem
{
    public partial class labelAndTextBox : UserControl
    {
        public bool isNumericEntering = false;
        public bool isEmailEntering = false;
        public labelAndTextBox()
        {
            InitializeComponent();
        }
        public string text
        {
            get
            {
                return label1.Text;
            }
            set
            {
                this.label1.Text = value;
            }
        }
        public string tbText
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                this.textBox1.Text = value;
            }
        }
        public void SetMaxLength(int length)
        {
            textBox1.MaxLength = length;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isNumericEntering)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;// отказываем в вводе
                }
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (isEmailEntering)
            {
                string email = textBox1.Text.Trim();

                if (!string.IsNullOrEmpty(email))
                {
                    bool isEmailValid = Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

                    if (!isEmailValid)
                    {
                        MessageBox.Show("Неверный формат email адреса.");
                        e.Cancel = true;
                    }
                }
            }
        }
    }
}
