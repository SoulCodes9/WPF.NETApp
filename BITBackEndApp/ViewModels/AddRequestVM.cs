using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using BITBackEndApp.Data_Access_Layer;
using BITBackEndApp.Models;

namespace BITBackEndApp.ViewModels
{
    class AddRequestVM : INotifyPropertyChanged
    {
        private Request _request;
        private ObservableCollection<AvailableRequest> _availableRequest;
        private AvailableRequest _selectedRequest;
        private MyCommand _findCommand;
        private MyCommand _confirmCommand;
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }

        public AvailableRequest SelectedRequest
        {
            get { return _selectedRequest; }
            set { _selectedRequest = value; }
        }

        public MyCommand FindCommand
        {
            get
            {
                if (_findCommand == null)
                {
                    _findCommand = new MyCommand(this.FindMethod, true);
                }
                return _findCommand;
            }
            set
            {
                _findCommand = value;
            }
        }

        public MyCommand ConfirmCommand
        {
            get
            {
                if (_confirmCommand == null)
                {
                    _confirmCommand = new MyCommand(this.AddMethod, true);

                }
                return _confirmCommand;
            }
            set
            {
                _confirmCommand = value;
            }
        }

        public void AddMethod()
        {

            string sqlString =
                "INSERT INTO REQUEST( " +
                " Location_Id, " +
                " Coordinator_Id, " +
                " Skill_Name, " +
                " Date_Of_Job, " +
                " Client_Id, " +
                " Start_Time, " +
                " End_Time, " +
                " Contractor_Id, " +
                " Km_Travelled, " +
                " Status ) " +
                " VALUES( " +
                Request.LocationId + ", " +
                Request.CoordinatorId + ", '" +
                Request.SkillName + "', '" +
                Request.DayOfJob.ToString("yyyy-MM-dd") + "', " +
                Request.ClientId + ", '" +
                Request.RequestTime + "', '" +
                Request.ReqEndTime + "', " +
                SelectedRequest.ContractorId + ", " +
                "'0', 'Booked' )";
            SQLHelper objHelper = new SQLHelper("BIT");
            objHelper.ExecuteNonQuery(sqlString);
            MessageBox.Show("Request has been booked and inserted into the database.");
        }

        public ObservableCollection<AvailableRequest> AvailableRequests
        {
            get { return _availableRequest; }
            set
            {
                _availableRequest = value;
                OnPropertyChanged("AvailableRequests");
            }
        }

        public void FindMethod()
        {
            AvailableRequests allRequests = new AvailableRequests(Request.Suburb, Request.DayOfJob.DayOfWeek.ToString(), Request.RequestTime, Request.ReqEndTime, Request.SkillName);
            AvailableRequests = new ObservableCollection<AvailableRequest>(allRequests);
        }

        public AddRequestVM()
        {
            _request = new Request();
        }

        public Request Request
        {
            get { return _request; }
            set { _request = value; }
        }
    }
}
