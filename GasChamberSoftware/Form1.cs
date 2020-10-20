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
using System.IO.Ports;

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
using System.IO.Ports;

namespace GasChamberSoftware
{
    public partial class MainForm : Form
    {
        bool smuDone = false;
        bool nanoDone = false;
        bool nanoConnected = false;
        string nano_output;
        List <string> logFile = new List<string>();
        int logCount=0;
        Timer updateTimer = new Timer();
        int junkCount = 3; //remove first few data

        string[] ports;
        public MainForm()
        {
            InitializeComponent();
            updateTimer.Tick += UpdateTimer_Tick;
            updateTimer.Interval = 100;
            nano_connect.Focus();
            try
            {
                ports = SerialPort.GetPortNames();
                nano_portname.Items.Clear();
                nano_portname.Items.AddRange(ports);
                analyteBox.SelectedIndex = 0;
                diluentBox.SelectedIndex = 0;
                nano_portname.SelectedIndex = nano_portname.Items.Count - 1;
            }
            catch (Exception err)
            {

            }
            
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            if (!recordBox.Checked)
            {
                displayNoLog();
            }
            else
            {
                updateDisplay();
            }

            pressureChart.ChartAreas[0].AxisY.IsStartedFromZero = fz_pressure.Checked;
            temperatureChart.ChartAreas[0].AxisY.IsStartedFromZero = fz_temp.Checked;
            humidityChart.ChartAreas[0].AxisY.IsStartedFromZero = fz_humidity.Checked;
            no2Chart.ChartAreas[0].AxisY.IsStartedFromZero = fz_NO2.Checked; //UPDATE HERE
            coChart.ChartAreas[0].AxisY.IsStartedFromZero = fz_CO.Checked;
            nh3Chart.ChartAreas[0].AxisY.IsStartedFromZero = fz_NH3.Checked;
            h2Chart.ChartAreas[0].AxisY.IsStartedFromZero = fz_h2.Checked;
        }

        private void displayNoLog() //UPDATE WHEN ALL DONE
        {
            //to be updated after finalized
        }

        private void updateDisplay()
        {
            string[] outputs = new string[] { }; ;
            if(nanoDone)
            {
                if(junkCount > 0)
                {
                    statusLogBox.AppendText("Initializing.... " + junkCount + "\n");
                    junkCount -= 1;
                    if(junkCount == 0)
                        statusLogBox.AppendText("Success! Reading started!\n");
                    return;
                }


                try
                {
                    outputs = nano_output.Split(',');
                    if(RawOutput.Checked)
                    {
                        statusLogBox.AppendText(nano_output);
                    }
                }
                catch (Exception err)
                {
                    nano_output = "0,0,0,0,0,0,0,0,0";
                    outputs = nano_output.Split(',');
                }
                string heaterOn;
                try
                {
                    pressureBox.Text = outputs[6]; //update here
                    tempBox.Text = outputs[4];
                    humidBox.Text = outputs[5];
                    ambtempBox.Text = outputs[7];
                    no2Box.Text = outputs[0];
                    coBox.Text = outputs[1];
                    nh3Box.Text = outputs[2];
                    h2Box.Text = outputs[3];
                    heaterOn = outputs[8];
                    heaterOn = heaterOn.Substring(0, 1);
                }
                catch
                {
                    return;
                    statusLogBox.AppendText("Invalid frame\n");
                }

                if(heaterOn == "1")
                {
                    Heat_But.Text = "Stop Heating";
                    isHeating = true;
                    heaterIndicator.Text = "HEATER ON";
                    heaterIndicator.ForeColor = Color.Red;
                }
                else
                {
                    Heat_But.Text = "Start Heating";
                    isHeating = false;
                    heaterIndicator.Text = "HEATER OFF";
                    heaterIndicator.ForeColor = Color.MidnightBlue;
                }
                smuDone = false;
                nanoDone = false;
                if(recordBox.Checked)
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
                updateChart(pressureBox.Text, tempBox.Text, humidBox.Text, no2Box.Text, coBox.Text, nh3Box.Text, h2Box.Text, curDT.ToLongTimeString()); //UPDATE HERE
                //Creates a CSV string. to add stuff, just add to the CSV string
                string csvStrings = no2Box.Text + "," + coBox.Text + "," + nh3Box.Text + "," + h2Box.Text + "," + tempBox.Text + "," + humidBox.Text + "," + pressureBox.Text + "," + ambtempBox.Text+","+heaterOn;
                logFile.Add((curDT.ToLongTimeString() + "," + csvStrings).Replace(System.Environment.NewLine, null));//UPDATE HERE
                logCount++;
                memCount.Text = logCount.ToString();
                using (var writer = new StreamWriter("EmergencyLog.csv",true))
                {
                    writer.WriteLine((curDT.ToShortDateString()+","+curDT.ToLongTimeString() + ","  + csvStrings).Replace(System.Environment.NewLine, null)); //UPDATE HERE
                }
            }
        }

