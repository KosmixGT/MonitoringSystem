using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace MonitoringSystem
{
    public partial class Menu_Resident : Form
    {
        private bool isUnlogin = false;
        private DataBase dataBase = new DataBase();
        private Autorization par;
        public int RS_code;
        public Menu_Resident(int rs_code, Autorization parent)
        {
            InitializeComponent();
            par = parent;
            RS_code = rs_code;
        }

        private void Menu_Resident_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // запрещаем изменение размера формы, но разрешаем сворачивание и разворачивание окна
        }

        private void Menu_Resident_FormClosed(object sender, FormClosedEventArgs e)
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
            MC_view frm = new MC_view();
            frm.ShowDialog();
        }

        private void reports_view_btn_Click(object sender, EventArgs e)
        {
            Reports_view frm = new Reports_view();
            frm.ShowDialog();
        }

        private void control_reports_btn_Click(object sender, EventArgs e)
        {
            Reports_resident frm = new Reports_resident(RS_code);
            frm.ShowDialog();
        }

        private void ExcelReports_btn_Click(object sender, EventArgs e)
        {
            var query = "SELECT МКД.адрес AS 'Адрес объекта МКД'," +
                " COUNT(*) AS 'Количество обращений на объект МКД'," +
                " SUM(CASE WHEN Обращения.статус_обращения = 3 THEN 1 ELSE 0 END) AS 'Количество решенных обращений на объект МКД'" +
                " FROM Обращения" +
                " INNER JOIN Учётные_записи ON Обращения.учётная_запись = Учётные_записи.код_пользователя" +
                " INNER JOIN МКД ON Обращения.объект_МКД = МКД.код_МКД" +
                $" WHERE Учётные_записи.код_пользователя = {RS_code}" +
                " GROUP BY Учётные_записи.логин, МКД.адрес" +
                " ORDER BY Учётные_записи.логин, МКД.адрес;";

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
                
                string filename = $"Отчёт по обращениям ({cur.ToString("dd-MM-yyyy HH-mm-ss")}).xlsx";
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
                MessageBox.Show("Данных об обращениях для этого пользователя нет!");
            }
        }
    }
}
