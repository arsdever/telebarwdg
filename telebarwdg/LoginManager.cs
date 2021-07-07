using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeleBarWdg
{
    public partial class LoginManager : UserControl
    {
        public LoginManager()
        {
            InitializeComponent();
        }

        private async void submit_Click(object sender, EventArgs e)
        {
            submit.Hide();
            progress.Show();
            await Client.Instance.TClient.SendCodeRequestAsync(input.Text);
        }
    }
}
