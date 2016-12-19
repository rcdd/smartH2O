using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

// send to web service http://stackoverflow.com/questions/17535872/http-post-xml-data-in-c-sharp

namespace SmartH2O_DLog
{
    class Program
    {
        static bool xmlValid = true;
        static string strXmlErrorReason;
        static string XmlPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "..\\..\\SmartH2O_Service\\App_Data\\log-sensors.xml";
        static string xsdPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "..\\..\\SmartH2O_Service\\App_Data\\log-sensors.xsd";
        //private static XmlDocument doc = new XmlDocument();
        static void Main(string[] args)
        {
            MqttClient client = new MqttClient("host.dynip.sapo.pt", 21, false, null, null, MqttSslProtocols.None);
            client.Connect(Guid.NewGuid().ToString(), "isuser", "is2016");
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
            String strTemp = Encoding.UTF8.GetString(e.Message);
            XElement t = XElement.Parse(strTemp);

            ServiceLog.ServiceLogClient service = new ServiceLog.ServiceLogClient();
            Console.Write(service.SendValues(strTemp));
            Console.Write(service.GetAllValues());
           /* Console.Write("Received msg: ");
            Console.WriteLine(t.Element("Name").Value);
            Console.WriteLine(t.Element("Value").Value);
            Console.WriteLine(t.Element("ID").Value);
            Console.WriteLine(t.Element("Date").Value);
            Console.WriteLine(t.Element("Time").Value+"\n\n");*/

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

        private static void validateXML(Object sender, ValidationEventArgs args)
        {
            xmlValid = false;
            strXmlErrorReason = args.Message;
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

            //VALIDATION
            xmlDoc.Schemas.Add(null, xsdPath);
            ValidationEventHandler eventHandler = new ValidationEventHandler(validateXML);
            xmlDoc.Validate(eventHandler);
            if (xmlValid)
            {
                Console.Write("XML Status: OK!\n\n");
            }
            else
            {
                throw new XmlException(strXmlErrorReason.ToString());
            }

           // ServiceLog.ServiceLogClient service = new ServiceLog.ServiceLogClient();

            //Console.Write(service.SendValues(xmlDoc.InnerText));
            xmlDoc.Save(xmlPath);
        }
    }
}
