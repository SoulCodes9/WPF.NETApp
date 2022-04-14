using BITBackEndApp.Data_Access_Layer;
using BITBackEndApp.Models;
using System.Collections.ObjectModel;
using System.Windows;

namespace BITBackEndApp.ViewModels
{
    public class CoordinatorVIewModel
    {
        private ObservableCollection<Coordinator> _coordinators;
        private Coordinator _selectedCoordinator;
        private MyCommand _updateCommand;
        private MyCommand _deleteCommand;
        public MyCommand DeleteCommand
        {
            get
            {
                if (_deleteCommand == null)
                {
                    _deleteCommand = new MyCommand(this.DeleteMethod, true);
                }
                return _deleteCommand;
            }
            set { _deleteCommand = value; }
        }

        public MyCommand UpdateCommand
        {
            get
            {
                if (_updateCommand == null)
                {
                    _updateCommand = new MyCommand(this.UpdateMethod, true);
                }
                return _updateCommand;
            }
            set { _updateCommand = value; }
        }

        public ObservableCollection<Coordinator> Coordinators
        {
            get { return _coordinators; }
            set { _coordinators = value; }
        }

        public Coordinator SelectedCoordinator
        {
            get { return _selectedCoordinator; }
            set { _selectedCoordinator = value; }
        }

        public CoordinatorVIewModel()
        {
            Coordinators allCoords = new Coordinators();
            Coordinators = new ObservableCollection<Coordinator>(allCoords);
        }

        public void UpdateMethod()
        {
            string sqlString =
            "UPDATE Coordinator " +
            " SET " +
            " Coord_FName = '" + SelectedCoordinator.FirstName +
            "', Coord_LName = '" + SelectedCoordinator.LastName +
            "', Street = '" + SelectedCoordinator.Street +
            "', Suburb = '" + SelectedCoordinator.Suburb +
            "', PostCode = '" + SelectedCoordinator.PostCode +
            "', State = '" + SelectedCoordinator.State +
            "', Phone = '" + SelectedCoordinator.Phone +
            "', Email = '" + SelectedCoordinator.Email +
            "', User_Name = '" + SelectedCoordinator.UserName +
            "', Password = '" + SelectedCoordinator.Password +
            "', Status = '" + SelectedCoordinator.Status +
            "' where Coordinator_Id = " + SelectedCoordinator.CoordinatorId;
            SQLHelper objHelper = new SQLHelper("BIT");
            objHelper.ExecuteNonQuery(sqlString);
            MessageBox.Show("Coordinator Details have been successfully updated.");
        }

        public void DeleteMethod()
        {
            string sqlString =
               "UPDATE Coordinator " +
               "SET Status = 'Not Active' " +
               " where Coordinator_Id = " + SelectedCoordinator.CoordinatorId;
            SQLHelper objHelper = new SQLHelper("BIT");
            objHelper.ExecuteNonQuery(sqlString);
            MessageBox.Show("Coordinator's Status has been set to Not Active");
        }
    }
}
