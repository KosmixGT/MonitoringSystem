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
    public partial class Reports_view : Form
    {
        private DataBase dataBase = new DataBase();
        public Reports_view() // !!ОТОБРАЖАЮТСЯ ТОЛЬКО ЗАРЕГИСТРИРОВАННЫЕ ОБРАЩЕНИЯ (СОЗДАННЫЕ ДОЛЖНЫ ПРОЙТИ ЭТАП МОДЕРАЦИИ И РЕГИСТРАЦИИ)!!
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // запрещаем изменение размера формы, но разрешаем сворачивание и разворачивание окна
        }

        private void Report_view_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();
            string query = @"SELECT
        код_обращения AS ""Номер обращения"",
        Тема_обращения.тема_проблемы AS ""Тема"",
		Сезон_обращения.сезонность_обр AS ""Сезонность"",
		срок_подг_ответа AS ""Срок подготовки ответа"",
		срок_подтв_ответа AS ""Срок подтверждения ответа"",
		описание AS ""Описание"",
		Статус_обращения.статус_обр AS ""Статус обращения"",
		дата_обращения AS ""Дата обращения"",
		МКД.адрес AS ""Адрес"",
		обслужив_лицо AS ""Обслуживающее лицо"",
		оценка AS ""Оценка""
        FROM Обращения
		LEFT JOIN Тема_обращения
        ON Обращения.тема = Тема_обращения.код_темы_обращения
		LEFT JOIN Сезон_обращения
        ON Обращения.сезонность = Сезон_обращения.код_сезонности_обр
		LEFT JOIN Статус_обращения
        ON Обращения.статус_обращения = Статус_обращения.код_статуса_обращения
		LEFT JOIN МКД
        ON Обращения.объект_МКД = МКД.код_МКД
        WHERE Обращения.статус_обращения != 5";

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
