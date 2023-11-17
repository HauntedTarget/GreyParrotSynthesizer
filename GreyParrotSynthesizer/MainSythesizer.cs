namespace GreyParrotSynthesizer
{
    public partial class MainSythesizer : Form
    {

        Audio.WaveType waveType = Audio.WaveType.SINE;
        float frequency = 200f;
        short amplitude = 1000;

        public MainSythesizer()
        {
            InitializeComponent();
            WaveFormDropDown_Load();
        }

        private void WaveFormDropDown_Load()
        {
            WaveFormDropDown.DataSource = System.Enum.GetValues(typeof(Audio.WaveType));
        }

        private void MainSythesizer_KeyDown(object sender, KeyEventArgs e)
        {
            Audio.PlaySineSound(440f);
        }
    }
}