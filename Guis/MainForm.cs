using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace AveBusManager
{
    public partial class MainForm : Form
    {

        private AveBusController aveBusController;
        private LogForm busListenerForm;

        public MainForm()
        {
            InitializeComponent();

            this.aveBusController = new AveBusController();
            disableAllButtons();

        }

        // useless =================================================
        private void label1_Click(object sender, EventArgs e)  { }
        private void label10_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e)  { }
        private void label9_Click(object sender, EventArgs e)  { }
        private void label7_Click(object sender, EventArgs e)  { }
        // =========================================================



        // =========================================================
        // combo box section
        private void comboBox1_showItems(object sender, EventArgs e)
        {
            String[] ports = aveBusController.getAvailablePorts();
            foreach (String port in ports)
            {
                SerialPort serialPort = new SerialPort(port);
                if (!serialPort.IsOpen && !(comboBox1.Items.Contains(port)))
                {
                    comboBox1.Items.Add(port); // add port to the list if available
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string port = comboBox1.SelectedItem as string;

            aveBusController.configureSerialPort(
                port,
                4800,
                Parity.Odd,
                8,
                StopBits.One,
                Handshake.None
            );

            aveBusController.openSerialPort();
            MessageBox.Show("Successfully configured COM port", "Status");

            enableAllButtons();

            // update labels
            baud_var.Text = aveBusController.getSerialPort().BaudRate.ToString();
            parity_var.Text = aveBusController.getSerialPort().Parity.ToString();
            dataBits_var.Text = aveBusController.getSerialPort().DataBits.ToString();
            stopBits_var.Text = aveBusController.getSerialPort().StopBits.ToString();

        }



        // =========================================================
        // buttons section
        private void button1_Click(object sender, EventArgs e)
        {
            aveBusController.changeLight1Status();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            aveBusController.turnOnLight_1();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            aveBusController.turnOffLight_1();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            busListenerForm = new LogForm();
            busListenerForm.Show();

            aveBusController.startReading();   
        }

        private void button6_Click(object sender, EventArgs e)
        {
            aveBusController.stopReading();
            busListenerForm.Hide();
        }


        private void enableAllButtons()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            startReading_btn.Enabled = true;
            stopReading_btn.Enabled = true;
        }

        private void disableAllButtons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            startReading_btn.Enabled = false;
            stopReading_btn.Enabled = false;
        }

    }
}
