using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Globalization;

namespace COM_test
{
    public partial class Form1 : Form
    {
        delegate void SetTextCallback(string text);
        delegate void SetLabelBattTextCallback(string text);
        delegate void SetBattLevelImgCallback(string data);
        delegate void SetKpValueCallback(Decimal value);
        delegate void NumericUpDownKpSetIncrementCallback(Decimal value);
        delegate void SetKdValueCallback(Decimal value);
        delegate void NumericUpDownKdSetIncrementCallback(Decimal value);
        delegate void SetKiValueCallback(Decimal value);
        delegate void NumericUpDownKiSetIncrementCallback(Decimal value);
        delegate void SetPWMValueCallback(int value);
        //delegate void SetPanelSensorsVisibilityCallback(bool value);
        private bool Echo = false;
        private bool Benchmark = false;
        private bool BattFlat = false;
        private bool RaceMode = true;
        private int BenchmarkResult;
        private bool ExternalPower = false;
        public bool Debug = false;
        private bool ManualMode = false;
        public int[] SensorsWeights = new int[12];
        String DataIncomplete = String.Empty;

        public event EventHandler SensorsWeightsRecived;

        public Form1()
        {
            InitializeComponent();
            Echo = false;
            string[] ports = SerialPort.GetPortNames();
            foreach (string a in ports)
                Combo.Items.Add(a);
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Application.DoEvents();
                SerialPortBt.Open();
                LabelIsConn.Text = "Połączony";
                ToolStripLabelPort.Text = "Port: " + SerialPortBt.PortName + " Baudrate: " + SerialPortBt.BaudRate;
                //Timer1.Start();
                SerialSend(Commands.SetMode);
                SerialSend(Commands.Info);
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Błąd! Nie można otworzyć portu.");
                Cursor.Current = Cursors.Default;
            }
        }
        private void ButtonDc_Click(object sender, EventArgs e)
        {
            if (SerialPortBt.IsOpen)
                SerialPortBt.Close();
            Timer1.Stop();
            LabelIsConn.Text = "Brak Połączenia";
            ToolStripLabelPort.Text = "Port: Brak";
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            if (TextBoxToSend.Text != String.Empty)
            {
                if (TextBoxToSend.Text.Length == 4 && TextBoxToSend.Text.StartsWith("0x"))
                {
                    string Text = TextBoxToSend.Text;
                    Text = Text.Remove(0, 2);
                    byte Data = Convert.ToByte(Text, 16);
                    SerialSend(Data);
                }
                else
                    SerialSend(TextBoxToSend.Text);
                TextBoxToSend.Text = String.Empty;
            }
        }

