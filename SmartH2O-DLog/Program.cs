using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace SmartH2O_DLog
{
    class Program
    {
        //private static XmlDocument doc = new XmlDocument();
        static void Main(string[] args)
        {

            MqttClient client = new MqttClient("127.0.0.1");
            client.Connect(Guid.NewGuid().ToString());
            if (client.IsConnected)
            {
                //Subscribe
                string[] m_strTopicsInfo = new string[1];
                m_strTopicsInfo[0] = "SensorValues";
                client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
                byte[] qosLevels = { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE };
                client.Subscribe(m_strTopicsInfo, qosLevels);
            }
            else
            {
                Console.Write("Error connecting to message broker...");
                return;
            }
            
        }

        private static void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {

            //Console.WriteLine("Received = " + Encoding.UTF8.GetString(e.Message) + " on topic " + e.Topic);
            String strTemp = Encoding.UTF8.GetString(e.Message);
            XElement t = XElement.Parse(strTemp);

            Console.Write("Received msg: "/*+ strTemp*/);
            Console.WriteLine(t.Element("Name").Value);
            Console.WriteLine(t.Element("Value").Value);
            Console.WriteLine(t.Element("ID").Value);
            Console.WriteLine(t.Element("Date").Value);
            Console.WriteLine(t.Element("Time").Value+"\n\n");

            XmlDocument doc = new XmlDocument();
            

            if(!File.Exists(@"C:\\Users\\rpbeat\\Desktop\\EngenhariaInformatica_3ano\\document.xml"))
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlNode rootNode = xmlDoc.CreateElement("Sensores");
                xmlDoc.AppendChild(rootNode);

                XmlElement sensor = xmlDoc.CreateElement("Sensor");
                rootNode.AppendChild(sensor);

                XmlNode nameNode = xmlDoc.CreateElement("Name");
                nameNode.InnerText = t.Element("Name").Value;
                sensor.AppendChild(nameNode);

                XmlNode valueNode = xmlDoc.CreateElement("Value");
                valueNode.InnerText = t.Element("Name").Value;
                sensor.AppendChild(valueNode);

                XmlNode idNode = xmlDoc.CreateElement("ID");
                valueNode.InnerText = t.Element("ID").Value;
                sensor.AppendChild(valueNode);

                XmlNode dateNode = xmlDoc.CreateElement("Date");
                dateNode.InnerText = t.Element("Date").Value;
                sensor.AppendChild(dateNode);

                XmlNode timeNode = xmlDoc.CreateElement("Time");
                timeNode.InnerText = t.Element("Time").Value;
                sensor.AppendChild(timeNode);

                xmlDoc.Save(@"C:\\Users\\rpbeat\\Desktop\\EngenhariaInformatica_3ano\\document.xml");
            }else
            {
                doc.Load(@"C:\\Users\\rpbeat\\Desktop\\EngenhariaInformatica_3ano\\document.xml");

                XmlNode root = doc.DocumentElement;
                XmlNode myNode = root.SelectSingleNode("/Sensores");

                XmlElement sensor = doc.CreateElement("Sensor");
                myNode.AppendChild(sensor);

                XmlNode nameNode = doc.CreateElement("Name");
                nameNode.InnerText = t.Element("Name").Value;
                sensor.AppendChild(nameNode);

                XmlNode valueNode = doc.CreateElement("Value");
                valueNode.InnerText = t.Element("Name").Value;
                sensor.AppendChild(valueNode);

                XmlNode idNode = doc.CreateElement("ID");
                valueNode.InnerText = t.Element("ID").Value;
                sensor.AppendChild(valueNode);

                XmlNode dateNode = doc.CreateElement("Date");
                dateNode.InnerText = t.Element("Date").Value;
                sensor.AppendChild(dateNode);

                XmlNode timeNode = doc.CreateElement("Time");
                timeNode.InnerText = t.Element("Time").Value;
                sensor.AppendChild(timeNode);

                doc.Save("C:\\Users\\rpbeat\\Desktop\\EngenhariaInformatica_3ano\\document.xml");
            }
        }
    }
}
