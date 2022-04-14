using System.Windows;
using BITBackEndApp.Views;
using System;
using NLog;
namespace BITBackEndApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public MainWindow()
        {
            InitializeComponent();

            FileLogger fileLogger = new FileLogger();
            fileLogger.Log("Error");
            logger.Info("There is an error");
        }

        private void btnClient_Click(object sender, RoutedEventArgs e)
        {
            contentFrame.Content = new ClientManagement();
        }

        private void btnContractor_Click(object sender, RoutedEventArgs e)
        {
            contentFrame.Content = new ContractorManagement();
        }

        private void btnEmployee_Click(object sender, RoutedEventArgs e)
        {
            contentFrame.Content = new CoordinatorManagement();
        }

        private void btnRequests_Click(object sender, RoutedEventArgs e)
        {
            contentFrame.Content = new RequestManagement();
        }

        private void btnSkills_Click(object sender, RoutedEventArgs e)
        {
            contentFrame.Content = new SkillsView();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
