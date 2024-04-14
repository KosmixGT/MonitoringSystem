namespace MonitoringSystem
{
    partial class users_CRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(users_CRUD));
            this.mainDataSet = new MonitoringSystem.MainDataSet();
            this.учётные_записиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.учётные_записиTableAdapter = new MonitoringSystem.MainDataSetTableAdapters.Учётные_записиTableAdapter();
            this.tableAdapterManager = new MonitoringSystem.MainDataSetTableAdapters.TableAdapterManager();
            this.учётные_записиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.учётные_записиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.учётные_записиDataGridView = new System.Windows.Forms.DataGridView();
            this.типучётнойзаписиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.тип_учётной_записиTableAdapter = new MonitoringSystem.MainDataSetTableAdapters.Тип_учётной_записиTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учётные_записиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учётные_записиBindingNavigator)).BeginInit();
            this.учётные_записиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.учётные_записиDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типучётнойзаписиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainDataSet
            // 
            this.mainDataSet.DataSetName = "MainDataSet";
            this.mainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // учётные_записиBindingSource
            // 
            this.учётные_записиBindingSource.DataMember = "Учётные_записи";
            this.учётные_записиBindingSource.DataSource = this.mainDataSet;
            // 
            // учётные_записиTableAdapter
            // 
            this.учётные_записиTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ОПФ_укTableAdapter = null;
            this.tableAdapterManager.Сезон_обращенияTableAdapter = null;
            this.tableAdapterManager.Состояние_домаTableAdapter = null;
            this.tableAdapterManager.Способ_управления_МКДTableAdapter = null;
            this.tableAdapterManager.Статус_мероприятияTableAdapter = null;
            this.tableAdapterManager.Статус_обращенияTableAdapter = null;
            this.tableAdapterManager.Тема_обращенияTableAdapter = null;
            this.tableAdapterManager.Тип_учётной_записиTableAdapter = null;
            this.tableAdapterManager.Управляющие_компанииTableAdapter = null;
            this.tableAdapterManager.Учётные_записиTableAdapter = this.учётные_записиTableAdapter;
            // 
            // учётные_записиBindingNavigator
            // 
            this.учётные_записиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.учётные_записиBindingNavigator.BindingSource = this.учётные_записиBindingSource;
            this.учётные_записиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.учётные_записиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.учётные_записиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.учётные_записиBindingNavigatorSaveItem});
            this.учётные_записиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.учётные_записиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.учётные_записиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.учётные_записиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.учётные_записиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.учётные_записиBindingNavigator.Name = "учётные_записиBindingNavigator";
            this.учётные_записиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.учётные_записиBindingNavigator.Size = new System.Drawing.Size(459, 25);
            this.учётные_записиBindingNavigator.TabIndex = 0;
            this.учётные_записиBindingNavigator.Text = "bindingNavigator1";
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
            // учётные_записиBindingNavigatorSaveItem
            // 
            this.учётные_записиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.учётные_записиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("учётные_записиBindingNavigatorSaveItem.Image")));
            this.учётные_записиBindingNavigatorSaveItem.Name = "учётные_записиBindingNavigatorSaveItem";
            this.учётные_записиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.учётные_записиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.учётные_записиBindingNavigatorSaveItem.Click += new System.EventHandler(this.учётные_записиBindingNavigatorSaveItem_Click);
            // 
            // учётные_записиDataGridView
            // 
            this.учётные_записиDataGridView.AutoGenerateColumns = false;
            this.учётные_записиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.учётные_записиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.учётные_записиDataGridView.DataSource = this.учётные_записиBindingSource;
            this.учётные_записиDataGridView.Location = new System.Drawing.Point(0, 28);
            this.учётные_записиDataGridView.Name = "учётные_записиDataGridView";
            this.учётные_записиDataGridView.Size = new System.Drawing.Size(446, 220);
            this.учётные_записиDataGridView.TabIndex = 1;
            // 
            // типучётнойзаписиBindingSource
            // 
            this.типучётнойзаписиBindingSource.DataMember = "Тип_учётной_записи";
            this.типучётнойзаписиBindingSource.DataSource = this.mainDataSet;
            // 
            // тип_учётной_записиTableAdapter
            // 
            this.тип_учётной_записиTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "код_пользователя";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "логин";
            this.dataGridViewTextBoxColumn2.HeaderText = "Логин";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "пароль";
            this.dataGridViewTextBoxColumn3.HeaderText = "Пароль";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "тип_учётной_записи";
            this.dataGridViewTextBoxColumn4.DataSource = this.типучётнойзаписиBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "тип_пользователя";
            this.dataGridViewTextBoxColumn4.HeaderText = "Тип учётной записи";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "код_типа_пользователя";
            // 
            // users_CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 264);
            this.Controls.Add(this.учётные_записиDataGridView);
            this.Controls.Add(this.учётные_записиBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(475, 303);
            this.MinimumSize = new System.Drawing.Size(475, 303);
            this.Name = "users_CRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление учётными записями";
            this.Load += new System.EventHandler(this.users_CRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учётные_записиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учётные_записиBindingNavigator)).EndInit();
            this.учётные_записиBindingNavigator.ResumeLayout(false);
            this.учётные_записиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.учётные_записиDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типучётнойзаписиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MainDataSet mainDataSet;
        private System.Windows.Forms.BindingSource учётные_записиBindingSource;
        private MainDataSetTableAdapters.Учётные_записиTableAdapter учётные_записиTableAdapter;
        private MainDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator учётные_записиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton учётные_записиBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView учётные_записиDataGridView;
        private System.Windows.Forms.BindingSource типучётнойзаписиBindingSource;
        private MainDataSetTableAdapters.Тип_учётной_записиTableAdapter тип_учётной_записиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
    }
}