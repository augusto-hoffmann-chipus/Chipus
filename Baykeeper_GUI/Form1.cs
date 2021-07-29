using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;



namespace Baykeeper_GUI
{

    public enum Outputs : int
    {
        LDO1 = 0,
        LDO2 = 1,
        LDO3 = 2,
        VDCDC1 = 3,
        VDCDC2 = 4
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        ///////////////////////////////////// Form Events /////////////////////////////////////////
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void comboBox_serialPorts_Click(object sender, EventArgs e)
        {
            comboBox_serialPorts.Items.Clear();
            String[] ports = null;
            ports = SerialPort.GetPortNames();//
            comboBox_serialPorts.Items.AddRange(ports);
            ports = null;
        }

        private void button_serialPorts_Click(object sender, EventArgs e)
        {
            // Disconnect serial handle
            if (serialPort1.IsOpen)
            {
                serialDisconnect();


            }
            // Connect serial handle
            else
                if (serialConnect() == true)
            {

                button_serialPorts.Text = "Disconnect";
                label_serialPortStatus.Text = "Connected";
                label_serialPortStatus.ForeColor = Color.Lime;
            }
            else
                // error message
                MessageBox.Show("Connection attempt failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void linkLabel_tabAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            this.linkLabel_tabAbout.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://www.chipus-ip.com/");
        }

        ///////////////////////////////////// Serial Events /////////////////////////////////////////
        public bool serialConnect()
        {
            serialPort1.Dispose();
            serialPort1.PortName = comboBox_serialPorts.Text;
            try
            {
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                // do nothing
            }


            if (serialPort1.IsOpen)
            {
                button_outputLDO1.Enabled = true;
                button_outputLDO2.Enabled = true;
                button_outputLDO3.Enabled = true;
                button_outputVDCDC1.Enabled = true;
                button_outputVDCDC2.Enabled = true;
                button_outputAllOn.Enabled = true;
                button_outputAllOff.Enabled = true;

                timer_serialCheck.Enabled = true;

                comboBox_serialPorts.Enabled = false;

                return true;
            }
            else
                return false;
        }
        public void serialDisconnect()
        {
            button_serialPorts.Text = "Connect";
            label_serialPortStatus.Text = "Disconnected";
            label_serialPortStatus.ForeColor = Color.Red;

            comboBox_serialPorts.Enabled = true;


            if (comboBox_serialPorts.Text != "")
                button_serialPorts.Enabled = true;
            else
                button_serialPorts.Enabled = false;


            comboBox_serialPorts.Items.Remove(comboBox_serialPorts.Text);

            serialPort1.Dispose();

            try
            {
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                // do nothing
            }

            comboBox_serialPorts.Text = "";
            button_serialPorts.Enabled = false;

            button_outputLDO1.Enabled = false;
            button_outputLDO2.Enabled = false;
            button_outputLDO3.Enabled = false;
            button_outputVDCDC1.Enabled = false;
            button_outputVDCDC2.Enabled = false;
            button_outputAllOn.Enabled = false;
            button_outputAllOff.Enabled = false;
        }

