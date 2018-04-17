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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
            //FeatureSet features = reader.QueryFeatureSet();
            //Status status = reader.QueryStatus();
            //Settings settings = reader.QuerySettings();
            ListStatus.Items.Add("Функции считывателя");
            ListStatus.Items.Add("--------------------");
            ListStatus.Items.Add("Модель: "/* + features.ModelName*/);
            ListStatus.Items.Add("Номер модели: "/* + features.ModelNumber*/);
            ListStatus.Items.Add("Версия прошивки: "/* + features.FirmwareVersion*/);
            ListStatus.Items.Add("Количество антенн: "/* + features.AntennaCount*/);
            ListStatus.Items.Add("Статус считывателя");
            ListStatus.Items.Add("--------------------");
            ListStatus.Items.Add("Статус подключения: "/* + status.IsConnected*/);
            ListStatus.Items.Add("Singulation: "/* + status.IsSingulating*/);
            ListStatus.Items.Add("Температура: "/* + status.TemperatureInCelsius*/);
            ListStatus.Items.Add("Настройки считывателя");
            ListStatus.Items.Add("--------------------");
            ListStatus.Items.Add("Режим: "/* + settings.ReaderMode*/);
            ListStatus.Items.Add("Режим поиска: "/* + settings.SearchMode*/);
            ListStatus.Items.Add("Сессия: "/* + settings.Session*/);
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            // Подключение к считывателю.
            // Подключение по введенному IP или имени  считывателя
            //string hostname = Convert.ToString(BoxConnect.Text);(снять)
            //reader.Connect(hostname);//(снять)
            if (true)//reader.IsConnected(заменить на true)
            {
                MessageBox.Show("Считыватель подключен!", "Подключение", MessageBoxButtons.OK);
                // Получение настроек по умолчанию со считывателя
                //Settings settings = reader.QueryDefaultSettings();(снять)
                // Подключение антенны
                //settings.Report.IncludeAntennaPortNumber = true;(снять)
                //settings.ReaderMode = ReaderMode.AutoSetDenseReader;(снять)
                //settings.SearchMode = SearchMode.SingleTarget;(снять)
                //settings.Session = 3;(снять)
                // Доступ ко всем антеннам
                //settings.Antennas.EnableAll();(снять)
                // Включение максимальноя мощности и чувствительности
                //settings.Antennas.TxPowerMax = true;(снять)
                //settings.Antennas.RxSensitivityMax = true;(снять)
                // Применить настройки
                //reader.ApplySettings(settings);(снять)
                ListStatus.Items.Clear();
                //FeatureSet features = reader.QueryFeatureSet();
                //Status status = reader.QueryStatus();
                //Settings settings = reader.QuerySettings();
                ListStatus.Items.Add("Функции считывателя");
                ListStatus.Items.Add("--------------------");
                ListStatus.Items.Add("Модель: "/* + features.ModelName*/);
                ListStatus.Items.Add("Номер модели: "/* + features.ModelNumber*/);
                ListStatus.Items.Add("Версия прошивки: "/* + features.FirmwareVersion*/);
                ListStatus.Items.Add("Количество антенн: "/* + features.AntennaCount*/);
                ListStatus.Items.Add("Статус считывателя");
                ListStatus.Items.Add("--------------------");
                ListStatus.Items.Add("Статус подключения: "/* + status.IsConnected*/);
                ListStatus.Items.Add("Singulation: "/* + status.IsSingulating*/);
                ListStatus.Items.Add("Температура: "/* + status.TemperatureInCelsius*/);
                ListStatus.Items.Add("Настройки считывателя");
                ListStatus.Items.Add("--------------------");
                ListStatus.Items.Add("Режим: "/* + settings.ReaderMode*/);
                ListStatus.Items.Add("Режим поиска: "/* + settings.SearchMode*/);
                ListStatus.Items.Add("Сессия: "/* + settings.Session*/);
            }
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {

        }

        private void BtnDB_Click(object sender, EventArgs e)
        {
            Tables table = new Tables();
            table.ShowDialog();
        }
    }
}
