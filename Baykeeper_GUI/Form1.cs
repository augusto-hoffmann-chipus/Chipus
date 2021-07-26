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

namespace Baykeeper_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox_serialPorts_Click(object sender, EventArgs e)
        {
            comboBox_serialPorts.Items.Clear();
            String[] ports = SerialPort.GetPortNames();
            comboBox_serialPorts.Items.AddRange(ports);
        }
    }
}
