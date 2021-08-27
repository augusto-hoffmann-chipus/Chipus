
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
            this.tabPage_ADS112C04 = new System.Windows.Forms.TabPage();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label_voltage = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_readData = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ADS0x4c = new System.Windows.Forms.TextBox();
            this.textBox_ADS0x48 = new System.Windows.Forms.TextBox();
            this.textBox_ADS0x44 = new System.Windows.Forms.TextBox();
            this.textBox_ADS0x40 = new System.Windows.Forms.TextBox();
            this.label_ADSReg0x4c = new System.Windows.Forms.Label();
            this.label_ADSReg0x48 = new System.Windows.Forms.Label();
            this.label_ADSReg0x44 = new System.Windows.Forms.Label();
            this.label_ADSReg0x40 = new System.Windows.Forms.Label();
            this.button_readADS = new System.Windows.Forms.Button();
            this.button_writeADS = new System.Windows.Forms.Button();
            this.tabPage_about = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.linkLabel_tabAbout = new System.Windows.Forms.LinkLabel();
            this.label_tabAbout = new System.Windows.Forms.Label();
            this.pictureBox_tabAbout = new System.Windows.Forms.PictureBox();
            this.label_copyright = new System.Windows.Forms.Label();
            this.pictureBox_chipusLogo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_disconnect = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.tabControl1.SuspendLayout();
            this.tabPage_config.SuspendLayout();
            this.tabPage_outputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_statusVDCDC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_statusVDCDC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_statusLDO3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_statusLDO2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_statusLDO1)).BeginInit();
            this.tabPage_battery.SuspendLayout();
            this.tabPage_ADS112C04.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabPage_ADS112C04);
            this.tabControl1.Controls.Add(this.tabPage_about);
            this.tabControl1.Font = new System.Drawing.Font("Raleway SemiBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label_serialPortStatus.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_serialPortStatus.ForeColor = System.Drawing.Color.Red;
            this.label_serialPortStatus.Location = new System.Drawing.Point(309, 289);
            this.label_serialPortStatus.Name = "label_serialPortStatus";
            this.label_serialPortStatus.Size = new System.Drawing.Size(161, 20);
            this.label_serialPortStatus.TabIndex = 3;
            this.label_serialPortStatus.Text = "Disconnected";
            this.label_serialPortStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_serialPorts
            // 
            this.button_serialPorts.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label_serialPorts.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_serialPorts.Location = new System.Drawing.Point(224, 148);
            this.label_serialPorts.Name = "label_serialPorts";
            this.label_serialPorts.Size = new System.Drawing.Size(332, 38);
            this.label_serialPorts.TabIndex = 1;
            this.label_serialPorts.Text = "Connect USB cable between EVM and PC.\r\nThen, click in Connect.";
            this.label_serialPorts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage_outputs
            // 
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
            // button_outputAllOff
            // 
            this.button_outputAllOff.Enabled = false;
            this.button_outputAllOff.Font = new System.Drawing.Font("Raleway SemiBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.button_outputAllOn.Font = new System.Drawing.Font("Raleway SemiBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label_outputStatus.Font = new System.Drawing.Font("Raleway SemiBold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_outputStatus.Location = new System.Drawing.Point(513, 34);
            this.label_outputStatus.Name = "label_outputStatus";
            this.label_outputStatus.Size = new System.Drawing.Size(83, 22);
            this.label_outputStatus.TabIndex = 15;
            this.label_outputStatus.Text = "STATUS";
            this.label_outputStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_outputVDCDC2
            // 
            this.label_outputVDCDC2.AutoSize = true;
            this.label_outputVDCDC2.Font = new System.Drawing.Font("Raleway SemiBold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_outputVDCDC2.Location = new System.Drawing.Point(132, 281);
            this.label_outputVDCDC2.Name = "label_outputVDCDC2";
            this.label_outputVDCDC2.Size = new System.Drawing.Size(147, 37);
            this.label_outputVDCDC2.TabIndex = 14;
            this.label_outputVDCDC2.Text = "VDCDC2";
            // 
            // label_outputVDCDC1
            // 
            this.label_outputVDCDC1.AutoSize = true;
            this.label_outputVDCDC1.Font = new System.Drawing.Font("Raleway SemiBold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_outputVDCDC1.Location = new System.Drawing.Point(132, 227);
            this.label_outputVDCDC1.Name = "label_outputVDCDC1";
            this.label_outputVDCDC1.Size = new System.Drawing.Size(144, 37);
            this.label_outputVDCDC1.TabIndex = 13;
            this.label_outputVDCDC1.Text = "VDCDC1";
            // 
            // label_outputLDO3
            // 
            this.label_outputLDO3.AutoSize = true;
            this.label_outputLDO3.Font = new System.Drawing.Font("Raleway SemiBold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_outputLDO3.Location = new System.Drawing.Point(179, 173);
            this.label_outputLDO3.Name = "label_outputLDO3";
            this.label_outputLDO3.Size = new System.Drawing.Size(101, 37);
            this.label_outputLDO3.TabIndex = 12;
            this.label_outputLDO3.Text = "LDO3";
            // 
            // label_outputLDO2
            // 
            this.label_outputLDO2.AutoSize = true;
            this.label_outputLDO2.Font = new System.Drawing.Font("Raleway SemiBold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_outputLDO2.Location = new System.Drawing.Point(179, 119);
            this.label_outputLDO2.Name = "label_outputLDO2";
            this.label_outputLDO2.Size = new System.Drawing.Size(101, 37);
            this.label_outputLDO2.TabIndex = 11;
            this.label_outputLDO2.Text = "LDO2";
            // 
            // button_outputVDCDC2
            // 
            this.button_outputVDCDC2.Enabled = false;
            this.button_outputVDCDC2.Font = new System.Drawing.Font("Raleway SemiBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.button_outputVDCDC1.Font = new System.Drawing.Font("Raleway SemiBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.button_outputLDO3.Font = new System.Drawing.Font("Raleway SemiBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.button_outputLDO2.Font = new System.Drawing.Font("Raleway SemiBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label_outputLDO1.Font = new System.Drawing.Font("Raleway SemiBold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_outputLDO1.Location = new System.Drawing.Point(179, 65);
            this.label_outputLDO1.Name = "label_outputLDO1";
            this.label_outputLDO1.Size = new System.Drawing.Size(98, 37);
            this.label_outputLDO1.TabIndex = 2;
            this.label_outputLDO1.Text = "LDO1";
            // 
            // button_outputLDO1
            // 
            this.button_outputLDO1.Enabled = false;
            this.button_outputLDO1.Font = new System.Drawing.Font("Raleway SemiBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tabPage_battery.Controls.Add(this.progressBar1);
            this.tabPage_battery.Controls.Add(this.label_battery);
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
            this.label_battery.Font = new System.Drawing.Font("Raleway SemiBold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_battery.Location = new System.Drawing.Point(348, 307);
            this.label_battery.Name = "label_battery";
            this.label_battery.Size = new System.Drawing.Size(79, 37);
            this.label_battery.TabIndex = 1;
            this.label_battery.Text = "50%";
            this.label_battery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage_ADS112C04
            // 
            this.tabPage_ADS112C04.Controls.Add(this.textBox8);
            this.tabPage_ADS112C04.Controls.Add(this.label9);
            this.tabPage_ADS112C04.Controls.Add(this.textBox7);
            this.tabPage_ADS112C04.Controls.Add(this.label8);
            this.tabPage_ADS112C04.Controls.Add(this.label_voltage);
            this.tabPage_ADS112C04.Controls.Add(this.textBox5);
            this.tabPage_ADS112C04.Controls.Add(this.textBox6);
            this.tabPage_ADS112C04.Controls.Add(this.label6);
            this.tabPage_ADS112C04.Controls.Add(this.label7);
            this.tabPage_ADS112C04.Controls.Add(this.button_readData);
            this.tabPage_ADS112C04.Controls.Add(this.textBox1);
            this.tabPage_ADS112C04.Controls.Add(this.textBox2);
            this.tabPage_ADS112C04.Controls.Add(this.textBox3);
            this.tabPage_ADS112C04.Controls.Add(this.textBox4);
            this.tabPage_ADS112C04.Controls.Add(this.label2);
            this.tabPage_ADS112C04.Controls.Add(this.label3);
            this.tabPage_ADS112C04.Controls.Add(this.label4);
            this.tabPage_ADS112C04.Controls.Add(this.label5);
            this.tabPage_ADS112C04.Controls.Add(this.textBox_ADS0x4c);
            this.tabPage_ADS112C04.Controls.Add(this.textBox_ADS0x48);
            this.tabPage_ADS112C04.Controls.Add(this.textBox_ADS0x44);
            this.tabPage_ADS112C04.Controls.Add(this.textBox_ADS0x40);
            this.tabPage_ADS112C04.Controls.Add(this.label_ADSReg0x4c);
            this.tabPage_ADS112C04.Controls.Add(this.label_ADSReg0x48);
            this.tabPage_ADS112C04.Controls.Add(this.label_ADSReg0x44);
            this.tabPage_ADS112C04.Controls.Add(this.label_ADSReg0x40);
            this.tabPage_ADS112C04.Controls.Add(this.button_readADS);
            this.tabPage_ADS112C04.Controls.Add(this.button_writeADS);
            this.tabPage_ADS112C04.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ADS112C04.Name = "tabPage_ADS112C04";
            this.tabPage_ADS112C04.Size = new System.Drawing.Size(778, 507);
            this.tabPage_ADS112C04.TabIndex = 4;
            this.tabPage_ADS112C04.Text = "ADS112C04";
            this.tabPage_ADS112C04.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(617, 357);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 27;
            this.textBox8.Text = "2,048";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(581, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "VREF";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(617, 331);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 25;
            this.textBox7.Text = "128";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(581, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "GAIN";
            // 
            // label_voltage
            // 
            this.label_voltage.AutoSize = true;
            this.label_voltage.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_voltage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_voltage.Location = new System.Drawing.Point(468, 398);
            this.label_voltage.Name = "label_voltage";
            this.label_voltage.Size = new System.Drawing.Size(93, 24);
            this.label_voltage.TabIndex = 23;
            this.label_voltage.Text = "X.XX mV";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(472, 357);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 22;
            this.textBox5.Text = "00";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(472, 331);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 21;
            this.textBox6.Text = "00";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "LSB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "MSB";
            // 
            // button_readData
            // 
            this.button_readData.Location = new System.Drawing.Point(497, 302);
            this.button_readData.Name = "button_readData";
            this.button_readData.Size = new System.Drawing.Size(75, 23);
            this.button_readData.TabIndex = 18;
            this.button_readData.Text = "Read Data";
            this.button_readData.UseVisualStyleBackColor = true;
            this.button_readData.Click += new System.EventHandler(this.button_readData_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(472, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "00";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(472, 185);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = "00";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(472, 159);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 15;
            this.textBox3.Text = "00";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(472, 133);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "00";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "0x4c";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "0x48";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "0x44";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "0x40";
            // 
            // textBox_ADS0x4c
            // 
            this.textBox_ADS0x4c.Location = new System.Drawing.Point(109, 211);
            this.textBox_ADS0x4c.Name = "textBox_ADS0x4c";
            this.textBox_ADS0x4c.Size = new System.Drawing.Size(100, 20);
            this.textBox_ADS0x4c.TabIndex = 9;
            this.textBox_ADS0x4c.Text = "00";
            this.textBox_ADS0x4c.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_ADS0x48
            // 
            this.textBox_ADS0x48.Location = new System.Drawing.Point(109, 185);
            this.textBox_ADS0x48.Name = "textBox_ADS0x48";
            this.textBox_ADS0x48.Size = new System.Drawing.Size(100, 20);
            this.textBox_ADS0x48.TabIndex = 8;
            this.textBox_ADS0x48.Text = "00";
            this.textBox_ADS0x48.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_ADS0x44
            // 
            this.textBox_ADS0x44.Location = new System.Drawing.Point(109, 159);
            this.textBox_ADS0x44.Name = "textBox_ADS0x44";
            this.textBox_ADS0x44.Size = new System.Drawing.Size(100, 20);
            this.textBox_ADS0x44.TabIndex = 7;
            this.textBox_ADS0x44.Text = "68";
            this.textBox_ADS0x44.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_ADS0x40
            // 
            this.textBox_ADS0x40.Location = new System.Drawing.Point(109, 133);
            this.textBox_ADS0x40.Name = "textBox_ADS0x40";
            this.textBox_ADS0x40.Size = new System.Drawing.Size(100, 20);
            this.textBox_ADS0x40.TabIndex = 6;
            this.textBox_ADS0x40.Text = "0e";
            this.textBox_ADS0x40.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_ADSReg0x4c
            // 
            this.label_ADSReg0x4c.AutoSize = true;
            this.label_ADSReg0x4c.Location = new System.Drawing.Point(73, 214);
            this.label_ADSReg0x4c.Name = "label_ADSReg0x4c";
            this.label_ADSReg0x4c.Size = new System.Drawing.Size(32, 13);
            this.label_ADSReg0x4c.TabIndex = 5;
            this.label_ADSReg0x4c.Text = "0x4c";
            // 
            // label_ADSReg0x48
            // 
            this.label_ADSReg0x48.AutoSize = true;
            this.label_ADSReg0x48.Location = new System.Drawing.Point(73, 188);
            this.label_ADSReg0x48.Name = "label_ADSReg0x48";
            this.label_ADSReg0x48.Size = new System.Drawing.Size(33, 13);
            this.label_ADSReg0x48.TabIndex = 4;
            this.label_ADSReg0x48.Text = "0x48";
            // 
            // label_ADSReg0x44
            // 
            this.label_ADSReg0x44.AutoSize = true;
            this.label_ADSReg0x44.Location = new System.Drawing.Point(73, 162);
            this.label_ADSReg0x44.Name = "label_ADSReg0x44";
            this.label_ADSReg0x44.Size = new System.Drawing.Size(32, 13);
            this.label_ADSReg0x44.TabIndex = 3;
            this.label_ADSReg0x44.Text = "0x44";
            // 
            // label_ADSReg0x40
            // 
            this.label_ADSReg0x40.AutoSize = true;
            this.label_ADSReg0x40.Location = new System.Drawing.Point(73, 136);
            this.label_ADSReg0x40.Name = "label_ADSReg0x40";
            this.label_ADSReg0x40.Size = new System.Drawing.Size(33, 13);
            this.label_ADSReg0x40.TabIndex = 2;
            this.label_ADSReg0x40.Text = "0x40";
            // 
            // button_readADS
            // 
            this.button_readADS.Location = new System.Drawing.Point(497, 237);
            this.button_readADS.Name = "button_readADS";
            this.button_readADS.Size = new System.Drawing.Size(75, 23);
            this.button_readADS.TabIndex = 1;
            this.button_readADS.Text = "Read Back";
            this.button_readADS.UseVisualStyleBackColor = true;
            this.button_readADS.Click += new System.EventHandler(this.button_readADS_Click);
            // 
            // button_writeADS
            // 
            this.button_writeADS.Location = new System.Drawing.Point(134, 237);
            this.button_writeADS.Name = "button_writeADS";
            this.button_writeADS.Size = new System.Drawing.Size(75, 23);
            this.button_writeADS.TabIndex = 0;
            this.button_writeADS.Text = "Write";
            this.button_writeADS.UseVisualStyleBackColor = true;
            this.button_writeADS.Click += new System.EventHandler(this.button_writeADS_Click);
            // 
            // tabPage_about
            // 
            this.tabPage_about.Controls.Add(this.label10);
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Raleway SemiBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(329, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Author: A. Hoffmann";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel_tabAbout
            // 
            this.linkLabel_tabAbout.AutoSize = true;
            this.linkLabel_tabAbout.Font = new System.Drawing.Font("Raleway SemiBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_tabAbout.Location = new System.Drawing.Point(309, 276);
            this.linkLabel_tabAbout.Name = "linkLabel_tabAbout";
            this.linkLabel_tabAbout.Size = new System.Drawing.Size(157, 13);
            this.linkLabel_tabAbout.TabIndex = 2;
            this.linkLabel_tabAbout.TabStop = true;
            this.linkLabel_tabAbout.Text = "https://www.chipus-ip.com/";
            this.linkLabel_tabAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel_tabAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_tabAbout_LinkClicked);
            // 
            // label_tabAbout
            // 
            this.label_tabAbout.AutoSize = true;
            this.label_tabAbout.Font = new System.Drawing.Font("Raleway SemiBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tabAbout.Location = new System.Drawing.Point(220, 240);
            this.label_tabAbout.Name = "label_tabAbout";
            this.label_tabAbout.Size = new System.Drawing.Size(332, 26);
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
            this.label_copyright.Font = new System.Drawing.Font("Raleway SemiBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_copyright.Location = new System.Drawing.Point(494, 539);
            this.label_copyright.Name = "label_copyright";
            this.label_copyright.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_copyright.Size = new System.Drawing.Size(284, 13);
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
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer_disconnect
            // 
            this.timer_disconnect.Interval = 1000;
            this.timer_disconnect.Tick += new System.EventHandler(this.timer_disconnect_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(185, 237);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(400, 50);
            this.progressBar1.Style = MetroFramework.MetroColorStyle.Red;
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Value = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox_chipusLogo);
            this.Controls.Add(this.label_copyright);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Chipus - Baykeeper GUI";
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
            this.tabPage_ADS112C04.ResumeLayout(false);
            this.tabPage_ADS112C04.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage_battery;
        private System.Windows.Forms.Label label_battery;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPage_ADS112C04;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ADS0x4c;
        private System.Windows.Forms.TextBox textBox_ADS0x48;
        private System.Windows.Forms.TextBox textBox_ADS0x44;
        private System.Windows.Forms.TextBox textBox_ADS0x40;
        private System.Windows.Forms.Label label_ADSReg0x4c;
        private System.Windows.Forms.Label label_ADSReg0x48;
        private System.Windows.Forms.Label label_ADSReg0x44;
        private System.Windows.Forms.Label label_ADSReg0x40;
        private System.Windows.Forms.Button button_readADS;
        private System.Windows.Forms.Button button_writeADS;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_readData;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_voltage;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer_disconnect;
        private System.Windows.Forms.Label label10;
        private MetroFramework.Controls.MetroProgressBar progressBar1;
    }
}

