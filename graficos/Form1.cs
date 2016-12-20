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
            populateCharts();
        }

        private void populateCharts()
        {
            ServiceH2O.ServiceLogClient client = new ServiceH2O.ServiceLogClient();
            String xml = client.GetAllValues();
            
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            XmlNodeList listPH = doc.SelectNodes("/Sensors/Sensor[Name='PH']/Value");
            XmlNodeList listCI2 = doc.SelectNodes("/Sensors/Sensor[Name='CI2']/Value");
            XmlNodeList listNH3 = doc.SelectNodes("/Sensors/Sensor[Name='NH3']/Value");

            //MessageBox.Show("ph: "+listPH.Count + "CI2: "+listCI2.Count + "NH3: "+listNH3.Count);

            drawChart(phChart1, listPH);
            drawChart(ciChart2, listCI2);
            drawChart(nh3Chart1, listNH3);
        }

        private void drawChart(LiveCharts.WinForms.CartesianChart chart, XmlNodeList nodeList)
        {
            ChartValues<double> values = new ChartValues<double>();
            foreach (XmlNode node in nodeList)
            {
                values.Add(double.Parse(node.InnerText, System.Globalization.CultureInfo.InvariantCulture));
            }

            chart.Series.Add(new LineSeries
            {
                Values = values,
                StrokeThickness = 2,
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(28, 142, 196)),
                Fill = System.Windows.Media.Brushes.Transparent,
                LineSmoothness = 1,
                PointGeometrySize = 15,
                PointForeround =
                    new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49))
            });

            chart.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49));

            phChart1.AxisY.Add(new Axis
            {
                IsMerged = true,
                Separator = new Separator
                {
                    StrokeThickness = 1.5,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(new double[] { 10 }),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
