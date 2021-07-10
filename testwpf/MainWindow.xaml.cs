using System.Windows;

namespace TeleBarWdg
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
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
