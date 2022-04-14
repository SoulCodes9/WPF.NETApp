using BITBackEndApp.ViewModels;
using System;
using System.Windows.Controls;


namespace BITBackEndApp.Views
{
    /// <summary>
    /// Interaction logic for RequestManagement.xaml
    /// </summary>
    public partial class RequestManagement : Page
    {
        public RequestManagement()
        {
            InitializeComponent();
            this.DataContext = new RequestViewModel();
        }

        private void btnNewRequest_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Views/AddRequestView.xaml", UriKind.Relative));
        }

        private void btnDelete_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Views/RequestManagement.xaml", UriKind.Relative));
        }
    }
}
