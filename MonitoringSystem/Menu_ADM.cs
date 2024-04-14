using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MonitoringSystem
{
    public partial class Menu_ADM : Form
    {
        private bool isUnlogin = false;
        private Autorization par;
        public Menu_ADM(Autorization parent)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // запрещаем изменение размера формы, но разрешаем сворачивание и разворачивание окна
            par = parent;
        }

        private void Menu_MC_Load(object sender, EventArgs e)
        {
            
        }
        private void Menu_MC_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isUnlogin == false)
            {
                GC.Collect();
                Application.Exit();
            }
        }

        private void UnLogin_Click(object sender, EventArgs e)
        {
            isUnlogin = true;
            GC.Collect();
            this.Close();
            par.Show();
        }

        private void data_mc_Click(object sender, EventArgs e)
        {
            var frm = new ManageCompanies_CRUD_ADM();
            frm.ShowDialog();
        }

        private void users_btn_Click(object sender, EventArgs e)
        {
            var frm = new users_CRUD();
            frm.ShowDialog();
        }

        private void mkd_control_Click(object sender, EventArgs e)
        {
            var frm = new MKD_CRUD_ADM();
            frm.ShowDialog();
        }
    }
}
