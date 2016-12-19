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
                string ID="";
                string Value="";
                string Desc="";
                int i=0;
                foreach (string word in words)
                {
                    if (i == 0)
                    {
                        ID = word;
                    }else if(i == 1)
                    {
                        Desc = word;
                    }else
                    {
                        Value = word;
                    }
                    i++;
                }
                XElement element = new XElement("Sensor", new XElement("ID", ID), new XElement("Name", Desc), new XElement("Value", Value), new XElement("Time", DateTime.Now.ToString("HH:mm:ss")), new XElement("Date", DateTime.Now.ToString("dd/MM/yyyy")));
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
                //Console.WriteLine(v);
                client.Publish("SensorValues", Encoding.UTF8.GetBytes(v));
            }
        }
    }
}
