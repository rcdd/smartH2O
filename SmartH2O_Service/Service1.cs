using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml;
using System.Xml.Linq;

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
            LinkedList<XElement> sensors = new LinkedList<XElement>();
            if (File.Exists(XmlPath))
            {
                doc.Load(XmlPath);

               /* XmlNode root = doc.FirstChild;

                StringBuilder sb = new StringBuilder();

                if (root.HasChildNodes)
                {
                    for (int i = 0; i < root.ChildNodes.Count; i++)
                    {
                        sb.Append(root.ChildNodes[i].InnerText+"\n");
                    }
                }*/

                return doc.InnerXml;
            }
            else
            {
                return "File does not exists yet";
            }
        }
    }
}
