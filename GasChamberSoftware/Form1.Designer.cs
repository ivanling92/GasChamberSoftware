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
            ((System.ComponentModel.ISupportInitialize)(this.ivChart)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pressure (hPa)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperature (c)";
            // 
            // pressureBox
            // 
            this.pressureBox.Location = new System.Drawing.Point(129, 25);
            this.pressureBox.Name = "pressureBox";
            this.pressureBox.ReadOnly = true;
            this.pressureBox.Size = new System.Drawing.Size(100, 20);
            this.pressureBox.TabIndex = 2;
            this.pressureBox.Text = "0";
            // 
            // tempBox
            // 
            this.tempBox.Location = new System.Drawing.Point(129, 53);
            this.tempBox.Name = "tempBox";
            this.tempBox.ReadOnly = true;
            this.tempBox.Size = new System.Drawing.Size(100, 20);
            this.tempBox.TabIndex = 3;
            this.tempBox.Text = "0";
            // 
            // humidBox
            // 
            this.humidBox.Location = new System.Drawing.Point(129, 84);
            this.humidBox.Name = "humidBox";
            this.humidBox.ReadOnly = true;
            this.humidBox.Size = new System.Drawing.Size(100, 20);
            this.humidBox.TabIndex = 5;
            this.humidBox.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 87);
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
            this.nano_portname.Location = new System.Drawing.Point(326, 37);
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
            this.smu_portname.Location = new System.Drawing.Point(326, 76);
            this.smu_portname.Name = "smu_portname";
            this.smu_portname.Size = new System.Drawing.Size(121, 21);
            this.smu_portname.TabIndex = 7;
            this.smu_portname.Text = "COM5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nano Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "SMU Port";
            // 
            // nano_connect
            // 
            this.nano_connect.Location = new System.Drawing.Point(466, 37);
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
            this.smu_connect.Location = new System.Drawing.Point(466, 76);
            this.smu_connect.Name = "smu_connect";
            this.smu_connect.Size = new System.Drawing.Size(75, 23);
            this.smu_connect.TabIndex = 10;
            this.smu_connect.Text = "Connect";
            this.smu_connect.UseVisualStyleBackColor = true;
            this.smu_connect.Click += new System.EventHandler(this.smu_connect_Click);
            // 
            // ledBox
            // 
            this.ledBox.Location = new System.Drawing.Point(129, 116);
            this.ledBox.Name = "ledBox";
            this.ledBox.ReadOnly = true;
            this.ledBox.Size = new System.Drawing.Size(100, 20);
            this.ledBox.TabIndex = 12;
            this.ledBox.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "LED Status";
            // 
            // LEDswitch
            // 
            this.LEDswitch.Enabled = false;
            this.LEDswitch.Location = new System.Drawing.Point(344, 116);
            this.LEDswitch.Name = "LEDswitch";
            this.LEDswitch.Size = new System.Drawing.Size(75, 23);
            this.LEDswitch.TabIndex = 13;
            this.LEDswitch.Text = "Toggle LED";
            this.LEDswitch.UseVisualStyleBackColor = true;
            this.LEDswitch.Click += new System.EventHandler(this.LEDswitch_Click);
            // 
            // resistBox
            // 
            this.resistBox.Location = new System.Drawing.Point(129, 156);
            this.resistBox.Name = "resistBox";
            this.resistBox.ReadOnly = true;
            this.resistBox.Size = new System.Drawing.Size(100, 20);
            this.resistBox.TabIndex = 15;
            this.resistBox.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Resistance";
            // 
            // readAllButt
            // 
            this.readAllButt.Enabled = false;
            this.readAllButt.Location = new System.Drawing.Point(438, 116);
            this.readAllButt.Name = "readAllButt";
            this.readAllButt.Size = new System.Drawing.Size(91, 23);
            this.readAllButt.TabIndex = 17;
            this.readAllButt.Text = "Read All";
            this.readAllButt.UseVisualStyleBackColor = true;
            this.readAllButt.Click += new System.EventHandler(this.readAll_click);
            // 
            // intVolt
            // 
            this.intVolt.Location = new System.Drawing.Point(439, 215);
            this.intVolt.Name = "intVolt";
            this.intVolt.Size = new System.Drawing.Size(100, 20);
            this.intVolt.TabIndex = 23;
            this.intVolt.Text = "0.1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Interval (V)";
            // 
            // endVolt
            // 
            this.endVolt.Location = new System.Drawing.Point(439, 184);
            this.endVolt.Name = "endVolt";
            this.endVolt.Size = new System.Drawing.Size(100, 20);
            this.endVolt.TabIndex = 21;
            this.endVolt.Text = "3";
            // 
            // startVolt
            // 
            this.startVolt.Location = new System.Drawing.Point(439, 156);
            this.startVolt.Name = "startVolt";
            this.startVolt.Size = new System.Drawing.Size(100, 20);
            this.startVolt.TabIndex = 20;
            this.startVolt.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(338, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "End Voltage (V)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(338, 156);
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
            this.ivChart.Location = new System.Drawing.Point(25, 182);
            this.ivChart.Name = "ivChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ivChart.Series.Add(series1);
            this.ivChart.Size = new System.Drawing.Size(300, 216);
            this.ivChart.TabIndex = 24;
            this.ivChart.Text = "chart1";
            // 
            // autoCount
            // 
            this.autoCount.Location = new System.Drawing.Point(438, 279);
            this.autoCount.Name = "autoCount";
            this.autoCount.Size = new System.Drawing.Size(58, 20);
            this.autoCount.TabIndex = 26;
            this.autoCount.Text = "10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(337, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Auto read times:";
            // 
            // autoRead
            // 
            this.autoRead.Enabled = false;
            this.autoRead.Location = new System.Drawing.Point(508, 277);
            this.autoRead.Name = "autoRead";
            this.autoRead.Size = new System.Drawing.Size(77, 23);
            this.autoRead.TabIndex = 27;
            this.autoRead.Text = "Start";
            this.autoRead.UseVisualStyleBackColor = true;
            this.autoRead.Click += new System.EventHandler(this.autoRead_Click);
            // 
            // memCount
            // 
            this.memCount.Location = new System.Drawing.Point(448, 311);
            this.memCount.Name = "memCount";
            this.memCount.ReadOnly = true;
            this.memCount.Size = new System.Drawing.Size(48, 20);
            this.memCount.TabIndex = 29;
            this.memCount.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(337, 314);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Readings in memory:";
            // 
            // saveButt
            // 
            this.saveButt.Enabled = false;
            this.saveButt.ForeColor = System.Drawing.Color.SeaGreen;
            this.saveButt.Location = new System.Drawing.Point(340, 342);
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
            this.clearButt.Location = new System.Drawing.Point(423, 342);
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
            this.stopButt.Location = new System.Drawing.Point(508, 309);
            this.stopButt.Name = "stopButt";
            this.stopButt.Size = new System.Drawing.Size(77, 23);
            this.stopButt.TabIndex = 32;
            this.stopButt.Text = "Stop";
            this.stopButt.UseVisualStyleBackColor = true;
            this.stopButt.Click += new System.EventHandler(this.stopButt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 415);
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
            this.Name = "MainForm";
            this.Text = "Gas Chamber - SOTON";
            ((System.ComponentModel.ISupportInitialize)(this.ivChart)).EndInit();
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
    }
}

