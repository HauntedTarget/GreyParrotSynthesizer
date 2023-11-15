namespace GreyParrotSynthesizer
{
    public partial class MainSythesizer : Form
    {

        WaveForms waveForms = WaveForms.Sin;
        float frequency = 200f;
        int amplitude;

        public MainSythesizer()
        {
            InitializeComponent();
            WaveFormDropDown_Load();
        }

        private void WaveFormDropDown_Load()
        {
            WaveFormDropDown.DataSource = System.Enum.GetValues(typeof(WaveForms));
        }

        private void MainSythesizer_KeyDown(object sender, KeyEventArgs e)
        {
            Audio.PlaySound(440f, (short)1000, Audio.WaveType.SINE);
        }

        private void WaveFormDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = WaveFormDropDown.Items[WaveFormDropDown.SelectedIndex].ToString();
            waveForms = (WaveForms)Enum.Parse(typeof(WaveForms), str);
        }

        private void PlaySound_Click(object sender, EventArgs e)
        {
            Audio.PlaySineSound(frequency);
        }

        private void FrequencyBar_Scroll(object sender, EventArgs e)
        {
            frequency = FrequencyBar.Value;
        }

        private void AmplitudeBar_Scroll(object sender, EventArgs e)
        {
            amplitude = AmplitudeBar.Value;
        }
    }
}