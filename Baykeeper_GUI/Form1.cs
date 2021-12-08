#define FT232H                // Enable only one of these defines depending on your device type
//#define FT2232H
//#define FT4232H

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FTD2XX_NET;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;



namespace Baykeeper_GUI
{

    public partial class Form1 : Form
    {

        //###################################################################################################################################
        //###################################################################################################################################
        //##################                                      Definitions                                           #####################
        //###################################################################################################################################
        //###################################################################################################################################

        // ###### Driver defines ######
        FTDI.FT_STATUS ftStatus = FTDI.FT_STATUS.FT_OK;

        // ###### I2C Library defines ######
        const byte I2C_Dir_SDAin_SCLin = 0x00;
        const byte I2C_Dir_SDAin_SCLout = 0x01;
        const byte I2C_Dir_SDAout_SCLout = 0x03;
        const byte I2C_Dir_SDAout_SCLin = 0x02;
        const byte I2C_Data_SDAhi_SCLhi = 0x03;
        const byte I2C_Data_SDAlo_SCLhi = 0x01;
        const byte I2C_Data_SDAlo_SCLlo = 0x00;
        const byte I2C_Data_SDAhi_SCLlo = 0x02;
        // MPSSE clocking commands
        const byte MSB_FALLING_EDGE_CLOCK_BYTE_IN = 0x24;
        const byte MSB_RISING_EDGE_CLOCK_BYTE_IN = 0x20;
        const byte MSB_FALLING_EDGE_CLOCK_BYTE_OUT = 0x11;
        const byte MSB_DOWN_EDGE_CLOCK_BIT_IN = 0x26;
        const byte MSB_UP_EDGE_CLOCK_BYTE_IN = 0x20;
        const byte MSB_UP_EDGE_CLOCK_BYTE_OUT = 0x10;
        const byte MSB_RISING_EDGE_CLOCK_BIT_IN = 0x22;
        const byte MSB_FALLING_EDGE_CLOCK_BIT_OUT = 0x13;
        // Clock
        //const uint ClockDivisor = 49;  // for 400 kHz // frequency clock divider
        const uint ClockDivisor = 199;  // for 100 kHz
        // Sending and receiving
        static uint NumBytesToSend = 0;
        static uint NumBytesToRead = 0;
        uint NumBytesSent = 0;
        static uint NumBytesRead = 0;
        static byte[] MPSSEbuffer = new byte[500];
        static byte[] InputBuffer = new byte[500];
        static byte[] InputBuffer2 = new byte[500];
        static uint BytesAvailable = 0;
        static bool I2C_Ack = false;
        static byte AppStatus = 0;
        static byte I2C_Status = 0;
        public bool Running = true;
        static bool DeviceOpen = false;
        // GPIO
        static byte GPIO_Low_Dat = 0;
        static byte GPIO_Low_Dir = 0;
        static byte ADbusReadVal = 0;
        static byte ACbusReadVal = 0;

        static byte[] ADCData = new byte[500];
        static byte i2c_return = 0x00;
        static Int16 ADCvalue = 0;


        // ###### Baykeeper defines ######


        static uint ACKCounter = 0;


        const byte BKP_ADDRESS = 0x44;

        // COMMAND
        const byte BKP_TASK0 = 0X00;
        const byte BKP_TASK1 = 0X01;
        // PWR PATH
        const byte BKP_RG_FLAG = 0X10;
        const byte BKP_RG_DBEN = 0X11;
        const byte BKP_RG_DBDATA = 0X12;
        const byte BKP_RG_DBOCTRL = 0X13;
        const byte BKP_RG_ILIM = 0X14;
        const byte BKP_RG_EN = 0X15;
        const byte BKP_RG_TRIM0 = 0X16;
        // OSC
        const byte BKP_OSC_EN = 0X20;
        const byte BKP_OSC_TRIM = 0X21;
        // DBG
        const byte BKP_DBG_DEMUX_IN_SEL = 0X30;
        const byte BKP_DBG_MUX_OUT_SEL = 0X31;
        // TEMPERATURE SENSOR
        const byte BKP_TS_EVNT1 = 0X40;
        const byte BKP_TS_CTRL0 = 0X41;
        const byte BKP_TEMP_MSB = 0X42;
        const byte BKP_TEMP_LSB = 0X43;
        const byte BKP_TS_DBEN = 0X44;
        const byte BKP_TS_TRIM0 = 0X45;
        const byte BKP_TS_TRIM1 = 0X46;
        // BATTERY CHARGER
        const byte BKP_BC_CHGST = 0X50;
        const byte BKP_BC_NTC = 0X51;
        const byte BKP_BC_FLAG0 = 0X52;
        const byte BKP_BC_FLAG1 = 0X53;
        const byte BKP_BC_DBEN0 = 0X54;
        const byte BKP_BC_DBEN1 = 0X55;
        const byte BKP_BC_DBDATA0 = 0X56;
        const byte BKP_BC_DBDATA1 = 0X57;
        const byte BKP_BC_DBOCTRL = 0X58;
        const byte BKP_BC_TRIM0 = 0X59;
        const byte BKP_BC_TRIM1 = 0X5A;
        const byte BKP_BC_CTRL0 = 0X5B;
        const byte BKP_BC_CTRL1 = 0X5C;
        const byte BKP_BC_CTRL2 = 0X5D;
        const byte BKP_BC_CTRL3 = 0X5E;
        const byte BKP_BC_EN0 = 0X5F;
        const byte BKP_BC_EN1 = 0X60;
        const byte BKP_BC_EN2 = 0X61;
        // FUEL GAUGE
        const byte BKP_FG_M0_DATA_MSB = 0X70;
        const byte BKP_FG_M0_DATA_LSB = 0X71;
        const byte BKP_FG_M1_DATA_MSB = 0X72;
        const byte BKP_FG_M1_DATA_LSB = 0X73;
        const byte BKP_FG_TIME_CTRL = 0X74;
        const byte BKP_FG_DBEN = 0X75;
        const byte BKP_FG_CTRL0 = 0X76;
        const byte BKP_FG_EN = 0X77;
        const byte BKP_FG_TRIM_MODE0 = 0X78;
        const byte BKP_FG_TRIM_MODE1 = 0X79;
        // ULP PMU
        const byte BKP_UL_DBDATA = 0X80;
        const byte BKP_UL_DBEN = 0X81;
        const byte BKP_UL_DBCTRL = 0X82;
        const byte BKP_UL_CTRL0 = 0X83;
        const byte BKP_UL_CTRL1 = 0X84;
        const byte BKP_UL_EN = 0X85;
        const byte BKP_UL_TRIM0 = 0X86;
        const byte BKP_UL_TRIM1 = 0X87;
        const byte BKP_UL_TRIM2 = 0X88;
        const byte BKP_UL_TRIM3 = 0X89;
        // SIMO
        const byte BKP_SIMO_DBEN = 0X90;
        const byte BKP_SIMO_DBCTRL0 = 0X91;
        const byte BKP_SIMO_DBCTRL1 = 0X92;
        const byte BKP_SIMO_EN = 0X93;
        const byte BKP_SIMO_CTRL0 = 0X94;
        const byte BKP_SIMO_CTRL1 = 0X95;
        const byte BKP_SIMO_CTRL2 = 0X96;
        const byte BKP_SIMO_CTRL3 = 0X97;
        const byte BKP_SIMO_TRIM0 = 0X98;
        const byte BKP_SIMO_TRIM1 = 0X99;
        const byte BKP_SIMO_TRIM2 = 0X9A;
        const byte BKP_SIMO_TRIM3 = 0X9B;
        // LDO
        const byte BKP_L1_CTRL0 = 0XA0;
        const byte BKP_L1_EN = 0XA1;
        const byte BKP_L1_TRIM0 = 0XA2;
        const byte BKP_L2_CTRL0 = 0XA3;
        const byte BKP_L2_EN = 0XA4;
        const byte BKP_L2_TRIM0 = 0XA5;
        const byte BKP_L3_CTRL0 = 0XA6;
        const byte BKP_L3_EN = 0XA7;
        const byte BKP_L3_TRIM0 = 0XA8;
        //public const byte reg = 0x29; // add registers here
        uint devcount = 0;

        // Create new instance of the FTDI device class
        FTDI myFtdiDevice = new FTDI();




        public Form1()
        {
            InitializeComponent(); 
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                this.Text = string.Format("Chipus - Baykeeper GUI (" +
                    ApplicationDeployment.CurrentDeployment.CurrentVersion) + ")";
            }



            // Tab do debug Dubbel ADC, removed in this application
            tabControl1.TabPages.Remove(tabPage_ADS112C04);

            device_disconnected();
        }


        ///////////////////////////////////// Form Events /////////////////////////////////////////
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        //###################################################################################################################################
        // Code for the INITIALISE button...

