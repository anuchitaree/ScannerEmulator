using System.IO.Ports;

namespace ScannerEmulator
{
    public partial class Form1 : Form
    {

        private SetupUC _setupUC;



        public Form1()
        {
            InitializeComponent();
            _setupUC = new SetupUC();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSetupUC();
            string Header = "Scanner Emulator v1.0 © 2026 Anuchit Aree. All rights reserved. Free for use. Not for resale.";
            var _form1 = new Form1();
            _form1.Text = Header;
        }

        private void LoadSetupUC()
        {
            _setupUC = new SetupUC
            {
                Dock = DockStyle.Fill
            };

            panelMain.Controls.Clear();
            panelMain.Controls.Add(_setupUC);
        }

       
    }
}
