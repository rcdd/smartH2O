using LiveCharts;
using LiveCharts.Wpf;
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


namespace graficos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getAllInfo();
        }

        private void getAllInfo()
        {
            ServiceH2O.ServiceLogClient client = new ServiceH2O.ServiceLogClient();
            String xml = client.GetAllValues();

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            XmlNodeList listPH = doc.SelectNodes("/Sensors/Sensor[Name='PH']");
            XmlNodeList listCI2 = doc.SelectNodes("/Sensors/Sensor[Name='CI2']");
            XmlNodeList listNH3 = doc.SelectNodes("/Sensors/Sensor[Name='NH3']");


            //MessageBox.Show("ph: "+listPH.Count + "CI2: "+listCI2.Count + "NH3: "+listNH3.Count);
            ChartModuleInfo chartModule = new ChartModuleInfo();
            chartModule.drawChart(phChart1, listPH);
            chartModule.drawChart(ciChart2, listCI2);
            chartModule.drawChart(nh3Chart1, listNH3);

            chartModule.populateInfo(listPH, labelMinPh, labelMaxPh, labelAveragePh);
            chartModule.populateInfo(listCI2, labelMinCI2, labelMaxCI2, label5);
            chartModule.populateInfo(listNH3, labelMinNH3, labelMaxNH3, labelAvgNH3);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDate_Click(object sender, EventArgs e)
        {
            monthCalendar1.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    groupBoxDate.Hide();
                    return;
                case 1:
                    
                    return;
            }
            groupBoxDate.Show();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    getAllInfo();
                    break;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textDate.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
            monthCalendar1.Hide();
        }

        private void tab1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl1.TabPages[tabControl1.SelectedIndex].Controls.Add(groupBoxDate);
        }
    }
}