        private void updateChart(string pressure, string temperature, string humidity, string no2, string co, string nh3, string h2, string datetime)//UPDATE HERE
        {
            try
            {
                pressureChart.ChartAreas[0].AxisY.Title = "Pressure (hPa)";
                pressureChart.Series["Series1"].Points.AddXY(datetime, pressure);
                temperatureChart.ChartAreas[0].AxisY.Title = "Temperature (c)";
                temperatureChart.Series["Series1"].Points.AddXY(datetime, temperature);
                humidityChart.ChartAreas[0].AxisY.Title = "Humidity (%RH)";
                humidityChart.Series["Series1"].Points.AddXY(datetime, humidity);
                no2Chart.ChartAreas[0].AxisY.Title = "NO2 (PPM)";//UPDATE HERE
                no2Chart.Series["Series1"].Points.AddXY(datetime, no2);
                coChart.ChartAreas[0].AxisY.Title = "CO (PPM)";
                coChart.Series["Series1"].Points.AddXY(datetime, co);
                nh3Chart.ChartAreas[0].AxisY.Title = "NH3 (PPM)";
                nh3Chart.Series["Series1"].Points.AddXY(datetime, nh3);
                h2Chart.ChartAreas[0].AxisY.Title = "H2 (PPM)";
                h2Chart.Series["Series1"].Points.AddXY(datetime, h2);

                if (scroll_pressure.Checked)
                {
                    pressureChart.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
                    pressureChart.ChartAreas[0].AxisX.IsLabelAutoFit = true;
                    pressureChart.ChartAreas[0].AxisX.ScaleView.Size = Convert.ToInt32(zoomFactor.Value);
                    if (pressureChart.ChartAreas[0].AxisX.Maximum > pressureChart.ChartAreas[0].AxisX.ScaleView.Size)
                    {
                        pressureChart.ChartAreas[0].AxisX.ScaleView.Scroll(pressureChart.ChartAreas[0].AxisX.Maximum);
                    }       
                }


                if (scroll_temp.Checked)
                {
                    temperatureChart.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
                    temperatureChart.ChartAreas[0].AxisX.IsLabelAutoFit = true;
                    temperatureChart.ChartAreas[0].AxisX.ScaleView.Size = Convert.ToInt32(zoomFactor.Value);
                    if (temperatureChart.ChartAreas[0].AxisX.Maximum > temperatureChart.ChartAreas[0].AxisX.ScaleView.Size)
                    {
                        temperatureChart.ChartAreas[0].AxisX.ScaleView.Scroll(temperatureChart.ChartAreas[0].AxisX.Maximum);
                    }
                }

                if (scroll_humid.Checked)
                {
                    humidityChart.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
                    humidityChart.ChartAreas[0].AxisX.IsLabelAutoFit = true;
                    humidityChart.ChartAreas[0].AxisX.ScaleView.Size = Convert.ToInt32(zoomFactor.Value);
                    if (humidityChart.ChartAreas[0].AxisX.Maximum > humidityChart.ChartAreas[0].AxisX.ScaleView.Size)
                    {
                        humidityChart.ChartAreas[0].AxisX.ScaleView.Scroll(humidityChart.ChartAreas[0].AxisX.Maximum);
                    }
                }


                if (scrollNO2.Checked)  //UPDATE HERE
                {
                    no2Chart.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
                    no2Chart.ChartAreas[0].AxisX.IsLabelAutoFit = true;
                    no2Chart.ChartAreas[0].AxisX.ScaleView.Size = Convert.ToInt32(zoomFactor.Value);
                    if (no2Chart.ChartAreas[0].AxisX.Maximum > no2Chart.ChartAreas[0].AxisX.ScaleView.Size)
                    {
                        no2Chart.ChartAreas[0].AxisX.ScaleView.Scroll(no2Chart.ChartAreas[0].AxisX.Maximum);
                    }
                }

                if (scroll_co.Checked)  //UPDATE HERE
                {
                    coChart.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
                    coChart.ChartAreas[0].AxisX.IsLabelAutoFit = true;
                    coChart.ChartAreas[0].AxisX.ScaleView.Size = Convert.ToInt32(zoomFactor.Value);
                    if (coChart.ChartAreas[0].AxisX.Maximum > coChart.ChartAreas[0].AxisX.ScaleView.Size)
                    {
                        coChart.ChartAreas[0].AxisX.ScaleView.Scroll(no2Chart.ChartAreas[0].AxisX.Maximum);
                    }
                }

                if (scroll_nh3.Checked)  //UPDATE HERE
                {
                    nh3Chart.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
                    nh3Chart.ChartAreas[0].AxisX.IsLabelAutoFit = true;
                    nh3Chart.ChartAreas[0].AxisX.ScaleView.Size = Convert.ToInt32(zoomFactor.Value);
                    if (nh3Chart.ChartAreas[0].AxisX.Maximum > nh3Chart.ChartAreas[0].AxisX.ScaleView.Size)
                    {
                        nh3Chart.ChartAreas[0].AxisX.ScaleView.Scroll(no2Chart.ChartAreas[0].AxisX.Maximum);
                    }
                }

                if (scroll_h2.Checked)  //UPDATE HERE
                {
                    h2Chart.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
                    h2Chart.ChartAreas[0].AxisX.IsLabelAutoFit = true;
                    h2Chart.ChartAreas[0].AxisX.ScaleView.Size = Convert.ToInt32(zoomFactor.Value);
                    if (h2Chart.ChartAreas[0].AxisX.Maximum > h2Chart.ChartAreas[0].AxisX.ScaleView.Size)
                    {
                        h2Chart.ChartAreas[0].AxisX.ScaleView.Scroll(no2Chart.ChartAreas[0].AxisX.Maximum);
                    }
                }


            }
            catch { }
        }

        
        private void nano_connect_Click(object sender, EventArgs e)
        {
            if(analyteBox.SelectedItem == null || diluentBox.SelectedItem == null)
            {
                statusLogBox.AppendText("Please select the analyte and diluent first!\n");
                return;
            }
            if (nanoConnected) //Disconnect is clicked
            {
                statusLogBox.AppendText("Disconnecting...\n");
                try
                {
                    serialPort_nano.Close();
                    nano_connect.Text = "Connect";
                    ConnectLabel.Text = "Nano Port";
                    nanoConnected = false;
                    updateTimer.Stop();
                    autoRead.Enabled = false; //Disable both start and stop button
                    stopButt.Enabled = false;
                    statusLogBox.AppendText("Success! \n");
                }
                catch (Exception err)
                {
                    //ConnectLabel.Text = err.Message;
                    statusLogBox.AppendText("Error!\n");
                    statusLogBox.AppendText(err.Message+"\n");
                }
            }
            else //Connect is clicked
            {
                statusLogBox.AppendText("Attempt to connect...\n");
                try
                {
                    serialPort_nano.PortName = nano_portname.Items[nano_portname.SelectedIndex].ToString();
                    serialPort_nano.Open();
                    nano_connect.Text = "Disconnect";
                    ConnectLabel.Text = "Nano Port";
                    nanoConnected = true;
                    updateTimer.Start();
                    autoRead.Enabled = false; //Disable both start button
                    stopButt.Enabled = true;
                    statusLogBox.AppendText("Success! \n");
                    statusLogBox.AppendText("Connected to " + serialPort_nano.PortName + "\n");
                }
                catch (Exception err)
                {
                    //ConnectLabel.Text = err.Message;
                    statusLogBox.AppendText("Error!\n");
                    statusLogBox.AppendText(err.Message + "\n");
                }
            }
            
            
        }


