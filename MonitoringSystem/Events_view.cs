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
    public partial class Events_view : Form
    {
        DataBase dataBase = new DataBase();
        public Events_view()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // запрещаем изменение размера формы, но разрешаем сворачивание и разворачивание окна
        }

        private void Events_view_Load(object sender, EventArgs e)
        {
            string query = @"SELECT Категория_мероприятия.категория_меропр AS ""Категория мероприятия"", 
    тема_меропр AS ""Тема мероприятия"", 
    МКД.адрес AS ""Адрес"",
	описание AS ""Описание"",
	дата_время_проведения AS ""Дата и время и проведения"",
	исполнитель AS ""Исполнитель"",
	Статус_мероприятия.статус_меропр AS ""Статус мероприятия""
        FROM Мероприятия
		LEFT JOIN Категория_мероприятия
        ON Мероприятия.кат_меропр = Категория_мероприятия.код_категории_меропр
		LEFT JOIN МКД
        ON Мероприятия.объект_МКД = МКД.код_МКД
		LEFT JOIN Статус_мероприятия
        ON Мероприятия.статус_меропр = Статус_мероприятия.код_тек_статуса_меропр";

            // Создание адаптера данных и заполнение таблицы данными из запроса
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, dataBase.getConnection());
            dataAdapter.Fill(dataTable);

            // Установка источника данных для DataGridView
            dataGridView1.DataSource = dataTable;


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // установка автоматической настройки ширины столбцов

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // установка автоматической настройки ширины столбца
            }
        }
    }
}
