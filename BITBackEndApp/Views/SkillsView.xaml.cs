using BITBackEndApp.ViewModels;
using System.Windows.Controls;


namespace BITBackEndApp.Views
{
    /// <summary>
    /// Interaction logic for SkillsView.xaml
    /// </summary>
    public partial class SkillsView : Page
    {
        public SkillsView()
        {
            InitializeComponent();
            this.DataContext = new SkillsVM();
        }

        private void btnBackToContractorManagement_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}
