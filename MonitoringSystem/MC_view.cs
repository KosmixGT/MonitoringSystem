using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitoringSystem
{
    public partial class MC_view : Form
    {
        DataBase dataBase = new DataBase();
        public MC_view()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // запрещаем изменение размера формы, но разрешаем сворачивание и разворачивание окна
        }

        private void MC_view_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();
            string query = @"SELECT название AS ""Название"", 
    ФИО_руков AS ""ФИО руководителя"", 
	дата_получения_лицензии AS ""Дата получения лицензии"",
	номер_лицензии AS ""Номер лицензии"",
	ОПФ_ук.орг_прав_форма AS ""Организационно-правовая форма"",
	почтовый_адрес AS ""Почтовый адрес"",
	контактный_телефон AS ""Контактный телефон"",
	адрес_электронной_почты AS ""Адрес электронной почты""
        FROM Управляющие_компании
		LEFT JOIN ОПФ_ук
        ON Управляющие_компании.ОПФ = ОПФ_ук.код_опф";

            // Создание адаптера данных и заполнение таблицы данными из запроса
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, dataBase.getConnection());
            dataAdapter.Fill(dataTable);
            dataBase.closeConnection();
            // Установка источника данных для DataGridView
            dataGridView1.DataSource = dataTable;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // установка автоматической настройки ширины столбцов
        }
    }
}
