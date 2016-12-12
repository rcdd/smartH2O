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

            string XmlPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\App_Data\\log-sensors.xml";
            String strTemp = Encoding.UTF8.GetString(e.Message);
            XElement t = XElement.Parse(strTemp);

            Console.Write("Received msg: ");
            Console.WriteLine(t.Element("Name").Value);
            Console.WriteLine(t.Element("Value").Value);
            Console.WriteLine(t.Element("ID").Value);
            Console.WriteLine(t.Element("Date").Value);
            Console.WriteLine(t.Element("Time").Value+"\n\n");

            XmlDocument doc = new XmlDocument();
            
            if(!File.Exists(XmlPath))
            {
                XmlNode rootNode = doc.CreateElement("Sensors");
                doc.AppendChild(rootNode);
                writeOnLogFile(doc,rootNode,XmlPath, t);
            }else
            {
                doc.Load(XmlPath);
                XmlNode root = doc.DocumentElement;
                XmlNode myNode = root.SelectSingleNode("/Sensors");
                writeOnLogFile(doc, myNode, XmlPath, t);
            }
        }

        private static void writeOnLogFile(XmlDocument xmlDoc, XmlNode rootNode, string xmlPath, XElement t)
        {
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

            xmlDoc.Save(xmlPath);
        }
    }
}
