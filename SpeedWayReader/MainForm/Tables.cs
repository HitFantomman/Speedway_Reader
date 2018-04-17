using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class Tables : Form
    {
        public Tables()
        {
            InitializeComponent();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tables_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "systemRFIDDataSet.access_visit". При необходимости она может быть перемещена или удалена.
            this.access_visitTableAdapter.Fill(this.systemRFIDDataSet.access_visit);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "systemRFIDDataSet.status_active". При необходимости она может быть перемещена или удалена.
            this.status_activeTableAdapter.Fill(this.systemRFIDDataSet.status_active);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "systemRFIDDataSet.RFID_metka". При необходимости она может быть перемещена или удалена.
            this.rFID_metkaTableAdapter.Fill(this.systemRFIDDataSet.RFID_metka);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "systemRFIDDataSet.type_car". При необходимости она может быть перемещена или удалена.
            this.type_carTableAdapter.Fill(this.systemRFIDDataSet.type_car);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "systemRFIDDataSet.cars". При необходимости она может быть перемещена или удалена.
            this.carsTableAdapter.Fill(this.systemRFIDDataSet.cars);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "systemRFIDDataSet.chauffeur". При необходимости она может быть перемещена или удалена.
            this.chauffeurTableAdapter.Fill(this.systemRFIDDataSet.chauffeur);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "systemRFIDDataSet.cars_with_RFID". При необходимости она может быть перемещена или удалена.
            this.cars_with_RFIDTableAdapter.Fill(this.systemRFIDDataSet.cars_with_RFID);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "systemRFIDDataSet.type_visit". При необходимости она может быть перемещена или удалена.
            this.type_visitTableAdapter.Fill(this.systemRFIDDataSet.type_visit);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "systemRFIDDataSet.history_visit". При необходимости она может быть перемещена или удалена.
            this.history_visitTableAdapter.Fill(this.systemRFIDDataSet.history_visit);

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.historyvisitBindingSource.EndEdit();
            this.history_visitTableAdapter.Update(systemRFIDDataSet);
        }

        private void BtnSaveCarWithRFID_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carswithRFIDBindingSource.EndEdit();
            this.cars_with_RFIDTableAdapter.Update(systemRFIDDataSet);
        }

        private void BtnSaveChauffeur_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chauffeurBindingSource.EndEdit();
            this.chauffeurTableAdapter.Update(systemRFIDDataSet);
        }

        private void BtnSaveCars_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carsBindingSource.EndEdit();
            this.carsTableAdapter.Update(systemRFIDDataSet);
        }

        private void BtnSaveTypeCar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.typecarBindingSource.EndEdit();
            this.type_carTableAdapter.Update(systemRFIDDataSet);
        }

        private void BtnSaveRFIDMetka_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rFIDmetkaBindingSource.EndEdit();
            this.rFID_metkaTableAdapter.Update(systemRFIDDataSet);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dvhistoryvisit = new DataView(systemRFIDDataSet.history_visit);
            dvhistoryvisit.RowFilter = string.Format("Convert(машина, 'System.String') LIKE '%" + textBox1.Text + "%'"
                                                        +"or Convert(дата_проезда, 'System.String') LIKE '%" + textBox1.Text + "%'");
            dataGridViewHistoryVisit.DataSource = dvhistoryvisit;
        }

        private void BoxSearchChauffeur_TextChanged(object sender, EventArgs e)
        {
            chauffeurBindingSource.Filter = "Convert([фамилия], 'System.String') like \'%" + BoxSearchChauffeur.Text + "%\' or " +
                                            "Convert([имя], 'System.String') like \'%" + BoxSearchChauffeur.Text + "%\' or " +
                                            "Convert([отчество], 'System.String') like \'%" + BoxSearchChauffeur.Text + "%\' or " +
                                            "Convert([№_водительских_прав], 'System.String') like \'%" + BoxSearchChauffeur.Text + "%\'";
        }

        private void поИсторииПроездовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportsBD.ReportHistoryVisit rhv = new ReportsBD.ReportHistoryVisit();
            rhv.ShowDialog();
        }
    }
}
