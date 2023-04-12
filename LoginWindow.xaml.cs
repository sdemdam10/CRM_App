using System.Windows;

namespace CRM_App
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Check if the username and password are valid and grant access to the main window if they are

            // For example, if the username is "admin" and the password is "password", allow access to the main window
            if (UsernameTextBox.Text == "admin" && PasswordBox.Password == "123")
            {
                // Create a new instance of the main window and show it
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();

                // Close the login window
                Close();
            }
            else
            {
                // If the username and/or password are incorrect, display an error message
                ErrorMessageTextBlock.Text = "Invalid username or password";
                ErrorMessageTextBlock.Visibility = Visibility.Visible;
            }
        }

    }
}