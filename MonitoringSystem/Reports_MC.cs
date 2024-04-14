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
    public partial class Reports_MC : Form
    {
        //private DataBase dataBase = new DataBase();
        int MC_code;
        public Reports_MC(int id)
        {
            InitializeComponent();
            MC_code = id;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // запрещаем изменение размера формы, но разрешаем сворачивание и разворачивание окна
            this.обращенияDataGridView.DataError += new DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
        }

        private void обращенияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.обращенияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mainDataSet);
        }

        private void Reports_MC_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.Сезон_обращения". При необходимости она может быть перемещена или удалена.
            this.сезон_обращенияTableAdapter.Fill(this.mainDataSet.Сезон_обращения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.Статус_обращения". При необходимости она может быть перемещена или удалена.
            this.статус_обращенияTableAdapter.Fill(this.mainDataSet.Статус_обращения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.МКД". При необходимости она может быть перемещена или удалена.
            this.мКДTableAdapter.Fill(this.mainDataSet.МКД);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.Учётные_записи". При необходимости она может быть перемещена или удалена.
            this.учётные_записиTableAdapter.Fill(this.mainDataSet.Учётные_записи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.Обращения". При необходимости она может быть перемещена или удалена.
            this.обращенияTableAdapter.Fill(this.mainDataSet.Обращения);

            обращенияDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            parametrToolStripTextBox.Text = MC_code.ToString();
            fillByToolStripButton.PerformClick();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.обращенияTableAdapter.FillBy(this.mainDataSet.Обращения, ((int)(System.Convert.ChangeType(parametrToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null && e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Ошибка: Невозможно сохранить изменения. Пожалуйста, введите корректное значение..", "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            e.ThrowException = false;
        }
    }
}
