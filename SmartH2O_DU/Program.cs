using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using uPLibrary.Networking.M2Mqtt;

namespace SmartH2O_DU
{
    class Program
    {
        static void Main(string[] args)
        {
            SensorNodeDll.SensorNodeDll dll = new SensorNodeDll.SensorNodeDll();
            dll.Initialize(DllValues, 5000);
        }

        private static void DllValues(string message)
        {
            if (message != null)
            {
                string[] words = message.Split(';');
                DateTime now = DateTime.Now;
                XElement element = new XElement("Sensor", 
                    new XElement("ID", words[0]), 
                    new XElement("Name", words[1]), 
                    new XElement("Value", words[2]), 
                    new XElement("Time", now.ToString("HH:mm:ss")), 
                    new XElement("Date", now.ToString("dd/MM/yyyy")), 
                    new XElement("TimeStamp", ConvertToUnixTimestamp(now)));

                Console.WriteLine(element);
                publish(element.ToString());
            }
        }

        private static void publish(string v)
        {
            MqttClient client = new MqttClient("host.dynip.sapo.pt", 21,false, null, null, MqttSslProtocols.None);
            client.Connect(Guid.NewGuid().ToString(), "isuser", "is2016");
            if (client.IsConnected)
            {
                Console.WriteLine(v);
                client.Publish("SensorValues", Encoding.UTF8.GetBytes(v));
            }
        }

        public static double ConvertToUnixTimestamp(DateTime date)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan diff = date.ToUniversalTime() - origin;
            return Math.Floor(diff.TotalSeconds);
        }

        //To Inverse Timestamp
        public static DateTime ConvertFromUnixTimestamp(double timestamp)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            return origin.AddSeconds(timestamp);
        }
    }
}
