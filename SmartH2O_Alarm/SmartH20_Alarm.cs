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
using System.Runtime.Serialization;
using System.Xml.Schema;
using System.Threading;
using System.Globalization;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Xml.Linq;

namespace SmartH2O_Alarm
{
    public partial class SmartH20_Alarm : Form
    {

        string xmlPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\App_Data\\trigger-rules.xml";
        string xsdPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\App_Data\\trigger-rules.xsd";
        LinkedList<Sensor> sensorList = new LinkedList<Sensor>();
        MqttClient client;
        static bool xmlValid = true;
        static string strXmlErrorReason;
        string[] m_strTopicsInfo = new string[1] { "SensorValues" };

        public SmartH20_Alarm()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            InitializeComponent();
            readXmlRules();

            
            //connect to mosquito
            client = new MqttClient("host.dynip.sapo.pt", 21, false, null, null, MqttSslProtocols.None);
            client.Connect(Guid.NewGuid().ToString(), "isuser", "is2016");
            if (client.IsConnected)
            {
                //Subscribe
                client.MqttMsgPublishReceived += readSensors;
                byte[] qosLevels = { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE };
                client.Subscribe(m_strTopicsInfo, qosLevels);
            }
            else
            {
                Console.Write("Error connecting to message broker...");
                return;
            }


            //populate listView
            foreach (Sensor sensor in sensorList)
            {
                listBoxSensors.Items.Add(sensor.name);
            }

            if (!checkBoxActivate.Checked) groupBox1.Enabled = false; else groupBox1.Enabled = true;

            if (!checkBoxEq.Checked) groupBox2.Enabled = false; else groupBox2.Enabled = true;

            if (!checkBoxGr.Checked) groupBox3.Enabled = false; else groupBox3.Enabled = true;

            if (!checkBoxLs.Checked) groupBox4.Enabled = false; else groupBox4.Enabled = true;
            
            if (!checkBoxBT.Checked) groupBox5.Enabled = false; else groupBox5.Enabled = true;

        }



        private void readSensors(object sender, MqttMsgPublishEventArgs e)
        {
            String strTemp = Encoding.UTF8.GetString(e.Message);
            XElement t = XElement.Parse(strTemp);
            float value = 0;
            String sensorName = t.Element("Name").Value;

            foreach (Sensor s in sensorList)
            {
                if (s.name.Equals(sensorName) && s.status == 1)
                {
                    try
                    {
                        value = float.Parse(t.Element("Value").Value, CultureInfo.GetCultureInfo("en-US"));

                        if (s.eqStatus == 1 && value == s.eqVal)
                        {
                            publishAlarm(t, "Equal " + s.eqVal);
                        }
                        if (s.lsStatus == 1 && value <= s.lsVal)
                        {
                            publishAlarm(t, "Less " + s.lsVal);
                        }
                        if (s.grStatus == 1 && value >= s.grVal)
                        {
                            publishAlarm(t, "Greate " + s.grVal);
                        }

                        if (s.btStatus == 1 && (value >= s.btMin && value <= s.btMax))
                        {
                            publishAlarm(t, "Between " + s.btMin + " and " + s.btMax);
                        }
                    }
                    catch (Exception)
                    {
                        throw new Exception("Parse element to string error!");
                    }
                }
            }

        }

        private void publishAlarm(XElement x, String type)
        {
            XElement element = new XElement("Sensor", new XElement("ID", x.Element("ID").Value), 
                new XElement("Name", x.Element("Name").Value), 
                new XElement("Value", x.Element("Value").Value), 
                new XElement("Time", x.Element("Time").Value), 
                new XElement("Date", x.Element("Date").Value),
                new XElement("TimeStamp", x.Element("TimeStamp").Value),
                new XElement("Alarm", type));

            if (client.IsConnected)
            {
                Console.WriteLine(element);
                client.Publish("Alarms", Encoding.UTF8.GetBytes(element.ToString()));
            }
        }

