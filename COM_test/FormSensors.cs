using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            foreach(Control num in GroupBoxSensorsWeights.Controls)
            {
                if(num is NumericUpDown)
                {
                    SetNumericUpDownValue((num as NumericUpDown), e.Values[Int32.Parse(num.Name.Substring(25))-1]);
                }
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
    }
}
