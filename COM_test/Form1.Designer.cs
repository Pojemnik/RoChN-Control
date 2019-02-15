namespace COM_test
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.Combo = new System.Windows.Forms.ComboBox();
            this.LabelIsConn = new System.Windows.Forms.Label();
            this.ButtonDc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxToSend = new System.Windows.Forms.TextBox();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.SerialPortBt = new System.IO.Ports.SerialPort(this.components);
            this.TextBoxRecived = new System.Windows.Forms.TextBox();
            this.CheckBoxEcho = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckBoxManualMode = new System.Windows.Forms.CheckBox();
            this.CheckBoxRaceMode = new System.Windows.Forms.CheckBox();
            this.CheckBoxDebug = new System.Windows.Forms.CheckBox();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ButtonPitstop = new System.Windows.Forms.Button();
            this.LabelBatt = new System.Windows.Forms.Label();
            this.TabControlMenu = new System.Windows.Forms.TabControl();
            this.TabDataRaw = new System.Windows.Forms.TabPage();
            this.TabOptions = new System.Windows.Forms.TabPage();
            this.ButtonBenchmark = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.NumericUpDownBaudRate = new System.Windows.Forms.NumericUpDown();
            this.BaudRateLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NumericUpDownBattDelay = new System.Windows.Forms.NumericUpDown();
            this.LabelOptionsBattDelay = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimerBenchmark = new System.Windows.Forms.Timer(this.components);
            this.ButtonOfDoom = new System.Windows.Forms.Button();
            this.ToolTipTest = new System.Windows.Forms.ToolTip(this.components);
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.CheckBoxGenerateFile = new System.Windows.Forms.CheckBox();
            this.CheckBoxEnableSensors = new System.Windows.Forms.CheckBox();
            this.ButtonEditWeights = new System.Windows.Forms.Button();
            this.StatusStripBottom = new System.Windows.Forms.StatusStrip();
            this.ToolStripLabelPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabelEmpty = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.NumericUpDownKp = new System.Windows.Forms.NumericUpDown();
            this.LabelKp = new System.Windows.Forms.Label();
            this.GroupBoxCalibration = new System.Windows.Forms.GroupBox();
            this.LabelKi = new System.Windows.Forms.Label();
            this.NumericUpDownPWM = new System.Windows.Forms.NumericUpDown();
            this.LabelPWM = new System.Windows.Forms.Label();
            this.NumericUpDownKi = new System.Windows.Forms.NumericUpDown();
            this.ButtonCheckValues = new System.Windows.Forms.Button();
            this.NumericUpDownKd = new System.Windows.Forms.NumericUpDown();
            this.LabelKd = new System.Windows.Forms.Label();
            this.ButtonSendCallibration = new System.Windows.Forms.Button();
            this.PanelSensors = new System.Windows.Forms.Panel();
            this.PictureBoxSensor11 = new System.Windows.Forms.PictureBox();
            this.PictureBoxSensor10 = new System.Windows.Forms.PictureBox();
            this.PictureBoxSensor9 = new System.Windows.Forms.PictureBox();
            this.PictureBoxSensor8 = new System.Windows.Forms.PictureBox();
            this.PictureBoxSensor7 = new System.Windows.Forms.PictureBox();
            this.PictureBoxSensor6 = new System.Windows.Forms.PictureBox();
            this.PictureBoxSensor5 = new System.Windows.Forms.PictureBox();
            this.PictureBoxSensor4 = new System.Windows.Forms.PictureBox();
            this.PictureBoxSensor3 = new System.Windows.Forms.PictureBox();
            this.PictureBoxSensor2 = new System.Windows.Forms.PictureBox();
            this.PictureBoxSensor1 = new System.Windows.Forms.PictureBox();
            this.PictureBoxSensor0 = new System.Windows.Forms.PictureBox();
            this.ButtonShowSensors = new System.Windows.Forms.Button();
            this.GroupBoxSensors = new System.Windows.Forms.GroupBox();
            this.PictureBoxBatt = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.TabControlMenu.SuspendLayout();
            this.TabDataRaw.SuspendLayout();
            this.TabOptions.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownBaudRate)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownBattDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.StatusStripBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownKp)).BeginInit();
            this.GroupBoxCalibration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownPWM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownKi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownKd)).BeginInit();
            this.PanelSensors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSensor11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSensor10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSensor9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSensor8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSensor7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSensor6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSensor5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSensor4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSensor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSensor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSensor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSensor0)).BeginInit();
            this.GroupBoxSensors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBatt)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Location = new System.Drawing.Point(139, 23);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(75, 23);
            this.ButtonConnect.TabIndex = 0;
            this.ButtonConnect.Text = "Połącz";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // Combo
            // 
            this.Combo.FormattingEnabled = true;
            this.Combo.Location = new System.Drawing.Point(12, 25);
            this.Combo.Name = "Combo";
            this.Combo.Size = new System.Drawing.Size(121, 21);
            this.Combo.TabIndex = 1;
            this.Combo.SelectionChangeCommitted += new System.EventHandler(this.Combo_SelectionChangeCommitted);
            // 
            // LabelIsConn
            // 
            this.LabelIsConn.AutoSize = true;
            this.LabelIsConn.Location = new System.Drawing.Point(9, 49);
            this.LabelIsConn.Name = "LabelIsConn";
            this.LabelIsConn.Size = new System.Drawing.Size(85, 13);
            this.LabelIsConn.TabIndex = 2;
            this.LabelIsConn.Text = "Brak połączenia";
            // 
            // ButtonDc
            // 
            this.ButtonDc.Location = new System.Drawing.Point(220, 23);
            this.ButtonDc.Name = "ButtonDc";
            this.ButtonDc.Size = new System.Drawing.Size(75, 23);
            this.ButtonDc.TabIndex = 3;
            this.ButtonDc.Text = "Rozłącz";
            this.ButtonDc.UseVisualStyleBackColor = true;
            this.ButtonDc.Click += new System.EventHandler(this.ButtonDc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wybierz port:";
            // 
            // TextBoxToSend
            // 
            this.TextBoxToSend.Location = new System.Drawing.Point(12, 355);
            this.TextBoxToSend.Name = "TextBoxToSend";
            this.TextBoxToSend.Size = new System.Drawing.Size(202, 20);
            this.TextBoxToSend.TabIndex = 5;
            // 
            // ButtonSend
            // 
            this.ButtonSend.Location = new System.Drawing.Point(220, 352);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(75, 23);
            this.ButtonSend.TabIndex = 6;
            this.ButtonSend.Text = "Wyślij";
            this.ButtonSend.UseVisualStyleBackColor = true;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // SerialPortBt
            // 
            this.SerialPortBt.BaudRate = 115200;
            this.SerialPortBt.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPortBtDataReceived);
            // 
            // TextBoxRecived
            // 
            this.TextBoxRecived.BackColor = System.Drawing.SystemColors.WindowText;
            this.TextBoxRecived.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxRecived.ForeColor = System.Drawing.SystemColors.Info;
            this.TextBoxRecived.Location = new System.Drawing.Point(0, 0);
            this.TextBoxRecived.Multiline = true;
            this.TextBoxRecived.Name = "TextBoxRecived";
            this.TextBoxRecived.ReadOnly = true;
            this.TextBoxRecived.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxRecived.Size = new System.Drawing.Size(272, 258);
            this.TextBoxRecived.TabIndex = 9;
            this.TextBoxRecived.Text = "Odebrane dane:";
            // 
            // CheckBoxEcho
            // 
            this.CheckBoxEcho.AutoSize = true;
            this.CheckBoxEcho.Location = new System.Drawing.Point(6, 19);
            this.CheckBoxEcho.Name = "CheckBoxEcho";
            this.CheckBoxEcho.Size = new System.Drawing.Size(51, 17);
            this.CheckBoxEcho.TabIndex = 10;
            this.CheckBoxEcho.Text = "Echo";
            this.ToolTipTest.SetToolTip(this.CheckBoxEcho, "Włącz/wyłącz echo konsoli");
            this.CheckBoxEcho.UseVisualStyleBackColor = true;
            this.CheckBoxEcho.CheckStateChanged += new System.EventHandler(this.CheckBoxEcho_CheckStateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CheckBoxManualMode);
            this.groupBox1.Controls.Add(this.CheckBoxRaceMode);
            this.groupBox1.Location = new System.Drawing.Point(3, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 73);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcje robota";
            // 
            // CheckBoxManualMode
            // 
            this.CheckBoxManualMode.AutoSize = true;
            this.CheckBoxManualMode.Location = new System.Drawing.Point(6, 47);
            this.CheckBoxManualMode.Name = "CheckBoxManualMode";
            this.CheckBoxManualMode.Size = new System.Drawing.Size(117, 17);
            this.CheckBoxManualMode.TabIndex = 13;
            this.CheckBoxManualMode.Text = "Sterowanie ręczne ";
            this.ToolTipTest.SetToolTip(this.CheckBoxManualMode, "Umożliwia ręczne sterowanie za pomacą klawiszy strzałek");
            this.CheckBoxManualMode.UseVisualStyleBackColor = true;
            this.CheckBoxManualMode.CheckStateChanged += new System.EventHandler(this.CheckBoxManualMode_CheckStateChanged);
            // 
            // CheckBoxRaceMode
            // 
            this.CheckBoxRaceMode.AutoSize = true;
            this.CheckBoxRaceMode.Checked = true;
            this.CheckBoxRaceMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxRaceMode.Location = new System.Drawing.Point(6, 24);
            this.CheckBoxRaceMode.Name = "CheckBoxRaceMode";
            this.CheckBoxRaceMode.Size = new System.Drawing.Size(106, 17);
            this.CheckBoxRaceMode.TabIndex = 12;
            this.CheckBoxRaceMode.Text = "Przejazd na czas";
            this.ToolTipTest.SetToolTip(this.CheckBoxRaceMode, "Włącz/wyłącz okresowe sprawdzanie stanu baterii");
            this.CheckBoxRaceMode.UseVisualStyleBackColor = true;
            this.CheckBoxRaceMode.CheckStateChanged += new System.EventHandler(this.CheckBoxRaceMode_CheckStateChanged);
            // 
            // CheckBoxDebug
            // 
            this.CheckBoxDebug.AutoSize = true;
            this.CheckBoxDebug.Location = new System.Drawing.Point(305, 72);
            this.CheckBoxDebug.Name = "CheckBoxDebug";
            this.CheckBoxDebug.Size = new System.Drawing.Size(58, 17);
            this.CheckBoxDebug.TabIndex = 11;
            this.CheckBoxDebug.Text = "Debug";
            this.ToolTipTest.SetToolTip(this.CheckBoxDebug, "Wyświetlanie stanów czujników w czasie rzeczywistym");
            this.CheckBoxDebug.UseVisualStyleBackColor = true;
            this.CheckBoxDebug.CheckStateChanged += new System.EventHandler(this.CheckBoxDebug_CheckStateChanged);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(20, 19);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 23);
            this.ButtonStart.TabIndex = 12;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonStop.Location = new System.Drawing.Point(20, 48);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(75, 23);
            this.ButtonStop.TabIndex = 13;
            this.ButtonStop.Text = "Stop";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ButtonPitstop);
            this.groupBox2.Controls.Add(this.ButtonStart);
            this.groupBox2.Controls.Add(this.ButtonStop);
            this.groupBox2.Location = new System.Drawing.Point(314, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(118, 108);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kontrola";
            // 
            // ButtonPitstop
            // 
            this.ButtonPitstop.Location = new System.Drawing.Point(20, 77);
            this.ButtonPitstop.Name = "ButtonPitstop";
            this.ButtonPitstop.Size = new System.Drawing.Size(75, 23);
            this.ButtonPitstop.TabIndex = 14;
            this.ButtonPitstop.Text = "Pitstop";
            this.ButtonPitstop.UseVisualStyleBackColor = true;
            this.ButtonPitstop.Click += new System.EventHandler(this.ButtonPitstop_Click);
            // 
            // LabelBatt
            // 
            this.LabelBatt.AutoSize = true;
            this.LabelBatt.BackColor = System.Drawing.Color.Transparent;
            this.LabelBatt.Location = new System.Drawing.Point(366, 25);
            this.LabelBatt.Name = "LabelBatt";
            this.LabelBatt.Size = new System.Drawing.Size(43, 13);
            this.LabelBatt.TabIndex = 16;
            this.LabelBatt.Text = "Bateria:";
            // 
            // TabControlMenu
            // 
            this.TabControlMenu.Controls.Add(this.TabDataRaw);
            this.TabControlMenu.Controls.Add(this.TabOptions);
            this.TabControlMenu.Location = new System.Drawing.Point(15, 65);
            this.TabControlMenu.Name = "TabControlMenu";
            this.TabControlMenu.SelectedIndex = 0;
            this.TabControlMenu.Size = new System.Drawing.Size(280, 284);
            this.TabControlMenu.TabIndex = 17;
            // 
            // TabDataRaw
            // 
            this.TabDataRaw.Controls.Add(this.TextBoxRecived);
            this.TabDataRaw.Location = new System.Drawing.Point(4, 22);
            this.TabDataRaw.Name = "TabDataRaw";
            this.TabDataRaw.Padding = new System.Windows.Forms.Padding(3);
            this.TabDataRaw.Size = new System.Drawing.Size(272, 258);
            this.TabDataRaw.TabIndex = 0;
            this.TabDataRaw.Text = "Odebrane dane";
            this.TabDataRaw.UseVisualStyleBackColor = true;
            // 
            // TabOptions
            // 
            this.TabOptions.AutoScroll = true;
            this.TabOptions.BackColor = System.Drawing.Color.Transparent;
            this.TabOptions.Controls.Add(this.ButtonBenchmark);
            this.TabOptions.Controls.Add(this.groupBox4);
            this.TabOptions.Controls.Add(this.groupBox3);
            this.TabOptions.Controls.Add(this.groupBox1);
            this.TabOptions.Location = new System.Drawing.Point(4, 22);
            this.TabOptions.Name = "TabOptions";
            this.TabOptions.Size = new System.Drawing.Size(272, 258);
            this.TabOptions.TabIndex = 2;
            this.TabOptions.Text = "Opcje konsoli";
            // 
            // ButtonBenchmark
            // 
            this.ButtonBenchmark.Enabled = false;
            this.ButtonBenchmark.Location = new System.Drawing.Point(134, 39);
            this.ButtonBenchmark.Name = "ButtonBenchmark";
            this.ButtonBenchmark.Size = new System.Drawing.Size(102, 23);
            this.ButtonBenchmark.TabIndex = 2;
            this.ButtonBenchmark.Text = "Test połączenia";
            this.ButtonBenchmark.UseVisualStyleBackColor = true;
            this.ButtonBenchmark.Visible = false;
            this.ButtonBenchmark.Click += new System.EventHandler(this.ButtonBenchmark_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.NumericUpDownBaudRate);
            this.groupBox4.Controls.Add(this.BaudRateLabel);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(235, 71);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Opcje połączenia";
            // 
            // NumericUpDownBaudRate
            // 
            this.NumericUpDownBaudRate.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumericUpDownBaudRate.InterceptArrowKeys = false;
            this.NumericUpDownBaudRate.Location = new System.Drawing.Point(5, 39);
            this.NumericUpDownBaudRate.Maximum = new decimal(new int[] {
            115200,
            0,
            0,
            0});
            this.NumericUpDownBaudRate.Minimum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.NumericUpDownBaudRate.Name = "NumericUpDownBaudRate";
            this.NumericUpDownBaudRate.Size = new System.Drawing.Size(120, 20);
            this.NumericUpDownBaudRate.TabIndex = 1;
            this.NumericUpDownBaudRate.ThousandsSeparator = true;
            this.ToolTipTest.SetToolTip(this.NumericUpDownBaudRate, "Ustaw szybkość transmisji");
            this.NumericUpDownBaudRate.Value = new decimal(new int[] {
            115200,
            0,
            0,
            0});
            this.NumericUpDownBaudRate.ValueChanged += new System.EventHandler(this.NumericUpDownBaudRate_ValueChanged);
            // 
            // BaudRateLabel
            // 
            this.BaudRateLabel.AutoSize = true;
            this.BaudRateLabel.Location = new System.Drawing.Point(5, 23);
            this.BaudRateLabel.Name = "BaudRateLabel";
            this.BaudRateLabel.Size = new System.Drawing.Size(50, 13);
            this.BaudRateLabel.TabIndex = 0;
            this.BaudRateLabel.Text = "Baudrate";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NumericUpDownBattDelay);
            this.groupBox3.Controls.Add(this.LabelOptionsBattDelay);
            this.groupBox3.Controls.Add(this.CheckBoxEcho);
            this.groupBox3.Location = new System.Drawing.Point(3, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 82);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opcje konsoli";
            // 
            // NumericUpDownBattDelay
            // 
            this.NumericUpDownBattDelay.AllowDrop = true;
            this.NumericUpDownBattDelay.Location = new System.Drawing.Point(6, 58);
            this.NumericUpDownBattDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericUpDownBattDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownBattDelay.Name = "NumericUpDownBattDelay";
            this.NumericUpDownBattDelay.Size = new System.Drawing.Size(120, 20);
            this.NumericUpDownBattDelay.TabIndex = 0;
            this.NumericUpDownBattDelay.Tag = "";
            this.NumericUpDownBattDelay.ThousandsSeparator = true;
            this.NumericUpDownBattDelay.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDownBattDelay.ValueChanged += new System.EventHandler(this.NumericUpDownBattDelay_ValueChanged);
            // 
            // LabelOptionsBattDelay
            // 
            this.LabelOptionsBattDelay.AutoSize = true;
            this.LabelOptionsBattDelay.Location = new System.Drawing.Point(6, 42);
            this.LabelOptionsBattDelay.Name = "LabelOptionsBattDelay";
            this.LabelOptionsBattDelay.Size = new System.Drawing.Size(174, 13);
            this.LabelOptionsBattDelay.TabIndex = 1;
            this.LabelOptionsBattDelay.Text = "Odstęp sprawdzania stanu baterii(s)";
            // 
            // Timer1
            // 
            this.Timer1.Interval = 10000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // TimerBenchmark
            // 
            this.TimerBenchmark.Interval = 1000;
            this.TimerBenchmark.Tick += new System.EventHandler(this.TimerBenchmark_Tick);
            // 
            // ButtonOfDoom
            // 
            this.ButtonOfDoom.Location = new System.Drawing.Point(427, 23);
            this.ButtonOfDoom.Name = "ButtonOfDoom";
            this.ButtonOfDoom.Size = new System.Drawing.Size(63, 48);
            this.ButtonOfDoom.TabIndex = 18;
            this.ButtonOfDoom.Text = "Guzik zagłady";
            this.ToolTipTest.SetToolTip(this.ButtonOfDoom, "Zagłada!!!!");
            this.ButtonOfDoom.UseVisualStyleBackColor = true;
            this.ButtonOfDoom.Visible = false;
            this.ButtonOfDoom.Click += new System.EventHandler(this.ButtonOfDoom_Click);
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.Image = global::COM_test.Properties.Resources.male;
            this.PictureBoxLogo.Location = new System.Drawing.Point(438, 301);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(50, 50);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxLogo.TabIndex = 28;
            this.PictureBoxLogo.TabStop = false;
            this.ToolTipTest.SetToolTip(this.PictureBoxLogo, "Autor programu: Andrzej \"Pojemnik\" Gauza\r\nKoło Robotyczne Ósmego Liceum");
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(393, 91);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 29;
            this.ButtonSave.Text = "Zapisz";
            this.ToolTipTest.SetToolTip(this.ButtonSave, "Zapisz dane do pliku");
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // CheckBoxGenerateFile
            // 
            this.CheckBoxGenerateFile.AutoSize = true;
            this.CheckBoxGenerateFile.Location = new System.Drawing.Point(305, 95);
            this.CheckBoxGenerateFile.Name = "CheckBoxGenerateFile";
            this.CheckBoxGenerateFile.Size = new System.Drawing.Size(82, 17);
            this.CheckBoxGenerateFile.TabIndex = 28;
            this.CheckBoxGenerateFile.Text = "Generuj plik";
            this.ToolTipTest.SetToolTip(this.CheckBoxGenerateFile, "Generuj plik z danymi  z robota w formacie lf3");
            this.CheckBoxGenerateFile.UseVisualStyleBackColor = true;
            this.CheckBoxGenerateFile.CheckedChanged += new System.EventHandler(this.CheckBoxGenerateFile_CheckedChanged);
            // 
            // CheckBoxEnableSensors
            // 
            this.CheckBoxEnableSensors.AutoSize = true;
            this.CheckBoxEnableSensors.Location = new System.Drawing.Point(305, 49);
            this.CheckBoxEnableSensors.Name = "CheckBoxEnableSensors";
            this.CheckBoxEnableSensors.Size = new System.Drawing.Size(62, 17);
            this.CheckBoxEnableSensors.TabIndex = 27;
            this.CheckBoxEnableSensors.Text = "Czujniki";
            this.ToolTipTest.SetToolTip(this.CheckBoxEnableSensors, "Włącz/wyłącz czujniki linii w robocie");
            this.CheckBoxEnableSensors.UseVisualStyleBackColor = true;
            this.CheckBoxEnableSensors.CheckedChanged += new System.EventHandler(this.CheckBoxEnableSensors_CheckedChanged);
            // 
            // ButtonEditWeights
            // 
            this.ButtonEditWeights.Location = new System.Drawing.Point(305, 19);
            this.ButtonEditWeights.Name = "ButtonEditWeights";
            this.ButtonEditWeights.Size = new System.Drawing.Size(98, 23);
            this.ButtonEditWeights.TabIndex = 26;
            this.ButtonEditWeights.Text = "Wagi czujników";
            this.ToolTipTest.SetToolTip(this.ButtonEditWeights, "Otwiera okienko z wagami czujników");
            this.ButtonEditWeights.UseVisualStyleBackColor = true;
            this.ButtonEditWeights.Click += new System.EventHandler(this.ButtonEditWeights_Click);
            // 
            // StatusStripBottom
            // 
            this.StatusStripBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLabelPort,
            this.ToolStripStatusLabelEmpty,
            this.toolStripStatusLabel1});
            this.StatusStripBottom.Location = new System.Drawing.Point(0, 540);
            this.StatusStripBottom.Name = "StatusStripBottom";
            this.StatusStripBottom.Size = new System.Drawing.Size(504, 22);
            this.StatusStripBottom.TabIndex = 19;
            this.StatusStripBottom.Text = "statusStrip1";
            // 
            // ToolStripLabelPort
            // 
            this.ToolStripLabelPort.Name = "ToolStripLabelPort";
            this.ToolStripLabelPort.Size = new System.Drawing.Size(58, 17);
            this.ToolStripLabelPort.Text = "Port: Brak";
            // 
            // ToolStripStatusLabelEmpty
            // 
            this.ToolStripStatusLabelEmpty.Name = "ToolStripStatusLabelEmpty";
            this.ToolStripStatusLabelEmpty.Size = new System.Drawing.Size(285, 17);
            this.ToolStripStatusLabelEmpty.Spring = true;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(146, 17);
            this.toolStripStatusLabel1.Text = "Wersja 1.3 Warszawa 2019)";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 540);
            this.splitter1.TabIndex = 20;
            this.splitter1.TabStop = false;
            // 
            // NumericUpDownKp
            // 
            this.NumericUpDownKp.DecimalPlaces = 1;
            this.NumericUpDownKp.Location = new System.Drawing.Point(47, 25);
            this.NumericUpDownKp.Name = "NumericUpDownKp";
            this.NumericUpDownKp.Size = new System.Drawing.Size(48, 20);
            this.NumericUpDownKp.TabIndex = 22;
            // 
            // LabelKp
            // 
            this.LabelKp.AutoSize = true;
            this.LabelKp.Location = new System.Drawing.Point(6, 27);
            this.LabelKp.Name = "LabelKp";
            this.LabelKp.Size = new System.Drawing.Size(23, 13);
            this.LabelKp.TabIndex = 23;
            this.LabelKp.Text = "Kp:";
            // 
            // GroupBoxCalibration
            // 
            this.GroupBoxCalibration.Controls.Add(this.LabelKi);
            this.GroupBoxCalibration.Controls.Add(this.NumericUpDownPWM);
            this.GroupBoxCalibration.Controls.Add(this.LabelPWM);
            this.GroupBoxCalibration.Controls.Add(this.NumericUpDownKi);
            this.GroupBoxCalibration.Controls.Add(this.ButtonCheckValues);
            this.GroupBoxCalibration.Controls.Add(this.NumericUpDownKd);
            this.GroupBoxCalibration.Controls.Add(this.LabelKd);
            this.GroupBoxCalibration.Controls.Add(this.ButtonSendCallibration);
            this.GroupBoxCalibration.Controls.Add(this.LabelKp);
            this.GroupBoxCalibration.Controls.Add(this.NumericUpDownKp);
            this.GroupBoxCalibration.Location = new System.Drawing.Point(314, 204);
            this.GroupBoxCalibration.Name = "GroupBoxCalibration";
            this.GroupBoxCalibration.Size = new System.Drawing.Size(118, 171);
            this.GroupBoxCalibration.TabIndex = 24;
            this.GroupBoxCalibration.TabStop = false;
            this.GroupBoxCalibration.Text = "Kalibracja";
            // 
            // LabelKi
            // 
            this.LabelKi.AutoSize = true;
            this.LabelKi.Location = new System.Drawing.Point(6, 64);
            this.LabelKi.Name = "LabelKi";
            this.LabelKi.Size = new System.Drawing.Size(19, 13);
            this.LabelKi.TabIndex = 30;
            this.LabelKi.Text = "Ki:";
            // 
            // NumericUpDownPWM
            // 
            this.NumericUpDownPWM.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumericUpDownPWM.Location = new System.Drawing.Point(47, 87);
            this.NumericUpDownPWM.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericUpDownPWM.Name = "NumericUpDownPWM";
            this.NumericUpDownPWM.Size = new System.Drawing.Size(48, 20);
            this.NumericUpDownPWM.TabIndex = 27;
            // 
            // LabelPWM
            // 
            this.LabelPWM.AutoSize = true;
            this.LabelPWM.Location = new System.Drawing.Point(4, 89);
            this.LabelPWM.Name = "LabelPWM";
            this.LabelPWM.Size = new System.Drawing.Size(37, 13);
            this.LabelPWM.TabIndex = 26;
            this.LabelPWM.Text = "PWM:";
            // 
            // NumericUpDownKi
            // 
            this.NumericUpDownKi.DecimalPlaces = 1;
            this.NumericUpDownKi.Location = new System.Drawing.Point(47, 62);
            this.NumericUpDownKi.Name = "NumericUpDownKi";
            this.NumericUpDownKi.Size = new System.Drawing.Size(48, 20);
            this.NumericUpDownKi.TabIndex = 29;
            // 
            // ButtonCheckValues
            // 
            this.ButtonCheckValues.Location = new System.Drawing.Point(20, 142);
            this.ButtonCheckValues.Name = "ButtonCheckValues";
            this.ButtonCheckValues.Size = new System.Drawing.Size(75, 23);
            this.ButtonCheckValues.TabIndex = 28;
            this.ButtonCheckValues.Text = "Sprawdź";
            this.ButtonCheckValues.UseVisualStyleBackColor = true;
            this.ButtonCheckValues.Click += new System.EventHandler(this.ButtonCheckValues_Click);
            // 
            // NumericUpDownKd
            // 
            this.NumericUpDownKd.DecimalPlaces = 1;
            this.NumericUpDownKd.Location = new System.Drawing.Point(47, 44);
            this.NumericUpDownKd.Name = "NumericUpDownKd";
            this.NumericUpDownKd.Size = new System.Drawing.Size(48, 20);
            this.NumericUpDownKd.TabIndex = 25;
            // 
            // LabelKd
            // 
            this.LabelKd.AutoSize = true;
            this.LabelKd.Location = new System.Drawing.Point(6, 46);
            this.LabelKd.Name = "LabelKd";
            this.LabelKd.Size = new System.Drawing.Size(23, 13);
            this.LabelKd.TabIndex = 25;
            this.LabelKd.Text = "Kd:";
            // 
            // ButtonSendCallibration
            // 
            this.ButtonSendCallibration.Location = new System.Drawing.Point(20, 113);
            this.ButtonSendCallibration.Name = "ButtonSendCallibration";
            this.ButtonSendCallibration.Size = new System.Drawing.Size(75, 23);
            this.ButtonSendCallibration.TabIndex = 24;
            this.ButtonSendCallibration.Text = "Wyślij";
            this.ButtonSendCallibration.UseVisualStyleBackColor = true;
            this.ButtonSendCallibration.Click += new System.EventHandler(this.ButtonSendCallibration_Click);
            // 
            // PanelSensors
            // 
            this.PanelSensors.Controls.Add(this.PictureBoxSensor11);
            this.PanelSensors.Controls.Add(this.PictureBoxSensor10);
            this.PanelSensors.Controls.Add(this.PictureBoxSensor9);
            this.PanelSensors.Controls.Add(this.PictureBoxSensor8);
            this.PanelSensors.Controls.Add(this.PictureBoxSensor7);
            this.PanelSensors.Controls.Add(this.PictureBoxSensor6);
            this.PanelSensors.Controls.Add(this.PictureBoxSensor5);
            this.PanelSensors.Controls.Add(this.PictureBoxSensor4);
            this.PanelSensors.Controls.Add(this.PictureBoxSensor3);
            this.PanelSensors.Controls.Add(this.PictureBoxSensor2);
            this.PanelSensors.Controls.Add(this.PictureBoxSensor1);
            this.PanelSensors.Controls.Add(this.PictureBoxSensor0);
            this.PanelSensors.Location = new System.Drawing.Point(10, 19);
            this.PanelSensors.Name = "PanelSensors";
            this.PanelSensors.Size = new System.Drawing.Size(283, 105);
            this.PanelSensors.TabIndex = 25;
            this.PanelSensors.Visible = false;
            // 
            // PictureBoxSensor11
            // 
            this.PictureBoxSensor11.Image = global::COM_test.Properties.Resources.sensor_black;
            this.PictureBoxSensor11.Location = new System.Drawing.Point(255, 75);
            this.PictureBoxSensor11.Name = "PictureBoxSensor11";
            this.PictureBoxSensor11.Size = new System.Drawing.Size(20, 20);
            this.PictureBoxSensor11.TabIndex = 38;
            this.PictureBoxSensor11.TabStop = false;
            // 
            // PictureBoxSensor10
            // 
            this.PictureBoxSensor10.Image = global::COM_test.Properties.Resources.sensor_black;
            this.PictureBoxSensor10.Location = new System.Drawing.Point(235, 55);
            this.PictureBoxSensor10.Name = "PictureBoxSensor10";
            this.PictureBoxSensor10.Size = new System.Drawing.Size(20, 20);
            this.PictureBoxSensor10.TabIndex = 37;
            this.PictureBoxSensor10.TabStop = false;
            // 
            // PictureBoxSensor9
            // 
            this.PictureBoxSensor9.Image = global::COM_test.Properties.Resources.sensor_black;
            this.PictureBoxSensor9.Location = new System.Drawing.Point(215, 35);
            this.PictureBoxSensor9.Name = "PictureBoxSensor9";
            this.PictureBoxSensor9.Size = new System.Drawing.Size(20, 20);
            this.PictureBoxSensor9.TabIndex = 36;
            this.PictureBoxSensor9.TabStop = false;
            // 
            // PictureBoxSensor8
            // 
            this.PictureBoxSensor8.Image = global::COM_test.Properties.Resources.sensor_black;
            this.PictureBoxSensor8.Location = new System.Drawing.Point(195, 15);
            this.PictureBoxSensor8.Name = "PictureBoxSensor8";
            this.PictureBoxSensor8.Size = new System.Drawing.Size(20, 20);
            this.PictureBoxSensor8.TabIndex = 35;
            this.PictureBoxSensor8.TabStop = false;
            // 
            // PictureBoxSensor7
            // 
            this.PictureBoxSensor7.Image = global::COM_test.Properties.Resources.sensor_black;
            this.PictureBoxSensor7.Location = new System.Drawing.Point(169, 15);
            this.PictureBoxSensor7.Name = "PictureBoxSensor7";
            this.PictureBoxSensor7.Size = new System.Drawing.Size(20, 20);
            this.PictureBoxSensor7.TabIndex = 34;
            this.PictureBoxSensor7.TabStop = false;
            // 
            // PictureBoxSensor6
            // 
            this.PictureBoxSensor6.Image = global::COM_test.Properties.Resources.sensor_black;
            this.PictureBoxSensor6.Location = new System.Drawing.Point(143, 15);
            this.PictureBoxSensor6.Name = "PictureBoxSensor6";
            this.PictureBoxSensor6.Size = new System.Drawing.Size(20, 20);
            this.PictureBoxSensor6.TabIndex = 33;
            this.PictureBoxSensor6.TabStop = false;
            // 
            // PictureBoxSensor5
            // 
            this.PictureBoxSensor5.Image = global::COM_test.Properties.Resources.sensor_black;
            this.PictureBoxSensor5.Location = new System.Drawing.Point(117, 15);
            this.PictureBoxSensor5.Name = "PictureBoxSensor5";
            this.PictureBoxSensor5.Size = new System.Drawing.Size(20, 20);
            this.PictureBoxSensor5.TabIndex = 32;
            this.PictureBoxSensor5.TabStop = false;
            // 
            // PictureBoxSensor4
            // 
            this.PictureBoxSensor4.Image = global::COM_test.Properties.Resources.sensor_black;
            this.PictureBoxSensor4.Location = new System.Drawing.Point(91, 15);
            this.PictureBoxSensor4.Name = "PictureBoxSensor4";
            this.PictureBoxSensor4.Size = new System.Drawing.Size(20, 20);
            this.PictureBoxSensor4.TabIndex = 31;
            this.PictureBoxSensor4.TabStop = false;
            // 
            // PictureBoxSensor3
            // 
            this.PictureBoxSensor3.Image = global::COM_test.Properties.Resources.sensor_black;
            this.PictureBoxSensor3.Location = new System.Drawing.Point(65, 15);
            this.PictureBoxSensor3.Name = "PictureBoxSensor3";
            this.PictureBoxSensor3.Size = new System.Drawing.Size(20, 20);
            this.PictureBoxSensor3.TabIndex = 30;
            this.PictureBoxSensor3.TabStop = false;
            // 
            // PictureBoxSensor2
            // 
            this.PictureBoxSensor2.Image = global::COM_test.Properties.Resources.sensor_black;
            this.PictureBoxSensor2.Location = new System.Drawing.Point(45, 35);
            this.PictureBoxSensor2.Name = "PictureBoxSensor2";
            this.PictureBoxSensor2.Size = new System.Drawing.Size(20, 20);
            this.PictureBoxSensor2.TabIndex = 29;
            this.PictureBoxSensor2.TabStop = false;
            // 
            // PictureBoxSensor1
            // 
            this.PictureBoxSensor1.Image = global::COM_test.Properties.Resources.sensor_black;
            this.PictureBoxSensor1.Location = new System.Drawing.Point(25, 55);
            this.PictureBoxSensor1.Name = "PictureBoxSensor1";
            this.PictureBoxSensor1.Size = new System.Drawing.Size(20, 20);
            this.PictureBoxSensor1.TabIndex = 28;
            this.PictureBoxSensor1.TabStop = false;
            // 
            // PictureBoxSensor0
            // 
            this.PictureBoxSensor0.Image = global::COM_test.Properties.Resources.sensor_black;
            this.PictureBoxSensor0.Location = new System.Drawing.Point(5, 75);
            this.PictureBoxSensor0.Name = "PictureBoxSensor0";
            this.PictureBoxSensor0.Size = new System.Drawing.Size(20, 20);
            this.PictureBoxSensor0.TabIndex = 27;
            this.PictureBoxSensor0.TabStop = false;
            // 
            // ButtonShowSensors
            // 
            this.ButtonShowSensors.BackColor = System.Drawing.Color.Transparent;
            this.ButtonShowSensors.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonShowSensors.Location = new System.Drawing.Point(438, 357);
            this.ButtonShowSensors.Name = "ButtonShowSensors";
            this.ButtonShowSensors.Size = new System.Drawing.Size(23, 18);
            this.ButtonShowSensors.TabIndex = 26;
            this.ButtonShowSensors.Text = "▼";
            this.ButtonShowSensors.UseVisualStyleBackColor = false;
            this.ButtonShowSensors.Click += new System.EventHandler(this.ButtonShowSensors_Click);
            // 
            // GroupBoxSensors
            // 
            this.GroupBoxSensors.Controls.Add(this.ButtonSave);
            this.GroupBoxSensors.Controls.Add(this.CheckBoxGenerateFile);
            this.GroupBoxSensors.Controls.Add(this.CheckBoxEnableSensors);
            this.GroupBoxSensors.Controls.Add(this.ButtonEditWeights);
            this.GroupBoxSensors.Controls.Add(this.CheckBoxDebug);
            this.GroupBoxSensors.Controls.Add(this.PanelSensors);
            this.GroupBoxSensors.Location = new System.Drawing.Point(12, 381);
            this.GroupBoxSensors.Name = "GroupBoxSensors";
            this.GroupBoxSensors.Size = new System.Drawing.Size(478, 156);
            this.GroupBoxSensors.TabIndex = 27;
            this.GroupBoxSensors.TabStop = false;
            this.GroupBoxSensors.Text = "Opcje czujników";
            // 
            // PictureBoxBatt
            // 
            this.PictureBoxBatt.Image = global::COM_test.Properties.Resources.batt_full;
            this.PictureBoxBatt.Location = new System.Drawing.Point(314, 25);
            this.PictureBoxBatt.Name = "PictureBoxBatt";
            this.PictureBoxBatt.Size = new System.Drawing.Size(46, 54);
            this.PictureBoxBatt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxBatt.TabIndex = 15;
            this.PictureBoxBatt.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.ButtonSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.ButtonStop;
            this.ClientSize = new System.Drawing.Size(504, 562);
            this.Controls.Add(this.PictureBoxLogo);
            this.Controls.Add(this.GroupBoxSensors);
            this.Controls.Add(this.ButtonShowSensors);
            this.Controls.Add(this.GroupBoxCalibration);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.StatusStripBottom);
            this.Controls.Add(this.ButtonOfDoom);
            this.Controls.Add(this.TabControlMenu);
            this.Controls.Add(this.LabelBatt);
            this.Controls.Add(this.PictureBoxBatt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ButtonSend);
            this.Controls.Add(this.TextBoxToSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonDc);
            this.Controls.Add(this.LabelIsConn);
            this.Controls.Add(this.Combo);
            this.Controls.Add(this.ButtonConnect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "RoChN Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.TabControlMenu.ResumeLayout(false);
            this.TabDataRaw.ResumeLayout(false);
            this.TabDataRaw.PerformLayout();
            this.TabOptions.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownBaudRate)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownBattDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.StatusStripBottom.ResumeLayout(false);
            this.StatusStripBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownKp)).EndInit();
            this.GroupBoxCalibration.ResumeLayout(false);
            this.GroupBoxCalibration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownPWM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownKi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownKd)).EndInit();
            this.PanelSensors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSensor11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSensor10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSensor9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSensor8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSensor7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSensor6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSensor5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSensor4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSensor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSensor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSensor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSensor0)).EndInit();
            this.GroupBoxSensors.ResumeLayout(false);
            this.GroupBoxSensors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBatt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.ComboBox Combo;
        private System.Windows.Forms.Label LabelIsConn;
        private System.Windows.Forms.Button ButtonDc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxToSend;
        private System.Windows.Forms.Button ButtonSend;
        private System.IO.Ports.SerialPort SerialPortBt;
        private System.Windows.Forms.TextBox TextBoxRecived;
        private System.Windows.Forms.CheckBox CheckBoxEcho;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox PictureBoxBatt;
        private System.Windows.Forms.Label LabelBatt;
        private System.Windows.Forms.Button ButtonPitstop;
        private System.Windows.Forms.CheckBox CheckBoxRaceMode;
        private System.Windows.Forms.CheckBox CheckBoxDebug;
        private System.Windows.Forms.TabControl TabControlMenu;
        private System.Windows.Forms.TabPage TabDataRaw;
        private System.Windows.Forms.TabPage TabOptions;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown NumericUpDownBattDelay;
        private System.Windows.Forms.Label LabelOptionsBattDelay;
        private System.Windows.Forms.NumericUpDown NumericUpDownBaudRate;
        private System.Windows.Forms.Label BaudRateLabel;
        private System.Windows.Forms.Button ButtonBenchmark;
        private System.Windows.Forms.Timer TimerBenchmark;
        private System.Windows.Forms.Button ButtonOfDoom;
        private System.Windows.Forms.ToolTip ToolTipTest;
        private System.Windows.Forms.StatusStrip StatusStripBottom;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripLabelPort;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.NumericUpDown NumericUpDownKp;
        private System.Windows.Forms.Label LabelKp;
        private System.Windows.Forms.GroupBox GroupBoxCalibration;
        private System.Windows.Forms.Button ButtonSendCallibration;
        private System.Windows.Forms.NumericUpDown NumericUpDownKd;
        private System.Windows.Forms.Label LabelKd;
        private System.Windows.Forms.NumericUpDown NumericUpDownPWM;
        private System.Windows.Forms.Label LabelPWM;
        private System.Windows.Forms.Button ButtonCheckValues;
        private System.Windows.Forms.Panel PanelSensors;
        private System.Windows.Forms.Button ButtonShowSensors;
        private System.Windows.Forms.PictureBox PictureBoxSensor3;
        private System.Windows.Forms.PictureBox PictureBoxSensor2;
        private System.Windows.Forms.PictureBox PictureBoxSensor1;
        private System.Windows.Forms.PictureBox PictureBoxSensor0;
        private System.Windows.Forms.PictureBox PictureBoxSensor4;
        private System.Windows.Forms.PictureBox PictureBoxSensor11;
        private System.Windows.Forms.PictureBox PictureBoxSensor10;
        private System.Windows.Forms.PictureBox PictureBoxSensor9;
        private System.Windows.Forms.PictureBox PictureBoxSensor8;
        private System.Windows.Forms.PictureBox PictureBoxSensor7;
        private System.Windows.Forms.PictureBox PictureBoxSensor6;
        private System.Windows.Forms.PictureBox PictureBoxSensor5;
        private System.Windows.Forms.CheckBox CheckBoxManualMode;
        private System.Windows.Forms.GroupBox GroupBoxSensors;
        private System.Windows.Forms.Button ButtonEditWeights;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabelEmpty;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label LabelKi;
        private System.Windows.Forms.NumericUpDown NumericUpDownKi;
        private System.Windows.Forms.CheckBox CheckBoxEnableSensors;
        private System.Windows.Forms.CheckBox CheckBoxGenerateFile;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

