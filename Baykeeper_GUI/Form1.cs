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
        const byte I2C_Dir_SDAout_SCLin = 0x02;
        const byte I2C_Dir_SDAout_SCLout = 0x03;
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
        const uint ClockDivisor = 2*199;  // for 100 kHz
        // Sending and receiving
        static uint NumBytesToSend = 0;
        //static uint NumBytesToRead = 0;
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
        static byte[] i2c_return = new byte[500];


        // ###### Sambaqui defines ######
        static uint TSon = 0;


        static byte trim_LSB = 0b_11111111; //default
        static byte trim_MSB = 0b_00000001; //default

        static byte MSB_old = 0x00;
        static byte LSB_old = 0x00;

        /*const byte BKP_ADDRESS = 0x44;

        // COMMAND
        const byte BKP_TASK0 = 0X00;
        const byte BKP_TASK1 = 0X01;
        // OSC
        const byte BKP_OSC_EN = 0X20;
        const byte BKP_OSC_TRIM = 0X21;
        // TEMPERATURE SENSOR
        const byte BKP_TS_EVNT1 = 0X40;
        const byte BKP_TS_CTRL0 = 0X41;
        const byte BKP_TEMP_MSB = 0X42;
        const byte BKP_TEMP_LSB = 0X43;
        const byte BKP_TS_DBEN = 0X44;
        const byte BKP_TS_TRIM0 = 0X45;
        const byte BKP_TS_TRIM1 = 0X46;*/


        uint devcount = 0;

        // Create new instance of the FTDI device class
        FTDI myFtdiDevice = new FTDI();

        //calibrations vars
        //byte CalDevStatus = 0;
        //byte StatusCont = 0;
        const int extendSize = 320;
        State ActualState = 0;
        //static int sizeDebug = 0;
        public enum State {SmallWin, BigWin}
        private System.Windows.Forms.Label label_TMP = new System.Windows.Forms.Label();




        public Form1()
        {

            InitializeComponent();
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                this.Text = string.Format("Chipus - Sambaqui GUI (" +
                    ApplicationDeployment.CurrentDeployment.CurrentVersion) + ")";
            }




            device_disconnected();
        }
        

        ///////////////////////////////////// Form Events /////////////////////////////////////////
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        //###################################################################################################################################
        // Code for the INITIALISE button...

        private void tryToConnect()
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
                    //MessageBox.Show("No device found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            System.Diagnostics.Process.Start("https://www.chipus.com.br/");
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

        private byte i2c_write_and_check(byte ADDR, byte REG, byte DATA)
        {
            int i = 0;
            byte status = 0;
            while (true)
            {
                i2c_write(ADDR, REG, DATA);
                i2c_read(ADDR, REG);
                if (i2c_return[0] == DATA)
                {
                    status = 0;
                    break;
                }
                else
                {
                    i = i + 1;
                }
                if (i >= 10)
                {
                    status = 1;
                    break;
                }
            }

            return status;
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

            AppStatus = I2C_ReadByte(false, 1);                                                 // I2C READ (send Ack)
            if (AppStatus != 0) return 1;

            i2c_return[0] = InputBuffer2[0];                                              // Get the byte read

            AppStatus = I2C_SetStop();                                                      // I2C STOP
            if (AppStatus != 0) return 1;


            return 0;
        }



        //###################################################################################################################################
        // Read I2C (2 byte) and refresh i2c_return static byte
        // Not tested yet
        private byte i2c_read_word(byte ADDR, ushort REG)
        {
            return i2c_read_Nbytes(ADDR, REG, 2);
        }

        private byte i2c_read_Nbytes(byte ADDR, ushort REG, ushort NumBytes)
        {
            ushort i;

            AppStatus = I2C_SetStart();                                             // I2C START
            if (AppStatus != 0) return 1;

            AppStatus = I2C_SendDeviceAddrAndCheckACK((byte)(ADDR), false);         // I2C ADDRESS (for write)
            if (AppStatus != 0) return 1;
            if (I2C_Ack != true) { I2C_SetStop(); return 1; }                       // if sensor NAKs then send stop and return

            AppStatus = I2C_SendByteAndCheckACK((byte)(REG));                       // SEND REGISTER ID
            if (AppStatus != 0) return 1;
            if (I2C_Ack != true) { I2C_SetStop(); return 1; }                       // if sensor NAKs then send stop and return

            AppStatus = I2C_SetStart();                                             // REPEAT START
            if (AppStatus != 0) return 1;

            AppStatus = I2C_SendDeviceAddrAndCheckACK((byte)(ADDR), true);          // I2C ADDRESS (for read)
            if (AppStatus != 0) return 1;
            if (I2C_Ack != true) { I2C_SetStop(); return 1; }                       // if sensor NAKs then send stop and return


            for (i = 0; i < NumBytes - 1; i++)
            {
                AppStatus = I2C_ReadByte(true, 1);                                  // I2C READ (send Ack)
                if (AppStatus != 0) return 1;
                i2c_return[i] = InputBuffer2[0];                                    // Get the byte read from input buffer to i2c buffer
            }
            
            AppStatus = I2C_ReadByte(false, 1);                                     // I2C READ (send Ack)
            if (AppStatus != 0) return 1;

            i2c_return[i] = InputBuffer2[0];


            AppStatus = I2C_SetStop();                                              // I2C STOP
            if (AppStatus != 0) return 1;


            return 0;

        }


        //###################################################################################################################################
        // This funcion reads 2 following data from REG and REG+1 an write on a global variable called ADCvalue
        // Used to test ADS112C04 and verified

        //###################################################################################################################################
        // A 1 second timer is enabled after connected to detect if the connection is still avaiable
        // An unused GPIO is read in order to check if FTDI is answering
        private void timer_disconnect_Tick(object sender, EventArgs e)
        {

            if (myFtdiDevice.IsOpen)
            {
                AppStatus = I2C_GetGPIOValuesLow();

                //If write to MPSSE failed (e.g. device unplugged) then stop running
                if (AppStatus != 0)
                {
                    myFtdiDevice.Close();
                    device_disconnected();
                    DeviceOpen = false;
                    MessageBox.Show("Device connection lost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // try to connect
            {
                try
                {
                    tryToConnect();
                }
                catch
                {

                }
            }
            

        }


        //###################################################################################################################################
        // Configure itens in all tabs when device is disconnected
        private void device_disconnected()
        {
            // Close the FTDI device and then close the window
            //timer_disconnect.Enabled = false;


            DeviceOpen = false;

            ///////////////////////////////////////////////////////////////////
            /// TAB "Configuration"
            ///////////////////////////////////////////////////////////////////
            //button_serialPorts.Text = "Connect";
            label_serialPortStatus.Text = "Disconnected";
            label_serialPortStatus.ForeColor = Color.FromArgb(210, 39, 48);


            ///////////////////////////////////////////////////////////////////
            /// TAB "About"
            ///////////////////////////////////////////////////////////////////
            // do nothing


            ///////////////////////////////////////////////////////////////////
            /// TAB "Temperature Sensor"
            ///////////////////////////////////////////////////////////////////
            buttonWrite.Enabled = false;
            buttonRead.Enabled = false;
            button_testMode.Enabled = false;
            button_maskTSD.Enabled = false;

            label_Write_ack.Text = "---";
            label_Write_ack.ForeColor = Color.Black;

            label_Read_ack.Text = "---";
            label_Read_ack.ForeColor = Color.Black;

            label_testMode.Text = "---";
            label_testMode.ForeColor = Color.Black;

            label_maskTSD.Text = "---";
            label_maskTSD.ForeColor = Color.Black;

        }



        private void button_TS_Click(object sender, EventArgs e)
        {
            /////////////////////////////////////////////////////////////////////////////////////////////
            byte i2c_dataWrite = 0x00;
            try
            {
                i2c_dataWrite = Convert.ToByte(textBox_i2cDataWrite.Text, 2);
                textBox_i2cDataWrite.Text = Convert.ToString(i2c_dataWrite, 2).PadLeft(8, '0');
            }
            catch
            {
                // error message
                MessageBox.Show("Please insert a valid data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_i2cDataWrite.Text = "00000000";
                return;
            }

            byte i2c_regWrite = 0x00;
            try
            {
                i2c_regWrite = Convert.ToByte(textBox_i2cRegWrite.Text, 16);
                textBox_i2cRegWrite.Text = Convert.ToString(i2c_regWrite, 16).PadLeft(2, '0');
            }
            catch
            {
                // error message
                MessageBox.Show("Please insert a valid register.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_i2cRegWrite.Text = "00";
                return;
            }

            byte i2c_SlaveAddr = 0x00;
            try
            {
                i2c_SlaveAddr = Convert.ToByte(textBox_i2c_SlaveAddr.Text, 2);
                textBox_i2c_SlaveAddr.Text = Convert.ToString(i2c_SlaveAddr, 2).PadLeft(7, '0');
            }
            catch
            {
                // error message
                MessageBox.Show("Please insert a valid slave address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_i2c_SlaveAddr.Text = "0000000";
                return;
            }

            byte ack = i2c_write(i2c_SlaveAddr, i2c_regWrite, i2c_dataWrite);
            if (ack == 0)
            {
                label_Write_ack.Text = "ACK";
                label_Write_ack.ForeColor = Color.LimeGreen;
            }
            else
            {
                label_Write_ack.Text = "NACK";
                label_Write_ack.ForeColor = Color.FromArgb(210, 39, 48);
                return;
            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            byte i2c_regRead = 0x00;
            try
            {
                i2c_regRead = Convert.ToByte(textBox_i2cRegRead.Text, 16);
                textBox_i2cRegRead.Text = Convert.ToString(i2c_regRead, 16).PadLeft(2, '0');
            }
            catch
            {
                // error message
                MessageBox.Show("Please insert a valid register.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_i2cRegRead.Text = "00";
                return;
            }

            byte i2c_SlaveAddr = 0x00;
            try
            {
                i2c_SlaveAddr = Convert.ToByte(textBox_i2c_SlaveAddr.Text, 2);
                textBox_i2c_SlaveAddr.Text = Convert.ToString(i2c_SlaveAddr, 2).PadLeft(7, '0');
            }
            catch
            {
                // error message
                MessageBox.Show("Please insert a valid slave address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_i2cDataWrite.Text = "0000000";
                return;
            }

            byte dataRead = 0x00;
            byte ack = i2c_read(i2c_SlaveAddr, i2c_regRead);

            if (ack == 0)
            {
                label_Read_ack.Text = "ACK";
                label_Read_ack.ForeColor = Color.LimeGreen;
                dataRead = i2c_return[0];
                textBox_dataRead.Text = Convert.ToString(dataRead, 2).PadLeft(8, '0');

            }
            else
            {
                //Console.WriteLine("\npintando de preto");
                label_Read_ack.Text = "NACK";
                label_Read_ack.ForeColor = Color.FromArgb(210, 39, 48);
                textBox_dataRead.Text = "";
            }
        }

        //###################################################################################################################################
        // Configure itens in all tabs when device is connected
        private byte device_connected()
        {
            


            if (baykeeperInit() != 0)
            {
                MessageBox.Show("Oops, I2C interface could not be initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myFtdiDevice.Close();
                DeviceOpen = false;
                device_disconnected();
                return 1;
            }
            timer_disconnect.Enabled = true;

            ///////////////////////////////////////////////////////////////////
            /// TAB "Configuration"
            ///////////////////////////////////////////////////////////////////
            //button_serialPorts.Text = "Disconnect";
            label_serialPortStatus.Text = "Connected";
            label_serialPortStatus.ForeColor = Color.LimeGreen;


            ///////////////////////////////////////////////////////////////////
            /// TAB "About"
            ///////////////////////////////////////////////////////////////////
            // do nothing

            ///////////////////////////////////////////////////////////////////
            /// TAB "Temperature Sensor"
            ///////////////////////////////////////////////////////////////////

            buttonWrite.Enabled = true;
            buttonRead.Enabled = true;
            button_testMode.Enabled = true;
            button_maskTSD.Enabled = true;

            return 0;
        }

        private byte baykeeperInit()
        {
            //return 0;
            // Due to wrong implementation, the following register must be trimmed before use
            // Start

            // End


            return 0;
        }


        private void textBox_i2cDataWrite_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow backspace, 0 and 1
            e.Handled = !("\b01".Contains(e.KeyChar));
        }

        private void textBox_i2cRegWrite_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow backspace, and hexadecimals
            e.Handled = !("\b0123456789abcdefABCDEF".Contains(e.KeyChar));
        }

        private void textBox_TS_i2c_addr_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow backspace, 0 and 1
            e.Handled = !("\b01".Contains(e.KeyChar));
        }
        private void textBox_i2cRegRead_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow backspace, and hexadecimals
            e.Handled = !("\b0123456789abcdefABCDEF".Contains(e.KeyChar));
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
            //NumBytesToRead = 2;
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
            //NumBytesToRead = 2;
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

        public byte I2C_ReadByte(bool ACK, ushort NumBytes)
        {
            byte ADbusVal = 0;
            byte ADbusDir = 0;
            NumBytesToSend = 0;

#if (FT232H)
            // Clock in one data byte
            MPSSEbuffer[NumBytesToSend++] = MSB_RISING_EDGE_CLOCK_BYTE_IN;      // Clock data byte in
            MPSSEbuffer[NumBytesToSend++] = (byte)(NumBytes - 1);
            MPSSEbuffer[NumBytesToSend++] = (byte) ((NumBytes - 1) >> 8);                               // Data length of 0x0000 means 1 byte data to clock in

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
            I2C_Status = Receive_Data(NumBytes);
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

            //for (Count = 0; Count < 6; Count++)
            for (Count = 0; Count < 18; Count++)
            {
                MPSSEbuffer[NumBytesToSend++] = 0x80;	    // ADbus GPIO command
                MPSSEbuffer[NumBytesToSend++] = ADbusVal;   // Set data value
                MPSSEbuffer[NumBytesToSend++] = ADbusDir;	// Set direction
            }
            for (Count = 0; Count < 18; Count++)
            {
                MPSSEbuffer[NumBytesToSend++] = 0x80;	    // ADbus GPIO command
                MPSSEbuffer[NumBytesToSend++] = ADbusVal;   // Set data value
                MPSSEbuffer[NumBytesToSend++] = ADbusDir;	// Set direction
            }
            for (Count = 0; Count < 18; Count++)
            {
                MPSSEbuffer[NumBytesToSend++] = 0x80;	    // ADbus GPIO command
                MPSSEbuffer[NumBytesToSend++] = ADbusVal;   // Set data value
                MPSSEbuffer[NumBytesToSend++] = ADbusDir;	// Set direction
            }





            // SDA lo, SCL high
            ADbusVal = (byte)(0x00 | I2C_Data_SDAlo_SCLhi | (GPIO_Low_Dat & 0xF8));

            //for (Count = 0; Count < 6; Count++)    // Repeat commands to ensure the minimum period of the start setup time ie 600ns is achieved
            for (Count = 0; Count < 18; Count++)    // counter increased to work with Baykeeper - A. Hoffmann
            {
                MPSSEbuffer[NumBytesToSend++] = 0x80;	    // ADbus GPIO command
                MPSSEbuffer[NumBytesToSend++] = ADbusVal;   // Set data value
                MPSSEbuffer[NumBytesToSend++] = ADbusDir;	// Set direction
            }





            // SDA lo, SCL lo
            ADbusVal = (byte)(0x00 | I2C_Data_SDAlo_SCLlo | (GPIO_Low_Dat & 0xF8));

            //for (Count = 0; Count < 6; Count++)    // Repeat commands to ensure the minimum period of the start setup time ie 600ns is achieved
            for (Count = 0; Count < 18; Count++)    // counter increased to work with Baykeeper - A. Hoffmann

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

            for (Count = 0; Count < 18; Count++)
            {
                MPSSEbuffer[NumBytesToSend++] = 0x80;	    // ADbus GPIO command
                MPSSEbuffer[NumBytesToSend++] = ADbusVal;   // Set data value
                MPSSEbuffer[NumBytesToSend++] = ADbusDir;	// Set direction
            }

            // SDA low, SCL high
            ADbusVal = (byte)(0x00 | I2C_Data_SDAlo_SCLhi | (GPIO_Low_Dat & 0xF8));
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAout_SCLout | (GPIO_Low_Dir & 0xF8));    // on FT232H lines always output

            for (Count = 0; Count < 18; Count++)
            {
                MPSSEbuffer[NumBytesToSend++] = 0x80;	    // ADbus GPIO command
                MPSSEbuffer[NumBytesToSend++] = ADbusVal;   // Set data value
                MPSSEbuffer[NumBytesToSend++] = ADbusDir;	// Set direction
            }

            // SDA high, SCL high
            ADbusVal = (byte)(0x00 | I2C_Data_SDAhi_SCLhi | (GPIO_Low_Dat & 0xF8));
            ADbusDir = (byte)(0x00 | I2C_Dir_SDAout_SCLout | (GPIO_Low_Dir & 0xF8));        // on FT232H lines always output

            for (Count = 0; Count < 18; Count++)
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

        private void button_testMode_Click(object sender, EventArgs e)
        {
            byte i2c_SlaveAddr = 0x00;
            try
            {
                i2c_SlaveAddr = Convert.ToByte(textBox_i2c_SlaveAddr.Text, 2);
                textBox_i2c_SlaveAddr.Text = Convert.ToString(i2c_SlaveAddr, 2).PadLeft(7, '0');
            }
            catch
            {
                // error message
                MessageBox.Show("Please insert a valid slave address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_i2c_SlaveAddr.Text = "0000000";
                return;
            }

            byte ack = i2c_write(i2c_SlaveAddr, 0x0f, 0xfa);
            if (ack == 0)
            {
                label_testMode.Text = "ACK";
                label_testMode.ForeColor = Color.LimeGreen;
            }
            else
            {
                label_testMode.Text = "NACK";
                label_testMode.ForeColor = Color.FromArgb(210, 39, 48);
                return;
            }
        }

        private void button_maskTSD_Click(object sender, EventArgs e)
        {
            byte i2c_SlaveAddr = 0x00;
            try
            {
                i2c_SlaveAddr = Convert.ToByte(textBox_i2c_SlaveAddr.Text, 2);
                textBox_i2c_SlaveAddr.Text = Convert.ToString(i2c_SlaveAddr, 2).PadLeft(7, '0');
            }
            catch
            {
                // error message
                MessageBox.Show("Please insert a valid slave address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_i2c_SlaveAddr.Text = "0000000";
                return;
            }

            byte ack = i2c_write(i2c_SlaveAddr, 0x80, 0x0f);
            if (ack == 0)
            {
                label_maskTSD.Text = "ACK";
                label_maskTSD.ForeColor = Color.LimeGreen;
            }
            else
            {
                label_maskTSD.Text = "NACK";
                label_maskTSD.ForeColor = Color.FromArgb(210, 39, 48);
                return;
            }
        }








        //###################################################################################################################################
        //##################                                     End of D2xx Layer                                      #####################
        //###################################################################################################################################



    }
}
