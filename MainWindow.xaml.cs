using System.Windows;

namespace CRM_App
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExportMenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Handle Export menu item click
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Handle Exit menu item click
            Application.Current.Shutdown();
        }

        private void AboutMenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Handle About menu item click
            MessageBox.Show("CRM App\n\nVersion 1.0\n\n© 2023 CRM App, Inc. All rights reserved.", "About CRM App", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ContactManagementButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to ContactManagementPage
            MainFrame.NavigationService.Navigate(new ContactManagementPage());
        }

        private void PriorityIndicatorButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to PriorityIndicatorPage
            MainFrame.NavigationService.Navigate(new PriorityIndicatorPage());
        }

        private void ReferralTrackingButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to ReferralTrackingPage
            MainFrame.NavigationService.Navigate(new ReferralTrackingPage());
        }

        private void CustomerFeedbackButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to CustomerFeedbackPage
            MainFrame.NavigationService.Navigate(new CustomerFeedbackPage());
        }

        private void CustomerFilterButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to CustomerFilterPage
            MainFrame.NavigationService.Navigate(new CustomerFilterPage());
        }

        private void PurchaseHistoryLogButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to PurchaseHistoryLogPage
            MainFrame.NavigationService.Navigate(new PurchaseHistoryLogPage());
        }

        private void DataExportButton_Click(object sender, RoutedEventArgs e)
        {
            // Handle Data Export button click
        }

        private void StoringInventoryButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to StoringInventoryPage
            MainFrame.NavigationService.Navigate(new StoringInventoryPage());
        }

        private void ReportsBasedOnDataButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to ReportsBasedOnDataPage
            MainFrame.NavigationService.Navigate(new ReportsBasedOnDataPage());
        }
    }
}
