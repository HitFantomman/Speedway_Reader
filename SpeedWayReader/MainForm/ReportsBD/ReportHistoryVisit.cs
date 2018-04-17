using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm.ReportsBD
{
    public partial class ReportHistoryVisit : Form
    {
        public ReportHistoryVisit()
        {
            InitializeComponent();
        }

        private void ReportHistoryVisit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "systemRFIDDataSet.type_visit". При необходимости она может быть перемещена или удалена.
            this.type_visitTableAdapter.Fill(this.systemRFIDDataSet.type_visit);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "systemRFIDDataSet.cars". При необходимости она может быть перемещена или удалена.
            this.carsTableAdapter.Fill(this.systemRFIDDataSet.cars);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "systemRFIDDataSet.history_visit". При необходимости она может быть перемещена или удалена.
            this.history_visitTableAdapter.Fill(this.systemRFIDDataSet.history_visit);
            this.reportViewer1.RefreshReport();
        }
    }
}