        private void Combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (SerialPortBt.IsOpen)
                SerialPortBt.Close();
            LabelIsConn.Text = "Brak Połączenia";
            ToolStripLabelPort.Text = "Port: Brak";
            SerialPortBt.PortName = Combo.SelectedItem.ToString();
        }

        private void SerialPortBtDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (Benchmark)
            {
                SerialSend("1");
                BenchmarkResult++;
                return;
            }
            String Data = String.Empty;
            if (DataIncomplete != String.Empty)
            {
                Data = DataIncomplete;
                DataIncomplete = String.Empty;
            }
            Data += SerialPortBt.ReadExisting();
            Data = Data.Replace("\0", String.Empty);
            Queue<string> DataQueue = new Queue<string>(Data.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries));
            while (DataQueue.Count > 0)
            {
                if (DataQueue.Peek() == String.Empty)
                {
                    DataQueue.Dequeue();
                    if (DataQueue.Count == 0)
                        break;
                }
                char DataCode = 'x';
                if (Char.GetUnicodeCategory(DataQueue.Peek()[0]) == UnicodeCategory.UppercaseLetter)
                {
                    if (Char.ToLower(DataQueue.Peek()[0]) != DataQueue.Peek()[DataQueue.Peek().Length - 1])
                    {
                        Data = String.Empty;
                        DataIncomplete = DataQueue.Dequeue();
                        DataCode = 'i';//data incomplete
                    }
                    else
                    {
                        DataCode = DataQueue.Peek()[0];
                        Data = DataQueue.Peek().Substring(1, DataQueue.Peek().Length - 2);
                    }
                }
                switch (DataCode)
                {
                    case 'B':
                        /*
                        if (DataQueue.Peek()[DataQueue.Peek().Length - 1] != 'b')
                        {
                            Data = String.Empty;
                            DataIncomplete = DataQueue.Dequeue();
                            break;
                        }*/
                        SetText(Environment.NewLine + "B:");
                        Single BattValue = 0;
                        try { BattValue = Convert.ToSingle(Data); }
                        catch
                        {
                            MessageBox.Show("Błąd odczytu danych(stan baterii)!");
                            DataQueue.Dequeue();
                        }
                        DataQueue.Dequeue();
                        if (BattValue < 100)
                        {
                            ExternalPower = true;
                            SetLabelBattText(Environment.NewLine + "Zasilanie zewnętrzne");
                            SetBattLevelImg("full");
                        }
                        else
                        {
                            ExternalPower = false;
                            if (BattValue < 165)
                            {
                                BattFlat = true;
                                MessageBox.Show("Bateria w stanie krytycznym!");
                                SetLabelBattText(Convert.ToString(Math.Round(BattValue / 0.255) / 100) + "V" + Environment.NewLine + "0%");
                                SetBattLevelImg("empty");
                                return;
                            }
                            else
                            {
                                BattFlat = false;
                                if (BattValue >= 215)
                                {
                                    SetLabelBattText(Convert.ToString(Math.Round(BattValue / 0.255) / 100) + "V" + Environment.NewLine + "100%");
                                    SetBattLevelImg("full");
                                    return;
                                }
                                else
                                {
                                    int BattPercent = Convert.ToInt32((BattValue - 165) * 2);
                                    SetLabelBattText(Convert.ToString(Math.Round(BattValue / 0.255) / 100) + "V" + Environment.NewLine + BattPercent + "%");
                                    if (BattPercent >= 75)
                                    {
                                        SetBattLevelImg("full");
                                    }
                                    if (BattPercent >= 50 && BattPercent < 75)
                                    {
                                        SetBattLevelImg("75%");
                                    }
                                    if (BattPercent >= 25 && BattPercent < 50)
                                    {
                                        SetBattLevelImg("50%");
                                    }
                                    if (BattPercent < 25)
                                    {
                                        SetBattLevelImg("25%");
                                    }
                                }

                            }
                        }
                        break;
                    case 'C':
                        if (!Debug)
                        {
                            SetText(Environment.NewLine + "Czujniki:");
                        }
                        SetText(Environment.NewLine);
                        string temp = DataQueue.Dequeue().Substring(1, 12);
                        foreach (PictureBox PB in PanelSensors.Controls)
                        {
                            int num = 0;
                            if (PB.Name.Length == 17)
                                num = PB.Name[PB.Name.Length - 1] - '0';
                            else
                            if (PB.Name.Length == 18)
                                num = Int32.Parse(PB.Name.Substring(PB.Name.Length - 2));
                            if (temp[num] == '0')
                                PB.Image = Properties.Resources.sensor_white;
                            else
                                PB.Image = Properties.Resources.sensor_black;
                        }
                        break;
                    case 'P':
                        SetText(Environment.NewLine + "Kp:");
                        SetKpValue(Convert.ToDecimal(Data, CultureInfo.InvariantCulture));
                        DataQueue.Dequeue();
                        break;
                    case 'I':
                        SetText(Environment.NewLine + "Ki:");
                        SetKiValue(Convert.ToDecimal(Data, CultureInfo.InvariantCulture));
                        DataQueue.Dequeue();
                        break;
                    case 'D':
                        SetText(Environment.NewLine + "Kd:");
                        SetKdValue(Convert.ToDecimal(Data, CultureInfo.InvariantCulture));
                        DataQueue.Dequeue();
                        break;
                    case 'W':
                        SetText(Environment.NewLine + "PWM:");
                        SetPWMValue(Int32.Parse(Data));
                        DataQueue.Dequeue();
                        break;
                    case 'i':
                        break;
                    case 'Q':
                        string[] Val = Data.Split(new char[] { ':' });
                        SensorsWeights[Int32.Parse(Val[0])] = Int32.Parse(Val[1]);
                        DataQueue.Dequeue();
                        //OnSensorsWeightsRecived();
                        break;
                    default:
                        DataQueue.Dequeue();
                        break;
                }
                if (Data != String.Empty)
                {
                    //if(!Debug || Data!="000000000000")
                    SetText(Data);
                    Data = String.Empty;
                }
            }
        }

        private void SetText(string text)
        {
            if (this.TextBoxRecived.InvokeRequired)
            {
                SetTextCallback x = new SetTextCallback(SetText);
                this.Invoke(x, new object[] { text });
            }
            else
            {
                if (TextBoxRecived.Text == "Odebrane dane:")
                {
                    TextBoxRecived.Text = String.Empty;
                    text = text.Replace(Environment.NewLine, "");
                }
                this.TextBoxRecived.AppendText(text);
            }
        }

        private void SetLabelBattText(string text)
        {
            if (this.LabelBatt.InvokeRequired)
            {
                SetLabelBattTextCallback x = new SetLabelBattTextCallback(SetLabelBattText);
                this.Invoke(x, new object[] { text });
            }
            else
            {
                LabelBatt.Text = "Bateria: " + text;
            }
        }

        private void SetKpValue(Decimal value)
        {
            if (this.NumericUpDownKp.InvokeRequired)
            {
                SetKpValueCallback x = new SetKpValueCallback(SetKpValue);
                this.Invoke(x, new object[] { value });
            }
            else
            {
                NumericUpDownKp.Value = value;
            }
        }

        private void SetKdValue(Decimal value)
        {
            if (this.NumericUpDownKd.InvokeRequired)
            {
                SetKdValueCallback x = new SetKdValueCallback(SetKdValue);
                this.Invoke(x, new object[] { value });
            }
            else
            {
                NumericUpDownKd.Value = value;
            }
        }

        private void SetKiValue(Decimal value)
        {
            if (this.NumericUpDownKi.InvokeRequired)
            {
                SetKiValueCallback x = new SetKiValueCallback(SetKiValue);
                this.Invoke(x, new object[] { value });
            }
            else
            {
                NumericUpDownKi.Value = value;
            }
        }

        private void SerialSend(byte data)
        {
            byte[] Data = new byte[1];
            Data[0] = data;
            string DataValue = System.Text.Encoding.ASCII.GetString(Data);
            if (Commands.IsPowerSensitive(DataValue))
            {
                if (ExternalPower)
                {
                    MessageBox.Show("Błąd! Nie można wykonać przy zwenętrznym zasilaniu!");
                    return;
                }
                if (BattFlat)
                {
                    MessageBox.Show("Błąd! Nie można wykonać przy słabej baterii!");
                    return;
                }
            }
            if (SerialPortBt.IsOpen)
            {
                SerialPortBt.Write(Data, 0, 1);
                if (Echo)
                {
                    SetText(DataValue + Environment.NewLine);
                }
            }
            else
            {
                MessageBox.Show("Port nie jest otwarty!");
            }
        }

        public void SerialSend(string data)
        {
            if (Commands.IsPowerSensitive(data))
            {
                if (ExternalPower)
                {
                    MessageBox.Show("Błąd! Nie można wykonać przy zwenętrznym zasilaniu!");
                    return;
                }
                if (BattFlat)
                {
                    MessageBox.Show("Błąd! Nie można wykonać przy słabej baterii!");
                    return;
                }
            }
            if (SerialPortBt.IsOpen)
            {
                SerialPortBt.WriteLine(data);
                if (Echo)
                {
                    SetText(data + Environment.NewLine);
                }
            }
            else
            {
                MessageBox.Show("Port nie jest otwarty!");
            }
        }

        private void SetBattLevelImg(string data)
        {
            if (this.PictureBoxBatt.InvokeRequired)
            {
                SetBattLevelImgCallback x = new SetBattLevelImgCallback(SetBattLevelImg);
                this.Invoke(x, new object[] { data });
            }
            else
            {
                switch (data)
                {
                    case "empty":
                        PictureBoxBatt.Image = Properties.Resources.batt_empty;
                        break;
                    case "full":
                        PictureBoxBatt.Image = Properties.Resources.batt_full;
                        break;
                    case "25%":
                        PictureBoxBatt.Image = Properties.Resources.batt_25_;
                        break;
                    case "75%":
                        PictureBoxBatt.Image = Properties.Resources.batt_75_;
                        break;
                    case "50%":
                        PictureBoxBatt.Image = Properties.Resources.batt_50_;
                        break;
                    default:
                        PictureBoxBatt.Image = Properties.Resources.batt_full;
                        break;
                }
            }
        }

        private void CheckBoxEcho_CheckStateChanged(object sender, EventArgs e)
        {
            Echo = CheckBoxEcho.Checked;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            SerialSend(Commands.Start);
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            SerialSend(Commands.Stop);
        }

        private void ButtonPitstop_Click(object sender, EventArgs e)
        {
            SerialSend(Commands.Pitstop);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (!RaceMode)
                SerialSend(Commands.BattCheck);
        }

        private void NumericUpDownBattDelay_ValueChanged(object sender, EventArgs e)
        {
            Timer1.Interval = Convert.ToInt32(NumericUpDownBattDelay.Value) * 1000;
        }

        private void NumericUpDownBaudRate_ValueChanged(object sender, EventArgs e)
        {
            if (SerialPortBt.IsOpen)
                SerialPortBt.Close();
            SerialPortBt.BaudRate = Convert.ToInt32(NumericUpDownBaudRate.Value);
        }

        private void ButtonBenchmark_Click(object sender, EventArgs e)
        {
            BenchmarkResult = 0;
            Benchmark = true;
            SerialSend(Commands.Benchmark);
            Cursor.Current = Cursors.WaitCursor;
            TimerBenchmark.Start();
        }

        private void CheckBoxRaceMode_CheckStateChanged(object sender, EventArgs e)
        {
            RaceMode = CheckBoxRaceMode.Checked;
            if (CheckBoxRaceMode.Checked)
                Timer1.Stop();
            else
                Timer1.Start();
        }

        private void TimerBenchmark_Tick(object sender, EventArgs e)
        {
            Benchmark = false;
            SerialSend(Commands.Benchmark);
            TimerBenchmark.Stop();
            Cursor.Current = Cursors.Default;
            MessageBox.Show(Convert.ToString(BenchmarkResult));
        }

        new private void Resize(int width, int height)
        {
            this.Size = new System.Drawing.Size(width, height);
        }

        private void ButtonOfDoom_Click(object sender, EventArgs e)
        {
            OnSensorsWeightsRecived(new EventArgs());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NumericUpDownKpSetIncrement(0.1M);
            NumericUpDownKdSetIncrement(0.1M);
            NumericUpDownKiSetIncrement(0.1M);
            ButtonShowSensors_Click(this, new EventArgs());
            foreach (PictureBox PB in PanelSensors.Controls)
            {
                PB.Image = Properties.Resources.sensor_white;
            }
        }

        private void NumericUpDownKpSetIncrement(Decimal value)
        {
            if (this.NumericUpDownKp.InvokeRequired)
            {
                NumericUpDownKpSetIncrementCallback x = new NumericUpDownKpSetIncrementCallback(NumericUpDownKpSetIncrement);
                this.Invoke(x, new object[] { value });
            }
            else
            {
                NumericUpDownKp.Increment = value;
            }
        }

        private void NumericUpDownKdSetIncrement(Decimal value)
        {
            if (this.NumericUpDownKd.InvokeRequired)
            {
                NumericUpDownKdSetIncrementCallback x = new NumericUpDownKdSetIncrementCallback(NumericUpDownKdSetIncrement);
                this.Invoke(x, new object[] { value });
            }
            else
            {
                NumericUpDownKd.Increment = value;
            }
        }

        private void NumericUpDownKiSetIncrement(Decimal value)
        {
            if (this.NumericUpDownKi.InvokeRequired)
            {
                NumericUpDownKiSetIncrementCallback x = new NumericUpDownKiSetIncrementCallback(NumericUpDownKiSetIncrement);
                this.Invoke(x, new object[] { value });
            }
            else
            {
                NumericUpDownKi.Increment = value;
            }
        }

        private void SetPWMValue(int value)
        {
            if (this.NumericUpDownPWM.InvokeRequired)
            {
                SetPWMValueCallback x = new SetPWMValueCallback(SetPWMValue);
                this.Invoke(x, new object[] { value });
            }
            else
            {
                NumericUpDownPWM.Value = value;
            }
        }

        private void ButtonSendCallibration_Click(object sender, EventArgs e)
        {
            SerialSend(Commands.SetKp + Convert.ToString(NumericUpDownKp.Value, CultureInfo.InvariantCulture));
            SerialSend(Commands.SetKd + Convert.ToString(NumericUpDownKd.Value, CultureInfo.InvariantCulture));
            SerialSend(Commands.SetPWM + Convert.ToString(NumericUpDownPWM.Value, CultureInfo.InvariantCulture) + Commands.IntEnd);
            ButtonCheckValues_Click(this, new EventArgs());
        }

        private void ButtonCheckValues_Click(object sender, EventArgs e)
        {
            SerialSend(Commands.KpValue);
            SerialSend(Commands.KdValue);
            SerialSend(Commands.PWMValue);
        }

        private void ButtonShowSensors_Click(object sender, EventArgs e)
        {
            if (this.Size.Height == 440 || Debug)
            {
                Resize(this.Size.Width, 600);
                ButtonShowSensors.Text = "▲";
                SetControlVisibility(GroupBoxSensors, true);
                SetControlVisibility(PanelSensors, true);
            }
            else
            {
                Resize(this.Size.Width, 440);
                ButtonShowSensors.Text = "▼";
                SetControlVisibility(GroupBoxSensors, false);
                SetControlVisibility(PanelSensors, false);
            }
        }

        private void SetControlVisibility(Control control, bool value)
        {
            MethodInvoker methodInvokerDelegate = delegate () { control.Visible = value; };
            if (this.InvokeRequired)
                this.Invoke(methodInvokerDelegate);
            else
                methodInvokerDelegate();
        }

        private void SetControlEnabled(Control control, bool value)
        {
            MethodInvoker methodInvokerDelegate = delegate () { control.Enabled = value; };
            if (this.InvokeRequired)
                this.Invoke(methodInvokerDelegate);
            else
                methodInvokerDelegate();
        }

        private void CheckBoxDebug_CheckStateChanged(object sender, EventArgs e)
        {
            SerialSend(Commands.SetDebug);
            Debug = CheckBoxDebug.Checked;
            ButtonShowSensors_Click(this, new EventArgs());
        }

        private void CheckBoxManualMode_CheckStateChanged(object sender, EventArgs e)
        {
            ManualMode = CheckBoxManualMode.Checked;
            SerialSend(Commands.ManualMode);
            if (CheckBoxManualMode.Checked)
            {
                SetControlEnabled(TabControlMenu, false);
            }
            else
            {
                SetControlEnabled(TabControlMenu, true);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (ManualMode)
            {
                if (e.KeyCode == Keys.Up)
                {
                    SerialSend(Commands.Forward);
                }
                if (e.KeyCode == Keys.Left)
                {
                    SerialSend(Commands.Left);
                }
                if (e.KeyCode == Keys.Right)
                {
                    SerialSend(Commands.Right);
                }
                if (e.KeyCode == Keys.Down)
                {
                    SerialSend(Commands.Back);
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (ManualMode)
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Down)
                {
                    SerialSend(Commands.Stop);
                }
            }
        }

        private void ButtonEditWeights_Click(object sender, EventArgs e)
        {
            FormSensors formSensors = new FormSensors(this);
            formSensors.Show();
        }

        protected virtual void OnSensorsWeightsRecived(EventArgs e)
        {
            SensorsWeightsRecived?.Invoke(this, e);
        }
    }

    public static class Commands
    {
        public const string Start = "8";
        public const string Stop = "s";
        public const string Pitstop = "6";
        public const string BattCheck = "5";
        public const string Benchmark = "b";
        public const string SetMode = "2";
        public const string Info = "V";
        public const string KdValue = "d";
        public const string KpValue = "p";
        public const string PWMValue = "w";
        public const string SetKd = "D";
        public const string SetKp = "P";
        public const string SetPWM = "W";
        public const string IntEnd = "X";
        public const string SetDebug = "g";
        public const string ManualMode = "m";
        public const string Forward = "^";
        public const string Back = "B";
        public const string Right = ">";
        public const string Left = "<";
        public const string CheckSensorsWeights = "Q";
        public const string SwitchSensors = "7";
        public const string KiValue = "i";
        public const string SetKi = "I";

        public static string[] PowerSensitive = { Start, Pitstop };

        public static bool IsPowerSensitive(string data)
        {
            foreach (string x in PowerSensitive)
            {
                if (x == data)
                    return true;
            }
            return false;
        }
    }

    public class SesorsWeightsRecivedEventArgs : EventArgs //WTF
    {
        public String[] Values { get; set; }
    }
}
