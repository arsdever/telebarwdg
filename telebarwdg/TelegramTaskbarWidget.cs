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
    public partial class TelegramTaskbarWidget : UserControl
    {
        public TelegramTaskbarWidget()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelegramWindow window = TelegramWindow.Instance;
            window.Show();
            var globalPos = button1.PointToScreen(Point.Empty);
            window.Location =
                new Point(globalPos.X - window.Width / 2 + button1.Width / 2,
                globalPos.Y - window.Height - 10);
        }
    }
}
