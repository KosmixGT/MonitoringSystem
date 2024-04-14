namespace MonitoringSystem
{
    partial class Menu_MC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_MC));
            this.login_uk = new System.Windows.Forms.Button();
            this.data_mc = new System.Windows.Forms.Button();
            this.UnLogin = new System.Windows.Forms.Button();
            this.reportsMC_btn = new System.Windows.Forms.Button();
            this.curr_mkd_btn = new System.Windows.Forms.Button();
            this.curr_event_btn = new System.Windows.Forms.Button();
            this.ExcelRpMc_btn = new System.Windows.Forms.Button();
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
            this.data_mc.Size = new System.Drawing.Size(132, 56);
            this.data_mc.TabIndex = 11;
            this.data_mc.Text = "Данные об УК";
            this.data_mc.UseVisualStyleBackColor = false;
            this.data_mc.Click += new System.EventHandler(this.data_mc_Click);
            // 
            // UnLogin
            // 
            this.UnLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.UnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UnLogin.Location = new System.Drawing.Point(25, 178);
            this.UnLogin.Name = "UnLogin";
            this.UnLogin.Size = new System.Drawing.Size(132, 56);
            this.UnLogin.TabIndex = 12;
            this.UnLogin.Text = "Выйти из аккаунта";
            this.UnLogin.UseVisualStyleBackColor = false;
            this.UnLogin.Click += new System.EventHandler(this.UnLogin_Click);
            // 
            // reportsMC_btn
            // 
            this.reportsMC_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.reportsMC_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportsMC_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.reportsMC_btn.Location = new System.Drawing.Point(178, 74);
            this.reportsMC_btn.Name = "reportsMC_btn";
            this.reportsMC_btn.Size = new System.Drawing.Size(132, 56);
            this.reportsMC_btn.TabIndex = 13;
            this.reportsMC_btn.Text = "Обращения";
            this.reportsMC_btn.UseVisualStyleBackColor = false;
            this.reportsMC_btn.Click += new System.EventHandler(this.reportsMC_btn_Click);
            // 
            // curr_mkd_btn
            // 
            this.curr_mkd_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.curr_mkd_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.curr_mkd_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.curr_mkd_btn.Location = new System.Drawing.Point(178, 136);
            this.curr_mkd_btn.Name = "curr_mkd_btn";
            this.curr_mkd_btn.Size = new System.Drawing.Size(132, 56);
            this.curr_mkd_btn.TabIndex = 14;
            this.curr_mkd_btn.Text = "Объекты МКД";
            this.curr_mkd_btn.UseVisualStyleBackColor = false;
            this.curr_mkd_btn.Click += new System.EventHandler(this.curr_mkd_btn_Click);
            // 
            // curr_event_btn
            // 
            this.curr_event_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.curr_event_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.curr_event_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.curr_event_btn.Location = new System.Drawing.Point(178, 200);
            this.curr_event_btn.Name = "curr_event_btn";
            this.curr_event_btn.Size = new System.Drawing.Size(132, 56);
            this.curr_event_btn.TabIndex = 15;
            this.curr_event_btn.Text = "Мероприятия";
            this.curr_event_btn.UseVisualStyleBackColor = false;
            this.curr_event_btn.Click += new System.EventHandler(this.curr_event_btn_Click);
            // 
            // ExcelRpMc_btn
            // 
            this.ExcelRpMc_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.ExcelRpMc_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExcelRpMc_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExcelRpMc_btn.Location = new System.Drawing.Point(178, 262);
            this.ExcelRpMc_btn.Name = "ExcelRpMc_btn";
            this.ExcelRpMc_btn.Size = new System.Drawing.Size(132, 56);
            this.ExcelRpMc_btn.TabIndex = 16;
            this.ExcelRpMc_btn.Text = "Отчёт об обращениях";
            this.ExcelRpMc_btn.UseVisualStyleBackColor = false;
            this.ExcelRpMc_btn.Click += new System.EventHandler(this.SaveReport);
            // 
            // Menu_MC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 333);
            this.Controls.Add(this.ExcelRpMc_btn);
            this.Controls.Add(this.curr_event_btn);
            this.Controls.Add(this.curr_mkd_btn);
            this.Controls.Add(this.reportsMC_btn);
            this.Controls.Add(this.UnLogin);
            this.Controls.Add(this.data_mc);
            this.Controls.Add(this.login_uk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu_MC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню управления УК";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_MC_FormClosed);
            this.Load += new System.EventHandler(this.Menu_MC_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button login_uk;
        private System.Windows.Forms.Button data_mc;
        private System.Windows.Forms.Button UnLogin;
        private System.Windows.Forms.Button reportsMC_btn;
        private System.Windows.Forms.Button curr_mkd_btn;
        private System.Windows.Forms.Button curr_event_btn;
        private System.Windows.Forms.Button ExcelRpMc_btn;
    }
}