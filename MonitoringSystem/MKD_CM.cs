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
    public partial class MKD_CM : Form
    {
        //private DataBase dataBase = new DataBase();
        int MC_code;
        public MKD_CM(int MC_id)
        {
            InitializeComponent();
            MC_code = MC_id;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // запрещаем изменение размера формы, но разрешаем сворачивание и разворачивание окна
            this.мКДDataGridView.DataError += new DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
        }

        private void MKD_view_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.Способ_управления_МКД". При необходимости она может быть перемещена или удалена.
            this.способ_управления_МКДTableAdapter.Fill(this.mainDataSet.Способ_управления_МКД);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.Состояние_дома". При необходимости она может быть перемещена или удалена.
            this.состояние_домаTableAdapter.Fill(this.mainDataSet.Состояние_дома);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.МКД". При необходимости она может быть перемещена или удалена.
            this.мКДTableAdapter.Fill(this.mainDataSet.МКД);

            мКДDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // установка автоматической настройки ширины столбцов

            code_MCToolStripTextBox.Text = MC_code.ToString();

            fillByToolStripButton.PerformClick();

            мКДDataGridView.Columns[1].DefaultCellStyle.NullValue = "*Обязательно к заполнению";
            мКДDataGridView.Columns[3].DefaultCellStyle.NullValue = "*Обязательно к заполнению";
            мКДDataGridView.Columns[6].DefaultCellStyle.NullValue = "*Обязательно к заполнению";
            мКДDataGridView.Columns[7].DefaultCellStyle.NullValue = "*Обязательно к заполнению";
            мКДDataGridView.Columns[10].DefaultCellStyle.NullValue = "*Обязательно к заполнению";
            мКДDataGridView.Columns[12].DefaultCellStyle.NullValue = "*Обязательно к заполнению";
            мКДDataGridView.Columns[13].DefaultCellStyle.NullValue = "*Обязательно к заполнению";
            мКДDataGridView.Columns[14].DefaultCellStyle.NullValue = "*Обязательно к заполнению";
            мКДDataGridView.Columns[15].DefaultCellStyle.NullValue = "*Обязательно к заполнению";

            мКДDataGridView.DefaultValuesNeeded += мКДDataGridView_DefaultValuesNeeded;
            мКДDataGridView.AllowUserToAddRows = false;
        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null && e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Ошибка: Невозможно сохранить изменения. Пожалуйста, введите корректное значение.", "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            e.ThrowException = false;
        }

        private void мКДBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.мКДBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mainDataSet);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.мКДTableAdapter.FillBy(this.mainDataSet.МКД, new System.Nullable<int>(((int)(System.Convert.ChangeType(code_MCToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void мКДDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["dataGridViewTextBoxColumn9"].Value = MC_code.ToString();
        }
    }
}
