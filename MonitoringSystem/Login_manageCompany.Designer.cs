namespace MonitoringSystem
{
    partial class Login_manageCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_manageCompany));
            this.create = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.VisiblePswd = new System.Windows.Forms.PictureBox();
            this.InvisiblePswd = new System.Windows.Forms.PictureBox();
            this.password = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VisiblePswd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvisiblePswd)).BeginInit();
            this.SuspendLayout();
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.SystemColors.Highlight;
            this.create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create.ForeColor = System.Drawing.SystemColors.ControlText;
            this.create.Location = new System.Drawing.Point(168, 138);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(198, 56);
            this.create.TabIndex = 7;
            this.create.Text = "Создать аккаунт";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.Create_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.ForeColor = System.Drawing.Color.White;
            this.loginLabel.Location = new System.Drawing.Point(25, 38);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(77, 25);
            this.loginLabel.TabIndex = 8;
            this.loginLabel.Text = "Логин:";
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(123, 38);
            this.login.MaximumSize = new System.Drawing.Size(300, 100);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(167, 31);
            this.login.TabIndex = 9;
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            this.login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_KeyDown);
            this.login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.SystemColors.Highlight;
            this.enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.enter.Location = new System.Drawing.Point(21, 138);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(132, 56);
            this.enter.TabIndex = 10;
            this.enter.Text = "Войти";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // VisiblePswd
            // 
            this.VisiblePswd.BackColor = System.Drawing.Color.Transparent;
            this.VisiblePswd.Image = ((System.Drawing.Image)(resources.GetObject("VisiblePswd.Image")));
            this.VisiblePswd.Location = new System.Drawing.Point(296, 76);
            this.VisiblePswd.Name = "VisiblePswd";
            this.VisiblePswd.Size = new System.Drawing.Size(48, 39);
            this.VisiblePswd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VisiblePswd.TabIndex = 11;
            this.VisiblePswd.TabStop = false;
            this.VisiblePswd.Click += new System.EventHandler(this.VisiblePswd_Click);
            // 
            // InvisiblePswd
            // 
            this.InvisiblePswd.BackColor = System.Drawing.Color.Transparent;
            this.InvisiblePswd.Image = ((System.Drawing.Image)(resources.GetObject("InvisiblePswd.Image")));
            this.InvisiblePswd.Location = new System.Drawing.Point(296, 76);
            this.InvisiblePswd.Name = "InvisiblePswd";
            this.InvisiblePswd.Size = new System.Drawing.Size(48, 39);
            this.InvisiblePswd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InvisiblePswd.TabIndex = 12;
            this.InvisiblePswd.TabStop = false;
            this.InvisiblePswd.Click += new System.EventHandler(this.InvisiblePswd_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(123, 84);
            this.password.MaximumSize = new System.Drawing.Size(300, 100);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(167, 31);
            this.password.TabIndex = 14;
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordlabel.ForeColor = System.Drawing.Color.White;
            this.passwordlabel.Location = new System.Drawing.Point(25, 87);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(92, 25);
            this.passwordlabel.TabIndex = 13;
            this.passwordlabel.Text = "Пароль:";
            // 
            // Login_manageCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(388, 215);
            this.Controls.Add(this.password);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.InvisiblePswd);
            this.Controls.Add(this.VisiblePswd);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.login);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.create);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login_manageCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход для лица УК";
            this.Load += new System.EventHandler(this.Login_manageCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VisiblePswd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvisiblePswd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.PictureBox VisiblePswd;
        private System.Windows.Forms.PictureBox InvisiblePswd;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label passwordlabel;
    }
}