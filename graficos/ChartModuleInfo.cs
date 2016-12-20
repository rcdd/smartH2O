using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace graficos
{
    class ChartModuleInfo
    {
        public class DateModel
        {
            public System.DateTime DateTime { get; set; }
            public double Value { get; set; }
        }
        public void drawChart(LiveCharts.WinForms.CartesianChart chart, XmlNodeList nodeList)
        {
            ChartValues<DateModel> values = new ChartValues<DateModel>();

            var dayConfig = Mappers.Xy<DateModel>()
                .X(dayModel => (double)dayModel.DateTime.Ticks / TimeSpan.FromHours(1).Ticks)
                .Y(dayModel => dayModel.Value);

            int i = 0;
            foreach (XmlNode node in nodeList)
            {
                DateModel dateModel = new DateModel();
                dateModel.DateTime = UnixTimeStampToDateTime(long.Parse(node["TimeStamp"].InnerText));
                dateModel.Value = double.Parse(node["Value"].InnerText, System.Globalization.CultureInfo.InvariantCulture);
                values.Add(dateModel);
            }

            chart.Series = new SeriesCollection(dayConfig)
            {
                new LineSeries
                {
                    Values = values,
                    PointGeometrySize = 18,
                    StrokeThickness = 4,
                    DataLabels = false
                }
            };

            chart.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49));


            chart.AxisY = new AxesCollection
            {
                new Axis
                {
                    IsMerged = false,
                    Separator = new Separator
                    {
                        StrokeThickness = 1,
                        StrokeDashArray = new System.Windows.Media.DoubleCollection(new double[] { 10 }),
                        Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                    }
                }
            };

            chart.AxisX  = new AxesCollection
            {
                new Axis
                {
                    LabelFormatter = value =>"Day: "+ new System.DateTime((long)(value * TimeSpan.FromHours(1).Ticks)).ToString("dd HH:mm:ss")
                }
            };
        }

        private DateTime UnixTimeStampToDateTime(long unixTimeStamp)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp);
            return dtDateTime;
        }

        public void populateInfo(XmlNodeList values, Label labelMin, Label labelMax, Label labelAverage)
        {
            double sumValues = 0;
            double minValues = double.MaxValue;
            double maxValues = double.MinValue;

            foreach (XmlNode node in values)
            {
                double val = double.Parse(node["Value"].InnerText, System.Globalization.CultureInfo.InvariantCulture);
                sumValues += val;
                maxValues = (maxValues < val ? val : maxValues);
                minValues = (minValues > val ? val : minValues);
            }

            labelMin.Text = minValues.ToString("F");
            labelMax.Text = maxValues.ToString("F");


            labelAverage.Text = (sumValues / values.Count).ToString("F");
        }
    }
}
