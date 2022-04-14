using System;
using System.ComponentModel;
using System.Data;
using BITBackEndApp.Data_Access_Layer;

namespace BITBackEndApp.Models
{
    public class Request : INotifyPropertyChanged
    {
        private int _requestId;
        private DateTime _dateofJob;
        private string _requesttime;
        private string _requestendTime;
        private string _clientFName;
        private string _clientLName;
        private int _locationId;
        private string _contFName;
        private string _contLName;
        private int _contId;
        private int _clientId;
        private int _coordId;
        private string _street;
        private string _skillName;
        private string _suburb;
        private string _postcode;
        private string _state;
        private string _status;
        private int _kilometers;
        private SQLHelper _db;
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string prop)
        {
            if (PropertyChanged != null) //this is checking if we do have an event handler
            {
                //PropertyChanged() is a delegate that will call an EventHandler
                //depending on who is Subscribed to listen to this event
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }


        public int ContractorId
        {
            get { return _contId; }
            set { _contId = value; }
        }
        public int RequestId
        {
            get { return _requestId; }
            set { _requestId = value; }
        }
        public int LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }

        public int CoordinatorId
        {
            get { return _coordId; }
            set { _coordId = value; }
        }
        public DateTime DayOfJob
        {
            get { return _dateofJob; }
            set { _dateofJob = value; }
        }
        public string RequestTime
        {
            get { return _requesttime; }
            set { _requesttime = value; }
        }

        public string ClientFName
        {
            get { return _clientFName; }
            set { _clientFName = value; }
        }

        public string ClientLName
        {
            get { return _clientLName; }
            set { _clientLName = value; }
        }

        public string ContFName
        {
            get { return _contFName; }
            set { _contFName = value; }
        }

        public string ContLName
        {
            get { return _contLName; }
            set { _contLName = value; }
        }

        public string SkillName
        {
            get { return _skillName; }
            set { _skillName = value; }
        }
        public int ClientId
        {
            get { return _clientId; }
            set { _clientId = value; }
        }
        public string ReqEndTime
        {
            get { return _requestendTime; }
            set { _requestendTime = value; }
        }

        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }
        public string Suburb
        {
            get { return _suburb; }
            set
            {
                _suburb = value;
            }
        }
        public string PostCode
        {
            get { return _postcode; }
            set
            {
                _postcode = value;
            }
        }
        public string State
        {
            get { return _state; }
            set
            {
                _state = value;
            }
        }
        public string Status
        {
            get { return _status; }
            set
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
        public int Kilometers
        {
            get { return _kilometers; }
            set
            {
                _kilometers = value;
                OnPropertyChanged("Kilometers");
            }
        }

        public Request()
        {
            _db = new SQLHelper("BIT");
        }

        public Request(DataRow dr)
        {
            RequestId = Convert.ToInt32(dr["Request_Id"]);
            DayOfJob = Convert.ToDateTime(dr["Date_Of_Job"]);
            RequestTime = dr["Start_Time"].ToString();
            ClientId = Convert.ToInt32(dr["Client_Id"]);
            CoordinatorId = Convert.ToInt32(dr["Coordinator_ID"]);
            ClientFName = dr["Client_FName"].ToString();
            ClientLName = dr["Client_LName"].ToString();
            ContFName = dr["Cont_FName"].ToString();
            ContLName = dr["Cont_LName"].ToString();
            Street = dr["Address"].ToString();
            //ContractorId = Convert.ToInt32(dr["Contractor_Id"]);
            LocationId = Convert.ToInt32(dr["Location_Id"]);
            Suburb = dr["Suburb_Name"].ToString();
            PostCode = dr["PostCode"].ToString();
            Status = dr["Status"].ToString();
            Kilometers = Convert.ToInt32(dr["Km_Travelled"]);
            ReqEndTime = dr["End_Time"].ToString();
            _db = new SQLHelper("BIT");
        }
    }
}
