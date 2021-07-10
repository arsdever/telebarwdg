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
        }
    }
}
