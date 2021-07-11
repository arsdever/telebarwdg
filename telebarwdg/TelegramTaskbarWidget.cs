using System;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace TeleBarWdg
{
    public partial class TelegramTaskbarWidget : UserControl
    {
        public TelegramTaskbarWidget()
        {
            InitializeComponent();
        }

        private void taskbarButton1_Click(object sender, EventArgs e)
        {
            ControlProvider.MainWindowProvider = new WPFWindowProvider();
            Window mainWindow = ControlProvider.GetMainWindow();
            ElementHost.EnableModelessKeyboardInterop(mainWindow);
            mainWindow.Show();
            var globalPos = taskbarButton1.PointToScreen(new System.Drawing.Point());
            Point position =
                new Point(globalPos.X - mainWindow.Width / 2 + taskbarButton1.Width / 2,
                globalPos.Y - mainWindow.Height - 10);
            mainWindow.Left = position.X;
            mainWindow.Top = position.Y;
        }
    }
}