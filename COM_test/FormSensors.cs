using System;
using System.Windows.Forms;

namespace COM_test
{
    public partial class FormSensors : Form
    {
        public FormSensors()
        {
            InitializeComponent();
        }

        private Form1 MainForm;

        public FormSensors(Form1 callingForm)
        {
            MainForm = callingForm;
            InitializeComponent();
        }

        private void HandleSensorsWeightsRecived(object sender, SensorsWeightsRecivedEventArgs e)
        {
            if (e.Values.Length == 12)
            {
                foreach (Control num in GroupBoxSensorsWeights.Controls)
                {
                    if (num is NumericUpDown)
                    {
                        if (num.Name[13] != 'A')
                        {
                            SetNumericUpDownValue((num as NumericUpDown), e.Values[Int16.Parse(num.Name.Substring(25)) - 1]);
                        }
                    }
                }
            }
            else
            {
                SetNumericUpDownValue(NumericUpDownASensor1, Convert.ToDecimal(e.Values[0]));
                SetNumericUpDownValue(NumericUpDownASensor2, Convert.ToDecimal(e.Values[1]));
            }
        }

        public void SetNumericUpDownValue(NumericUpDown numeric, decimal value)
        {
            MethodInvoker methodInvokerDelegate = delegate () { numeric.Value = value; };
            if (this.InvokeRequired)
                this.Invoke(methodInvokerDelegate);
            else
                methodInvokerDelegate();
        }

        private void ButtonCheckWeights_Click(object sender, EventArgs e)
        {
            MainForm.SerialSend(Commands.CheckSensorsWeights);
        }

        private void FormSensors_Load(object sender, EventArgs e)
        {
            MainForm.SensorsWeightsRecived += HandleSensorsWeightsRecived;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            foreach (Control num in GroupBoxSensorsWeights.Controls)
            {
                if (num is NumericUpDown)
                {
                    if (num.Name[13] != 'A')
                    {
                        MainForm.SensorsWeights[Int16.Parse(num.Name.Substring(25)) - 1] = Convert.ToInt16((num as NumericUpDown).Value);
                    }
                    else
                    {
                        if (num.Name[20] == '1')
                            MainForm.AdditionalSensorsWeights[0] = Convert.ToInt16((num as NumericUpDown).Value);
                        if (num.Name[20] == '2')
                            MainForm.AdditionalSensorsWeights[1] = Convert.ToInt16((num as NumericUpDown).Value);
                    }
                }
            }
        }
    }
}