        private void readXmlRules()
        {
            if (!File.Exists(xmlPath))
            {
                MessageBox.Show("No config file found - Created a template file!");
                createXmlTemplate();
            }

            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(xmlPath);
                //VALIDATION
                doc.Schemas.Add(null, xsdPath);
                ValidationEventHandler eventHandler = new ValidationEventHandler(validateXML);
                doc.Validate(eventHandler);
                if (xmlValid)
                {
                    Console.Write("XML Status: OK!");
                }
                else
                {
                    throw new XmlException(strXmlErrorReason.ToString());
                }
            }
            catch (XmlException ex)
            {
                DialogResult ans = MessageBox.Show("Invalid XML File! Error: " + ex.Message + "\n\nDo want continue with new template XML file?", "ERROR - XML Status", MessageBoxButtons.YesNo);
                if (ans == DialogResult.Yes)
                {
                    ans = MessageBox.Show("You will lost your old configurations, are you sure?", "ATENTION: ALL DATA WILL BE LOST!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (ans == DialogResult.Yes)
                    {
                        //delete incorrect template file
                        File.Delete(xmlPath);
                        xmlValid = true;
                        readXmlRules();
                        return;
                    }
                }
                Environment.Exit(1);
            }

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                string name = node.Attributes["name"]?.InnerText;
                Sensor sensor = new Sensor(name);
                //Console.WriteLine("Name Sensor: " + name);
                string path = "/SmartH2O/sensor[@name = '"+name+"']/";

                //Console.WriteLine("Eq Val: " + node.SelectSingleNode(path + "triggers/equal/value").InnerText.ToString());
                sensor.eqVal = float.Parse(node.SelectSingleNode(path + "triggers/equal/value").InnerText.ToString());
                //Console.WriteLine("Eq Status: " + node.SelectSingleNode(path + "triggers/equal/status").InnerText.ToString());
                sensor.eqStatus = int.Parse(node.SelectSingleNode(path + "triggers/equal/status").InnerText.ToString());

                //Console.WriteLine("Gr Val: " + node.SelectSingleNode(path + "triggers/greater/value").InnerText.ToString());
                sensor.grVal = float.Parse(node.SelectSingleNode(path + "triggers/greater/value").InnerText.ToString());
                //Console.WriteLine("Gr Status: " + node.SelectSingleNode(path + "triggers/greater/status").InnerText.ToString());
                sensor.grStatus = int.Parse(node.SelectSingleNode(path + "triggers/greater/status").InnerText.ToString());

                //Console.WriteLine("Ls Val: " + node.SelectSingleNode(path + "triggers/less/value").InnerText.ToString());
                sensor.lsVal = float.Parse(node.SelectSingleNode(path + "triggers/less/value").InnerText.ToString());
                //Console.WriteLine("Ls Status: " + node.SelectSingleNode(path + "triggers/less/status").InnerText.ToString());
                sensor.lsStatus = int.Parse(node.SelectSingleNode(path + "triggers/less/status").InnerText.ToString());

                //Console.WriteLine("Bt max: " + node.SelectSingleNode(path + "triggers/between/valueMax").InnerText.ToString());
                sensor.btMax = float.Parse(node.SelectSingleNode(path + "triggers/between/valueMax").InnerText.ToString());
                //Console.WriteLine("Bt min: " + node.SelectSingleNode(path + "triggers/between/valueMin").InnerText.ToString());
                sensor.btMin = float.Parse(node.SelectSingleNode(path + "triggers/between/valueMin").InnerText.ToString());
                //Console.WriteLine("Bt Status: " + node.SelectSingleNode(path + "triggers/between/status").InnerText.ToString());
                sensor.btStatus = int.Parse(node.SelectSingleNode(path + "triggers/between/status").InnerText.ToString());

                //Console.WriteLine("Sensor status: " + node.SelectSingleNode(path + "/status").InnerText.ToString());
                sensor.status = int.Parse(node.SelectSingleNode(path + "status").InnerText.ToString());

                sensorList.AddLast(sensor);
            }
        }

        private static void validateXML(Object sender, ValidationEventArgs args)
        {
            xmlValid = false;
            strXmlErrorReason = args.Message;
        }

        private void comboBoxSensors_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sensor sensor = sensorList.ElementAt(listBoxSensors.SelectedIndex);

            //populate fields
            checkBoxActivate.Enabled = true;
            labelSensorName.Text = sensor.name;
            if (sensor.status == 1) checkBoxActivate.Checked = true; else checkBoxActivate.Checked = false;

            if (sensor.eqStatus == 1) checkBoxEq.Checked = true; else checkBoxEq.Checked = false;
            textBoxValueEQ.Text = sensor.eqVal.ToString();
            if (sensor.grStatus == 1) checkBoxGr.Checked = true; else checkBoxGr.Checked = false;
            textBoxValueGR.Text = sensor.grVal.ToString();
            if (sensor.lsStatus == 1) checkBoxLs.Checked = true; else checkBoxLs.Checked = false;
            textBoxValueLS.Text = sensor.lsVal.ToString();
            if (sensor.btStatus == 1) checkBoxBT.Checked = true; else checkBoxBT.Checked = false;
            textBoxBTMax.Text = sensor.btMax.ToString();
            textBoxBTMin.Text = sensor.btMin.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxSensors.SelectedIndex != -1)
                {
                    if (checkForm())
                    {
                        Sensor sensor = sensorList.ElementAt(listBoxSensors.SelectedIndex);

                        if (checkBoxActivate.Checked) sensor.status = 1; else sensor.status = 0;

                        sensor.btMax = float.Parse(textBoxBTMax.Text.Replace(",", "."));
                        sensor.btMin = float.Parse(textBoxBTMin.Text.Replace(",", "."));

                        if (checkBoxBT.Checked) sensor.btStatus = 1; else sensor.btStatus = 0;
                        sensor.eqVal = float.Parse(textBoxValueEQ.Text.Replace(",", "."));
                        if (checkBoxEq.Checked) sensor.eqStatus = 1; else sensor.eqStatus = 0;
                        sensor.grVal = float.Parse(textBoxValueGR.Text.Replace(",","."));
                        if (checkBoxGr.Checked) sensor.grStatus = 1; else sensor.grStatus = 0;
                        sensor.lsVal = float.Parse(textBoxValueLS.Text.Replace(",", "."));
                        if (checkBoxLs.Checked) sensor.lsStatus = 1; else sensor.lsStatus = 0;

                        listBoxSensors.Refresh();
                        updateXML(sensor);

                        ShowMessage("Data saved of sensor " + sensor.name + "!");
                    }
                    
                }
                else
                {
                    MessageBox.Show("You need select a sensor");
                }

            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Some field is empty");
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Some field is empty or incorrect");
            }
        }

        private void ShowMessage(string text)
        {
            var t = new System.Windows.Forms.Timer();
            t.Interval = 3000; // it will Tick in 3 seconds
            labelMessage.Text = (text);
            labelMessage.Show();
            t.Tick += (s, ez) =>
            {
                labelMessage.Hide();
                t.Stop();
            };
            t.Start();
        }

        private bool checkForm()
        {
            try
            {
                if (float.Parse(textBoxBTMax.Text) < float.Parse(textBoxBTMin.Text))
                {
                    throw new MinMaxRangeBT();
                }

                /*
                if (float.Parse(textBoxValueGR.Text) < float.Parse(textBoxValueLS.Text))
                {
                    throw new MinMaxRangeValues();
                } */

                return true;

            }
            catch (MinMaxRangeBT e)
            {
                MessageBox.Show(e.Message);
            }
            catch (MinMaxRangeValues e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }


        public void createXmlTemplate()
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", null, null);
            doc.AppendChild(dec);
            XmlElement root = doc.CreateElement("SmartH2O");
            doc.AppendChild(root);
            
            string[] arraySensors = new string[] { "PH", "NH3", "CI2" };

            foreach (string sen in arraySensors) {

                XmlElement sensor = doc.CreateElement("sensor");
                sensor.SetAttribute("name", sen);
                root.AppendChild(sensor);
                XmlElement triggers = doc.CreateElement("triggers");
                sensor.AppendChild(triggers);

                //EQUAL
                XmlElement equal = doc.CreateElement("equal");
                triggers.AppendChild(equal);
                XmlElement value = doc.CreateElement("value");
                equal.AppendChild(value);
                value.InnerText = "5";
                XmlElement status = doc.CreateElement("status");
                equal.AppendChild(status);
                status.InnerText = "0";

                //GREATE
                XmlElement greater = doc.CreateElement("greater");
                triggers.AppendChild(greater);
                value = doc.CreateElement("value");
                greater.AppendChild(value);
                value.InnerText = "5";
                status = doc.CreateElement("status");
                greater.AppendChild(status);
                status.InnerText = "0";

                //less
                XmlElement less = doc.CreateElement("less");
                triggers.AppendChild(less);
                value = doc.CreateElement("value");
                less.AppendChild(value);
                value.InnerText = "5";
                status = doc.CreateElement("status");
                less.AppendChild(status);
                status.InnerText = "0";

                //between
                XmlElement between = doc.CreateElement("between");
                triggers.AppendChild(between);
                XmlElement valueMax = doc.CreateElement("valueMax");
                between.AppendChild(valueMax);
                valueMax.InnerText = "1";
                XmlElement valueMin = doc.CreateElement("valueMin");
                between.AppendChild(valueMin);
                valueMin.InnerText = "0";
                status = doc.CreateElement("status");
                between.AppendChild(status);
                status.InnerText = "0";

                //status
                status = doc.CreateElement("status");
                sensor.AppendChild(status);
                status.InnerText = "0";
            }

            doc.Save(xmlPath);
        }

        private void updateXML(Sensor sensor)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);

            XmlNode node = doc.DocumentElement;
            string path = "/SmartH2O/sensor[@name = '" + sensor.name + "']/";

            node.SelectSingleNode(path + "triggers/equal/value").InnerText = sensor.eqVal.ToString();
            node.SelectSingleNode(path + "triggers/equal/status").InnerText = sensor.eqStatus.ToString();
            node.SelectSingleNode(path + "triggers/greater/value").InnerText = sensor.grVal.ToString();
            node.SelectSingleNode(path + "triggers/greater/status").InnerText = sensor.grStatus.ToString();
            node.SelectSingleNode(path + "triggers/less/value").InnerText = sensor.lsVal.ToString();
            node.SelectSingleNode(path + "triggers/less/status").InnerText = sensor.lsStatus.ToString();
            node.SelectSingleNode(path + "triggers/between/valueMax").InnerText = sensor.btMax.ToString();
            node.SelectSingleNode(path + "triggers/between/valueMin").InnerText = sensor.btMin.ToString();
            node.SelectSingleNode(path + "triggers/between/status").InnerText = sensor.btStatus.ToString();
            node.SelectSingleNode(path + "status").InnerText = sensor.status.ToString();

            doc.Save(xmlPath);
        }

        private void checkBoxActivate_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxActivate.Checked) groupBox1.Enabled = false; else groupBox1.Enabled = true;
        }

        private void checkBoxEq_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxEq.Checked) groupBox2.Enabled = false; else groupBox2.Enabled = true;
        }

        private void checkBoxGr_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxGr.Checked) groupBox3.Enabled = false; else groupBox3.Enabled = true;
        }

        private void checkBoxLs_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxLs.Checked) groupBox4.Enabled = false; else groupBox4.Enabled = true;
        }

        private void checkBoxBT_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxBT.Checked) groupBox5.Enabled = false; else groupBox5.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipTitle = "Smart H2O";
                notifyIcon1.BalloonTipText = "The window is hidding. Click in the icon in your system tray to open again.";
                notifyIcon1.Text = "Click here to maximize";
                notifyIcon1.ShowBalloonTip(1000);
                notifyIcon1.Visible = true;
                this.Hide();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            Activate();
            WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }

        private void SmartH20_Alarm_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Unsubscribe(m_strTopicsInfo);
            client.Disconnect();
        }
    }


    [Serializable]
    internal class MinMaxRangeBT : Exception
    {
        public override string Message
        {
            get
            {
                return "Between values is incorrect - min value greater than max value";
            }
        }
    }

    [Serializable]
    internal class MinMaxRangeValues : Exception
    {
        public override string Message
        {
            get
            {
                return "Min value is grater than Max value";
            }
        }
    }
    
}
