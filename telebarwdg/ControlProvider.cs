using SharpShell.SharpDeskBand;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Forms;

namespace TeleBarWdg
{
    [ComVisible(true)]
    [DisplayName("Telegram")]
    public class ControlProvider : SharpDeskBand
    {
        public static IMainWindowProvider MainWindowProvider { get; set; }

        public static Window GetMainWindow()
        {
            return MainWindowProvider.GetWindow();
        }

        protected override UserControl CreateDeskBand()
        {
            return new TelegramTaskbarWidget();
        }

        protected override BandOptions GetBandOptions()
        {
            return new BandOptions
            {
                HasVariableHeight = false,
                IsSunken = false,
                ShowTitle = true,
                Title = "Telegram",
                UseBackgroundColour = false,
                AlwaysShowGripper = false,
                HasNoMargins = true,
                IsFixed = true
            };
        }
    }
}
