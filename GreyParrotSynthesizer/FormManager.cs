using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreyParrotSynthesizer
{
    internal class FormManager : ApplicationContext
    {
#pragma warning disable IDE0044 // Add readonly modifier
        private static Lazy<FormManager> _current = new();
#pragma warning restore IDE0044 // Add readonly modifier
        public static FormManager Current => _current.Value;

#pragma warning disable IDE0044 // Add readonly modifier
        private List<Form> forms = new();
#pragma warning restore IDE0044 // Add readonly modifier

        public enum FormSelection { MainSynthesizer = 0, UserWaveView = 1, TestForm = 2 }
        public FormManager()
        {
            //adds forms
            forms.Add(CreateForm<MainSythesizer>());
            forms.Add(CreateForm<UserWaveView>());
            forms.Add(CreateForm<TestForm>());
            //sets first form to the main one
            OpenOneForm(FormSelection.MainSynthesizer);
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

            if (FormToOpen == FormSelection.TestForm)
            {
                forms[(int)FormSelection.TestForm].Show();
            }
            else
            {
                forms[(int)FormSelection.TestForm].Hide();
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

        private void OnFormClosed(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                ExitThread();
            }
        }

        public T CreateForm<T>() where T : Form, new()
        {
            var ret = new T();
            ret.FormClosed += OnFormClosed;
            return ret;
        }
    }
}
