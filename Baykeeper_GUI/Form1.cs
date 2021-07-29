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
            String[] ports = SerialPort.GetPortNames();
            comboBox_serialPorts.Items.AddRange(ports);

        }

        private void button_serialPorts_Click(object sender, EventArgs e)
        {
            // Disconnect serial handle
            if (serialPort1.IsOpen)
            {
                serialDisconnect();
                button_serialPorts.Text = "Connect";
                label_serialPortStatus.Text = "Disconnected";
                label_serialPortStatus.ForeColor = Color.Red;

                comboBox_serialPorts.Items.Clear();
                String[] ports = SerialPort.GetPortNames();
                comboBox_serialPorts.Items.AddRange(ports);


                if (comboBox_serialPorts.Text != "")
                    button_serialPorts.Enabled = true;
                else
                    button_serialPorts.Enabled = false;

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
            serialPort1.Open();

            if (serialPort1.IsOpen)
            {
                return true;
            }
            else
                return false;
        }
        public bool serialDisconnect()
        {
            serialPort1.Dispose();
            serialPort1.Close();

            if (serialPort1.IsOpen)
                return false;
            else
                return true;
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
                button_outputLDO1.Text = "OFF";
                pictureBox_statusLDO1.Image = Properties.Resources.outputStatusOn;
            }
            else
            {
                button_outputLDO1.Text = "ON";
                pictureBox_statusLDO1.Image = Properties.Resources.outputStatusOff;
            }
        }

        private void button_outputLDO2_Click(object sender, EventArgs e)
        {
            if (button_outputLDO2.Text == "ON")
            {
                button_outputLDO2.Text = "OFF";
                pictureBox_statusLDO2.Image = Properties.Resources.outputStatusOn;
            }
            else
            {
                button_outputLDO2.Text = "ON";
                pictureBox_statusLDO2.Image = Properties.Resources.outputStatusOff;
            }
        }

        private void button_outputLDO3_Click(object sender, EventArgs e)
        {
            if (button_outputLDO3.Text == "ON")
            {
                button_outputLDO3.Text = "OFF";
                pictureBox_statusLDO3.Image = Properties.Resources.outputStatusOn;
            }
            else
            {
                button_outputLDO3.Text = "ON";
                pictureBox_statusLDO3.Image = Properties.Resources.outputStatusOff;
            }
        }

        private void button_outputVDCDC1_Click(object sender, EventArgs e)
        {
            if (button_outputVDCDC1.Text == "ON")
            {
                button_outputVDCDC1.Text = "OFF";
                pictureBox_statusVDCDC1.Image = Properties.Resources.outputStatusOn;
            }
            else
            {
                button_outputVDCDC1.Text = "ON";
                pictureBox_statusVDCDC1.Image = Properties.Resources.outputStatusOff;
            }
        }

        private void button_outputVDCDC2_Click(object sender, EventArgs e)
        {
            if (button_outputVDCDC2.Text == "ON")
            {
                button_outputVDCDC2.Text = "OFF";
                pictureBox_statusVDCDC2.Image = Properties.Resources.outputStatusOn;
            }
            else
            {
                button_outputVDCDC2.Text = "ON";
                pictureBox_statusVDCDC2.Image = Properties.Resources.outputStatusOff;
            }
        }

        private void button_outputAllOn_Click(object sender, EventArgs e)
        {
            button_outputLDO1.Text = "OFF";
            pictureBox_statusLDO1.Image = Properties.Resources.outputStatusOn;

            button_outputLDO2.Text = "OFF";
            pictureBox_statusLDO2.Image = Properties.Resources.outputStatusOn;

            button_outputLDO3.Text = "OFF";
            pictureBox_statusLDO3.Image = Properties.Resources.outputStatusOn;

            button_outputVDCDC1.Text = "OFF";
            pictureBox_statusVDCDC1.Image = Properties.Resources.outputStatusOn;

            button_outputVDCDC2.Text = "OFF";
            pictureBox_statusVDCDC2.Image = Properties.Resources.outputStatusOn;
        }

        private void button_outputAllOff_Click(object sender, EventArgs e)
        {
            button_outputLDO1.Text = "ON";
            pictureBox_statusLDO1.Image = Properties.Resources.outputStatusOff;

            button_outputLDO2.Text = "ON";
            pictureBox_statusLDO2.Image = Properties.Resources.outputStatusOff;

            button_outputLDO3.Text = "ON";
            pictureBox_statusLDO3.Image = Properties.Resources.outputStatusOff;

            button_outputVDCDC1.Text = "ON";
            pictureBox_statusVDCDC1.Image = Properties.Resources.outputStatusOff;

            button_outputVDCDC2.Text = "ON";
            pictureBox_statusVDCDC2.Image = Properties.Resources.outputStatusOff;
        }
    }
}
