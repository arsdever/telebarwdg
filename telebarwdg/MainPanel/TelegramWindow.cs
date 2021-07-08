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
        public static TelegramWindow Instance { get => _instance; }
        public Color BorderColor { get; set; }

        private Timer timer = new Timer();
        private static TelegramWindow _instance = new TelegramWindow();

        private TelegramWindow()
        {
            InitializeComponent();
            timer.Tick += (_, __) => Close();
            timer.Interval = 2000;
            BorderColor = Color.FromArgb(80, 0, 0, 0);
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

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            e.Graphics.DrawRectangle(new Pen(BorderColor, 4), e.ClipRectangle);
        }

        private void form_MouseDown(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("button1_MouseDown");
        }

        private void form_MouseUp(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("button1_MouseUp");
        }

        private void form_MouseCaptureChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("button1_MouseCaptureChanged");
        }

        public void NavigateTo(IView view)
        {
            UserControl oldView = Controls[0] as UserControl;
            Controls.Remove(oldView);
            oldView.Dispose();

            Controls.Add(view as UserControl);
            (view as UserControl).Dock = DockStyle.Fill;
        }

        private void loginPage_OnCodeRecieved(string code)
        {
            Controls.Remove(loginPage);
            confirmPage = new MainPanel.CodeConfirmPage();
            confirmPage.Location = new Point(0, 0);
            confirmPage.Margin = new Padding(0);
            confirmPage.Name = "loginPage1";
            confirmPage.Size = new Size(300, 450);
            confirmPage.TabIndex = 0;
            Controls.Add(confirmPage);
        }
    }
}
