using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace POS_System
{
    public partial class Form_SerialConnection : Form
    {
        public static SerialPort mySerialPort;
        string[] Ports;
        int mySerialStatus = 0; // 0 - 연결 안됨 / 1 - 연결됨 / 2 - 연결할 수 없음

        public Form_SerialConnection()
        {
            InitializeComponent();
        }

        private void PNL_Serial_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchSerial()
        {
            CBB_SerialPort.Items.Clear();
            Ports = SerialPort.GetPortNames();

            if (Ports.Length > 0)
            {
                CBB_SerialPort.Items.AddRange(Ports);
                CBB_SerialPort.SelectedIndex = 0;
                mySerialStatus = 0; // 연결 가능한 포트가 있음
            }
            else
            {
                MessageBox.Show("No COM ports detected", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CBB_SerialPort.Text = "";
                CBB_SerialPort.Items.Clear();
                mySerialStatus = 2; // 연결할 수 없음
            }

            UpdateButtonVisibility();
        }

        private void UpdateButtonVisibility()
        {
            BTN_SerialConnection.Visible = (mySerialStatus == 0);
            BTN_Disconnect.Visible = (mySerialStatus == 1);

            if (mySerialStatus == 2)
            {
                BTN_SerialConnection.Visible = false;
                BTN_Disconnect.Visible = false;
            }
        }

        private void Form_SerialConnection_Load(object sender, EventArgs e)
        {
            if (mySerialPort != null &&  mySerialPort.IsOpen)
            {
                mySerialStatus = 1;
                CBB_SerialPort.Items.Add(mySerialPort.PortName);
            }
            else
            {
                mySerialStatus = 0;
                SearchSerial();
                CBB_BaudRate.SelectedIndex = 0;
            }
          
        }

        private void BTN_BackSpace_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_SearchSerial_Click(object sender, EventArgs e)
        {
            try
            {
                SearchSerial();
            }
            catch (Exception ex)
            {
                MessageBox.Show("COM port not detected: " + ex.Message, "Warning!!!", MessageBoxButtons.OK);
                CBB_SerialPort.Text = "";
                CBB_SerialPort.Items.Clear();
                mySerialStatus = 2;
                UpdateButtonVisibility();
            }
            CBB_SerialPort.DroppedDown = true;
        }

        private void LBL_ConnectionStatus_Click(object sender, EventArgs e)
        {

        }

        private void BTN_SerialConnection_Click(object sender, EventArgs e)
        {
            if (mySerialPort != null && mySerialPort.IsOpen)
            {
                MessageBox.Show("Already connected to a COM port", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            mySerialPort = new SerialPort(CBB_SerialPort.SelectedItem.ToString())
            {
                BaudRate = int.Parse(CBB_BaudRate.SelectedItem.ToString()),
                RtsEnable = true
            };


            try
            {
                mySerialPort.Open();
                LBL_ConnectionStatus.Text = $"{mySerialPort.PortName} Connected";
                mySerialStatus = 1;
                UpdateButtonVisibility();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open the COM port: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mySerialStatus = 2;
                UpdateButtonVisibility();
            }
        }

        private void BTN_Disconnect_Click(object sender, EventArgs e)
        {
            if (mySerialPort != null && mySerialPort.IsOpen)
            {
                mySerialPort.Close();
                LBL_ConnectionStatus.Text = "Disconnected";
                mySerialStatus = 0;
                UpdateButtonVisibility();
            }
        }

       

    }
}
