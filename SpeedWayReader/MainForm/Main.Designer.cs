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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TimerTags = new System.Timers.Timer();
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DGHistoryVisit = new System.Windows.Forms.DataGridView();
            this.PanelNumber = new System.Windows.Forms.Panel();
            this.BoxNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typ_visit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.access_typ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TimerTags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGHistoryVisit)).BeginInit();
            this.PanelNumber.SuspendLayout();
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
            this.ButtonSettings.Location = new System.Drawing.Point(13, 13);
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
            this.label2.Location = new System.Drawing.Point(9, 60);
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
            this.DGHistoryVisit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.machine,
            this.typ_visit,
            this.access_typ});
            this.DGHistoryVisit.EnableHeadersVisualStyles = false;
            this.DGHistoryVisit.Location = new System.Drawing.Point(13, 87);
            this.DGHistoryVisit.Name = "DGHistoryVisit";
            this.DGHistoryVisit.ReadOnly = true;
            this.DGHistoryVisit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGHistoryVisit.Size = new System.Drawing.Size(982, 374);
            this.DGHistoryVisit.TabIndex = 11;
            // 
            // PanelNumber
            // 
            this.PanelNumber.Controls.Add(this.BoxNumber);
            this.PanelNumber.Controls.Add(this.label1);
            this.PanelNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PanelNumber.Location = new System.Drawing.Point(698, 12);
            this.PanelNumber.Name = "PanelNumber";
            this.PanelNumber.Size = new System.Drawing.Size(297, 69);
            this.PanelNumber.TabIndex = 12;
            this.PanelNumber.Tag = "";
            // 
            // BoxNumber
            // 
            this.BoxNumber.Location = new System.Drawing.Point(170, 21);
            this.BoxNumber.Name = "BoxNumber";
            this.BoxNumber.ReadOnly = true;
            this.BoxNumber.Size = new System.Drawing.Size(110, 26);
            this.BoxNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Распознанный номер";
            // 
            // Data
            // 
            this.Data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.Format = "F";
            dataGridViewCellStyle5.NullValue = null;
            this.Data.DefaultCellStyle = dataGridViewCellStyle5;
            this.Data.HeaderText = "Дата";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // machine
            // 
            this.machine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.machine.DefaultCellStyle = dataGridViewCellStyle6;
            this.machine.HeaderText = "Машина";
            this.machine.Name = "machine";
            this.machine.ReadOnly = true;
            // 
            // typ_visit
            // 
            this.typ_visit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typ_visit.DefaultCellStyle = dataGridViewCellStyle7;
            this.typ_visit.HeaderText = "Тип проезда";
            this.typ_visit.Name = "typ_visit";
            this.typ_visit.ReadOnly = true;
            // 
            // access_typ
            // 
            this.access_typ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.access_typ.DefaultCellStyle = dataGridViewCellStyle8;
            this.access_typ.HeaderText = "Доступ";
            this.access_typ.Name = "access_typ";
            this.access_typ.ReadOnly = true;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1008, 473);
            this.Controls.Add(this.PanelNumber);
            this.Controls.Add(this.DGHistoryVisit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonSettings);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speedway Reader v1.0.0.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.TimerTags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGHistoryVisit)).EndInit();
            this.PanelNumber.ResumeLayout(false);
            this.PanelNumber.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn machine;
        private System.Windows.Forms.DataGridViewTextBoxColumn typ_visit;
        private System.Windows.Forms.DataGridViewTextBoxColumn access_typ;
    }
}

