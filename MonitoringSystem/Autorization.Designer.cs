namespace MonitoringSystem
{
    partial class Autorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autorization));
            this.login_uk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.login_resident = new System.Windows.Forms.Button();
            this.login_nobody = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_uk
            // 
            this.login_uk.BackColor = System.Drawing.Color.DimGray;
            this.login_uk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_uk.ForeColor = System.Drawing.Color.Transparent;
            this.login_uk.Image = ((System.Drawing.Image)(resources.GetObject("login_uk.Image")));
            this.login_uk.Location = new System.Drawing.Point(103, 87);
            this.login_uk.Name = "login_uk";
            this.login_uk.Size = new System.Drawing.Size(160, 160);
            this.login_uk.TabIndex = 0;
            this.login_uk.UseVisualStyleBackColor = false;
            this.login_uk.Click += new System.EventHandler(this.login_uk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 84);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добро пожаловать!\r\nКак вы хотите авторизоваться?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login_resident
            // 
            this.login_resident.BackColor = System.Drawing.Color.DimGray;
            this.login_resident.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_resident.Image = ((System.Drawing.Image)(resources.GetObject("login_resident.Image")));
            this.login_resident.Location = new System.Drawing.Point(313, 87);
            this.login_resident.Name = "login_resident";
            this.login_resident.Size = new System.Drawing.Size(160, 160);
            this.login_resident.TabIndex = 2;
            this.login_resident.UseVisualStyleBackColor = false;
            this.login_resident.Click += new System.EventHandler(this.login_resident_Click);
            // 
            // login_nobody
            // 
            this.login_nobody.BackColor = System.Drawing.SystemColors.Highlight;
            this.login_nobody.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_nobody.ForeColor = System.Drawing.SystemColors.ControlText;
            this.login_nobody.Location = new System.Drawing.Point(193, 294);
            this.login_nobody.Name = "login_nobody";
            this.login_nobody.Size = new System.Drawing.Size(190, 56);
            this.login_nobody.TabIndex = 3;
            this.login_nobody.Text = "Продолжить без авторизации";
            this.login_nobody.UseVisualStyleBackColor = false;
            this.login_nobody.Click += new System.EventHandler(this.login_nobody_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(90, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Менеджер УК";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(339, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Житель";
            // 
            // Autorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(576, 383);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login_nobody);
            this.Controls.Add(this.login_resident);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_uk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(592, 422);
            this.MinimumSize = new System.Drawing.Size(592, 422);
            this.Name = "Autorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход в систему";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Autorization_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Autorization_FormClosed);
            this.Load += new System.EventHandler(this.Autorization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_uk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login_resident;
        private System.Windows.Forms.Button login_nobody;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

