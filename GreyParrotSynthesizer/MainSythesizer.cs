using System.Diagnostics.CodeAnalysis;

using static GreyParrotSynthesizer.WaveUtils;

namespace GreyParrotSynthesizer
{
    public partial class MainSythesizer : Form
    {
        private static string directoryPath = Path.Combine(Environment.CurrentDirectory, "Sounds");
        //private string filename;
        private string existingSound = Path.Combine(directoryPath, "sound");

        WaveUtils.WaveType waveType = WaveUtils.WaveType.SINE;
        float frequency = 200f;
        short amplitude = 1000;
        float seconds = 0.5f;
        // ranges 0 to 8
        short octave = 4;

        public MainSythesizer()
        {
            InitializeComponent();
            WaveFormDropDown_Load();

            CreateFiles();

        }

        private void CreateFiles()
        {
            if (File.Exists(existingSound + "1"))
            {
                return;
            }
            else
            {
                Directory.CreateDirectory(directoryPath);
                for (int i = 0; i < 8; i++)
                {
                    Audio.SaveSound(frequency, amplitude, waveType, seconds, existingSound + (i + 1).ToString());
                }
            }
        }

        private void WaveFormDropDown_Load()
        {
            WaveFormDropDown.DataSource = System.Enum.GetValues(typeof(WaveType));
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Escape))
            {
                this.Close();
            }

