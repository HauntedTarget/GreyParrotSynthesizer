using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreyParrotSynthesizer
{
    public partial class UserWaveView : Form
    {

        System.Windows.Forms.Timer timer;
        double time;
        short[] wave;

        public UserWaveView()
        {
            InitializeComponent();
            InitializeChart();
            InitializeTimer();

        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            FormManager.Current.HideForm(FormManager.FormSelection.MainSynthesizer);
        }

        public void RecieveData(short[] wave)
        {
            this.wave = wave;
        }

        private void InitializeChart()
        {
            // Chart and area
            //chart1.ChartAreas.Add(new ChartArea("Default"));

            // Customize chart
            chart1.BackColor = Color.Black;


            // Series?
            //chart1.Series[0].ChartType = SeriesChartType.Line;
            double y = 0;
            chart1.Series[0].Color = Color.Green;
            chart1.RightToLeft = RightToLeft.Yes;
            chart1.Series[0].Points.DataBindXY(new double[] { time }, new double[] { y });

        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1;
            timer.Tick += Timer_Tick;
            timer.Start();
        }


        private void Timer_Tick(object sender, EventArgs e)
        {

            if (wave != null)
            {
                for (int i = 0; i < wave.Length; i++)
                {
                    // test purposes
                    double y = wave[i];
                    chart1.Series[0].Points.DataBindXY(new double[] { time }, new double[] { y });
                    time += 1;
                }
                wave = null;
            }
            //else
            //{
            //    chart1.Series[0].Points.AddXY(time, 0);
            //}


            if (chart1.Series[0].Points.Count > 100)
                chart1.Series[0].Points.RemoveAt(0);

            chart1.ChartAreas[0].AxisX.Minimum = chart1.Series[0].Points[0].XValue;
            chart1.ChartAreas[0].AxisX.Maximum = chart1.Series[0].Points[0].XValue+100;
            chart1.ChartAreas[0].AxisY.Minimum = -10000.1;
            chart1.ChartAreas[0].AxisY.Maximum = 10000.1;

            time += 1;
        }
    }
}
