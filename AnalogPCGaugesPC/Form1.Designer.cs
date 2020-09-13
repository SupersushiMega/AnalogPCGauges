﻿namespace AnalogPCGaugesPC
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.CPU_Usage = new System.Diagnostics.PerformanceCounter();
            this.RAM_Usage = new System.Diagnostics.PerformanceCounter();
            this.Gauge1Hard = new System.Windows.Forms.ComboBox();
            this.Gauge1Sens = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.COMPORT = new System.Windows.Forms.Label();
            this.SensorTypeLabel = new System.Windows.Forms.Label();
            this.Gauge1SensType = new System.Windows.Forms.ComboBox();
            this.Gauge2Hard = new System.Windows.Forms.ComboBox();
            this.Gauge2SensType = new System.Windows.Forms.ComboBox();
            this.Gauge2Sens = new System.Windows.Forms.ComboBox();
            this.Gauge3SensType = new System.Windows.Forms.ComboBox();
            this.Gauge3Sens = new System.Windows.Forms.ComboBox();
            this.Gauge3Hard = new System.Windows.Forms.ComboBox();
            this.Gauge4SensType = new System.Windows.Forms.ComboBox();
            this.Gauge4Sens = new System.Windows.Forms.ComboBox();
            this.Gauge4Hard = new System.Windows.Forms.ComboBox();
            this.port = new System.Windows.Forms.ComboBox();
            this.PortSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_Usage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM_Usage)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Test Test Test";
            this.notifyIcon1.BalloonTipTitle = "Titel";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "GaugeSetup";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // CPU_Usage
            // 
            this.CPU_Usage.CategoryName = "Processor";
            this.CPU_Usage.CounterName = "% Processor Time";
            this.CPU_Usage.InstanceName = "_Total";
            // 
            // RAM_Usage
            // 
            this.RAM_Usage.CategoryName = "Memory";
            this.RAM_Usage.CounterName = "% Committed Bytes In Use";
            // 
            // Gauge1Hard
            // 
            this.Gauge1Hard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gauge1Hard.FormattingEnabled = true;
            this.Gauge1Hard.Location = new System.Drawing.Point(78, 161);
            this.Gauge1Hard.Name = "Gauge1Hard";
            this.Gauge1Hard.Size = new System.Drawing.Size(121, 21);
            this.Gauge1Hard.TabIndex = 2;
            this.Gauge1Hard.SelectedIndexChanged += new System.EventHandler(this.Guage1Hard_SelectedIndexChanged);
            // 
            // Gauge1Sens
            // 
            this.Gauge1Sens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gauge1Sens.FormattingEnabled = true;
            this.Gauge1Sens.Location = new System.Drawing.Point(78, 224);
            this.Gauge1Sens.Name = "Gauge1Sens";
            this.Gauge1Sens.Size = new System.Drawing.Size(121, 21);
            this.Gauge1Sens.TabIndex = 3;
            this.Gauge1Sens.SelectedIndexChanged += new System.EventHandler(this.Guage1Sens_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Component";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sensor";
            // 
            // COMPORT
            // 
            this.COMPORT.AutoSize = true;
            this.COMPORT.Location = new System.Drawing.Point(6, 15);
            this.COMPORT.Name = "COMPORT";
            this.COMPORT.Size = new System.Drawing.Size(37, 13);
            this.COMPORT.TabIndex = 6;
            this.COMPORT.Text = "PORT";
            // 
            // SensorTypeLabel
            // 
            this.SensorTypeLabel.AutoSize = true;
            this.SensorTypeLabel.Location = new System.Drawing.Point(5, 201);
            this.SensorTypeLabel.Name = "SensorTypeLabel";
            this.SensorTypeLabel.Size = new System.Drawing.Size(67, 13);
            this.SensorTypeLabel.TabIndex = 7;
            this.SensorTypeLabel.Text = "Sensor Type";
            this.SensorTypeLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // Gauge1SensType
            // 
            this.Gauge1SensType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gauge1SensType.FormattingEnabled = true;
            this.Gauge1SensType.Location = new System.Drawing.Point(78, 193);
            this.Gauge1SensType.Name = "Gauge1SensType";
            this.Gauge1SensType.Size = new System.Drawing.Size(121, 21);
            this.Gauge1SensType.TabIndex = 8;
            this.Gauge1SensType.SelectedIndexChanged += new System.EventHandler(this.Guage1SensType_SelectedIndexChanged);
            // 
            // Gauge2Hard
            // 
            this.Gauge2Hard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gauge2Hard.FormattingEnabled = true;
            this.Gauge2Hard.Location = new System.Drawing.Point(205, 161);
            this.Gauge2Hard.Name = "Gauge2Hard";
            this.Gauge2Hard.Size = new System.Drawing.Size(121, 21);
            this.Gauge2Hard.TabIndex = 9;
            this.Gauge2Hard.Tag = "";
            this.Gauge2Hard.SelectedIndexChanged += new System.EventHandler(this.Guage1Hard_SelectedIndexChanged);
            // 
            // Gauge2SensType
            // 
            this.Gauge2SensType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gauge2SensType.FormattingEnabled = true;
            this.Gauge2SensType.Location = new System.Drawing.Point(205, 193);
            this.Gauge2SensType.Name = "Gauge2SensType";
            this.Gauge2SensType.Size = new System.Drawing.Size(121, 21);
            this.Gauge2SensType.TabIndex = 11;
            this.Gauge2SensType.SelectedIndexChanged += new System.EventHandler(this.Guage1SensType_SelectedIndexChanged);
            // 
            // Gauge2Sens
            // 
            this.Gauge2Sens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gauge2Sens.FormattingEnabled = true;
            this.Gauge2Sens.Location = new System.Drawing.Point(205, 224);
            this.Gauge2Sens.Name = "Gauge2Sens";
            this.Gauge2Sens.Size = new System.Drawing.Size(121, 21);
            this.Gauge2Sens.TabIndex = 10;
            this.Gauge2Sens.SelectedIndexChanged += new System.EventHandler(this.Guage1Sens_SelectedIndexChanged);
            // 
            // Gauge3SensType
            // 
            this.Gauge3SensType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gauge3SensType.FormattingEnabled = true;
            this.Gauge3SensType.Location = new System.Drawing.Point(332, 193);
            this.Gauge3SensType.Name = "Gauge3SensType";
            this.Gauge3SensType.Size = new System.Drawing.Size(121, 21);
            this.Gauge3SensType.TabIndex = 14;
            this.Gauge3SensType.SelectedIndexChanged += new System.EventHandler(this.Guage1SensType_SelectedIndexChanged);
            // 
            // Gauge3Sens
            // 
            this.Gauge3Sens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gauge3Sens.FormattingEnabled = true;
            this.Gauge3Sens.Location = new System.Drawing.Point(332, 224);
            this.Gauge3Sens.Name = "Gauge3Sens";
            this.Gauge3Sens.Size = new System.Drawing.Size(121, 21);
            this.Gauge3Sens.TabIndex = 13;
            this.Gauge3Sens.SelectedIndexChanged += new System.EventHandler(this.Guage1Sens_SelectedIndexChanged);
            // 
            // Gauge3Hard
            // 
            this.Gauge3Hard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gauge3Hard.FormattingEnabled = true;
            this.Gauge3Hard.Location = new System.Drawing.Point(332, 161);
            this.Gauge3Hard.Name = "Gauge3Hard";
            this.Gauge3Hard.Size = new System.Drawing.Size(121, 21);
            this.Gauge3Hard.TabIndex = 12;
            this.Gauge3Hard.SelectedIndexChanged += new System.EventHandler(this.Guage1Hard_SelectedIndexChanged);
            // 
            // Gauge4SensType
            // 
            this.Gauge4SensType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gauge4SensType.FormattingEnabled = true;
            this.Gauge4SensType.Location = new System.Drawing.Point(459, 193);
            this.Gauge4SensType.Name = "Gauge4SensType";
            this.Gauge4SensType.Size = new System.Drawing.Size(121, 21);
            this.Gauge4SensType.TabIndex = 17;
            this.Gauge4SensType.SelectedIndexChanged += new System.EventHandler(this.Guage1SensType_SelectedIndexChanged);
            // 
            // Gauge4Sens
            // 
            this.Gauge4Sens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gauge4Sens.FormattingEnabled = true;
            this.Gauge4Sens.Location = new System.Drawing.Point(459, 224);
            this.Gauge4Sens.Name = "Gauge4Sens";
            this.Gauge4Sens.Size = new System.Drawing.Size(121, 21);
            this.Gauge4Sens.TabIndex = 16;
            this.Gauge4Sens.SelectedIndexChanged += new System.EventHandler(this.Guage1Sens_SelectedIndexChanged);
            // 
            // Gauge4Hard
            // 
            this.Gauge4Hard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gauge4Hard.FormattingEnabled = true;
            this.Gauge4Hard.Location = new System.Drawing.Point(459, 161);
            this.Gauge4Hard.Name = "Gauge4Hard";
            this.Gauge4Hard.Size = new System.Drawing.Size(121, 21);
            this.Gauge4Hard.TabIndex = 15;
            this.Gauge4Hard.SelectedIndexChanged += new System.EventHandler(this.Guage1Hard_SelectedIndexChanged);
            // 
            // port
            // 
            this.port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.port.FormattingEnabled = true;
            this.port.Location = new System.Drawing.Point(47, 12);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(121, 21);
            this.port.TabIndex = 18;
            this.port.SelectedIndexChanged += new System.EventHandler(this.port_SelectedIndexChanged);
            // 
            // PortSearch
            // 
            this.PortSearch.Location = new System.Drawing.Point(174, 10);
            this.PortSearch.Name = "PortSearch";
            this.PortSearch.Size = new System.Drawing.Size(75, 23);
            this.PortSearch.TabIndex = 19;
            this.PortSearch.Text = "Search";
            this.PortSearch.UseVisualStyleBackColor = true;
            this.PortSearch.Click += new System.EventHandler(this.PortSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 274);
            this.Controls.Add(this.PortSearch);
            this.Controls.Add(this.port);
            this.Controls.Add(this.Gauge4SensType);
            this.Controls.Add(this.Gauge4Sens);
            this.Controls.Add(this.Gauge4Hard);
            this.Controls.Add(this.Gauge3SensType);
            this.Controls.Add(this.Gauge3Sens);
            this.Controls.Add(this.Gauge3Hard);
            this.Controls.Add(this.Gauge2SensType);
            this.Controls.Add(this.Gauge2Sens);
            this.Controls.Add(this.Gauge2Hard);
            this.Controls.Add(this.Gauge1SensType);
            this.Controls.Add(this.SensorTypeLabel);
            this.Controls.Add(this.COMPORT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Gauge1Sens);
            this.Controls.Add(this.Gauge1Hard);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CPU_Usage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM_Usage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Diagnostics.PerformanceCounter CPU_Usage;
        private System.Diagnostics.PerformanceCounter RAM_Usage;
        private System.Windows.Forms.ComboBox Gauge1Hard;
        private System.Windows.Forms.ComboBox Gauge1Sens;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label COMPORT;
        private System.Windows.Forms.Label SensorTypeLabel;
        private System.Windows.Forms.ComboBox Gauge1SensType;
        private System.Windows.Forms.ComboBox Gauge2Hard;
        private System.Windows.Forms.ComboBox Gauge2SensType;
        private System.Windows.Forms.ComboBox Gauge2Sens;
        private System.Windows.Forms.ComboBox Gauge3SensType;
        private System.Windows.Forms.ComboBox Gauge3Sens;
        private System.Windows.Forms.ComboBox Gauge3Hard;
        private System.Windows.Forms.ComboBox Gauge4SensType;
        private System.Windows.Forms.ComboBox Gauge4Sens;
        private System.Windows.Forms.ComboBox Gauge4Hard;
        private System.Windows.Forms.ComboBox port;
        private System.Windows.Forms.Button PortSearch;
    }
}

