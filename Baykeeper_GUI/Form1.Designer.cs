
namespace Baykeeper_GUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_I2C = new System.Windows.Forms.TabPage();
            this.label_Write_ack = new System.Windows.Forms.Label();
            this.textBox_i2cDataWrite = new System.Windows.Forms.TextBox();
            this.textBox_i2cRegWrite = new System.Windows.Forms.TextBox();
            this.textBox_i2c_SlaveAddr = new System.Windows.Forms.TextBox();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.label42 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.tabPage_about = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.linkLabel_tabAbout = new System.Windows.Forms.LinkLabel();
            this.label_tabAbout = new System.Windows.Forms.Label();
            this.pictureBox_tabAbout = new System.Windows.Forms.PictureBox();
            this.timer_disconnect = new System.Windows.Forms.Timer(this.components);
            this.label_serialPortStatus = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.pictureBox_chipusLogo = new System.Windows.Forms.PictureBox();
            this.label_Read_ack = new System.Windows.Forms.Label();
            this.textBox_dataRead = new System.Windows.Forms.TextBox();
            this.textBox_i2cRegRead = new System.Windows.Forms.TextBox();
            this.buttonRead = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage_commands = new System.Windows.Forms.TabPage();
            this.button_testMode = new System.Windows.Forms.Button();
            this.label_testMode = new System.Windows.Forms.Label();
            this.label_maskTSD = new System.Windows.Forms.Label();
            this.button_maskTSD = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage_I2C.SuspendLayout();
            this.tabPage_about.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tabAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_chipusLogo)).BeginInit();
            this.tabPage_commands.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage_I2C);
            this.tabControl1.Controls.Add(this.tabPage_commands);
            this.tabControl1.Controls.Add(this.tabPage_about);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 151);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage_I2C
            // 
            this.tabPage_I2C.Controls.Add(this.label_Read_ack);
            this.tabPage_I2C.Controls.Add(this.textBox_dataRead);
            this.tabPage_I2C.Controls.Add(this.textBox_i2cRegRead);
            this.tabPage_I2C.Controls.Add(this.buttonRead);
            this.tabPage_I2C.Controls.Add(this.label2);
            this.tabPage_I2C.Controls.Add(this.label3);
            this.tabPage_I2C.Controls.Add(this.label_Write_ack);
            this.tabPage_I2C.Controls.Add(this.textBox_i2cDataWrite);
            this.tabPage_I2C.Controls.Add(this.textBox_i2cRegWrite);
            this.tabPage_I2C.Controls.Add(this.textBox_i2c_SlaveAddr);
            this.tabPage_I2C.Controls.Add(this.buttonWrite);
            this.tabPage_I2C.Controls.Add(this.label42);
            this.tabPage_I2C.Controls.Add(this.label57);
            this.tabPage_I2C.Controls.Add(this.label58);
            this.tabPage_I2C.Location = new System.Drawing.Point(4, 23);
            this.tabPage_I2C.Name = "tabPage_I2C";
            this.tabPage_I2C.Size = new System.Drawing.Size(802, 124);
            this.tabPage_I2C.TabIndex = 7;
            this.tabPage_I2C.Text = "I2C";
            this.tabPage_I2C.UseVisualStyleBackColor = true;
            // 
            // label_Write_ack
            // 
            this.label_Write_ack.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Write_ack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.label_Write_ack.Location = new System.Drawing.Point(146, 96);
            this.label_Write_ack.Name = "label_Write_ack";
            this.label_Write_ack.Size = new System.Drawing.Size(74, 13);
            this.label_Write_ack.TabIndex = 62;
            this.label_Write_ack.Text = "Not ACK";
            this.label_Write_ack.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox_i2cDataWrite
            // 
            this.textBox_i2cDataWrite.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_i2cDataWrite.Location = new System.Drawing.Point(120, 73);
            this.textBox_i2cDataWrite.MaxLength = 8;
            this.textBox_i2cDataWrite.Name = "textBox_i2cDataWrite";
            this.textBox_i2cDataWrite.Size = new System.Drawing.Size(100, 20);
            this.textBox_i2cDataWrite.TabIndex = 59;
            this.textBox_i2cDataWrite.Text = "00000000";
            this.textBox_i2cDataWrite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_i2cDataWrite_KeyPress);
            // 
            // textBox_i2cRegWrite
            // 
            this.textBox_i2cRegWrite.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_i2cRegWrite.Location = new System.Drawing.Point(120, 47);
            this.textBox_i2cRegWrite.MaxLength = 2;
            this.textBox_i2cRegWrite.Name = "textBox_i2cRegWrite";
            this.textBox_i2cRegWrite.Size = new System.Drawing.Size(100, 20);
            this.textBox_i2cRegWrite.TabIndex = 58;
            this.textBox_i2cRegWrite.Text = "00";
            this.textBox_i2cRegWrite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_i2cRegWrite_KeyPress);
            // 
            // textBox_i2c_SlaveAddr
            // 
            this.textBox_i2c_SlaveAddr.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_i2c_SlaveAddr.Location = new System.Drawing.Point(120, 21);
            this.textBox_i2c_SlaveAddr.MaxLength = 7;
            this.textBox_i2c_SlaveAddr.Name = "textBox_i2c_SlaveAddr";
            this.textBox_i2c_SlaveAddr.Size = new System.Drawing.Size(100, 20);
            this.textBox_i2c_SlaveAddr.TabIndex = 57;
            this.textBox_i2c_SlaveAddr.Text = "1110000";
            this.textBox_i2c_SlaveAddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_TS_i2c_addr_KeyPress);
            // 
            // buttonWrite
            // 
            this.buttonWrite.Enabled = false;
            this.buttonWrite.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWrite.Location = new System.Drawing.Point(242, 21);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(150, 75);
            this.buttonWrite.TabIndex = 56;
            this.buttonWrite.Text = "Write";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.button_TS_Click);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(64, 76);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(55, 14);
            this.label42.TabIndex = 53;
            this.label42.Text = "Data (0b):";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.Location = new System.Drawing.Point(46, 50);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(73, 14);
            this.label57.TabIndex = 52;
            this.label57.Text = "Register (0x):";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(15, 24);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(104, 14);
            this.label58.TabIndex = 51;
            this.label58.Text = "Slave Address (0b):";
            // 
            // tabPage_about
            // 
            this.tabPage_about.Controls.Add(this.label10);
            this.tabPage_about.Controls.Add(this.linkLabel_tabAbout);
            this.tabPage_about.Controls.Add(this.label_tabAbout);
            this.tabPage_about.Controls.Add(this.pictureBox_tabAbout);
            this.tabPage_about.Location = new System.Drawing.Point(4, 23);
            this.tabPage_about.Name = "tabPage_about";
            this.tabPage_about.Size = new System.Drawing.Size(802, 124);
            this.tabPage_about.TabIndex = 2;
            this.tabPage_about.Text = "About";
            this.tabPage_about.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(516, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 14);
            this.label10.TabIndex = 3;
            this.label10.Text = "Author: Augusto Hoffmann";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel_tabAbout
            // 
            this.linkLabel_tabAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel_tabAbout.AutoSize = true;
            this.linkLabel_tabAbout.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_tabAbout.Location = new System.Drawing.Point(513, 62);
            this.linkLabel_tabAbout.Name = "linkLabel_tabAbout";
            this.linkLabel_tabAbout.Size = new System.Drawing.Size(143, 14);
            this.linkLabel_tabAbout.TabIndex = 2;
            this.linkLabel_tabAbout.TabStop = true;
            this.linkLabel_tabAbout.Text = "https://www.chipus.com.br/";
            this.linkLabel_tabAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel_tabAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_tabAbout_LinkClicked);
            // 
            // label_tabAbout
            // 
            this.label_tabAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_tabAbout.AutoSize = true;
            this.label_tabAbout.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tabAbout.Location = new System.Drawing.Point(446, 22);
            this.label_tabAbout.Name = "label_tabAbout";
            this.label_tabAbout.Size = new System.Drawing.Size(276, 28);
            this.label_tabAbout.TabIndex = 1;
            this.label_tabAbout.Text = "This is a GUI developed to be used with Sambaqui EVM.\r\n© 2023 Chipus Microelectro" +
    "nics. All Rights Reserved.";
            this.label_tabAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_tabAbout
            // 
            this.pictureBox_tabAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_tabAbout.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_tabAbout.Image")));
            this.pictureBox_tabAbout.Location = new System.Drawing.Point(80, 22);
            this.pictureBox_tabAbout.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox_tabAbout.Name = "pictureBox_tabAbout";
            this.pictureBox_tabAbout.Size = new System.Drawing.Size(310, 80);
            this.pictureBox_tabAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_tabAbout.TabIndex = 0;
            this.pictureBox_tabAbout.TabStop = false;
            // 
            // timer_disconnect
            // 
            this.timer_disconnect.Enabled = true;
            this.timer_disconnect.Interval = 1000;
            this.timer_disconnect.Tick += new System.EventHandler(this.timer_disconnect_Tick);
            // 
            // label_serialPortStatus
            // 
            this.label_serialPortStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_serialPortStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_serialPortStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.label_serialPortStatus.Location = new System.Drawing.Point(688, 154);
            this.label_serialPortStatus.Name = "label_serialPortStatus";
            this.label_serialPortStatus.Size = new System.Drawing.Size(118, 20);
            this.label_serialPortStatus.TabIndex = 4;
            this.label_serialPortStatus.Text = "Disconnected";
            this.label_serialPortStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_status
            // 
            this.label_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_status.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.Location = new System.Drawing.Point(621, 155);
            this.label_status.Name = "label_status";
            this.label_status.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_status.Size = new System.Drawing.Size(70, 19);
            this.label_status.TabIndex = 5;
            this.label_status.Text = "Status:";
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox_chipusLogo
            // 
            this.pictureBox_chipusLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox_chipusLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_chipusLogo.Image")));
            this.pictureBox_chipusLogo.Location = new System.Drawing.Point(6, 153);
            this.pictureBox_chipusLogo.Name = "pictureBox_chipusLogo";
            this.pictureBox_chipusLogo.Size = new System.Drawing.Size(100, 26);
            this.pictureBox_chipusLogo.TabIndex = 3;
            this.pictureBox_chipusLogo.TabStop = false;
            // 
            // label_Read_ack
            // 
            this.label_Read_ack.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Read_ack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.label_Read_ack.Location = new System.Drawing.Point(533, 96);
            this.label_Read_ack.Name = "label_Read_ack";
            this.label_Read_ack.Size = new System.Drawing.Size(74, 13);
            this.label_Read_ack.TabIndex = 69;
            this.label_Read_ack.Text = "Not ACK";
            this.label_Read_ack.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox_dataRead
            // 
            this.textBox_dataRead.Enabled = false;
            this.textBox_dataRead.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_dataRead.Location = new System.Drawing.Point(507, 73);
            this.textBox_dataRead.MaxLength = 8;
            this.textBox_dataRead.Name = "textBox_dataRead";
            this.textBox_dataRead.ReadOnly = true;
            this.textBox_dataRead.Size = new System.Drawing.Size(100, 20);
            this.textBox_dataRead.TabIndex = 68;
            this.textBox_dataRead.Text = "00000000";
            // 
            // textBox_i2cRegRead
            // 
            this.textBox_i2cRegRead.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_i2cRegRead.Location = new System.Drawing.Point(507, 47);
            this.textBox_i2cRegRead.MaxLength = 2;
            this.textBox_i2cRegRead.Name = "textBox_i2cRegRead";
            this.textBox_i2cRegRead.Size = new System.Drawing.Size(100, 20);
            this.textBox_i2cRegRead.TabIndex = 67;
            this.textBox_i2cRegRead.Text = "00";
            this.textBox_i2cRegRead.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_i2cRegRead_KeyPress);
            // 
            // buttonRead
            // 
            this.buttonRead.Enabled = false;
            this.buttonRead.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRead.Location = new System.Drawing.Point(629, 21);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(150, 75);
            this.buttonRead.TabIndex = 66;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(451, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 65;
            this.label2.Text = "Data (0b):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(433, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 14);
            this.label3.TabIndex = 64;
            this.label3.Text = "Register (0x):";
            // 
            // tabPage_commands
            // 
            this.tabPage_commands.Controls.Add(this.label_maskTSD);
            this.tabPage_commands.Controls.Add(this.button_maskTSD);
            this.tabPage_commands.Controls.Add(this.label_testMode);
            this.tabPage_commands.Controls.Add(this.button_testMode);
            this.tabPage_commands.Location = new System.Drawing.Point(4, 23);
            this.tabPage_commands.Name = "tabPage_commands";
            this.tabPage_commands.Size = new System.Drawing.Size(802, 124);
            this.tabPage_commands.TabIndex = 8;
            this.tabPage_commands.Text = "Commands";
            this.tabPage_commands.UseVisualStyleBackColor = true;
            // 
            // button_testMode
            // 
            this.button_testMode.Location = new System.Drawing.Point(8, 8);
            this.button_testMode.Name = "button_testMode";
            this.button_testMode.Size = new System.Drawing.Size(118, 23);
            this.button_testMode.TabIndex = 0;
            this.button_testMode.Text = "Enter test mode";
            this.button_testMode.UseVisualStyleBackColor = true;
            this.button_testMode.Click += new System.EventHandler(this.button_testMode_Click);
            // 
            // label_testMode
            // 
            this.label_testMode.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_testMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.label_testMode.Location = new System.Drawing.Point(132, 12);
            this.label_testMode.Name = "label_testMode";
            this.label_testMode.Size = new System.Drawing.Size(74, 13);
            this.label_testMode.TabIndex = 63;
            this.label_testMode.Text = "Not ACK";
            // 
            // label_maskTSD
            // 
            this.label_maskTSD.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_maskTSD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.label_maskTSD.Location = new System.Drawing.Point(132, 41);
            this.label_maskTSD.Name = "label_maskTSD";
            this.label_maskTSD.Size = new System.Drawing.Size(74, 13);
            this.label_maskTSD.TabIndex = 65;
            this.label_maskTSD.Text = "Not ACK";
            // 
            // button_maskTSD
            // 
            this.button_maskTSD.Location = new System.Drawing.Point(8, 37);
            this.button_maskTSD.Name = "button_maskTSD";
            this.button_maskTSD.Size = new System.Drawing.Size(118, 23);
            this.button_maskTSD.TabIndex = 64;
            this.button_maskTSD.Text = "Mask TSD";
            this.button_maskTSD.UseVisualStyleBackColor = true;
            this.button_maskTSD.Click += new System.EventHandler(this.button_maskTSD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 182);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label_serialPortStatus);
            this.Controls.Add(this.pictureBox_chipusLogo);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Chipus - I2C R/W (x.x.x.x)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_I2C.ResumeLayout(false);
            this.tabPage_I2C.PerformLayout();
            this.tabPage_about.ResumeLayout(false);
            this.tabPage_about.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tabAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_chipusLogo)).EndInit();
            this.tabPage_commands.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.PictureBox pictureBox_chipusLogo;
        private System.Windows.Forms.TabPage tabPage_about;
        private System.Windows.Forms.LinkLabel linkLabel_tabAbout;
        private System.Windows.Forms.Label label_tabAbout;
        private System.Windows.Forms.PictureBox pictureBox_tabAbout;
        private System.Windows.Forms.Timer timer_disconnect;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage_I2C;
        private System.Windows.Forms.Label label_Write_ack;
        private System.Windows.Forms.TextBox textBox_i2cDataWrite;
        private System.Windows.Forms.TextBox textBox_i2cRegWrite;
        private System.Windows.Forms.TextBox textBox_i2c_SlaveAddr;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label_serialPortStatus;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_Read_ack;
        private System.Windows.Forms.TextBox textBox_dataRead;
        private System.Windows.Forms.TextBox textBox_i2cRegRead;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage_commands;
        private System.Windows.Forms.Label label_testMode;
        private System.Windows.Forms.Button button_testMode;
        private System.Windows.Forms.Label label_maskTSD;
        private System.Windows.Forms.Button button_maskTSD;
    }
}

