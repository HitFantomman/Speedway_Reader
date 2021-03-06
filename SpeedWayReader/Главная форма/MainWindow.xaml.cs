﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Impinj.OctaneSdk;
using System.Threading;
using Org.LLRP.LTK.LLRPV1;
using Org.LLRP.LTK.LLRPV1.DataType;
using Org.LLRP.LTK.LLRPV1.Impinj;
using System.Timers;

namespace Главная_форма
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ImpinjReader reader = new ImpinjReader();
        static LLRPClient readerR = new LLRPClient();
        static void Delete_RoSpec()
        {
            MSG_DELETE_ROSPEC msg = new MSG_DELETE_ROSPEC();
            msg.ROSpecID = 0;
            MSG_ERROR_MESSAGE msg_err;

            MSG_DELETE_ROSPEC_RESPONSE rsp =
            readerR.DELETE_ROSPEC(msg, out msg_err, 2000);
        }
        static void Add_RoSpec()
        {
            MSG_ERROR_MESSAGE msg_err;
            MSG_ADD_ROSPEC msg = new MSG_ADD_ROSPEC();

            // Reader Operation Spec (ROSpec)
            msg.ROSpec = new PARAM_ROSpec();
            // ROSpec должен быть по умолчанию не доступен
            msg.ROSpec.CurrentState = ENUM_ROSpecState.Disabled;
            // The ROSpec ID может получить числовой ID
            msg.ROSpec.ROSpecID = 123;
            // ROBoundarySpec
            // Specifies the start and stop triggers for the ROSpec
            msg.ROSpec.ROBoundarySpec = new PARAM_ROBoundarySpec();
            // Immediate start trigger
            // The reader will start reading tags as soon as the ROSpec
            // is enabled
            msg.ROSpec.ROBoundarySpec.ROSpecStartTrigger =
               new PARAM_ROSpecStartTrigger();
            msg.ROSpec.ROBoundarySpec.ROSpecStartTrigger
               .ROSpecStartTriggerType = ENUM_ROSpecStartTriggerType.Immediate;

            // No stop trigger. Keep reading tags until the ROSpec is disabled.
            msg.ROSpec.ROBoundarySpec.ROSpecStopTrigger =
               new PARAM_ROSpecStopTrigger();
            msg.ROSpec.ROBoundarySpec.ROSpecStopTrigger.ROSpecStopTriggerType =
               ENUM_ROSpecStopTriggerType.Null;

            // Antenna Inventory Spec (AISpec)
            // Specifies which antennas and protocol to use
            msg.ROSpec.SpecParameter = new UNION_SpecParameter();
            PARAM_AISpec aiSpec = new PARAM_AISpec();
            aiSpec.AntennaIDs = new UInt16Array();
            // Enable all antennas
            aiSpec.AntennaIDs.Add(0);
            // No AISpec stop trigger. It stops when the ROSpec stops.
            aiSpec.AISpecStopTrigger = new PARAM_AISpecStopTrigger();
            aiSpec.AISpecStopTrigger.AISpecStopTriggerType =
               ENUM_AISpecStopTriggerType.Null;
            aiSpec.InventoryParameterSpec =
               new PARAM_InventoryParameterSpec[1];
            aiSpec.InventoryParameterSpec[0] =
               new PARAM_InventoryParameterSpec();
            aiSpec.InventoryParameterSpec[0].InventoryParameterSpecID = 1234;
            aiSpec.InventoryParameterSpec[0].ProtocolID =
               ENUM_AirProtocols.EPCGlobalClass1Gen2;
            msg.ROSpec.SpecParameter.Add(aiSpec);

            // Report Spec
            msg.ROSpec.ROReportSpec = new PARAM_ROReportSpec();
            // Send a report for every tag read
            msg.ROSpec.ROReportSpec.ROReportTrigger =
               ENUM_ROReportTriggerType.Upon_N_Tags_Or_End_Of_ROSpec;
            msg.ROSpec.ROReportSpec.N = 1;
            msg.ROSpec.ROReportSpec.TagReportContentSelector =
               new PARAM_TagReportContentSelector();

            MSG_ADD_ROSPEC_RESPONSE rsp =
               readerR.ADD_ROSPEC(msg, out msg_err, 2000);
        }
        static void Enable_RoSpec()
        {
            MSG_ERROR_MESSAGE msg_err;
            MSG_ENABLE_ROSPEC msg = new MSG_ENABLE_ROSPEC();
            msg.ROSpecID = 1111;
            MSG_ENABLE_ROSPEC_RESPONSE rsp =
            readerR.ENABLE_ROSPEC(msg, out msg_err, 2000);
        }
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                // Вызов метода отображения информации с меток
                //reader.TagsReported += OnTagsReported;(снять)
            }
            catch (OctaneSdkException ex)
            {
                // Ошибка пакета Octane
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                // Ошибки программы
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateListbox(List<Tag> list)
        {
            // Вставка информации о метке в текущее время
            DateTime now = DateTime.Now;
            
            foreach (var tag in list)
            {
                listTags.Items.Add(listTags.Items.Count + ") EPC: " + tag.Epc + "\n   Номер антенны: " + tag.AntennaPortNumber + "\n   Дата и время: " + now);
            }
        }

        private void OnTagsReported(ImpinjReader sender, TagReport report)
        {
            // Это событие которое обнавляет информацию в ListBox со считывателя во время считывания.
            //Action action = delegate()(снять)
            //{(снять)
            //    UpdateListbox(report.Tags);(снять)
            //};(снять)
            //Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, action);(снять)
        }

        private static System.Timers.Timer aTimer;

        private void UpdateListah()
        {
            DateTime now = DateTime.Now;
            Random Ran = new Random();
            long Epc = Ran.Next() + 999999999999999;
            int AntennaPortNumber = Ran.Next(1, 2);
            listTags.Items.Add(listTags.Items.Count + ") EPC: " + Epc + "\n   Номер антенны: " + AntennaPortNumber + "\n   Дата и время: " + now);
        }

        private void SetTimer()
        {
            aTimer = new System.Timers.Timer(2000);
            // Hook up the Elapsed event for the timer.
            //aTimer.Elapsed += UpdateListah();
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            ButtonStart.IsEnabled = false;
            ButtonStop.IsEnabled = true;
            listTags.IsEnabled = true;
            SetTimer();
            try
            {
                // Подготовка к считыванию
                //if (!reader.QueryStatus().IsSingulating)(снять)
                //{(снять)
                //    // Старт считывания
                //    reader.Start();(снять)
                //    Add_RoSpec();(снять)
                //    Enable_RoSpec();(снять)
                //}(снять)
            }
            catch (OctaneSdkException ex)
            {
                // Ошибки пакета Octane
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                // Ошибки программы
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonStop_Click(object sender, RoutedEventArgs e)
        {
            ButtonStart.IsEnabled = true;
            ButtonStop.IsEnabled = false;
            aTimer.Close();
            try
            {
                // Отключение считывания считывателя
                //if (reader.QueryStatus().IsSingulating)(снять)
                //{(снять)
                //    Delete_RoSpec();(снять)
                //    reader.Stop();(снять)
                //}(снять)
            }
            catch (OctaneSdkException ex)
            {
                // Ошибки пакета Octane
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                // Ошибки программы
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            listTags.Items.Clear();
        }

        private void ButtonConnect_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                // Подключение к считывателю.
                // Подключение по введенному IP или имени  считывателя
                //string hostname = Convert.ToString(TextIP.Text);(снять)
                //reader.Connect(hostname);//(снять)
                if (true)//reader.IsConnected(заменить на true)
                {
                    MessageBox.Show("Считыватель подключен!");
                    ButtonStart.IsEnabled = true;
                    listTags.IsEnabled = true;
                    ButtonSettings.IsEnabled = true;
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
                }
                
            }
            catch (OctaneSdkException ex)
            {
                // Ошибка пакета Octane
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                // Ошибки программы
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            if (true)//reader.IsConnected(заменить на true)
            {
                try
                {
                    // Отключение считывания считывателя
                    //if (reader.QueryStatus().IsSingulating)(снять)
                    //{(снять)
                    //    Delete_RoSpec();(снять)
                    //    reader.Stop();(снять)
                    //}(снять)
                    // Отсоединение от считывателя
                    //reader.Disconnect();(снять)
                }
                catch (OctaneSdkException ex)
                {
                    // Ошибки пакета Octane
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    // Ошибки программы
                    MessageBox.Show(ex.Message);
                }
            }
            Close();
        }

        private void ButtonSettings_Click(object sender, RoutedEventArgs e)
        {
            //FeatureSet features = reader.QueryFeatureSet();
            //Status status = reader.QueryStatus();
            //Settings settings = reader.QuerySettings();
            MessageBox.Show("Функции считывателя\n--------------------\n" +
                "Модель: "/* + features.ModelName*/ + "\n" +
                "Номер модели: "/* + features.ModelNumber*/ + "\n" +
                "Версия прошивки: "/* + features.FirmwareVersion*/ + "\n" +
                "Количество антенн: "/* + features.AntennaCount*/ + "\n\n" +
                "Статус считывателя\n--------------------\n" +
                "Статус подключения: "/* + status.IsConnected*/ + "\n" +
                "Singulation: "/* + status.IsSingulating*/ + "\n" +
                "Температура: "/* + status.TemperatureInCelsius*/ + "\n\n" +
                "Настройки считывателя\n--------------------\n" +
                "Режим: "/* + settings.ReaderMode*/ + "\n" +
                "Режим поиска: "/* + settings.SearchMode*/ + "\n" +
                "Сессия: "/* + settings.Session*/);
        }

        private void ButtonDisconnect_Click(object sender, RoutedEventArgs e)
        {
            //reader.Disconnect();(снять)
            ButtonStart.IsEnabled = false;
            listTags.IsEnabled = false;
            ButtonSettings.IsEnabled = false;
            MessageBox.Show("Считыватель отключен!");
        }
    }
}
