using AnalogPCGaugesPC.Properties;
using OpenHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO.Ports;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalogPCGaugesPC
{
    public partial class Form1 : Form
    {
        Computer comp;
        ISensor[] SelectSensor;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            COMPORT.Text = "hallo";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SelectSensor = new ISensor[4];

            comp = new Computer()
            {
                HDDEnabled = true,
                MainboardEnabled = true,
                RAMEnabled = true,
                GPUEnabled = true,
                CPUEnabled = true
            };
            comp.Open();

            serialPort1.PortName = Properties.Settings.Default.COMPort;
            try
            {
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (var hardware in comp.Hardware)
            {
                Gauge1Hard.Items.Add(hardware.Name);
                Gauge2Hard.Items.Add(hardware.Name);
                Gauge3Hard.Items.Add(hardware.Name);
                Gauge4Hard.Items.Add(hardware.Name);
            }
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            byte[] SerialOut;
            SerialOut = new byte[4];
            byte i;

            foreach (var hardware in comp.Hardware)
            {
                hardware.Update();
            }

            for (i = 0; i < SerialOut.Length - 1; i++)
            {
                if (SelectSensor[i] != null)
                {
                    if (SelectSensor[i].Value != null)
                    {
                        if (SelectSensor[i].SensorType == SensorType.Level || SelectSensor[i].SensorType == SensorType.Load || SelectSensor[i].SensorType == SensorType.Control || SelectSensor[i].SensorType == SensorType.Temperature)
                        {
                            SerialOut[i] = (byte)(SelectSensor[i].Value * (255 / 100));
                        }

                        else
                        {
                            SerialOut[i] = (byte)(SelectSensor[i].Value * (255 / SelectSensor[i].Max));
                        }
                        Debug.Write(SelectSensor[i].Name);
                        Debug.Write(" ");
                        Debug.Write(SelectSensor[i].SensorType);
                        Debug.WriteLine(SelectSensor[i].Value);
                        if (SerialOut[i] > 255)
                        {
                            SerialOut[i] = 255;
                        }
                    }
                    else
                    {
                        SerialOut[i] = 0;
                    }
                }
                else
                {
                    SerialOut[i] = 0;
                }
            }

            if (serialPort1.IsOpen)
            {
                serialPort1.Write(SerialOut, 0, 4);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Guage1Hard_SelectedIndexChanged(object sender, EventArgs e)
        {
            string send = Convert.ToString(((ComboBox)sender).Name);
            ComboBox Hard = Gauge1Hard;
            ComboBox SensType = Gauge1SensType;
            ComboBox Sens = Gauge1Sens;
            bool foundCopy = false;
            Debug.WriteLine(send);

            if (send == "Gauge2Hard")
            {
                Hard = Gauge2Hard;
                SensType = Gauge2SensType;
                Sens = Gauge2Sens;
            }

            else if (send == "Gauge3Hard")
            {
                Hard = Gauge3Hard;
                SensType = Gauge3SensType;
                Sens = Gauge3Sens;
            }

            else if (send == "Gauge4Hard")
            {
                Hard = Gauge4Hard;
                SensType = Gauge4SensType;
                Sens = Gauge4Sens;
            }

            Debug.WriteLine(Sens.Name);
            Debug.WriteLine(SensType.Name);

            Sens.Items.Clear();
            SensType.Items.Clear();
            foreach (var hardware in comp.Hardware)
            {
                if (hardware.Name == Convert.ToString(Hard.SelectedItem))
                {
                    foreach (var sensor in hardware.Sensors)
                    {
                        foundCopy = false;
                        foreach (SensorType type in SensType.Items)
                        {
                            Debug.Write(type);
                            if (type == sensor.SensorType)
                            {
                                foundCopy = true;
                                break;
                            }
                        }
                        if (!foundCopy)
                        {
                            SensType.Items.Add(sensor.SensorType);
                        }
                    }
                }
            }
        }

        private void Guage1SensType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string send = (((ComboBox)sender).Name);
            byte Output = 0; 
            ComboBox Hard = Gauge1Hard;
            ComboBox SensType = Gauge1SensType;
            ComboBox Sens = Gauge1Sens;

            if (send == "Gauge2SensType")
            {
                Output = 1;
                Hard = Gauge2Hard;
                SensType = Gauge2SensType;
                Sens = Gauge2Sens;
            }

            else if (send.ToString() == "Gauge3SensType")
            {
                Output = 2;
                Hard = Gauge3Hard;
                SensType = Gauge3SensType;
                Sens = Gauge3Sens;
            }

            else if (send.ToString() == "Gauge4SensType")
            {
                Output = 3;
                Hard = Gauge4Hard;
                SensType = Gauge4SensType;
                Sens = Gauge4Sens;
            }

            Sens.Items.Clear();
            foreach (var hardware in comp.Hardware)
            {
                if (hardware.Name == Convert.ToString(Hard.SelectedItem))
                {
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (Convert.ToString(sensor.SensorType) == Convert.ToString(SensType.SelectedItem))
                        {
                            Sens.Items.Add(sensor.Name);
                        }
                    }
                }
            }
        }

        private void Guage1Sens_SelectedIndexChanged(object sender, EventArgs e)
        {
            string send = (((ComboBox)sender).Name);
            byte Output = 0;
            ComboBox Hard = Gauge1Hard;
            ComboBox SensType = Gauge1SensType;
            ComboBox Sens = Gauge1Sens;

            if (send == "Gauge2Sens")
            {
                Output = 1;
                Hard = Gauge2Hard;
                SensType = Gauge2SensType;
                Sens = Gauge2Sens;
            }

            else if (send.ToString() == "Gauge3Sens")
            {
                Output = 2;
                Hard = Gauge3Hard;
                SensType = Gauge3SensType;
                Sens = Gauge3Sens;
            }

            else if (send.ToString() == "Gauge4Sens")
            {
                Output = 3;
                Hard = Gauge4Hard;
                SensType = Gauge4SensType;
                Sens = Gauge4Sens;
            }

            foreach(var hardware in comp.Hardware)
            {
                if (hardware.Name == Convert.ToString(Hard.SelectedItem))
                {
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (Convert.ToString(sensor.SensorType) == Convert.ToString(SensType.SelectedItem))
                        {
                            if(sensor.Name == Convert.ToString(Sens.SelectedItem))
                            {
                                SelectSensor[Output] = sensor;
                            }
                        }
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PortSearch_Click(object sender, EventArgs e)
        {
            string[] Ports = SerialPort.GetPortNames();
            port.Items.AddRange(Ports);
        }

        private void port_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            Properties.Settings.Default.COMPort = port.SelectedItem.ToString();
            serialPort1.PortName = port.SelectedItem.ToString();
            try
            {
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
