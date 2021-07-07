using SharpShell.SharpDeskBand;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace TeleBarWdg
{
    [ComVisible(true)]
    [DisplayName("Telegram")]
    public class ControlProvider : SharpDeskBand
    {
        protected override System.Windows.Forms.UserControl CreateDeskBand()
        {
            return new TelegramTaskbarWidget();
        }

        protected override BandOptions GetBandOptions()
        {
            return new BandOptions
            {
                HasVariableHeight = true,
                IsSunken = false,
                ShowTitle = true,
                Title = "Telegram",
                UseBackgroundColour = false,
                AlwaysShowGripper = true
            };
        }
    }
}
