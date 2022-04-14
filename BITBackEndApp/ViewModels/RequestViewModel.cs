using System.Collections.ObjectModel;
using System.Windows;
using BITBackEndApp.Data_Access_Layer;
using BITBackEndApp.Models;

namespace BITBackEndApp.ViewModels
{
    public class RequestViewModel
    {
        private ObservableCollection<Request> _requests;
        private Request _selectedRequest;
        private MyCommand _updateCommand;

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

        public void UpdateMethod()
        {
            string sqlStr =
                "UPDATE REQUEST " +
                "SET " +
                " Status = '" + SelectedRequest.Status + 
                "', Km_Travelled = '" + SelectedRequest.Kilometers + "' " +
                " WHERE Request_Id = " + SelectedRequest.RequestId;
            SQLHelper objHelper = new SQLHelper("BIT");
            objHelper.ExecuteNonQuery(sqlStr);
            MessageBox.Show("Request updated.");
        }

        public ObservableCollection<Request> Requests
        {
            get { return _requests; }
            set { _requests = value; }
        }

        public Request SelectedRequest
        {
            get { return _selectedRequest; }
            set { _selectedRequest = value; }
        }

        public RequestViewModel()
        {
            Requests allRequests = new Requests();
            Requests = new ObservableCollection<Request>(allRequests);
        }
    }
}