using BITBackEndApp.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;


namespace BITBackEndApp.Views
{
    /// <summary>
    /// Interaction logic for ClientManagement.xaml
    /// </summary>
    public partial class ClientManagement : Page
    {
        public ClientManagement()
        {
            InitializeComponent();
            this.DataContext = new ClientViewModel();
        }

        private void btnNewClient_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Views/AddClientView.xaml", UriKind.Relative));
        }

    }
}
