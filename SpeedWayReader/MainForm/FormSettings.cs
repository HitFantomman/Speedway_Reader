﻿using Impinj.OctaneSdk;
using Org.LLRP.LTK.LLRPV1;
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
        private ImpinjReader reader = new ImpinjReader();
        static LLRPClient readerR = new LLRPClient();
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
                // Включение максимальной мощности и чувствительности
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

        private void BtnDB_Click(object sender, EventArgs e)
        {
            Tables table = new Tables();
            table.ShowDialog();
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            Settings settings = reader.QuerySettings();
            if (BoxRead.Text=="AutoSetDenseReader");//settings.ReaderMode = ReaderMode.AutoSetDenseReader;(снять)
            if (BoxRead.Text=="AutoSetDenseReaderDeepScan");//settings.ReaderMode = ReaderMode.AutoSetDenseReaderDeepScan;(снять)
            if (BoxRead.Text=="AutoSetStaticDRM");//settings.ReaderMode = ReaderMode.AutoSetStaticDRM;(снять)
            if (BoxRead.Text=="AutoSetStaticFast");//settings.ReaderMode = ReaderMode.AutoSetStaticFast;(снять)
            if (BoxRead.Text=="DenseReaderM4");//settings.ReaderMode = ReaderMode.DenseReaderM4;(снять)
            if (BoxRead.Text=="DenseReaderM4Two");//settings.ReaderMode = ReaderMode.DenseReaderM4Two;(снять)
            if (BoxRead.Text=="DenseReaderM8");//settings.ReaderMode = ReaderMode.DenseReaderM8;(снять)
            if (BoxRead.Text=="Hybrid");//settings.ReaderMode = ReaderMode.Hybrid;(снять)
            if (BoxRead.Text=="MaxMiller");//settings.ReaderMode = ReaderMode.MaxMiller;(снять)
            if (BoxRead.Text=="MaxThroughput");//settings.ReaderMode = ReaderMode.MaxThroughput;(снять)
            if (BoxSearch.Text=="DualTarget");//settings.SearchMode = SearchMode.DualTarget;(снять)
            if (BoxSearch.Text=="DualTargetBtoASelect");//settings.SearchMode = SearchMode.DualTargetBtoASelect;(снять)
            if (BoxSearch.Text=="ReaderSelected");//settings.SearchMode = SearchMode.ReaderSelected;(снять)
            if (BoxSearch.Text=="SingleTarget");//settings.SearchMode = SearchMode.SingleTarget;(снять)
            if (BoxSearch.Text=="SingleTargetReset");//settings.SearchMode = SearchMode.SingleTargetReset;(снять)
            if (BoxSearch.Text=="TagFocus");//settings.SearchMode = SearchMode.TagFocus;(снять)
            //settings.Session = Convert.ToUInt16(BoxSession.Text);(снять)
        }
    }
}
