using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MonitoringSystem
{
    public partial class Reports_resident : Form
    {
        DataBase dataBase = new DataBase();
        public int RS_code;
        public Reports_resident(int id_rs)
        {
            InitializeComponent();
            RS_code = id_rs;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.reports_DGV.DataError += new DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            reports_DGV.CellFormatting += new DataGridViewCellFormattingEventHandler(reports_DGV_CellFormatting);
        }

        private void Reports_resident_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();
            load_Refresh_DGV();

            reports_DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // установка автоматической настройки ширины столбцов
            reports_DGV.MultiSelect = false;
        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null && e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Ошибка: Невозможно сохранить изменения. Пожалуйста, выберите значение из списка.", "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            e.ThrowException = false;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            int rp_code;
            if (reports_DGV.SelectedRows.Count > 0)
            {
                var row = reports_DGV.SelectedRows[0];

                rp_code = int.Parse(row.Cells["кодобращенияDataGridViewTextBoxColumn"].FormattedValue.ToString());
                try
                {
                    // открываем соединение с бд
                    dataBase.openConnection();

                    string query = $@"UPDATE [dbo].[Обращения]
                                        SET
                                            [тема] =  @тема,
                                            [сезонность] = @сезонность,
                                            [описание] = @описание,
                                            [объект_МКД] =  @объект_МКД,
                                            [оценка] = @оценка
                                        WHERE Обращения.код_обращения = {rp_code}";
                    // создаем команду с запросом на обновление записи
                    SqlCommand command = new SqlCommand(query, dataBase.getConnection());

                    command.Parameters.AddWithValue("@тема", темаComboBox.SelectedValue);
                    command.Parameters.AddWithValue("@сезонность", сезонностьComboBox.SelectedValue);
                    command.Parameters.AddWithValue("@описание", описаниеTextBox.Text);
                    command.Parameters.AddWithValue("@объект_МКД", объект_МКДComboBox.SelectedValue);
                    command.Parameters.AddWithValue("@оценка", оценкаTextBox.Text);

                    // выполняем команду на обновление записи
                    int rowsAffected = command.ExecuteNonQuery();

                    // выводим сообщение об успешном обновлении записи
                    MessageBox.Show(string.Format("Обновлено {0} запись(и/ей)", rowsAffected));
                }
                catch (Exception ex)
                {
                    // выводим сообщение об ошибке
                    MessageBox.Show("Ошибка при обновлении записи: " + ex.Message);
                }
                finally
                {
                    load_Refresh_DGV();
                    //обращенияTableAdapter.Update(dataSet.Обращения);
                    dataBase.closeConnection();
                }
            }
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // открываем соединение с бд
                dataBase.openConnection();

                DateTime cur = DateTime.Now;
                string dateNow = cur.ToString("dd-MM-yyyy");

                string query = "INSERT INTO [dbo].[Обращения]" +
                    " ([тема],[сезонность],[описание],[статус_обращения],[дата_обращения],[объект_МКД],[учётная_запись])" +
                    " VALUES" +
                    $" ({темаComboBox.SelectedValue}, {сезонностьComboBox.SelectedValue}, '{описаниеTextBox.Text}'," +
                    $" 5, '{dateNow}', {объект_МКДComboBox.SelectedValue}, {RS_code})";
                // создаем команду с запросом на добавление записи
                SqlCommand command = new SqlCommand(query, dataBase.getConnection());

                // выполняем команду на добавление записи
                int rowsAffected = command.ExecuteNonQuery();

                // выводим сообщение об успешном добавлении записи
                MessageBox.Show("Обращение добавлено");
            }
            catch (Exception ex)
            {
                // выводим сообщение об ошибке
                MessageBox.Show("Ошибка при добавлении записи: " + ex.Message, "Ошибка");
            }
            finally
            {
                dataBase.closeConnection();
                load_Refresh_DGV();
                reports_DGV.Invalidate();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (reports_DGV.SelectedRows.Count > 0)
            {
                var row = reports_DGV.SelectedRows[0];

                темаComboBox.Text = row.Cells["темаDataGridViewTextBoxColumn"].FormattedValue.ToString();
                сезонностьComboBox.Text = row.Cells["сезонностьDataGridViewTextBoxColumn"].FormattedValue.ToString();
                описаниеTextBox.Text = row.Cells["описаниеDataGridViewTextBoxColumn"].FormattedValue.ToString();
                объект_МКДComboBox.Text = row.Cells["объектМКДDataGridViewTextBoxColumn"].FormattedValue.ToString();
                оценкаTextBox.Text = row.Cells["оценкаDataGridViewTextBoxColumn"].FormattedValue.ToString();

                int rp_state = int.Parse(row.Cells["статусобращенияDataGridViewTextBoxColumn"].Value.ToString());

                if (rp_state == 4 || rp_state == 1 || rp_state == 2) //если обращение зарегистрировано в системе и не решено
                {
                    MessageBox.Show("Данное обращение зарегистрировано, изменять его данные нельзя!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    темаComboBox.Enabled = false;
                    сезонностьComboBox.Enabled = false;
                    описаниеTextBox.Enabled = false;
                    объект_МКДComboBox.Enabled = false;
                    оценкаTextBox.Enabled = false;
                }
                else if(rp_state == 3) //если обращение зарегистрировано в системе и решено
                {
                    MessageBox.Show("Данное обращение решено, изменять его данные нельзя." +
                        " \n Вы можете оставить оценку для этого обращения", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    темаComboBox.Enabled = false;
                    сезонностьComboBox.Enabled = false;
                    описаниеTextBox.Enabled = false;
                    объект_МКДComboBox.Enabled = false;
                    оценкаTextBox.Enabled = true;
                }
                else //если обращение только создано в системе и не проходило модерацию
                {
                    MessageBox.Show("Данное обращение ещё не проходило модерацию, вы можете изменить данные." , "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    темаComboBox.Enabled = true;
                    сезонностьComboBox.Enabled = true;
                    описаниеTextBox.Enabled = true;
                    объект_МКДComboBox.Enabled = true;
                    оценкаTextBox.Enabled = false;
                }

            }
        }
        private void load_Refresh_DGV()
        {
            dataBase.openConnection();

            reports_DGV.TabStop = false;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.МКД". При необходимости она может быть перемещена или удалена.
            this.мКДTableAdapter.Fill(this.mainDataSet.МКД);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Сезон_обращения". При необходимости она может быть перемещена или удалена.
            this.сезон_обращенияTableAdapter.Fill(this.dataSet.Сезон_обращения);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Тема_обращения". При необходимости она может быть перемещена или удалена.
            this.тема_обращенияTableAdapter.Fill(this.dataSet.Тема_обращения);

            string selectQuery = $@"SELECT код_обращения, тема, сезонность, срок_подг_ответа, срок_подтв_ответа, описание,
                                    статус_обращения, дата_обращения, объект_МКД, обслужив_лицо, оценка,
                                    учётная_запись FROM dbo.Обращения
                                WHERE учётная_запись = {RS_code}";

            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, dataBase.getConnection());
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            reports_DGV.DataSource = bindingSource;

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            adapter.UpdateCommand = commandBuilder.GetUpdateCommand();

            #region Заполнение комбобокса с темами
            string zapr = "select код_темы_обращения, тема_проблемы from Тема_обращения";
            DataTable dt = new DataTable();
            SqlDataAdapter at = new SqlDataAdapter(zapr, dataBase.getConnection());
            at.Fill(dt);
            темаDataGridViewTextBoxColumn.DataSource = dt;
            темаDataGridViewTextBoxColumn.DataPropertyName = "тема"; //название вашего столбца с внешним ключом
            темаDataGridViewTextBoxColumn.DisplayMember = "тема_проблемы"; //название столбца с названием значения в таблице 2
            темаDataGridViewTextBoxColumn.ValueMember = "код_темы_обращения"; //название столбца с кодом значения в таблице 2
            #endregion

            #region Заполнение комбобокса с сезонами
            string zapr1 = "select код_сезонности_обр, сезонность_обр from Сезон_обращения";
            DataTable dt1 = new DataTable();
            SqlDataAdapter at1 = new SqlDataAdapter(zapr1, dataBase.getConnection());
            at1.Fill(dt1);
            сезонностьDataGridViewTextBoxColumn.DataSource = dt1;
            сезонностьDataGridViewTextBoxColumn.DataPropertyName = "сезонность"; //название вашего столбца с внешним ключом
            сезонностьDataGridViewTextBoxColumn.DisplayMember = "сезонность_обр"; //название столбца с названием значения в таблице 2
            сезонностьDataGridViewTextBoxColumn.ValueMember = "код_сезонности_обр"; //название столбца с кодом значения в таблице 2
            #endregion

            #region Заполнение комбобокса с объектами МКД
            string zapr2 = "select код_МКД, адрес from МКД";
            DataTable dt2 = new DataTable();
            SqlDataAdapter at2 = new SqlDataAdapter(zapr2, dataBase.getConnection());
            at2.Fill(dt2);
            объектМКДDataGridViewTextBoxColumn.DataSource = dt2;
            объектМКДDataGridViewTextBoxColumn.DataPropertyName = "объект_МКД"; //название вашего столбца с внешним ключом
            объектМКДDataGridViewTextBoxColumn.DisplayMember = "адрес"; //название столбца с названием значения в таблице 2
            объектМКДDataGridViewTextBoxColumn.ValueMember = "код_МКД"; //название столбца с кодом значения в таблице 2
            #endregion

            #region Заполнение комбобокса со статусом обращения
            string zapr3 = "select код_статуса_обращения, статус_обр from Статус_обращения";
            DataTable dt3 = new DataTable();
            SqlDataAdapter at3 = new SqlDataAdapter(zapr3, dataBase.getConnection());
            at3.Fill(dt3);
            статусобращенияDataGridViewTextBoxColumn.DataSource = dt3;
            статусобращенияDataGridViewTextBoxColumn.DataPropertyName = "статус_обращения"; //название вашего столбца с внешним ключом
            статусобращенияDataGridViewTextBoxColumn.DisplayMember = "статус_обр"; //название столбца с названием значения в таблице 2
            статусобращенияDataGridViewTextBoxColumn.ValueMember = "код_статуса_обращения"; //название столбца с кодом значения в таблице 2
            #endregion

            темаComboBox.Text = "";
            сезонностьComboBox.Text = "";
            описаниеTextBox.Text = "";
            объект_МКДComboBox.Text = "";
            оценкаTextBox.Text = "";

            темаComboBox.SelectedValue = "0";
            сезонностьComboBox.SelectedValue = "0";
            объект_МКДComboBox.SelectedValue = "0";

            темаComboBox.Enabled = false;
            сезонностьComboBox.Enabled = false;
            описаниеTextBox.Enabled = false;
            объект_МКДComboBox.Enabled = false;
            оценкаTextBox.Enabled = false;

        }

        private void reports_DGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (e.Value != null)
                {
                    if (e.Value.ToString() == "Решено")
                    {
                        reports_DGV.Rows[e.RowIndex].Cells[0].Style.BackColor = Color.Lime;
                    }
                    else if (e.Value.ToString() == "В работе")
                    {
                        reports_DGV.Rows[e.RowIndex].Cells[0].Style.BackColor = Color.LightBlue;
                    }
                    else if (e.Value.ToString() == "Модерация" || e.Value.ToString() == "Зарегистрировано")
                    {
                        reports_DGV.Rows[e.RowIndex].Cells[0].Style.BackColor = Color.LightCoral;
                    }
                    else if (e.Value.ToString() == "Создано")
                    {
                        reports_DGV.Rows[e.RowIndex].Cells[0].Style.BackColor = Color.White;
                    }
                }
            }
        }

        private void openData_btn_Click(object sender, EventArgs e)
        {
            темаComboBox.Text = "";
            сезонностьComboBox.Text = "";
            описаниеTextBox.Text = "";
            объект_МКДComboBox.Text = "";
            оценкаTextBox.Text = "";

            темаComboBox.SelectedValue = "0";
            сезонностьComboBox.SelectedValue = "0";
            объект_МКДComboBox.SelectedValue = "0";

            темаComboBox.Enabled = true;
            сезонностьComboBox.Enabled = true;
            описаниеTextBox.Enabled = true;
            объект_МКДComboBox.Enabled = true;
            оценкаTextBox.Enabled = false;
        }
    }
}