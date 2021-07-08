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
using TeleSharp.TL;

namespace TeleBarWdg.MainPanel
{
    public partial class CodeConfirmPage : UserControl, IView
    {

        public delegate void ErrorOccuredHandler(string message);
        public delegate void LoginConfirmedHandler(TLUser user);

        public event ErrorOccuredHandler OnErrorOccured;
        public event LoginConfirmedHandler OnLoginConfirmed;

        public CodeConfirmPage()
        {
            InitializeComponent();
        }

        private void verifyCode_Click(object sender, EventArgs e)
        {
            mainControl.Visible = false;
            loadingPanel.Visible = true;
            var _verifyTask = Client.Instance.TClient.MakeAuthAsync(Client.Instance.PhoneNumer, Client.Instance.PhoneCodeHash, code.Text);
            Dispatcher uiDispatcher = Dispatcher.CurrentDispatcher;

            _verifyTask.ContinueWith(t =>
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

                    TLUser user = t.Result;
                    OnLoginConfirmed?.Invoke(user);
                    Client.Instance.CurrentUser = user;
                });
            });
        }
    }
}
