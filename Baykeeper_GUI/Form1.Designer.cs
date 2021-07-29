
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
            this.comboBox_serialPorts = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label_serialPortStatus = new System.Windows.Forms.Label();
            this.button_serialPorts = new System.Windows.Forms.Button();
            this.label_serialPorts = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.linkLabel_tabAbout = new System.Windows.Forms.LinkLabel();
            this.label_tabAbout = new System.Windows.Forms.Label();
            this.pictureBox_tabAbout = new System.Windows.Forms.PictureBox();
            this.label_copyright = new System.Windows.Forms.Label();
            this.pictureBox_chipusLogo = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button_outputAllOn = new System.Windows.Forms.Button();
            this.button_outputAllOff = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_statusVDCDC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_statusVDCDC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_statusLDO3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_statusLDO2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_statusLDO1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tabAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_chipusLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_serialPorts
            // 
            this.comboBox_serialPorts.FormattingEnabled = true;
            this.comboBox_serialPorts.Location = new System.Drawing.Point(8, 30);
            this.comboBox_serialPorts.Name = "comboBox_serialPorts";
            this.comboBox_serialPorts.Size = new System.Drawing.Size(121, 21);
            this.comboBox_serialPorts.TabIndex = 0;
            this.comboBox_serialPorts.SelectedIndexChanged += new System.EventHandler(this.comboBox_serialPorts_SelectedIndexChanged);
            this.comboBox_serialPorts.Click += new System.EventHandler(this.comboBox_serialPorts_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(786, 533);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label_serialPortStatus);
            this.tabPage1.Controls.Add(this.button_serialPorts);
            this.tabPage1.Controls.Add(this.label_serialPorts);
            this.tabPage1.Controls.Add(this.comboBox_serialPorts);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(778, 507);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Configuration";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label_serialPortStatus
            // 
            this.label_serialPortStatus.AutoSize = true;
            this.label_serialPortStatus.ForeColor = System.Drawing.Color.Red;
            this.label_serialPortStatus.Location = new System.Drawing.Point(8, 54);
            this.label_serialPortStatus.Name = "label_serialPortStatus";
            this.label_serialPortStatus.Size = new System.Drawing.Size(73, 13);
            this.label_serialPortStatus.TabIndex = 3;
            this.label_serialPortStatus.Text = "Disconnected";
            // 
            // button_serialPorts
            // 
            this.button_serialPorts.Enabled = false;
            this.button_serialPorts.Location = new System.Drawing.Point(135, 28);
            this.button_serialPorts.Name = "button_serialPorts";
            this.button_serialPorts.Size = new System.Drawing.Size(75, 23);
            this.button_serialPorts.TabIndex = 2;
            this.button_serialPorts.Text = "Connect";
            this.button_serialPorts.UseVisualStyleBackColor = true;
            this.button_serialPorts.Click += new System.EventHandler(this.button_serialPorts_Click);
            // 
            // label_serialPorts
            // 
            this.label_serialPorts.AutoSize = true;
            this.label_serialPorts.Location = new System.Drawing.Point(8, 14);
            this.label_serialPorts.Name = "label_serialPorts";
            this.label_serialPorts.Size = new System.Drawing.Size(88, 13);
            this.label_serialPorts.TabIndex = 1;
            this.label_serialPorts.Text = "Select serial port:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_outputAllOff);
            this.tabPage2.Controls.Add(this.button_outputAllOn);
            this.tabPage2.Controls.Add(this.label_outputStatus);
            this.tabPage2.Controls.Add(this.label_outputVDCDC2);
            this.tabPage2.Controls.Add(this.label_outputVDCDC1);
            this.tabPage2.Controls.Add(this.label_outputLDO3);
            this.tabPage2.Controls.Add(this.label_outputLDO2);
            this.tabPage2.Controls.Add(this.button_outputVDCDC2);
            this.tabPage2.Controls.Add(this.button_outputVDCDC1);
            this.tabPage2.Controls.Add(this.button_outputLDO3);
            this.tabPage2.Controls.Add(this.button_outputLDO2);
            this.tabPage2.Controls.Add(this.pictureBox_statusVDCDC2);
            this.tabPage2.Controls.Add(this.pictureBox_statusVDCDC1);
            this.tabPage2.Controls.Add(this.pictureBox_statusLDO3);
            this.tabPage2.Controls.Add(this.pictureBox_statusLDO2);
            this.tabPage2.Controls.Add(this.label_outputLDO1);
            this.tabPage2.Controls.Add(this.button_outputLDO1);
            this.tabPage2.Controls.Add(this.pictureBox_statusLDO1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(778, 507);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Outputs";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.label_outputLDO3.Location = new System.Drawing.Point(132, 173);
            this.label_outputLDO3.Name = "label_outputLDO3";
            this.label_outputLDO3.Size = new System.Drawing.Size(99, 36);
            this.label_outputLDO3.TabIndex = 12;
            this.label_outputLDO3.Text = "LDO3";
            // 
            // label_outputLDO2
            // 
            this.label_outputLDO2.AutoSize = true;
            this.label_outputLDO2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_outputLDO2.Location = new System.Drawing.Point(132, 119);
            this.label_outputLDO2.Name = "label_outputLDO2";
            this.label_outputLDO2.Size = new System.Drawing.Size(99, 36);
            this.label_outputLDO2.TabIndex = 11;
            this.label_outputLDO2.Text = "LDO2";
            // 
            // button_outputVDCDC2
            // 
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
            this.label_outputLDO1.Location = new System.Drawing.Point(132, 65);
            this.label_outputLDO1.Name = "label_outputLDO1";
            this.label_outputLDO1.Size = new System.Drawing.Size(99, 36);
            this.label_outputLDO1.TabIndex = 2;
            this.label_outputLDO1.Text = "LDO1";
            // 
            // button_outputLDO1
            // 
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.linkLabel_tabAbout);
            this.tabPage3.Controls.Add(this.label_tabAbout);
            this.tabPage3.Controls.Add(this.pictureBox_tabAbout);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(778, 507);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // linkLabel_tabAbout
            // 
            this.linkLabel_tabAbout.AutoSize = true;
            this.linkLabel_tabAbout.Location = new System.Drawing.Point(330, 276);
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
            this.label_tabAbout.Location = new System.Drawing.Point(248, 235);
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
            this.pictureBox_tabAbout.Location = new System.Drawing.Point(250, 150);
            this.pictureBox_tabAbout.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox_tabAbout.Name = "pictureBox_tabAbout";
            this.pictureBox_tabAbout.Size = new System.Drawing.Size(300, 80);
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
            // button_outputAllOn
            // 
            this.button_outputAllOn.Location = new System.Drawing.Point(284, 341);
            this.button_outputAllOn.Name = "button_outputAllOn";
            this.button_outputAllOn.Size = new System.Drawing.Size(75, 23);
            this.button_outputAllOn.TabIndex = 16;
            this.button_outputAllOn.Text = "ALL ON";
            this.button_outputAllOn.UseVisualStyleBackColor = true;
            this.button_outputAllOn.Click += new System.EventHandler(this.button_outputAllOn_Click);
            // 
            // button_outputAllOff
            // 
            this.button_outputAllOff.Location = new System.Drawing.Point(284, 395);
            this.button_outputAllOff.Name = "button_outputAllOff";
            this.button_outputAllOff.Size = new System.Drawing.Size(75, 23);
            this.button_outputAllOff.TabIndex = 17;
            this.button_outputAllOff.Text = "ALL OFF";
            this.button_outputAllOff.UseVisualStyleBackColor = true;
            this.button_outputAllOff.Click += new System.EventHandler(this.button_outputAllOff_Click);
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_statusVDCDC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_statusVDCDC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_statusLDO3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_statusLDO2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_statusLDO1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tabAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_chipusLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_serialPorts;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label_serialPortStatus;
        private System.Windows.Forms.Button button_serialPorts;
        private System.Windows.Forms.Label label_serialPorts;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label_copyright;
        private System.Windows.Forms.PictureBox pictureBox_chipusLogo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.LinkLabel linkLabel_tabAbout;
        private System.Windows.Forms.Label label_tabAbout;
        private System.Windows.Forms.PictureBox pictureBox_tabAbout;
        private System.IO.Ports.SerialPort serialPort1;
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
        private System.Windows.Forms.Button button_outputLDO1;
        private System.Windows.Forms.PictureBox pictureBox_statusLDO1;
        private System.Windows.Forms.Label label_outputStatus;
        private System.Windows.Forms.Button button_outputAllOn;
        private System.Windows.Forms.Button button_outputAllOff;
    }
}

