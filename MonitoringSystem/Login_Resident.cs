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
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

namespace MonitoringSystem
{
    public partial class Login_Resident : Form
    {
        DataBase dataBase = new DataBase();
        Autorization par;
        public Login_Resident(Autorization parent)
        {
            InitializeComponent();
            par = parent;
            visible_pswd_box.Visible = false;
            login.MaxLength = 50;
            password.MaxLength = 50;
            password.UseSystemPasswordChar = true;
        }

        private void InvisiblePswd_Click(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = false;
            visible_pswd_box.Visible = true;
            unvisible_pswd_box.Visible = false;
        }

        private void VisiblePswd_Click(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;
            visible_pswd_box.Visible = false;
            unvisible_pswd_box.Visible = true;
        }

        private void enter_Click(object sender, EventArgs e)
        {
            var loginRS= login.Text;
            var passwdRS = password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select код_пользователя, логин, пароль, тип_учётной_записи from Учётные_записи" +
                $" where логин = '{loginRS}' and пароль = '{passwdRS}' and (тип_учётной_записи = {1} or тип_учётной_записи = {3})";
            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
            
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                var userType = (int)table.Rows[0][3];
                if (userType == 3)
                {
                    MessageBox.Show("Вы успешно вошли как администратор", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    var menuAdm = new Menu_ADM(par);
                    menuAdm.Show();
                    par.Hide();
                }
                else
                {
                    MessageBox.Show("Вы успешно вошли", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    var user_code = (int)table.Rows[0][0];
                    var menuRs = new Menu_Resident(user_code, par);
                    menuRs.Show();
                    par.Hide();
                }
            }
            else
            {
                MessageBox.Show("Аккаунт с такими данными не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Login_Resident_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // запрещаем изменение размера формы, но разрешаем сворачивание и разворачивание окна
        }

        private void create_Click(object sender, EventArgs e)
        {
            var loginRS = login.Text;
            var passwdRS = password.Text;

            if (String.IsNullOrEmpty(passwdRS) || String.IsNullOrEmpty(loginRS))
            {
                MessageBox.Show("Поля не должны быть пустыми", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select код_пользователя, логин, пароль, тип_учётной_записи from Учётные_записи" +
                $" where логин = '{loginRS}' and (тип_учётной_записи = {1} or тип_учётной_записи = {3})";
            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 0)
            {
                dataBase.openConnection();
                string insertAccount = $"INSERT INTO [dbo].[Учётные_записи]" +
                                            $" ([логин]" +
                                            $" ,[пароль]" +
                                            $" ,[тип_учётной_записи])" +
                                            $" VALUES" +
                                            $" ('{loginRS}', '{passwdRS}', 1)";

                SqlCommand com = new SqlCommand(insertAccount, dataBase.getConnection());
                int a = com.ExecuteNonQuery();
                dataBase.closeConnection();

                MessageBox.Show("Аккаунт жителя создан", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Аккаунт с таким логином уже есть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void login_TextChanged(object sender, EventArgs e)
        {
            if (login.Text != "")
            {
                string curentText = login.Text;
                Regex regex = new Regex(@"^[a-zA-Zа-яА-Я0-9\s\-""']*$");
                if (regex.IsMatch(curentText) == false || login.Text == "")
                {
                    MessageBox.Show("Вы ввели неверный символ!");
                    login.Clear();
                }
            }
        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V || e.Shift && e.KeyCode == Keys.Insert)
            {
                e.SuppressKeyPress = true; // Предотвращаем вставку
            }
        }
    }
}
