using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using TLSharp.Core.Network.Exceptions;

namespace TeleBarWdg
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void requestButton_Click(object sender, RoutedEventArgs e)
        {
            loadingSpinner.Visibility = Visibility.Visible;
            errorString.Visibility = Visibility.Hidden;
            Dispatcher uiDispatcher = Dispatcher.CurrentDispatcher;
            Client.Instance.Login(phoneNumber.Text).ContinueWith(t =>
              {
                  uiDispatcher.Invoke(() =>
                  {
                      loadingSpinner.Visibility = Visibility.Hidden;
                      if (t.IsFaulted)
                      {
                          errorString.Visibility = Visibility.Visible;
                          Exception ex = t.Exception.InnerException;
                          Type extype = ex.GetType();
                          string errorMessage = "Unknown error";
                          if (extype == typeof(ArgumentNullException))
                          {
                              errorMessage = "The phone number was not provided.";
                          }
                          else if (extype == typeof(InvalidOperationException))
                          {
                              errorMessage = "The provided phone number is invalid.";
                          }
                          else if (extype == typeof(FloodException))
                          {
                            // TODO: The correct time is not shown. Replace once fixed
                            // errorMessage = string.Format("Too many attempts. Please retry in {0} seconds.", ((FloodException)ex).TimeToWait.TotalSeconds);
                            errorMessage = "Too many attempts. Please retry later.";
                          }
                          else
                          {

                          }

                          errorString.Text = errorMessage;

                          return;
                      }

                      if (t.IsCanceled)
                      {
                          return;
                      }

                      NavigationService.Navigate(new CodeConfirmationPage());
                  });
              });
        }
    }
}
