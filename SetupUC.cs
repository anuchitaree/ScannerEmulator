using System.IO.Ports;

namespace ScannerEmulator
{
    public partial class SetupUC : UserControl
    {
        private SerialPort? _serialPort;

        public SetupUC()
        {
            InitializeComponent();
        }

        private void SetupUC_Load(object sender, EventArgs e)
        {
            COMPort();
        }
        private void COMPort()
        {

            cmbCom.DataSource = SerialPort.GetPortNames();
            cmbCom.SelectedIndex = 0;

            int[] baudRates = { 300, 600, 1200, 2400, 4800, 9600, 19200, 38400, 57600, 115200, 230400, 460800, 921600 };
            cmbBaudrate.DataSource = baudRates;
            cmbBaudrate.SelectedItem = 19200;   // default

            int[] dataBits = { 5, 6, 7, 8 };
            cmbLength.DataSource = dataBits;
            cmbLength.SelectedItem = 8;  // default


            cmbParity.DataSource = Enum.GetValues(typeof(Parity));
            cmbParity.SelectedItem = Parity.None;

            cmbStop.DataSource = Enum.GetValues(typeof(StopBits));
            cmbStop.SelectedItem = StopBits.One;   // default

            cmbHand.DataSource = Enum.GetValues(typeof(Handshake));
            cmbHand.SelectedItem = Handshake.None;   // default

            comboBoxPrefix.DataSource = Enum.GetValues(typeof(BarcodePrefix));
            comboBoxPrefix.SelectedItem = BarcodePrefix.None;
            textBoxCustomPrefix.Enabled = false;


            comboBoxSuffix.DataSource = Enum.GetValues(typeof(BarcodeSuffix));
            comboBoxSuffix.SelectedItem = BarcodeSuffix.CRLF;
            textBoxCustomSuffix.Enabled = false;

            button6.Enabled = false;

        }

        private void OpenPort()
        {
            try
            {
                _serialPort = new SerialPort
                {
                    PortName = cmbCom.Text,      // เปลี่ยนตามเครื่อง

                    BaudRate = (int)cmbBaudrate.SelectedItem!,

                    DataBits = (int)cmbLength.SelectedItem!,

                    Parity = (Parity)cmbParity.SelectedItem!,

                    StopBits = (StopBits)cmbStop.SelectedItem!,

                    Handshake = (Handshake)cmbHand.SelectedItem!,
                };

                _serialPort.Open();
                button4.Enabled = false;
                button4.BackColor = Color.GreenYellow;
                cmbCom.Enabled = false;
                cmbBaudrate.Enabled = false;
                cmbParity.Enabled = false;
                cmbLength.Enabled = false;
                cmbStop.Enabled = false;
                cmbHand.Enabled = false;
                button6.Enabled = true;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ClosePort()
        {
            if (_serialPort?.IsOpen == true)
            {
                _serialPort.Close();
                button4.Enabled = true;
                button4.BackColor = SystemColors.Control;
                cmbCom.Enabled = true;
                cmbBaudrate.Enabled = true;
                cmbParity.Enabled = true;
                cmbLength.Enabled = true;
                cmbStop.Enabled = true;
                cmbHand.Enabled = true;
                button6.Enabled = false;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenPort();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClosePort();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Send();
        }

        private void Send()
        {
            if (_serialPort?.IsOpen == true)
            {
                string barcode = txtSend.Text;

                string prefix = "";

                switch ((BarcodePrefix)comboBoxPrefix.SelectedItem!)
                {
                    case BarcodePrefix.STX:
                        prefix = "\x02";
                        break;

                    case BarcodePrefix.TAB:
                        prefix = "\t";
                        break;

                    case BarcodePrefix.Custom:
                        prefix = textBoxCustomPrefix.Text;
                        break;
                }



                string suffix = "";

                switch ((BarcodeSuffix)comboBoxSuffix.SelectedItem!)
                {
                    case BarcodeSuffix.CR:
                        suffix = "\r";
                        break;

                    case BarcodeSuffix.LF:
                        suffix = "\n";
                        break;

                    case BarcodeSuffix.CRLF:
                        suffix = "\r\n";
                        break;

                    case BarcodeSuffix.TAB:
                        suffix = "\t";
                        break;

                    //case BarcodeSuffix.Custom:
                    //    suffix = textBoxCustomSuffix.Text;
                    //    break;
                }

                // ปกติเครื่องยิงจะส่ง CR LF ต่อท้าย
                string dataToSend = $"{prefix}{barcode}{suffix}";

                _serialPort.Write(dataToSend);

                string displayData = $"{DateTime.Now}:{dataToSend}\n";

                richTextBox2.Text = displayData + richTextBox2.Text;

               

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
        }

        private void comboBoxPrefix_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((BarcodePrefix)comboBoxPrefix.SelectedItem!)
            {
                case BarcodePrefix.STX:


                case BarcodePrefix.TAB:
                    textBoxCustomPrefix.Enabled = false;
                    break;

                case BarcodePrefix.Custom:
                    textBoxCustomPrefix.Enabled = true;

                    break;
            }
        }

        private void comboBoxSuffix_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((BarcodeSuffix)comboBoxSuffix.SelectedItem!)
            {
                case BarcodeSuffix.CR:

                case BarcodeSuffix.LF:

                case BarcodeSuffix.CRLF:

                case BarcodeSuffix.TAB:
                    textBoxCustomSuffix.Enabled = false;
                    break;

                //case BarcodeSuffix.Custom:
                //    textBoxCustomSuffix.Enabled = true;
                //    break;
            }
        }
    }
}
