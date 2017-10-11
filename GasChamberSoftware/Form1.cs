using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasChamberSoftware
{
    public partial class MainForm : Form
    {
        bool LED_ON = false;
        bool smuDone = false;
        bool nanoDone = false;
        string nano_output;
        string smu_output;
        string iv_curve;
        List <string> logFile = new List<string>();
        int logCount=0;
        public MainForm()
        {
            InitializeComponent();
            Timer updateTimer = new Timer();
            updateTimer.Tick += UpdateTimer_Tick;
            updateTimer.Interval = 1;
            updateTimer.Start();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            if(realTime.Checked && !recordBox.Checked)
            {
                displayNoLog();
            }
            else
            {
                updateDisplay();
            }
            pressureChart.ChartAreas[0].AxisY.IsStartedFromZero = fz_pressure.Checked;
            resistanceChart.ChartAreas[0].AxisY.IsStartedFromZero = fz_resistance.Checked;
            temperatureChart.ChartAreas[0].AxisY.IsStartedFromZero = fz_temp.Checked;
            humidityChart.ChartAreas[0].AxisY.IsStartedFromZero = fz_humidity.Checked;
        }

        private void displayNoLog()
        {
            string[] outputs = new string[] { }; ;
            if (smuDone && nanoDone)
            {
                try
                {
                    outputs = nano_output.Split(',');
                }
                catch (Exception err)
                {
                    nano_output = "0,0,0,0";
                    outputs = nano_output.Split(',');
                }
                pressureBox.Text = outputs[0];
                tempBox.Text = outputs[1];
                humidBox.Text = outputs[2];
                if (LED_ON)
                {
                    ledBox.Text = "1";
                }
                else
                {
                    ledBox.Text = "0";
                }
                resistBox.Text = smu_output;
                smuDone = false;
                nanoDone = false;
                readAllButt.Enabled = true;
                DateTime curDT = DateTime.Now;
                updateChart(iv_curve, pressureBox.Text, tempBox.Text, humidBox.Text, resistBox.Text, curDT.ToLongTimeString());
                object sender = null;
                EventArgs e = null;
                readAll_click(sender, e);
            }
        }

        private void updateDisplay()
        {
            string[] outputs = new string[] { }; ;
            if(smuDone && nanoDone)
            {
                try
                {
                    outputs = nano_output.Split(',');
                }
                catch (Exception err)
                {
                    nano_output = "0,0,0,0";
                    outputs = nano_output.Split(',');
                }
                pressureBox.Text = outputs[0];
                tempBox.Text = outputs[1];
                humidBox.Text = outputs[2];
                if (LED_ON)
                {
                    ledBox.Text = "1";
                }
                else
                {
                    ledBox.Text = "0";
                }
                resistBox.Text = smu_output;
                smuDone = false;
                nanoDone = false;
                readAllButt.Enabled = true;
                if(autoRead.Enabled == false && Convert.ToInt16(autoCount.Text)>0 && !recordBox.Checked)
                {
                    autoCount.Text = (Convert.ToInt16(autoCount.Text) - 1).ToString();
                    object sender = null;
                    EventArgs e = null;
                    readAll_click(sender,e);
                }
                else if(recordBox.Checked)
                {
                    object sender = null;
                    EventArgs e = null;
                    readAll_click(sender, e);
                }
                else
                {
                    autoRead.Enabled = true;
                }
                DateTime curDT = DateTime.Now;
                updateChart(iv_curve, pressureBox.Text, tempBox.Text, humidBox.Text, resistBox.Text, curDT.ToLongTimeString());
                logFile.Add(curDT.ToString()+","+pressureBox.Text + "," + tempBox.Text + "," + humidBox.Text + "," + ledBox.Text + "," + resistBox.Text + "," + startVolt.Text + "," + endVolt.Text + "," + intVolt.Text);
                logCount++;
                memCount.Text = logCount.ToString();
            }
        }

        private void updateChart(string iv_curve, string pressure, string temperature, string humidity, string resistance, string datetime)
        {
            string[] ivPoints = iv_curve.Split(';');
            ivChart.Series["Series1"].Points.Clear();
            ivChart.ChartAreas[0].AxisX.Title = "Voltage";
            ivChart.ChartAreas[0].AxisY.Title = "Current";
            foreach (string ivpoint in ivPoints)
            {
                //Console.WriteLine(ivpoint);
                try
                {
                    string xpoint = ivpoint.Split(',')[0];
                    string ypoint = ivpoint.Split(',')[1];
                    ivChart.Series["Series1"].Points.AddXY(xpoint, ypoint);
                }
                catch(Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
            try
            {
                pressureChart.ChartAreas[0].AxisY.Title = "Pressure (hPa)";
                pressureChart.Series["Series1"].Points.AddXY(datetime, pressure);
                temperatureChart.ChartAreas[0].AxisY.Title = "Temperature (c)";
                temperatureChart.Series["Series1"].Points.AddXY(datetime, temperature);
                humidityChart.ChartAreas[0].AxisY.Title = "Humidity (%RH)";
                humidityChart.Series["Series1"].Points.AddXY(datetime, humidity);
                resistanceChart.ChartAreas[0].AxisY.Title = "Resistance (Ohm)";
                resistanceChart.Series["Series1"].Points.AddXY(datetime, resistance);
                if(scroll_pressure.Checked)
                {
                    pressureChart.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
                    pressureChart.ChartAreas[0].AxisX.IsLabelAutoFit = true;
                    pressureChart.ChartAreas[0].AxisX.ScaleView.Size = 100;
                    if (pressureChart.ChartAreas[0].AxisX.Maximum > pressureChart.ChartAreas[0].AxisX.ScaleView.Size)
                    {
                        pressureChart.ChartAreas[0].AxisX.ScaleView.Scroll(pressureChart.ChartAreas[0].AxisX.Maximum);
                    }       
                }

                if (scroll_resist.Checked)
                {
                    resistanceChart.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
                    resistanceChart.ChartAreas[0].AxisX.IsLabelAutoFit = true;
                    resistanceChart.ChartAreas[0].AxisX.ScaleView.Size = 100;
                    if (resistanceChart.ChartAreas[0].AxisX.Maximum > resistanceChart.ChartAreas[0].AxisX.ScaleView.Size)
                    {
                        resistanceChart.ChartAreas[0].AxisX.ScaleView.Scroll(resistanceChart.ChartAreas[0].AxisX.Maximum);
                    }
                }

                if (scroll_temp.Checked)
                {
                    temperatureChart.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
                    temperatureChart.ChartAreas[0].AxisX.IsLabelAutoFit = true;
                    temperatureChart.ChartAreas[0].AxisX.ScaleView.Size = 100;
                    if (temperatureChart.ChartAreas[0].AxisX.Maximum > temperatureChart.ChartAreas[0].AxisX.ScaleView.Size)
                    {
                        temperatureChart.ChartAreas[0].AxisX.ScaleView.Scroll(temperatureChart.ChartAreas[0].AxisX.Maximum);
                    }
                }

                if (scroll_humid.Checked)
                {
                    humidityChart.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
                    humidityChart.ChartAreas[0].AxisX.IsLabelAutoFit = true;
                    humidityChart.ChartAreas[0].AxisX.ScaleView.Size = 100;
                    if (humidityChart.ChartAreas[0].AxisX.Maximum > humidityChart.ChartAreas[0].AxisX.ScaleView.Size)
                    {
                        humidityChart.ChartAreas[0].AxisX.ScaleView.Scroll(humidityChart.ChartAreas[0].AxisX.Maximum);
                    }
                }


            }
            catch { }
        }

        private void nano_connect_Click(object sender, EventArgs e)
        {
            serialPort_nano.Open();
            LEDswitch.Enabled = true;
            smu_connect.Enabled = true;
            nano_connect.Enabled = false;
        }

        private void smu_connect_Click(object sender, EventArgs e)
        {
            serialPort_smu.Open();
            readAllButt.Enabled = true;
            autoRead.Enabled = true;
            smu_connect.Enabled = false;
            realTime.Enabled = true;
            realTime.Checked = true;
            recordBox.Enabled = true;
        }

        private void serialPort_smu_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                iv_curve = serialPort_smu.ReadLine();
                smu_output = serialPort_smu.ReadLine();
                smuDone = true;
            }
            catch
            { }

            
        }

        private void serialPort_nano_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            nanoDone = true;
            nano_output = serialPort_nano.ReadLine();
        }

        private void LEDswitch_Click(object sender, EventArgs e)
        {
            if(!LED_ON)
            {
                serialPort_nano.WriteLine("UV_ON");
                LED_ON = true;
            }
            else
            {
                serialPort_nano.WriteLine("UV_OFF");
                LED_ON = false;
            }
            
        }

        private void readAll_click(object sender, EventArgs e)
        {
            saveButt.Enabled = true;
            clearButt.Enabled = true;
            smuDone = false;
            nanoDone = false;
            readAllButt.Enabled = false;
            serialPort_nano.WriteLine("STAT");
            if(startVolt.Text != endVolt.Text && Convert.ToDouble(intVolt.Text) != 0 && Convert.ToDouble(endVolt.Text) - Convert.ToDouble(startVolt.Text) >= Convert.ToDouble(intVolt.Text))
            {
                serialPort_smu.WriteLine("start(" + startVolt.Text + "," + endVolt.Text + "," + intVolt.Text + ")");
            }
            else
            {
                serialPort_smu.WriteLine("start(1,3,0.5)");
            }
        }

        private void autoRead_Click(object sender, EventArgs e)
        {
            autoRead.Enabled = false;
            stopButt.Enabled = true;
            readAll_click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show("This operation cannot be undone. Confirm delete?", "Delete logs", buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                logCount = 0;
                logFile.Clear();
                memCount.Text = "0";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "CSV|*.csv|All file|*.";
            saveFileDialog1.Title = "Save output as";
            saveFileDialog1.FileOk += SaveFileDialog1_FileOk;
            saveFileDialog1.ShowDialog();
        }

        private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            using (var writer = new StreamWriter(saveFileDialog1.FileName))
            {
                writer.WriteLine("TimeStamp,Pressure,Temperature,Humidity,LEDStatus,Resistance,Vstart,Vend,Vint");
                foreach (string loggedline in logFile)
                {
                    writer.WriteLine(loggedline);
                }
            }
        }

        private void stopButt_Click(object sender, EventArgs e)
        {
            autoCount.Text = "0";
            realTime.Checked = false;
        }

        private void realTime_CheckedChanged(object sender, EventArgs e)
        {
            if(realTime.Checked)
            {
                stopButt.Enabled = true;
                autoRead.Enabled = false;
                readAll_click(sender, e);
            }
            else
            {
                stopButt.Enabled = false;
                autoRead.Enabled = true;
            }

        }

        private void ResetChart_Click(object sender, EventArgs e)
        {
            ivChart.Series["Series1"].Points.Clear();
            pressureChart.Series["Series1"].Points.Clear();
            temperatureChart.Series["Series1"].Points.Clear();
            humidityChart.Series["Series1"].Points.Clear();
            resistanceChart.Series["Series1"].Points.Clear();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pressureChart.ChartAreas[0].AxisY.IsStartedFromZero = fz_pressure.Checked;
        }

        private void fz_temp_CheckedChanged(object sender, EventArgs e)
        {
            temperatureChart.ChartAreas[0].AxisY.IsStartedFromZero = fz_temp.Checked;
        }

        private void fz_humidity_CheckedChanged(object sender, EventArgs e)
        {
            humidityChart.ChartAreas[0].AxisY.IsStartedFromZero = fz_humidity.Checked;
        }

        private void fz_resistance_CheckedChanged(object sender, EventArgs e)
        {
            resistanceChart.ChartAreas[0].AxisY.IsStartedFromZero = fz_resistance.Checked;
        }

        private void scroll_pressure_CheckedChanged(object sender, EventArgs e)
        {
            if(!scroll_pressure.Checked)
            {
                pressureChart.ChartAreas[0].AxisX.ScrollBar.Enabled = false;
                pressureChart.ChartAreas[0].AxisX.IsLabelAutoFit = false;
                pressureChart.ChartAreas[0].AxisX.ScaleView.ZoomReset();
            }
        }

        private void scroll_resist_CheckedChanged(object sender, EventArgs e)
        {
            if (!scroll_resist.Checked)
            {
                resistanceChart.ChartAreas[0].AxisX.ScrollBar.Enabled = false;
                resistanceChart.ChartAreas[0].AxisX.IsLabelAutoFit = false;
                resistanceChart.ChartAreas[0].AxisX.ScaleView.ZoomReset();
            }
        }

        private void scroll_temp_CheckedChanged(object sender, EventArgs e)
        {
            if (!scroll_temp.Checked)
            {
               temperatureChart.ChartAreas[0].AxisX.ScrollBar.Enabled = false;
               temperatureChart.ChartAreas[0].AxisX.IsLabelAutoFit = false;
               temperatureChart.ChartAreas[0].AxisX.ScaleView.ZoomReset();
            }
        }

        private void scroll_humid_CheckedChanged(object sender, EventArgs e)
        {
            if (!scroll_temp.Checked)
            {
                humidityChart.ChartAreas[0].AxisX.ScrollBar.Enabled = false;
                humidityChart.ChartAreas[0].AxisX.IsLabelAutoFit = false;
                humidityChart.ChartAreas[0].AxisX.ScaleView.ZoomReset();
            }
        }
    }
}
