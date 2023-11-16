namespace GreyParrotSynthesizer
{
    public partial class MainSythesizer : Form
    {
        public MainSythesizer()
        {
            InitializeComponent();
        }

        private void MainSythesizer_KeyDown(object sender, KeyEventArgs e)
        {
            Audio.PlaySound(440f, (short)1000, Audio.WaveType.SINE);
        }
    }
}