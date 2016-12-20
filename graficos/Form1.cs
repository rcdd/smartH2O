using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace graficos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            groupBoxDate.Hide();
            getAllInfoSensors();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Hide();

            tabCharts.Hide();
            groupBoxAlarms.Show();
            getAllInfoAlarms();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                groupBoxDate.Hide();
                return;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                groupBoxDate.Show();
                panelDate2.Hide();
                panelDate.Show();
                panelTime.Show();
                return;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                panelTime.Hide();
                groupBoxDate.Show();
                panelDate2.Hide();
                panelDate.Show();
                return;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                panelDate.Show();
                panelDate2.Show();
                panelTime.Hide();
                groupBoxDate.Show();
                return;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            ServiceH2O.ServiceLogClient client = new ServiceH2O.ServiceLogClient();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    getAllInfoSensors();
                    break;
                case 1:
                    if (timePicker1.Text.Length < 5 || datePicker1.Text.Length < 5)
                    {
                        MessageBox.Show("Error");
                        return;
                    }
                    getAllSensorsByDateHour(datePicker1.Value.ToString("dd/MM/yyyy"), timePicker1.Value.ToString("hh"));
                    break;
                case 2:
                    if (datePicker1.Text.Length < 5)
                    {
                        MessageBox.Show("Error");
                        return;
                    }
                    getAllSensorsByDate(datePicker1.Value.ToString("dd/MM/yyyy"));
                    break;
                case 3:
                    if (datePicker2.Text.Length < 5 || datePicker1.Text.Length < 5)
                    {
                        MessageBox.Show("Error");
                        return;
                    }
                    getAllSensorsBetweenDate(datePicker1.Value.ToString("dd/MM/yyyy"), datePicker2.Value.ToString("dd/MM/yyyy"));
                    break;
            }
        }

        private void tab1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabCharts.TabPages[tabCharts.SelectedIndex].Controls.Add(groupBoxDate);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabCharts.Show();
            comboBox1.Show();
            groupBoxAlarms.Hide();
        }

        private void populateCharts(String xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            XmlNodeList listPH = doc.SelectNodes("/Sensors/Sensor[Name='PH']");
            XmlNodeList listCI2 = doc.SelectNodes("/Sensors/Sensor[Name='CI2']");
            XmlNodeList listNH3 = doc.SelectNodes("/Sensors/Sensor[Name='NH3']");

            if (listPH.Count < 1 || listCI2.Count < 1 || listNH3.Count < 1)
            {
                MessageBox.Show("Info not available");
                return;
            }


            ChartModule chartModule = new ChartModule();
            chartModule.drawChart(phChart1, listPH);
            chartModule.drawChart(ciChart2, listCI2);
            chartModule.drawChart(nh3Chart1, listNH3);

            chartModule.populateInfo(listPH, labelMinPh, labelMaxPh, labelAveragePh);
            chartModule.populateInfo(listCI2, labelMinCI2, labelMaxCI2, label5);
            chartModule.populateInfo(listNH3, labelMinNH3, labelMaxNH3, labelAvgNH3);
        }

        public void getAllInfoSensors()
        {
            ServiceH2O.ServiceLogClient client = new ServiceH2O.ServiceLogClient();
            String xml = client.GetAllValues();
            populateCharts(xml);
        }

        public void getAllSensorsByDateHour(string date, string hour)
        {
            ServiceH2O.ServiceLogClient client = new ServiceH2O.ServiceLogClient();
            String xml = client.GetValuesByDateAndHour(date, hour);
            populateCharts(xml);

        }

        public void getAllSensorsByDate(string date)
        {
            ServiceH2O.ServiceLogClient client = new ServiceH2O.ServiceLogClient();
            String xml = client.GetValuesByDate(date);
            populateCharts(xml);

        }

        public void getAllSensorsBetweenDate(string date1, string date2)
        {
            ChartModule chartModule = new ChartModule();
            ServiceH2O.ServiceLogClient client = new ServiceH2O.ServiceLogClient();
            String xml = client.GetValuesBetweenDate(chartModule.ConvertToUnixTimestamp(date1, false),
                chartModule.ConvertToUnixTimestamp(date2, true));
            populateCharts(xml);

        }

        private void comboBoxAlarms_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (comboBoxAlarms.SelectedIndex == 1)
            {
                groupBoxAlarmsInfo.Show();
                panelDateAlarm2.Hide();
                panelDateAlarm1.Show();
                panelTimeAlarm.Show();
                return;
            }
            else if (comboBoxAlarms.SelectedIndex == 2)
            {
                panelTimeAlarm.Hide();
                groupBoxAlarmsInfo.Show();
                panelDateAlarm2.Hide();
                panelDateAlarm1.Show();
                return;
            }
            else if (comboBoxAlarms.SelectedIndex == 3)
            {
                panelDateAlarm1.Show();
                panelDateAlarm2.Show();
                panelTimeAlarm.Hide();
                groupBoxAlarmsInfo.Show();
                return;
            }
        }

        private void getAllInfoAlarms()
        {
            ServiceH2O.ServiceLogClient client = new ServiceH2O.ServiceLogClient();
            string xml = client.GetAllAlmars();
            
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            XmlNodeList xmlnodeList = doc.SelectNodes("/Alarms/Sensor");
            if (xmlnodeList.Count < 1)
            {
                MessageBox.Show("Info not available");
                return;
            }
            populateListAlarms(xmlnodeList);
        }

        private void getAllAlarmsByDateHour(string date, string hour)
        {
            ServiceH2O.ServiceLogClient client = new ServiceH2O.ServiceLogClient();
            string xml = client.GetAlarmsByDateAndHour(date, hour);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            XmlNodeList xmlnodeList = doc.SelectNodes("/Alarms/Sensor");
            if (xmlnodeList.Count < 1)
            {
                MessageBox.Show("Info not available");
                return;
            }
            populateListAlarms(xmlnodeList);
        }

        private void getAllAlarmsByDate(string date)
        {
            ServiceH2O.ServiceLogClient client = new ServiceH2O.ServiceLogClient();
            string xml = client.GetAlarmsByDate(date);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            XmlNodeList xmlnodeList = doc.SelectNodes("/Alarms/Sensor");
            if (xmlnodeList.Count < 1)
            {
                MessageBox.Show("Info not available");
                return;
            }
            populateListAlarms(xmlnodeList);
        }

        private void getAllAlarmsBetweenDate(string date1, string date2)
        {
            ServiceH2O.ServiceLogClient client = new ServiceH2O.ServiceLogClient();
            ChartModule chartModule = new ChartModule();

            string xml = client.GetAlarmsBetweenDate(chartModule.ConvertToUnixTimestamp(date1, false),
                chartModule.ConvertToUnixTimestamp(date2, true));

            Console.WriteLine(chartModule.ConvertToUnixTimestamp(date2, true) + "ola");
            Console.WriteLine(chartModule.ConvertToUnixTimestamp(date1, false) + "adeuas");


            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            XmlNodeList xmlnodeList = doc.SelectNodes("/Alarms/Sensor");
            if (xmlnodeList.Count < 1)
            {
                MessageBox.Show("Info not available");
                return;
            }
            populateListAlarms(xmlnodeList);
        }

        private void populateListAlarms(XmlNodeList xmlnodeList)
        {
            listViewAlarms.Items.Clear();
            foreach (XmlNode node in xmlnodeList)
            {
                listViewAlarms.Items.Add(new ListViewItem(new string[] { node["ID"].InnerText,
                    node["Name"].InnerText, node["Value"].InnerText,node["Date"].InnerText, node["Time"].InnerText,
                node["Alarm"].InnerText}));
            }
        }

        private void buttonUpdateAlarmInfo_Click(object sender, EventArgs e)
        {
            ServiceH2O.ServiceLogClient client = new ServiceH2O.ServiceLogClient();
            switch (comboBoxAlarms.SelectedIndex)
            {
                case 0:
                    getAllInfoAlarms();
                    break;
                case 1:
                    if (timePickerAlarm1.Text.Length < 5 || datePickerAlarm1.Text.Length < 5)
                    {
                        MessageBox.Show("Error");
                        return;
                    }
                    getAllAlarmsByDateHour(datePickerAlarm1.Value.ToString("dd/MM/yyyy"), timePickerAlarm1.Value.ToString("hh"));
                    break;
                case 2:
                    if (datePickerAlarm1.Text.Length < 5)
                    {
                        MessageBox.Show("Error");
                        return;
                    }
                    getAllAlarmsByDate(datePickerAlarm1.Value.ToString("dd/MM/yyyy"));
                    break;
                case 3:
                    if (datePickerAlarm2.Text.Length < 5 || datePickerAlarm1.Text.Length < 5)
                    {
                        MessageBox.Show("Error");
                        return;
                    }
                    getAllAlarmsBetweenDate(datePickerAlarm1.Value.ToString("dd/MM/yyyy"), datePickerAlarm2.Value.ToString("dd/MM/yyyy"));
                    break;
            }
        }
    }
}
