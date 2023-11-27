using System.Diagnostics.CodeAnalysis;

using static GreyParrotSynthesizer.WaveUtils;

namespace GreyParrotSynthesizer
{
    public partial class MainSythesizer : Form
    {
        WaveType waveType = WaveType.SINE;
        float frequency = 200f;
        // frequency of C note: 523.25
        // note frequency algorithm = 440 * (1.059463..)^n
        // n = steps away from A4
        short amplitude = 1000;
        float seconds = 0.5f;
        // ranges 0 to 8
        short octive = 4;

        public MainSythesizer()
        {
            InitializeComponent();
            WaveFormDropDown_Load();
        }

        private void WaveFormDropDown_Load()
        {
            WaveFormDropDown.DataSource = System.Enum.GetValues(typeof(WaveType));
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            Audio.PlaySound(frequency, amplitude, waveType, seconds);
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
        }

        private void AmplitudeBar_Scroll(object sender, EventArgs e)
        {
            amplitude = (short)AmplitudeBar.Value;
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
    }
}