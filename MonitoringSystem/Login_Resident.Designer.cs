namespace MonitoringSystem
{
    partial class Login_Resident
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Resident));
            this.create_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.enter_btn = new System.Windows.Forms.Button();
            this.visible_pswd_box = new System.Windows.Forms.PictureBox();
            this.unvisible_pswd_box = new System.Windows.Forms.PictureBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.visible_pswd_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unvisible_pswd_box)).BeginInit();
            this.SuspendLayout();
            // 
            // create_btn
            // 
            this.create_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.create_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.create_btn.Location = new System.Drawing.Point(168, 138);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(198, 56);
            this.create_btn.TabIndex = 7;
            this.create_btn.Text = "Создать аккаунт";
            this.create_btn.UseVisualStyleBackColor = false;
            this.create_btn.Click += new System.EventHandler(this.create_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Логин:";
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
            this.login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_KeyPress);
            // 
            // enter_btn
            // 
            this.enter_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.enter_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.enter_btn.Location = new System.Drawing.Point(21, 138);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(132, 56);
            this.enter_btn.TabIndex = 10;
            this.enter_btn.Text = "Войти";
            this.enter_btn.UseVisualStyleBackColor = false;
            this.enter_btn.Click += new System.EventHandler(this.enter_Click);
            // 
            // visible_pswd_box
            // 
            this.visible_pswd_box.BackColor = System.Drawing.Color.Transparent;
            this.visible_pswd_box.Image = ((System.Drawing.Image)(resources.GetObject("visible_pswd_box.Image")));
            this.visible_pswd_box.Location = new System.Drawing.Point(296, 76);
            this.visible_pswd_box.Name = "visible_pswd_box";
            this.visible_pswd_box.Size = new System.Drawing.Size(48, 39);
            this.visible_pswd_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.visible_pswd_box.TabIndex = 11;
            this.visible_pswd_box.TabStop = false;
            this.visible_pswd_box.Click += new System.EventHandler(this.VisiblePswd_Click);
            // 
            // unvisible_pswd_box
            // 
            this.unvisible_pswd_box.BackColor = System.Drawing.Color.Transparent;
            this.unvisible_pswd_box.Image = ((System.Drawing.Image)(resources.GetObject("unvisible_pswd_box.Image")));
            this.unvisible_pswd_box.Location = new System.Drawing.Point(296, 76);
            this.unvisible_pswd_box.Name = "unvisible_pswd_box";
            this.unvisible_pswd_box.Size = new System.Drawing.Size(48, 39);
            this.unvisible_pswd_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.unvisible_pswd_box.TabIndex = 12;
            this.unvisible_pswd_box.TabStop = false;
            this.unvisible_pswd_box.Click += new System.EventHandler(this.InvisiblePswd_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(123, 84);
            this.password.MaximumSize = new System.Drawing.Size(300, 100);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(167, 31);
            this.password.TabIndex = 14;
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Пароль:";
            // 
            // Login_Resident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(388, 215);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.unvisible_pswd_box);
            this.Controls.Add(this.visible_pswd_box);
            this.Controls.Add(this.enter_btn);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.create_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login_Resident";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход для жителя";
            this.Load += new System.EventHandler(this.Login_Resident_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visible_pswd_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unvisible_pswd_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Button enter_btn;
        private System.Windows.Forms.PictureBox visible_pswd_box;
        private System.Windows.Forms.PictureBox unvisible_pswd_box;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
    }
}