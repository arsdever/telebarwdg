using System;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace TeleBarWdg
{
    /// <summary>
    /// Interaction logic for CodeConfirmationPage.xaml
    /// </summary>
    public partial class CodeConfirmationPage : Page
    {
        public CodeConfirmationPage()
        {
            InitializeComponent();
        }

        private void requestButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            loadingSpinner.Visibility = System.Windows.Visibility.Visible;
            errorString.Visibility = System.Windows.Visibility.Hidden;
            Dispatcher uiDispatcher = Dispatcher.CurrentDispatcher;
            Client.Instance.VerifyCode(confirmationCode.Text).ContinueWith(t =>
            {
                uiDispatcher.Invoke(() =>
                {
                    loadingSpinner.Visibility = System.Windows.Visibility.Hidden;
                    if (t.IsFaulted)
                    {
                        errorString.Visibility = System.Windows.Visibility.Visible;
                        Type extype = t.Exception.InnerException.GetType();
                        string errorMessage = "Unknown error";
                        if (extype == typeof(ArgumentNullException))
                        {
                            errorMessage = "The confirmation code was not provided.";
                        }
                        else if (extype == typeof(TLSharp.Core.Exceptions.InvalidPhoneCodeException))
                        {
                            errorMessage = "Wrong confirmation code.";
                        }
                        else
                        {

                        }
                        errorString.Text = errorMessage;

                        return;
                    }

                    NavigationService.Navigate(new SessionPage());
                });
            });
        }

        private void changePhone_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new LoginPage());
        }
    }
}
