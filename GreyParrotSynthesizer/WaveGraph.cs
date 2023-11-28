using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GreyParrotSynthesizer
{
    public partial class WaveGraph : Form
    {
        System.Windows.Forms.Timer timer;
        double x = 0;
        ChartArea chartArea;

        public WaveGraph()
        {
            InitializeComponent();
            InitializeChart();
            InitializeTimer();

            //MainSythesizer.DataSend += RecieveData;
        }

        private void InitializeChart()
        {
            // Chart and area
            //chart1.ChartAreas.Add(new ChartArea("Default"));

            // Customize chart
            chart1.BackColor = Color.Black;

            // Series?
            //chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[0].Color = Color.Green;

        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 5;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void RecieveData(object sender, short[] wave)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            chart1.Series[0].Points.AddXY(x, Math.Cos(x));

            if (chart1.Series[0].Points.Count > 100)
                chart1.Series[0].Points.RemoveAt(0);

            chart1.ChartAreas[0].AxisX.Minimum = chart1.Series[0].Points[0].XValue;
            chart1.ChartAreas[0].AxisX.Maximum = x;

            x += 0.1;
        }
    }
}
