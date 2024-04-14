namespace MonitoringSystem
{
    partial class Reports_resident
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
            System.Windows.Forms.Label описаниеLabel;
            System.Windows.Forms.Label темаLabel1;
            System.Windows.Forms.Label сезонностьLabel1;
            System.Windows.Forms.Label объект_МКДLabel1;
            System.Windows.Forms.Label оценкаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports_resident));
            this.reports_DGV = new System.Windows.Forms.DataGridView();
            this.кодобращенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.темаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.сезонностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.срокподгответаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.срокподтвответаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусобращенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.датаобращенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.объектМКДDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.обслуживлицоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оценкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.учётнаязаписьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.обращенияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MonitoringSystem.DataSet();
            this.обращенияTableAdapter = new MonitoringSystem.DataSetTableAdapters.ОбращенияTableAdapter();
            this.темаобращенияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.тема_обращенияTableAdapter = new MonitoringSystem.DataSetTableAdapters.Тема_обращенияTableAdapter();
            this.save_btn = new System.Windows.Forms.Button();
            this.create_btn = new System.Windows.Forms.Button();
            this.tableAdapterManager = new MonitoringSystem.DataSetTableAdapters.TableAdapterManager();
            this.fKОбращенияТемаобращенияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сезонобращенияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сезон_обращенияTableAdapter = new MonitoringSystem.DataSetTableAdapters.Сезон_обращенияTableAdapter();
            this.mainDataSet = new MonitoringSystem.MainDataSet();
            this.мКДBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.мКДTableAdapter = new MonitoringSystem.MainDataSetTableAdapters.МКДTableAdapter();
            this.темаComboBox = new System.Windows.Forms.ComboBox();
            this.объект_МКДComboBox = new System.Windows.Forms.ComboBox();
            this.сезонностьComboBox = new System.Windows.Forms.ComboBox();
            this.описаниеTextBox = new System.Windows.Forms.TextBox();
            this.оценкаTextBox = new System.Windows.Forms.TextBox();
            this.openData_btn = new System.Windows.Forms.Button();
            описаниеLabel = new System.Windows.Forms.Label();
            темаLabel1 = new System.Windows.Forms.Label();
            сезонностьLabel1 = new System.Windows.Forms.Label();
            объект_МКДLabel1 = new System.Windows.Forms.Label();
            оценкаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reports_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.обращенияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.темаобращенияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKОбращенияТемаобращенияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сезонобращенияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мКДBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // описаниеLabel
            // 
            описаниеLabel.AutoSize = true;
            описаниеLabel.Location = new System.Drawing.Point(291, 452);
            описаниеLabel.Name = "описаниеLabel";
            описаниеLabel.Size = new System.Drawing.Size(60, 13);
            описаниеLabel.TabIndex = 13;
            описаниеLabel.Text = "Описание:";
            // 
            // темаLabel1
            // 
            темаLabel1.AutoSize = true;
            темаLabel1.Location = new System.Drawing.Point(16, 452);
            темаLabel1.Name = "темаLabel1";
            темаLabel1.Size = new System.Drawing.Size(37, 13);
            темаLabel1.TabIndex = 20;
            темаLabel1.Text = "Тема:";
            // 
            // сезонностьLabel1
            // 
            сезонностьLabel1.AutoSize = true;
            сезонностьLabel1.Location = new System.Drawing.Point(16, 480);
            сезонностьLabel1.Name = "сезонностьLabel1";
            сезонностьLabel1.Size = new System.Drawing.Size(48, 13);
            сезонностьLabel1.TabIndex = 21;
            сезонностьLabel1.Text = "Период:";
            // 
            // объект_МКДLabel1
            // 
            объект_МКДLabel1.AutoSize = true;
            объект_МКДLabel1.Location = new System.Drawing.Point(16, 507);
            объект_МКДLabel1.Name = "объект_МКДLabel1";
            объект_МКДLabel1.Size = new System.Drawing.Size(33, 13);
            объект_МКДLabel1.TabIndex = 22;
            объект_МКДLabel1.Text = "Дом:";
            // 
            // оценкаLabel
            // 
            оценкаLabel.AutoSize = true;
            оценкаLabel.Location = new System.Drawing.Point(617, 451);
            оценкаLabel.Name = "оценкаLabel";
            оценкаLabel.Size = new System.Drawing.Size(48, 13);
            оценкаLabel.TabIndex = 24;
            оценкаLabel.Text = "Оценка:";
            // 
            // reports_DGV
            // 
            this.reports_DGV.AllowUserToAddRows = false;
            this.reports_DGV.AllowUserToDeleteRows = false;
            this.reports_DGV.AutoGenerateColumns = false;
            this.reports_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reports_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодобращенияDataGridViewTextBoxColumn,
            this.темаDataGridViewTextBoxColumn,
            this.сезонностьDataGridViewTextBoxColumn,
            this.срокподгответаDataGridViewTextBoxColumn,
            this.срокподтвответаDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn,
            this.статусобращенияDataGridViewTextBoxColumn,
            this.датаобращенияDataGridViewTextBoxColumn,
            this.объектМКДDataGridViewTextBoxColumn,
            this.обслуживлицоDataGridViewTextBoxColumn,
            this.оценкаDataGridViewTextBoxColumn,
            this.учётнаязаписьDataGridViewTextBoxColumn});
            this.reports_DGV.DataSource = this.обращенияBindingSource;
            this.reports_DGV.Location = new System.Drawing.Point(12, 12);
            this.reports_DGV.Name = "reports_DGV";
            this.reports_DGV.ReadOnly = true;
            this.reports_DGV.Size = new System.Drawing.Size(1223, 431);
            this.reports_DGV.TabIndex = 0;
            this.reports_DGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.reports_DGV_CellFormatting);
            this.reports_DGV.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // кодобращенияDataGridViewTextBoxColumn
            // 
            this.кодобращенияDataGridViewTextBoxColumn.DataPropertyName = "код_обращения";
            this.кодобращенияDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.кодобращенияDataGridViewTextBoxColumn.Name = "кодобращенияDataGridViewTextBoxColumn";
            this.кодобращенияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // темаDataGridViewTextBoxColumn
            // 
            this.темаDataGridViewTextBoxColumn.DataPropertyName = "тема";
            this.темаDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.темаDataGridViewTextBoxColumn.HeaderText = "Тема";
            this.темаDataGridViewTextBoxColumn.Name = "темаDataGridViewTextBoxColumn";
            this.темаDataGridViewTextBoxColumn.ReadOnly = true;
            this.темаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.темаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // сезонностьDataGridViewTextBoxColumn
            // 
            this.сезонностьDataGridViewTextBoxColumn.DataPropertyName = "сезонность";
            this.сезонностьDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.сезонностьDataGridViewTextBoxColumn.HeaderText = "Период";
            this.сезонностьDataGridViewTextBoxColumn.Name = "сезонностьDataGridViewTextBoxColumn";
            this.сезонностьDataGridViewTextBoxColumn.ReadOnly = true;
            this.сезонностьDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.сезонностьDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // срокподгответаDataGridViewTextBoxColumn
            // 
            this.срокподгответаDataGridViewTextBoxColumn.DataPropertyName = "срок_подг_ответа";
            this.срокподгответаDataGridViewTextBoxColumn.HeaderText = "Подготовка ответа (дни)";
            this.срокподгответаDataGridViewTextBoxColumn.Name = "срокподгответаDataGridViewTextBoxColumn";
            this.срокподгответаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // срокподтвответаDataGridViewTextBoxColumn
            // 
            this.срокподтвответаDataGridViewTextBoxColumn.DataPropertyName = "срок_подтв_ответа";
            this.срокподтвответаDataGridViewTextBoxColumn.HeaderText = "Подтверждение ответа (дни)";
            this.срокподтвответаDataGridViewTextBoxColumn.Name = "срокподтвответаDataGridViewTextBoxColumn";
            this.срокподтвответаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            this.описаниеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // статусобращенияDataGridViewTextBoxColumn
            // 
            this.статусобращенияDataGridViewTextBoxColumn.DataPropertyName = "статус_обращения";
            this.статусобращенияDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.статусобращенияDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.статусобращенияDataGridViewTextBoxColumn.Name = "статусобращенияDataGridViewTextBoxColumn";
            this.статусобращенияDataGridViewTextBoxColumn.ReadOnly = true;
            this.статусобращенияDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.статусобращенияDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // датаобращенияDataGridViewTextBoxColumn
            // 
            this.датаобращенияDataGridViewTextBoxColumn.DataPropertyName = "дата_обращения";
            this.датаобращенияDataGridViewTextBoxColumn.HeaderText = "Дата обращения";
            this.датаобращенияDataGridViewTextBoxColumn.Name = "датаобращенияDataGridViewTextBoxColumn";
            this.датаобращенияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // объектМКДDataGridViewTextBoxColumn
            // 
            this.объектМКДDataGridViewTextBoxColumn.DataPropertyName = "объект_МКД";
            this.объектМКДDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.объектМКДDataGridViewTextBoxColumn.HeaderText = "Дом";
            this.объектМКДDataGridViewTextBoxColumn.Name = "объектМКДDataGridViewTextBoxColumn";
            this.объектМКДDataGridViewTextBoxColumn.ReadOnly = true;
            this.объектМКДDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.объектМКДDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // обслуживлицоDataGridViewTextBoxColumn
            // 
            this.обслуживлицоDataGridViewTextBoxColumn.DataPropertyName = "обслужив_лицо";
            this.обслуживлицоDataGridViewTextBoxColumn.HeaderText = "Обслуживающее лицо";
            this.обслуживлицоDataGridViewTextBoxColumn.Name = "обслуживлицоDataGridViewTextBoxColumn";
            this.обслуживлицоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // оценкаDataGridViewTextBoxColumn
            // 
            this.оценкаDataGridViewTextBoxColumn.DataPropertyName = "оценка";
            this.оценкаDataGridViewTextBoxColumn.HeaderText = "Оценка";
            this.оценкаDataGridViewTextBoxColumn.Name = "оценкаDataGridViewTextBoxColumn";
            this.оценкаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // учётнаязаписьDataGridViewTextBoxColumn
            // 
            this.учётнаязаписьDataGridViewTextBoxColumn.DataPropertyName = "учётная_запись";
            this.учётнаязаписьDataGridViewTextBoxColumn.HeaderText = "Учётная_запись";
            this.учётнаязаписьDataGridViewTextBoxColumn.Name = "учётнаязаписьDataGridViewTextBoxColumn";
            this.учётнаязаписьDataGridViewTextBoxColumn.ReadOnly = true;
            this.учётнаязаписьDataGridViewTextBoxColumn.Visible = false;
            // 
            // обращенияBindingSource
            // 
            this.обращенияBindingSource.DataMember = "Обращения";
            this.обращенияBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // обращенияTableAdapter
            // 
            this.обращенияTableAdapter.ClearBeforeFill = true;
            // 
            // темаобращенияBindingSource
            // 
            this.темаобращенияBindingSource.DataMember = "Тема_обращения";
            this.темаобращенияBindingSource.DataSource = this.dataSet;
            // 
            // тема_обращенияTableAdapter
            // 
            this.тема_обращенияTableAdapter.ClearBeforeFill = true;
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.Lime;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save_btn.Location = new System.Drawing.Point(1130, 448);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(105, 58);
            this.save_btn.TabIndex = 1;
            this.save_btn.Text = "Сохранить";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // create_btn
            // 
            this.create_btn.BackColor = System.Drawing.Color.Orange;
            this.create_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.create_btn.Location = new System.Drawing.Point(1019, 448);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(105, 58);
            this.create_btn.TabIndex = 2;
            this.create_btn.Text = "Добавить обращение";
            this.create_btn.UseVisualStyleBackColor = false;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = MonitoringSystem.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Категория_мероприятияTableAdapter = null;
            this.tableAdapterManager.Категория_проблемыTableAdapter = null;
            this.tableAdapterManager.МероприятияTableAdapter = null;
            this.tableAdapterManager.МКДTableAdapter = null;
            this.tableAdapterManager.ОбращенияTableAdapter = this.обращенияTableAdapter;
            this.tableAdapterManager.ОПФ_укTableAdapter = null;
            this.tableAdapterManager.Сезон_обращенияTableAdapter = null;
            this.tableAdapterManager.Состояние_домаTableAdapter = null;
            this.tableAdapterManager.Способ_управления_МКДTableAdapter = null;
            this.tableAdapterManager.Статус_мероприятияTableAdapter = null;
            this.tableAdapterManager.Статус_обращенияTableAdapter = null;
            this.tableAdapterManager.Тема_обращенияTableAdapter = this.тема_обращенияTableAdapter;
            this.tableAdapterManager.Тип_учётной_записиTableAdapter = null;
            this.tableAdapterManager.Управляющие_компанииTableAdapter = null;
            this.tableAdapterManager.Учётные_записиTableAdapter = null;
            // 
            // fKОбращенияТемаобращенияBindingSource
            // 
            this.fKОбращенияТемаобращенияBindingSource.DataMember = "FK_Обращения_Тема_обращения";
            this.fKОбращенияТемаобращенияBindingSource.DataSource = this.темаобращенияBindingSource;
            // 
            // сезонобращенияBindingSource
            // 
            this.сезонобращенияBindingSource.DataMember = "Сезон_обращения";
            this.сезонобращенияBindingSource.DataSource = this.dataSet;
            // 
            // сезон_обращенияTableAdapter
            // 
            this.сезон_обращенияTableAdapter.ClearBeforeFill = true;
            // 
            // mainDataSet
            // 
            this.mainDataSet.DataSetName = "MainDataSet";
            this.mainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // мКДBindingSource
            // 
            this.мКДBindingSource.DataMember = "МКД";
            this.мКДBindingSource.DataSource = this.mainDataSet;
            // 
            // мКДTableAdapter
            // 
            this.мКДTableAdapter.ClearBeforeFill = true;
            // 
            // темаComboBox
            // 
            this.темаComboBox.DataSource = this.темаобращенияBindingSource;
            this.темаComboBox.DisplayMember = "тема_проблемы";
            this.темаComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.темаComboBox.DropDownWidth = 600;
            this.темаComboBox.FormattingEnabled = true;
            this.темаComboBox.Location = new System.Drawing.Point(71, 449);
            this.темаComboBox.Name = "темаComboBox";
            this.темаComboBox.Size = new System.Drawing.Size(214, 21);
            this.темаComboBox.TabIndex = 27;
            this.темаComboBox.ValueMember = "код_темы_обращения";
            // 
            // объект_МКДComboBox
            // 
            this.объект_МКДComboBox.DataSource = this.мКДBindingSource;
            this.объект_МКДComboBox.DisplayMember = "адрес";
            this.объект_МКДComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.объект_МКДComboBox.DropDownWidth = 500;
            this.объект_МКДComboBox.FormattingEnabled = true;
            this.объект_МКДComboBox.Location = new System.Drawing.Point(71, 504);
            this.объект_МКДComboBox.Name = "объект_МКДComboBox";
            this.объект_МКДComboBox.Size = new System.Drawing.Size(214, 21);
            this.объект_МКДComboBox.TabIndex = 29;
            this.объект_МКДComboBox.ValueMember = "код_МКД";
            // 
            // сезонностьComboBox
            // 
            this.сезонностьComboBox.DataSource = this.сезонобращенияBindingSource;
            this.сезонностьComboBox.DisplayMember = "сезонность_обр";
            this.сезонностьComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.сезонностьComboBox.FormattingEnabled = true;
            this.сезонностьComboBox.Location = new System.Drawing.Point(71, 477);
            this.сезонностьComboBox.Name = "сезонностьComboBox";
            this.сезонностьComboBox.Size = new System.Drawing.Size(214, 21);
            this.сезонностьComboBox.TabIndex = 30;
            this.сезонностьComboBox.ValueMember = "код_сезонности_обр";
            // 
            // описаниеTextBox
            // 
            this.описаниеTextBox.Location = new System.Drawing.Point(357, 448);
            this.описаниеTextBox.Multiline = true;
            this.описаниеTextBox.Name = "описаниеTextBox";
            this.описаниеTextBox.Size = new System.Drawing.Size(243, 95);
            this.описаниеTextBox.TabIndex = 31;
            // 
            // оценкаTextBox
            // 
            this.оценкаTextBox.Location = new System.Drawing.Point(671, 448);
            this.оценкаTextBox.Multiline = true;
            this.оценкаTextBox.Name = "оценкаTextBox";
            this.оценкаTextBox.Size = new System.Drawing.Size(200, 95);
            this.оценкаTextBox.TabIndex = 32;
            // 
            // openData_btn
            // 
            this.openData_btn.BackColor = System.Drawing.Color.Aqua;
            this.openData_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openData_btn.Location = new System.Drawing.Point(908, 448);
            this.openData_btn.Name = "openData_btn";
            this.openData_btn.Size = new System.Drawing.Size(105, 58);
            this.openData_btn.TabIndex = 33;
            this.openData_btn.Text = "Создать обращение";
            this.openData_btn.UseVisualStyleBackColor = false;
            this.openData_btn.Click += new System.EventHandler(this.openData_btn_Click);
            // 
            // Reports_resident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 555);
            this.Controls.Add(this.openData_btn);
            this.Controls.Add(this.оценкаTextBox);
            this.Controls.Add(this.описаниеTextBox);
            this.Controls.Add(this.сезонностьComboBox);
            this.Controls.Add(this.объект_МКДComboBox);
            this.Controls.Add(this.темаComboBox);
            this.Controls.Add(оценкаLabel);
            this.Controls.Add(объект_МКДLabel1);
            this.Controls.Add(сезонностьLabel1);
            this.Controls.Add(темаLabel1);
            this.Controls.Add(описаниеLabel);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.reports_DGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1289, 629);
            this.Name = "Reports_resident";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обращения пользователя";
            this.Load += new System.EventHandler(this.Reports_resident_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reports_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.обращенияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.темаобращенияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKОбращенияТемаобращенияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сезонобращенияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мКДBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reports_DGV;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource обращенияBindingSource;
        private DataSetTableAdapters.ОбращенияTableAdapter обращенияTableAdapter;
        private System.Windows.Forms.BindingSource темаобращенияBindingSource;
        private DataSetTableAdapters.Тема_обращенияTableAdapter тема_обращенияTableAdapter;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button create_btn;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource fKОбращенияТемаобращенияBindingSource;
        private System.Windows.Forms.BindingSource сезонобращенияBindingSource;
        private DataSetTableAdapters.Сезон_обращенияTableAdapter сезон_обращенияTableAdapter;
        private MainDataSet mainDataSet;
        private System.Windows.Forms.BindingSource мКДBindingSource;
        private MainDataSetTableAdapters.МКДTableAdapter мКДTableAdapter;
        private System.Windows.Forms.ComboBox темаComboBox;
        private System.Windows.Forms.ComboBox объект_МКДComboBox;
        private System.Windows.Forms.ComboBox сезонностьComboBox;
        private System.Windows.Forms.TextBox описаниеTextBox;
        private System.Windows.Forms.TextBox оценкаTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодобращенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn темаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn сезонностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn срокподгответаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn срокподтвответаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn статусобращенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаобращенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn объектМКДDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn обслуживлицоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оценкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn учётнаязаписьDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button openData_btn;
    }
}