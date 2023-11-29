using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreyParrotSynthesizer
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormManager.Current.OpenOneForm(FormManager.FormSelection.MainSynthesizer);
            MainSythesizer ms = Application.OpenForms.OfType<MainSythesizer>().First();
            ms.SetDesktopLocation(20, 200);

            FormManager.Current.OpenForm(FormManager.FormSelection.UserWaveView);
            UserWaveView userWaveView = Application.OpenForms.OfType<UserWaveView>().First();
            userWaveView.SetDesktopLocation(1170, 200);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
