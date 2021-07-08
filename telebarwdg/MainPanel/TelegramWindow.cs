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
        public static TelegramWindow Instance { get => _instance; }
        private static TelegramWindow _instance = new TelegramWindow();

        private TelegramWindow()
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

        public void NavigateTo(IView view)
        {
            UserControl oldView = Controls[0] as UserControl;
            Controls.Remove(oldView);
            oldView.Dispose();

            Controls.Add(view as UserControl);
            (view as UserControl).Dock = DockStyle.Fill;
        }
    }
}
