using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BITBackEndApp.Models;
using BITBackEndApp.Data_Access_Layer;
using System.Windows;

namespace BITBackEndApp.ViewModels
{
    public class ClientViewModel
    {
        ObservableCollection<Client> _clients;
        private Client _selectedClient;

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
        // When update button is hit

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
            "UPDATE CLIENT " +
            "SET " +
            "Client_FName = '" + SelectedClient.FirstName +
            "', Client_LName = '" + SelectedClient.LastName +
            "', Street = '" + SelectedClient.Street +
            "', Suburb = '" + SelectedClient.Suburb +
            "', PostCode = '" + SelectedClient.PostCode +
            "', State = '" + SelectedClient.State +
            "', Phone = '" + SelectedClient.Phone +
            "', Email = '" + SelectedClient.Email +
            "', Password = '" + SelectedClient.Password +
            "', Status = '" + SelectedClient.Status +
            "' where Client_Id = " + SelectedClient.ClientId;
            SQLHelper objHelper = new SQLHelper("BIT");
            objHelper.ExecuteNonQuery(sqlString);
            MessageBox.Show("Client Details have been successfully updated.");
        }

        public void DeleteMethod()
        {
            //Ask teacher about adding and if statement to ask if user is sure they want to use
            string sqlString =
               "UPDATE CLIENT " +
               "SET Status = 'Not Active' " +
               " where Client_Id = " + SelectedClient.ClientId;
            SQLHelper objHelper = new SQLHelper("BIT");
            objHelper.ExecuteNonQuery(sqlString);
        }

        public ObservableCollection<Client> Clients
        {
            get { return _clients; }
            set { _clients = value; }
        }


        public Client SelectedClient
        {
            get { return _selectedClient; }
            set { _selectedClient = value; }
        }

        public ClientViewModel()
        {
            GetAllClients();
        }

        public virtual ObservableCollection<Client> GetAllClients()
        {
            Clients allClie = new Clients();
            Clients = new ObservableCollection<Client>(allClie);
            return Clients;
        }
    }
}
