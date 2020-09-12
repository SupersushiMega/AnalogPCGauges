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


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

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
