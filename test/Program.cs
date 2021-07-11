using System;
using System.Windows;
using Application = System.Windows.Forms.Application;
using System.Windows.Forms.Integration;

namespace TeleBarWdg.TestApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Window wnd = new MainWindow();
            ElementHost.EnableModelessKeyboardInterop(wnd);
            wnd.Show();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run();
        }
    }
}
