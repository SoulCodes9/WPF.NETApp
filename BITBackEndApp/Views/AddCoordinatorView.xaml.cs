using BITBackEndApp.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;


namespace BITBackEndApp.Views
{
    /// <summary>
    /// Interaction logic for AddCoordinatorView.xaml
    /// </summary>
    public partial class AddCoordinatorView : Page
    {
        public AddCoordinatorView()
        {
            InitializeComponent();
            this.DataContext = new AddCoordinatorVM();
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

        private void btnBackToCoordView_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Views/CoordinatorManagement.xaml", UriKind.Relative));
        }
    }
}
