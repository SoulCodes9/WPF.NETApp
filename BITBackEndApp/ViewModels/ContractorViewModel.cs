using System.Collections.ObjectModel;
using System.Windows;
using BITBackEndApp.Data_Access_Layer;
using BITBackEndApp.Models;

namespace BITBackEndApp.ViewModels
{
    public class ContractorViewModel
    {
        private ObservableCollection<Contractor> _contractors;
        private Contractor _selectedContractor;
        private MyCommand _updateCommand;
        private MyCommand _deleteCommand;

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
            set
            {
                _updateCommand = value;
            }
        }

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

        public void UpdateMethod()
        {
            string sqlString =
            "UPDATE CONTRACTOR " +
            " SET " +
            " Cont_FName = '" + SelectedContractor.FirstName +
            "', Cont_LName = '" + SelectedContractor.LastName +
            "', Street = '" + SelectedContractor.Street +
            "', Suburb = '" + SelectedContractor.Suburb +
            "', PostCode = '" + SelectedContractor.PostCode +
            "', State = '" + SelectedContractor.State +
            "', Phone = '" + SelectedContractor.Phone +
            "', Email = '" + SelectedContractor.Email +
            "', Password = '" + SelectedContractor.Password +
            "', Status = '" + SelectedContractor.Status +
            "' where Contractor_Id = " + SelectedContractor.ContractorId;
            SQLHelper objHelper = new SQLHelper("BIT");
            objHelper.ExecuteNonQuery(sqlString);
            MessageBox.Show("Contractor Details have been successfully updated.");
        }

        public void DeleteMethod()
        {
            //Ask teacher about adding and if statement to ask if user is sure they want to use
            string sqlString =
               "UPDATE CONTRACTOR " +
               "SET Status = 'Not Active' " +
               " where Contractor_Id = " + SelectedContractor.ContractorId;
            SQLHelper objHelper = new SQLHelper("BIT");
            objHelper.ExecuteNonQuery(sqlString);
            MessageBox.Show("Contractor has been set to Not Active");
        }


        public ObservableCollection<Contractor> Contractors
        {
            get { return _contractors; }
            set { _contractors = value; }
        }
        public Contractor SelectedContractor
        {
            get { return _selectedContractor; }
            set { _selectedContractor = value; }
        }
        public ContractorViewModel()
        {
            Contractors allContractor = new Contractors();
            Contractors = new ObservableCollection<Contractor>(allContractor);
        }
    }
}
