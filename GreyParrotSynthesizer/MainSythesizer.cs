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
                Audio.PlaySound(400f);
            }
        }
    }
}