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
            //Console.Write(service.GetAllValues());

           /* Console.Write("Received msg: ");
            Console.WriteLine(t.Element("Name").Value);
            Console.WriteLine(t.Element("Value").Value);
            Console.WriteLine(t.Element("ID").Value);
            Console.WriteLine(t.Element("Date").Value);
            Console.WriteLine(t.Element("Time").Value+"\n\n");*/
        }
    }
}
