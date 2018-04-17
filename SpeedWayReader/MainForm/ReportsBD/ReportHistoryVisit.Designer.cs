namespace MainForm.ReportsBD
{
    partial class ReportHistoryVisit
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.systemRFIDDataSet = new MainForm.SystemRFIDDataSet();
            this.historyvisitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.history_visitTableAdapter = new MainForm.SystemRFIDDataSetTableAdapters.history_visitTableAdapter();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter = new MainForm.SystemRFIDDataSetTableAdapters.carsTableAdapter();
            this.typevisitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.type_visitTableAdapter = new MainForm.SystemRFIDDataSetTableAdapters.type_visitTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.systemRFIDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyvisitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typevisitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetHistoryVisit";
            reportDataSource1.Value = this.carsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MainForm.ReportsBD.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(702, 400);
            this.reportViewer1.TabIndex = 0;
            // 
            // systemRFIDDataSet
            // 
            this.systemRFIDDataSet.DataSetName = "SystemRFIDDataSet";
            this.systemRFIDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historyvisitBindingSource
            // 
            this.historyvisitBindingSource.DataMember = "history_visit";
            this.historyvisitBindingSource.DataSource = this.systemRFIDDataSet;
            // 
            // history_visitTableAdapter
            // 
            this.history_visitTableAdapter.ClearBeforeFill = true;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "cars";
            this.carsBindingSource.DataSource = this.systemRFIDDataSet;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // typevisitBindingSource
            // 
            this.typevisitBindingSource.DataMember = "type_visit";
            this.typevisitBindingSource.DataSource = this.systemRFIDDataSet;
            // 
            // type_visitTableAdapter
            // 
            this.type_visitTableAdapter.ClearBeforeFill = true;
            // 
            // ReportHistoryVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 400);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportHistoryVisit";
            this.Text = "ReportHistoryVisit";
            this.Load += new System.EventHandler(this.ReportHistoryVisit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.systemRFIDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyvisitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typevisitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private SystemRFIDDataSet systemRFIDDataSet;
        private System.Windows.Forms.BindingSource historyvisitBindingSource;
        private SystemRFIDDataSetTableAdapters.history_visitTableAdapter history_visitTableAdapter;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private SystemRFIDDataSetTableAdapters.carsTableAdapter carsTableAdapter;
        private System.Windows.Forms.BindingSource typevisitBindingSource;
        private SystemRFIDDataSetTableAdapters.type_visitTableAdapter type_visitTableAdapter;
    }
}