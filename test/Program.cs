using System;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using TeleBarWdg;

namespace test
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var page = new MainWindow();
            ElementHost.EnableModelessKeyboardInterop(page);
            page.Show();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run();
        }
    }
}
