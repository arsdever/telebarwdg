using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeleBarWdg.MainPanel
{
    public partial class LoginPage : UserControl, IView
    {
        Task<string> _sendingTask;

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
            _sendingTask = Client.Instance.TClient.SendCodeRequestAsync(phoneNumber.Text);
            Client.Instance.PhoneNumer = phoneNumber.Text;

            _sendingTask.ContinueWith(t =>
            {
                if (t.IsFaulted)
                {
                    loadingPanel.Visible = false;
                    errorMsg.Visible = true;
                    errorMsg.Text = t.Exception.Message;
                    mainControl.Visible = true;
                    OnErrorOccured?.Invoke(t.Exception.Message);
                    return;
                }

                OnCodeRecieved?.Invoke(t.Result);
                Client.Instance.PhoneCodeHash = t.Result;      
            });
        }
    }
}
