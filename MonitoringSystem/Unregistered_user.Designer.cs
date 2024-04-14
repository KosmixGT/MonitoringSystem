namespace MonitoringSystem
{
    partial class Unregistered_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Unregistered_user));
            this.mkd_view_btn = new System.Windows.Forms.Button();
            this.events_view_btn = new System.Windows.Forms.Button();
            this.companies_view_btn = new System.Windows.Forms.Button();
            this.reports_view_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mkd_view_btn
            // 
            this.mkd_view_btn.BackColor = System.Drawing.Color.Indigo;
            this.mkd_view_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.mkd_view_btn.ForeColor = System.Drawing.Color.White;
            this.mkd_view_btn.Location = new System.Drawing.Point(12, 12);
            this.mkd_view_btn.Name = "mkd_view_btn";
            this.mkd_view_btn.Size = new System.Drawing.Size(150, 150);
            this.mkd_view_btn.TabIndex = 0;
            this.mkd_view_btn.Text = "Просмотр данных об объектах МКД";
            this.mkd_view_btn.UseVisualStyleBackColor = false;
            this.mkd_view_btn.Click += new System.EventHandler(this.mkd_view_btn_Click);
            // 
            // events_view_btn
            // 
            this.events_view_btn.BackColor = System.Drawing.Color.Indigo;
            this.events_view_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.events_view_btn.ForeColor = System.Drawing.Color.White;
            this.events_view_btn.Location = new System.Drawing.Point(168, 12);
            this.events_view_btn.Name = "events_view_btn";
            this.events_view_btn.Size = new System.Drawing.Size(150, 150);
            this.events_view_btn.TabIndex = 1;
            this.events_view_btn.Text = "Просмотр данных об отключениях и работах";
            this.events_view_btn.UseVisualStyleBackColor = false;
            this.events_view_btn.Click += new System.EventHandler(this.events_view_btn_Click);
            // 
            // companies_view_btn
            // 
            this.companies_view_btn.BackColor = System.Drawing.Color.Indigo;
            this.companies_view_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.companies_view_btn.ForeColor = System.Drawing.Color.White;
            this.companies_view_btn.Location = new System.Drawing.Point(324, 12);
            this.companies_view_btn.Name = "companies_view_btn";
            this.companies_view_btn.Size = new System.Drawing.Size(150, 150);
            this.companies_view_btn.TabIndex = 2;
            this.companies_view_btn.Text = "Просмотр данных об УК";
            this.companies_view_btn.UseVisualStyleBackColor = false;
            this.companies_view_btn.Click += new System.EventHandler(this.companies_view_btn_Click);
            // 
            // reports_view_btn
            // 
            this.reports_view_btn.BackColor = System.Drawing.Color.Indigo;
            this.reports_view_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.reports_view_btn.ForeColor = System.Drawing.Color.White;
            this.reports_view_btn.Location = new System.Drawing.Point(480, 12);
            this.reports_view_btn.Name = "reports_view_btn";
            this.reports_view_btn.Size = new System.Drawing.Size(150, 150);
            this.reports_view_btn.TabIndex = 3;
            this.reports_view_btn.Text = "Просмотр данных об обращениях";
            this.reports_view_btn.UseVisualStyleBackColor = false;
            this.reports_view_btn.Click += new System.EventHandler(this.reports_view_btn_Click);
            // 
            // Unregistered_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 186);
            this.Controls.Add(this.reports_view_btn);
            this.Controls.Add(this.companies_view_btn);
            this.Controls.Add(this.events_view_btn);
            this.Controls.Add(this.mkd_view_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(522, 171);
            this.Name = "Unregistered_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню неавторизованного пользователя";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Unregistered_user_FormClosed);
            this.Load += new System.EventHandler(this.Unregistered_user_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mkd_view_btn;
        private System.Windows.Forms.Button events_view_btn;
        private System.Windows.Forms.Button companies_view_btn;
        private System.Windows.Forms.Button reports_view_btn;
    }
}