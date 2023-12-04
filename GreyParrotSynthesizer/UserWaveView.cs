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
        public static short[]? wave;
        double y;
        bool ready = true;
        int waveLength = 0;
        int waveIndex = 0;

        public UserWaveView()
        {
            InitializeComponent();
            InitializeChart();
            InitializeTimer();

        }

        public static void Wave(short[] value)
        {

            int newIndex = 0;
            short[] newWave = new short[(value.Length / 1000) + 1];
            for (int i = 0; i < value.Length; i++)
            {
                if (i % 1000 == 0)
                {
                    newWave[newIndex] = value[i];
                    newIndex++;
                }
            }
            wave = newWave;

        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            FormManager.Current.HideForm(FormManager.FormSelection.MainSynthesizer);
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
            try
            {
                if (wave != null)
                {
                    waveLength = wave.Length;
                    waveIndex = 0;
                    for (int i = 0; i < wave.Length; i++)
                    {
                        y = wave[i];
                        chart1.Series[0].Points.AddXY(time, y);
                        time += 1;
                    }
                    wave = null;
                    ready = false;
                }
                else if (!ready)
                {
                    if (waveLength <= waveIndex)
                    {
                        ready = true;
                    }
                    else
                    {
                        waveIndex++;
                    }
                }
                else
                {
                    chart1.Series[0].Points.AddXY(time, 0);
                    time += 1;
                }

                //if (wave == null)
                //    return;

                //for (int i = 0; i < wave.Length; i++)
                //{
                //    // test purposes
                //    y = wave[i];
                //    chart1.Series[0].Points.AddXY(time, y);
                //    time += 1;
                //}


                if (chart1.Series[0].Points.Count > 100)
                    chart1.Series[0].Points.RemoveAt(0);

                chart1.ChartAreas[0].AxisX.Minimum = chart1.Series[0].Points[0].XValue;
                chart1.ChartAreas[0].AxisX.Maximum = chart1.Series[0].Points[0].XValue + 100;
                chart1.ChartAreas[0].AxisY.Minimum = -100000.1;
                chart1.ChartAreas[0].AxisY.Maximum = 100000.1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }

        private void UserWaveView_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
        }
    }
}
