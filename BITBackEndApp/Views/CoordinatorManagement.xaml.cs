using System;
using System.Windows.Controls;
using BITBackEndApp.ViewModels;

namespace BITBackEndApp.Views
{
    /// <summary>
    /// Interaction logic for CoordinatorManagement.xaml
    /// </summary>
    public partial class CoordinatorManagement : Page
    {
        public CoordinatorManagement()
        {
            InitializeComponent();
            this.DataContext = new CoordinatorVIewModel();
        }

        private void btnNewCoord_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Views/AddCoordinatorView.xaml", UriKind.Relative));
        }
    }
}
