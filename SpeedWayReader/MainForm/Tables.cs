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
            Main main = new Main();
            main.ShowDialog();
        }

        private void Tables_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdRFIDDataSet.RFID_metka". При необходимости она может быть перемещена или удалена.
            this.rFID_metkaTableAdapter.Fill(this.bdRFIDDataSet.RFID_metka);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdRFIDDataSet.status_active". При необходимости она может быть перемещена или удалена.
            this.status_activeTableAdapter.Fill(this.bdRFIDDataSet.status_active);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdRFIDDataSet.type_car". При необходимости она может быть перемещена или удалена.
            this.type_carTableAdapter.Fill(this.bdRFIDDataSet.type_car);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdRFIDDataSet.cars". При необходимости она может быть перемещена или удалена.
            this.carsTableAdapter.Fill(this.bdRFIDDataSet.cars);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdRFIDDataSet.chauffeur". При необходимости она может быть перемещена или удалена.
            this.chauffeurTableAdapter.Fill(this.bdRFIDDataSet.chauffeur);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdRFIDDataSet.access_visit". При необходимости она может быть перемещена или удалена.
            this.access_visitTableAdapter.Fill(this.bdRFIDDataSet.access_visit);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdRFIDDataSet.car_with_RFID". При необходимости она может быть перемещена или удалена.
            this.car_with_RFIDTableAdapter.Fill(this.bdRFIDDataSet.car_with_RFID);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdRFIDDataSet.visit_type". При необходимости она может быть перемещена или удалена.
            this.visit_typeTableAdapter.Fill(this.bdRFIDDataSet.visit_type);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdRFIDDataSet.history_visit". При необходимости она может быть перемещена или удалена.
            this.history_visitTableAdapter.Fill(this.bdRFIDDataSet.history_visit);

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.historyvisitBindingSource.EndEdit();
            this.history_visitTableAdapter.Update(bdRFIDDataSet);
        }

        private void BtnSaveCarWithRFID_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carwithRFIDBindingSource.EndEdit();
            this.car_with_RFIDTableAdapter.Update(bdRFIDDataSet);
        }

        private void BtnSaveChauffeur_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chauffeurBindingSource.EndEdit();
            this.chauffeurTableAdapter.Update(bdRFIDDataSet);
        }

        private void BtnSaveCars_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carsBindingSource.EndEdit();
            this.carsTableAdapter.Update(bdRFIDDataSet);
        }

        private void BtnSaveTypeCar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.typecarBindingSource.EndEdit();
            this.type_carTableAdapter.Update(bdRFIDDataSet);
        }

        private void BtnSaveRFIDMetka_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rFIDmetkaBindingSource.EndEdit();
            this.rFID_metkaTableAdapter.Update(bdRFIDDataSet);
        }
    }
}