        private void button_serialPorts_Click(object sender, EventArgs e)
        {
            bool DeviceInit = false;

            if (DeviceOpen == false)
            {
                try
                {
                    ftStatus = myFtdiDevice.GetNumberOfDevices(ref devcount);
                }
                catch
                {
                    // error message
                    MessageBox.Show("Driver not loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // e.g. open a UM232H Module by it's description
                //ftStatus = myFtdiDevice.OpenByDescription("UM232H");  // could replace line below
                ftStatus = myFtdiDevice.OpenByIndex(0);

                // Update the Status text line
                if (ftStatus == FTDI.FT_STATUS.FT_OK)
                {
                    DeviceOpen = true;
                }
                else
                {
                    DeviceOpen = false;
                    // error message
                    MessageBox.Show("No device found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                // If the device opened successfully, initialise MPSSE and then configure prox and colour sensors over I2C 
                if (DeviceOpen == true)
                {
                    DeviceInit = true;

                    AppStatus = I2C_ConfigureMpsse();
                    if (AppStatus != 0)
                    {
                        MessageBox.Show("Failed to config MPSSE.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DeviceInit = false;
                    }

                    if (DeviceInit == true)
                    {
                        device_connected();

                    }
                    else
                    {
                        MessageBox.Show("Connection attempt failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        myFtdiDevice.Close();
                        device_disconnected();
                    }

                }
                else
                {
                    // allow re-init or exit
                    //buttonInit.Enabled = true;
                    //buttonStart.Enabled = false;
                    //buttonClose.Enabled = true;


                }
            }
            else // if DeviceOpen == true
            {
                myFtdiDevice.Close();
                device_disconnected();
            }


        }

        private void linkLabel_tabAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            // Specify that the link was visited.
            this.linkLabel_tabAbout.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://www.chipus-ip.com/");
        }






        ///////////////////////////////////// Output Buttons Handle ///////////
        private void button_outputLDO1_Click(object sender, EventArgs e)
        {
            if (i2c_read(BKP_ADDRESS, BKP_L1_EN) == 0) // read current state
            {
                if (i2c_return == 0) // enable bit is set low (output off)
                {
                    if (outputOn(BKP_L1_EN) == 0) // no error
                    {
                        button_outputLDO1.Text = "OFF";
                        pictureBox_statusLDO1.Image = Properties.Resources.outputStatusOn;
                    }
                    else
                    {
                        MessageBox.Show("Oops, something wrong turning LDO1 on.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (outputOff(BKP_L1_EN) == 0) // no error
                    {
                        button_outputLDO1.Text = "ON";
                        pictureBox_statusLDO1.Image = Properties.Resources.outputStatusOff;
                    }
                    else
                    {
                        MessageBox.Show("Oops, something wrong turning LDO1 off.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else // error message
            {
                MessageBox.Show("Error accessing BKP_L1_EN register.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_outputLDO2_Click(object sender, EventArgs e)
        {
            if (i2c_read(BKP_ADDRESS, BKP_L2_EN) == 0) // read current state
            {
                if (i2c_return == 0) // enable bit is set low (output off)
                {
                    if (outputOn(BKP_L2_EN) == 0) // no error
                    {
                        button_outputLDO2.Text = "OFF";
                        pictureBox_statusLDO2.Image = Properties.Resources.outputStatusOn;
                    }
                    else
                    {
                        MessageBox.Show("Oops, something wrong turning LDO2 on.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (outputOff(BKP_L2_EN) == 0) // no error
                    {
                        button_outputLDO2.Text = "ON";
                        pictureBox_statusLDO2.Image = Properties.Resources.outputStatusOff;
                    }
                    else
                    {
                        MessageBox.Show("Oops, something wrong turning LDO2 off.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else // error message
            {
                MessageBox.Show("Error accessing BKP_L2_EN register.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_outputLDO3_Click(object sender, EventArgs e)
        {
            if (i2c_read(BKP_ADDRESS, BKP_L3_EN) == 0) // read current state
            {
                if (i2c_return == 0) // enable bit is set low (output off)
                {
                    if (outputOn(BKP_L3_EN) == 0) // no error
                    {
                        button_outputLDO3.Text = "OFF";
                        pictureBox_statusLDO3.Image = Properties.Resources.outputStatusOn;
                    }
                    else
                    {
                        MessageBox.Show("Oops, something wrong turning LDO3 on.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (outputOff(BKP_L3_EN) == 0) // no error
                    {
                        button_outputLDO3.Text = "ON";
                        pictureBox_statusLDO3.Image = Properties.Resources.outputStatusOff;
                    }
                    else
                    {
                        MessageBox.Show("Oops, something wrong turning LDO3 off.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else // error message
            {
                MessageBox.Show("Error accessing BKP_L3_EN register.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_outputVDCDC1_Click(object sender, EventArgs e)
        {
            // to be implemented
        }

        private void button_outputVDCDC2_Click(object sender, EventArgs e)
        {
            // to be implemented
        }

        private void button_outputAllOn_Click(object sender, EventArgs e)
        {
            if (outputOn(BKP_L1_EN) == 0) // no error
            {
                button_outputLDO1.Text = "OFF";
                pictureBox_statusLDO1.Image = Properties.Resources.outputStatusOn;
            }
            else
            {
                MessageBox.Show("Oops, something wrong turning LDO1 on.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (outputOn(BKP_L2_EN) == 0) // no error
            {
                button_outputLDO2.Text = "OFF";
                pictureBox_statusLDO2.Image = Properties.Resources.outputStatusOn;
            }
            else
            {
                MessageBox.Show("Oops, something wrong turning LDO2 on.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (outputOn(BKP_L3_EN) == 0) // no error
            {
                button_outputLDO3.Text = "OFF";
                pictureBox_statusLDO3.Image = Properties.Resources.outputStatusOn;
            }
            else
            {
                MessageBox.Show("Oops, something wrong turning LDO3 on.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            // others outputs to be added
        }

        private void button_outputAllOff_Click(object sender, EventArgs e)
        {
            if (outputOff(BKP_L1_EN) == 0) // no error
            {
                button_outputLDO1.Text = "ON";
                pictureBox_statusLDO1.Image = Properties.Resources.outputStatusOff;
            }
            else
            {
                MessageBox.Show("Oops, something wrong turning LDO1 off.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (outputOff(BKP_L2_EN) == 0) // no error
            {
                button_outputLDO2.Text = "ON";
                pictureBox_statusLDO2.Image = Properties.Resources.outputStatusOff;
            }
            else
            {
                MessageBox.Show("Oops, something wrong turning LDO2 off.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (outputOff(BKP_L3_EN) == 0) // no error
            {
                button_outputLDO3.Text = "ON";
                pictureBox_statusLDO3.Image = Properties.Resources.outputStatusOff;
            }
            else
            {
                MessageBox.Show("Oops, something wrong turning LDO3 off.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // others outputs to be added
        }


        private byte outputOn(byte REG)
        {
            byte ENABLE = 0x01;
            // write new register value
            if (i2c_write(BKP_ADDRESS, REG, ENABLE) != 0) return 1; // example

            // read back to check if it was writen right
            if (i2c_read(BKP_ADDRESS, REG) != 0) return 1; // example

            // check values
            if (i2c_return != ENABLE) return 1; // error

            return 0;    // no error
        }

        private byte outputOff(byte REG)
        {
            byte DISABLE = 0x00;
            // write new register value
            if (i2c_write(BKP_ADDRESS, REG, DISABLE) != 0) return 1; // example

            // read back to check if it was writen right
            if (i2c_read(BKP_ADDRESS, REG) != 0) return 1; // example

            // check values
            if (i2c_return != DISABLE) return 1; // error

            return 0;    // no error
        }




        //###################################################################################################################################
        // Write I2C (1 byte)
        // Tested and validated
        private byte i2c_write(byte ADDR, byte REG, byte DATA)
        {

            AppStatus = I2C_SetStart();                                                     // I2C START
            if (AppStatus != 0) return 1;

            AppStatus = I2C_SendDeviceAddrAndCheckACK((byte)(ADDR), false);        // I2C ADDRESS (for write)
            if (AppStatus != 0) return 1;
            if (I2C_Ack != true) { I2C_SetStop(); return 1; }                                 // if sensor NAKs then send stop and return

            AppStatus = I2C_SendByteAndCheckACK((byte)(REG));                              // SEND REGISTER ID
            if (AppStatus != 0) return 1;
            if (I2C_Ack != true) { I2C_SetStop(); return 1; }                                 // if sensor NAKs then send stop and return

            AppStatus = I2C_SendByteAndCheckACK((byte)(DATA));                              // SEND REGISTER DATA
            if (AppStatus != 0) return 1;
            if (I2C_Ack != true) { I2C_SetStop(); return 1; }                                 // if sensor NAKs then send stop and return


            AppStatus = I2C_SetStop();                                                      // I2C STOP
            if (AppStatus != 0) return 1;

            return 0;
        }


        //###################################################################################################################################
        // Read I2C (1 byte) and refresh i2c_return static byte
        // Not tested yet
        private byte i2c_read(byte ADDR, byte REG)
        {

            AppStatus = I2C_SetStart();                                                     // I2C START
            if (AppStatus != 0) return 1;

            AppStatus = I2C_SendDeviceAddrAndCheckACK((byte)(ADDR), false);        // I2C ADDRESS (for write)
            if (AppStatus != 0) return 1;
            if (I2C_Ack != true) { I2C_SetStop(); return 1; }                                 // if sensor NAKs then send stop and return

            AppStatus = I2C_SendByteAndCheckACK((byte)(REG));                              // SEND REGISTER ID
            if (AppStatus != 0) return 1;
            if (I2C_Ack != true) { I2C_SetStop(); return 1; }                                 // if sensor NAKs then send stop and return

            AppStatus = I2C_SetStart();                                                     // REPEAT START
            if (AppStatus != 0) return 1;

            AppStatus = I2C_SendDeviceAddrAndCheckACK((byte)(ADDR), true);                      // I2C ADDRESS (for read)
            if (AppStatus != 0) return 1;
            if (I2C_Ack != true) { I2C_SetStop(); return 1; }                                 // if sensor NAKs then send stop and return

            AppStatus = I2C_ReadByte(false);                                                 // I2C READ (send Ack)
            if (AppStatus != 0) return 1;

            i2c_return = InputBuffer2[0];                                              // Get the byte read

            AppStatus = I2C_SetStop();                                                      // I2C STOP
            if (AppStatus != 0) return 1;


            return 0;
        }


        //###################################################################################################################################
        // Reads ADC and update screen
        // Must be deleted to use with Baykeeper
        private void timer1_Tick(object sender, EventArgs e)
        {
            i2c_read_ADS112C04(0x40, 0x10);
            textBox6.Text = Convert.ToString(ADCData[0], 2).PadLeft(8, '0');
            textBox5.Text = Convert.ToString(ADCData[1], 2).PadLeft(8, '0');


            int gain = 1;
            try
            {
                gain = Convert.ToUInt16(textBox7.Text);
            }
            catch
            { }


            double vref = 2.048;
            try
            {
                vref = Convert.ToDouble(textBox8.Text);
            }
            catch
            { }
            double voltage = ((2 * vref / gain) / Math.Pow(2, 16)) * ADCvalue;


            label_voltage.Text = (1000 * voltage).ToString() + " mV";


            i2c_write(0x40, 0x08, 0x00);
        }


        //###################################################################################################################################
        // Write ADS122C04 config register and start conversion
        // Tested and validated
        private void button_writeADS_Click(object sender, EventArgs e)
        {
            byte data0x40 = Convert.ToByte(textBox_ADS0x40.Text, 16);
            byte data0x44 = Convert.ToByte(textBox_ADS0x44.Text, 16);
            byte data0x48 = Convert.ToByte(textBox_ADS0x48.Text, 16);
            byte data0x4c = Convert.ToByte(textBox_ADS0x4c.Text, 16);

            i2c_write(0x40, 0x40, data0x40);
            i2c_write(0x40, 0x44, data0x44);
            i2c_write(0x40, 0x48, data0x48);
            i2c_write(0x40, 0x4c, data0x4c);


            i2c_write(0x40, 0x08, data0x4c); // dummy data
        }


        //###################################################################################################################################
        // Read back ADS122C04 config register to check if it was well writen
        // Tested and validated
        private void button_readADS_Click(object sender, EventArgs e)
        {
            byte data0x40 = i2c_read(0x40, 0x20);
            byte data0x44 = i2c_read(0x40, 0x24);
            byte data0x48 = i2c_read(0x40, 0x28);
            byte data0x4c = i2c_read(0x40, 0x2c);



            textBox4.Text = data0x40.ToString("X").PadLeft(2, '0');
            textBox3.Text = data0x44.ToString("X").PadLeft(2, '0');
            textBox2.Text = data0x48.ToString("X").PadLeft(2, '0');
            textBox1.Text = data0x4c.ToString("X").PadLeft(2, '0');
        }


        //###################################################################################################################################
        // Enable 1.5 second timer to constantly reading ADS122C04
        // Could be deleted to use only with baykeeper
        private void button_readData_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }


        //###################################################################################################################################
        // This funcion reads 2 following data from REG and REG+1 an write on a global variable called ADCvalue
        // Used to test ADS112C04 and verified
        private byte i2c_read_ADS112C04(byte ADDR, byte REG)
        {

            AppStatus = I2C_SetStart();                                                     // I2C START
            if (AppStatus != 0) return 1;

            AppStatus = I2C_SendDeviceAddrAndCheckACK((byte)(ADDR), false);        // I2C ADDRESS (for write)
            if (AppStatus != 0) return 1;
            if (I2C_Ack != true) { I2C_SetStop(); return 1; }                                 // if sensor NAKs then send stop and return

            AppStatus = I2C_SendByteAndCheckACK((byte)(REG));                              // SEND REGISTER ID
            if (AppStatus != 0) return 1;
            if (I2C_Ack != true) { I2C_SetStop(); return 1; }                                 // if sensor NAKs then send stop and return

            AppStatus = I2C_SetStart();                                                     // REPEAT START
            if (AppStatus != 0) return 1;

            AppStatus = I2C_SendDeviceAddrAndCheckACK((byte)(ADDR), true);                      // I2C ADDRESS (for read)
            if (AppStatus != 0) return 1;
            if (I2C_Ack != true) { I2C_SetStop(); return 1; }                                 // if sensor NAKs then send stop and return

            AppStatus = I2C_ReadByte(true);                                                 // I2C READ (send Ack)
            if (AppStatus != 0) return 1;

            ADCData[0] = InputBuffer2[0];                                              // Get the byte read

            AppStatus = I2C_ReadByte(false);                                                 // I2C READ (send Ack)
            if (AppStatus != 0) return 1;

            ADCData[1] = InputBuffer2[0];                                              // Get the byte read

            AppStatus = I2C_SetStop();                                                      // I2C STOP
            if (AppStatus != 0) return 1;

            ADCvalue = (Int16)((ADCData[0] << 8) | ADCData[1]);

            return 0;

        }


        //###################################################################################################################################
        // A 1 second timer is enabled after connected to detect if the connection is still avaiable
        // An unused GPIO is set to high value in order to check if FTDI is answering
        private void timer_disconnect_Tick(object sender, EventArgs e)
        {
            AppStatus = I2C_SetGPIOValuesHigh(0x40, 0x40);  // set direction of AC6 as output, value is 1 (high) for LED off

            //If write to MPSSE failed (e.g. device unplugged) then stop running
            if (AppStatus != 0)
            {
                myFtdiDevice.Close();
                device_disconnected();
                DeviceOpen = false;
                MessageBox.Show("Device connection lost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //###################################################################################################################################
        // Configure itens in all tabs when device is disconnected
        private void device_disconnected()
        {
            // Close the FTDI device and then close the window
            timer1.Enabled = false;
            timer_disconnect.Enabled = false;


            DeviceOpen = false;

            ///////////////////////////////////////////////////////////////////
            /// TAB "Configuration"
            ///////////////////////////////////////////////////////////////////
            button_serialPorts.Text = "Connect";
            label_serialPortStatus.Text = "Disconnected";
            label_serialPortStatus.ForeColor = Color.Red;

            ///////////////////////////////////////////////////////////////////
            /// TAB "Outputs"
            ///////////////////////////////////////////////////////////////////
            button_outputLDO1.Enabled = false;
            button_outputLDO2.Enabled = false;
            button_outputLDO3.Enabled = false;
            button_outputVDCDC1.Enabled = false;
            button_outputVDCDC2.Enabled = false;
            button_outputAllOn.Enabled = false;
            button_outputAllOff.Enabled = false;
            pictureBox_statusLDO1.Image = Properties.Resources.outputStatusOff;
            pictureBox_statusLDO2.Image = Properties.Resources.outputStatusOff;
            pictureBox_statusLDO3.Image = Properties.Resources.outputStatusOff;
            pictureBox_statusVDCDC1.Image = Properties.Resources.outputStatusOff;
            pictureBox_statusVDCDC2.Image = Properties.Resources.outputStatusOff;



            ///////////////////////////////////////////////////////////////////
            /// TAB "Battery Charger"
            ///////////////////////////////////////////////////////////////////
            progressBar1.Value = 0;
            label_battery.Text = "0%";


            ///////////////////////////////////////////////////////////////////
            /// TAB "About"
            ///////////////////////////////////////////////////////////////////
            // do nothing


            ///////////////////////////////////////////////////////////////////
            /// TAB "ADS112C04"
            ///////////////////////////////////////////////////////////////////
            textBox_ADS0x40.Text = "00";
            textBox_ADS0x40.Enabled = false;
            textBox_ADS0x44.Text = "00";
            textBox_ADS0x44.Enabled = false;
            textBox_ADS0x48.Text = "00";
            textBox_ADS0x48.Enabled = false;
            textBox_ADS0x4c.Text = "00";
            textBox_ADS0x4c.Enabled = false;

            button_writeADS.Enabled = false;


            textBox4.Text = "00";
            textBox3.Text = "00";
            textBox2.Text = "00";
            textBox1.Text = "00";

            button_readADS.Enabled = false;

            button_readData.Enabled = false;

            textBox5.Text = "XXXXXXXX";
            textBox6.Text = "XXXXXXXX";
            textBox7.Text = "128";
            textBox8.Text = "2,048";
            label_voltage.Text = "X,XX mV";






        }

        //###################################################################################################################################
        // Write button on I2C tab
        private void button1_Click(object sender, EventArgs e)
        {
            textBox_i2c_Readback.Text = "";

            byte i2c_addr = 0x00;
            byte i2c_reg = 0x00;
            byte i2c_data = 0x00;

            try
            {
                i2c_addr = Convert.ToByte(textBox_i2c_SlaveAddr.Text, 16);
            }
            catch
            {
                // error message
                MessageBox.Show("Please insert a valid slave address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_i2c_SlaveAddr.Text = "00";
                return;
            }

            try
            {
                i2c_reg = Convert.ToByte(textBox_i2c_WriteReg.Text, 16);
            }
            catch
            {
                // error message
                MessageBox.Show("Please insert a valid register address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_i2c_WriteReg.Text = "00";
                return;
            }

            try
            {
                i2c_data = Convert.ToByte(textBox_i2c_WriteData.Text, 2);
            }
            catch
            {
                // error message
                MessageBox.Show("Please insert a valid data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_i2c_WriteData.Text = "00000000";
                return;
            }




            byte ack = i2c_write(i2c_addr, i2c_reg, i2c_data);


            if (ack == 0)
            {
                label_i2c_WriteACK.Text = "ACK";
                label_i2c_WriteACK.ForeColor = Color.Green;

                if (checkBox_readback.Checked)
                {

                    byte readback = i2c_read(i2c_addr, i2c_reg);
                    if (readback == 0)
                    {
                        label_i2c_ReadbackACK.Text = "ACK";
                        label_i2c_ReadbackACK.ForeColor = Color.Green;
                        textBox_i2c_Readback.Text = Convert.ToString(i2c_return, 2).PadLeft(8, '0');
                    }
                    else
                    {
                        /***** Flush the buffer *****/
                        I2C_Status = FlushBuffer();

                        textBox_i2c_Readback.Text = "";
                        label_i2c_ReadbackACK.Text = "Not ACK";
                        label_i2c_ReadbackACK.ForeColor = Color.Red;
                    }
                }


            }
            else
            {
                /***** Flush the buffer *****/
                I2C_Status = FlushBuffer();

                label_i2c_WriteACK.Text = "Not ACK";
                label_i2c_WriteACK.ForeColor = Color.Red;

                label_i2c_ReadbackACK.Text = "---";
                label_i2c_ReadbackACK.ForeColor = Color.Black;
                textBox_i2c_Readback.Text = "";
            }







        }

        //###################################################################################################################################
        // Read button on I2C tab
        private void button2_Click(object sender, EventArgs e)
        {
            byte i2c_addr = Convert.ToByte(textBox_i2c_SlaveAddr.Text, 16);
            byte i2c_reg = Convert.ToByte(textBox_i2c_ReadReg.Text, 16);


            //while(true)
            //{
            byte ack = i2c_read(i2c_addr, i2c_reg);
            if (ack == 0)
            {
                label_i2c_ReadACK.Text = "ACK";
                label_i2c_ReadACK.ForeColor = Color.Green;
                textBox_i2c_ReadData.Text = Convert.ToString(i2c_return, 2).PadLeft(8, '0');
                ACKCounter++;
                label_ACKCounter.Text = "ACK Counter: " + ACKCounter.ToString();
            }
            else
            {
                /***** Flush the buffer *****/
                I2C_Status = FlushBuffer();

                label_i2c_ReadACK.Text = "Not ACK";
                label_i2c_ReadACK.ForeColor = Color.Red;
                textBox_i2c_ReadData.Text = "";
                ACKCounter = 0;
                //break;
            }
            if (ACKCounter >= 500)
            {
                ACKCounter = 0;
                //break;
            }
            //}

        }
        
        
        //###################################################################################################################################
        // 10 ms timer for FG task
        private void button_FG_task_Click(object sender, EventArgs e)
        {
            byte i2c_addr = Convert.ToByte(textBox_FGtask_addr.Text, 16);
            byte i2c_reg = Convert.ToByte(textBox_FGtask_reg.Text, 16);
            byte i2c_data = Convert.ToByte(textBox_FGtask_data.Text, 16);

            byte ack = i2c_write(i2c_addr, i2c_reg, i2c_data);
            if (ack == 0)
            {
                label20.Text = "ACK";
                label20.ForeColor = Color.Green;
                timer_FG.Enabled = true;
            }
            else
            {
                label20.Text = "Not ACK";
                label20.ForeColor = Color.Red;
            }


        }

        //###################################################################################################################################
        // Button to run FG task
        private void timer_FG_Tick(object sender, EventArgs e)
        {
            timer_FG.Enabled = false;

            byte i2c_addr = Convert.ToByte(textBox_FGtask_addr.Text, 16);
            byte i2c_reg = Convert.ToByte(textBox_mode0MSB_reg.Text, 16);
            byte ack = i2c_read(i2c_addr, i2c_reg);
            if (ack == 0)
            {
                label_mode0MSB_ack.Text = "ACK";
                label_mode0MSB_ack.ForeColor = Color.Green;
                textBox_mode0MSB_data.Text = i2c_return.ToString("X").PadLeft(2, '0');
            }
            else
            {
                label_mode0MSB_ack.Text = "Not ACK";
                label_mode0MSB_ack.ForeColor = Color.Red;
                textBox_mode0MSB_data.Text = "";
            }

            i2c_addr = Convert.ToByte(textBox_FGtask_addr.Text, 16);
            i2c_reg = Convert.ToByte(textBox_mode0LSB_reg.Text, 16);
            ack = i2c_read(i2c_addr, i2c_reg);
            if (ack == 0)
            {
                label_mode0LSB_ack.Text = "ACK";
                label_mode0LSB_ack.ForeColor = Color.Green;
                textBox_mode0LSB_data.Text = i2c_return.ToString("X").PadLeft(2, '0');
            }
            else
            {
                label_mode0LSB_ack.Text = "Not ACK";
                label_mode0LSB_ack.ForeColor = Color.Red;
                textBox_mode0LSB_data.Text = "";
            }

            i2c_addr = Convert.ToByte(textBox_FGtask_addr.Text, 16);
            i2c_reg = Convert.ToByte(textBox_mode1MSB_reg.Text, 16);
            ack = i2c_read(i2c_addr, i2c_reg);
            if (ack == 0)
            {
                label_mode1MSB_ack.Text = "ACK";
                label_mode1MSB_ack.ForeColor = Color.Green;
                textBox_mode1MSB_data.Text = i2c_return.ToString("X").PadLeft(2, '0');
            }
            else
            {
                label_mode1MSB_ack.Text = "Not ACK";
                label_mode1MSB_ack.ForeColor = Color.Red;
                textBox_mode1MSB_data.Text = "";
            }

            i2c_addr = Convert.ToByte(textBox_FGtask_addr.Text, 16);
            i2c_reg = Convert.ToByte(textBox_mode1LSB_reg.Text, 16);
            ack = i2c_read(i2c_addr, i2c_reg);
            if (ack == 0)
            {
                label_mode1LSB_ack.Text = "ACK";
                label_mode1LSB_ack.ForeColor = Color.Green;
                textBox_mode1LSB_data.Text = i2c_return.ToString("X").PadLeft(2, '0');
            }
            else
            {
                label_mode1LSB_ack.Text = "Not ACK";
                label_mode1LSB_ack.ForeColor = Color.Red;
                textBox_mode1LSB_data.Text = "";
            }


            i2c_write(i2c_addr, 0x01, 0x00);
        }

        //###################################################################################################################################
        // Run Write button on I2C tab if press enter
        private void textBox_i2c_WriteData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();

            }
        }

        //###################################################################################################################################
        // Checkbox state
        private void checkBox_readback_CheckedChanged(object sender, EventArgs e)
        {
            textBox_i2c_Readback.Text = "";
            label_i2c_ReadbackACK.Text = "---";
            label_i2c_ReadbackACK.ForeColor = Color.Black;
        }

        //###################################################################################################################################
        // Run Read button on I2C tab if press enter
        private void textBox_i2c_ReadReg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2.PerformClick();
            }
        }

        //###################################################################################################################################
        // Run Write button on I2C tab if press enter
        private void textBox_i2c_WriteReg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }




        //###################################################################################################################################
        // Configure itens in all tabs when device is connected
        private byte device_connected()
        {
            if (baykeeperInit() != 0)
            {
                MessageBox.Show("Oops, Baykeeper could not be initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myFtdiDevice.Close();
                DeviceOpen = false;
                device_disconnected();
                return 1;
            }
            timer_disconnect.Enabled = true;

            ///////////////////////////////////////////////////////////////////
            /// TAB "Configuration"
            ///////////////////////////////////////////////////////////////////
            button_serialPorts.Text = "Disconnect";
            label_serialPortStatus.Text = "Connected";
            label_serialPortStatus.ForeColor = Color.Lime;

            ///////////////////////////////////////////////////////////////////
            /// TAB "Outputs"
            ///////////////////////////////////////////////////////////////////
            button_outputLDO1.Enabled = true;
            button_outputLDO2.Enabled = true;
            button_outputLDO3.Enabled = true;
            button_outputVDCDC1.Enabled = true;
            button_outputVDCDC2.Enabled = true;
            button_outputAllOn.Enabled = true;
            button_outputAllOff.Enabled = true;
            pictureBox_statusLDO1.Image = Properties.Resources.outputStatusOff;
            pictureBox_statusLDO2.Image = Properties.Resources.outputStatusOff;
            pictureBox_statusLDO3.Image = Properties.Resources.outputStatusOff;
            pictureBox_statusVDCDC1.Image = Properties.Resources.outputStatusOff;
            pictureBox_statusVDCDC2.Image = Properties.Resources.outputStatusOff;



            ///////////////////////////////////////////////////////////////////
            /// TAB "Battery Charger"
            ///////////////////////////////////////////////////////////////////
            progressBar1.Value = 50;
            label_battery.Text = "50%";


            ///////////////////////////////////////////////////////////////////
            /// TAB "About"
            ///////////////////////////////////////////////////////////////////
            // do nothing


            ///////////////////////////////////////////////////////////////////
            /// TAB "ADS112C04"
            ///////////////////////////////////////////////////////////////////
            textBox_ADS0x40.Text = "00";
            textBox_ADS0x40.Enabled = true;
            textBox_ADS0x44.Text = "00";
            textBox_ADS0x44.Enabled = true;
            textBox_ADS0x48.Text = "00";
            textBox_ADS0x48.Enabled = true;
            textBox_ADS0x4c.Text = "00";
            textBox_ADS0x4c.Enabled = true;

            button_writeADS.Enabled = true;


            textBox4.Text = "00";
            textBox3.Text = "00";
            textBox2.Text = "00";
            textBox1.Text = "00";

            button_readADS.Enabled = true;

            button_readData.Enabled = true;

            textBox5.Text = "XXXXXXXX";
            textBox6.Text = "XXXXXXXX";
            textBox7.Text = "128";
            textBox8.Text = "2,048";
            label_voltage.Text = "X,XX mV";

            return 0;
        }

        private byte baykeeperInit()
        {
            return 0;
            // Due to wrong implementation, the following register must be trimmed before use
            // Start

            if (i2c_write(BKP_ADDRESS, BKP_FG_CTRL0, 0b01010000) != 0) return 1;
            // End



            if (i2c_write(BKP_ADDRESS, BKP_L1_EN, 0x00) != 0) return 1;
            if (i2c_write(BKP_ADDRESS, BKP_L2_EN, 0x00) != 0) return 1;
            if (i2c_write(BKP_ADDRESS, BKP_L3_EN, 0x00) != 0) return 1;

            return 0;
        }

















        //###################################################################################################################################
        //###################################################################################################################################
        //##################                             I2C Layer                                                      #####################
        //###################################################################################################################################
        //###################################################################################################################################


        public byte I2C_ConfigureMpsse()
        {

            byte ADbusVal = 0;
            byte ADbusDir = 0;
            NumBytesToSend = 0;

            /***** Initial device configuration *****/

            ftStatus = FTDI.FT_STATUS.FT_OK;
            ftStatus |= myFtdiDevice.SetTimeouts(5000, 5000);
            ftStatus |= myFtdiDevice.SetLatency(16);
            ftStatus |= myFtdiDevice.SetFlowControl(FTDI.FT_FLOW_CONTROL.FT_FLOW_RTS_CTS, 0x00, 0x00);
            ftStatus |= myFtdiDevice.SetBitMode(0x00, 0x00);
            ftStatus |= myFtdiDevice.SetBitMode(0x00, 0x02);         // MPSSE mode        

            if (ftStatus != FTDI.FT_STATUS.FT_OK)
                return 1; // error();

            /***** Flush the buffer *****/
            I2C_Status = FlushBuffer();

            /***** Synchronize the MPSSE interface by sending bad command 0xAA *****/
            NumBytesToSend = 0;
            MPSSEbuffer[NumBytesToSend++] = 0xAA;
            I2C_Status = Send_Data(NumBytesToSend);
            if (I2C_Status != 0) return 1; // error();
            NumBytesToRead = 2;
            I2C_Status = Receive_Data(2);
            if (I2C_Status != 0) return 1; //error();

            if ((InputBuffer2[0] == 0xFA) && (InputBuffer2[1] == 0xAA))
            {
                //Console.WriteLine("Bad Command Echo successful");
            }
            else
            {
                return 1;            //error();
            }

            /***** Synchronize the MPSSE interface by sending bad command 0xAB *****/
            NumBytesToSend = 0;
            MPSSEbuffer[NumBytesToSend++] = 0xAB;
            I2C_Status = Send_Data(NumBytesToSend);
            if (I2C_Status != 0) return 1; // error();
            NumBytesToRead = 2;
            I2C_Status = Receive_Data(2);
            if (I2C_Status != 0) return 1; //error();

            if ((InputBuffer2[0] == 0xFA) && (InputBuffer2[1] == 0xAB))
            {
                //Console.WriteLine("Bad Command Echo successful");
            }
            else
            {
                return 1;            //error();
            }

            NumBytesToSend = 0;
            MPSSEbuffer[NumBytesToSend++] = 0x8A; 	// Disable clock divide by 5 for 60Mhz master clock
            MPSSEbuffer[NumBytesToSend++] = 0x97;	// Turn off adaptive clocking
            MPSSEbuffer[NumBytesToSend++] = 0x8C; 	// Enable 3 phase data clock, used by I2C to allow data on both clock edges
            // The SK clock frequency can be worked out by below algorithm with divide by 5 set as off
            // SK frequency  = 60MHz /((1 +  [(1 +0xValueH*256) OR 0xValueL])*2)
            MPSSEbuffer[NumBytesToSend++] = 0x86; 	//Command to set clock divisor
            MPSSEbuffer[NumBytesToSend++] = (byte)(ClockDivisor & 0x00FF);	//Set 0xValueL of clock divisor
            MPSSEbuffer[NumBytesToSend++] = (byte)((ClockDivisor >> 8) & 0x00FF);	//Set 0xValueH of clock divisor
            MPSSEbuffer[NumBytesToSend++] = 0x85; 			// loopback off

#if (FT232H)
            MPSSEbuffer[NumBytesToSend++] = 0x9E;       //Enable the FT232H's drive-zero mode with the following enable mask...
            MPSSEbuffer[NumBytesToSend++] = 0x07;       // ... Low byte (ADx) enables - bits 0, 1 and 2 and ... 
            MPSSEbuffer[NumBytesToSend++] = 0x00;       //...High byte (ACx) enables - all off

            ADbusVal = (byte)(0x00 | I2C_Data_SDAhi_SCLhi | (GPIO_Low_Dat & 0xF8)); // SDA and SCL both output high (open drain)
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAout_SCLout | (GPIO_Low_Dir & 0xF8));
#else
            ADbusVal = (byte)(0x00 | I2C_Data_SDAlo_SCLlo | (GPIO_Low_Dat & 0xF8));  	// SDA and SCL set low but as input to mimic open drain
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAin_SCLin | (GPIO_Low_Dir & 0xF8));	//

#endif


            MPSSEbuffer[NumBytesToSend++] = 0x80; 	//Command to set directions of lower 8 pins and force value on bits set as output 
            MPSSEbuffer[NumBytesToSend++] = (byte)(ADbusVal);
            MPSSEbuffer[NumBytesToSend++] = (byte)(ADbusDir);


            I2C_Status = Send_Data(NumBytesToSend);
            if (I2C_Status != 0)
            {
                return 1;            //error();
            }
            else
            {
                return 0;
            }
        }

        //###################################################################################################################################
        // Reads a byte over I2C 

        public byte I2C_ReadByte(bool ACK)
        {
            byte ADbusVal = 0;
            byte ADbusDir = 0;
            NumBytesToSend = 0;

#if (FT232H)
            // Clock in one data byte
            MPSSEbuffer[NumBytesToSend++] = MSB_RISING_EDGE_CLOCK_BYTE_IN;      // Clock data byte in
            MPSSEbuffer[NumBytesToSend++] = 0x00;
            MPSSEbuffer[NumBytesToSend++] = 0x00;                               // Data length of 0x0000 means 1 byte data to clock in

            // clock out one bit as ack/nak bit
            MPSSEbuffer[NumBytesToSend++] = MSB_FALLING_EDGE_CLOCK_BIT_OUT;     // Clock data bit out
            MPSSEbuffer[NumBytesToSend++] = 0x00;                               // Length of 0 means 1 bit
            if (ACK == true)
                MPSSEbuffer[NumBytesToSend++] = 0x00;                           // Data bit to send is a '0'
            else
                MPSSEbuffer[NumBytesToSend++] = 0xFF;                           // Data bit to send is a '1'

            // I2C lines back to idle state 
            ADbusVal = (byte)(0x00 | I2C_Data_SDAhi_SCLlo | (GPIO_Low_Dat & 0xF8));
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAout_SCLout | (GPIO_Low_Dir & 0xF8));
            MPSSEbuffer[NumBytesToSend++] = 0x80;                               //       ' Command - set low byte
            MPSSEbuffer[NumBytesToSend++] = ADbusVal;                            //      ' Set the values
            MPSSEbuffer[NumBytesToSend++] = ADbusDir;                             //     ' Set the directions
#else          
            // Ensure line is definitely an input since FT2232H and FT4232H don't have open drain
            ADbusVal = (byte)(0x00 | I2C_Data_SDAlo_SCLlo | (GPIO_Low_Dat & 0xF8));
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAin_SCLout | (GPIO_Low_Dir & 0xF8)); // make data input
            MPSSEbuffer[NumBytesToSend++] = 0x80;                                   // command - set low byte
            MPSSEbuffer[NumBytesToSend++] = ADbusVal;                               // Set the values
            MPSSEbuffer[NumBytesToSend++] = ADbusDir;                               // Set the directions
            // Clock one byte of data in from the sensor
            MPSSEbuffer[NumBytesToSend++] = MSB_RISING_EDGE_CLOCK_BYTE_IN;      // Clock data byte in
            MPSSEbuffer[NumBytesToSend++] = 0x00;
            MPSSEbuffer[NumBytesToSend++] = 0x00;                               // Data length of 0x0000 means 1 byte data to clock in
            
            // Change direction back to output and clock out one bit. If ACK is true, we send bit as 0 as an acknowledge
            ADbusVal = (byte)(0x00 | I2C_Data_SDAlo_SCLlo | (GPIO_Low_Dat & 0xF8));
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAout_SCLout | (GPIO_Low_Dir & 0xF8));    // back to output
            MPSSEbuffer[NumBytesToSend++] = 0x80;                               // Command - set low byte
            MPSSEbuffer[NumBytesToSend++] = ADbusVal;                           // set the values
            MPSSEbuffer[NumBytesToSend++] = ADbusDir;                           // set the directions

            MPSSEbuffer[NumBytesToSend++] = MSB_FALLING_EDGE_CLOCK_BIT_OUT;    // Clock data bit out
            MPSSEbuffer[NumBytesToSend++] = 0x00;                              // Length of 0 means 1 bit
            if (ACK == true)
            {
                MPSSEbuffer[NumBytesToSend++] = 0x00;                          // Data bit to send is a '0'
            }
            else
            {
                MPSSEbuffer[NumBytesToSend++] = 0xFF;                          // Data bit to send is a '1'
            }

            // Put line states back to idle with SDA open drain high (set to input) 
            ADbusVal = (byte)(0x00 | I2C_Data_SDAlo_SCLlo | (GPIO_Low_Dat & 0xF8));
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAin_SCLout | (GPIO_Low_Dir & 0xF8));//make data input
            MPSSEbuffer[NumBytesToSend++] = 0x80;                               //       ' Command - set low byte
            MPSSEbuffer[NumBytesToSend++] = ADbusVal;                            //      ' Set the values
            MPSSEbuffer[NumBytesToSend++] = ADbusDir;                             //     ' Set the directions

            
#endif
            // This command then tells the MPSSE to send any results gathered back immediately
            MPSSEbuffer[NumBytesToSend++] = 0x87;                                  //    ' Send answer back immediate command

            // send commands to chip
            I2C_Status = Send_Data(NumBytesToSend);
            if (I2C_Status != 0)
            {
                return 1;
            }

            // get the byte which has been read from the driver's receive buffer
            I2C_Status = Receive_Data(1);
            if (I2C_Status != 0)
            {
                return 1;
            }

            // InputBuffer2[0] now contains the results

            return 0;
        }


        //###################################################################################################################################
        // Sends I2C address followed by reading 2 bytes

        public byte I2C_Read2BytesWithAddr(byte Address)
        {
            byte ADbusVal = 0;
            byte ADbusDir = 0;
            NumBytesToSend = 0;

            // ------------------------------------ Address ------------------------------------

            Address <<= 1;
            Address |= 0x01;

#if (FT232H)
            MPSSEbuffer[NumBytesToSend++] = MSB_FALLING_EDGE_CLOCK_BYTE_OUT;        // clock data byte out
            MPSSEbuffer[NumBytesToSend++] = 0x00;                                   // 
            MPSSEbuffer[NumBytesToSend++] = 0x00;                                   //  Data length of 0x0000 means 1 byte data to clock in
            MPSSEbuffer[NumBytesToSend++] = Address;// DataSend[0];          //  Byte to send

            // Put line back to idle (data released, clock pulled low)
            ADbusVal = (byte)(0x00 | I2C_Data_SDAhi_SCLlo | (GPIO_Low_Dat & 0xF8));
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAout_SCLout | (GPIO_Low_Dir & 0xF8));// make data input
            MPSSEbuffer[NumBytesToSend++] = 0x80;                                   // Command - set low byte
            MPSSEbuffer[NumBytesToSend++] = ADbusVal;                               // Set the values
            MPSSEbuffer[NumBytesToSend++] = ADbusDir;                               // Set the directions

            // CLOCK IN ACK
            MPSSEbuffer[NumBytesToSend++] = MSB_RISING_EDGE_CLOCK_BIT_IN;           // clock data bits in
            MPSSEbuffer[NumBytesToSend++] = 0x00;                                   // Length of 0 means 1 bit
#else

            // Set directions of clock and data to output in preparation for clocking out a byte
            ADbusVal = (byte)(0x00 | I2C_Data_SDAlo_SCLlo | (GPIO_Low_Dat & 0xF8));
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAout_SCLout | (GPIO_Low_Dir & 0xF8));// back to output
            MPSSEbuffer[NumBytesToSend++] = 0x80;                                   // Command - set low byte
            MPSSEbuffer[NumBytesToSend++] = ADbusVal;                               // Set the values
            MPSSEbuffer[NumBytesToSend++] = ADbusDir;                               // Set the directions
            // clock out one byte
            MPSSEbuffer[NumBytesToSend++] = MSB_FALLING_EDGE_CLOCK_BYTE_OUT;        // clock data byte out
            MPSSEbuffer[NumBytesToSend++] = 0x00;                                   // 
            MPSSEbuffer[NumBytesToSend++] = 0x00;                                   // Data length of 0x0000 means 1 byte data to clock in
            MPSSEbuffer[NumBytesToSend++] = Address;                         // Byte to send

            // Put line back to idle (data released, clock pulled low) so that sensor can drive data line
            ADbusVal = (byte)(0x00 | I2C_Data_SDAlo_SCLlo | (GPIO_Low_Dat & 0xF8));
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAin_SCLout | (GPIO_Low_Dir & 0xF8)); // make data input
            MPSSEbuffer[NumBytesToSend++] = 0x80;                                   // Command - set low byte
            MPSSEbuffer[NumBytesToSend++] = ADbusVal;                               // Set the values
            MPSSEbuffer[NumBytesToSend++] = ADbusDir;                               // Set the directions

            // CLOCK IN ACK
            MPSSEbuffer[NumBytesToSend++] = MSB_RISING_EDGE_CLOCK_BIT_IN;           // clock data byte in
            MPSSEbuffer[NumBytesToSend++] = 0x00;                                   // Length of 0 means 1 bit

#endif

            // ------------------------------------ Clock in 1st byte and ACK ------------------------------------

#if (FT232H)
            MPSSEbuffer[NumBytesToSend++] = MSB_RISING_EDGE_CLOCK_BYTE_IN;      // Clock data byte in
            MPSSEbuffer[NumBytesToSend++] = 0x00;
            MPSSEbuffer[NumBytesToSend++] = 0x00;                               // Data length of 0x0000 means 1 byte data to clock in

            MPSSEbuffer[NumBytesToSend++] = MSB_FALLING_EDGE_CLOCK_BIT_OUT;    // Clock data bit out
            MPSSEbuffer[NumBytesToSend++] = 0x00;                              // Length of 0 means 1 bit
            MPSSEbuffer[NumBytesToSend++] = 0x00;                              // Sending 0 here as ACK

            ADbusVal = (byte)(0x00 | I2C_Data_SDAhi_SCLlo | (GPIO_Low_Dat & 0xF8));
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAout_SCLout | (GPIO_Low_Dir & 0xF8));

            MPSSEbuffer[NumBytesToSend++] = 0x80;                               //       ' Command - set low byte
            MPSSEbuffer[NumBytesToSend++] = ADbusVal;                            //      ' Set the values
            MPSSEbuffer[NumBytesToSend++] = ADbusDir;                             //     ' Set the directions
#else          

            MPSSEbuffer[NumBytesToSend++] = MSB_RISING_EDGE_CLOCK_BYTE_IN;      // Clock data byte in
            MPSSEbuffer[NumBytesToSend++] = 0x00;
            MPSSEbuffer[NumBytesToSend++] = 0x00;                               // Data length of 0x0000 means 1 byte data to clock in
            
            // Send a 0 bit as an acknowledge
            ADbusVal = (byte)(0x00 | I2C_Data_SDAlo_SCLlo | (GPIO_Low_Dat & 0xF8));
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAout_SCLout | (GPIO_Low_Dir & 0xF8));//back to output
            MPSSEbuffer[NumBytesToSend++] = 0x80;                               //       ' Command - set low byte
            MPSSEbuffer[NumBytesToSend++] = ADbusVal;                            //      ' Set the values
            MPSSEbuffer[NumBytesToSend++] = ADbusDir;                             //     ' Set the directions

            MPSSEbuffer[NumBytesToSend++] = MSB_FALLING_EDGE_CLOCK_BIT_OUT;    // Clock data bit out
            MPSSEbuffer[NumBytesToSend++] = 0x00;                              // Length of 0 means 1 bit
            MPSSEbuffer[NumBytesToSend++] = 0x00;                              // Sending 0 here as ACK
            
            ADbusVal = (byte)(0x00 | I2C_Data_SDAlo_SCLlo | (GPIO_Low_Dat & 0xF8));
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAin_SCLout | (GPIO_Low_Dir & 0xF8));//make data input
            
            MPSSEbuffer[NumBytesToSend++] = 0x80;                               //       ' Command - set low byte
            MPSSEbuffer[NumBytesToSend++] = ADbusVal;                            //      ' Set the values
            MPSSEbuffer[NumBytesToSend++] = ADbusDir;                             //     ' Set the directions

            
#endif

            // ------------------------------------ Clock in 2nd byte and NAK ------------------------------------

#if (FT232H)
            MPSSEbuffer[NumBytesToSend++] = MSB_RISING_EDGE_CLOCK_BYTE_IN;      // Clock data byte in
            MPSSEbuffer[NumBytesToSend++] = 0x00;
            MPSSEbuffer[NumBytesToSend++] = 0x00;                               // Data length of 0x0000 means 1 byte data to clock in

            MPSSEbuffer[NumBytesToSend++] = MSB_FALLING_EDGE_CLOCK_BIT_OUT;    // Clock data bit out
            MPSSEbuffer[NumBytesToSend++] = 0x00;                              // Length of 0 means 1 bit
            MPSSEbuffer[NumBytesToSend++] = 0xFF;                              // Sending 1 here as NAK

            ADbusVal = (byte)(0x00 | I2C_Data_SDAhi_SCLlo | (GPIO_Low_Dat & 0xF8));
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAout_SCLout | (GPIO_Low_Dir & 0xF8));

            MPSSEbuffer[NumBytesToSend++] = 0x80;                               //       ' Command - set low byte
            MPSSEbuffer[NumBytesToSend++] = ADbusVal;                            //      ' Set the values
            MPSSEbuffer[NumBytesToSend++] = ADbusDir;                             //     ' Set the directions
#else
            MPSSEbuffer[NumBytesToSend++] = MSB_RISING_EDGE_CLOCK_BYTE_IN;      // Clock data byte in
            MPSSEbuffer[NumBytesToSend++] = 0x00;
            MPSSEbuffer[NumBytesToSend++] = 0x00;                               // Data length of 0x0000 means 1 byte data to clock in
            
            // Send a 1 bit as a Nack
            ADbusVal = (byte)(0x00 | I2C_Data_SDAlo_SCLlo | (GPIO_Low_Dat & 0xF8));
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAout_SCLout | (GPIO_Low_Dir & 0xF8));//back to output
            MPSSEbuffer[NumBytesToSend++] = 0x80;                               //       ' Command - set low byte
            MPSSEbuffer[NumBytesToSend++] = ADbusVal;                            //      ' Set the values
            MPSSEbuffer[NumBytesToSend++] = ADbusDir;                             //     ' Set the directions

            MPSSEbuffer[NumBytesToSend++] = MSB_FALLING_EDGE_CLOCK_BIT_OUT;    // Clock data bit out
            MPSSEbuffer[NumBytesToSend++] = 0x00;                              // Length of 0 means 1 bit
            MPSSEbuffer[NumBytesToSend++] = 0xFF;                              // Sending 1 here as NAK
                                   
            ADbusVal = (byte)(0x00 | I2C_Data_SDAlo_SCLlo | (GPIO_Low_Dat & 0xF8));
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAin_SCLout | (GPIO_Low_Dir & 0xF8));//make data input
            
            MPSSEbuffer[NumBytesToSend++] = 0x80;                               //       ' Command - set low byte
            MPSSEbuffer[NumBytesToSend++] = ADbusVal;                            //      ' Set the values
            MPSSEbuffer[NumBytesToSend++] = ADbusDir;                             //     ' Set the directions
                        
#endif
            // This command then tells the MPSSE to send any results gathered back immediately
            MPSSEbuffer[NumBytesToSend++] = 0x87;                                //  ' Send answer back immediate command

            // Send off the commands
            I2C_Status = Send_Data(NumBytesToSend);
            if (I2C_Status != 0)
            {
                return 1;
            }

            // Read back the ack from the address phase and the 2 bytes read
            I2C_Status = Receive_Data(3);
            if (I2C_Status != 0)
            {
                return 1;
            }

            // Check if address phase was acked
            if ((InputBuffer2[0] & 0x01) == 0)
            {
                I2C_Ack = true;
            }
            else
            {
                I2C_Ack = false;
            }

            // Get the two data bytes to put back to the calling function - InputBuffer2[0..1] now contains the results
            InputBuffer2[0] = InputBuffer2[1];
            InputBuffer2[1] = InputBuffer2[2];

            return 0;

        }


        //###################################################################################################################################

        public byte I2C_SendDeviceAddrAndCheckACK(byte Address, bool Read)
        {


            byte ADbusVal = 0;
            byte ADbusDir = 0;
            NumBytesToSend = 0;

            Address <<= 1;
            if (Read == true)
                Address |= 0x01;

#if (FT232H)
            MPSSEbuffer[NumBytesToSend++] = MSB_FALLING_EDGE_CLOCK_BYTE_OUT;        // clock data byte out
            MPSSEbuffer[NumBytesToSend++] = 0x00;                                   // 
            MPSSEbuffer[NumBytesToSend++] = 0x00;                                   //  Data length of 0x0000 means 1 byte data to clock in
            MPSSEbuffer[NumBytesToSend++] = Address;           //  Byte to send

            // Put line back to idle (data released, clock pulled low)
            ADbusVal = (byte)(0x00 | I2C_Data_SDAhi_SCLlo | (GPIO_Low_Dat & 0xF8));
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAout_SCLout | (GPIO_Low_Dir & 0xF8));// make data input
            MPSSEbuffer[NumBytesToSend++] = 0x80;                                   // Command - set low byte
            MPSSEbuffer[NumBytesToSend++] = ADbusVal;                               // Set the values
            MPSSEbuffer[NumBytesToSend++] = ADbusDir;                               // Set the directions

            // CLOCK IN ACK
            MPSSEbuffer[NumBytesToSend++] = MSB_RISING_EDGE_CLOCK_BIT_IN;           // clock data bits in
            MPSSEbuffer[NumBytesToSend++] = 0x00;                                   // Length of 0 means 1 bit
#else

            // Set directions of clock and data to output in preparation for clocking out a byte
            ADbusVal = (byte)(0x00 | I2C_Data_SDAlo_SCLlo | (GPIO_Low_Dat & 0xF8));
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAout_SCLout | (GPIO_Low_Dir & 0xF8));// back to output
            MPSSEbuffer[NumBytesToSend++] = 0x80;                                   // Command - set low byte
            MPSSEbuffer[NumBytesToSend++] = ADbusVal;                               // Set the values
            MPSSEbuffer[NumBytesToSend++] = ADbusDir;                               // Set the directions
            // clock out one byte
            MPSSEbuffer[NumBytesToSend++] = MSB_FALLING_EDGE_CLOCK_BYTE_OUT;        // clock data byte out
            MPSSEbuffer[NumBytesToSend++] = 0x00;                                   // 
            MPSSEbuffer[NumBytesToSend++] = 0x00;                                   // Data length of 0x0000 means 1 byte data to clock in
            MPSSEbuffer[NumBytesToSend++] = Address;                         // Byte to send

            // Put line back to idle (data released, clock pulled low) so that sensor can drive data line
            ADbusVal = (byte)(0x00 | I2C_Data_SDAlo_SCLlo | (GPIO_Low_Dat & 0xF8));
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAin_SCLout | (GPIO_Low_Dir & 0xF8)); // make data input
            MPSSEbuffer[NumBytesToSend++] = 0x80;                                   // Command - set low byte
            MPSSEbuffer[NumBytesToSend++] = ADbusVal;                               // Set the values
            MPSSEbuffer[NumBytesToSend++] = ADbusDir;                               // Set the directions

            // CLOCK IN ACK
            MPSSEbuffer[NumBytesToSend++] = MSB_RISING_EDGE_CLOCK_BIT_IN;           // clock data byte in
            MPSSEbuffer[NumBytesToSend++] = 0x00;                                   // Length of 0 means 1 bit

#endif
            // This command then tells the MPSSE to send any results gathered (in this case the ack bit) back immediately
            MPSSEbuffer[NumBytesToSend++] = 0x87;                                //  ' Send answer back immediate command

            // send commands to chip
            I2C_Status = Send_Data(NumBytesToSend);
            if (I2C_Status != 0)
            {
                return 1;
            }

            // read back byte containing ack
            I2C_Status = Receive_Data(1);
            if (I2C_Status != 0)
            {
                return 1;            // can also check NumBytesRead
            }

            // if ack bit is 0 then sensor acked the transfer, otherwise it nak'd the transfer
            if ((InputBuffer2[0] & 0x01) == 0)
            {
                I2C_Ack = true;
            }
            else
            {
                I2C_Ack = false;
            }

            return 0;

        }

        //###################################################################################################################################
        // Writes one byte to the I2C bus

        public byte I2C_SendByteAndCheckACK(byte DataByteToSend)
        {
            byte ADbusVal = 0;
            byte ADbusDir = 0;
            NumBytesToSend = 0;

#if (FT232H)
            MPSSEbuffer[NumBytesToSend++] = MSB_FALLING_EDGE_CLOCK_BYTE_OUT;        // clock data byte out
            MPSSEbuffer[NumBytesToSend++] = 0x00;                                   // 
            MPSSEbuffer[NumBytesToSend++] = 0x00;                                   //  Data length of 0x0000 means 1 byte data to clock in
            MPSSEbuffer[NumBytesToSend++] = DataByteToSend;// DataSend[0];          //  Byte to send

            // Put line back to idle (data released, clock pulled low)
            ADbusVal = (byte)(0x00 | I2C_Data_SDAhi_SCLlo | (GPIO_Low_Dat & 0xF8));
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAout_SCLout | (GPIO_Low_Dir & 0xF8));// make data input
            MPSSEbuffer[NumBytesToSend++] = 0x80;                                   // Command - set low byte
            MPSSEbuffer[NumBytesToSend++] = ADbusVal;                               // Set the values
            MPSSEbuffer[NumBytesToSend++] = ADbusDir;                               // Set the directions

            // CLOCK IN ACK
            MPSSEbuffer[NumBytesToSend++] = MSB_RISING_EDGE_CLOCK_BIT_IN;           // clock data bits in
            MPSSEbuffer[NumBytesToSend++] = 0x00;                                   // Length of 0 means 1 bit
#else

            // Set directions of clock and data to output in preparation for clocking out a byte
            ADbusVal = (byte)(0x00 | I2C_Data_SDAlo_SCLlo | (GPIO_Low_Dat & 0xF8));
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAout_SCLout | (GPIO_Low_Dir & 0xF8));// back to output
            MPSSEbuffer[NumBytesToSend++] = 0x80;                                   // Command - set low byte
            MPSSEbuffer[NumBytesToSend++] = ADbusVal;                               // Set the values
            MPSSEbuffer[NumBytesToSend++] = ADbusDir;                               // Set the directions
            // clock out one byte
            MPSSEbuffer[NumBytesToSend++] = MSB_FALLING_EDGE_CLOCK_BYTE_OUT;        // clock data byte out
            MPSSEbuffer[NumBytesToSend++] = 0x00;                                   // 
            MPSSEbuffer[NumBytesToSend++] = 0x00;                                   // Data length of 0x0000 means 1 byte data to clock in
            MPSSEbuffer[NumBytesToSend++] = DataByteToSend;                         // Byte to send

            // Put line back to idle (data released, clock pulled low) so that sensor can drive data line
            ADbusVal = (byte)(0x00 | I2C_Data_SDAlo_SCLlo | (GPIO_Low_Dat & 0xF8));
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAin_SCLout | (GPIO_Low_Dir & 0xF8)); // make data input
            MPSSEbuffer[NumBytesToSend++] = 0x80;                                   // Command - set low byte
            MPSSEbuffer[NumBytesToSend++] = ADbusVal;                               // Set the values
            MPSSEbuffer[NumBytesToSend++] = ADbusDir;                               // Set the directions

            // CLOCK IN ACK
            MPSSEbuffer[NumBytesToSend++] = MSB_RISING_EDGE_CLOCK_BIT_IN;           // clock data byte in
            MPSSEbuffer[NumBytesToSend++] = 0x00;                                   // Length of 0 means 1 bit

#endif
            // This command then tells the MPSSE to send any results gathered (in this case the ack bit) back immediately
            MPSSEbuffer[NumBytesToSend++] = 0x87;                                //  ' Send answer back immediate command

            // send commands to chip
            I2C_Status = Send_Data(NumBytesToSend);
            if (I2C_Status != 0)
            {
                return 1;
            }

            // read back byte containing ack
            I2C_Status = Receive_Data(1);
            if (I2C_Status != 0)
            {
                return 1;            // can also check NumBytesRead
            }

            // if ack bit is 0 then sensor acked the transfer, otherwise it nak'd the transfer
            if ((InputBuffer2[0] & 0x01) == 0)
            {
                I2C_Ack = true;
            }
            else
            {
                I2C_Ack = false;
            }

            return 0;

        }

        //###################################################################################################################################
        // Sets I2C Start condition

        public byte I2C_SetStart()
        {
            byte Count = 0;
            byte ADbusVal = 0;
            byte ADbusDir = 0;
            NumBytesToSend = 0;


#if (FT232H)
            // SDA high, SCL high
            ADbusVal = (byte)(0x00 | I2C_Data_SDAhi_SCLhi | (GPIO_Low_Dat & 0xF8));
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAout_SCLout | (GPIO_Low_Dir & 0xF8));    // on FT232H lines always output

            for (Count = 0; Count < 6; Count++)
            {
                MPSSEbuffer[NumBytesToSend++] = 0x80;	    // ADbus GPIO command
                MPSSEbuffer[NumBytesToSend++] = ADbusVal;   // Set data value
                MPSSEbuffer[NumBytesToSend++] = ADbusDir;	// Set direction
            }

            // SDA lo, SCL high
            ADbusVal = (byte)(0x00 | I2C_Data_SDAlo_SCLhi | (GPIO_Low_Dat & 0xF8));

            for (Count = 0; Count < 6; Count++)	// Repeat commands to ensure the minimum period of the start setup time ie 600ns is achieved
            {
                MPSSEbuffer[NumBytesToSend++] = 0x80;	    // ADbus GPIO command
                MPSSEbuffer[NumBytesToSend++] = ADbusVal;   // Set data value
                MPSSEbuffer[NumBytesToSend++] = ADbusDir;	// Set direction
            }

            // SDA lo, SCL lo
            ADbusVal = (byte)(0x00 | I2C_Data_SDAlo_SCLlo | (GPIO_Low_Dat & 0xF8));

            for (Count = 0; Count < 6; Count++)	// Repeat commands to ensure the minimum period of the start setup time ie 600ns is achieved
            {
                MPSSEbuffer[NumBytesToSend++] = 0x80;	    // ADbus GPIO command
                MPSSEbuffer[NumBytesToSend++] = ADbusVal;   // Set data value
                MPSSEbuffer[NumBytesToSend++] = ADbusDir;	// Set direction
            }

            // Release SDA
            ADbusVal = (byte)(0x00 | I2C_Data_SDAhi_SCLlo | (GPIO_Low_Dat & 0xF8));

            MPSSEbuffer[NumBytesToSend++] = 0x80;	    // ADbus GPIO command
            MPSSEbuffer[NumBytesToSend++] = ADbusVal;   // Set data value
            MPSSEbuffer[NumBytesToSend++] = ADbusDir;	// Set direction


# else

            // Both SDA and SCL high (setting to input simulates open drain high)
            ADbusVal = (byte)(0x00 | I2C_Data_SDAlo_SCLlo | (GPIO_Low_Dat & 0xF8));
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAin_SCLin | (GPIO_Low_Dir & 0xF8));

            for (Count = 0; Count < 6; Count++)
            {
                MPSSEbuffer[NumBytesToSend++] = 0x80;	    // ADbus GPIO command
                MPSSEbuffer[NumBytesToSend++] = ADbusVal;   // Set data value
                MPSSEbuffer[NumBytesToSend++] = ADbusDir;	// Set direction
            }

            // SDA low, SCL high (setting to input simulates open drain high)
            ADbusVal = (byte)(0x00 | I2C_Data_SDAlo_SCLlo | (GPIO_Low_Dat & 0xF8));
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAout_SCLin | (GPIO_Low_Dir & 0xF8));

            for (Count = 0; Count < 6; Count++)	// Repeat commands to ensure the minimum period of the start setup time
            {
                MPSSEbuffer[NumBytesToSend++] = 0x80;	    // ADbus GPIO command
                MPSSEbuffer[NumBytesToSend++] = ADbusVal;   // Set data value
                MPSSEbuffer[NumBytesToSend++] = ADbusDir;	// Set direction
            }

            // SDA low, SCL low
            ADbusVal = (byte)(0x00 | I2C_Data_SDAlo_SCLlo | (GPIO_Low_Dat & 0xF8));//
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAout_SCLout | (GPIO_Low_Dir & 0xF8));//as above

            for (Count = 0; Count < 6; Count++)	// Repeat commands to ensure the minimum period of the start setup time
            {
                MPSSEbuffer[NumBytesToSend++] = 0x80;	    // ADbus GPIO command
                MPSSEbuffer[NumBytesToSend++] = ADbusVal;   // Set data value
                MPSSEbuffer[NumBytesToSend++] = ADbusDir;	// Set direction
            }

            // Release SDA (setting to input simulates open drain high)
            ADbusVal = (byte)(0x00 | I2C_Data_SDAlo_SCLlo | (GPIO_Low_Dat & 0xF8));//
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAin_SCLout | (GPIO_Low_Dir & 0xF8));//as above

            MPSSEbuffer[NumBytesToSend++] = 0x80;	    // ADbus GPIO command
            MPSSEbuffer[NumBytesToSend++] = ADbusVal;   // Set data value
            MPSSEbuffer[NumBytesToSend++] = ADbusDir;	// Set direction



# endif
            I2C_Status = Send_Data(NumBytesToSend);
            if (I2C_Status != 0)
                return 1;
            else
                return 0;

        }

        //###################################################################################################################################
        // Sets I2C Stop condition

        public byte I2C_SetStop()
        {
            byte Count = 0;
            byte ADbusVal = 0;
            byte ADbusDir = 0;
            NumBytesToSend = 0;

#if (FT232H)
            // SDA low, SCL low
            ADbusVal = (byte)(0x00 | I2C_Data_SDAlo_SCLlo | (GPIO_Low_Dat & 0xF8));
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAout_SCLout | (GPIO_Low_Dir & 0xF8));    // on FT232H lines always output

            for (Count = 0; Count < 6; Count++)
            {
                MPSSEbuffer[NumBytesToSend++] = 0x80;	    // ADbus GPIO command
                MPSSEbuffer[NumBytesToSend++] = ADbusVal;   // Set data value
                MPSSEbuffer[NumBytesToSend++] = ADbusDir;	// Set direction
            }

            // SDA low, SCL high
            ADbusVal = (byte)(0x00 | I2C_Data_SDAlo_SCLhi | (GPIO_Low_Dat & 0xF8));
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAout_SCLout | (GPIO_Low_Dir & 0xF8));    // on FT232H lines always output

            for (Count = 0; Count < 6; Count++)
            {
                MPSSEbuffer[NumBytesToSend++] = 0x80;	    // ADbus GPIO command
                MPSSEbuffer[NumBytesToSend++] = ADbusVal;   // Set data value
                MPSSEbuffer[NumBytesToSend++] = ADbusDir;	// Set direction
            }

            // SDA high, SCL high
            ADbusVal = (byte)(0x00 | I2C_Data_SDAhi_SCLhi | (GPIO_Low_Dat & 0xF8));
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAout_SCLout | (GPIO_Low_Dir & 0xF8));        // on FT232H lines always output

            for (Count = 0; Count < 6; Count++)
            {
                MPSSEbuffer[NumBytesToSend++] = 0x80;	    // ADbus GPIO command
                MPSSEbuffer[NumBytesToSend++] = ADbusVal;   // Set data value
                MPSSEbuffer[NumBytesToSend++] = ADbusDir;	// Set direction
            }

#else

            // SDA low, SCL low
            ADbusVal = (byte)(0x00 | I2C_Data_SDAlo_SCLlo | (GPIO_Low_Dat & 0xF8));
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAout_SCLout | (GPIO_Low_Dir & 0xF8));

            for (Count = 0; Count < 6; Count++)
            {
                MPSSEbuffer[NumBytesToSend++] = 0x80;	    // ADbus GPIO command
                MPSSEbuffer[NumBytesToSend++] = ADbusVal;   // Set data value
                MPSSEbuffer[NumBytesToSend++] = ADbusDir;	// Set direction
            }


            // SDA low, SCL high (note: setting to input simulates open drain high)
            ADbusVal = (byte)(0x00 | I2C_Data_SDAlo_SCLlo | (GPIO_Low_Dat & 0xF8));
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAout_SCLin | (GPIO_Low_Dir & 0xF8));

            for (Count = 0; Count < 6; Count++)
            {
                MPSSEbuffer[NumBytesToSend++] = 0x80;	    // ADbus GPIO command
                MPSSEbuffer[NumBytesToSend++] = ADbusVal;   // Set data value
                MPSSEbuffer[NumBytesToSend++] = ADbusDir;	// Set direction
            }

            // SDA high, SCL high (note: setting to input simulates open drain high)
            ADbusVal = (byte)(0x00 | I2C_Data_SDAlo_SCLlo | (GPIO_Low_Dat & 0xF8));
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAin_SCLin | (GPIO_Low_Dir & 0xF8));

            for (Count = 0; Count < 6; Count++)	// Repeat commands to hold states for longer time
            {
                MPSSEbuffer[NumBytesToSend++] = 0x80;	    // ADbus GPIO command
                MPSSEbuffer[NumBytesToSend++] = ADbusVal;   // Set data value
                MPSSEbuffer[NumBytesToSend++] = ADbusDir;	// Set direction
            }
#endif
            // send the buffer of commands to the chip 
            I2C_Status = Send_Data(NumBytesToSend);
            if (I2C_Status != 0)
                return 1;
            else
                return 0;

        }


        //###################################################################################################################################
        // Sets GPIO values on low byte and puts I2C lines (bits 0, 1, 2) to idle outwith transaction state

        public byte I2C_SetLineStatesIdle()
        {
            byte ADbusVal = 0;
            byte ADbusDir = 0;
            NumBytesToSend = 0;

#if (FT232H)
            // '######## Combine the I2C line state for bits 2..0 with the GPIO for bits 7..3 ########
            ADbusVal = (byte)(0x00 | I2C_Data_SDAhi_SCLhi | (GPIO_Low_Dat & 0xF8));
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAout_SCLout | (GPIO_Low_Dir & 0xF8));    // FT232H always output due to open drain capability    

#else
           ADbusVal = (byte)(0x00 | I2C_Data_SDAlo_SCLlo | (GPIO_Low_Dat & 0xF8));
           ADbusDir = (byte)(0x00 | I2C_Dir_SDAin_SCLin | (GPIO_Low_Dir & 0xF8));       // FT2232H/FT4232H use input to mimic open drain
#endif

            MPSSEbuffer[NumBytesToSend++] = 0x80;       // ADbus GPIO command
            MPSSEbuffer[NumBytesToSend++] = ADbusVal;   // Set data value
            MPSSEbuffer[NumBytesToSend++] = ADbusDir;   // Set direction

            I2C_Status = Send_Data(NumBytesToSend);
            if (I2C_Status != 0)
                return 1;
            else
                return 0;
        }


        //###################################################################################################################################
        // Gets GPIO values from low byte

        public byte I2C_GetGPIOValuesLow()
        {
            NumBytesToSend = 0;

            MPSSEbuffer[NumBytesToSend++] = 0x81;       // ADbus GPIO command for reading low byte
            MPSSEbuffer[NumBytesToSend++] = 0x87;        // Send answer back immediate command

            I2C_Status = Send_Data(NumBytesToSend);
            if (I2C_Status != 0)
                return 1;

            I2C_Status = Receive_Data(1);
            if (I2C_Status != 0)
            {
                return 1;
            }

            ADbusReadVal = (byte)(InputBuffer2[0] & 0xF8); // mask the returned value to show only 5 GPIO lines (bits 0/1/2 are I2C)

            return 0;
        }



        //###################################################################################################################################
        // Sets GPIO values on high byte

        public byte I2C_SetGPIOValuesHigh(byte ACbusDir, byte ACbusVal)
        {
            NumBytesToSend = 0;

#if (FT4232H)

           return 1;
           
#else
            MPSSEbuffer[NumBytesToSend++] = 0x82;       // ACbus GPIO command
            MPSSEbuffer[NumBytesToSend++] = ACbusVal;   // Set data value
            MPSSEbuffer[NumBytesToSend++] = ACbusDir;   // Set direction

            I2C_Status = Send_Data(NumBytesToSend);
            if (I2C_Status != 0)
                return 1;
            else
                return 0;

#endif
        }



        //###################################################################################################################################
        // Gets GPIO values from high byte

        public byte I2C_GetGPIOValuesHigh()
        {
            NumBytesToSend = 0;

#if (FT4232H)
                return 1;       // no high byte on FT4232H
#else

            MPSSEbuffer[NumBytesToSend++] = 0x83;           // ACbus read GPIO command
            MPSSEbuffer[NumBytesToSend++] = 0x87;            // Send answer back immediate command

            I2C_Status = Send_Data(NumBytesToSend);
            if (I2C_Status != 0)
                return 1;

            I2C_Status = Receive_Data(1);
            if (I2C_Status != 0)
                return 1;

            ACbusReadVal = (byte)(InputBuffer2[0]);      // Return via global variable for calling function to read

            return 0;
#endif
        }

        //###################################################################################################################################
        //##################                             End of I2C Layer                                               #####################
        //###################################################################################################################################




        //###################################################################################################################################
        //###################################################################################################################################
        //##################                                          D2xx Layer                                        #####################
        //###################################################################################################################################
        //###################################################################################################################################


        // Read a specified number of bytes from the driver receive buffer

        private byte Receive_Data(uint BytesToRead)
        {
            uint NumBytesInQueue = 0;
            uint QueueTimeOut = 0;
            uint Buffer1Index = 0;
            uint Buffer2Index = 0;
            uint TotalBytesRead = 0;
            bool QueueTimeoutFlag = false;
            uint NumBytesRxd = 0;

            // Keep looping until all requested bytes are received or we've tried 5000 times (value can be chosen as required)
            while ((TotalBytesRead < BytesToRead) && (QueueTimeoutFlag == false))
            {
                ftStatus = myFtdiDevice.GetRxBytesAvailable(ref NumBytesInQueue);       // Check bytes available

                if ((NumBytesInQueue > 0) && (ftStatus == FTDI.FT_STATUS.FT_OK))
                {
                    ftStatus = myFtdiDevice.Read(InputBuffer, NumBytesInQueue, ref NumBytesRxd);  // if any available read them

                    if ((NumBytesInQueue == NumBytesRxd) && (ftStatus == FTDI.FT_STATUS.FT_OK))
                    {
                        Buffer1Index = 0;

                        while (Buffer1Index < NumBytesRxd)
                        {
                            InputBuffer2[Buffer2Index] = InputBuffer[Buffer1Index];     // copy into main overall application buffer
                            Buffer1Index++;
                            Buffer2Index++;
                        }
                        TotalBytesRead = TotalBytesRead + NumBytesRxd;                  // Keep track of total
                    }
                    else
                        return 1;

                    QueueTimeOut++;
                    if (QueueTimeOut == 5000)
                        QueueTimeoutFlag = true;
                    else
                        Thread.Sleep(0);                                                // Avoids running Queue status checks back to back
                }
            }
            // returning globals NumBytesRead and the buffer InputBuffer2
            NumBytesRead = TotalBytesRead;

            if (QueueTimeoutFlag == true)
                return 1;
            else
                return 0;
        }


        //###################################################################################################################################
        // Write a buffer of data and check that it got sent without error

        private byte Send_Data(uint BytesToSend)
        {

            NumBytesToSend = BytesToSend;

            // Send data. This will return once all sent or if times out
            ftStatus = myFtdiDevice.Write(MPSSEbuffer, NumBytesToSend, ref NumBytesSent);

            // Ensure that call completed OK and that all bytes sent as requested
            if ((NumBytesSent != NumBytesToSend) || (ftStatus != FTDI.FT_STATUS.FT_OK))
                return 1;   // error   calling function can check NumBytesSent to see how many got sent
            else
                return 0;   // success
        }


        //###################################################################################################################################
        // Flush drivers receive buffer - Get queue status and read everything available and discard data

        private byte FlushBuffer()
        {
            ftStatus = myFtdiDevice.GetRxBytesAvailable(ref BytesAvailable);	 // Get the number of bytes in the receive buffer
            if (ftStatus != FTDI.FT_STATUS.FT_OK)
                return 1;

            if (BytesAvailable > 0)
            {
                ftStatus = myFtdiDevice.Read(InputBuffer, BytesAvailable, ref NumBytesRead);  	//Read out the data from receive buffer
                if (ftStatus != FTDI.FT_STATUS.FT_OK)
                    return 1;       // error
                else
                    return 0;       // all bytes successfully read
            }
            else
            {
                return 0;           // there were no bytes to read
            }
        }


        //###################################################################################################################################
        //##################                                     End of D2xx Layer                                      #####################
        //###################################################################################################################################



    }
}
