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
    public partial class TelegramWindow : Form
    {
        Timer timer = new Timer();

        public TelegramWindow()
        {
            InitializeComponent();
            timer.Tick += (_, __) => Close();
            timer.Interval = 2000;
        }

        private void TelegramWindow_OnMouseEnter(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Interval = 2000;
        }

        private void TelegramWindow_OnMouseLeave(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
