
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox_serialPorts = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox_serialPorts
            // 
            this.comboBox_serialPorts.FormattingEnabled = true;
            this.comboBox_serialPorts.Location = new System.Drawing.Point(667, 12);
            this.comboBox_serialPorts.Name = "comboBox_serialPorts";
            this.comboBox_serialPorts.Size = new System.Drawing.Size(121, 21);
            this.comboBox_serialPorts.TabIndex = 0;
            this.comboBox_serialPorts.Click += new System.EventHandler(this.comboBox_serialPorts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_serialPorts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Baykeeper GUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_serialPorts;
    }
}

