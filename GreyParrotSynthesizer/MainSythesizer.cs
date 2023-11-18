namespace GreyParrotSynthesizer
{
    public partial class MainSythesizer : Form
    {

        WaveUtils.WaveType waveType = WaveUtils.WaveType.SINE;
        float frequency = 200f;
        short amplitude = 1000;

        public MainSythesizer()
        {
            InitializeComponent();
            WaveFormDropDown_Load();
        }

        private void WaveFormDropDown_Load()
        {
            WaveFormDropDown.DataSource = System.Enum.GetValues(typeof(WaveUtils.WaveType));
        }

        private void MainSythesizer_KeyDown(object sender, KeyEventArgs e)
        {
            Audio.PlaySound(440f, (short)1000, WaveUtils.WaveType.SINE);
        }

        private void WaveFormDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = WaveFormDropDown.Items[WaveFormDropDown.SelectedIndex].ToString();
            waveType = (WaveUtils.WaveType)Enum.Parse(typeof(WaveUtils.WaveType), str);
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
    }
}