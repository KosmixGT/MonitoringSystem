namespace MonitoringSystem
{
    partial class Events_CRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Events_CRUD));
            this.мероприятияBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.мероприятияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataSet = new MonitoringSystem.MainDataSet();
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
            this.мероприятияBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.мероприятияDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.категориямероприятияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataSet1 = new MonitoringSystem.MainDataSet();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.объект_МКДTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.статусмероприятияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.код_упр_комToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.код_упр_комToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.мероприятияTableAdapter = new MonitoringSystem.MainDataSetTableAdapters.МероприятияTableAdapter();
            this.tableAdapterManager = new MonitoringSystem.MainDataSetTableAdapters.TableAdapterManager();
            this.категория_мероприятияTableAdapter = new MonitoringSystem.MainDataSetTableAdapters.Категория_мероприятияTableAdapter();
            this.статус_мероприятияTableAdapter = new MonitoringSystem.MainDataSetTableAdapters.Статус_мероприятияTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.мероприятияBindingNavigator)).BeginInit();
            this.мероприятияBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.мероприятияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мероприятияDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.категориямероприятияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусмероприятияBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // мероприятияBindingNavigator
            // 
            this.мероприятияBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.мероприятияBindingNavigator.BindingSource = this.мероприятияBindingSource;
            this.мероприятияBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.мероприятияBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.мероприятияBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.мероприятияBindingNavigatorSaveItem});
            this.мероприятияBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.мероприятияBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.мероприятияBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.мероприятияBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.мероприятияBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.мероприятияBindingNavigator.Name = "мероприятияBindingNavigator";
            this.мероприятияBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.мероприятияBindingNavigator.Size = new System.Drawing.Size(875, 25);
            this.мероприятияBindingNavigator.TabIndex = 0;
            this.мероприятияBindingNavigator.Text = "bindingNavigator1";
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
            // мероприятияBindingSource
            // 
            this.мероприятияBindingSource.DataMember = "Мероприятия";
            this.мероприятияBindingSource.DataSource = this.mainDataSet;
            // 
            // mainDataSet
            // 
            this.mainDataSet.DataSetName = "MainDataSet";
            this.mainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // мероприятияBindingNavigatorSaveItem
            // 
            this.мероприятияBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.мероприятияBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("мероприятияBindingNavigatorSaveItem.Image")));
            this.мероприятияBindingNavigatorSaveItem.Name = "мероприятияBindingNavigatorSaveItem";
            this.мероприятияBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.мероприятияBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.мероприятияBindingNavigatorSaveItem.Click += new System.EventHandler(this.мероприятияBindingNavigatorSaveItem_Click_1);
            // 
            // мероприятияDataGridView
            // 
            this.мероприятияDataGridView.AutoGenerateColumns = false;
            this.мероприятияDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.мероприятияDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.объект_МКДTextBoxColumn,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.мероприятияDataGridView.DataSource = this.мероприятияBindingSource;
            this.мероприятияDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.мероприятияDataGridView.Location = new System.Drawing.Point(0, 25);
            this.мероприятияDataGridView.Name = "мероприятияDataGridView";
            this.мероприятияDataGridView.Size = new System.Drawing.Size(875, 345);
            this.мероприятияDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "код_мероприятия";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "кат_меропр";
            this.dataGridViewTextBoxColumn2.DataSource = this.категориямероприятияBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "категория_меропр";
            this.dataGridViewTextBoxColumn2.HeaderText = "Категория";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "код_категории_меропр";
            // 
            // категориямероприятияBindingSource
            // 
            this.категориямероприятияBindingSource.DataMember = "Категория_мероприятия";
            this.категориямероприятияBindingSource.DataSource = this.mainDataSet1;
            // 
            // mainDataSet1
            // 
            this.mainDataSet1.DataSetName = "MainDataSet";
            this.mainDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "тема_меропр";
            this.dataGridViewTextBoxColumn3.HeaderText = "Тема";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // объект_МКДTextBoxColumn
            // 
            this.объект_МКДTextBoxColumn.DataPropertyName = "объект_МКД";
            this.объект_МКДTextBoxColumn.HeaderText = "Дом";
            this.объект_МКДTextBoxColumn.Name = "объект_МКДTextBoxColumn";
            this.объект_МКДTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.объект_МКДTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "описание";
            this.dataGridViewTextBoxColumn5.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "дата_время_проведения";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата время проведения";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "исполнитель";
            this.dataGridViewTextBoxColumn7.HeaderText = "Исполнитель";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "статус_меропр";
            this.dataGridViewTextBoxColumn8.DataSource = this.статусмероприятияBindingSource;
            this.dataGridViewTextBoxColumn8.DisplayMember = "статус_меропр";
            this.dataGridViewTextBoxColumn8.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn8.ValueMember = "код_тек_статуса_меропр";
            // 
            // статусмероприятияBindingSource
            // 
            this.статусмероприятияBindingSource.DataMember = "Статус_мероприятия";
            this.статусмероприятияBindingSource.DataSource = this.mainDataSet1;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.код_упр_комToolStripLabel,
            this.код_упр_комToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(9, 336);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(235, 25);
            this.fillByToolStrip.TabIndex = 2;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.Visible = false;
            // 
            // код_упр_комToolStripLabel
            // 
            this.код_упр_комToolStripLabel.Name = "код_упр_комToolStripLabel";
            this.код_упр_комToolStripLabel.Size = new System.Drawing.Size(82, 22);
            this.код_упр_комToolStripLabel.Text = "Код_упр_ком:";
            // 
            // код_упр_комToolStripTextBox
            // 
            this.код_упр_комToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.код_упр_комToolStripTextBox.Name = "код_упр_комToolStripTextBox";
            this.код_упр_комToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // мероприятияTableAdapter
            // 
            this.мероприятияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = MonitoringSystem.MainDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Категория_мероприятияTableAdapter = null;
            this.tableAdapterManager.Категория_проблемыTableAdapter = null;
            this.tableAdapterManager.МероприятияTableAdapter = this.мероприятияTableAdapter;
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
            this.tableAdapterManager.Учётные_записиTableAdapter = null;
            // 
            // категория_мероприятияTableAdapter
            // 
            this.категория_мероприятияTableAdapter.ClearBeforeFill = true;
            // 
            // статус_мероприятияTableAdapter
            // 
            this.статус_мероприятияTableAdapter.ClearBeforeFill = true;
            // 
            // Events_CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(875, 370);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.мероприятияDataGridView);
            this.Controls.Add(this.мероприятияBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(891, 409);
            this.MinimumSize = new System.Drawing.Size(891, 409);
            this.Name = "Events_CRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление мероприятиями";
            this.Load += new System.EventHandler(this.MKD_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.мероприятияBindingNavigator)).EndInit();
            this.мероприятияBindingNavigator.ResumeLayout(false);
            this.мероприятияBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.мероприятияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мероприятияDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.категориямероприятияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусмероприятияBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MainDataSet mainDataSet;
        private System.Windows.Forms.BindingSource мероприятияBindingSource;
        private MainDataSetTableAdapters.МероприятияTableAdapter мероприятияTableAdapter;
        private MainDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator мероприятияBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton мероприятияBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView мероприятияDataGridView;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel код_упр_комToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox код_упр_комToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private MainDataSet mainDataSet1;
        private System.Windows.Forms.BindingSource категориямероприятияBindingSource;
        private MainDataSetTableAdapters.Категория_мероприятияTableAdapter категория_мероприятияTableAdapter;
        private System.Windows.Forms.BindingSource статусмероприятияBindingSource;
        private MainDataSetTableAdapters.Статус_мероприятияTableAdapter статус_мероприятияTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn объект_МКДTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn8;
    }
}