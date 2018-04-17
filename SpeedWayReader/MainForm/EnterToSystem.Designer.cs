namespace MainForm
{
    partial class EnterToSystem
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
            this.BoxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BoxPassword
            // 
            this.BoxPassword.Location = new System.Drawing.Point(106, 122);
            this.BoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.BoxPassword.Name = "BoxPassword";
            this.BoxPassword.Size = new System.Drawing.Size(237, 26);
            this.BoxPassword.TabIndex = 0;
            this.BoxPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пароль";
            // 
            // BtnEnter
            // 
            this.BtnEnter.AutoSize = true;
            this.BtnEnter.Location = new System.Drawing.Point(133, 196);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(150, 42);
            this.BtnEnter.TabIndex = 4;
            this.BtnEnter.Text = "Войти";
            this.BtnEnter.UseVisualStyleBackColor = true;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Логин";
            // 
            // BoxLogin
            // 
            this.BoxLogin.Location = new System.Drawing.Point(106, 78);
            this.BoxLogin.Name = "BoxLogin";
            this.BoxLogin.Size = new System.Drawing.Size(237, 26);
            this.BoxLogin.TabIndex = 6;
            // 
            // EnterToSystem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(426, 290);
            this.Controls.Add(this.BoxLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BoxPassword);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EnterToSystem";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход в систему";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BoxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BoxLogin;
    }
}