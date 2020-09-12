using AnalogPCGaugesPC.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalogPCGaugesPC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "hallo";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.PortName = Properties.Settings.Default.COMPort;
            try
            {
                serialPort1.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Fehler",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            timer.Start();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            byte[] SerialOut;
            SerialOut = new byte[4];
            byte i;
            for (i = 0; i < SerialOut.Length; i++)
            {
                SerialOut[i] = 0;
            }
            double CPU_Use = (CPU_Usage.NextValue() * 2.55);
            double RAM_Use = (RAM_Usage.NextValue() * 2.55);
            SerialOut[0] = (byte)CPU_Use;
            SerialOut[1] = (byte)RAM_Use;
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
    }
}
