using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.LLRP.LTK.LLRPV1;
using Org.LLRP.LTK.LLRPV1.DataType;
using Org.LLRP.LTK.LLRPV1.Impinj;

namespace RoSpec
{
    class Program
    {
        static void Delete_RoSpec()
        {
            MSG_DELETE_ROSPEC msg = new MSG_DELETE_ROSPEC();
            msg.ROSpecID = 0;
            MSG_ERROR_MESSAGE msg_err;

            MSG_DELETE_ROSPEC_RESPONSE rsp =
            reader.DELETE_ROSPEC(msg, out msg_err, 2000);

            if (rsp != null)
            {
                // Success
                Console.WriteLine(rsp.ToString());
            }
            else if (msg_err != null)
            {
                // Error
                Console.WriteLine(msg_err.ToString());
            }
            else
            {
                // Timeout
                Console.WriteLine("Timeout Error.");
            }
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
              reader.ADD_ROSPEC(msg, out msg_err, 2000);
           if (rsp != null)
           {
              // Success
              Console.WriteLine (rsp.ToString());
           }
           else if (msg_err != null)
           {
              // Error
              Console.WriteLine (msg_err.ToString());
           }
           else
           {
              // Timeout
              Console.WriteLine("Timeout Error.");
           }
        }
        static void Enable_RoSpec()
        {
           MSG_ERROR_MESSAGE msg_err;
           MSG_ENABLE_ROSPEC msg = new MSG_ENABLE_ROSPEC();
           msg.ROSpecID = 123;
           MSG_ENABLE_ROSPEC_RESPONSE rsp =
           reader.ENABLE_ROSPEC(msg, out msg_err, 2000);
           if (rsp != null)
           {
              // Success
              Console.WriteLine (rsp.ToString());
           }
           else if (msg_err != null)
           {
              // Error
              Console.WriteLine (msg_err.ToString());
           }
           else
           {
              // Timeout
              Console.WriteLine("Timeout Error.");
           }
        }
        static void OnReportEvent(MSG_RO_ACCESS_REPORT msg)
        {
           // Loop through all the tags in the report
           for (int i = 0; i < msg.TagReportData.Length; i++)
           {
              if (msg.TagReportData[i].EPCParameter.Count > 0)
              {
                 string epc;
                 // Two possible types of EPC: 96-bit and 128-bit
                 if (msg.TagReportData[i].EPCParameter[0].GetType() ==
                    typeof(PARAM_EPC_96))
                 {
                    epc = ((PARAM_EPC_96)
                       (msg.TagReportData[i].EPCParameter[0]))
                          .EPC.ToHexString();
                 }
                 else
                 {
                    epc = ((PARAM_EPCData)
                       (msg.TagReportData[i].EPCParameter[0]))
                          .EPC.ToHexString();
                 }
                 Console.WriteLine("epc = " + epc);
              }
           }
        }
        static LLRPClient reader;
        static void Main(string[] args)
        {
           // Create a LLRPClient instance.
           reader = new LLRPClient();
 
           /*
              Connect to the reader.
              Replace "SpeedwayR-10-25-32" with your reader's hostname.
              The second argument (2000) is a timeout value in milliseconds.
              If a connection cannot be established within this timeframe,
              the call will fail.
           */
           ENUM_ConnectionAttemptStatusType status;
           reader.Open("192.168.88.32", 2000, out status);
 
           // Check for a connection error
           if (status != ENUM_ConnectionAttemptStatusType.Success)
           {
              // Could not connect to the reader.
              // Print out the error
              Console.WriteLine(status.ToString());
              // Do something here.
              // Your application should not continue.
              return;
           }
 
           /*
              If you successfully connect to the reader, the next step is to
              create a delegate. The delegate determines which function gets
              called when a report event occurs.
           */
           reader.OnRoAccessReportReceived += new
           delegateRoAccessReport(OnReportEvent);
 
           // Send the messages
           //Delete_RoSpec();
           Add_RoSpec();
           Enable_RoSpec();
 
           // Keep reading tags until the user presses return
           //Console.ReadLine();
 
           // Cleanup the reader by deleting the ROSpec
           //Delete_RoSpec();
           Console.ReadKey();
        }
    }
}
