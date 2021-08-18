﻿
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
            this.tabPage_config = new System.Windows.Forms.TabPage();
            this.label_serialPortStatus = new System.Windows.Forms.Label();
            this.button_serialPorts = new System.Windows.Forms.Button();
            this.label_serialPorts = new System.Windows.Forms.Label();
            this.tabPage_outputs = new System.Windows.Forms.TabPage();
            this.label_ADRL = new System.Windows.Forms.Label();
            this.label_ADRM = new System.Windows.Forms.Label();
            this.label_ADRH = new System.Windows.Forms.Label();
            this.button_readI2C = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_outputAllOff = new System.Windows.Forms.Button();
            this.button_outputAllOn = new System.Windows.Forms.Button();
            this.label_outputStatus = new System.Windows.Forms.Label();
            this.label_outputVDCDC2 = new System.Windows.Forms.Label();
            this.label_outputVDCDC1 = new System.Windows.Forms.Label();
            this.label_outputLDO3 = new System.Windows.Forms.Label();
            this.label_outputLDO2 = new System.Windows.Forms.Label();
            this.button_outputVDCDC2 = new System.Windows.Forms.Button();
            this.button_outputVDCDC1 = new System.Windows.Forms.Button();
            this.button_outputLDO3 = new System.Windows.Forms.Button();
            this.button_outputLDO2 = new System.Windows.Forms.Button();
            this.pictureBox_statusVDCDC2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_statusVDCDC1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_statusLDO3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_statusLDO2 = new System.Windows.Forms.PictureBox();
            this.label_outputLDO1 = new System.Windows.Forms.Label();
            this.button_outputLDO1 = new System.Windows.Forms.Button();
            this.pictureBox_statusLDO1 = new System.Windows.Forms.PictureBox();
            this.tabPage_battery = new System.Windows.Forms.TabPage();
            this.label_battery = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabPage_about = new System.Windows.Forms.TabPage();
            this.linkLabel_tabAbout = new System.Windows.Forms.LinkLabel();
            this.label_tabAbout = new System.Windows.Forms.Label();
            this.pictureBox_tabAbout = new System.Windows.Forms.PictureBox();
            this.label_copyright = new System.Windows.Forms.Label();
            this.pictureBox_chipusLogo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage_config.SuspendLayout();
            this.tabPage_outputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_statusVDCDC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_statusVDCDC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_statusLDO3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_statusLDO2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_statusLDO1)).BeginInit();
            this.tabPage_battery.SuspendLayout();
            this.tabPage_about.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tabAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_chipusLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_config);
            this.tabControl1.Controls.Add(this.tabPage_outputs);
            this.tabControl1.Controls.Add(this.tabPage_battery);
            this.tabControl1.Controls.Add(this.tabPage_about);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(786, 533);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage_config
            // 
            this.tabPage_config.Controls.Add(this.label_serialPortStatus);
            this.tabPage_config.Controls.Add(this.button_serialPorts);
            this.tabPage_config.Controls.Add(this.label_serialPorts);
            this.tabPage_config.Location = new System.Drawing.Point(4, 22);
            this.tabPage_config.Name = "tabPage_config";
            this.tabPage_config.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_config.Size = new System.Drawing.Size(778, 507);
            this.tabPage_config.TabIndex = 0;
            this.tabPage_config.Text = "Configuration";
            this.tabPage_config.UseVisualStyleBackColor = true;
            // 
            // label_serialPortStatus
            // 
            this.label_serialPortStatus.AutoSize = true;
            this.label_serialPortStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_serialPortStatus.ForeColor = System.Drawing.Color.Red;
            this.label_serialPortStatus.Location = new System.Drawing.Point(335, 289);
            this.label_serialPortStatus.Name = "label_serialPortStatus";
            this.label_serialPortStatus.Size = new System.Drawing.Size(107, 20);
            this.label_serialPortStatus.TabIndex = 3;
            this.label_serialPortStatus.Text = "Disconnected";
            this.label_serialPortStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_serialPorts
            // 
            this.button_serialPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_serialPorts.Location = new System.Drawing.Point(264, 211);
            this.button_serialPorts.Name = "button_serialPorts";
            this.button_serialPorts.Size = new System.Drawing.Size(250, 50);
            this.button_serialPorts.TabIndex = 2;
            this.button_serialPorts.Text = "Connect";
            this.button_serialPorts.UseVisualStyleBackColor = true;
            this.button_serialPorts.Click += new System.EventHandler(this.button_serialPorts_Click);
            // 
            // label_serialPorts
            // 
            this.label_serialPorts.AutoSize = true;
            this.label_serialPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_serialPorts.Location = new System.Drawing.Point(238, 143);
            this.label_serialPorts.Name = "label_serialPorts";
            this.label_serialPorts.Size = new System.Drawing.Size(313, 40);
            this.label_serialPorts.TabIndex = 1;
            this.label_serialPorts.Text = "Connect USB cable between EVM and PC.\r\nThen, click in Connect.";
            this.label_serialPorts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage_outputs
            // 
            this.tabPage_outputs.Controls.Add(this.label_ADRL);
            this.tabPage_outputs.Controls.Add(this.label_ADRM);
            this.tabPage_outputs.Controls.Add(this.label_ADRH);
            this.tabPage_outputs.Controls.Add(this.button_readI2C);
            this.tabPage_outputs.Controls.Add(this.label1);
            this.tabPage_outputs.Controls.Add(this.button_outputAllOff);
            this.tabPage_outputs.Controls.Add(this.button_outputAllOn);
            this.tabPage_outputs.Controls.Add(this.label_outputStatus);
            this.tabPage_outputs.Controls.Add(this.label_outputVDCDC2);
            this.tabPage_outputs.Controls.Add(this.label_outputVDCDC1);
            this.tabPage_outputs.Controls.Add(this.label_outputLDO3);
            this.tabPage_outputs.Controls.Add(this.label_outputLDO2);
            this.tabPage_outputs.Controls.Add(this.button_outputVDCDC2);
            this.tabPage_outputs.Controls.Add(this.button_outputVDCDC1);
            this.tabPage_outputs.Controls.Add(this.button_outputLDO3);
            this.tabPage_outputs.Controls.Add(this.button_outputLDO2);
            this.tabPage_outputs.Controls.Add(this.pictureBox_statusVDCDC2);
            this.tabPage_outputs.Controls.Add(this.pictureBox_statusVDCDC1);
            this.tabPage_outputs.Controls.Add(this.pictureBox_statusLDO3);
            this.tabPage_outputs.Controls.Add(this.pictureBox_statusLDO2);
            this.tabPage_outputs.Controls.Add(this.label_outputLDO1);
            this.tabPage_outputs.Controls.Add(this.button_outputLDO1);
            this.tabPage_outputs.Controls.Add(this.pictureBox_statusLDO1);
            this.tabPage_outputs.Location = new System.Drawing.Point(4, 22);
            this.tabPage_outputs.Name = "tabPage_outputs";
            this.tabPage_outputs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_outputs.Size = new System.Drawing.Size(778, 507);
            this.tabPage_outputs.TabIndex = 1;
            this.tabPage_outputs.Text = "Outputs";
            this.tabPage_outputs.UseVisualStyleBackColor = true;
            // 
            // label_ADRL
            // 
            this.label_ADRL.AutoSize = true;
            this.label_ADRL.Location = new System.Drawing.Point(72, 416);
            this.label_ADRL.Name = "label_ADRL";
            this.label_ADRL.Size = new System.Drawing.Size(116, 13);
            this.label_ADRL.TabIndex = 22;
            this.label_ADRL.Text = "ADRL = 0bXXXXXXXX";
            // 
            // label_ADRM
            // 
            this.label_ADRM.AutoSize = true;
            this.label_ADRM.Location = new System.Drawing.Point(72, 400);
            this.label_ADRM.Name = "label_ADRM";
            this.label_ADRM.Size = new System.Drawing.Size(119, 13);
            this.label_ADRM.TabIndex = 21;
            this.label_ADRM.Text = "ADRM = 0bXXXXXXXX";
            // 
            // label_ADRH
            // 
            this.label_ADRH.AutoSize = true;
            this.label_ADRH.Location = new System.Drawing.Point(72, 385);
            this.label_ADRH.Name = "label_ADRH";
            this.label_ADRH.Size = new System.Drawing.Size(118, 13);
            this.label_ADRH.TabIndex = 20;
            this.label_ADRH.Text = "ADRH = 0bXXXXXXXX";
            // 
            // button_readI2C
            // 
            this.button_readI2C.Location = new System.Drawing.Point(558, 411);
            this.button_readI2C.Name = "button_readI2C";
            this.button_readI2C.Size = new System.Drawing.Size(75, 23);
            this.button_readI2C.TabIndex = 19;
            this.button_readI2C.Text = "Read I2C";
            this.button_readI2C.UseVisualStyleBackColor = true;
            this.button_readI2C.Click += new System.EventHandler(this.button_readI2C_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(538, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "0bXXXXXXXX";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_outputAllOff
            // 
            this.button_outputAllOff.Enabled = false;
            this.button_outputAllOff.Location = new System.Drawing.Point(284, 395);
            this.button_outputAllOff.Name = "button_outputAllOff";
            this.button_outputAllOff.Size = new System.Drawing.Size(75, 23);
            this.button_outputAllOff.TabIndex = 17;
            this.button_outputAllOff.Text = "ALL OFF";
            this.button_outputAllOff.UseVisualStyleBackColor = true;
            this.button_outputAllOff.Click += new System.EventHandler(this.button_outputAllOff_Click);
            // 
            // button_outputAllOn
            // 
            this.button_outputAllOn.Enabled = false;
            this.button_outputAllOn.Location = new System.Drawing.Point(284, 341);
            this.button_outputAllOn.Name = "button_outputAllOn";
            this.button_outputAllOn.Size = new System.Drawing.Size(75, 23);
            this.button_outputAllOn.TabIndex = 16;
            this.button_outputAllOn.Text = "ALL ON";
            this.button_outputAllOn.UseVisualStyleBackColor = true;
            this.button_outputAllOn.Click += new System.EventHandler(this.button_outputAllOn_Click);
            // 
            // label_outputStatus
            // 
            this.label_outputStatus.AutoSize = true;
            this.label_outputStatus.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_outputStatus.Location = new System.Drawing.Point(513, 34);
            this.label_outputStatus.Name = "label_outputStatus";
            this.label_outputStatus.Size = new System.Drawing.Size(84, 22);
            this.label_outputStatus.TabIndex = 15;
            this.label_outputStatus.Text = "STATUS";
            this.label_outputStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_outputVDCDC2
            // 
            this.label_outputVDCDC2.AutoSize = true;
            this.label_outputVDCDC2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_outputVDCDC2.Location = new System.Drawing.Point(132, 281);
            this.label_outputVDCDC2.Name = "label_outputVDCDC2";
            this.label_outputVDCDC2.Size = new System.Drawing.Size(146, 36);
            this.label_outputVDCDC2.TabIndex = 14;
            this.label_outputVDCDC2.Text = "VDCDC2";
            // 
            // label_outputVDCDC1
            // 
            this.label_outputVDCDC1.AutoSize = true;
            this.label_outputVDCDC1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_outputVDCDC1.Location = new System.Drawing.Point(132, 227);
            this.label_outputVDCDC1.Name = "label_outputVDCDC1";
            this.label_outputVDCDC1.Size = new System.Drawing.Size(146, 36);
            this.label_outputVDCDC1.TabIndex = 13;
            this.label_outputVDCDC1.Text = "VDCDC1";
            // 
            // label_outputLDO3
            // 
            this.label_outputLDO3.AutoSize = true;
            this.label_outputLDO3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_outputLDO3.Location = new System.Drawing.Point(179, 173);
            this.label_outputLDO3.Name = "label_outputLDO3";
            this.label_outputLDO3.Size = new System.Drawing.Size(99, 36);
            this.label_outputLDO3.TabIndex = 12;
            this.label_outputLDO3.Text = "LDO3";
            // 
            // label_outputLDO2
            // 
            this.label_outputLDO2.AutoSize = true;
            this.label_outputLDO2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_outputLDO2.Location = new System.Drawing.Point(179, 119);
            this.label_outputLDO2.Name = "label_outputLDO2";
            this.label_outputLDO2.Size = new System.Drawing.Size(99, 36);
            this.label_outputLDO2.TabIndex = 11;
            this.label_outputLDO2.Text = "LDO2";
            // 
            // button_outputVDCDC2
            // 
            this.button_outputVDCDC2.Enabled = false;
            this.button_outputVDCDC2.Location = new System.Drawing.Point(284, 287);
            this.button_outputVDCDC2.Name = "button_outputVDCDC2";
            this.button_outputVDCDC2.Size = new System.Drawing.Size(75, 23);
            this.button_outputVDCDC2.TabIndex = 10;
            this.button_outputVDCDC2.Text = "ON";
            this.button_outputVDCDC2.UseVisualStyleBackColor = true;
            this.button_outputVDCDC2.Click += new System.EventHandler(this.button_outputVDCDC2_Click);
            // 
            // button_outputVDCDC1
            // 
            this.button_outputVDCDC1.Enabled = false;
            this.button_outputVDCDC1.Location = new System.Drawing.Point(284, 233);
            this.button_outputVDCDC1.Name = "button_outputVDCDC1";
            this.button_outputVDCDC1.Size = new System.Drawing.Size(75, 23);
            this.button_outputVDCDC1.TabIndex = 9;
            this.button_outputVDCDC1.Text = "ON";
            this.button_outputVDCDC1.UseVisualStyleBackColor = true;
            this.button_outputVDCDC1.Click += new System.EventHandler(this.button_outputVDCDC1_Click);
            // 
            // button_outputLDO3
            // 
            this.button_outputLDO3.Enabled = false;
            this.button_outputLDO3.Location = new System.Drawing.Point(284, 179);
            this.button_outputLDO3.Name = "button_outputLDO3";
            this.button_outputLDO3.Size = new System.Drawing.Size(75, 23);
            this.button_outputLDO3.TabIndex = 8;
            this.button_outputLDO3.Text = "ON";
            this.button_outputLDO3.UseVisualStyleBackColor = true;
            this.button_outputLDO3.Click += new System.EventHandler(this.button_outputLDO3_Click);
            // 
            // button_outputLDO2
            // 
            this.button_outputLDO2.Enabled = false;
            this.button_outputLDO2.Location = new System.Drawing.Point(284, 125);
            this.button_outputLDO2.Name = "button_outputLDO2";
            this.button_outputLDO2.Size = new System.Drawing.Size(75, 23);
            this.button_outputLDO2.TabIndex = 7;
            this.button_outputLDO2.Text = "ON";
            this.button_outputLDO2.UseVisualStyleBackColor = true;
            this.button_outputLDO2.Click += new System.EventHandler(this.button_outputLDO2_Click);
            // 
            // pictureBox_statusVDCDC2
            // 
            this.pictureBox_statusVDCDC2.Image = global::Baykeeper_GUI.Properties.Resources.outputStatusOff;
            this.pictureBox_statusVDCDC2.Location = new System.Drawing.Point(532, 275);
            this.pictureBox_statusVDCDC2.Name = "pictureBox_statusVDCDC2";
            this.pictureBox_statusVDCDC2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox_statusVDCDC2.TabIndex = 6;
            this.pictureBox_statusVDCDC2.TabStop = false;
            // 
            // pictureBox_statusVDCDC1
            // 
            this.pictureBox_statusVDCDC1.Image = global::Baykeeper_GUI.Properties.Resources.outputStatusOff;
            this.pictureBox_statusVDCDC1.Location = new System.Drawing.Point(532, 221);
            this.pictureBox_statusVDCDC1.Name = "pictureBox_statusVDCDC1";
            this.pictureBox_statusVDCDC1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox_statusVDCDC1.TabIndex = 5;
            this.pictureBox_statusVDCDC1.TabStop = false;
            // 
            // pictureBox_statusLDO3
            // 
            this.pictureBox_statusLDO3.Image = global::Baykeeper_GUI.Properties.Resources.outputStatusOff;
            this.pictureBox_statusLDO3.Location = new System.Drawing.Point(532, 167);
            this.pictureBox_statusLDO3.Name = "pictureBox_statusLDO3";
            this.pictureBox_statusLDO3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox_statusLDO3.TabIndex = 4;
            this.pictureBox_statusLDO3.TabStop = false;
            // 
            // pictureBox_statusLDO2
            // 
            this.pictureBox_statusLDO2.Image = global::Baykeeper_GUI.Properties.Resources.outputStatusOff;
            this.pictureBox_statusLDO2.Location = new System.Drawing.Point(532, 113);
            this.pictureBox_statusLDO2.Name = "pictureBox_statusLDO2";
            this.pictureBox_statusLDO2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox_statusLDO2.TabIndex = 3;
            this.pictureBox_statusLDO2.TabStop = false;
            // 
            // label_outputLDO1
            // 
            this.label_outputLDO1.AutoSize = true;
            this.label_outputLDO1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_outputLDO1.Location = new System.Drawing.Point(179, 65);
            this.label_outputLDO1.Name = "label_outputLDO1";
            this.label_outputLDO1.Size = new System.Drawing.Size(99, 36);
            this.label_outputLDO1.TabIndex = 2;
            this.label_outputLDO1.Text = "LDO1";
            // 
            // button_outputLDO1
            // 
            this.button_outputLDO1.Enabled = false;
            this.button_outputLDO1.Location = new System.Drawing.Point(284, 71);
            this.button_outputLDO1.Name = "button_outputLDO1";
            this.button_outputLDO1.Size = new System.Drawing.Size(75, 23);
            this.button_outputLDO1.TabIndex = 1;
            this.button_outputLDO1.Text = "ON";
            this.button_outputLDO1.UseVisualStyleBackColor = true;
            this.button_outputLDO1.Click += new System.EventHandler(this.button_outputLDO1_Click);
            // 
            // pictureBox_statusLDO1
            // 
            this.pictureBox_statusLDO1.Image = global::Baykeeper_GUI.Properties.Resources.outputStatusOff;
            this.pictureBox_statusLDO1.Location = new System.Drawing.Point(532, 59);
            this.pictureBox_statusLDO1.Name = "pictureBox_statusLDO1";
            this.pictureBox_statusLDO1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox_statusLDO1.TabIndex = 0;
            this.pictureBox_statusLDO1.TabStop = false;
            // 
            // tabPage_battery
            // 
            this.tabPage_battery.Controls.Add(this.label_battery);
            this.tabPage_battery.Controls.Add(this.progressBar1);
            this.tabPage_battery.Location = new System.Drawing.Point(4, 22);
            this.tabPage_battery.Name = "tabPage_battery";
            this.tabPage_battery.Size = new System.Drawing.Size(778, 507);
            this.tabPage_battery.TabIndex = 3;
            this.tabPage_battery.Text = "Battery Charger";
            this.tabPage_battery.UseVisualStyleBackColor = true;
            // 
            // label_battery
            // 
            this.label_battery.AutoSize = true;
            this.label_battery.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_battery.Location = new System.Drawing.Point(348, 307);
            this.label_battery.Name = "label_battery";
            this.label_battery.Size = new System.Drawing.Size(79, 36);
            this.label_battery.TabIndex = 1;
            this.label_battery.Text = "50%";
            this.label_battery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(185, 217);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(400, 50);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 50;
            // 
            // tabPage_about
            // 
            this.tabPage_about.Controls.Add(this.linkLabel_tabAbout);
            this.tabPage_about.Controls.Add(this.label_tabAbout);
            this.tabPage_about.Controls.Add(this.pictureBox_tabAbout);
            this.tabPage_about.Location = new System.Drawing.Point(4, 22);
            this.tabPage_about.Name = "tabPage_about";
            this.tabPage_about.Size = new System.Drawing.Size(778, 507);
            this.tabPage_about.TabIndex = 2;
            this.tabPage_about.Text = "About";
            this.tabPage_about.UseVisualStyleBackColor = true;
            // 
            // linkLabel_tabAbout
            // 
            this.linkLabel_tabAbout.AutoSize = true;
            this.linkLabel_tabAbout.Location = new System.Drawing.Point(310, 276);
            this.linkLabel_tabAbout.Name = "linkLabel_tabAbout";
            this.linkLabel_tabAbout.Size = new System.Drawing.Size(140, 13);
            this.linkLabel_tabAbout.TabIndex = 2;
            this.linkLabel_tabAbout.TabStop = true;
            this.linkLabel_tabAbout.Text = "https://www.chipus-ip.com/";
            this.linkLabel_tabAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel_tabAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_tabAbout_LinkClicked);
            // 
            // label_tabAbout
            // 
            this.label_tabAbout.AutoSize = true;
            this.label_tabAbout.Location = new System.Drawing.Point(228, 235);
            this.label_tabAbout.Name = "label_tabAbout";
            this.label_tabAbout.Size = new System.Drawing.Size(304, 26);
            this.label_tabAbout.TabIndex = 1;
            this.label_tabAbout.Text = "This is a GUI developed to be used with Baykeeper USB EVM.\r\nAll rights reserved.";
            this.label_tabAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_tabAbout
            // 
            this.pictureBox_tabAbout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_tabAbout.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_tabAbout.Image")));
            this.pictureBox_tabAbout.Location = new System.Drawing.Point(230, 150);
            this.pictureBox_tabAbout.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox_tabAbout.Name = "pictureBox_tabAbout";
            this.pictureBox_tabAbout.Size = new System.Drawing.Size(313, 80);
            this.pictureBox_tabAbout.TabIndex = 0;
            this.pictureBox_tabAbout.TabStop = false;
            // 
            // label_copyright
            // 
            this.label_copyright.AutoSize = true;
            this.label_copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_copyright.Location = new System.Drawing.Point(512, 539);
            this.label_copyright.Name = "label_copyright";
            this.label_copyright.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_copyright.Size = new System.Drawing.Size(260, 13);
            this.label_copyright.TabIndex = 2;
            this.label_copyright.Text = "© 2021 Chipus Microelectronics, All Rights Reserved.";
            this.label_copyright.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox_chipusLogo
            // 
            this.pictureBox_chipusLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox_chipusLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_chipusLogo.Image")));
            this.pictureBox_chipusLogo.Location = new System.Drawing.Point(12, 532);
            this.pictureBox_chipusLogo.Name = "pictureBox_chipusLogo";
            this.pictureBox_chipusLogo.Size = new System.Drawing.Size(100, 26);
            this.pictureBox_chipusLogo.TabIndex = 3;
            this.pictureBox_chipusLogo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox_chipusLogo);
            this.Controls.Add(this.label_copyright);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Baykeeper GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_config.ResumeLayout(false);
            this.tabPage_config.PerformLayout();
            this.tabPage_outputs.ResumeLayout(false);
            this.tabPage_outputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_statusVDCDC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_statusVDCDC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_statusLDO3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_statusLDO2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_statusLDO1)).EndInit();
            this.tabPage_battery.ResumeLayout(false);
            this.tabPage_battery.PerformLayout();
            this.tabPage_about.ResumeLayout(false);
            this.tabPage_about.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tabAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_chipusLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_config;
        private System.Windows.Forms.Label label_serialPortStatus;
        private System.Windows.Forms.Button button_serialPorts;
        private System.Windows.Forms.Label label_serialPorts;
        private System.Windows.Forms.TabPage tabPage_outputs;
        private System.Windows.Forms.Label label_copyright;
        private System.Windows.Forms.PictureBox pictureBox_chipusLogo;
        private System.Windows.Forms.TabPage tabPage_about;
        private System.Windows.Forms.LinkLabel linkLabel_tabAbout;
        private System.Windows.Forms.Label label_tabAbout;
        private System.Windows.Forms.PictureBox pictureBox_tabAbout;
        private System.Windows.Forms.Label label_outputVDCDC2;
        private System.Windows.Forms.Label label_outputVDCDC1;
        private System.Windows.Forms.Label label_outputLDO3;
        private System.Windows.Forms.Label label_outputLDO2;
        private System.Windows.Forms.Button button_outputVDCDC2;
        private System.Windows.Forms.Button button_outputVDCDC1;
        private System.Windows.Forms.Button button_outputLDO3;
        private System.Windows.Forms.Button button_outputLDO2;
        private System.Windows.Forms.PictureBox pictureBox_statusVDCDC2;
        private System.Windows.Forms.PictureBox pictureBox_statusVDCDC1;
        private System.Windows.Forms.PictureBox pictureBox_statusLDO3;
        private System.Windows.Forms.PictureBox pictureBox_statusLDO2;
        private System.Windows.Forms.Label label_outputLDO1;
        private System.Windows.Forms.PictureBox pictureBox_statusLDO1;
        private System.Windows.Forms.Label label_outputStatus;
        private System.Windows.Forms.Button button_outputAllOn;
        private System.Windows.Forms.Button button_outputAllOff;
        private System.Windows.Forms.Button button_outputLDO1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_readI2C;
        private System.Windows.Forms.TabPage tabPage_battery;
        private System.Windows.Forms.Label label_battery;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label_ADRH;
        private System.Windows.Forms.Label label_ADRL;
        private System.Windows.Forms.Label label_ADRM;
        private System.Windows.Forms.Timer timer1;
    }
}

