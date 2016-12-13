using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml;

namespace SmartH2O_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string GetAllValues()
        {
            string XmlPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\App_Data\\log-sensors.xml";
            XmlDocument doc = new XmlDocument();
            if (File.Exists(XmlPath))
            { 
                doc.Load(XmlPath);
                XmlNodeList elemList = doc.GetElementsByTagName("sensor");
                for (int i = 0; i < elemList.Count; i++)
                {
                    Console.WriteLine(elemList[i].InnerXml);
                }
                return "I found the file!"+doc.Name;
            }else
            {
                return "File does not exists yet";
            }
        }
    }
}
