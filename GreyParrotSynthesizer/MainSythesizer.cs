using System;
using System.IO;

namespace GreyParrotSynthesizer
{

    public partial class MainSythesizer : Form
    {

        private string path = Environment.CurrentDirectory;
        private string filename = "sound";

        Audio.WaveType waveType = Audio.WaveType.SINE;
        float frequency = 200f;
        short amplitude = 1000;

        public MainSythesizer()
        {
            InitializeComponent();
            WaveFormDropDown_Load();

            CreateFiles();
        }

        private void WaveFormDropDown_Load()
        {
            WaveFormDropDown.DataSource = System.Enum.GetValues(typeof(Audio.WaveType));
        }

        private void CreateFiles()
        {
            if (File.Exists(Path.Combine(path, "Sounds", filename, "1")))
            {
                return;
            }
            else
            {
                Directory.CreateDirectory(Path.Combine(path, "Sounds"));
                for (int i = 0; i < 8; i++)
                {
                    Audio.SaveSound(frequency, amplitude, waveType, Path.Combine(path, "Sounds", filename + (i + 1).ToString()));
                }
            }
        }

        private void MainSythesizer_KeyDown(object sender, KeyEventArgs e)
        {
            Audio.PlaySound(440f, (short)1000, Audio.WaveType.SINE);
        }

        private void WaveFormDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ?str = WaveFormDropDown.Items[WaveFormDropDown.SelectedIndex].ToString();
            waveType = (Audio.WaveType)Enum.Parse(typeof(Audio.WaveType), str);
        }

        private void PlaySound_Click(object sender, EventArgs e)
        {
            Audio.PlaySound(frequency, amplitude, waveType);
        }

        private void FrequencyBar_Scroll(object sender, EventArgs e)
        {
            frequency = FrequencyBar.Value;
        }

        private void AmplitudeBar_Scroll(object sender, EventArgs e)
        {
            amplitude = (short)AmplitudeBar.Value;
        }

        private void TestSave_Click(object sender, EventArgs e)
        {
            Audio.SaveSound(frequency,amplitude,waveType, Path.Combine(path, "Sounds", filename + "1"));
        }
    }
}