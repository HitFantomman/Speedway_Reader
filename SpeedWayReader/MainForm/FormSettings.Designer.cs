namespace MainForm
{
    partial class FormSettings
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
            this.BtnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxConnect = new System.Windows.Forms.TextBox();
            this.ListStatus = new System.Windows.Forms.ListBox();
            this.BtnDB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxRead = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BoxSearch = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BoxSession = new System.Windows.Forms.ComboBox();
            this.BtnApply = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnConnect
            // 
            this.BtnConnect.AutoSize = true;
            this.BtnConnect.Location = new System.Drawing.Point(127, 55);
            this.BtnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(126, 34);
            this.BtnConnect.TabIndex = 0;
            this.BtnConnect.Text = "Подключиться";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Подключение";
            // 
            // BoxConnect
            // 
            this.BoxConnect.Location = new System.Drawing.Point(127, 12);
            this.BoxConnect.Name = "BoxConnect";
            this.BoxConnect.Size = new System.Drawing.Size(246, 26);
            this.BoxConnect.TabIndex = 2;
            // 
            // ListStatus
            // 
            this.ListStatus.Enabled = false;
            this.ListStatus.FormattingEnabled = true;
            this.ListStatus.ItemHeight = 19;
            this.ListStatus.Location = new System.Drawing.Point(388, 41);
            this.ListStatus.Name = "ListStatus";
            this.ListStatus.Size = new System.Drawing.Size(287, 327);
            this.ListStatus.TabIndex = 4;
            // 
            // BtnDB
            // 
            this.BtnDB.AutoSize = true;
            this.BtnDB.Location = new System.Drawing.Point(12, 329);
            this.BtnDB.Name = "BtnDB";
            this.BtnDB.Size = new System.Drawing.Size(167, 38);
            this.BtnDB.TabIndex = 6;
            this.BtnDB.Text = "Настройки данных";
            this.BtnDB.UseVisualStyleBackColor = true;
            this.BtnDB.Click += new System.EventHandler(this.BtnDB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Настройки считывателя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Режим чтения";
            // 
            // BoxRead
            // 
            this.BoxRead.FormattingEnabled = true;
            this.BoxRead.Location = new System.Drawing.Point(142, 22);
            this.BoxRead.Name = "BoxRead";
            this.BoxRead.Size = new System.Drawing.Size(121, 27);
            this.BoxRead.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnApply);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.BoxSession);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BoxSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BoxRead);
            this.groupBox1.Location = new System.Drawing.Point(23, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 164);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройка считывателя:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Режим поиска";
            // 
            // BoxSearch
            // 
            this.BoxSearch.FormattingEnabled = true;
            this.BoxSearch.Location = new System.Drawing.Point(142, 55);
            this.BoxSearch.Name = "BoxSearch";
            this.BoxSearch.Size = new System.Drawing.Size(121, 27);
            this.BoxSearch.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Сессия";
            // 
            // BoxSession
            // 
            this.BoxSession.FormattingEnabled = true;
            this.BoxSession.Location = new System.Drawing.Point(142, 88);
            this.BoxSession.Name = "BoxSession";
            this.BoxSession.Size = new System.Drawing.Size(121, 27);
            this.BoxSession.TabIndex = 14;
            // 
            // BtnApply
            // 
            this.BtnApply.AutoSize = true;
            this.BtnApply.Location = new System.Drawing.Point(181, 129);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(82, 29);
            this.BtnApply.TabIndex = 15;
            this.BtnApply.Text = "Принять";
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 379);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnDB);
            this.Controls.Add(this.ListStatus);
            this.Controls.Add(this.BoxConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnConnect);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSettings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки считывателя";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BoxConnect;
        private System.Windows.Forms.ListBox ListStatus;
        private System.Windows.Forms.Button BtnDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BoxRead;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox BoxSession;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox BoxSearch;
        private System.Windows.Forms.Button BtnApply;
    }
}