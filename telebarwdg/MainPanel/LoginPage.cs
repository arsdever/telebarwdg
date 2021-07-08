using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace TeleBarWdg.MainPanel
{
    public partial class LoginPage : UserControl, IView
    {
                public delegate void ErrorOccuredHandler(string message);
        public delegate void CodeReceivedHandler(string code);

        public event ErrorOccuredHandler OnErrorOccured;
        public event CodeReceivedHandler OnCodeRecieved;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void requestCode_Click(object sender, EventArgs e)
        {
            loadingPanel.Visible = true;
            mainControl.Visible = false;
            var _sendingTask = Client.Instance.TClient.SendCodeRequestAsync(phoneNumber.Text);
            Client.Instance.PhoneNumer = phoneNumber.Text;
            Dispatcher uiDispatcher = Dispatcher.CurrentDispatcher;
            _sendingTask.ContinueWith(t =>
            {
                uiDispatcher.Invoke(() =>
                {
                    if (t.IsFaulted)
                    {
                        loadingPanel.Visible = false;
                        mainControl.Visible = true;
                        errorMsg.Visible = true;
                        errorMsg.Text = t.Exception.Message;
                        OnErrorOccured?.Invoke(t.Exception.Message);
                        return;
                    }

                    OnCodeRecieved?.Invoke(t.Result);
                    Client.Instance.PhoneCodeHash = t.Result;
                });
            });
        }
    }
}
