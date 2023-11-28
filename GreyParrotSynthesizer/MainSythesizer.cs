using System.Diagnostics.CodeAnalysis;

using static GreyParrotSynthesizer.WaveUtils;

namespace GreyParrotSynthesizer
{
    public partial class MainSythesizer : Form
    {

        WaveType waveType = WaveType.SINE;
        float frequency = 200f;
        short amplitude = 1000;

        public MainSythesizer()
        {
            InitializeComponent();
            WaveFormDropDown_Load();
        }

        private void WaveFormDropDown_Load()
        {
            WaveFormDropDown.DataSource = System.Enum.GetValues(typeof(WaveType));
        }

        private void MainSythesizer_KeyDown(object sender, KeyEventArgs e)
        {
            Audio.PlaySound(440f, (short)1000, WaveType.SINE);
        }

        private void WaveFormDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = WaveFormDropDown.Items[WaveFormDropDown.SelectedIndex].ToString();
            waveType = (WaveType)Enum.Parse(typeof(WaveType), str);
        }

        private void PlaySound_Click(object sender, EventArgs e)
        {
            Audio.PlaySound(frequency, amplitude, waveType);
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainSythesizer_Activated(object sender, EventArgs e)
        {
            FormManager.Current.OpenForm(FormManager.FormSelection.UserWaveView);
        }
    }
}