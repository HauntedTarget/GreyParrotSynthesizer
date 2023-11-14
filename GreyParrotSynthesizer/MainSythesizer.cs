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
            Audio.PlaySineSound(440f);
        }
    }
}