            if (!e.KeyChar.Equals('-') && !e.KeyChar.Equals('='))
            {
                float frequencyPress = KeyToNote(e, octave);

                if (frequencyPress > 19) Audio.PlaySound(frequencyPress, amplitude, waveType, seconds);
            }
            else
            {
                switch (e.KeyChar)
                {
                    default:
                        if (octave > 0) octave--;
                        break;
                    case '=':
                        if (octave < 8) octave++;
                        break;
                }
            }
            // Fix found here: https://stackoverflow.com/questions/9648381/how-to-prevent-manual-input-into-a-combobox-in-c-sharp
            e.Handled = true;
        }

        private void WaveFormDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = WaveFormDropDown.Items[WaveFormDropDown.SelectedIndex].ToString() + "";
            waveType = (WaveType)Enum.Parse(typeof(WaveType), str);
        }

        private void PlaySound_Click(object sender, EventArgs e)
        {
            Audio.PlaySound(frequency, amplitude, waveType, seconds);
            //Audio.SaveSound(frequency, amplitude, waveType, "test.wav");
        }

        private void FrequencyBar_Scroll(object sender, EventArgs e)
        {
            frequency = FrequencyBar.Value;
            frequencyValueDisplay.Text = frequency.ToString();
        }

        private void AmplitudeBar_Scroll(object sender, EventArgs e)
        {
            amplitude = (short)AmplitudeBar.Value;
            amplitudeDisplay.Text = amplitude.ToString();
        }
        private void durationBar_Scroll(object sender, EventArgs e)
        {
            durationValueDisplay.Text = durationBar.Value.ToString();
        }

        //changes padding of radio buttons to 0
        private void changeRBPadding0(RadioButton radioButton)
        {
            radioButton.Padding = new Padding(0, 0, 0, 0);
        }

        //sets bottom padding to 100, this makes it so the background image is visible
        private void changeRBPaddingImageVisible(RadioButton radioButton)
        {
            radioButton.Padding = new Padding(0, 100, 0, 0);
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            //for each of these it changes the padding of the active radiobutton back to 0 to indicate that it has been accessed
            //it sets the other ones to 100 so that you can see the button image again
            changeRBPadding0(radioButton1);
            changeRBPaddingImageVisible(radioButton2);
            changeRBPaddingImageVisible(radioButton3);
            changeRBPaddingImageVisible(radioButton4);
            changeRBPaddingImageVisible(radioButton5);
            changeRBPaddingImageVisible(radioButton6);
            changeRBPaddingImageVisible(radioButton8);
            changeRBPaddingImageVisible(radioButton7);
            changeRBPaddingImageVisible(radioButton9);
            changeRBPaddingImageVisible(radioButton10);
        }
        private void radioButton2_Click(object sender, EventArgs e)
        {
            changeRBPadding0(radioButton2);
            changeRBPaddingImageVisible(radioButton1);
            changeRBPaddingImageVisible(radioButton3);
            changeRBPaddingImageVisible(radioButton4);
            changeRBPaddingImageVisible(radioButton5);
            changeRBPaddingImageVisible(radioButton6);
            changeRBPaddingImageVisible(radioButton8);
            changeRBPaddingImageVisible(radioButton7);
            changeRBPaddingImageVisible(radioButton9);
            changeRBPaddingImageVisible(radioButton10);
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            changeRBPadding0(radioButton3);
            changeRBPaddingImageVisible(radioButton1);
            changeRBPaddingImageVisible(radioButton2);
            changeRBPaddingImageVisible(radioButton4);
            changeRBPaddingImageVisible(radioButton5);
            changeRBPaddingImageVisible(radioButton6);
            changeRBPaddingImageVisible(radioButton8);
            changeRBPaddingImageVisible(radioButton7);
            changeRBPaddingImageVisible(radioButton9);
            changeRBPaddingImageVisible(radioButton10);
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            changeRBPadding0(radioButton4);
            changeRBPaddingImageVisible(radioButton1);
            changeRBPaddingImageVisible(radioButton3);
            changeRBPaddingImageVisible(radioButton2);
            changeRBPaddingImageVisible(radioButton5);
            changeRBPaddingImageVisible(radioButton6);
            changeRBPaddingImageVisible(radioButton8);
            changeRBPaddingImageVisible(radioButton7);
            changeRBPaddingImageVisible(radioButton9);
            changeRBPaddingImageVisible(radioButton10);
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            changeRBPadding0(radioButton5);
            changeRBPaddingImageVisible(radioButton1);
            changeRBPaddingImageVisible(radioButton3);
            changeRBPaddingImageVisible(radioButton4);
            changeRBPaddingImageVisible(radioButton2);
            changeRBPaddingImageVisible(radioButton6);
            changeRBPaddingImageVisible(radioButton8);
            changeRBPaddingImageVisible(radioButton7);
            changeRBPaddingImageVisible(radioButton9);
            changeRBPaddingImageVisible(radioButton10);
        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            changeRBPadding0(radioButton6);
            changeRBPaddingImageVisible(radioButton1);
            changeRBPaddingImageVisible(radioButton3);
            changeRBPaddingImageVisible(radioButton4);
            changeRBPaddingImageVisible(radioButton5);
            changeRBPaddingImageVisible(radioButton2);
            changeRBPaddingImageVisible(radioButton8);
            changeRBPaddingImageVisible(radioButton7);
            changeRBPaddingImageVisible(radioButton9);
            changeRBPaddingImageVisible(radioButton10);
        }

        private void radioButton7_Click(object sender, EventArgs e)
        {
            changeRBPadding0(radioButton7);
            changeRBPaddingImageVisible(radioButton1);
            changeRBPaddingImageVisible(radioButton3);
            changeRBPaddingImageVisible(radioButton4);
            changeRBPaddingImageVisible(radioButton5);
            changeRBPaddingImageVisible(radioButton6);
            changeRBPaddingImageVisible(radioButton8);
            changeRBPaddingImageVisible(radioButton2);
            changeRBPaddingImageVisible(radioButton9);
            changeRBPaddingImageVisible(radioButton10);
        }

        private void radioButton8_Click(object sender, EventArgs e)
        {
            changeRBPadding0(radioButton8);
            changeRBPaddingImageVisible(radioButton1);
            changeRBPaddingImageVisible(radioButton3);
            changeRBPaddingImageVisible(radioButton4);
            changeRBPaddingImageVisible(radioButton5);
            changeRBPaddingImageVisible(radioButton6);
            changeRBPaddingImageVisible(radioButton7);
            changeRBPaddingImageVisible(radioButton2);
            changeRBPaddingImageVisible(radioButton9);
            changeRBPaddingImageVisible(radioButton10);
        }

        private void radioButton9_Click(object sender, EventArgs e)
        {
            changeRBPadding0(radioButton9);
            changeRBPaddingImageVisible(radioButton1);
            changeRBPaddingImageVisible(radioButton3);
            changeRBPaddingImageVisible(radioButton4);
            changeRBPaddingImageVisible(radioButton5);
            changeRBPaddingImageVisible(radioButton6);
            changeRBPaddingImageVisible(radioButton7);
            changeRBPaddingImageVisible(radioButton2);
            changeRBPaddingImageVisible(radioButton8);
            changeRBPaddingImageVisible(radioButton10);
        }

        private void radioButton10_Click(object sender, EventArgs e)
        {
            changeRBPadding0(radioButton10);
            changeRBPaddingImageVisible(radioButton1);
            changeRBPaddingImageVisible(radioButton3);
            changeRBPaddingImageVisible(radioButton4);
            changeRBPaddingImageVisible(radioButton5);
            changeRBPaddingImageVisible(radioButton6);
            changeRBPaddingImageVisible(radioButton7);
            changeRBPaddingImageVisible(radioButton2);
            changeRBPaddingImageVisible(radioButton9);
            changeRBPaddingImageVisible(radioButton8);
        }

        private void saveButtton_Click(object sender, EventArgs e)
        {

            if (/*textbox with filename not empty*/ false)
            {
                Audio.SaveSound(frequency, amplitude, waveType, seconds, Path.Combine(directoryPath,/*textbox filename*/ ""));
            }


            if (radioButton1.Checked) Audio.SaveSound(frequency, amplitude, waveType, seconds, existingSound + "1");
            else if (radioButton2.Checked) Audio.SaveSound(frequency, amplitude, waveType, seconds, existingSound + "2");
            else if (radioButton3.Checked) Audio.SaveSound(frequency, amplitude, waveType, seconds, existingSound + "3");
            else if (radioButton4.Checked) Audio.SaveSound(frequency, amplitude, waveType, seconds, existingSound + "4");
            else if (radioButton5.Checked) Audio.SaveSound(frequency, amplitude, waveType, seconds, existingSound + "5");
            else if (radioButton6.Checked) Audio.SaveSound(frequency, amplitude, waveType, seconds, existingSound + "6");
            else if (radioButton7.Checked) Audio.SaveSound(frequency, amplitude, waveType, seconds, existingSound + "7");
            else if (radioButton8.Checked) Audio.SaveSound(frequency, amplitude, waveType, seconds, existingSound + "8");
            else if (radioButton9.Checked) Audio.SaveSound(frequency, amplitude, waveType, seconds, existingSound + "9");
            else if (radioButton10.Checked) Audio.SaveSound(frequency, amplitude, waveType, seconds, existingSound + "10");
        }

        private void playSoundStorage_Click(object sender, EventArgs e)
        {

            Audio.PlayAllSoundsFromFiles(existingSound);

        }


    }
}