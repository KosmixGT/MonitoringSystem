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
    public partial class Events_CRUD : Form
    {
        DataBase dataBase = new DataBase();
        int MC_code;
        public Events_CRUD(int MC_id)
        {
            InitializeComponent();
            MC_code = MC_id;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // запрещаем изменение размера формы, но разрешаем сворачивание и разворачивание окна
            this.мероприятияDataGridView.DataError += new DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
        }

        private void MKD_view_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet1.Статус_мероприятия". При необходимости она может быть перемещена или удалена.
            this.статус_мероприятияTableAdapter.Fill(this.mainDataSet1.Статус_мероприятия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet1.Категория_мероприятия". При необходимости она может быть перемещена или удалена.
            this.категория_мероприятияTableAdapter.Fill(this.mainDataSet1.Категория_мероприятия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.Мероприятия". При необходимости она может быть перемещена или удалена.
            this.мероприятияTableAdapter.Fill(this.mainDataSet.Мероприятия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.Мероприятия". При необходимости она может быть перемещена или удалена.
            //this.мероприятияTableAdapter.Fill(this.mainDataSet.Мероприятия);


            #region Заполнение комбобокса с объектами МКД
            string zapr = $"select код_МКД, адрес from МКД where УК = {MC_code}";
            DataTable dt = new DataTable();
            SqlDataAdapter at = new SqlDataAdapter(zapr, dataBase.getConnection());
            at.Fill(dt);
            объект_МКДTextBoxColumn.DataSource = dt;
            объект_МКДTextBoxColumn.DataPropertyName = "объект_МКД"; //название вашего столбца с внешним ключом
            объект_МКДTextBoxColumn.DisplayMember = "адрес"; //название столбца с названием значения
            объект_МКДTextBoxColumn.ValueMember = "код_МКД"; //название столбца с кодом значения
            #endregion

            мероприятияDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // установка автоматической настройки ширины столбцов

            код_упр_комToolStripTextBox.Text = MC_code.ToString(); //задаём код управляющей компании по-умолчанию, он не отображается в datagridview
            fillByToolStripButton.PerformClick(); //заполнение элементами только для домов которые управляются текущей компанией

            мероприятияDataGridView.Columns[1].DefaultCellStyle.NullValue = "*Обязательно к заполнению";
            мероприятияDataGridView.Columns[2].DefaultCellStyle.NullValue = "*Обязательно к заполнению";
            мероприятияDataGridView.Columns[3].DefaultCellStyle.NullValue = "*Обязательно к заполнению";
            мероприятияDataGridView.Columns[5].DefaultCellStyle.NullValue = "*Обязательно к заполнению";
            мероприятияDataGridView.Columns[7].DefaultCellStyle.NullValue = "*Обязательно к заполнению";

        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null && e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Ошибка: Невозможно сохранить изменения. Пожалуйста, введите корректное значение..", "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            e.ThrowException = false;
        }
        private void мероприятияBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.мероприятияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mainDataSet);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.мероприятияTableAdapter.FillBy(this.mainDataSet.Мероприятия, ((int)(System.Convert.ChangeType(код_упр_комToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
