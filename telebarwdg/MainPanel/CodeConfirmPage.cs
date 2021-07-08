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
    public partial class CodeConfirmPage : UserControl, IView
    {
        public CodeConfirmPage()
        {
            InitializeComponent();
        }

        private void verifyCode_Click(object sender, EventArgs e)
        {
            mainControl.Visible = false;
            loadingPanel.Visible = true;
            Client.Instance.TClient.MakeAuthAsync(Client.Instance.PhoneNumer, Client.Instance.PhoneCodeHash, code.Text);
        }
    }
}
