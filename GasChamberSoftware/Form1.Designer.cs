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
            this.serialPort_nano = new System.IO.Ports.SerialPort(this.components);
            this.serialPort_smu = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pressureBox = new System.Windows.Forms.TextBox();
            this.tempBox = new System.Windows.Forms.TextBox();
            this.humidBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nano_portname = new System.Windows.Forms.ComboBox();
            this.smu_portname = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nano_connect = new System.Windows.Forms.Button();
            this.smu_connect = new System.Windows.Forms.Button();
            this.ledBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LEDswitch = new System.Windows.Forms.Button();
            this.resistBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.readAllButt = new System.Windows.Forms.Button();
            this.intVolt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.endVolt = new System.Windows.Forms.TextBox();
            this.startVolt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ivChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.autoCount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.autoRead = new System.Windows.Forms.Button();
            this.memCount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.saveButt = new System.Windows.Forms.Button();
            this.clearButt = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.stopButt = new System.Windows.Forms.Button();
            this.realTime = new System.Windows.Forms.CheckBox();
            this.pressureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.temperatureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.humidityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.hiCurrentChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
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
            this.fz_resistance = new System.Windows.Forms.CheckBox();
            this.scroll_pressure = new System.Windows.Forms.CheckBox();
            this.scroll_temp = new System.Windows.Forms.CheckBox();
            this.scroll_humid = new System.Windows.Forms.CheckBox();
            this.scroll_resist = new System.Windows.Forms.CheckBox();
            this.zoomFactor = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.lowCurrentChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ivChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressureChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humidityChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiCurrentChart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowCurrentChart)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort_nano
            // 
            this.serialPort_nano.PortName = "COM4";
            this.serialPort_nano.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_nano_DataReceived);
            // 
            // serialPort_smu
            // 
            this.serialPort_smu.PortName = "COM5";
            this.serialPort_smu.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_smu_DataReceived);
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
            this.label2.Location = new System.Drawing.Point(31, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperature (c)";
            // 
            // pressureBox
            // 
            this.pressureBox.Location = new System.Drawing.Point(132, 43);
            this.pressureBox.Name = "pressureBox";
            this.pressureBox.ReadOnly = true;
            this.pressureBox.Size = new System.Drawing.Size(100, 20);
            this.pressureBox.TabIndex = 2;
            this.pressureBox.Text = "0";
            // 
            // tempBox
            // 
            this.tempBox.Location = new System.Drawing.Point(132, 71);
            this.tempBox.Name = "tempBox";
            this.tempBox.ReadOnly = true;
            this.tempBox.Size = new System.Drawing.Size(100, 20);
            this.tempBox.TabIndex = 3;
            this.tempBox.Text = "0";
            // 
            // humidBox
            // 
            this.humidBox.Location = new System.Drawing.Point(132, 102);
            this.humidBox.Name = "humidBox";
            this.humidBox.ReadOnly = true;
            this.humidBox.Size = new System.Drawing.Size(100, 20);
            this.humidBox.TabIndex = 5;
            this.humidBox.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Humidity (%)";
            // 
            // nano_portname
            // 
            this.nano_portname.FormattingEnabled = true;
            this.nano_portname.Items.AddRange(new object[] {
            "COM4",
            "COM5",
            "COM6",
            "COM7"});
            this.nano_portname.Location = new System.Drawing.Point(329, 55);
            this.nano_portname.Name = "nano_portname";
            this.nano_portname.Size = new System.Drawing.Size(121, 21);
            this.nano_portname.TabIndex = 6;
            this.nano_portname.Text = "COM4";
            // 
            // smu_portname
            // 
            this.smu_portname.FormattingEnabled = true;
            this.smu_portname.Items.AddRange(new object[] {
            "COM4",
            "COM5",
            "COM6",
            "COM7"});
            this.smu_portname.Location = new System.Drawing.Point(329, 94);
            this.smu_portname.Name = "smu_portname";
            this.smu_portname.Size = new System.Drawing.Size(121, 21);
            this.smu_portname.TabIndex = 7;
            this.smu_portname.Text = "COM5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nano Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "SMU Port";
            // 
            // nano_connect
            // 
            this.nano_connect.Location = new System.Drawing.Point(469, 55);
            this.nano_connect.Name = "nano_connect";
            this.nano_connect.Size = new System.Drawing.Size(75, 23);
            this.nano_connect.TabIndex = 9;
            this.nano_connect.Text = "Connect";
            this.nano_connect.UseVisualStyleBackColor = true;
            this.nano_connect.Click += new System.EventHandler(this.nano_connect_Click);
            // 
            // smu_connect
            // 
            this.smu_connect.Enabled = false;
            this.smu_connect.Location = new System.Drawing.Point(469, 94);
            this.smu_connect.Name = "smu_connect";
            this.smu_connect.Size = new System.Drawing.Size(75, 23);
            this.smu_connect.TabIndex = 10;
            this.smu_connect.Text = "Connect";
            this.smu_connect.UseVisualStyleBackColor = true;
            this.smu_connect.Click += new System.EventHandler(this.smu_connect_Click);
            // 
            // ledBox
            // 
            this.ledBox.Location = new System.Drawing.Point(132, 134);
            this.ledBox.Name = "ledBox";
            this.ledBox.ReadOnly = true;
            this.ledBox.Size = new System.Drawing.Size(100, 20);
            this.ledBox.TabIndex = 12;
            this.ledBox.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "LED Status";
            // 
            // LEDswitch
            // 
            this.LEDswitch.Enabled = false;
            this.LEDswitch.Location = new System.Drawing.Point(347, 134);
            this.LEDswitch.Name = "LEDswitch";
            this.LEDswitch.Size = new System.Drawing.Size(75, 23);
            this.LEDswitch.TabIndex = 13;
            this.LEDswitch.Text = "Toggle LED";
            this.LEDswitch.UseVisualStyleBackColor = true;
            this.LEDswitch.Click += new System.EventHandler(this.LEDswitch_Click);
            // 
            // resistBox
            // 
            this.resistBox.Location = new System.Drawing.Point(132, 174);
            this.resistBox.Name = "resistBox";
            this.resistBox.ReadOnly = true;
            this.resistBox.Size = new System.Drawing.Size(100, 20);
            this.resistBox.TabIndex = 15;
            this.resistBox.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Resistance";
            // 
            // readAllButt
            // 
            this.readAllButt.Enabled = false;
            this.readAllButt.Location = new System.Drawing.Point(441, 134);
            this.readAllButt.Name = "readAllButt";
            this.readAllButt.Size = new System.Drawing.Size(91, 23);
            this.readAllButt.TabIndex = 17;
            this.readAllButt.Text = "Read All";
            this.readAllButt.UseVisualStyleBackColor = true;
            this.readAllButt.Click += new System.EventHandler(this.readAll_click);
            // 
            // intVolt
            // 
            this.intVolt.Location = new System.Drawing.Point(442, 233);
            this.intVolt.Name = "intVolt";
            this.intVolt.Size = new System.Drawing.Size(100, 20);
            this.intVolt.TabIndex = 23;
            this.intVolt.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Interval (V)";
            // 
            // endVolt
            // 
            this.endVolt.Location = new System.Drawing.Point(442, 202);
            this.endVolt.Name = "endVolt";
            this.endVolt.Size = new System.Drawing.Size(100, 20);
            this.endVolt.TabIndex = 21;
            this.endVolt.Text = "3";
            // 
            // startVolt
            // 
            this.startVolt.Location = new System.Drawing.Point(442, 174);
            this.startVolt.Name = "startVolt";
            this.startVolt.Size = new System.Drawing.Size(100, 20);
            this.startVolt.TabIndex = 20;
            this.startVolt.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(341, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "End Voltage (V)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(341, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Start Voltage (V)";
            // 
            // ivChart
            // 
            chartArea1.Name = "ChartArea1";
            this.ivChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ivChart.Legends.Add(legend1);
            this.ivChart.Location = new System.Drawing.Point(28, 218);
            this.ivChart.Name = "ivChart";
            this.ivChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ivChart.Series.Add(series1);
            this.ivChart.Size = new System.Drawing.Size(300, 165);
            this.ivChart.TabIndex = 24;
            this.ivChart.Text = "chart1";
            // 
            // autoCount
            // 
            this.autoCount.Location = new System.Drawing.Point(440, 261);
            this.autoCount.Name = "autoCount";
            this.autoCount.Size = new System.Drawing.Size(58, 20);
            this.autoCount.TabIndex = 26;
            this.autoCount.Text = "10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(339, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Auto read times:";
            // 
            // autoRead
            // 
            this.autoRead.Enabled = false;
            this.autoRead.Location = new System.Drawing.Point(510, 259);
            this.autoRead.Name = "autoRead";
            this.autoRead.Size = new System.Drawing.Size(77, 23);
            this.autoRead.TabIndex = 27;
            this.autoRead.Text = "Start";
            this.autoRead.UseVisualStyleBackColor = true;
            this.autoRead.Click += new System.EventHandler(this.autoRead_Click);
            // 
            // memCount
            // 
            this.memCount.Location = new System.Drawing.Point(450, 293);
            this.memCount.Name = "memCount";
            this.memCount.ReadOnly = true;
            this.memCount.Size = new System.Drawing.Size(48, 20);
            this.memCount.TabIndex = 29;
            this.memCount.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(339, 296);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Readings in memory:";
            // 
            // saveButt
            // 
            this.saveButt.Enabled = false;
            this.saveButt.ForeColor = System.Drawing.Color.SeaGreen;
            this.saveButt.Location = new System.Drawing.Point(342, 324);
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
            this.clearButt.Location = new System.Drawing.Point(425, 324);
            this.clearButt.Name = "clearButt";
            this.clearButt.Size = new System.Drawing.Size(77, 23);
            this.clearButt.TabIndex = 31;
            this.clearButt.Text = "Clear";
            this.clearButt.UseVisualStyleBackColor = true;
            this.clearButt.Click += new System.EventHandler(this.button2_Click);
            // 
            // stopButt
            // 
            this.stopButt.Enabled = false;
            this.stopButt.Location = new System.Drawing.Point(510, 291);
            this.stopButt.Name = "stopButt";
            this.stopButt.Size = new System.Drawing.Size(77, 23);
            this.stopButt.TabIndex = 32;
            this.stopButt.Text = "Stop";
            this.stopButt.UseVisualStyleBackColor = true;
            this.stopButt.Click += new System.EventHandler(this.stopButt_Click);
            // 
            // realTime
            // 
            this.realTime.AutoSize = true;
            this.realTime.Enabled = false;
            this.realTime.Location = new System.Drawing.Point(238, 176);
            this.realTime.Name = "realTime";
            this.realTime.Size = new System.Drawing.Size(74, 17);
            this.realTime.TabIndex = 33;
            this.realTime.Text = "Real Time";
            this.realTime.UseVisualStyleBackColor = true;
            this.realTime.CheckedChanged += new System.EventHandler(this.realTime_CheckedChanged);
            // 
            // pressureChart
            // 
            chartArea2.Name = "ChartArea1";
            this.pressureChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.pressureChart.Legends.Add(legend2);
            this.pressureChart.Location = new System.Drawing.Point(639, 59);
            this.pressureChart.Name = "pressureChart";
            this.pressureChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.pressureChart.Series.Add(series2);
            this.pressureChart.Size = new System.Drawing.Size(401, 171);
            this.pressureChart.TabIndex = 34;
            this.pressureChart.Text = "chart1";
            // 
            // temperatureChart
            // 
            chartArea3.Name = "ChartArea1";
            this.temperatureChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.temperatureChart.Legends.Add(legend3);
            this.temperatureChart.Location = new System.Drawing.Point(639, 248);
            this.temperatureChart.Name = "temperatureChart";
            this.temperatureChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.temperatureChart.Series.Add(series3);
            this.temperatureChart.Size = new System.Drawing.Size(401, 186);
            this.temperatureChart.TabIndex = 35;
            this.temperatureChart.Text = "chart2";
            // 
            // humidityChart
            // 
            chartArea4.Name = "ChartArea1";
            this.humidityChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.humidityChart.Legends.Add(legend4);
            this.humidityChart.Location = new System.Drawing.Point(638, 458);
            this.humidityChart.Name = "humidityChart";
            this.humidityChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.humidityChart.Series.Add(series4);
            this.humidityChart.Size = new System.Drawing.Size(401, 186);
            this.humidityChart.TabIndex = 36;
            this.humidityChart.Text = "chart3";
            // 
            // hiCurrentChart
            // 
            chartArea5.Name = "ChartArea1";
            this.hiCurrentChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.hiCurrentChart.Legends.Add(legend5);
            this.hiCurrentChart.Location = new System.Drawing.Point(28, 413);
            this.hiCurrentChart.Name = "hiCurrentChart";
            this.hiCurrentChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.hiCurrentChart.Series.Add(series5);
            this.hiCurrentChart.Size = new System.Drawing.Size(516, 159);
            this.hiCurrentChart.TabIndex = 37;
            this.hiCurrentChart.Text = "chart4";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "IV-Curve:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 397);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Current (High and Low)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(636, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Pressure:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(636, 231);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "Temperature:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(636, 443);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 42;
            this.label17.Text = "Humidity:";
            // 
            // ResetChart
            // 
            this.ResetChart.Location = new System.Drawing.Point(343, 374);
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
            this.recordBox.Enabled = false;
            this.recordBox.Location = new System.Drawing.Point(238, 195);
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
            this.menuStrip1.Size = new System.Drawing.Size(1125, 24);
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
            this.fz_pressure.Location = new System.Drawing.Point(1046, 61);
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
            this.fz_temp.Location = new System.Drawing.Point(1046, 248);
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
            this.fz_humidity.Location = new System.Drawing.Point(1046, 458);
            this.fz_humidity.Name = "fz_humidity";
            this.fz_humidity.Size = new System.Drawing.Size(74, 17);
            this.fz_humidity.TabIndex = 48;
            this.fz_humidity.Text = "From Zero";
            this.fz_humidity.UseVisualStyleBackColor = true;
            this.fz_humidity.CheckedChanged += new System.EventHandler(this.fz_humidity_CheckedChanged);
            // 
            // fz_resistance
            // 
            this.fz_resistance.AutoSize = true;
            this.fz_resistance.Location = new System.Drawing.Point(550, 413);
            this.fz_resistance.Name = "fz_resistance";
            this.fz_resistance.Size = new System.Drawing.Size(74, 17);
            this.fz_resistance.TabIndex = 49;
            this.fz_resistance.Text = "From Zero";
            this.fz_resistance.UseVisualStyleBackColor = true;
            this.fz_resistance.CheckedChanged += new System.EventHandler(this.fz_resistance_CheckedChanged);
            // 
            // scroll_pressure
            // 
            this.scroll_pressure.AutoSize = true;
            this.scroll_pressure.Checked = true;
            this.scroll_pressure.CheckState = System.Windows.Forms.CheckState.Checked;
            this.scroll_pressure.Location = new System.Drawing.Point(1046, 84);
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
            this.scroll_temp.Location = new System.Drawing.Point(1046, 271);
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
            this.scroll_humid.Location = new System.Drawing.Point(1046, 481);
            this.scroll_humid.Name = "scroll_humid";
            this.scroll_humid.Size = new System.Drawing.Size(77, 17);
            this.scroll_humid.TabIndex = 52;
            this.scroll_humid.Text = "Scroll view";
            this.scroll_humid.UseVisualStyleBackColor = true;
            this.scroll_humid.CheckedChanged += new System.EventHandler(this.scroll_humid_CheckedChanged);
            // 
            // scroll_resist
            // 
            this.scroll_resist.AutoSize = true;
            this.scroll_resist.Checked = true;
            this.scroll_resist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.scroll_resist.Location = new System.Drawing.Point(550, 436);
            this.scroll_resist.Name = "scroll_resist";
            this.scroll_resist.Size = new System.Drawing.Size(77, 17);
            this.scroll_resist.TabIndex = 53;
            this.scroll_resist.Text = "Scroll view";
            this.scroll_resist.UseVisualStyleBackColor = true;
            this.scroll_resist.CheckedChanged += new System.EventHandler(this.scroll_resist_CheckedChanged);
            // 
            // zoomFactor
            // 
            this.zoomFactor.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.zoomFactor.Location = new System.Drawing.Point(927, 668);
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
            this.label18.Location = new System.Drawing.Point(854, 671);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 13);
            this.label18.TabIndex = 55;
            this.label18.Text = "Zoom Factor";
            // 
            // lowCurrentChart
            // 
            chartArea6.Name = "ChartArea1";
            this.lowCurrentChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.lowCurrentChart.Legends.Add(legend6);
            this.lowCurrentChart.Location = new System.Drawing.Point(28, 578);
            this.lowCurrentChart.Name = "lowCurrentChart";
            this.lowCurrentChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.lowCurrentChart.Series.Add(series6);
            this.lowCurrentChart.Size = new System.Drawing.Size(516, 159);
            this.lowCurrentChart.TabIndex = 56;
            this.lowCurrentChart.Text = "chart4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 733);
            this.Controls.Add(this.lowCurrentChart);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.zoomFactor);
            this.Controls.Add(this.scroll_resist);
            this.Controls.Add(this.scroll_humid);
            this.Controls.Add(this.scroll_temp);
            this.Controls.Add(this.scroll_pressure);
            this.Controls.Add(this.fz_resistance);
            this.Controls.Add(this.fz_humidity);
            this.Controls.Add(this.fz_temp);
            this.Controls.Add(this.fz_pressure);
            this.Controls.Add(this.recordBox);
            this.Controls.Add(this.ResetChart);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.hiCurrentChart);
            this.Controls.Add(this.humidityChart);
            this.Controls.Add(this.temperatureChart);
            this.Controls.Add(this.pressureChart);
            this.Controls.Add(this.realTime);
            this.Controls.Add(this.stopButt);
            this.Controls.Add(this.clearButt);
            this.Controls.Add(this.saveButt);
            this.Controls.Add(this.memCount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.autoRead);
            this.Controls.Add(this.autoCount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ivChart);
            this.Controls.Add(this.intVolt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.endVolt);
            this.Controls.Add(this.startVolt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.readAllButt);
            this.Controls.Add(this.resistBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LEDswitch);
            this.Controls.Add(this.ledBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.smu_connect);
            this.Controls.Add(this.nano_connect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.smu_portname);
            this.Controls.Add(this.nano_portname);
            this.Controls.Add(this.humidBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tempBox);
            this.Controls.Add(this.pressureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Gas Chamber - SOTON";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ivChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressureChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humidityChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiCurrentChart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowCurrentChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort_nano;
        private System.IO.Ports.SerialPort serialPort_smu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pressureBox;
        private System.Windows.Forms.TextBox tempBox;
        private System.Windows.Forms.TextBox humidBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox nano_portname;
        private System.Windows.Forms.ComboBox smu_portname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button nano_connect;
        private System.Windows.Forms.Button smu_connect;
        private System.Windows.Forms.TextBox ledBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button LEDswitch;
        private System.Windows.Forms.TextBox resistBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button readAllButt;
        private System.Windows.Forms.TextBox intVolt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox endVolt;
        private System.Windows.Forms.TextBox startVolt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart ivChart;
        private System.Windows.Forms.TextBox autoCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button autoRead;
        private System.Windows.Forms.TextBox memCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button saveButt;
        private System.Windows.Forms.Button clearButt;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button stopButt;
        private System.Windows.Forms.CheckBox realTime;
        private System.Windows.Forms.DataVisualization.Charting.Chart pressureChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart temperatureChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart humidityChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart hiCurrentChart;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
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
        private System.Windows.Forms.CheckBox fz_resistance;
        private System.Windows.Forms.CheckBox scroll_pressure;
        private System.Windows.Forms.CheckBox scroll_temp;
        private System.Windows.Forms.CheckBox scroll_humid;
        private System.Windows.Forms.CheckBox scroll_resist;
        private System.Windows.Forms.NumericUpDown zoomFactor;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataVisualization.Charting.Chart lowCurrentChart;
    }
}

