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
    public partial class ManageCompanies_CRUD_ADM : Form
    {
        public ManageCompanies_CRUD_ADM()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.управляющие_компанииDataGridView.DataError += new DataGridViewDataErrorEventHandler(this.управляющие_компанииDataGridView_DataError);
        }

        private void управляющие_компанииBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.управляющие_компанииBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mainDataSet);

        }

        private void ManageCompanies_CRUD_ADM_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.Учётные_записи". При необходимости она может быть перемещена или удалена.
            this.учётные_записиTableAdapter.Fill(this.mainDataSet.Учётные_записи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.ОПФ_ук". При необходимости она может быть перемещена или удалена.
            this.оПФ_укTableAdapter.Fill(this.mainDataSet.ОПФ_ук);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.Управляющие_компании". При необходимости она может быть перемещена или удалена.
            this.управляющие_компанииTableAdapter.Fill(this.mainDataSet.Управляющие_компании);

            управляющие_компанииDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // установка автоматической настройки ширины столбцов
        }
        private void управляющие_компанииDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null && e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Ошибка: Невозможно сохранить изменения. Пожалуйста, введите другое значение.", "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            e.ThrowException = false;
        }
    }
}
