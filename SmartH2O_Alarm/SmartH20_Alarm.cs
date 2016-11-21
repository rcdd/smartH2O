using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Web;
using System.IO;

namespace SmartH2O_Alarm
{
    public partial class SmartH20_Alarm : Form
    {
        string XmlPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\App_Data\\trigger-rules.xml";
        public SmartH20_Alarm()
        {
            InitializeComponent();
            readXmlRules();
        }

        private void readXmlRules()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(XmlPath);
            // TODO

        }
    }
}