        private void serialPort_nano_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            nanoDone = true;
            try
            {
                nano_output = serialPort_nano.ReadLine();
            }
            catch (Exception err)
            {

            }
            
        }


        private void readAll_click(object sender, EventArgs e)
        {
            saveButt.Enabled = true;
            clearButt.Enabled = true;
            smuDone = false;
            nanoDone = false;
        }

        private void autoRead_Click(object sender, EventArgs e)
        {
            stopButt.Enabled = true;
            autoRead.Enabled = false;
            updateTimer.Interval = Convert.ToInt32(intVolt.Text)*1000;
            updateTimer.Start();
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
                writer.WriteLine("TimeStamp,NO2,NH3,CO,H2,Temperature,Humidity,Pressure,AmbientTemp,HeaterOn");
                foreach (string loggedline in logFile)
                {
                    writer.WriteLine(loggedline);
                }
            }
        }

        private void stopButt_Click(object sender, EventArgs e)
        {
            try
            {
                updateTimer.Stop();
                autoRead.Enabled = true;
            }
            catch(Exception err)
            {
                Console.WriteLine(err.Message);
            }
            
        }


        private void ResetChart_Click(object sender, EventArgs e)
        {
            pressureChart.Series["Series1"].Points.Clear();
            temperatureChart.Series["Series1"].Points.Clear();
            humidityChart.Series["Series1"].Points.Clear();
            no2Chart.Series["Series1"].Points.Clear();
            h2Chart.Series["Series1"].Points.Clear();
            coChart.Series["Series1"].Points.Clear();
            nh3Chart.Series["Series1"].Points.Clear();
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


        private void scroll_pressure_CheckedChanged(object sender, EventArgs e)
        {
            if(!scroll_pressure.Checked)
            {
                pressureChart.ChartAreas[0].AxisX.ScrollBar.Enabled = false;
                pressureChart.ChartAreas[0].AxisX.IsLabelAutoFit = false;
                pressureChart.ChartAreas[0].AxisX.ScaleView.ZoomReset();
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
            if (!scroll_humid.Checked)
            {
                humidityChart.ChartAreas[0].AxisX.ScrollBar.Enabled = false;
                humidityChart.ChartAreas[0].AxisX.IsLabelAutoFit = false;
                humidityChart.ChartAreas[0].AxisX.ScaleView.ZoomReset();
            }
        }

        private void scroll_co_CheckedChanged(object sender, EventArgs e)
        {
            if (!scroll_co.Checked)
            {
                coChart.ChartAreas[0].AxisX.ScrollBar.Enabled = false;
                coChart.ChartAreas[0].AxisX.IsLabelAutoFit = false;
                coChart.ChartAreas[0].AxisX.ScaleView.ZoomReset();
            }
        }

        private void fz_NO2_CheckedChanged(object sender, EventArgs e)
        {
            no2Chart.ChartAreas[0].AxisY.IsStartedFromZero = fz_NO2.Checked;
        }

        private void fz_CO_CheckedChanged(object sender, EventArgs e)
        {
            coChart.ChartAreas[0].AxisY.IsStartedFromZero = fz_CO.Checked;
        }

        private void nano_portname_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ConnectLabel.Text = nano_portname.Items[nano_portname.SelectedIndex].ToString(); //for debugging only
            statusLogBox.Text += "COM port changed to " + nano_portname.Items[nano_portname.SelectedIndex].ToString() + " successfully!\n";
        }

        private void intVolt_MouseClick(object sender, MouseEventArgs e)
        {
            if (autoRead.Enabled)
            {

            }
            else //if start button is not enabled, means it's already running. Stop it.
            {
                autoRead.Enabled = true;
                stopButt.Enabled = false;
                updateTimer.Stop();
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            //accidental added
        }

        private void scrollNO2_CheckedChanged(object sender, EventArgs e)
        {
            if (!scrollNO2.Checked)
            {
                no2Chart.ChartAreas[0].AxisX.ScrollBar.Enabled = false;
                no2Chart.ChartAreas[0].AxisX.IsLabelAutoFit = false;
                no2Chart.ChartAreas[0].AxisX.ScaleView.ZoomReset();
            }
        }

        private void scroll_nh3_CheckedChanged(object sender, EventArgs e)
        {
            if (!scroll_nh3.Checked)
            {
                nh3Chart.ChartAreas[0].AxisX.ScrollBar.Enabled = false;
                nh3Chart.ChartAreas[0].AxisX.IsLabelAutoFit = false;
                nh3Chart.ChartAreas[0].AxisX.ScaleView.ZoomReset();
            }
        }



        private void scroll_h2_CheckedChanged(object sender, EventArgs e)
        {
            if (!scroll_h2.Checked)
            {
                h2Chart.ChartAreas[0].AxisX.ScrollBar.Enabled = false;
                h2Chart.ChartAreas[0].AxisX.IsLabelAutoFit = false;
                h2Chart.ChartAreas[0].AxisX.ScaleView.ZoomReset();
            }
        }


        private void analyteBar_Scroll(object sender, EventArgs e)
        {
            APWMBox.Text = analyteBar.Value.ToString();
        }

        private void diluentBar_Scroll(object sender, EventArgs e)
        {
            DPWMBox.Text = diluentBar.Value.ToString();
        }

        private void statusLogBox_TextChanged(object sender, EventArgs e)
        {
            statusLogBox.SelectionStart = statusLogBox.Text.Length;
            statusLogBox.ScrollToCaret();
        }

        bool isHeating = false;

        private void Heat_But_Click(object sender, EventArgs e)
        {
            if(isHeating)//if already heating, turn it off
            {
                try
                {
                    serialPort_nano.Write("H_L");
                }
                catch
                {
                    statusLogBox.AppendText("Error writing to Arduino!\n");
                }
            }
            else//if not heating turn it on
            {
                try
                {
                    serialPort_nano.Write("H_H");
                }
                catch
                {
                    statusLogBox.AppendText("Error writing to Arduino!\n");
                }
                
            }
        }
        int tempSetpoint = 20;
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            tempSetpoint = Convert.ToInt16(tempSetpointBox.Text);
            statusLogBox.AppendText("Setpoint is: "+tempSetpoint.ToString()+"\n");
            if(TempController.Checked)
            {
                Heat_But.Enabled = false;
                tempSetpointBox.Enabled = false;
                try
                {
                    serialPort_nano.Write("H_S");
                    serialPort_nano.Write(tempSetpointBox.Text);
                }
                catch
                {
                    statusLogBox.AppendText("Error writing to Arduino!\n");
                }

            }
            else
            {
                Heat_But.Enabled = true;
                tempSetpointBox.Enabled = true;
                try
                {
                    serialPort_nano.Write("H_S");
                    serialPort_nano.Write("0");
                }
                catch
                {
                    statusLogBox.AppendText("Error writing to Arduino!\n");
                }
            }
        }

        private void RawOutput_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CommandBut_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort_nano.Write(manualCommandBox.Text);
                manualCommandBox.Text = "";
            }
            catch
            {
                statusLogBox.AppendText("Error writing to Arduino!\n");
            }
        }
    }
}
