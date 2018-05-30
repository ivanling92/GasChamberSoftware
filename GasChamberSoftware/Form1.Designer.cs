namespace GasChamberSoftware
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.serialPort_nano = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pressureBox = new System.Windows.Forms.TextBox();
            this.tempBox = new System.Windows.Forms.TextBox();
            this.humidBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nano_portname = new System.Windows.Forms.ComboBox();
            this.ConnectLabel = new System.Windows.Forms.Label();
            this.nano_connect = new System.Windows.Forms.Button();
            this.intVolt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.autoRead = new System.Windows.Forms.Button();
            this.memCount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.saveButt = new System.Windows.Forms.Button();
            this.clearButt = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.stopButt = new System.Windows.Forms.Button();
            this.pressureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.temperatureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.humidityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.ResetChart = new System.Windows.Forms.Button();
            this.recordBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fz_pressure = new System.Windows.Forms.CheckBox();
            this.fz_temp = new System.Windows.Forms.CheckBox();
            this.fz_humidity = new System.Windows.Forms.CheckBox();
            this.scroll_pressure = new System.Windows.Forms.CheckBox();
            this.scroll_temp = new System.Windows.Forms.CheckBox();
            this.scroll_humid = new System.Windows.Forms.CheckBox();
            this.zoomFactor = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.no2Box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.h2Box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nh3Box = new System.Windows.Forms.TextBox();
            this.coBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DPWMBox = new System.Windows.Forms.TextBox();
            this.APWMBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.scrollNO2 = new System.Windows.Forms.CheckBox();
            this.fz_NO2 = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.no2Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.scroll_nh3 = new System.Windows.Forms.CheckBox();
            this.fz_NH3 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nh3Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.scroll_co = new System.Windows.Forms.CheckBox();
            this.fz_CO = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.coChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.scroll_h2 = new System.Windows.Forms.CheckBox();
            this.fz_h2 = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.h2Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusLogBox = new System.Windows.Forms.RichTextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.analyteBox = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.diluentBox = new System.Windows.Forms.ComboBox();
            this.analyteBar = new System.Windows.Forms.TrackBar();
            this.diluentBar = new System.Windows.Forms.TrackBar();
            this.Heat_But = new System.Windows.Forms.Button();
            this.ambtempBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.heaterIndicator = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.TempController = new System.Windows.Forms.CheckBox();
            this.tempSetpointBox = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.manualCommandBox = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.CommandBut = new System.Windows.Forms.Button();
            this.RawOutput = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pressureChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humidityChart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.no2Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nh3Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h2Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analyteBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diluentBar)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort_nano
            // 
            this.serialPort_nano.PortName = "COM3";
            this.serialPort_nano.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_nano_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pressure (hPa)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Heater Temp (c)";
            // 
            // pressureBox
            // 
            this.pressureBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressureBox.Location = new System.Drawing.Point(132, 28);
            this.pressureBox.Name = "pressureBox";
            this.pressureBox.ReadOnly = true;
            this.pressureBox.Size = new System.Drawing.Size(149, 38);
            this.pressureBox.TabIndex = 2;
            this.pressureBox.Text = "0";
            // 
            // tempBox
            // 
            this.tempBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempBox.ForeColor = System.Drawing.Color.Maroon;
            this.tempBox.Location = new System.Drawing.Point(132, 72);
            this.tempBox.Name = "tempBox";
            this.tempBox.ReadOnly = true;
            this.tempBox.Size = new System.Drawing.Size(100, 29);
            this.tempBox.TabIndex = 3;
            this.tempBox.Text = "0";
            // 
            // humidBox
            // 
            this.humidBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidBox.Location = new System.Drawing.Point(132, 101);
            this.humidBox.Name = "humidBox";
            this.humidBox.ReadOnly = true;
            this.humidBox.Size = new System.Drawing.Size(100, 29);
            this.humidBox.TabIndex = 5;
            this.humidBox.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Humidity (%)";
            // 
            // nano_portname
            // 
            this.nano_portname.FormattingEnabled = true;
            this.nano_portname.Items.AddRange(new object[] {
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7"});
            this.nano_portname.Location = new System.Drawing.Point(1145, 216);
            this.nano_portname.Name = "nano_portname";
            this.nano_portname.Size = new System.Drawing.Size(64, 21);
            this.nano_portname.TabIndex = 6;
            this.nano_portname.Text = "COM3";
            this.nano_portname.SelectedIndexChanged += new System.EventHandler(this.nano_portname_SelectedIndexChanged);
            // 
            // ConnectLabel
            // 
            this.ConnectLabel.AutoSize = true;
            this.ConnectLabel.Location = new System.Drawing.Point(1142, 196);
            this.ConnectLabel.Name = "ConnectLabel";
            this.ConnectLabel.Size = new System.Drawing.Size(55, 13);
            this.ConnectLabel.TabIndex = 4;
            this.ConnectLabel.Text = "Nano Port";
            // 
            // nano_connect
            // 
            this.nano_connect.Location = new System.Drawing.Point(1145, 246);
            this.nano_connect.Name = "nano_connect";
            this.nano_connect.Size = new System.Drawing.Size(75, 23);
            this.nano_connect.TabIndex = 9;
            this.nano_connect.Text = "Connect";
            this.nano_connect.UseVisualStyleBackColor = true;
            this.nano_connect.Click += new System.EventHandler(this.nano_connect_Click);
            // 
            // intVolt
            // 
            this.intVolt.Location = new System.Drawing.Point(1241, 46);
            this.intVolt.Name = "intVolt";
            this.intVolt.Size = new System.Drawing.Size(100, 20);
            this.intVolt.TabIndex = 23;
            this.intVolt.Text = "1";
            this.intVolt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.intVolt_MouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1140, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Interval ";
            // 
            // autoRead
            // 
            this.autoRead.Enabled = false;
            this.autoRead.Location = new System.Drawing.Point(1143, 74);
            this.autoRead.Name = "autoRead";
            this.autoRead.Size = new System.Drawing.Size(77, 23);
            this.autoRead.TabIndex = 27;
            this.autoRead.Text = "Start";
            this.autoRead.UseVisualStyleBackColor = true;
            this.autoRead.Click += new System.EventHandler(this.autoRead_Click);
            // 
            // memCount
            // 
            this.memCount.Location = new System.Drawing.Point(1249, 106);
            this.memCount.Name = "memCount";
            this.memCount.ReadOnly = true;
            this.memCount.Size = new System.Drawing.Size(48, 20);
            this.memCount.TabIndex = 29;
            this.memCount.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1138, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Readings in memory:";
            // 
            // saveButt
            // 
            this.saveButt.Enabled = false;
            this.saveButt.ForeColor = System.Drawing.Color.SeaGreen;
            this.saveButt.Location = new System.Drawing.Point(1141, 137);
            this.saveButt.Name = "saveButt";
            this.saveButt.Size = new System.Drawing.Size(77, 23);
            this.saveButt.TabIndex = 30;
            this.saveButt.Text = "Save";
            this.saveButt.UseVisualStyleBackColor = true;
            this.saveButt.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearButt
            // 
            this.clearButt.Enabled = false;
            this.clearButt.ForeColor = System.Drawing.Color.DarkRed;
            this.clearButt.Location = new System.Drawing.Point(1224, 137);
            this.clearButt.Name = "clearButt";
            this.clearButt.Size = new System.Drawing.Size(77, 23);
            this.clearButt.TabIndex = 31;
            this.clearButt.Text = "Clear";
            this.clearButt.UseVisualStyleBackColor = true;
            this.clearButt.Click += new System.EventHandler(this.button2_Click);
            // 
            // stopButt
            // 
            this.stopButt.Location = new System.Drawing.Point(1226, 74);
            this.stopButt.Name = "stopButt";
            this.stopButt.Size = new System.Drawing.Size(77, 23);
            this.stopButt.TabIndex = 32;
            this.stopButt.Text = "Stop";
            this.stopButt.UseVisualStyleBackColor = true;
            this.stopButt.Click += new System.EventHandler(this.stopButt_Click);
            // 
            // pressureChart
            // 
            chartArea1.Name = "ChartArea1";
            this.pressureChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.pressureChart.Legends.Add(legend1);
            this.pressureChart.Location = new System.Drawing.Point(12, 208);
            this.pressureChart.Name = "pressureChart";
            this.pressureChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.pressureChart.Series.Add(series1);
            this.pressureChart.Size = new System.Drawing.Size(401, 171);
            this.pressureChart.TabIndex = 34;
            this.pressureChart.Text = "chart1";
            // 
            // temperatureChart
            // 
            chartArea2.Name = "ChartArea1";
            this.temperatureChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.temperatureChart.Legends.Add(legend2);
            this.temperatureChart.Location = new System.Drawing.Point(12, 406);
            this.temperatureChart.Name = "temperatureChart";
            this.temperatureChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.temperatureChart.Series.Add(series2);
            this.temperatureChart.Size = new System.Drawing.Size(401, 186);
            this.temperatureChart.TabIndex = 35;
            this.temperatureChart.Text = "chart2";
            // 
            // humidityChart
            // 
            chartArea3.Name = "ChartArea1";
            this.humidityChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.humidityChart.Legends.Add(legend3);
            this.humidityChart.Location = new System.Drawing.Point(11, 616);
            this.humidityChart.Name = "humidityChart";
            this.humidityChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.humidityChart.Series.Add(series3);
            this.humidityChart.Size = new System.Drawing.Size(401, 186);
            this.humidityChart.TabIndex = 36;
            this.humidityChart.Text = "chart3";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 192);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Pressure:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 389);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "Temperature:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 601);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 42;
            this.label17.Text = "Humidity:";
            // 
            // ResetChart
            // 
            this.ResetChart.Location = new System.Drawing.Point(132, 165);
            this.ResetChart.Name = "ResetChart";
            this.ResetChart.Size = new System.Drawing.Size(75, 23);
            this.ResetChart.TabIndex = 43;
            this.ResetChart.Text = "ResetChart";
            this.ResetChart.UseVisualStyleBackColor = true;
            this.ResetChart.Click += new System.EventHandler(this.ResetChart_Click);
            // 
            // recordBox
            // 
            this.recordBox.AutoSize = true;
            this.recordBox.Checked = true;
            this.recordBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.recordBox.Location = new System.Drawing.Point(32, 171);
            this.recordBox.Name = "recordBox";
            this.recordBox.Size = new System.Drawing.Size(61, 17);
            this.recordBox.TabIndex = 44;
            this.recordBox.Text = "Record";
            this.recordBox.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1492, 24);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.editToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // fz_pressure
            // 
            this.fz_pressure.AutoSize = true;
            this.fz_pressure.Location = new System.Drawing.Point(419, 210);
            this.fz_pressure.Name = "fz_pressure";
            this.fz_pressure.Size = new System.Drawing.Size(74, 17);
            this.fz_pressure.TabIndex = 46;
            this.fz_pressure.Text = "From Zero";
            this.fz_pressure.UseVisualStyleBackColor = true;
            this.fz_pressure.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // fz_temp
            // 
            this.fz_temp.AutoSize = true;
            this.fz_temp.Location = new System.Drawing.Point(419, 406);
            this.fz_temp.Name = "fz_temp";
            this.fz_temp.Size = new System.Drawing.Size(74, 17);
            this.fz_temp.TabIndex = 47;
            this.fz_temp.Text = "From Zero";
            this.fz_temp.UseVisualStyleBackColor = true;
            this.fz_temp.CheckedChanged += new System.EventHandler(this.fz_temp_CheckedChanged);
            // 
            // fz_humidity
            // 
            this.fz_humidity.AutoSize = true;
            this.fz_humidity.Location = new System.Drawing.Point(419, 616);
            this.fz_humidity.Name = "fz_humidity";
            this.fz_humidity.Size = new System.Drawing.Size(74, 17);
            this.fz_humidity.TabIndex = 48;
            this.fz_humidity.Text = "From Zero";
            this.fz_humidity.UseVisualStyleBackColor = true;
            this.fz_humidity.CheckedChanged += new System.EventHandler(this.fz_humidity_CheckedChanged);
            // 
            // scroll_pressure
            // 
            this.scroll_pressure.AutoSize = true;
            this.scroll_pressure.Checked = true;
            this.scroll_pressure.CheckState = System.Windows.Forms.CheckState.Checked;
            this.scroll_pressure.Location = new System.Drawing.Point(419, 233);
            this.scroll_pressure.Name = "scroll_pressure";
            this.scroll_pressure.Size = new System.Drawing.Size(77, 17);
            this.scroll_pressure.TabIndex = 50;
            this.scroll_pressure.Text = "Scroll view";
            this.scroll_pressure.UseVisualStyleBackColor = true;
            this.scroll_pressure.CheckedChanged += new System.EventHandler(this.scroll_pressure_CheckedChanged);
            // 
            // scroll_temp
            // 
            this.scroll_temp.AutoSize = true;
            this.scroll_temp.Checked = true;
            this.scroll_temp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.scroll_temp.Location = new System.Drawing.Point(419, 429);
            this.scroll_temp.Name = "scroll_temp";
            this.scroll_temp.Size = new System.Drawing.Size(77, 17);
            this.scroll_temp.TabIndex = 51;
            this.scroll_temp.Text = "Scroll view";
            this.scroll_temp.UseVisualStyleBackColor = true;
            this.scroll_temp.CheckedChanged += new System.EventHandler(this.scroll_temp_CheckedChanged);
            // 
            // scroll_humid
            // 
            this.scroll_humid.AutoSize = true;
            this.scroll_humid.Checked = true;
            this.scroll_humid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.scroll_humid.Location = new System.Drawing.Point(419, 639);
            this.scroll_humid.Name = "scroll_humid";
            this.scroll_humid.Size = new System.Drawing.Size(77, 17);
            this.scroll_humid.TabIndex = 52;
            this.scroll_humid.Text = "Scroll view";
            this.scroll_humid.UseVisualStyleBackColor = true;
            this.scroll_humid.CheckedChanged += new System.EventHandler(this.scroll_humid_CheckedChanged);
            // 
            // zoomFactor
            // 
            this.zoomFactor.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.zoomFactor.Location = new System.Drawing.Point(85, 825);
            this.zoomFactor.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.zoomFactor.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.zoomFactor.Name = "zoomFactor";
            this.zoomFactor.Size = new System.Drawing.Size(120, 20);
            this.zoomFactor.TabIndex = 54;
            this.zoomFactor.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 828);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 13);
            this.label18.TabIndex = 55;
            this.label18.Text = "Zoom Factor";
            // 
            // no2Box
            // 
            this.no2Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no2Box.Location = new System.Drawing.Point(388, 131);
            this.no2Box.Name = "no2Box";
            this.no2Box.ReadOnly = true;
            this.no2Box.Size = new System.Drawing.Size(100, 29);
            this.no2Box.TabIndex = 57;
            this.no2Box.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "NO2 (PPM)";
            // 
            // h2Box
            // 
            this.h2Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h2Box.Location = new System.Drawing.Point(388, 102);
            this.h2Box.Name = "h2Box";
            this.h2Box.ReadOnly = true;
            this.h2Box.Size = new System.Drawing.Size(100, 29);
            this.h2Box.TabIndex = 63;
            this.h2Box.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "H2 (PPM)";
            // 
            // nh3Box
            // 
            this.nh3Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nh3Box.Location = new System.Drawing.Point(388, 71);
            this.nh3Box.Name = "nh3Box";
            this.nh3Box.ReadOnly = true;
            this.nh3Box.Size = new System.Drawing.Size(100, 29);
            this.nh3Box.TabIndex = 61;
            this.nh3Box.Text = "0";
            // 
            // coBox
            // 
            this.coBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coBox.Location = new System.Drawing.Point(388, 43);
            this.coBox.Name = "coBox";
            this.coBox.ReadOnly = true;
            this.coBox.Size = new System.Drawing.Size(100, 29);
            this.coBox.TabIndex = 60;
            this.coBox.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(287, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "NH3 (PPM)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(287, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 58;
            this.label10.Text = "CO (PPM)";
            // 
            // DPWMBox
            // 
            this.DPWMBox.Location = new System.Drawing.Point(625, 71);
            this.DPWMBox.Name = "DPWMBox";
            this.DPWMBox.ReadOnly = true;
            this.DPWMBox.Size = new System.Drawing.Size(100, 20);
            this.DPWMBox.TabIndex = 68;
            this.DPWMBox.Text = "0";
            // 
            // APWMBox
            // 
            this.APWMBox.Location = new System.Drawing.Point(625, 43);
            this.APWMBox.Name = "APWMBox";
            this.APWMBox.ReadOnly = true;
            this.APWMBox.Size = new System.Drawing.Size(100, 20);
            this.APWMBox.TabIndex = 67;
            this.APWMBox.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Diluent PWM (%)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(524, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 65;
            this.label11.Text = "Analyte PWM (%)";
            // 
            // scrollNO2
            // 
            this.scrollNO2.AutoSize = true;
            this.scrollNO2.Checked = true;
            this.scrollNO2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.scrollNO2.Location = new System.Drawing.Point(935, 235);
            this.scrollNO2.Name = "scrollNO2";
            this.scrollNO2.Size = new System.Drawing.Size(77, 17);
            this.scrollNO2.TabIndex = 72;
            this.scrollNO2.Text = "Scroll view";
            this.scrollNO2.UseVisualStyleBackColor = true;
            this.scrollNO2.CheckedChanged += new System.EventHandler(this.scrollNO2_CheckedChanged);
            // 
            // fz_NO2
            // 
            this.fz_NO2.AutoSize = true;
            this.fz_NO2.Location = new System.Drawing.Point(935, 212);
            this.fz_NO2.Name = "fz_NO2";
            this.fz_NO2.Size = new System.Drawing.Size(74, 17);
            this.fz_NO2.TabIndex = 71;
            this.fz_NO2.Text = "From Zero";
            this.fz_NO2.UseVisualStyleBackColor = true;
            this.fz_NO2.CheckedChanged += new System.EventHandler(this.fz_NO2_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(525, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 70;
            this.label13.Text = "NO2:";
            // 
            // no2Chart
            // 
            chartArea4.Name = "ChartArea1";
            this.no2Chart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.no2Chart.Legends.Add(legend4);
            this.no2Chart.Location = new System.Drawing.Point(528, 210);
            this.no2Chart.Name = "no2Chart";
            this.no2Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.no2Chart.Series.Add(series4);
            this.no2Chart.Size = new System.Drawing.Size(401, 171);
            this.no2Chart.TabIndex = 69;
            this.no2Chart.Text = "chart1";
            // 
            // scroll_nh3
            // 
            this.scroll_nh3.AutoSize = true;
            this.scroll_nh3.Checked = true;
            this.scroll_nh3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.scroll_nh3.Location = new System.Drawing.Point(935, 446);
            this.scroll_nh3.Name = "scroll_nh3";
            this.scroll_nh3.Size = new System.Drawing.Size(77, 17);
            this.scroll_nh3.TabIndex = 76;
            this.scroll_nh3.Text = "Scroll view";
            this.scroll_nh3.UseVisualStyleBackColor = true;
            this.scroll_nh3.CheckedChanged += new System.EventHandler(this.scroll_nh3_CheckedChanged);
            // 
            // fz_NH3
            // 
            this.fz_NH3.AutoSize = true;
            this.fz_NH3.Location = new System.Drawing.Point(935, 423);
            this.fz_NH3.Name = "fz_NH3";
            this.fz_NH3.Size = new System.Drawing.Size(74, 17);
            this.fz_NH3.TabIndex = 75;
            this.fz_NH3.Text = "From Zero";
            this.fz_NH3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "NH3:";
            // 
            // nh3Chart
            // 
            chartArea5.Name = "ChartArea1";
            this.nh3Chart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.nh3Chart.Legends.Add(legend5);
            this.nh3Chart.Location = new System.Drawing.Point(528, 421);
            this.nh3Chart.Name = "nh3Chart";
            this.nh3Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.nh3Chart.Series.Add(series5);
            this.nh3Chart.Size = new System.Drawing.Size(401, 171);
            this.nh3Chart.TabIndex = 73;
            this.nh3Chart.Text = "chart1";
            // 
            // scroll_co
            // 
            this.scroll_co.AutoSize = true;
            this.scroll_co.Checked = true;
            this.scroll_co.CheckState = System.Windows.Forms.CheckState.Checked;
            this.scroll_co.Location = new System.Drawing.Point(934, 656);
            this.scroll_co.Name = "scroll_co";
            this.scroll_co.Size = new System.Drawing.Size(77, 17);
            this.scroll_co.TabIndex = 80;
            this.scroll_co.Text = "Scroll view";
            this.scroll_co.UseVisualStyleBackColor = true;
            this.scroll_co.CheckedChanged += new System.EventHandler(this.scroll_co_CheckedChanged);
            // 
            // fz_CO
            // 
            this.fz_CO.AutoSize = true;
            this.fz_CO.Location = new System.Drawing.Point(934, 633);
            this.fz_CO.Name = "fz_CO";
            this.fz_CO.Size = new System.Drawing.Size(74, 17);
            this.fz_CO.TabIndex = 79;
            this.fz_CO.Text = "From Zero";
            this.fz_CO.UseVisualStyleBackColor = true;
            this.fz_CO.CheckedChanged += new System.EventHandler(this.fz_CO_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(524, 615);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 13);
            this.label14.TabIndex = 78;
            this.label14.Text = "CO";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // coChart
            // 
            chartArea6.Name = "ChartArea1";
            this.coChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.coChart.Legends.Add(legend6);
            this.coChart.Location = new System.Drawing.Point(527, 631);
            this.coChart.Name = "coChart";
            this.coChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.coChart.Series.Add(series6);
            this.coChart.Size = new System.Drawing.Size(401, 171);
            this.coChart.TabIndex = 77;
            this.coChart.Text = "chart2";
            // 
            // scroll_h2
            // 
            this.scroll_h2.AutoSize = true;
            this.scroll_h2.Checked = true;
            this.scroll_h2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.scroll_h2.Location = new System.Drawing.Point(935, 868);
            this.scroll_h2.Name = "scroll_h2";
            this.scroll_h2.Size = new System.Drawing.Size(77, 17);
            this.scroll_h2.TabIndex = 84;
            this.scroll_h2.Text = "Scroll view";
            this.scroll_h2.UseVisualStyleBackColor = true;
            this.scroll_h2.CheckedChanged += new System.EventHandler(this.scroll_h2_CheckedChanged);
            // 
            // fz_h2
            // 
            this.fz_h2.AutoSize = true;
            this.fz_h2.Location = new System.Drawing.Point(935, 845);
            this.fz_h2.Name = "fz_h2";
            this.fz_h2.Size = new System.Drawing.Size(74, 17);
            this.fz_h2.TabIndex = 83;
            this.fz_h2.Text = "From Zero";
            this.fz_h2.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(525, 827);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 13);
            this.label19.TabIndex = 82;
            this.label19.Text = "H2";
            // 
            // h2Chart
            // 
            chartArea7.Name = "ChartArea1";
            this.h2Chart.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.h2Chart.Legends.Add(legend7);
            this.h2Chart.Location = new System.Drawing.Point(528, 843);
            this.h2Chart.Name = "h2Chart";
            this.h2Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series7.IsVisibleInLegend = false;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.h2Chart.Series.Add(series7);
            this.h2Chart.Size = new System.Drawing.Size(401, 171);
            this.h2Chart.TabIndex = 81;
            this.h2Chart.Text = "chart2";
            // 
            // statusLogBox
            // 
            this.statusLogBox.Location = new System.Drawing.Point(1145, 306);
            this.statusLogBox.Name = "statusLogBox";
            this.statusLogBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.statusLogBox.Size = new System.Drawing.Size(335, 117);
            this.statusLogBox.TabIndex = 85;
            this.statusLogBox.Text = "";
            this.statusLogBox.TextChanged += new System.EventHandler(this.statusLogBox_TextChanged);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(1142, 290);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(40, 13);
            this.StatusLabel.TabIndex = 86;
            this.StatusLabel.Text = "Status:";
            // 
            // analyteBox
            // 
            this.analyteBox.FormattingEnabled = true;
            this.analyteBox.Items.AddRange(new object[] {
            "NO2",
            "NH3",
            "CO",
            "H2O",
            "Others"});
            this.analyteBox.Location = new System.Drawing.Point(625, 106);
            this.analyteBox.Name = "analyteBox";
            this.analyteBox.Size = new System.Drawing.Size(121, 21);
            this.analyteBox.TabIndex = 87;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(525, 109);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 13);
            this.label20.TabIndex = 88;
            this.label20.Text = "Current Analyte";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(525, 137);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 13);
            this.label21.TabIndex = 90;
            this.label21.Text = "Current Diluent";
            // 
            // diluentBox
            // 
            this.diluentBox.FormattingEnabled = true;
            this.diluentBox.Items.AddRange(new object[] {
            "N2",
            "O2/N2",
            "Atm Air",
            "He",
            "Ar",
            "Others"});
            this.diluentBox.Location = new System.Drawing.Point(625, 134);
            this.diluentBox.Name = "diluentBox";
            this.diluentBox.Size = new System.Drawing.Size(121, 21);
            this.diluentBox.TabIndex = 89;
            // 
            // analyteBar
            // 
            this.analyteBar.LargeChange = 10;
            this.analyteBar.Location = new System.Drawing.Point(755, 42);
            this.analyteBar.Maximum = 100;
            this.analyteBar.Name = "analyteBar";
            this.analyteBar.Size = new System.Drawing.Size(257, 45);
            this.analyteBar.SmallChange = 5;
            this.analyteBar.TabIndex = 91;
            this.analyteBar.Scroll += new System.EventHandler(this.analyteBar_Scroll);
            // 
            // diluentBar
            // 
            this.diluentBar.LargeChange = 10;
            this.diluentBar.Location = new System.Drawing.Point(755, 71);
            this.diluentBar.Maximum = 100;
            this.diluentBar.Name = "diluentBar";
            this.diluentBar.Size = new System.Drawing.Size(257, 45);
            this.diluentBar.SmallChange = 5;
            this.diluentBar.TabIndex = 92;
            this.diluentBar.Scroll += new System.EventHandler(this.diluentBar_Scroll);
            // 
            // Heat_But
            // 
            this.Heat_But.Location = new System.Drawing.Point(764, 109);
            this.Heat_But.Name = "Heat_But";
            this.Heat_But.Size = new System.Drawing.Size(137, 23);
            this.Heat_But.TabIndex = 93;
            this.Heat_But.Text = "Start Heating";
            this.Heat_But.UseVisualStyleBackColor = true;
            this.Heat_But.Click += new System.EventHandler(this.Heat_But_Click);
            // 
            // ambtempBox
            // 
            this.ambtempBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambtempBox.Location = new System.Drawing.Point(132, 130);
            this.ambtempBox.Name = "ambtempBox";
            this.ambtempBox.ReadOnly = true;
            this.ambtempBox.Size = new System.Drawing.Size(100, 29);
            this.ambtempBox.TabIndex = 95;
            this.ambtempBox.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(31, 138);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(90, 13);
            this.label22.TabIndex = 94;
            this.label22.Text = "Ambient Temp (c)";
            // 
            // heaterIndicator
            // 
            this.heaterIndicator.AutoSize = true;
            this.heaterIndicator.ForeColor = System.Drawing.Color.MidnightBlue;
            this.heaterIndicator.Location = new System.Drawing.Point(907, 114);
            this.heaterIndicator.Name = "heaterIndicator";
            this.heaterIndicator.Size = new System.Drawing.Size(74, 13);
            this.heaterIndicator.TabIndex = 96;
            this.heaterIndicator.Text = "HEATER OFF";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(1142, 446);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 13);
            this.label23.TabIndex = 97;
            this.label23.Text = "Automation";
            // 
            // TempController
            // 
            this.TempController.AutoSize = true;
            this.TempController.Location = new System.Drawing.Point(1145, 475);
            this.TempController.Name = "TempController";
            this.TempController.Size = new System.Drawing.Size(111, 17);
            this.TempController.TabIndex = 98;
            this.TempController.Text = "Maintain Temp at:";
            this.TempController.UseVisualStyleBackColor = true;
            this.TempController.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // tempSetpointBox
            // 
            this.tempSetpointBox.Location = new System.Drawing.Point(1256, 473);
            this.tempSetpointBox.Name = "tempSetpointBox";
            this.tempSetpointBox.Size = new System.Drawing.Size(47, 20);
            this.tempSetpointBox.TabIndex = 99;
            this.tempSetpointBox.Text = "20";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(1305, 476);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(14, 13);
            this.label24.TabIndex = 97;
            this.label24.Text = "C";
            // 
            // manualCommandBox
            // 
            this.manualCommandBox.Location = new System.Drawing.Point(1151, 526);
            this.manualCommandBox.Name = "manualCommandBox";
            this.manualCommandBox.Size = new System.Drawing.Size(328, 20);
            this.manualCommandBox.TabIndex = 100;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(1148, 510);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(92, 13);
            this.label25.TabIndex = 101;
            this.label25.Text = "Manual Command";
            // 
            // CommandBut
            // 
            this.CommandBut.Location = new System.Drawing.Point(1151, 553);
            this.CommandBut.Name = "CommandBut";
            this.CommandBut.Size = new System.Drawing.Size(75, 23);
            this.CommandBut.TabIndex = 102;
            this.CommandBut.Text = "Send";
            this.CommandBut.UseVisualStyleBackColor = true;
            this.CommandBut.Click += new System.EventHandler(this.CommandBut_Click);
            // 
            // RawOutput
            // 
            this.RawOutput.AutoSize = true;
            this.RawOutput.Location = new System.Drawing.Point(1241, 558);
            this.RawOutput.Name = "RawOutput";
            this.RawOutput.Size = new System.Drawing.Size(83, 17);
            this.RawOutput.TabIndex = 103;
            this.RawOutput.Text = "Raw Output";
            this.RawOutput.UseVisualStyleBackColor = true;
            this.RawOutput.CheckedChanged += new System.EventHandler(this.RawOutput_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 1045);
            this.Controls.Add(this.RawOutput);
            this.Controls.Add(this.CommandBut);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.manualCommandBox);
            this.Controls.Add(this.tempSetpointBox);
            this.Controls.Add(this.TempController);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.heaterIndicator);
            this.Controls.Add(this.ambtempBox);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.Heat_But);
            this.Controls.Add(this.diluentBar);
            this.Controls.Add(this.analyteBar);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.diluentBox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.analyteBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.statusLogBox);
            this.Controls.Add(this.scroll_h2);
            this.Controls.Add(this.fz_h2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.h2Chart);
            this.Controls.Add(this.scroll_co);
            this.Controls.Add(this.fz_CO);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.coChart);
            this.Controls.Add(this.scroll_nh3);
            this.Controls.Add(this.fz_NH3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nh3Chart);
            this.Controls.Add(this.scrollNO2);
            this.Controls.Add(this.fz_NO2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.no2Chart);
            this.Controls.Add(this.DPWMBox);
            this.Controls.Add(this.APWMBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.h2Box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nh3Box);
            this.Controls.Add(this.coBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.no2Box);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.zoomFactor);
            this.Controls.Add(this.scroll_humid);
            this.Controls.Add(this.scroll_temp);
            this.Controls.Add(this.scroll_pressure);
            this.Controls.Add(this.fz_humidity);
            this.Controls.Add(this.fz_temp);
            this.Controls.Add(this.fz_pressure);
            this.Controls.Add(this.recordBox);
            this.Controls.Add(this.ResetChart);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.humidityChart);
            this.Controls.Add(this.temperatureChart);
            this.Controls.Add(this.pressureChart);
            this.Controls.Add(this.stopButt);
            this.Controls.Add(this.clearButt);
            this.Controls.Add(this.saveButt);
            this.Controls.Add(this.memCount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.autoRead);
            this.Controls.Add(this.intVolt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nano_connect);
            this.Controls.Add(this.nano_portname);
            this.Controls.Add(this.humidBox);
            this.Controls.Add(this.ConnectLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tempBox);
            this.Controls.Add(this.pressureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Gas Chamber - SOTON";
            this.TransparencyKey = System.Drawing.Color.DarkBlue;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pressureChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humidityChart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.no2Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nh3Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h2Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analyteBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diluentBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort_nano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pressureBox;
        private System.Windows.Forms.TextBox tempBox;
        private System.Windows.Forms.TextBox humidBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox nano_portname;
        private System.Windows.Forms.Label ConnectLabel;
        private System.Windows.Forms.Button nano_connect;
        private System.Windows.Forms.TextBox intVolt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button autoRead;
        private System.Windows.Forms.TextBox memCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button saveButt;
        private System.Windows.Forms.Button clearButt;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button stopButt;
        private System.Windows.Forms.DataVisualization.Charting.Chart pressureChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart temperatureChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart humidityChart;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button ResetChart;
        private System.Windows.Forms.CheckBox recordBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.CheckBox fz_pressure;
        private System.Windows.Forms.CheckBox fz_temp;
        private System.Windows.Forms.CheckBox fz_humidity;
        private System.Windows.Forms.CheckBox scroll_pressure;
        private System.Windows.Forms.CheckBox scroll_temp;
        private System.Windows.Forms.CheckBox scroll_humid;
        private System.Windows.Forms.NumericUpDown zoomFactor;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox no2Box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox h2Box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nh3Box;
        private System.Windows.Forms.TextBox coBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox DPWMBox;
        private System.Windows.Forms.TextBox APWMBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox scrollNO2;
        private System.Windows.Forms.CheckBox fz_NO2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataVisualization.Charting.Chart no2Chart;
        private System.Windows.Forms.CheckBox scroll_nh3;
        private System.Windows.Forms.CheckBox fz_NH3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart nh3Chart;
        private System.Windows.Forms.CheckBox scroll_co;
        private System.Windows.Forms.CheckBox fz_CO;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataVisualization.Charting.Chart coChart;
        private System.Windows.Forms.CheckBox scroll_h2;
        private System.Windows.Forms.CheckBox fz_h2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataVisualization.Charting.Chart h2Chart;
        private System.Windows.Forms.RichTextBox statusLogBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ComboBox analyteBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox diluentBox;
        private System.Windows.Forms.TrackBar analyteBar;
        private System.Windows.Forms.TrackBar diluentBar;
        private System.Windows.Forms.Button Heat_But;
        private System.Windows.Forms.TextBox ambtempBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label heaterIndicator;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.CheckBox TempController;
        private System.Windows.Forms.TextBox tempSetpointBox;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox manualCommandBox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button CommandBut;
        private System.Windows.Forms.CheckBox RawOutput;
    }
}

