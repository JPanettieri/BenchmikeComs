using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;


namespace BenchmikeComs
{
    public partial class BenchmikeComTester : Form
    {
        public BenchmikeComTester()
        {
            InitializeComponent();

        }

        delegate void OutputUpdateDelegate(string data);
        private void OutputUpdateCallback(string data)
        {
            txtReceive.Text += data;
            rchTxtIn.Text += data;
        }

        private void DataRec
        (object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = port.ReadExisting();
                txtReceive.Invoke(new OutputUpdateDelegate(OutputUpdateCallback), data);
            }
            catch (System.Exception ex)
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

        private void btnListen_Click(object sender, EventArgs e)
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
    }



}
    

