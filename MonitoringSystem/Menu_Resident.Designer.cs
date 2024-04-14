namespace MonitoringSystem
{
    partial class Menu_Resident
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Resident));
            this.login_uk = new System.Windows.Forms.Button();
            this.data_mc = new System.Windows.Forms.Button();
            this.UnLogin = new System.Windows.Forms.Button();
            this.ExcelReports_btn = new System.Windows.Forms.Button();
            this.control_reports_btn = new System.Windows.Forms.Button();
            this.view_reports_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_uk
            // 
            this.login_uk.BackColor = System.Drawing.Color.DimGray;
            this.login_uk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_uk.ForeColor = System.Drawing.Color.Transparent;
            this.login_uk.Image = ((System.Drawing.Image)(resources.GetObject("login_uk.Image")));
            this.login_uk.Location = new System.Drawing.Point(12, 12);
            this.login_uk.Name = "login_uk";
            this.login_uk.Size = new System.Drawing.Size(160, 160);
            this.login_uk.TabIndex = 1;
            this.login_uk.UseVisualStyleBackColor = false;
            // 
            // data_mc
            // 
            this.data_mc.BackColor = System.Drawing.SystemColors.Highlight;
            this.data_mc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.data_mc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.data_mc.Location = new System.Drawing.Point(178, 12);
            this.data_mc.Name = "data_mc";
            this.data_mc.Size = new System.Drawing.Size(175, 56);
            this.data_mc.TabIndex = 11;
            this.data_mc.Text = "Просмотр УК";
            this.data_mc.UseVisualStyleBackColor = false;
            this.data_mc.Click += new System.EventHandler(this.data_mc_Click);
            // 
            // UnLogin
            // 
            this.UnLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.UnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UnLogin.Location = new System.Drawing.Point(28, 178);
            this.UnLogin.Name = "UnLogin";
            this.UnLogin.Size = new System.Drawing.Size(132, 56);
            this.UnLogin.TabIndex = 12;
            this.UnLogin.Text = "Выйти из аккаунта";
            this.UnLogin.UseVisualStyleBackColor = false;
            this.UnLogin.Click += new System.EventHandler(this.UnLogin_Click);
            // 
            // ExcelReports_btn
            // 
            this.ExcelReports_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.ExcelReports_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExcelReports_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExcelReports_btn.Location = new System.Drawing.Point(178, 226);
            this.ExcelReports_btn.Name = "ExcelReports_btn";
            this.ExcelReports_btn.Size = new System.Drawing.Size(175, 56);
            this.ExcelReports_btn.TabIndex = 13;
            this.ExcelReports_btn.Text = "Отчёт об обращениях";
            this.ExcelReports_btn.UseVisualStyleBackColor = false;
            this.ExcelReports_btn.Click += new System.EventHandler(this.ExcelReports_btn_Click);
            // 
            // control_reports_btn
            // 
            this.control_reports_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.control_reports_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.control_reports_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.control_reports_btn.Location = new System.Drawing.Point(178, 74);
            this.control_reports_btn.Name = "control_reports_btn";
            this.control_reports_btn.Size = new System.Drawing.Size(175, 70);
            this.control_reports_btn.TabIndex = 14;
            this.control_reports_btn.Text = "Управление обращениями";
            this.control_reports_btn.UseVisualStyleBackColor = false;
            this.control_reports_btn.Click += new System.EventHandler(this.control_reports_btn_Click);
            // 
            // view_reports_btn
            // 
            this.view_reports_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.view_reports_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.view_reports_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.view_reports_btn.Location = new System.Drawing.Point(178, 150);
            this.view_reports_btn.Name = "view_reports_btn";
            this.view_reports_btn.Size = new System.Drawing.Size(175, 70);
            this.view_reports_btn.TabIndex = 15;
            this.view_reports_btn.Text = "Просмотр всех обращений";
            this.view_reports_btn.UseVisualStyleBackColor = false;
            this.view_reports_btn.Click += new System.EventHandler(this.reports_view_btn_Click);
            // 
            // Menu_Resident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 304);
            this.Controls.Add(this.view_reports_btn);
            this.Controls.Add(this.control_reports_btn);
            this.Controls.Add(this.ExcelReports_btn);
            this.Controls.Add(this.UnLogin);
            this.Controls.Add(this.data_mc);
            this.Controls.Add(this.login_uk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(385, 343);
            this.MinimumSize = new System.Drawing.Size(385, 343);
            this.Name = "Menu_Resident";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню жителя";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_Resident_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Resident_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button login_uk;
        private System.Windows.Forms.Button data_mc;
        private System.Windows.Forms.Button UnLogin;
        private System.Windows.Forms.Button ExcelReports_btn;
        private System.Windows.Forms.Button control_reports_btn;
        private System.Windows.Forms.Button view_reports_btn;
    }
}