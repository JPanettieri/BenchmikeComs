using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace BenchmikeComs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Open the Serial port, if not already opened
            // put a try catch to catch if Open() throws an exception

        }
        delegate void OutputUpdateDelegate(string data);
        private void OutputUpdateCallback(string data)
        {
            txtReceive.Text += data;
        }

        private void DataRec
        (object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = port.ReadExisting();
                //txtreceive.Text += data;     
                //Not good as Serialport is a different Thread
                //OutputUpdateCallback(data);  //call directly will not work

                //You need to use the Invoke Method and pass the delegate and data
                txtReceive.Invoke(new OutputUpdateDelegate(OutputUpdateCallback), data);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }

        private void btn_open_Click(object sender, EventArgs e)
        {
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

        private void btnSend_Click_1(object sender, EventArgs e)
        {
            try
            {
                port.Write(txtSend.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
    

