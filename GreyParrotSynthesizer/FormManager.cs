using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreyParrotSynthesizer
{
    internal class FormManager : ApplicationContext
    {
        private static Lazy<FormManager> _current = new Lazy<FormManager>();
        public static FormManager Current => _current.Value;

        private List<Form> forms = new List<Form>();

        public enum FormSelection { MainSynthesizer = 0, UserWaveView = 1, TestForm = 2 }
        public FormManager()
        {
            forms.Add(CreateForm<MainSythesizer>());
            forms.Add(CreateForm<UserWaveView>());
            forms.Add(CreateForm<TestForm>());
            OpenOneForm(FormSelection.MainSynthesizer);
        }
        public void OpenOneForm(FormSelection FormToOpen)
        {
            if (FormToOpen == FormSelection.MainSynthesizer)
            {
                forms[(int)FormSelection.MainSynthesizer].Show();
            }
            else
            {
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

        public void OpenForm(FormSelection FormToOpen)
        {
            forms[(int)FormToOpen].Show();
        }

        public void OpenRequiredForm(FormSelection FormToRequire)
        {
            forms[(int)FormToRequire].ShowDialog();
        }

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
