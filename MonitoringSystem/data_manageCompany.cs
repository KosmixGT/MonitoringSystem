using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MonitoringSystem
{
    public partial class data_manageCompany : Form
    {
        private readonly DataTable table = new DataTable();
        private DataBase dataBase = new DataBase();
        public int MC_code;
        public data_manageCompany(DataTable dt, int MC_id)
        {
            InitializeComponent();
            MC_code = MC_id;
            table = dt;
            OPF_Box.GetElementsForComboBox(); //получить элементы для комбобокса
            OPF_Box.Zapros = "SELECT [орг_прав_форма] FROM [dbo].[ОПФ_ук] order by [код_ОПФ]";
            Filling(); //заполнение элементами
            tb9.text.Trim();
        }

        private void data_manageCompany_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // запрещаем изменение размера формы, но разрешаем сворачивание и разворачивание окна
            tb7.isNumericEntering = true; //включаем для текстбокса что ввод только цифр
            tb7.text.Trim();
            tb7.SetMaxLength(9); //устанавливаем максимально допустимое количество цифр

            tb9.isNumericEntering = true; //включаем для текстбокса что ввод только цифр
            tb9.SetMaxLength(12);
            tb9.text.Trim();

            tb11.isNumericEntering = true; //включаем для текстбокса что ввод только цифр
            tb11.SetMaxLength(13);
            tb11.text.Trim();
            tb17.isEmailEntering = true; //включаем для текстбокса что ввод email'a, регулярное выражение для эл. почты
        }

        private void Filling()
        {
            // Создать массив строк с именами элементов textbox
            string[] textBoxNames = new string[] {"tb2", "tb3", "tb4", "tb5", "tb7", "tb8", "tb9", "tb11", "tb12", "tb13", "tb14", "tb15", "tb16", "tb17" };

            // Цикл для обхода каждого элемента textbox и присвоения ему соответствующего значения из DataTable
            foreach (string textBoxName in textBoxNames)
            {
                // Получить элемент textbox по имени
                labelAndTextBox textBox = this.Controls.Find(textBoxName, true).FirstOrDefault() as labelAndTextBox;
                if (textBox != null)
                {
                    // Получить значение для текущего элемента из DataTable
                    int column = int.Parse(textBoxName.Replace("tb", ""));
                    string value = "";
                    if (!DBNull.Value.Equals(table.Rows[0][column - 1]))
                    {
                        value = table.Rows[0][column - 1].ToString();
                    }

                    // Присвоить значение текущему элементу
                    textBox.tbText = value;
                }
            }
            if (!DBNull.Value.Equals(table.Rows[0][5]))
            {
                licenseDatePicker.Value = (DateTime)table.Rows[0][5];
            }
            else
            {
                DateTime myDate = new DateTime(1900, 1, 1);
                licenseDatePicker.Value = myDate;
            }
            if (!string.IsNullOrEmpty(table.Rows[0][9].ToString()))
            {
                int index = int.Parse(table.Rows[0][9].ToString()) - 1;
                if (index >= 0)
                {
                    OPF_Box.SelecteIndex(index);
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $@"UPDATE [dbo].[Управляющие_компании]
                    SET [название] = @название,
                        [фирм_наим] = @фирм_наим,
                        [сокр_наим] = @сокр_наим,
                        [ФИО_руков] = @ФИО_руков,
                        [дата_получения_лицензии] = @дата_получения_лицензии,
                        [номер_лицензии] = @номер_лицензии,
                        [орган_выдавший_лицензию] = @орган_выдавший_лицензию,
                        [ИНН] = @ИНН,
                        [ОПФ] = @ОПФ,
                        [ОГРН] = @ОГРН,
                        [почтовый_адрес] = @почтовый_адрес,
                        [адрес_ФМОУ] = @адрес_ФМОУ,
                        [место_ГРЮЛ] = @место_ГРЮЛ,
                        [адрес_дисп_службы] = @адрес_дисп_службы,
                        [контактный_телефон] = @контактный_телефон,
                        [адрес_электронной_почты] = @адрес_электронной_почты
                    WHERE [dbo].[Управляющие_компании].[учётная_запись] = {MC_code}";

                SqlCommand command = new SqlCommand(query, dataBase.getConnection());
                dataBase.openConnection();
                command.Parameters.AddWithValue("@название", tb2.tbText);
                command.Parameters.AddWithValue("@фирм_наим", tb3.tbText);
                command.Parameters.AddWithValue("@сокр_наим", tb4.tbText);
                command.Parameters.AddWithValue("@ФИО_руков", tb5.tbText);

                command.Parameters.AddWithValue("@дата_получения_лицензии", licenseDatePicker.Value.ToString("yyyy-MM-dd"));

                command.Parameters.AddWithValue("@номер_лицензии", tb7.tbText);
                command.Parameters.AddWithValue("@орган_выдавший_лицензию", tb8.tbText);
                command.Parameters.AddWithValue("@ИНН", tb9.tbText);

                if (OPF_Box.GetSelectedIndex() != -1)
                {
                    command.Parameters.AddWithValue("@ОПФ", OPF_Box.GetSelectedIndex() + 1);
                }
                else
                {
                    command.Parameters.AddWithValue("@ОПФ", DBNull.Value);
                }
                command.Parameters.AddWithValue("@ОГРН", tb11.tbText);
                command.Parameters.AddWithValue("@почтовый_адрес", tb12.tbText);
                command.Parameters.AddWithValue("@адрес_ФМОУ", tb13.tbText);
                command.Parameters.AddWithValue("@место_ГРЮЛ", tb14.tbText);
                command.Parameters.AddWithValue("@адрес_дисп_службы", tb15.tbText);
                command.Parameters.AddWithValue("@контактный_телефон", tb16.tbText);
                command.Parameters.AddWithValue("@адрес_электронной_почты", tb17.tbText);
                command.ExecuteNonQuery();
                dataBase.closeConnection();
                MessageBox.Show("Данные обновлены", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Произошла ошибка при выполнении запроса: " + ex.Message);
            }
            
        }
    }
}
