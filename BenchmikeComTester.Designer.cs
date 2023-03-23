using System.IO.Ports;
using System;

namespace BenchmikeComs
{
    partial class BenchmikeComTester
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.port = new System.IO.Ports.SerialPort(this.components);
            this.btn_open = new System.Windows.Forms.Button();
            this.btnListen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCom = new System.Windows.Forms.TextBox();
            this.txtBaud = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbHandshaking = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbPex = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSendAll = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtReceive = new System.Windows.Forms.RichTextBox();
            this.txtAck = new System.Windows.Forms.RichTextBox();
            this.Defaut = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rchTxtFail = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(252, 212);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(338, 20);
            this.txtSend.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(252, 339);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // port
            // 
            this.port.BaudRate = 19200;
            this.port.DataBits = 7;
            this.port.PortName = "COM2";
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(32, 302);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 23);
            this.btn_open.TabIndex = 3;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(32, 340);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(75, 23);
            this.btnListen.TabIndex = 4;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Incoming";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Outgoing";
            // 
            // txtCom
            // 
            this.txtCom.Location = new System.Drawing.Point(32, 59);
            this.txtCom.Name = "txtCom";
            this.txtCom.Size = new System.Drawing.Size(100, 20);
            this.txtCom.TabIndex = 7;
            // 
            // txtBaud
            // 
            this.txtBaud.Location = new System.Drawing.Point(32, 113);
            this.txtBaud.Name = "txtBaud";
            this.txtBaud.Size = new System.Drawing.Size(100, 20);
            this.txtBaud.TabIndex = 8;
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(29, 40);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(28, 13);
            this.c.TabIndex = 9;
            this.c.Text = "Com";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Baud";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Parity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "DataBits";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Handshaking";
            // 
            // cbDataBits
            // 
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Items.AddRange(new object[] {
            "8",
            "7"});
            this.cbDataBits.Location = new System.Drawing.Point(32, 160);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(121, 21);
            this.cbDataBits.TabIndex = 17;
            this.cbDataBits.SelectedIndexChanged += new System.EventHandler(this.cbDataBits_SelectedIndexChanged);
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.cbParity.Location = new System.Drawing.Point(32, 212);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(121, 21);
            this.cbParity.TabIndex = 18;
            this.cbParity.SelectedIndexChanged += new System.EventHandler(this.cbParity_SelectedIndexChanged);
            // 
            // cbHandshaking
            // 
            this.cbHandshaking.FormattingEnabled = true;
            this.cbHandshaking.Items.AddRange(new object[] {
            "None",
            "XonXoff",
            "RequestToSend",
            "RequestToSendXonXoff"});
            this.cbHandshaking.Location = new System.Drawing.Point(32, 261);
            this.cbHandshaking.Name = "cbHandshaking";
            this.cbHandshaking.Size = new System.Drawing.Size(121, 21);
            this.cbHandshaking.TabIndex = 19;
            this.cbHandshaking.SelectedIndexChanged += new System.EventHandler(this.cbHandshaking_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(113, 302);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbPex
            // 
            this.cbPex.FormattingEnabled = true;
            this.cbPex.Items.AddRange(new object[] {
            "MEAS.CLEARALL.NOW",
            "CONF.SER.FORMAT.HEADER:EXCLAM",
            "CONF.SER.FORMAT.LABEL:OFF",
            "MEAS.START.NOW"});
            this.cbPex.Location = new System.Drawing.Point(252, 275);
            this.cbPex.Name = "cbPex";
            this.cbPex.Size = new System.Drawing.Size(338, 21);
            this.cbPex.TabIndex = 21;
            this.cbPex.SelectedIndexChanged += new System.EventHandler(this.cbPex_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "PexMeasure Test";
            // 
            // btnSendAll
            // 
            this.btnSendAll.Location = new System.Drawing.Point(351, 339);
            this.btnSendAll.Name = "btnSendAll";
            this.btnSendAll.Size = new System.Drawing.Size(75, 23);
            this.btnSendAll.TabIndex = 23;
            this.btnSendAll.Text = "Send All";
            this.btnSendAll.UseVisualStyleBackColor = true;
            this.btnSendAll.Click += new System.EventHandler(this.btnSendAll_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(615, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Acknowledge";
            // 
            // txtReceive
            // 
            this.txtReceive.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceive.Location = new System.Drawing.Point(255, 59);
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.Size = new System.Drawing.Size(335, 131);
            this.txtReceive.TabIndex = 26;
            this.txtReceive.Text = "";
            // 
            // txtAck
            // 
            this.txtAck.Font = new System.Drawing.Font("Unifont", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtAck.Location = new System.Drawing.Point(618, 56);
            this.txtAck.Name = "txtAck";
            this.txtAck.Size = new System.Drawing.Size(103, 134);
            this.txtAck.TabIndex = 27;
            this.txtAck.Text = "";
            // 
            // Defaut
            // 
            this.Defaut.Location = new System.Drawing.Point(113, 339);
            this.Defaut.Name = "Defaut";
            this.Defaut.Size = new System.Drawing.Size(75, 23);
            this.Defaut.TabIndex = 28;
            this.Defaut.Text = "Default";
            this.Defaut.UseVisualStyleBackColor = true;
            this.Defaut.Click += new System.EventHandler(this.Defaut_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(458, 339);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rchTxtFail
            // 
            this.rchTxtFail.Font = new System.Drawing.Font("Unifont", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchTxtFail.Location = new System.Drawing.Point(618, 228);
            this.rchTxtFail.Name = "rchTxtFail";
            this.rchTxtFail.Size = new System.Drawing.Size(103, 134);
            this.rchTxtFail.TabIndex = 31;
            this.rchTxtFail.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(615, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Failed Msg";
            // 
            // BenchmikeComTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rchTxtFail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.Defaut);
            this.Controls.Add(this.txtAck);
            this.Controls.Add(this.txtReceive);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSendAll);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbPex);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbHandshaking);
            this.Controls.Add(this.cbParity);
            this.Controls.Add(this.cbDataBits);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.c);
            this.Controls.Add(this.txtBaud);
            this.Controls.Add(this.txtCom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSend);
            this.Name = "BenchmikeComTester";
            this.Text = "Benchmike Coms Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnSend;
        private SerialPort port;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCom;
        private System.Windows.Forms.TextBox txtBaud;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbHandshaking;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbPex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSendAll;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox txtReceive;
        private System.Windows.Forms.RichTextBox txtAck;
        private System.Windows.Forms.Button Defaut;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox rchTxtFail;
        private System.Windows.Forms.Label label10;
    }
}

