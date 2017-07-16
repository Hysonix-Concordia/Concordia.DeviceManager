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
        private bool _waitingForMessage = false;
        private string txt;

        delegate void LoggingCallback(string text);
        delegate void StatusCallback(string text, Color color);
        delegate void ShowConfigPanelCallback();

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

        private void ShowConfigPanel()
        {
            if (this.pnlConfigure.InvokeRequired)
            {
                ShowConfigPanelCallback d = new ShowConfigPanelCallback(ShowConfigPanel);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.pnlConfigure.Visible = true;
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

                txt += string.Format("Received message: {0}", strData);
                Log(txt);

                if (strData.Contains("WAITING") && !_waitingForMessage)
                {
                    SetStatus("Device connection on COM3", Color.Green);
                    ShowConfigPanel();
                }
            };

            // Set port options
            _serialPort.SetPort("COM3", 115200);

            // Connect the serial port
            _serialPort.Connect();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var message = string.Format("{0}{1}{2}", txtSSID.Text.PadRight(32, ' '), txtPassword.Text.PadRight(32, ' '), txtSubscriptionId.Text.PadRight(36, ' '));
            _waitingForMessage = true;
            _serialPort.SendMessage(System.Text.Encoding.UTF8.GetBytes(message));
        }
    }
}
