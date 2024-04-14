namespace MonitoringSystem
{
    partial class ManageCompanies_CRUD_ADM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCompanies_CRUD_ADM));
            this.mainDataSet = new MonitoringSystem.MainDataSet();
            this.управляющие_компанииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.управляющие_компанииTableAdapter = new MonitoringSystem.MainDataSetTableAdapters.Управляющие_компанииTableAdapter();
            this.tableAdapterManager = new MonitoringSystem.MainDataSetTableAdapters.TableAdapterManager();
            this.оПФ_укTableAdapter = new MonitoringSystem.MainDataSetTableAdapters.ОПФ_укTableAdapter();
            this.учётные_записиTableAdapter = new MonitoringSystem.MainDataSetTableAdapters.Учётные_записиTableAdapter();
            this.управляющие_компанииBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.управляющие_компанииBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.управляющие_компанииDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.оПФукBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.учётныезаписиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.управляющие_компанииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.управляющие_компанииBindingNavigator)).BeginInit();
            this.управляющие_компанииBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.управляющие_компанииDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оПФукBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учётныезаписиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainDataSet
            // 
            this.mainDataSet.DataSetName = "MainDataSet";
            this.mainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // управляющие_компанииBindingSource
            // 
            this.управляющие_компанииBindingSource.DataMember = "Управляющие_компании";
            this.управляющие_компанииBindingSource.DataSource = this.mainDataSet;
            // 
            // управляющие_компанииTableAdapter
            // 
            this.управляющие_компанииTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = MonitoringSystem.MainDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Категория_мероприятияTableAdapter = null;
            this.tableAdapterManager.Категория_проблемыTableAdapter = null;
            this.tableAdapterManager.МероприятияTableAdapter = null;
            this.tableAdapterManager.МКДTableAdapter = null;
            this.tableAdapterManager.ОбращенияTableAdapter = null;
            this.tableAdapterManager.ОПФ_укTableAdapter = this.оПФ_укTableAdapter;
            this.tableAdapterManager.Сезон_обращенияTableAdapter = null;
            this.tableAdapterManager.Состояние_домаTableAdapter = null;
            this.tableAdapterManager.Способ_управления_МКДTableAdapter = null;
            this.tableAdapterManager.Статус_мероприятияTableAdapter = null;
            this.tableAdapterManager.Статус_обращенияTableAdapter = null;
            this.tableAdapterManager.Тема_обращенияTableAdapter = null;
            this.tableAdapterManager.Тип_учётной_записиTableAdapter = null;
            this.tableAdapterManager.Управляющие_компанииTableAdapter = this.управляющие_компанииTableAdapter;
            this.tableAdapterManager.Учётные_записиTableAdapter = this.учётные_записиTableAdapter;
            // 
            // оПФ_укTableAdapter
            // 
            this.оПФ_укTableAdapter.ClearBeforeFill = true;
            // 
            // учётные_записиTableAdapter
            // 
            this.учётные_записиTableAdapter.ClearBeforeFill = true;
            // 
            // управляющие_компанииBindingNavigator
            // 
            this.управляющие_компанииBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.управляющие_компанииBindingNavigator.BindingSource = this.управляющие_компанииBindingSource;
            this.управляющие_компанииBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.управляющие_компанииBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.управляющие_компанииBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.управляющие_компанииBindingNavigatorSaveItem});
            this.управляющие_компанииBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.управляющие_компанииBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.управляющие_компанииBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.управляющие_компанииBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.управляющие_компанииBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.управляющие_компанииBindingNavigator.Name = "управляющие_компанииBindingNavigator";
            this.управляющие_компанииBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.управляющие_компанииBindingNavigator.Size = new System.Drawing.Size(996, 25);
            this.управляющие_компанииBindingNavigator.TabIndex = 0;
            this.управляющие_компанииBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // управляющие_компанииBindingNavigatorSaveItem
            // 
            this.управляющие_компанииBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.управляющие_компанииBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("управляющие_компанииBindingNavigatorSaveItem.Image")));
            this.управляющие_компанииBindingNavigatorSaveItem.Name = "управляющие_компанииBindingNavigatorSaveItem";
            this.управляющие_компанииBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.управляющие_компанииBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.управляющие_компанииBindingNavigatorSaveItem.Click += new System.EventHandler(this.управляющие_компанииBindingNavigatorSaveItem_Click);
            // 
            // управляющие_компанииDataGridView
            // 
            this.управляющие_компанииDataGridView.AutoGenerateColumns = false;
            this.управляющие_компанииDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.управляющие_компанииDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewCheckBoxColumn1});
            this.управляющие_компанииDataGridView.DataSource = this.управляющие_компанииBindingSource;
            this.управляющие_компанииDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.управляющие_компанииDataGridView.Location = new System.Drawing.Point(0, 25);
            this.управляющие_компанииDataGridView.Name = "управляющие_компанииDataGridView";
            this.управляющие_компанииDataGridView.Size = new System.Drawing.Size(996, 453);
            this.управляющие_компанииDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "код_ук";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код УК";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "название";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "фирм_наим";
            this.dataGridViewTextBoxColumn3.HeaderText = "Фирменное наименование";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "сокр_наим";
            this.dataGridViewTextBoxColumn4.HeaderText = "Сокращённое наименование";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ФИО_руков";
            this.dataGridViewTextBoxColumn5.HeaderText = "ФИО руководителя";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "дата_получения_лицензии";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата получения лицензии";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "номер_лицензии";
            this.dataGridViewTextBoxColumn7.HeaderText = "Номер лицензии";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "орган_выдавший_лицензию";
            this.dataGridViewTextBoxColumn8.HeaderText = "Орган выдавший лицензию";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ИНН";
            this.dataGridViewTextBoxColumn9.HeaderText = "ИНН";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ОПФ";
            this.dataGridViewTextBoxColumn10.DataSource = this.оПФукBindingSource;
            this.dataGridViewTextBoxColumn10.DisplayMember = "орг_прав_форма";
            this.dataGridViewTextBoxColumn10.HeaderText = "ОПФ";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn10.ValueMember = "код_опф";
            // 
            // оПФукBindingSource
            // 
            this.оПФукBindingSource.DataMember = "ОПФ_ук";
            this.оПФукBindingSource.DataSource = this.mainDataSet;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ОГРН";
            this.dataGridViewTextBoxColumn11.HeaderText = "ОГРН";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "почтовый_адрес";
            this.dataGridViewTextBoxColumn12.HeaderText = "Почтовый адрес";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "адрес_ФМОУ";
            this.dataGridViewTextBoxColumn13.HeaderText = "Фактическое местонахождение органов управления";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "место_ГРЮЛ";
            this.dataGridViewTextBoxColumn14.HeaderText = "Почтовый адрес";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "адрес_дисп_службы";
            this.dataGridViewTextBoxColumn15.HeaderText = "Адрес диспетчерской службы";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "контактный_телефон";
            this.dataGridViewTextBoxColumn16.HeaderText = "Контактный телефон";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "адрес_электронной_почты";
            this.dataGridViewTextBoxColumn17.HeaderText = "Адрес электронной почты";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "учётная_запись";
            this.dataGridViewTextBoxColumn18.DataSource = this.учётныезаписиBindingSource;
            this.dataGridViewTextBoxColumn18.DisplayMember = "логин";
            this.dataGridViewTextBoxColumn18.HeaderText = "Учётная_запись";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn18.ValueMember = "код_пользователя";
            // 
            // учётныезаписиBindingSource
            // 
            this.учётныезаписиBindingSource.DataMember = "Учётные_записи";
            this.учётныезаписиBindingSource.DataSource = this.mainDataSet;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "подтверждение";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Подтверждение";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // ManageCompanies_CRUD_ADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 478);
            this.Controls.Add(this.управляющие_компанииDataGridView);
            this.Controls.Add(this.управляющие_компанииBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1012, 517);
            this.MinimumSize = new System.Drawing.Size(1012, 517);
            this.Name = "ManageCompanies_CRUD_ADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление данными УК";
            this.Load += new System.EventHandler(this.ManageCompanies_CRUD_ADM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.управляющие_компанииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.управляющие_компанииBindingNavigator)).EndInit();
            this.управляющие_компанииBindingNavigator.ResumeLayout(false);
            this.управляющие_компанииBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.управляющие_компанииDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оПФукBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учётныезаписиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MainDataSet mainDataSet;
        private System.Windows.Forms.BindingSource управляющие_компанииBindingSource;
        private MainDataSetTableAdapters.Управляющие_компанииTableAdapter управляющие_компанииTableAdapter;
        private MainDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator управляющие_компанииBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton управляющие_компанииBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView управляющие_компанииDataGridView;
        private MainDataSetTableAdapters.ОПФ_укTableAdapter оПФ_укTableAdapter;
        private System.Windows.Forms.BindingSource оПФукBindingSource;
        private MainDataSetTableAdapters.Учётные_записиTableAdapter учётные_записиTableAdapter;
        private System.Windows.Forms.BindingSource учётныезаписиBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}