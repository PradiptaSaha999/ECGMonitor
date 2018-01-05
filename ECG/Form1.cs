using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ECG
{
    public partial class Form1 : Form
    {
        int dataCount;
        public SerialPort sp = new SerialPort();
        public Boolean config;
        public Boolean connected;
        public string value = "";
        public int bN;
        public string pN;
        //char[] data;
        string data;
        usbConfig uc = new usbConfig();
        public Form1()
        {
            InitializeComponent();

           
            dataCount = 0;
            chartECG.ChartAreas["ChartArea1"].AxisX.ScaleView.Size = 500;
            chartECG.Series["Series1"].BorderWidth = 2;
            condition();
            connected = false;
            pauseButton.Hide();
            if (!System.IO.Directory.Exists(Application.StartupPath + "/" + DateTime.Today.Date.ToShortDateString()))
            {
                string str = DateTime.Today.Date.ToShortDateString();
                //creat todays directory
                Directory.CreateDirectory(Application.StartupPath + "/" + str);
            }
           
        }


        void condition()
        {
            //add value to the condition ComboBox
            conditionComboBox.Items.Add("resting");
            conditionComboBox.Items.Add("sitting");
            conditionComboBox.Items.Add("standing");
            conditionComboBox.Items.Add("moving");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chartECG_Click(object sender, EventArgs e)
        {

        }

        static void SynchronizedInvoke(ISynchronizeInvoke sync, Action action)
        {
            // If the invoke is not required, then invoke here and get out.
            if (!sync.InvokeRequired)
            {
                // Execute action.
                action();

                // Get out.
                return;
            }

            // Marshal to the required context.
            sync.Invoke(action, new object[] { });
        }

        private void SetText(string text)
        {
            SynchronizedInvoke(label1, delegate () { label1.Text = text.Trim(); dataPlot(); });//for data synchronizum
        }




        private void DataReceivedHandler(
                        object sender,
                        SerialDataReceivedEventArgs e)   //Serial data handeling
        {
            if (sp.IsOpen)
            {
                try
                {
                    //Read line to serial port

                    this.value = sp.ReadLine();

                    SetText(value);//call synchronizer
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }


        public void PortSettings()
        {
            pN = uc.comNO;
            bN = uc.bRate;

            try
            {
                sp.PortName = pN;
                sp.BaudRate = bN;
                sp.Parity = Parity.None;
                sp.StopBits = StopBits.One;
                sp.DataBits = 8;
                sp.Handshake = Handshake.None;
                sp.RtsEnable = true;


            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connected = true;
            try
            {

                sp.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);//start serial handler(types of inturpt )
                //open serial port
                sp.Open();
                pauseButton.Show();
                startButton.Hide();

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                connected = false;
                pauseButton.Hide();
                startButton.Show();
            }
            
            try
            {
                //write line to serial port
                sp.WriteLine("a");
                
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
           
            

        }
        private void startButton_Click(object sender, EventArgs e)
        {


            if (nameTextBox.Text == "")
            {
                MessageBox.Show("set the name first");
            }
            else if (conditionComboBox.Text == "condition")
            {
                MessageBox.Show("slect the condition first");

            }
            else
            {

                uc.settings();
                try
                {

                    uc.ShowDialog();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                PortSettings();

                
                // Application.Idle += new EventHandler(Application_Idle);

            }


        }
        


        void dataPlot()
        {
            //trim white space and /r/n
            value = value.Trim();
            
            // remove unwanted value 
            if ((value.Length >= 2))
            {
                if (connected)
                {
                    //add chart value to chart serise converting string to int
                    chartECG.Series["Series1"].Points.AddY(Int32.Parse(value));
                    //define chart type
                    chartECG.Series["Series1"].ChartType = SeriesChartType.Spline;
                    // if derictory is missing
                    if (!System.IO.Directory.Exists(Application.StartupPath + "\\" + DateTime.Today.ToShortDateString() + "\\" + nameTextBox.Text + "\\" + conditionComboBox.Text))
                    {
                        string dir = Application.StartupPath + "\\" + DateTime.Today.ToShortDateString() + "\\" + nameTextBox.Text + "\\" + conditionComboBox.Text;
                        //creat directory
                        Directory.CreateDirectory(dir);
                    }
                    //save raw data to text file
                    File.AppendAllText(Application.StartupPath + "\\" + DateTime.Today.ToShortDateString() + "\\" + nameTextBox.Text + "\\" + conditionComboBox.Text + "\\" + nameTextBox.Text + "_" + conditionComboBox.Text + "_" + DateTime.Today.ToShortDateString() + ".txt", value + ",");
                    chartECG.Series["Series1"].Color = Color.Black;
                    dataCount++;

                    if (dataCount > chartECG.ChartAreas["ChartArea1"].AxisX.ScaleView.Size)
                    {
                        // moving chart to trac last point
                        chartECG.ChartAreas["ChartArea1"].AxisX.ScaleView.Position = dataCount - chartECG.ChartAreas["ChartArea1"].AxisX.ScaleView.Size;

                    }
                }
            }
            
        }

        



        private void saveButton_Click(object sender, EventArgs e)
        {
            
            //if missing directory creat it
            if (!System.IO.Directory.Exists(Application.StartupPath + "/" + DateTime.Today.ToShortDateString() + "/" + nameTextBox.Text + "/" + conditionComboBox.Text))
            {
                //creat directory
                Directory.CreateDirectory(Application.StartupPath + "/" + DateTime.Today.ToShortDateString() + "/" + nameTextBox.Text + "/" + conditionComboBox.Text);
            }
            string dir = Application.StartupPath + "/" + DateTime.Today.ToShortDateString() + "/" + nameTextBox.Text + "/" + conditionComboBox.Text + "/" + nameTextBox.Text + "_" + conditionComboBox.Text + "_" + DateTime.Now.ToShortTimeString();
            // save chart image  //chartECG.SaveImage(directory,image format)
            this.chartECG.SaveImage(Application.StartupPath + "/" + DateTime.Today.ToShortDateString() + "/" + nameTextBox.Text + "/" + conditionComboBox.Text + "/" + nameTextBox.Text + "_" + conditionComboBox.Text + "_" + DateTime.Now.Hour + "." + DateTime.Now.Minute + "." + DateTime.Now.Hour + ".jpg", ChartImageFormat.Jpeg);
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        private void conditionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            sp.DiscardInBuffer();                           //clear buffer
            sp.DiscardOutBuffer();                         //clear buffer
            if (connected)
            {
                connected = false;
                //sp.Close();
                // timer1.Enabled = false;
                pauseButton.Text = "resume";
            }
            else
            {
                connected = true;
                pauseButton.Text = "pause";
                //PortSettings();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
