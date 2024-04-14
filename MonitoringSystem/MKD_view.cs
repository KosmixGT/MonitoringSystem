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
    public partial class MKD_view : Form
    {
        private DataBase dataBase = new DataBase();
        public MKD_view()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // запрещаем изменение размера формы, но разрешаем сворачивание и разворачивание окна
        }

        private void MKD_view_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();
            // Создание запроса для выборки данных из таблицы состояния дома,
            // связанной с таблицей МКД отношением «один ко многим»
            string query = @"SELECT МКД.адрес AS ""Адрес"", 
    МКД.кол_жил_пом AS ""Количество жилых помещений"", 
    Состояние_дома.состояние_объекта_МКД AS ""Состояние дома"", 
    CASE WHEN МКД.детская_площадка = 1 THEN 'Есть' ELSE 'Нет' END AS 'Детская площадка',
    CASE WHEN МКД.спортивная_площадка = 1 THEN 'Есть' ELSE 'Нет' END AS 'Спортивная площадка',
    Способ_управления_МКД.способ_управления AS ""Способ управления"", 
    Управляющие_компании.название AS ""Управляющая компания"", 
    год_постройки AS ""Год постройки""
        FROM МКД LEFT JOIN Состояние_дома
        ON МКД.состояние_МКД = Состояние_дома.код_состояния_объекта
		LEFT JOIN Способ_управления_МКД
        ON МКД.тип_управления = Способ_управления_МКД.код_типа_управления
		LEFT JOIN Управляющие_компании
        ON МКД.УК = Управляющие_компании.код_ук";

            // Создание адаптера данных и заполнение таблицы данными из запроса
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, dataBase.getConnection());
            dataAdapter.Fill(dataTable);
            dataBase.closeConnection();
            // Установка источника данных для DataGridView
            dataGridView1.DataSource = dataTable;


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // установка автоматической настройки ширины столбцов

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // установка автоматической настройки ширины столбца
            }
        }
    }
}
