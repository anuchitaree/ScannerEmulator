using System.IO.Ports;

namespace ScannerEmulator
{
    public partial class Form1 : Form
    {

        private SerialPort? _serialPort;


        public Form1()
        {
            InitializeComponent();
            //_serialPort = new SerialPort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort = new SerialPort
                {
                    PortName = "COM8",      // เปลี่ยนตามเครื่อง
                    BaudRate = 115200,
                    DataBits = 8,
                    Parity = Parity.None,
                    StopBits = StopBits.One,
                    Handshake = Handshake.None
                };

                _serialPort.Open();
                //MessageBox.Show("Port Opened");
                button1.Enabled = false;
                button1.BackColor = Color.GreenYellow;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_serialPort?.IsOpen == true)
            {
                _serialPort.Close();
                button1.Enabled = true;
                button1.BackColor = SystemColors.Control;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_serialPort?.IsOpen == true)
            {
                string barcode = txtBarcode.Text;

                // ปกติเครื่องยิงจะส่ง CR LF ต่อท้าย
                _serialPort.Write(barcode + "\r\n");
            }
        }
    }
}
