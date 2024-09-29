namespace POS_System
{
    partial class Form_SerialConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SerialConnection));
            this.PNL_Serial = new System.Windows.Forms.Panel();
            this.BTN_SerialConnection = new System.Windows.Forms.Button();
            this.BTN_Disconnect = new System.Windows.Forms.Button();
            this.LBL_BaudRate = new System.Windows.Forms.Label();
            this.CBB_BaudRate = new System.Windows.Forms.ComboBox();
            this.LBL_ConnectionStatus = new System.Windows.Forms.Label();
            this.BTN_SearchSerial = new System.Windows.Forms.Button();
            this.LBL_Port = new System.Windows.Forms.Label();
            this.CBB_SerialPort = new System.Windows.Forms.ComboBox();
            this.LBL_SerialConnection = new System.Windows.Forms.Label();
            this.BTN_BackSpace = new System.Windows.Forms.Button();
            this.PNL_Serial.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_Serial
            // 
            this.PNL_Serial.Controls.Add(this.BTN_SerialConnection);
            this.PNL_Serial.Controls.Add(this.BTN_Disconnect);
            this.PNL_Serial.Controls.Add(this.LBL_BaudRate);
            this.PNL_Serial.Controls.Add(this.CBB_BaudRate);
            this.PNL_Serial.Controls.Add(this.LBL_ConnectionStatus);
            this.PNL_Serial.Controls.Add(this.BTN_SearchSerial);
            this.PNL_Serial.Controls.Add(this.LBL_Port);
            this.PNL_Serial.Controls.Add(this.CBB_SerialPort);
            this.PNL_Serial.Controls.Add(this.LBL_SerialConnection);
            this.PNL_Serial.Cursor = System.Windows.Forms.Cursors.Default;
            this.PNL_Serial.Location = new System.Drawing.Point(12, 44);
            this.PNL_Serial.Name = "PNL_Serial";
            this.PNL_Serial.Size = new System.Drawing.Size(259, 242);
            this.PNL_Serial.TabIndex = 23;
            this.PNL_Serial.Paint += new System.Windows.Forms.PaintEventHandler(this.PNL_Serial_Paint);
            // 
            // BTN_SerialConnection
            // 
            this.BTN_SerialConnection.Location = new System.Drawing.Point(130, 96);
            this.BTN_SerialConnection.Name = "BTN_SerialConnection";
            this.BTN_SerialConnection.Size = new System.Drawing.Size(94, 30);
            this.BTN_SerialConnection.TabIndex = 28;
            this.BTN_SerialConnection.Text = "연결";
            this.BTN_SerialConnection.UseVisualStyleBackColor = true;
            this.BTN_SerialConnection.Click += new System.EventHandler(this.BTN_SerialConnection_Click);
            // 
            // BTN_Disconnect
            // 
            this.BTN_Disconnect.Location = new System.Drawing.Point(30, 132);
            this.BTN_Disconnect.Name = "BTN_Disconnect";
            this.BTN_Disconnect.Size = new System.Drawing.Size(194, 30);
            this.BTN_Disconnect.TabIndex = 27;
            this.BTN_Disconnect.Text = "연결 끊기";
            this.BTN_Disconnect.UseVisualStyleBackColor = true;
            this.BTN_Disconnect.Click += new System.EventHandler(this.BTN_Disconnect_Click);
            // 
            // LBL_BaudRate
            // 
            this.LBL_BaudRate.Location = new System.Drawing.Point(3, 67);
            this.LBL_BaudRate.Name = "LBL_BaudRate";
            this.LBL_BaudRate.Size = new System.Drawing.Size(100, 23);
            this.LBL_BaudRate.TabIndex = 26;
            this.LBL_BaudRate.Text = "BaudRate:";
            // 
            // CBB_BaudRate
            // 
            this.CBB_BaudRate.FormattingEnabled = true;
            this.CBB_BaudRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "31250",
            "38400",
            "57600",
            "74880",
            "115200"});
            this.CBB_BaudRate.Location = new System.Drawing.Point(109, 64);
            this.CBB_BaudRate.Name = "CBB_BaudRate";
            this.CBB_BaudRate.Size = new System.Drawing.Size(142, 26);
            this.CBB_BaudRate.TabIndex = 25;
            // 
            // LBL_ConnectionStatus
            // 
            this.LBL_ConnectionStatus.Location = new System.Drawing.Point(27, 166);
            this.LBL_ConnectionStatus.Name = "LBL_ConnectionStatus";
            this.LBL_ConnectionStatus.Size = new System.Drawing.Size(200, 38);
            this.LBL_ConnectionStatus.TabIndex = 24;
            this.LBL_ConnectionStatus.Text = "시리얼 연결 상태";
            this.LBL_ConnectionStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LBL_ConnectionStatus.Click += new System.EventHandler(this.LBL_ConnectionStatus_Click);
            // 
            // BTN_SearchSerial
            // 
            this.BTN_SearchSerial.Location = new System.Drawing.Point(30, 96);
            this.BTN_SearchSerial.Name = "BTN_SearchSerial";
            this.BTN_SearchSerial.Size = new System.Drawing.Size(94, 30);
            this.BTN_SearchSerial.TabIndex = 23;
            this.BTN_SearchSerial.Text = "찾기";
            this.BTN_SearchSerial.UseVisualStyleBackColor = true;
            this.BTN_SearchSerial.Click += new System.EventHandler(this.BTN_SearchSerial_Click);
            // 
            // LBL_Port
            // 
            this.LBL_Port.Location = new System.Drawing.Point(3, 38);
            this.LBL_Port.Name = "LBL_Port";
            this.LBL_Port.Size = new System.Drawing.Size(100, 23);
            this.LBL_Port.TabIndex = 2;
            this.LBL_Port.Text = "port:";
            // 
            // CBB_SerialPort
            // 
            this.CBB_SerialPort.FormattingEnabled = true;
            this.CBB_SerialPort.Location = new System.Drawing.Point(109, 35);
            this.CBB_SerialPort.Name = "CBB_SerialPort";
            this.CBB_SerialPort.Size = new System.Drawing.Size(142, 26);
            this.CBB_SerialPort.TabIndex = 1;
            // 
            // LBL_SerialConnection
            // 
            this.LBL_SerialConnection.AutoSize = true;
            this.LBL_SerialConnection.Location = new System.Drawing.Point(74, 12);
            this.LBL_SerialConnection.Name = "LBL_SerialConnection";
            this.LBL_SerialConnection.Size = new System.Drawing.Size(104, 18);
            this.LBL_SerialConnection.TabIndex = 0;
            this.LBL_SerialConnection.Text = "시리얼 연결";
            // 
            // BTN_BackSpace
            // 
            this.BTN_BackSpace.Location = new System.Drawing.Point(136, 6);
            this.BTN_BackSpace.Name = "BTN_BackSpace";
            this.BTN_BackSpace.Size = new System.Drawing.Size(135, 32);
            this.BTN_BackSpace.TabIndex = 47;
            this.BTN_BackSpace.Text = "뒤로가기";
            this.BTN_BackSpace.UseVisualStyleBackColor = true;
            this.BTN_BackSpace.Click += new System.EventHandler(this.BTN_BackSpace_Click);
            // 
            // Form_SerialConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 298);
            this.Controls.Add(this.BTN_BackSpace);
            this.Controls.Add(this.PNL_Serial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_SerialConnection";
            this.Text = "Serial Connection";
            this.Load += new System.EventHandler(this.Form_SerialConnection_Load);
            this.PNL_Serial.ResumeLayout(false);
            this.PNL_Serial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Serial;
        private System.Windows.Forms.Label LBL_BaudRate;
        private System.Windows.Forms.ComboBox CBB_BaudRate;
        private System.Windows.Forms.Label LBL_ConnectionStatus;
        private System.Windows.Forms.Button BTN_SearchSerial;
        private System.Windows.Forms.Label LBL_Port;
        private System.Windows.Forms.ComboBox CBB_SerialPort;
        private System.Windows.Forms.Label LBL_SerialConnection;
        private System.Windows.Forms.Button BTN_BackSpace;
        private System.Windows.Forms.Button BTN_Disconnect;
        private System.Windows.Forms.Button BTN_SerialConnection;
    }
}