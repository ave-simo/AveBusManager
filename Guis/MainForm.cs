using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace AveBusManager
{
    public partial class MainForm : Form
    {

        private AveBusController aveBusController;
        private GuiEventHandler guiEventHandler; // contains beginInvoke for gui update from external threads
        private Color defaultColor;

        public MainForm()
        {
            InitializeComponent();

            aveBusController = new AveBusController();
            guiEventHandler = new GuiEventHandler(this);
            aveBusController.busEvent += guiEventHandler.guiUpdate;

            defaultColor = this.BackColor;
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

            // update labels
            baud_var.Text = aveBusController.getSerialPort().BaudRate.ToString();
            parity_var.Text = aveBusController.getSerialPort().Parity.ToString();
            dataBits_var.Text = aveBusController.getSerialPort().DataBits.ToString();
            stopBits_var.Text = aveBusController.getSerialPort().StopBits.ToString();

            enableAllButtons();

        }



        // =========================================================
        // buttons section
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
            aveBusController.startReadingBus();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            aveBusController.stopReadingBus();
        }



        public void changeLight1StatusColor(string color)
        {
            if (color.Equals("yellow")) light_1_statusTextBox.BackColor = Color.Yellow;
            if (color.Equals("black"))  light_1_statusTextBox.BackColor = Color.Black;

        }
        public void AppendLog(string text)
        {
            textBox1.AppendText(text + " ");
        }


        public void changeBackGroundColor(string color)
        {

            if (color.Equals("red")) this.BackColor = Color.Red;
            if (color.Equals("green")) this.BackColor = Color.Green;
            if (color.Equals("blue")) this.BackColor = Color.Blue;
            if (color.Equals("default")) this.BackColor = defaultColor;
            // other colors...

        }


    }
}
