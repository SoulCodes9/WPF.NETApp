using BITBackEndApp.ViewModels;
using System;
using System.Windows.Controls;

namespace BITBackEndApp.Views
{
    /// <summary>
    /// Interaction logic for ContractorManagement.xaml
    /// </summary>
    public partial class ContractorManagement : Page
    {
        public ContractorManagement()
        {
            InitializeComponent();
            this.DataContext = new ContractorViewModel();
        }

        private void btnNewContractor_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Views/AddContractorView.xaml", UriKind.Relative));

        }
    }
}
