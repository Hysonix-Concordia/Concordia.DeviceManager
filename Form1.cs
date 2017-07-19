using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialPortLib;

namespace Concordia.DeviceManager
{
    public partial class Form1 : Form
    {

        private SerialPortInput _serialPort { get; set; }
        private string txt;

        delegate void LoggingCallback(string text);
        delegate void StatusCallback(string text, Color color);
        delegate void ShowWifiConfigPanelCallback();
        delegate void ShowConcordiaConfigPanelCallback();

        private void Log(string text)
        {
            if (this.txtLog.InvokeRequired)
            {
                LoggingCallback d = new LoggingCallback(Log);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtLog.Text = text;
            }
        }

        private void SetStatus(string text, Color color)
        {
            if (this.lblStatus.InvokeRequired)
            {
                StatusCallback d = new StatusCallback(SetStatus);
                this.Invoke(d, new object[] { text, color });
            }
            else
            {
                this.lblStatus.Text = text;
                this.lblStatus.ForeColor = Color.Green;
            }
        }

        private void ShowWifiConfigPanel()
        {
            if (this.pnlWifiConfig.InvokeRequired)
            {
                ShowWifiConfigPanelCallback d = new ShowWifiConfigPanelCallback(ShowWifiConfigPanel);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.pnlWifiConfig.Visible = true;
            }
        }

        private void ShowConcordiaConfigPanel()
        {
            if (this.pnlConcordiaConfig.InvokeRequired)
            {
                ShowConcordiaConfigPanelCallback d = new ShowConcordiaConfigPanelCallback(ShowConcordiaConfigPanel);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.pnlWifiConfig.Visible = false;
                this.pnlConcordiaConfig.Visible = true;
            }
        }

        public static string FromHex(string hex)
        {
            hex = hex.Replace("-", "");
            byte[] raw = new byte[hex.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return Encoding.ASCII.GetString(raw);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _serialPort = new SerialPortInput();

            // Listen to Serial Port events

            _serialPort.ConnectionStatusChanged += delegate (object sender2, ConnectionStatusChangedEventArgs args)
            {
                SetStatus("Waiting for connection", Color.Green);
                Log(txt);
            };

            _serialPort.MessageReceived += delegate (object sender2, MessageReceivedEventArgs args)
            {
                var binaryData = BitConverter.ToString(args.Data);
                var strData = FromHex(binaryData);

                txt += strData;
                Log(txt);

                if (strData.Contains("WAITING"))
                {
                    SetStatus("Device connection on COM3", Color.Green);
                    ShowWifiConfigPanel();
                }
                else if (strData.Contains("READY"))
                {
                    SetStatus("Device connected on " + strData.Replace("READY", ""), Color.Green);
                    ShowConcordiaConfigPanel();
                }
            };

            // Set port options
            _serialPort.SetPort("COM3", 115200);

            // Connect the serial port
            _serialPort.Connect();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var message = string.Format("{0}{1}", txtSSID.Text.PadRight(32, ' '), txtPassword.Text.PadRight(32, ' '));
            _serialPort.SendMessage(System.Text.Encoding.UTF8.GetBytes(message));
        }

        private void btnSaveConcordiaConfig_Click(object sender, EventArgs e)
        {

        }
    }
}
