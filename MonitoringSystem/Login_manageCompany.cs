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
using System.Text.RegularExpressions;

namespace MonitoringSystem
{
    public partial class Login_manageCompany : Form
    {
        private DataBase dataBase = new DataBase();
        private Autorization par;
        public Login_manageCompany(Autorization parent)
        {
            InitializeComponent();
            par = parent;
            VisiblePswd.Visible = false;
            login.MaxLength = 50;
            password.MaxLength = 50;
            password.UseSystemPasswordChar = true;
        }

        private void Login_manageCompany_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // запрещаем изменение размера формы, но разрешаем сворачивание и разворачивание окна
        }

        private void InvisiblePswd_Click(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = false;
            VisiblePswd.Visible = true;
            InvisiblePswd.Visible = false;
        } //смена отображения пароля

        private void VisiblePswd_Click(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;
            VisiblePswd.Visible = false;
            InvisiblePswd.Visible = true;
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            var loginMC = login.Text;
            var passwdMC = password.Text;

            dataBase.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select код_пользователя, логин, пароль, тип_учётной_записи from Учётные_записи" +
                $" where логин = '{loginMC}' and пароль = '{passwdMC}' and тип_учётной_записи = {2}";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
            
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                var user_code = (int)table.Rows[0][0];
                var menuMC = new Menu_MC(user_code, par);
                menuMC.Show();
                par.Hide();
            }
            else
            {
                MessageBox.Show("Аккаунт с такими данными не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataBase.closeConnection();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            var loginMc = login.Text;
            var passwdMc = password.Text;

            if (String.IsNullOrEmpty(passwdMc) || String.IsNullOrEmpty(loginMc))
            {
                MessageBox.Show("Поля не должны быть пустыми", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select код_пользователя, логин, пароль, тип_учётной_записи from Учётные_записи" +
                $" where логин = '{loginMc}' and тип_учётной_записи = 2";
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
                                            $" ('{loginMc}', '{passwdMc}', 2)";
                SqlCommand insAcc = new SqlCommand(insertAccount, dataBase.getConnection());
                insAcc.ExecuteNonQuery();

                #region GetUserId
                SqlDataAdapter adpt = new SqlDataAdapter();
                DataTable tbl = new DataTable();
                string getUserId = $"select код_пользователя from Учётные_записи" +
                $" where логин = '{loginMc}' and пароль = '{passwdMc}' and тип_учётной_записи = {2}";
                SqlCommand getId = new SqlCommand(getUserId, dataBase.getConnection());
                adpt.SelectCommand = getId;
                adpt.Fill(tbl);
                int us_Id = int.Parse(tbl.Rows[0][0].ToString());
                #endregion

                string insertMC = $"INSERT INTO [dbo].[Управляющие_компании] ([сокр_наим],[учётная_запись],[подтверждение])" +
                                    $" VALUES" +
                                    $" ('{loginMc}', {us_Id}, 0)";
                

                SqlCommand com = new SqlCommand(insertMC, dataBase.getConnection());
                com.ExecuteNonQuery();
                dataBase.closeConnection();

                MessageBox.Show("Аккаунт УК создан.\nДанные о компании вы можете настроить в меню 'Данные об УК'", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Аккаунт с таким логином уже есть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
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
