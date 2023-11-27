using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GreyParrotSynthesizer.Main;

namespace GreyParrotSynthesizer
{
    public partial class UserWaveView : Form
    {
        public UserWaveView()
        {
            InitializeComponent();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            FormManager.Current.HideForm(FormManager.FormSelection.MainSynthesizer);
        }
    }
}
