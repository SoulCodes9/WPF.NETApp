using BITBackEndApp.Data_Access_Layer;
using System;
using System.Windows;
using NLog;

namespace BITBackEndApp.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SQLHelper db = new SQLHelper("BIT");
                string sqlStr = "select count(1) from COORDINATOR where User_Name = '" +
                    txtUserName.Text + "' and password = '" + txtPassword.Text + "'";
                int count = Convert.ToInt32(db.ExcecuteSQLScaler(sqlStr));
                if (count == 1)
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("username or password is incorrect.");
                }
            }
            catch (Exception)
            {
                Logger logger = LogManager.GetCurrentClassLogger();
                logger.Info("Incorrect login");
            }
        }
    }
}
