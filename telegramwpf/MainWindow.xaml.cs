using System.IO;
using System.Windows;

namespace TeleBarWdg
{
    public class WPFWindowProvider : IMainWindowProvider
    {
        public Window GetWindow()
        {
            return new MainWindow();
        }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            if (Client.Instance.IsLogged)
            {
                frame.Navigate(new SessionPage());
            }
            else
            {
                frame.Navigate(new LoginPage());
            }
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
