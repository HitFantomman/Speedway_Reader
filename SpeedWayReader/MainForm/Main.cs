using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Impinj.OctaneSdk;
using Org.LLRP.LTK.LLRPV1;
using Org.LLRP.LTK.LLRPV1.DataType;
using Org.LLRP.LTK.LLRPV1.Impinj;

namespace MainForm
{
    public partial class Main : Form
    {
        public Main()
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

        private void UpdateListbox(List<Tag> list)
        {
            // Вставка информации о метке в текущее время
            DateTime now = DateTime.Now;
            
            foreach (var tag in list)
            {
                ListTags.Items.Add(ListTags.Items.Count + ") EPC: " + tag.Epc + "\n   Номер антенны: " + tag.AntennaPortNumber + "\n   Дата и время: " + now);
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

        int counter = 1;
        private void UpdateListah()
        {
            DateTime now = DateTime.Now;
            Random Ran = new Random();
            long Epc = Ran.Next(100000000, 500000000) + Ran.Next(100000000, 500000000);
            string machine = "а" + Convert.ToString(Ran.Next(100, 1000)) + "бв";
            int AntennaPortNumber = Ran.Next(1, 3);
            bool visit=new bool();
            visit=Convert.ToBoolean(Ran.Next(0, 2));
            string avisit;
            if (visit==true) avisit="Разрешено";
            else avisit="Не разрешено";
            string tvisit;
            if (AntennaPortNumber == 1) tvisit = "Въезд";
            else tvisit = "Выезд";
            //if (bdRFIDDataSet.RFID_metka.EpcColumn.Caption==EPC.)
            //{
                
            //}
            ListTags.Items.Add(counter + ") Дата и время: " + now + "\n   Номер антенны: " + AntennaPortNumber);
            counter += 1;
            ListTags.Items.Add("\n   EPC: " + Epc + "\n   № машины: " + machine + "\n   Тип проезда: " + tvisit + "\n   Доступ: " + avisit);
            //GridTags.Rows.(GridTags.Rows.GetNextRow, now, Epc, 0, AntennaPortNumber);
            if (visit == false)
            {
                TimerTags.Enabled = false;
                MessageBox.Show("Машине на проезде въезд/выезд запрещен!!!");
                TimerTags.Enabled = true;
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            ButtonStart.Enabled = false;
            ButtonStop.Enabled = true;
            ListTags.Enabled = true;
            Random rand = new Random();
            TimerTags.Enabled = true;
            TimerTags.Interval = rand.Next(1000, 5000);
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

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            ButtonStart.Enabled = true;
            ButtonStop.Enabled = false;
            TimerTags.Enabled = false;
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

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ListTags.Items.Clear();
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
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
                    ButtonStart.Enabled = true;
                    ListTags.Enabled = true;
                    ButtonSettings.Enabled = true;
                    ButtonClear.Enabled = true;
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

        private void ButtonClose_Click(object sender, EventArgs e)
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
                    Application.Exit();
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
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
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

        private void ButtonDisconnect_Click(object sender, EventArgs e)
        {
            //reader.Disconnect();(снять)
            ButtonStart.Enabled = false;
            ButtonStop.Enabled = false;
            ListTags.Enabled = false;
            ButtonSettings.Enabled = false;
            ButtonClear.Enabled = false;
            TimerTags.Enabled = false;
            MessageBox.Show("Считыватель отключен!");
        }

        private void TimerTags_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            UpdateListah();
        }

        private void ButtonBD_Click(object sender, EventArgs e)
        {
            TimerTags.Enabled = false;
            AccessBD BDaccess = new AccessBD();
            BDaccess.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
