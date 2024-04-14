namespace MonitoringSystem
{
    partial class Menu_ADM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_ADM));
            this.login_uk = new System.Windows.Forms.Button();
            this.data_mc = new System.Windows.Forms.Button();
            this.UnLogin = new System.Windows.Forms.Button();
            this.mkd_controll_btn = new System.Windows.Forms.Button();
            this.users_control_btn = new System.Windows.Forms.Button();
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
            this.data_mc.Size = new System.Drawing.Size(213, 56);
            this.data_mc.TabIndex = 11;
            this.data_mc.Text = "Управление УК";
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
            // mkd_controll_btn
            // 
            this.mkd_controll_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.mkd_controll_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mkd_controll_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mkd_controll_btn.Location = new System.Drawing.Point(178, 74);
            this.mkd_controll_btn.Name = "mkd_controll_btn";
            this.mkd_controll_btn.Size = new System.Drawing.Size(213, 56);
            this.mkd_controll_btn.TabIndex = 13;
            this.mkd_controll_btn.Text = "Управление МКД";
            this.mkd_controll_btn.UseVisualStyleBackColor = false;
            this.mkd_controll_btn.Click += new System.EventHandler(this.mkd_control_Click);
            // 
            // users_control_btn
            // 
            this.users_control_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.users_control_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.users_control_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.users_control_btn.Location = new System.Drawing.Point(178, 136);
            this.users_control_btn.Name = "users_control_btn";
            this.users_control_btn.Size = new System.Drawing.Size(213, 56);
            this.users_control_btn.TabIndex = 14;
            this.users_control_btn.Text = "Управление учётными записями";
            this.users_control_btn.UseVisualStyleBackColor = false;
            this.users_control_btn.Click += new System.EventHandler(this.users_btn_Click);
            // 
            // Menu_ADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 323);
            this.Controls.Add(this.users_control_btn);
            this.Controls.Add(this.mkd_controll_btn);
            this.Controls.Add(this.UnLogin);
            this.Controls.Add(this.data_mc);
            this.Controls.Add(this.login_uk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(423, 362);
            this.MinimumSize = new System.Drawing.Size(423, 362);
            this.Name = "Menu_ADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню администратора";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_MC_FormClosed);
            this.Load += new System.EventHandler(this.Menu_MC_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button login_uk;
        private System.Windows.Forms.Button data_mc;
        private System.Windows.Forms.Button UnLogin;
        private System.Windows.Forms.Button mkd_controll_btn;
        private System.Windows.Forms.Button users_control_btn;
    }
}