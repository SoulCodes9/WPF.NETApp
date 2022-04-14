using BITBackEndApp.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;


namespace BITBackEndApp.Views
{
    /// <summary>
    /// Interaction logic for AddRequestView.xaml
    /// </summary>
    public partial class AddRequestView : Page
    {
        public AddRequestView()
        {
            InitializeComponent();
            this.DataContext = new AddRequestVM();
        }

        private void btnClear_Click(object sender, System.Windows.RoutedEventArgs e)
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
            this.NavigationService.Navigate(new Uri("Views/RequestManagement.xaml", UriKind.Relative));

        }
    }
}
