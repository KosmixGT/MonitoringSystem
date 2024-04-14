namespace MonitoringSystem
{
    partial class data_manageCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(data_manageCompany));
            this.saveBtn = new System.Windows.Forms.Button();
            this.licenseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.licenseDate = new System.Windows.Forms.Label();
            this.OPF_Box = new MonitoringSystem.labelAndComboBox();
            this.tb17 = new MonitoringSystem.labelAndTextBox();
            this.tb16 = new MonitoringSystem.labelAndTextBox();
            this.tb13 = new MonitoringSystem.labelAndTextBox();
            this.tb12 = new MonitoringSystem.labelAndTextBox();
            this.tb14 = new MonitoringSystem.labelAndTextBox();
            this.tb11 = new MonitoringSystem.labelAndTextBox();
            this.tb15 = new MonitoringSystem.labelAndTextBox();
            this.tb9 = new MonitoringSystem.labelAndTextBox();
            this.tb8 = new MonitoringSystem.labelAndTextBox();
            this.tb7 = new MonitoringSystem.labelAndTextBox();
            this.tb5 = new MonitoringSystem.labelAndTextBox();
            this.tb4 = new MonitoringSystem.labelAndTextBox();
            this.tb3 = new MonitoringSystem.labelAndTextBox();
            this.tb2 = new MonitoringSystem.labelAndTextBox();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Lime;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.Location = new System.Drawing.Point(640, 304);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(119, 69);
            this.saveBtn.TabIndex = 18;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // licenseDatePicker
            // 
            this.licenseDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.licenseDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.licenseDatePicker.Location = new System.Drawing.Point(34, 323);
            this.licenseDatePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.licenseDatePicker.Name = "licenseDatePicker";
            this.licenseDatePicker.Size = new System.Drawing.Size(128, 26);
            this.licenseDatePicker.TabIndex = 19;
            this.licenseDatePicker.Value = new System.DateTime(2023, 3, 29, 0, 0, 0, 0);
            // 
            // licenseDate
            // 
            this.licenseDate.AutoSize = true;
            this.licenseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.licenseDate.Location = new System.Drawing.Point(30, 292);
            this.licenseDate.Name = "licenseDate";
            this.licenseDate.Size = new System.Drawing.Size(208, 20);
            this.licenseDate.TabIndex = 21;
            this.licenseDate.Text = "Дата получения лицензии";
            // 
            // OPF_Box
            // 
            this.OPF_Box.BackColor = System.Drawing.Color.Transparent;
            this.OPF_Box.Location = new System.Drawing.Point(350, 156);
            this.OPF_Box.Name = "OPF_Box";
            this.OPF_Box.Size = new System.Drawing.Size(223, 60);
            this.OPF_Box.TabIndex = 17;
            this.OPF_Box.text = "ОПФ:";
            this.OPF_Box.Zapros = "SELECT [орг_прав_форма] FROM [dbo].[ОПФ_ук] order by [код_ОПФ]";
            // 
            // tb17
            // 
            this.tb17.BackColor = System.Drawing.Color.Transparent;
            this.tb17.Location = new System.Drawing.Point(631, 222);
            this.tb17.Name = "tb17";
            this.tb17.Size = new System.Drawing.Size(243, 64);
            this.tb17.TabIndex = 16;
            this.tb17.tbText = "";
            this.tb17.text = "Адрес эл. почты:";
            // 
            // tb16
            // 
            this.tb16.BackColor = System.Drawing.Color.Transparent;
            this.tb16.Location = new System.Drawing.Point(631, 152);
            this.tb16.Name = "tb16";
            this.tb16.Size = new System.Drawing.Size(179, 64);
            this.tb16.TabIndex = 15;
            this.tb16.tbText = "";
            this.tb16.text = "Контактный телефон:";
            // 
            // tb13
            // 
            this.tb13.BackColor = System.Drawing.Color.Transparent;
            this.tb13.Location = new System.Drawing.Point(350, 362);
            this.tb13.Name = "tb13";
            this.tb13.Size = new System.Drawing.Size(254, 64);
            this.tb13.TabIndex = 12;
            this.tb13.tbText = "";
            this.tb13.text = "Адрес ФМОУ";
            // 
            // tb12
            // 
            this.tb12.BackColor = System.Drawing.Color.Transparent;
            this.tb12.Location = new System.Drawing.Point(350, 292);
            this.tb12.Name = "tb12";
            this.tb12.Size = new System.Drawing.Size(254, 64);
            this.tb12.TabIndex = 11;
            this.tb12.tbText = "";
            this.tb12.text = "Почтовый адрес:";
            // 
            // tb14
            // 
            this.tb14.BackColor = System.Drawing.Color.Transparent;
            this.tb14.Location = new System.Drawing.Point(631, 12);
            this.tb14.Name = "tb14";
            this.tb14.Size = new System.Drawing.Size(243, 64);
            this.tb14.TabIndex = 10;
            this.tb14.tbText = "";
            this.tb14.text = "Адрес Юр. Лица";
            // 
            // tb11
            // 
            this.tb11.BackColor = System.Drawing.Color.Transparent;
            this.tb11.Location = new System.Drawing.Point(350, 222);
            this.tb11.Name = "tb11";
            this.tb11.Size = new System.Drawing.Size(179, 64);
            this.tb11.TabIndex = 9;
            this.tb11.tbText = "";
            this.tb11.text = "ОГРН:";
            // 
            // tb15
            // 
            this.tb15.BackColor = System.Drawing.Color.Transparent;
            this.tb15.Location = new System.Drawing.Point(631, 82);
            this.tb15.Name = "tb15";
            this.tb15.Size = new System.Drawing.Size(243, 64);
            this.tb15.TabIndex = 8;
            this.tb15.tbText = "";
            this.tb15.text = "Адрес дисп. службы:";
            // 
            // tb9
            // 
            this.tb9.BackColor = System.Drawing.Color.Transparent;
            this.tb9.Location = new System.Drawing.Point(350, 82);
            this.tb9.Name = "tb9";
            this.tb9.Size = new System.Drawing.Size(179, 64);
            this.tb9.TabIndex = 7;
            this.tb9.tbText = "";
            this.tb9.text = "ИНН:";
            // 
            // tb8
            // 
            this.tb8.BackColor = System.Drawing.Color.Transparent;
            this.tb8.Location = new System.Drawing.Point(350, 12);
            this.tb8.Name = "tb8";
            this.tb8.Size = new System.Drawing.Size(254, 64);
            this.tb8.TabIndex = 6;
            this.tb8.tbText = "";
            this.tb8.text = "Орган, выдавший лицензию";
            // 
            // tb7
            // 
            this.tb7.BackColor = System.Drawing.Color.Transparent;
            this.tb7.Location = new System.Drawing.Point(23, 362);
            this.tb7.Name = "tb7";
            this.tb7.Size = new System.Drawing.Size(179, 64);
            this.tb7.TabIndex = 5;
            this.tb7.tbText = "";
            this.tb7.text = "Номер лицензии:";
            // 
            // tb5
            // 
            this.tb5.BackColor = System.Drawing.Color.Transparent;
            this.tb5.Location = new System.Drawing.Point(23, 222);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(287, 64);
            this.tb5.TabIndex = 3;
            this.tb5.tbText = "";
            this.tb5.text = "ФИО руководителя:";
            // 
            // tb4
            // 
            this.tb4.BackColor = System.Drawing.Color.Transparent;
            this.tb4.Location = new System.Drawing.Point(23, 152);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(287, 64);
            this.tb4.TabIndex = 2;
            this.tb4.tbText = "";
            this.tb4.text = "Сокращённое наименование:";
            // 
            // tb3
            // 
            this.tb3.BackColor = System.Drawing.Color.Transparent;
            this.tb3.Location = new System.Drawing.Point(23, 82);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(287, 64);
            this.tb3.TabIndex = 1;
            this.tb3.tbText = "";
            this.tb3.text = "Фирменное наименование:";
            // 
            // tb2
            // 
            this.tb2.BackColor = System.Drawing.Color.Transparent;
            this.tb2.Location = new System.Drawing.Point(23, 12);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(139, 64);
            this.tb2.TabIndex = 0;
            this.tb2.tbText = "";
            this.tb2.text = "Название:";
            // 
            // data_manageCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.licenseDate);
            this.Controls.Add(this.licenseDatePicker);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.OPF_Box);
            this.Controls.Add(this.tb17);
            this.Controls.Add(this.tb16);
            this.Controls.Add(this.tb13);
            this.Controls.Add(this.tb12);
            this.Controls.Add(this.tb14);
            this.Controls.Add(this.tb11);
            this.Controls.Add(this.tb15);
            this.Controls.Add(this.tb9);
            this.Controls.Add(this.tb8);
            this.Controls.Add(this.tb7);
            this.Controls.Add(this.tb5);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "data_manageCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные об УК";
            this.Load += new System.EventHandler(this.data_manageCompany_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private labelAndTextBox tb2;
        private labelAndTextBox tb3;
        private labelAndTextBox tb4;
        private labelAndTextBox tb5;
        private labelAndTextBox tb7;
        private labelAndTextBox tb8;
        private labelAndTextBox tb9;
        private labelAndTextBox tb15;
        private labelAndTextBox tb11;
        private labelAndTextBox tb14;
        private labelAndTextBox tb12;
        private labelAndTextBox tb13;
        private labelAndTextBox tb16;
        private labelAndTextBox tb17;
        private labelAndComboBox OPF_Box;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DateTimePicker licenseDatePicker;
        private System.Windows.Forms.Label licenseDate;
        //private labelAndComboBox labelAndComboBox1;
        //private labelAndComboBox labelAndComboBox2;
    }
}