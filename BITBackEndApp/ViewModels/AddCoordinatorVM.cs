using BITBackEndApp.Models;
using BITBackEndApp.Data_Access_Layer;
using System.Windows;

namespace BITBackEndApp.ViewModels
{
    /// <summary>
    /// Add Coordinator View Model
    /// </summary>
    class AddCoordinatorVM
    {
        private Coordinator _coordinator;
        private MyCommand _addCommand;

        public MyCommand AddCommand
        {
            get
            {
                if (_addCommand == null)
                {
                    _addCommand = new MyCommand(this.AddMethod, true);
                }
                return _addCommand;
            }
        }

        public void AddMethod()
        {
            //Logic 
            string sqlString =
           "INSERT INTO Coordinator (" +
           "Coord_FName," +
           "Coord_LName," +
           "Street," +
           "Suburb," +
           "PostCode," +
           "State," +
           "Phone," +
           "Email," +
           "Date_Of_Birth, " +
           "User_Name," +
           "Password, " +
           "Status )" +
           " VALUES ('" +
            Coordinator.FirstName + "', '" +
            Coordinator.LastName + "', '" +
            Coordinator.Street + "', '" +
            Coordinator.Suburb + "', '" +
            Coordinator.PostCode + "', '" +
            Coordinator.State + "', '" +
            Coordinator.Phone + "', '" +
            Coordinator.Email + "', '" +
            Coordinator.DOB.ToString("yyyy-MM-dd") + "', '" +
            Coordinator.UserName + "', '" +
            Coordinator.Password + "', '" +
            "Active ') ";

            SQLHelper sqlHelp = new SQLHelper("BIT");
            sqlHelp.ExecuteNonQuery(sqlString);

            MessageBox.Show("Coordinator has been successfully added.");

        }

        public AddCoordinatorVM()
        {
            _coordinator = new Coordinator();

        }
        public Coordinator Coordinator
        {
            get { return _coordinator; }
            set { _coordinator = value; }
        }
    }

}
