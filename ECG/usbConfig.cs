using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace ECG
{
    public partial class usbConfig : Form
    {
        string value;
        string[] ArrayComPortsNames = null;
        int index = -1;
        string ComPortName = null;
        private int baudR = 0;
        private string stopB = "";
        private string COMno = "";



        public int bRate
        {
            get
            {
                return baudR;
            }
            set
            {
                baudR = value;
            }
        }

        public string sBits
        {
            get
            {
                return stopB;
            }
            set
            {
                stopB = value;
            }
        }

        public string comNO
        {
            get
            {
                return COMno;
            }
            set
            {
                COMno = value;
            }
        }
        public usbConfig()
        {
            InitializeComponent();
        }


        public void settings()
        {
            comboBoxCOM.Items.Clear();
            index = -1;
            ArrayComPortsNames = SerialPort.GetPortNames();


            do
            {
                index += 1;
                try
                {
                    comboBoxCOM.Items.Add(ArrayComPortsNames[index]);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("no com port connected plz connect");
                    //this.Close();
                    break;
                }
            }

            while (!((ArrayComPortsNames[index] == ComPortName)
              || (index == ArrayComPortsNames.GetUpperBound(0))));
            Array.Sort(ArrayComPortsNames);
            comboBoxBAUDrate.Items.Add("1200");
            comboBoxBAUDrate.Items.Add("4800");
            comboBoxBAUDrate.Items.Add("9600");
            comboBoxBAUDrate.Items.Add("38400");
            comboBoxBAUDrate.Items.Add("57600");
            comboBoxBAUDrate.Items.Add("115200");
        }


        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nextButton_Click_1(object sender, EventArgs e)
        {
            this.comNO = comboBoxCOM.Text;
            this.bRate = Convert.ToInt32(comboBoxBAUDrate.Text);

            this.Close();
        }

        private void comboBoxCOM_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comNO = comboBoxCOM.Text;
            //MessageBox.Show(comNO);
        }

        private void usbConfig_Load(object sender, EventArgs e)
        {

        }
    }
}
