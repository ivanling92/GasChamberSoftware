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
            updateDisplay();
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
                    ledBox.Text = "ON";
                }
                else
                {
                    ledBox.Text = "OFF";
                }
                resistBox.Text = smu_output;
                smuDone = false;
                nanoDone = false;
                readAllButt.Enabled = true;
                updateChart(iv_curve);
                if(autoRead.Enabled == false && Convert.ToInt16(autoCount.Text)>0)
                {
                    autoCount.Text = (Convert.ToInt16(autoCount.Text) - 1).ToString();
                    object sender = null;
                    EventArgs e = null;
                    readAll_click(sender,e);
                }
                else
                {
                    autoRead.Enabled = true;
                }
                DateTime curDT = DateTime.Now;
                logFile.Add(curDT.ToString()+","+pressureBox.Text + "," + tempBox.Text + "," + humidBox.Text + "," + ledBox.Text + "," + resistBox.Text + "," + startVolt.Text + "," + endVolt.Text + "," + intVolt.Text);
                logCount++;
                memCount.Text = logCount.ToString();
            }
        }

        private void updateChart(string iv_curve)
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

                }
            }
        }

        private void nano_connect_Click(object sender, EventArgs e)
        {
            serialPort_nano.Open();
            LEDswitch.Enabled = true;
            smu_connect.Enabled = true;
        }

        private void smu_connect_Click(object sender, EventArgs e)
        {
            serialPort_smu.Open();
            readAllButt.Enabled = true;
            autoRead.Enabled = true;
        }

        private void serialPort_smu_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            iv_curve = serialPort_smu.ReadLine();
            smu_output = serialPort_smu.ReadLine();
            smuDone = true;
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
            logCount = 0;
            logFile.Clear();
            memCount.Text = "0";
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
        }
    }
}
