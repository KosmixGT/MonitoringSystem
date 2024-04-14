using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitoringSystem
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // запрещаем изменение размера формы, но разрешаем сворачивание и разворачивание окна
            InitializeComponent();
        }

        private void login_uk_Click(object sender, EventArgs e)
        {
            var login_mc = new Login_manageCompany(this);
            login_mc.ShowDialog();
        }

        private void login_resident_Click(object sender, EventArgs e)
        {
            var login_rs = new Login_Resident(this);
            login_rs.ShowDialog();
        }

        private void login_nobody_Click(object sender, EventArgs e)
        {
            var nb = new Unregistered_user(this);
            this.Hide();
            nb.Show();
        }

        private void Autorization_Load(object sender, EventArgs e)
        {

        }

        private void Autorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
        }

        private void Autorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
            Application.Exit();
        }
    }
}
