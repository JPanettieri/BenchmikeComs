//using System;
//using System.Collections.Generic;
//using System.IO.Ports;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BenchmikeComs
//{
//    public class Serial
//    {

//        public SerialPort SetSerial(string com, int baud, int dataBits)
//            {
//                SerialPort port = new SerialPort(
//                    com,
//                    baud,
//                    Parity.None,
//                    dataBits,
//                    StopBits.One);  
//                return port;
//            }

//            public Serial()
//            {
//                Console.WriteLine("Incoming Data:");
//            SerialPort port = SetSerial("COM2", 19200, 8);
//                // Attach a method to be called when there
//                // is data waiting in the port's buffer
//                port.DataReceived += new
//                  SerialDataReceivedEventHandler(port_DataReceived);

//                // Begin communications
//                port.Open();

//            }

//            public void port_DataReceived(object sender,
//              SerialDataReceivedEventArgs e)
//            {
//            SerialPort port = SetSerial("COM2", 19200, 8);
//            // Show all the incoming data in the port's buffer
//            Console.WriteLine(port.ReadExisting());
//            }
//        }
//    }