        private void comboBox_serialPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_serialPorts.Text != "")
                button_serialPorts.Enabled = true;
            else
                button_serialPorts.Enabled = false;
        }





        ///////////////////////////////////// Output Buttons Handle ///////////
        private void button_outputLDO1_Click(object sender, EventArgs e)
        {
            if (button_outputLDO1.Text == "ON")
            {
                outputOn(Outputs.LDO1);
            }
            else
            {
                outputOff(Outputs.LDO1);
            }
        }

        private void button_outputLDO2_Click(object sender, EventArgs e)
        {
            if (button_outputLDO2.Text == "ON")
            {
                outputOn(Outputs.LDO2);
            }
            else
            {
                outputOff(Outputs.LDO2);
            }
        }

        private void button_outputLDO3_Click(object sender, EventArgs e)
        {
            if (button_outputLDO3.Text == "ON")
            {
                outputOn(Outputs.LDO3);
            }
            else
            {
                outputOff(Outputs.LDO3);
            }
        }

        private void button_outputVDCDC1_Click(object sender, EventArgs e)
        {
            if (button_outputVDCDC1.Text == "ON")
            {
                outputOn(Outputs.VDCDC1);
            }
            else
            {
                outputOff(Outputs.VDCDC1);
            }
        }

        private void button_outputVDCDC2_Click(object sender, EventArgs e)
        {
            if (button_outputVDCDC2.Text == "ON")
            {
                outputOn(Outputs.VDCDC2);
            }
            else
            {
                outputOff(Outputs.VDCDC2);
            }
        }

        private void button_outputAllOn_Click(object sender, EventArgs e)
        {
            int min = Enum.GetValues(typeof(Outputs)).Cast<int>().Min();
            int max = Enum.GetValues(typeof(Outputs)).Cast<int>().Max();

            for (int i = min; i <= max; i++)
            {
                outputOn((Outputs)i);
            }
        }

        private void button_outputAllOff_Click(object sender, EventArgs e)
        {
            int min = Enum.GetValues(typeof(Outputs)).Cast<int>().Min();
            int max = Enum.GetValues(typeof(Outputs)).Cast<int>().Max();

            for (int i = min; i <= max; i++)
            {
                outputOff((Outputs)i);
            }
        }

        public void outputOff(Outputs outputOff)
        {
            switch (outputOff)
            {
                case Outputs.LDO1:
                    {
                        button_outputLDO1.Text = "ON";
                        pictureBox_statusLDO1.Image = Properties.Resources.outputStatusOff;
                        break;
                    }
                case Outputs.LDO2:
                    {
                        button_outputLDO2.Text = "ON";
                        pictureBox_statusLDO2.Image = Properties.Resources.outputStatusOff;
                        break;
                    }
                case Outputs.LDO3:
                    {
                        button_outputLDO3.Text = "ON";
                        pictureBox_statusLDO3.Image = Properties.Resources.outputStatusOff;
                        break;
                    }
                case Outputs.VDCDC1:
                    {
                        button_outputVDCDC1.Text = "ON";
                        pictureBox_statusVDCDC1.Image = Properties.Resources.outputStatusOff;
                        break;
                    }
                case Outputs.VDCDC2:
                    {
                        button_outputVDCDC2.Text = "ON";
                        pictureBox_statusVDCDC2.Image = Properties.Resources.outputStatusOff;
                        break;
                    }
                default:
                    break;
            }
        }

        public void outputOn(Outputs outputOn)
        {
            switch (outputOn)
            {
                case Outputs.LDO1:
                    {
                        button_outputLDO1.Text = "OFF";
                        pictureBox_statusLDO1.Image = Properties.Resources.outputStatusOn;
                        break;
                    }
                case Outputs.LDO2:
                    {
                        button_outputLDO2.Text = "OFF";
                        pictureBox_statusLDO2.Image = Properties.Resources.outputStatusOn;
                        break;
                    }
                case Outputs.LDO3:
                    {
                        button_outputLDO3.Text = "OFF";
                        pictureBox_statusLDO3.Image = Properties.Resources.outputStatusOn;
                        break;
                    }
                case Outputs.VDCDC1:
                    {
                        button_outputVDCDC1.Text = "OFF";
                        pictureBox_statusVDCDC1.Image = Properties.Resources.outputStatusOn;
                        break;
                    }
                case Outputs.VDCDC2:
                    {
                        button_outputVDCDC2.Text = "OFF";
                        pictureBox_statusVDCDC2.Image = Properties.Resources.outputStatusOn;
                        break;
                    }
                default:
                    break;
            }
        }

        private void timer_serialCheck_Tick(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                timer_serialCheck.Enabled = false;
                serialDisconnect();
            }
        }
    }
}
