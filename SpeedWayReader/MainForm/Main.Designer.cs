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
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DGHistoryVisit = new System.Windows.Forms.DataGridView();
            this.PanelNumber = new System.Windows.Forms.Panel();
            this.BoxNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuMain = new System.Windows.Forms.MenuStrip();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TimerTags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGHistoryVisit)).BeginInit();
            this.PanelNumber.SuspendLayout();
            this.MenuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerTags
            // 
            this.TimerTags.Interval = 2000D;
            this.TimerTags.SynchronizingObject = this;
            this.TimerTags.Elapsed += new System.Timers.ElapsedEventHandler(this.TimerTags_Elapsed);
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.AutoSize = true;
            this.ButtonSettings.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSettings.Location = new System.Drawing.Point(12, 34);
            this.ButtonSettings.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(324, 42);
            this.ButtonSettings.TabIndex = 2;
            this.ButtonSettings.Text = "Текущие настройки";
            this.ButtonSettings.UseVisualStyleBackColor = true;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "История обнаружения меток:";
            // 
            // DGHistoryVisit
            // 
            this.DGHistoryVisit.AllowUserToAddRows = false;
            this.DGHistoryVisit.AllowUserToDeleteRows = false;
            this.DGHistoryVisit.AllowUserToResizeColumns = false;
            this.DGHistoryVisit.AllowUserToResizeRows = false;
            this.DGHistoryVisit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGHistoryVisit.EnableHeadersVisualStyles = false;
            this.DGHistoryVisit.Location = new System.Drawing.Point(12, 108);
            this.DGHistoryVisit.Name = "DGHistoryVisit";
            this.DGHistoryVisit.ReadOnly = true;
            this.DGHistoryVisit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGHistoryVisit.Size = new System.Drawing.Size(982, 374);
            this.DGHistoryVisit.TabIndex = 11;
            this.DGHistoryVisit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DGHistoryVisit_MouseClick);
            // 
            // PanelNumber
            // 
            this.PanelNumber.Controls.Add(this.BoxNumber);
            this.PanelNumber.Controls.Add(this.label1);
            this.PanelNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PanelNumber.Location = new System.Drawing.Point(713, 33);
            this.PanelNumber.Name = "PanelNumber";
            this.PanelNumber.Size = new System.Drawing.Size(281, 69);
            this.PanelNumber.TabIndex = 12;
            this.PanelNumber.Tag = "";
            // 
            // BoxNumber
            // 
            this.BoxNumber.Location = new System.Drawing.Point(41, 31);
            this.BoxNumber.Name = "BoxNumber";
            this.BoxNumber.ReadOnly = true;
            this.BoxNumber.Size = new System.Drawing.Size(207, 26);
            this.BoxNumber.TabIndex = 1;
            this.BoxNumber.Text = "Неопознанный номер";
            this.BoxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Распознанный номер";
            // 
            // MenuMain
            // 
            this.MenuMain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетToolStripMenuItem});
            this.MenuMain.Location = new System.Drawing.Point(0, 0);
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Size = new System.Drawing.Size(1008, 27);
            this.MenuMain.TabIndex = 13;
            this.MenuMain.Text = "menuStrip1";
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(79, 23);
            this.отчетToolStripMenuItem.Text = "Отчеты";
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(416, 76);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(267, 26);
            this.SearchText.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(356, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Поиск:";
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1008, 498);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.PanelNumber);
            this.Controls.Add(this.DGHistoryVisit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonSettings);
            this.Controls.Add(this.MenuMain);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.MenuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speedway Reader v1.0.0.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TimerTags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGHistoryVisit)).EndInit();
            this.PanelNumber.ResumeLayout(false);
            this.PanelNumber.PerformLayout();
            this.MenuMain.ResumeLayout(false);
            this.MenuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Timers.Timer TimerTags;
        private System.Windows.Forms.Button ButtonSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGHistoryVisit;
        private System.Windows.Forms.Panel PanelNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BoxNumber;
        private System.Windows.Forms.MenuStrip MenuMain;
        private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Label label3;
    }
}

