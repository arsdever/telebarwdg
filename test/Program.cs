using System;
using System.Windows.Forms;
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
            //SampleClient example = new SampleClient();
            //example.Run();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(TelegramWindow.Instance);
        }
    }
}
