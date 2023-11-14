using System.Media;

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
            if (e.KeyCode == Keys.E) 
            {
                Audio.PlaySineSound(400f);
            }
            else if (e.KeyCode == Keys.R)
            {
                Audio.PlayNoise();
            }
        }
    }
}