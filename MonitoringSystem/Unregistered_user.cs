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
    public partial class Unregistered_user : Form
    {
        private Autorization par;
        public Unregistered_user(Autorization parent)
        {
            InitializeComponent();
            par = parent;
        }

        private void mkd_view_btn_Click(object sender, EventArgs e)
        {
            MKD_view frm = new MKD_view();
            frm.ShowDialog();
        }
        private void events_view_btn_Click(object sender, EventArgs e)
        {
            Events_view frm = new Events_view();
            frm.ShowDialog();
        }

        private void companies_view_btn_Click(object sender, EventArgs e)
        {
            MC_view frm = new MC_view();
            frm.ShowDialog();
        }

        private void reports_view_btn_Click(object sender, EventArgs e)
        {
            Reports_view frm = new Reports_view();
            frm.ShowDialog();
        }
        private void Unregistered_user_FormClosed(object sender, FormClosedEventArgs e)
        {
            par.Show();
        }

        private void Unregistered_user_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // запрещаем изменение размера формы, но разрешаем сворачивание и разворачивание окна
            BackColor = Color.FromArgb(238, 238, 238);
            mkd_view_btn.BackColor = Color.FromArgb(102, 104, 255);
            events_view_btn.BackColor = Color.FromArgb(102, 104, 255);
            companies_view_btn.BackColor = Color.FromArgb(102, 104, 255);
            reports_view_btn.BackColor = Color.FromArgb(102, 104, 255);

            mkd_view_btn.FlatAppearance.BorderColor = Color.Black;
            events_view_btn.FlatAppearance.BorderColor = Color.Black;
            companies_view_btn.FlatAppearance.BorderColor = Color.Black;
            reports_view_btn.FlatAppearance.BorderColor = Color.Black;

            mkd_view_btn.FlatStyle = FlatStyle.Flat;
            events_view_btn.FlatStyle = FlatStyle.Flat;
            companies_view_btn.FlatStyle = FlatStyle.Flat;
            reports_view_btn.FlatStyle = FlatStyle.Flat;
        }
    }
}
