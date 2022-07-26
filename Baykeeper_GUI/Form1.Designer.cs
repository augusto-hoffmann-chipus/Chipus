
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
            this.tabPage_TS = new System.Windows.Forms.TabPage();
            this.button_TS_MSB_help = new System.Windows.Forms.Button();
            this.label_TS_temperature = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_boardID = new System.Windows.Forms.Label();
            this.label_TS_LSB = new System.Windows.Forms.Label();
            this.textBox_TS_LSB = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label_TS_MSB = new System.Windows.Forms.Label();
            this.textBox_TS_MSB = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label_TS_trim0 = new System.Windows.Forms.Label();
            this.textBox_TS_trim0 = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label_TS_trim1 = new System.Windows.Forms.Label();
            this.label_TS_ack = new System.Windows.Forms.Label();
            this.textBox_TS_trim1 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox_TS_i2c_addr = new System.Windows.Forms.TextBox();
            this.button_TS = new System.Windows.Forms.Button();
            this.label40 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.tabPage_trimmingEq = new System.Windows.Forms.TabPage();
            this.tabPage_about = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.linkLabel_tabAbout = new System.Windows.Forms.LinkLabel();
            this.label_tabAbout = new System.Windows.Forms.Label();
            this.timer_disconnect = new System.Windows.Forms.Timer(this.components);
            this.timer_TS_refresh = new System.Windows.Forms.Timer(this.components);
            this.timer_TS_task = new System.Windows.Forms.Timer(this.components);
            this.label_serialPortStatus = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.pictureBox_chipusLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox_temperature = new System.Windows.Forms.PictureBox();
            this.pictureBox_boardID = new System.Windows.Forms.PictureBox();
            this.pictureBox_equation = new System.Windows.Forms.PictureBox();
            this.pictureBox_tabAbout = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage_TS.SuspendLayout();
            this.tabPage_trimmingEq.SuspendLayout();
            this.tabPage_about.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_chipusLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_temperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_boardID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_equation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tabAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_TS);
            this.tabControl1.Controls.Add(this.tabPage_trimmingEq);
            this.tabControl1.Controls.Add(this.tabPage_about);
            this.tabControl1.Font = new System.Drawing.Font("Raleway SemiBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(731, 260);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage_TS
            // 
            this.tabPage_TS.Controls.Add(this.button_TS_MSB_help);
            this.tabPage_TS.Controls.Add(this.label_TS_temperature);
            this.tabPage_TS.Controls.Add(this.label1);
            this.tabPage_TS.Controls.Add(this.label_boardID);
            this.tabPage_TS.Controls.Add(this.label_TS_LSB);
            this.tabPage_TS.Controls.Add(this.textBox_TS_LSB);
            this.tabPage_TS.Controls.Add(this.label17);
            this.tabPage_TS.Controls.Add(this.label_TS_MSB);
            this.tabPage_TS.Controls.Add(this.textBox_TS_MSB);
            this.tabPage_TS.Controls.Add(this.label31);
            this.tabPage_TS.Controls.Add(this.label_TS_trim0);
            this.tabPage_TS.Controls.Add(this.textBox_TS_trim0);
            this.tabPage_TS.Controls.Add(this.label36);
            this.tabPage_TS.Controls.Add(this.label_TS_trim1);
            this.tabPage_TS.Controls.Add(this.label_TS_ack);
            this.tabPage_TS.Controls.Add(this.textBox_TS_trim1);
            this.tabPage_TS.Controls.Add(this.textBox17);
            this.tabPage_TS.Controls.Add(this.textBox18);
            this.tabPage_TS.Controls.Add(this.textBox_TS_i2c_addr);
            this.tabPage_TS.Controls.Add(this.button_TS);
            this.tabPage_TS.Controls.Add(this.label40);
            this.tabPage_TS.Controls.Add(this.label42);
            this.tabPage_TS.Controls.Add(this.label57);
            this.tabPage_TS.Controls.Add(this.label58);
            this.tabPage_TS.Controls.Add(this.pictureBox_temperature);
            this.tabPage_TS.Controls.Add(this.pictureBox_boardID);
            this.tabPage_TS.Location = new System.Drawing.Point(4, 22);
            this.tabPage_TS.Name = "tabPage_TS";
            this.tabPage_TS.Size = new System.Drawing.Size(723, 234);
            this.tabPage_TS.TabIndex = 7;
            this.tabPage_TS.Text = "Temperature Sensor";
            this.tabPage_TS.UseVisualStyleBackColor = true;
            // 
            // button_TS_MSB_help
            // 
            this.button_TS_MSB_help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_TS_MSB_help.Location = new System.Drawing.Point(90, 152);
            this.button_TS_MSB_help.Name = "button_TS_MSB_help";
            this.button_TS_MSB_help.Size = new System.Drawing.Size(20, 23);
            this.button_TS_MSB_help.TabIndex = 86;
            this.button_TS_MSB_help.Text = "?";
            this.button_TS_MSB_help.UseVisualStyleBackColor = true;
            this.button_TS_MSB_help.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_TS_temperature
            // 
            this.label_TS_temperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_TS_temperature.Font = new System.Drawing.Font("Raleway SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TS_temperature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(46)))), ((int)(((byte)(44)))));
            this.label_TS_temperature.Location = new System.Drawing.Point(522, 182);
            this.label_TS_temperature.Name = "label_TS_temperature";
            this.label_TS_temperature.Size = new System.Drawing.Size(139, 30);
            this.label_TS_temperature.TabIndex = 79;
            this.label_TS_temperature.Text = "XXX.XXXX";
            this.label_TS_temperature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Raleway SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(46)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(651, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 30);
            this.label1.TabIndex = 85;
            this.label1.Text = "°C";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_boardID
            // 
            this.label_boardID.Font = new System.Drawing.Font("Raleway SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_boardID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(46)))), ((int)(((byte)(44)))));
            this.label_boardID.Location = new System.Drawing.Point(580, 66);
            this.label_boardID.Name = "label_boardID";
            this.label_boardID.Size = new System.Drawing.Size(80, 30);
            this.label_boardID.TabIndex = 81;
            this.label_boardID.Text = "---";
            this.label_boardID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_TS_LSB
            // 
            this.label_TS_LSB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_TS_LSB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.label_TS_LSB.Location = new System.Drawing.Point(335, 202);
            this.label_TS_LSB.Name = "label_TS_LSB";
            this.label_TS_LSB.Size = new System.Drawing.Size(57, 13);
            this.label_TS_LSB.TabIndex = 78;
            this.label_TS_LSB.Text = "Not ACK";
            this.label_TS_LSB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox_TS_LSB
            // 
            this.textBox_TS_LSB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_TS_LSB.Enabled = false;
            this.textBox_TS_LSB.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TS_LSB.Location = new System.Drawing.Point(292, 179);
            this.textBox_TS_LSB.MaxLength = 8;
            this.textBox_TS_LSB.Name = "textBox_TS_LSB";
            this.textBox_TS_LSB.ReadOnly = true;
            this.textBox_TS_LSB.Size = new System.Drawing.Size(100, 20);
            this.textBox_TS_LSB.TabIndex = 77;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.Location = new System.Drawing.Point(231, 186);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 13);
            this.label17.TabIndex = 75;
            this.label17.Text = "LSB (0b):";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_TS_MSB
            // 
            this.label_TS_MSB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_TS_MSB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.label_TS_MSB.Location = new System.Drawing.Point(163, 202);
            this.label_TS_MSB.Name = "label_TS_MSB";
            this.label_TS_MSB.Size = new System.Drawing.Size(57, 13);
            this.label_TS_MSB.TabIndex = 73;
            this.label_TS_MSB.Text = "Not ACK";
            this.label_TS_MSB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox_TS_MSB
            // 
            this.textBox_TS_MSB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_TS_MSB.Enabled = false;
            this.textBox_TS_MSB.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TS_MSB.Location = new System.Drawing.Point(120, 179);
            this.textBox_TS_MSB.MaxLength = 8;
            this.textBox_TS_MSB.Name = "textBox_TS_MSB";
            this.textBox_TS_MSB.ReadOnly = true;
            this.textBox_TS_MSB.Size = new System.Drawing.Size(100, 20);
            this.textBox_TS_MSB.TabIndex = 72;
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label31.Location = new System.Drawing.Point(42, 186);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(72, 13);
            this.label31.TabIndex = 70;
            this.label31.Text = "MSB (0b):";
            this.label31.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_TS_trim0
            // 
            this.label_TS_trim0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_TS_trim0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.label_TS_trim0.Location = new System.Drawing.Point(335, 155);
            this.label_TS_trim0.Name = "label_TS_trim0";
            this.label_TS_trim0.Size = new System.Drawing.Size(57, 13);
            this.label_TS_trim0.TabIndex = 68;
            this.label_TS_trim0.Text = "Not ACK";
            this.label_TS_trim0.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox_TS_trim0
            // 
            this.textBox_TS_trim0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_TS_trim0.Enabled = false;
            this.textBox_TS_trim0.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TS_trim0.Location = new System.Drawing.Point(292, 132);
            this.textBox_TS_trim0.MaxLength = 8;
            this.textBox_TS_trim0.Name = "textBox_TS_trim0";
            this.textBox_TS_trim0.Size = new System.Drawing.Size(100, 20);
            this.textBox_TS_trim0.TabIndex = 67;
            this.textBox_TS_trim0.Text = "11111111";
            this.textBox_TS_trim0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_TS_trim0_KeyPress);
            // 
            // label36
            // 
            this.label36.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label36.Location = new System.Drawing.Point(226, 139);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(60, 13);
            this.label36.TabIndex = 65;
            this.label36.Text = "Trim0 (0b)";
            this.label36.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_TS_trim1
            // 
            this.label_TS_trim1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_TS_trim1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.label_TS_trim1.Location = new System.Drawing.Point(163, 155);
            this.label_TS_trim1.Name = "label_TS_trim1";
            this.label_TS_trim1.Size = new System.Drawing.Size(57, 13);
            this.label_TS_trim1.TabIndex = 63;
            this.label_TS_trim1.Text = "Not ACK";
            this.label_TS_trim1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_TS_ack
            // 
            this.label_TS_ack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.label_TS_ack.Location = new System.Drawing.Point(146, 96);
            this.label_TS_ack.Name = "label_TS_ack";
            this.label_TS_ack.Size = new System.Drawing.Size(74, 13);
            this.label_TS_ack.TabIndex = 62;
            this.label_TS_ack.Text = "Not ACK";
            this.label_TS_ack.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox_TS_trim1
            // 
            this.textBox_TS_trim1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_TS_trim1.Enabled = false;
            this.textBox_TS_trim1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TS_trim1.Location = new System.Drawing.Point(120, 132);
            this.textBox_TS_trim1.MaxLength = 8;
            this.textBox_TS_trim1.Name = "textBox_TS_trim1";
            this.textBox_TS_trim1.Size = new System.Drawing.Size(100, 20);
            this.textBox_TS_trim1.TabIndex = 61;
            this.textBox_TS_trim1.Text = "00110001";
            this.textBox_TS_trim1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_TS_trim1_KeyPress);
            // 
            // textBox17
            // 
            this.textBox17.Enabled = false;
            this.textBox17.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox17.Location = new System.Drawing.Point(120, 73);
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new System.Drawing.Size(100, 20);
            this.textBox17.TabIndex = 59;
            this.textBox17.Text = "FF";
            // 
            // textBox18
            // 
            this.textBox18.Enabled = false;
            this.textBox18.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox18.Location = new System.Drawing.Point(120, 47);
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            this.textBox18.Size = new System.Drawing.Size(100, 20);
            this.textBox18.TabIndex = 58;
            this.textBox18.Text = "00";
            // 
            // textBox_TS_i2c_addr
            // 
            this.textBox_TS_i2c_addr.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TS_i2c_addr.Location = new System.Drawing.Point(120, 21);
            this.textBox_TS_i2c_addr.MaxLength = 2;
            this.textBox_TS_i2c_addr.Name = "textBox_TS_i2c_addr";
            this.textBox_TS_i2c_addr.Size = new System.Drawing.Size(100, 20);
            this.textBox_TS_i2c_addr.TabIndex = 57;
            this.textBox_TS_i2c_addr.Text = "44";
            this.textBox_TS_i2c_addr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_TS_i2c_addr_KeyPress);
            // 
            // button_TS
            // 
            this.button_TS.Font = new System.Drawing.Font("Raleway", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TS.Location = new System.Drawing.Point(242, 21);
            this.button_TS.Name = "button_TS";
            this.button_TS.Size = new System.Drawing.Size(150, 75);
            this.button_TS.TabIndex = 56;
            this.button_TS.Text = "Start Conversion";
            this.button_TS.UseVisualStyleBackColor = true;
            this.button_TS.Click += new System.EventHandler(this.button_TS_Click);
            // 
            // label40
            // 
            this.label40.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label40.Location = new System.Drawing.Point(30, 139);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(84, 13);
            this.label40.TabIndex = 55;
            this.label40.Text = "Trim1 (0b):";
            this.label40.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(59, 80);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(55, 13);
            this.label42.TabIndex = 53;
            this.label42.Text = "Data (0x):";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(39, 54);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(75, 13);
            this.label57.TabIndex = 52;
            this.label57.Text = "Register (0x):";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(9, 28);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(105, 13);
            this.label58.TabIndex = 51;
            this.label58.Text = "Slave Address (0x):";
            // 
            // tabPage_trimmingEq
            // 
            this.tabPage_trimmingEq.Controls.Add(this.pictureBox_equation);
            this.tabPage_trimmingEq.Location = new System.Drawing.Point(4, 22);
            this.tabPage_trimmingEq.Name = "tabPage_trimmingEq";
            this.tabPage_trimmingEq.Size = new System.Drawing.Size(723, 234);
            this.tabPage_trimmingEq.TabIndex = 8;
            this.tabPage_trimmingEq.Text = "Trimming Equation";
            this.tabPage_trimmingEq.UseVisualStyleBackColor = true;
            // 
            // tabPage_about
            // 
            this.tabPage_about.Controls.Add(this.label10);
            this.tabPage_about.Controls.Add(this.linkLabel_tabAbout);
            this.tabPage_about.Controls.Add(this.label_tabAbout);
            this.tabPage_about.Controls.Add(this.pictureBox_tabAbout);
            this.tabPage_about.Location = new System.Drawing.Point(4, 22);
            this.tabPage_about.Name = "tabPage_about";
            this.tabPage_about.Size = new System.Drawing.Size(723, 234);
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
            this.label10.Font = new System.Drawing.Font("Raleway SemiBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(288, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 13);
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
            this.linkLabel_tabAbout.Font = new System.Drawing.Font("Raleway SemiBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_tabAbout.Location = new System.Drawing.Point(284, 166);
            this.linkLabel_tabAbout.Name = "linkLabel_tabAbout";
            this.linkLabel_tabAbout.Size = new System.Drawing.Size(154, 13);
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
            this.label_tabAbout.Font = new System.Drawing.Font("Raleway SemiBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tabAbout.Location = new System.Drawing.Point(210, 125);
            this.label_tabAbout.Name = "label_tabAbout";
            this.label_tabAbout.Size = new System.Drawing.Size(303, 26);
            this.label_tabAbout.TabIndex = 1;
            this.label_tabAbout.Text = "This is a GUI developed to be used with Sambaqui EVM.\r\n© 2022 Chipus Microelectro" +
    "nics. All Rights Reserved.";
            this.label_tabAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_disconnect
            // 
            this.timer_disconnect.Enabled = true;
            this.timer_disconnect.Interval = 1000;
            this.timer_disconnect.Tick += new System.EventHandler(this.timer_disconnect_Tick);
            // 
            // timer_TS_refresh
            // 
            this.timer_TS_refresh.Interval = 500;
            this.timer_TS_refresh.Tick += new System.EventHandler(this.timer_TS_refresh_Tick);
            // 
            // timer_TS_task
            // 
            this.timer_TS_task.Interval = 500;
            this.timer_TS_task.Tick += new System.EventHandler(this.timer_TS_task_Tick);
            // 
            // label_serialPortStatus
            // 
            this.label_serialPortStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_serialPortStatus.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_serialPortStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.label_serialPortStatus.Location = new System.Drawing.Point(609, 263);
            this.label_serialPortStatus.Name = "label_serialPortStatus";
            this.label_serialPortStatus.Size = new System.Drawing.Size(118, 20);
            this.label_serialPortStatus.TabIndex = 4;
            this.label_serialPortStatus.Text = "Disconnected";
            this.label_serialPortStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_status
            // 
            this.label_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Raleway SemiBold", 12F);
            this.label_status.Location = new System.Drawing.Point(552, 264);
            this.label_status.Name = "label_status";
            this.label_status.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_status.Size = new System.Drawing.Size(62, 19);
            this.label_status.TabIndex = 5;
            this.label_status.Text = "Status:";
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox_chipusLogo
            // 
            this.pictureBox_chipusLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox_chipusLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_chipusLogo.Image")));
            this.pictureBox_chipusLogo.Location = new System.Drawing.Point(6, 262);
            this.pictureBox_chipusLogo.Name = "pictureBox_chipusLogo";
            this.pictureBox_chipusLogo.Size = new System.Drawing.Size(100, 26);
            this.pictureBox_chipusLogo.TabIndex = 3;
            this.pictureBox_chipusLogo.TabStop = false;
            // 
            // pictureBox_temperature
            // 
            this.pictureBox_temperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_temperature.Image = global::Baykeeper_GUI.Properties.Resources.temperature;
            this.pictureBox_temperature.Location = new System.Drawing.Point(439, 132);
            this.pictureBox_temperature.Name = "pictureBox_temperature";
            this.pictureBox_temperature.Size = new System.Drawing.Size(270, 90);
            this.pictureBox_temperature.TabIndex = 84;
            this.pictureBox_temperature.TabStop = false;
            // 
            // pictureBox_boardID
            // 
            this.pictureBox_boardID.Image = global::Baykeeper_GUI.Properties.Resources.boardID;
            this.pictureBox_boardID.Location = new System.Drawing.Point(529, 18);
            this.pictureBox_boardID.Name = "pictureBox_boardID";
            this.pictureBox_boardID.Size = new System.Drawing.Size(180, 90);
            this.pictureBox_boardID.TabIndex = 83;
            this.pictureBox_boardID.TabStop = false;
            // 
            // pictureBox_equation
            // 
            this.pictureBox_equation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_equation.Image = global::Baykeeper_GUI.Properties.Resources.equation;
            this.pictureBox_equation.Location = new System.Drawing.Point(56, 90);
            this.pictureBox_equation.Name = "pictureBox_equation";
            this.pictureBox_equation.Size = new System.Drawing.Size(610, 55);
            this.pictureBox_equation.TabIndex = 0;
            this.pictureBox_equation.TabStop = false;
            // 
            // pictureBox_tabAbout
            // 
            this.pictureBox_tabAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_tabAbout.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_tabAbout.Image")));
            this.pictureBox_tabAbout.Location = new System.Drawing.Point(205, 30);
            this.pictureBox_tabAbout.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox_tabAbout.Name = "pictureBox_tabAbout";
            this.pictureBox_tabAbout.Size = new System.Drawing.Size(313, 80);
            this.pictureBox_tabAbout.TabIndex = 0;
            this.pictureBox_tabAbout.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 291);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label_serialPortStatus);
            this.Controls.Add(this.pictureBox_chipusLogo);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Chipus - Sambaqui GUI (x.x.x.x)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_TS.ResumeLayout(false);
            this.tabPage_TS.PerformLayout();
            this.tabPage_trimmingEq.ResumeLayout(false);
            this.tabPage_about.ResumeLayout(false);
            this.tabPage_about.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_chipusLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_temperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_boardID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_equation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tabAbout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TabPage tabPage_TS;
        private System.Windows.Forms.Label label_TS_LSB;
        private System.Windows.Forms.TextBox textBox_TS_LSB;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label_TS_MSB;
        private System.Windows.Forms.TextBox textBox_TS_MSB;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label_TS_trim0;
        private System.Windows.Forms.TextBox textBox_TS_trim0;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label_TS_trim1;
        private System.Windows.Forms.Label label_TS_ack;
        private System.Windows.Forms.TextBox textBox_TS_trim1;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox_TS_i2c_addr;
        private System.Windows.Forms.Button button_TS;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Timer timer_TS_refresh;
        private System.Windows.Forms.Timer timer_TS_task;
        private System.Windows.Forms.Label label_TS_temperature;
        private System.Windows.Forms.Label label_boardID;
        private System.Windows.Forms.PictureBox pictureBox_boardID;
        private System.Windows.Forms.PictureBox pictureBox_temperature;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_TS_MSB_help;
        private System.Windows.Forms.TabPage tabPage_trimmingEq;
        private System.Windows.Forms.PictureBox pictureBox_equation;
        private System.Windows.Forms.Label label_serialPortStatus;
        private System.Windows.Forms.Label label_status;
    }
}

