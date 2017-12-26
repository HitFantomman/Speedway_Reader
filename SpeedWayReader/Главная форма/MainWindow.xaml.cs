using System;
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
            // ROSpec must be disabled by default
            msg.ROSpec.CurrentState = ENUM_ROSpecState.Disabled;
            // The ROSpec ID can be set to any number
            // You must use the same ID when enabling this ROSpec
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
                // Assign the TagsReported event handler.
                // This specifies which method to call
                // when tags reports are available.
                // This method will in turn call a delegate 
                // to update the UI (Listbox).
                reader.TagsReported += OnTagsReported;
            }
            catch (OctaneSdkException ex)
            {
                // An Octane SDK exception occurred. Handle it here.
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                // A general exception occurred. Handle it here.
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateListbox(List<Tag> list)
        {
            // Loop through each tag is the list and add it to the Listbox.
            DateTime now = DateTime.Now;
            
            foreach (var tag in list)
            {
                listTags.Items.Add(listTags.Items.Count + ") EPC: " + tag.Epc + "\n   Номер антенны: " + tag.AntennaPortNumber + "\n   Дата и время: " + now);
            }
        }

        private void OnTagsReported(ImpinjReader sender, TagReport report)
        {
            // This event handler gets called when a tag report is available.
            // Since it is executed in a different thread, we cannot operate
            // directly on UI elements (the Listbox) in this method.
            // We must execute another method (UpdateListbox) on the main thread
            // using BeginInvoke. We will pass updateListbox a List of tags.
            Action action = delegate()
            {
                UpdateListbox(report.Tags);
            };

            Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, action);
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            ButtonStart.IsEnabled = false;
            ButtonStop.IsEnabled = true;
            listTags.IsEnabled = true;
            try
            {
                // Don't call the Start method if the
                // reader is already running.
                if (!reader.QueryStatus().IsSingulating)
                {
                    // Start reading.
                    reader.Start();
                    Add_RoSpec();
                    Enable_RoSpec();
                }
            }
            catch (OctaneSdkException ex)
            {
                // An Octane SDK exception occurred. Handle it here.
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                // A general exception occurred. Handle it here.
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonStop_Click(object sender, RoutedEventArgs e)
        {
            ButtonStart.IsEnabled = true;
            ButtonStop.IsEnabled = false;
            try
            {
                // Don't call the Stop method if the
                // reader is already stopped.
                if (reader.QueryStatus().IsSingulating)
                {
                    reader.Stop();
                    Delete_RoSpec();
                }
            }
            catch (OctaneSdkException ex)
            {
                // An Octane SDK exception occurred. Handle it here.
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                // A general exception occurred. Handle it here.
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
                // Connect to the reader.
                // Pass in a reader hostname or IP address as a 
                // command line argument when running the example
                string hostname = Convert.ToString(TextIP.Text);
                reader.Connect(hostname);
                if (reader.IsConnected)
                {
                    MessageBox.Show("Считыватель подключен!");
                    ButtonStart.IsEnabled = true;
                    listTags.IsEnabled = true;
                    ButtonClear.IsEnabled = true;
                    ButtonSettings.IsEnabled = true;
                    // Получение настроек по умолчанию со считывателя
                    Settings settings = reader.QueryDefaultSettings();
                    // Подключение антенны
                    settings.Report.IncludeAntennaPortNumber = true;
                    settings.ReaderMode = ReaderMode.AutoSetDenseReader;
                    settings.SearchMode = SearchMode.SingleTarget;
                    settings.Session = 3;

                    // Enable antenna #1. Disable all others.
                    settings.Antennas.EnableAll();

                    // Set the Transmit Power and 
                    // Receive Sensitivity to the maximum.
                    settings.Antennas.TxPowerMax = true;
                    settings.Antennas.RxSensitivityMax = true;
                    // Apply the newly modified settings.
                    reader.ApplySettings(settings);
                }
                
            }
            catch (OctaneSdkException ex)
            {
                // An Octane SDK exception occurred. Handle it here.
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                // A general exception occurred. Handle it here.
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            if (reader.IsConnected)
            {
                try
                {
                    // Don't call the Stop method if the
                    // reader is already stopped.
                    if (reader.QueryStatus().IsSingulating)
                    {
                        Delete_RoSpec();
                        reader.Stop();
                    }
                    // Disconnect from the reader.
                    reader.Disconnect();
                }
                catch (OctaneSdkException ex)
                {
                    // An Octane SDK exception occurred. Handle it here.
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    // A general exception occurred. Handle it here.
                    MessageBox.Show(ex.Message);
                }
            }
            Close();
        }

        private void ButtonSettings_Click(object sender, RoutedEventArgs e)
        {
            FeatureSet features = reader.QueryFeatureSet();
            Status status = reader.QueryStatus();
            Settings settings = reader.QuerySettings();
            MessageBox.Show("Функции считывателя\n--------------------\n" +
                "Модель: " + features.ModelName + "\n" +
                "Номер модели: " + features.ModelNumber + "\n" +
                "Версия прошивки: " + features.FirmwareVersion + "\n" +
                "Количество антенн: " + features.AntennaCount + "\n\n" +
                "Статус считывателя\n--------------------\n" +
                "Статус подключения: " + status.IsConnected + "\n" +
                "Singulation: " + status.IsSingulating + "\n" +
                "Температура: " + status.TemperatureInCelsius + "\n\n" +
                "Настройки считывателя\n--------------------\n" +
                "Режим: " + settings.ReaderMode + "\n" +
                "Режим поиска: " + settings.SearchMode + "\n" +
                "Сессия: " + settings.Session);
        }
    }
}
