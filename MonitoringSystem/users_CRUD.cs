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
    public partial class users_CRUD : Form
    {
        public users_CRUD()
        {
            InitializeComponent();
            this.учётные_записиDataGridView.DataError += new DataGridViewDataErrorEventHandler(this.учётные_записиDataGridView_DataError);
        }

        private void учётные_записиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.учётные_записиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mainDataSet);
        }

        private void users_CRUD_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.Тип_учётной_записи". При необходимости она может быть перемещена или удалена.
            this.тип_учётной_записиTableAdapter.Fill(this.mainDataSet.Тип_учётной_записи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.Учётные_записи". При необходимости она может быть перемещена или удалена.
            this.учётные_записиTableAdapter.Fill(this.mainDataSet.Учётные_записи);


            учётные_записиDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // установка автоматической настройки ширины столбцов

            foreach (DataGridViewColumn column in учётные_записиDataGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // установка автоматической настройки ширины столбца
            }
        }
        private void учётные_записиDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null && e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Ошибка: Невозможно сохранить изменения. Пожалуйста, введите другое значение.", "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            e.ThrowException = false;
        }
    }
}
