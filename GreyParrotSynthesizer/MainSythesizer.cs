using System.Diagnostics.CodeAnalysis;

using static GreyParrotSynthesizer.WaveUtils;

namespace GreyParrotSynthesizer
{
    public partial class MainSythesizer : Form
    {
        private static string directoryPath = Path.Combine(Environment.CurrentDirectory, "Sounds");
        //private string filename;
        private string existingSound = Path.Combine(directoryPath, "sound");
#pragma warning restore IDE0044 // Add readonly modifier

        WaveUtils.WaveType waveType = WaveUtils.WaveType.SINE;
        float frequency = 200f;
        short amplitude = 1000;
        float seconds = 0.1f;
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

            if (e.KeyChar.Equals((char)Keys.Space))
            {
                PlaySoundStorage_Click(sender, e);
            }

            if (e.KeyChar.Equals('h'))
            {
                cb_hoverTut.Checked = !cb_hoverTut.Checked;
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
        private static void ChangeRBPadding0(RadioButton radioButton)
        {
            radioButton.Padding = new Padding(0, 0, 0, 0);
        }

        //sets bottom padding to 100, this makes it so the background image is visible
        private static void ChangeRBPaddingImageVisible(RadioButton radioButton)
        {
            radioButton.Padding = new Padding(0, 100, 0, 0);
        }

        private void RadioButton1_Click(object sender, EventArgs e)
        {
            //for each of these it changes the padding of the active radiobutton back to 0 to indicate that it has been accessed
            //it sets the other ones to 100 so that you can see the button image again
            ChangeRBPadding0(radioButton1);
            ChangeRBPaddingImageVisible(radioButton2);
            ChangeRBPaddingImageVisible(radioButton3);
            ChangeRBPaddingImageVisible(radioButton4);
            ChangeRBPaddingImageVisible(radioButton5);
            ChangeRBPaddingImageVisible(radioButton6);
            ChangeRBPaddingImageVisible(radioButton8);
            ChangeRBPaddingImageVisible(radioButton7);
            ChangeRBPaddingImageVisible(radioButton9);
            ChangeRBPaddingImageVisible(radioButton10);
        }
        private void RadioButton2_Click(object sender, EventArgs e)
        {
            ChangeRBPadding0(radioButton2);
            ChangeRBPaddingImageVisible(radioButton1);
            ChangeRBPaddingImageVisible(radioButton3);
            ChangeRBPaddingImageVisible(radioButton4);
            ChangeRBPaddingImageVisible(radioButton5);
            ChangeRBPaddingImageVisible(radioButton6);
            ChangeRBPaddingImageVisible(radioButton8);
            ChangeRBPaddingImageVisible(radioButton7);
            ChangeRBPaddingImageVisible(radioButton9);
            ChangeRBPaddingImageVisible(radioButton10);
        }

        private void RadioButton3_Click(object sender, EventArgs e)
        {
            ChangeRBPadding0(radioButton3);
            ChangeRBPaddingImageVisible(radioButton1);
            ChangeRBPaddingImageVisible(radioButton2);
            ChangeRBPaddingImageVisible(radioButton4);
            ChangeRBPaddingImageVisible(radioButton5);
            ChangeRBPaddingImageVisible(radioButton6);
            ChangeRBPaddingImageVisible(radioButton8);
            ChangeRBPaddingImageVisible(radioButton7);
            ChangeRBPaddingImageVisible(radioButton9);
            ChangeRBPaddingImageVisible(radioButton10);
        }

        private void RadioButton4_Click(object sender, EventArgs e)
        {
            ChangeRBPadding0(radioButton4);
            ChangeRBPaddingImageVisible(radioButton1);
            ChangeRBPaddingImageVisible(radioButton3);
            ChangeRBPaddingImageVisible(radioButton2);
            ChangeRBPaddingImageVisible(radioButton5);
            ChangeRBPaddingImageVisible(radioButton6);
            ChangeRBPaddingImageVisible(radioButton8);
            ChangeRBPaddingImageVisible(radioButton7);
            ChangeRBPaddingImageVisible(radioButton9);
            ChangeRBPaddingImageVisible(radioButton10);
        }

        private void RadioButton5_Click(object sender, EventArgs e)
        {
            ChangeRBPadding0(radioButton5);
            ChangeRBPaddingImageVisible(radioButton1);
            ChangeRBPaddingImageVisible(radioButton3);
            ChangeRBPaddingImageVisible(radioButton4);
            ChangeRBPaddingImageVisible(radioButton2);
            ChangeRBPaddingImageVisible(radioButton6);
            ChangeRBPaddingImageVisible(radioButton8);
            ChangeRBPaddingImageVisible(radioButton7);
            ChangeRBPaddingImageVisible(radioButton9);
            ChangeRBPaddingImageVisible(radioButton10);
        }

        private void RadioButton6_Click(object sender, EventArgs e)
        {
            ChangeRBPadding0(radioButton6);
            ChangeRBPaddingImageVisible(radioButton1);
            ChangeRBPaddingImageVisible(radioButton3);
            ChangeRBPaddingImageVisible(radioButton4);
            ChangeRBPaddingImageVisible(radioButton5);
            ChangeRBPaddingImageVisible(radioButton2);
            ChangeRBPaddingImageVisible(radioButton8);
            ChangeRBPaddingImageVisible(radioButton7);
            ChangeRBPaddingImageVisible(radioButton9);
            ChangeRBPaddingImageVisible(radioButton10);
        }

        private void RadioButton7_Click(object sender, EventArgs e)
        {
            ChangeRBPadding0(radioButton7);
            ChangeRBPaddingImageVisible(radioButton1);
            ChangeRBPaddingImageVisible(radioButton3);
            ChangeRBPaddingImageVisible(radioButton4);
            ChangeRBPaddingImageVisible(radioButton5);
            ChangeRBPaddingImageVisible(radioButton6);
            ChangeRBPaddingImageVisible(radioButton8);
            ChangeRBPaddingImageVisible(radioButton2);
            ChangeRBPaddingImageVisible(radioButton9);
            ChangeRBPaddingImageVisible(radioButton10);
        }

        private void RadioButton8_Click(object sender, EventArgs e)
        {
            ChangeRBPadding0(radioButton8);
            ChangeRBPaddingImageVisible(radioButton1);
            ChangeRBPaddingImageVisible(radioButton3);
            ChangeRBPaddingImageVisible(radioButton4);
            ChangeRBPaddingImageVisible(radioButton5);
            ChangeRBPaddingImageVisible(radioButton6);
            ChangeRBPaddingImageVisible(radioButton7);
            ChangeRBPaddingImageVisible(radioButton2);
            ChangeRBPaddingImageVisible(radioButton9);
            ChangeRBPaddingImageVisible(radioButton10);
        }

        private void RadioButton9_Click(object sender, EventArgs e)
        {
            ChangeRBPadding0(radioButton9);
            ChangeRBPaddingImageVisible(radioButton1);
            ChangeRBPaddingImageVisible(radioButton3);
            ChangeRBPaddingImageVisible(radioButton4);
            ChangeRBPaddingImageVisible(radioButton5);
            ChangeRBPaddingImageVisible(radioButton6);
            ChangeRBPaddingImageVisible(radioButton7);
            ChangeRBPaddingImageVisible(radioButton2);
            ChangeRBPaddingImageVisible(radioButton8);
            ChangeRBPaddingImageVisible(radioButton10);
        }

        private void RadioButton10_Click(object sender, EventArgs e)
        {
            ChangeRBPadding0(radioButton10);
            ChangeRBPaddingImageVisible(radioButton1);
            ChangeRBPaddingImageVisible(radioButton3);
            ChangeRBPaddingImageVisible(radioButton4);
            ChangeRBPaddingImageVisible(radioButton5);
            ChangeRBPaddingImageVisible(radioButton6);
            ChangeRBPaddingImageVisible(radioButton7);
            ChangeRBPaddingImageVisible(radioButton2);
            ChangeRBPaddingImageVisible(radioButton9);
            ChangeRBPaddingImageVisible(radioButton8);
        }

        private void SaveButtton_Click(object sender, EventArgs e)
        {

            if (/*textbox with filename not empty*/ false)
            {
#pragma warning disable CS0162 // Unreachable code detected
                Audio.SaveSound(frequency, amplitude, waveType, seconds, Path.Combine(directoryPath,/*textbox filename*/ ""));
#pragma warning restore CS0162 // Unreachable code detected
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

        private void PlaySoundStorage_Click(object sender, EventArgs e)
        {

            Audio.PlayAllSoundsFromFiles(existingSound);

        }

        private void OnHover(object sender, EventArgs e)
        {
            l_tip.Visible = true;
            if (sender == WaveFormDropDown)
            {
                l_tip.Text = "Use the dropdown to change waveform.";
            }
            else if (sender == cb_hoverTut)
            {
                l_tip.Text = "Shows tips when hovering over items. (Shortcut: h)";
            }
            else if (sender == playSoundStorage)
            {
                l_tip.Text = "Plays the set of saved sounds in order. (Shortcut: Space)";
            }
            else if (sender == l_tip)
            {
                Point mousePoint = PointToClient(MousePosition);
                mousePoint.Y -= l_tip.Height;
                l_tip.Location = mousePoint;
                l_tip.Visible = false;
            }
            else
            {
                l_tip.Visible = false;
            }
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (cb_hoverTut.Checked == true)
            {
                Point mousePoint = PointToClient(MousePosition);
                mousePoint.Y -= l_tip.Height;
                l_tip.Location = mousePoint;
            }
            else
            {
                l_tip.Visible = false;
            }
        }

        private void OnLeave(object sender, EventArgs e)
        {
            l_tip.Visible = false;
        }
    }
}