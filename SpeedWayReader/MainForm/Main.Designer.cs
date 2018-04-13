namespace MainForm
{
    partial class Main
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TimerTags = new System.Timers.Timer();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ButtonDisconnect = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.TextConnect = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListTags = new System.Windows.Forms.ListBox();
            this.ButtonBD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TimerTags)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerTags
            // 
            this.TimerTags.Interval = 2000D;
            this.TimerTags.SynchronizingObject = this;
            this.TimerTags.Elapsed += new System.Timers.ElapsedEventHandler(this.TimerTags_Elapsed);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Enabled = false;
            this.ButtonStart.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonStart.Location = new System.Drawing.Point(13, 13);
            this.ButtonStart.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(158, 38);
            this.ButtonStart.TabIndex = 0;
            this.ButtonStart.Text = "Начать";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.Enabled = false;
            this.ButtonStop.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonStop.Location = new System.Drawing.Point(179, 13);
            this.ButtonStop.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(158, 38);
            this.ButtonStop.TabIndex = 1;
            this.ButtonStop.Text = "Остановить";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.AutoSize = true;
            this.ButtonSettings.Enabled = false;
            this.ButtonSettings.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSettings.Location = new System.Drawing.Point(13, 59);
            this.ButtonSettings.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(324, 42);
            this.ButtonSettings.TabIndex = 2;
            this.ButtonSettings.Text = "Текущие настройки";
            this.ButtonSettings.UseVisualStyleBackColor = true;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Enabled = false;
            this.ButtonClear.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonClear.Location = new System.Drawing.Point(345, 13);
            this.ButtonClear.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(206, 38);
            this.ButtonClear.TabIndex = 3;
            this.ButtonClear.Text = "Очистить историю";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.AutoSize = true;
            this.ButtonConnect.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonConnect.Location = new System.Drawing.Point(867, 47);
            this.ButtonConnect.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(176, 42);
            this.ButtonConnect.TabIndex = 4;
            this.ButtonConnect.Text = "Подключиться";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // ButtonDisconnect
            // 
            this.ButtonDisconnect.AutoSize = true;
            this.ButtonDisconnect.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDisconnect.Location = new System.Drawing.Point(867, 97);
            this.ButtonDisconnect.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonDisconnect.Name = "ButtonDisconnect";
            this.ButtonDisconnect.Size = new System.Drawing.Size(176, 42);
            this.ButtonDisconnect.TabIndex = 5;
            this.ButtonDisconnect.Text = "Отключиться";
            this.ButtonDisconnect.UseVisualStyleBackColor = true;
            this.ButtonDisconnect.Click += new System.EventHandler(this.ButtonDisconnect_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.AutoSize = true;
            this.ButtonClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonClose.Location = new System.Drawing.Point(885, 482);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(158, 45);
            this.ButtonClose.TabIndex = 6;
            this.ButtonClose.Text = "Выйти";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // TextConnect
            // 
            this.TextConnect.BackColor = System.Drawing.SystemColors.Window;
            this.TextConnect.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextConnect.Location = new System.Drawing.Point(796, 13);
            this.TextConnect.Margin = new System.Windows.Forms.Padding(4);
            this.TextConnect.Name = "TextConnect";
            this.TextConnect.Size = new System.Drawing.Size(247, 29);
            this.TextConnect.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(559, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "IP или имя считывателя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "История обнаружения меток:";
            // 
            // ListTags
            // 
            this.ListTags.BackColor = System.Drawing.SystemColors.Window;
            this.ListTags.Enabled = false;
            this.ListTags.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListTags.FormattingEnabled = true;
            this.ListTags.ItemHeight = 22;
            this.ListTags.Location = new System.Drawing.Point(13, 147);
            this.ListTags.Margin = new System.Windows.Forms.Padding(4);
            this.ListTags.Name = "ListTags";
            this.ListTags.Size = new System.Drawing.Size(1030, 312);
            this.ListTags.TabIndex = 10;
            // 
            // ButtonBD
            // 
            this.ButtonBD.AutoSize = true;
            this.ButtonBD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBD.Location = new System.Drawing.Point(13, 482);
            this.ButtonBD.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonBD.Name = "ButtonBD";
            this.ButtonBD.Size = new System.Drawing.Size(154, 42);
            this.ButtonBD.TabIndex = 11;
            this.ButtonBD.Text = "База данных";
            this.ButtonBD.UseVisualStyleBackColor = true;
            this.ButtonBD.Click += new System.EventHandler(this.ButtonBD_Click);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1056, 534);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonBD);
            this.Controls.Add(this.ListTags);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextConnect);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonDisconnect);
            this.Controls.Add(this.ButtonConnect);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonSettings);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ButtonStart);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speedway Reader v1.0.0.0";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TimerTags)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Timers.Timer TimerTags;
        private System.Windows.Forms.Button ButtonDisconnect;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonSettings;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.TextBox TextConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListTags;
        private System.Windows.Forms.Button ButtonBD;
    }
}

