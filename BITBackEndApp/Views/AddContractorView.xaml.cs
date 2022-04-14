using System;
using System.Windows;
using System.Windows.Controls;
using BITBackEndApp.ViewModels;

namespace BITBackEndApp.Views
{
    /// <summary>
    /// Interaction logic for AddContractorView.xaml
    /// </summary>
    public partial class AddContractorView : Page
    {
        public AddContractorView()
        {
            InitializeComponent();
            this.DataContext = new AddContractorVM();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            foreach (UIElement ele in containerCanvas.Children)
            {
                TextBox textBox = ele as TextBox;
                if (textBox != null)
                {
                    textBox.Text = String.Empty;
                }
            }
        }

        private void btnBackToCustomerManagement_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Views/ContractorManagement.xaml", UriKind.Relative));
        }
    }
}
