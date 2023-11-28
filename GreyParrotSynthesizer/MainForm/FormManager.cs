using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreyParrotSynthesizer.Main
{
    internal class FormManager : ApplicationContext
    {
        private static Lazy<FormManager> _current = new Lazy<FormManager>();
        public static FormManager Current => _current.Value;

        private List<Form> forms = new List<Form>();

        public enum FormSelection { MainSynthesizer = 0, UserWaveView = 1, MainMenu = 2 }
        public FormManager()
        {
            //adds forms
            forms.Add(CreateForm<MainSythesizer>());
            forms.Add(CreateForm<UserWaveView>());
            forms.Add(CreateForm<MainMenu>());
            //sets first form to the main one
            OpenOneForm(FormSelection.MainMenu);
        }

        //opens one form closes the others
        public void OpenOneForm(FormSelection FormToOpen)
        {
            if (FormToOpen == FormSelection.MainSynthesizer)
            {
                //opening selected form
                forms[(int)FormSelection.MainSynthesizer].Show();
            }
            else
            {
                //hiding other forms
                forms[(int)FormSelection.MainSynthesizer].Hide();
            }

            if (FormToOpen == FormSelection.UserWaveView)
            {
                forms[(int)FormSelection.UserWaveView].Show();
            }
            else
            {
                forms[(int)FormSelection.UserWaveView].Hide();
            }

            if (FormToOpen == FormSelection.MainMenu)
            {
                forms[(int)FormSelection.MainMenu].Show();
            }
            else
            {
                forms[(int)FormSelection.MainMenu].Hide();
            }
        }

        //opens a form but leaves the others open
        public void OpenForm(FormSelection FormToOpen)
        {
            forms[(int)FormToOpen].Show();
        }

        //opens one form that is required to finish before going to the others
        public void OpenRequiredForm(FormSelection FormToRequire)
        {
            forms[(int)FormToRequire].ShowDialog();
        }

        //hides the selected form
        public void HideForm(FormSelection FormToHide)
        {
            forms[(int)FormToHide].Hide();
        }

        private void onFormClosed(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                ExitThread();
            }
        }

        public T CreateForm<T>() where T : Form, new()
        {
            var ret = new T();
            ret.FormClosed += onFormClosed;
            return ret;
        }
    }
}
