using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace MonitoringSystem
{
    public partial class Menu_MC : Form
    {
        private bool isUnlogin = false;
        private DataBase dataBase = new DataBase();
        private Autorization par;
        public int MC_code;
        private int id_UK;
        public Menu_MC(int mc_code, Autorization parent)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // запрещаем изменение размера формы, но разрешаем сворачивание и разворачивание окна
            par = parent;
            MC_code = mc_code;
            id_UK = GetIdManageCompany();
        }

        private void Menu_MC_Load(object sender, EventArgs e)
        {
            if (!isConfirmed())
            {
                MessageBox.Show("Ваша УК не подтверждена. Некоторые функции могут быть не доступны.", "Предпреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                reportsMC_btn.Enabled = false;
                curr_mkd_btn.Enabled = false;
                curr_event_btn.Enabled = false;
                ExcelRpMc_btn.Enabled = false;
            }
        }


        private void Menu_MC_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isUnlogin == false)
            {
                GC.Collect();
                System.Windows.Forms.Application.Exit();
            }
        }

        private void UnLogin_Click(object sender, EventArgs e)
        {
            isUnlogin = true;
            GC.Collect();
            this.Close();
            par.Show();
        }

        private void data_mc_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            System.Data.DataTable table = new System.Data.DataTable();

            string querystring = $"SELECT [код_ук],[название],[фирм_наим],[сокр_наим],[ФИО_руков],[дата_получения_лицензии]," +
                $"[номер_лицензии],[орган_выдавший_лицензию],[ИНН],[ОПФ],[ОГРН],[почтовый_адрес],[адрес_ФМОУ],[место_ГРЮЛ],[адрес_дисп_службы]," +
                $"[контактный_телефон],[адрес_электронной_почты],[учётная_запись],[подтверждение]FROM[dbo].[Управляющие_компании] where[учётная_запись] = {MC_code}";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            
            foreach (DataRow row in table.Rows)
            {
                if (!DBNull.Value.Equals(row["дата_получения_лицензии"]))
                {
                    row["дата_получения_лицензии"] = Convert.ToDateTime(row["дата_получения_лицензии"]).Date;
                }
            }

            data_manageCompany frm = new data_manageCompany(table, MC_code);
            frm.ShowDialog();
        }

        private void reportsMC_btn_Click(object sender, EventArgs e)
        {
            Reports_MC frm = new Reports_MC(id_UK);
            frm.ShowDialog();
        }
        private int GetIdManageCompany() //получает код управляющей компании в таблице Управляющие компании
        {
            string selectQuery = $@"SELECT код_ук FROM dbo.Управляющие_компании WHERE учётная_запись = {MC_code}";
            int code_MCInManageCompany = -1;
            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, dataBase.getConnection());
            System.Data.DataTable table = new System.Data.DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                code_MCInManageCompany = (int)table.Rows[0][0];
            }
            return code_MCInManageCompany;
        }
        private void curr_mkd_btn_Click(object sender, EventArgs e)
        {
            MKD_CM frm = new MKD_CM(id_UK);
            frm.ShowDialog();
        }

        private void curr_event_btn_Click(object sender, EventArgs e)
        {
            Events_CRUD frm = new Events_CRUD(id_UK);
            frm.ShowDialog();
        }

        private void SaveReport(object sender, EventArgs e)
        {
            var query = $"SELECT Учётные_записи.логин AS 'Пользователь'," +
                $" МКД.адрес AS 'Адрес объекта МКД'," +
                $" COUNT(*) AS 'Количество обращений на объект МКД'," +
                $" SUM(CASE WHEN Обращения.статус_обращения = 3 THEN 1 ELSE 0 END) AS 'Количество решенных обращений на объект МКД'" +
                $" FROM Обращения" +
                $" INNER JOIN Учётные_записи ON Обращения.учётная_запись = Учётные_записи.код_пользователя" +
                $" INNER JOIN МКД ON Обращения.объект_МКД = МКД.код_МКД" +
                $" WHERE МКД.УК = {id_UK}" +
                $" GROUP BY Учётные_записи.логин, МКД.адрес" +
                $" ORDER BY Учётные_записи.логин, МКД.адрес;";

            var datatable = new System.Data.DataTable();

            queryReturnData(query, datatable);

            ExportToExcel(datatable);
        }

        public System.Data.DataTable queryReturnData(string query, System.Data.DataTable dataTable)
        {
            dataBase.openConnection();

            SqlDataAdapter SDA = new SqlDataAdapter(query, dataBase.getConnection());
            SDA.SelectCommand.ExecuteNonQuery();
            SDA.Fill(dataTable);
            return dataTable;
        }
        private void ExportToExcel(System.Data.DataTable dataTable)
        {
            if (dataTable.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dataTable.Columns.Count + 1; i++)
                {
                    excel.Cells[1, i] = dataTable.Columns[i - 1].ColumnName;
                }

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        excel.Cells[i + 2, j + 1] = dataTable.Rows[i][j].ToString();
                    }
                }
                excel.Columns.AutoFit();

                DateTime cur = DateTime.Now;

                string filename = $"Статистика обращений жителей по объектам МКД ({cur.ToString("dd-MM-yyyy HH-mm-ss")}).xlsx";
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string fullPath = Path.Combine(path, filename);

                excel.ActiveWorkbook.SaveAs(fullPath);
                excel.Visible = true;

                MessageBox.Show("Файл сохранён в Мои Документы", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Закрыть только приложение Excel
                excel.Quit();

                // Освободить ресурсы
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
                excel = null;

                GC.Collect();
            }
            else
            {
                MessageBox.Show("Данных нет!");
            }
        }

        private bool isConfirmed()
        {
            System.Data.DataTable dataTable = new System.Data.DataTable();
            string query = $"SELECT Управляющие_компании.подтверждение FROM Управляющие_компании WHERE Управляющие_компании.учётная_запись = {MC_code}";
            dataBase.openConnection();
            SqlDataAdapter SDA = new SqlDataAdapter(query, dataBase.getConnection());
            SDA.SelectCommand.ExecuteNonQuery();
            SDA.Fill(dataTable);
            dataBase.closeConnection();
            return bool.Parse(dataTable.Rows[0][0].ToString());
        }
    }
}
