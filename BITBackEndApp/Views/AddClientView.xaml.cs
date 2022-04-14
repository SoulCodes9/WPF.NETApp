using BITBackEndApp.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;

namespace BITBackEndApp.Views
{
    /// <summary>
    /// Interaction logic for AddClientView.xaml
    /// </summary>
    public partial class AddClientView : Page
    {
        public AddClientView()
        {
            InitializeComponent();
            this.DataContext = new AddClientVM();
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
            this.NavigationService.Navigate(new Uri("Views/ClientManagement.xaml", UriKind.Relative));
        }
    }
}
