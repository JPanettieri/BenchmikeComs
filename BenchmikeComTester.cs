using System;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace BenchmikeComs
{
    public partial class BenchmikeComTester : Form
    {
        bool dataRecieved = false;
        public BenchmikeComTester()
        {
            InitializeComponent();

        }
        public void SaveLog()
        {
            string fileCreator = "Benchmike test " + DateTime.Now.ToString("mm") + DateTime.Now.ToString("ss") + ".txt";
            TextWriter txt = new StreamWriter(String.Format("C:\\Users\\joshu\\OneDrive\\Desktop\\{0}", fileCreator));
            txt.Write("New Test" + DateTime.Now.ToString("d") + "\n");
            txt.Write("Data Recieved \n");
            txt.Write(txtReceive.Text);
            txt.Write("Acknowledge respose \n");
            txt.Write(txtAck.Text);
            txt.Write("Unexpected response \n");
            txt.Write(txtFail.Text);
            txt.Close();
        }

        delegate void OutputUpdateDelegate(string data);
        private void OutputUpdateCallback(string data)
        {
            txtReceive.Text += data;
            if (txtReceive.Text.Contains("\u0006"))
            {
                txtAck.Text += data;
                dataRecieved = true;
            }
            else
            {
                txtFail.Text += data;
            }
        }

        

        public void DataRec
        (object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = port.ReadExisting();
                txtReceive.Invoke(new OutputUpdateDelegate(OutputUpdateCallback), data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string message = txtSend.Text + "\r";
                byte[] data = Encoding.ASCII.GetBytes(message);
                port.Write(data, 0, data.Length);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Defaut_Click(object sender, EventArgs e)
        {
            txtBaud.Text = "19200";
            cbParity.SelectedIndex = 0;
            cbDataBits.SelectedIndex = 0;
            cbHandshaking.SelectedIndex = 0;
            txtCom.Text = "COM3";
        }
        private void btn_open_Click(object sender, EventArgs e)
        {
            int baud;
            Int32.TryParse(txtBaud.Text, out baud);
            port.BaudRate = baud;
            port.PortName = txtCom.Text;
            if (!port.IsOpen)
            {
                try
                {
                    port.Open();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        public void btnListen_Click(object sender, EventArgs e)
        {
            port.DataReceived += new SerialDataReceivedEventHandler(DataRec);

        }

        private void cbDataBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDataBits.SelectedIndex == 0)
            {
                port.DataBits = 8;
            }
            else
            {
                port.DataBits = 7;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                try
                {
                    port.Close();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void cbParity_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbParity.SelectedIndex)
            {
                case 0:
                    port.Parity = Parity.None;
                    break;
                case 1:
                    port.Parity = Parity.Even;
                    break;
                case 2:
                    port.Parity = Parity.Odd;
                    break;
                case 3:
                    port.Parity = Parity.Mark; 
                    break;
                case 4:
                    port.Parity = Parity.Space;
                    break;
            }
        }

        private void cbHandshaking_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbHandshaking.SelectedIndex)
            {
                case 0:
                    port.Handshake = Handshake.None;
                    break; 
                case 1:
                    port.Handshake = Handshake.XOnXOff; 
                    break;
                case 2:
                    port.Handshake = Handshake.RequestToSend;
                    break;
                case 3:
                    port.Handshake = Handshake.RequestToSendXOnXOff;
                    break;
            }
        }

        private void cbPex_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSend.Text = cbPex.Text;
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string data = sp.ReadExisting();
            if (data.Contains("\u0006"))
            {
                dataRecieved = true;
            }
        }


        private void btnSendAll_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            try
            {
                foreach (var item in cbPex.Items)
                {
                    txtReceive.Text = "";
                    dataRecieved = false;
                    while (txtSend.Text != item.ToString())
                    {
                        txtSend.Text = item.ToString();
                        txtSend.Refresh();
                        string message = txtSend.Text + "\r";
                        byte[] data = Encoding.ASCII.GetBytes(message);
                        port.Write(data, 0, data.Length);
                    }
                    timer.Start();
                    port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    while (dataRecieved == false && timer.Elapsed.TotalSeconds < 10)
                    {
                        Application.DoEvents();
                    }
                    port.DataReceived -= new SerialDataReceivedEventHandler(DataReceivedHandler);
                    timer.Stop();
                    timer.Reset();
                    if (dataRecieved == false)
                    {
                        while (txtReceive.Text != "Test Failed")
                        {
                            txtReceive.Text = "Test Failed";
                            txtReceive.Refresh();
                        }
                        break;
                    }
                    txtReceive.Refresh();
                }
                System.Threading.Thread.Sleep(45000);
                Application.DoEvents();
                SaveLog();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtReceive.Text = string.Empty;
            txtSend.Text = string.Empty;
            txtAck.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveLog();
        }


    }



}
    

