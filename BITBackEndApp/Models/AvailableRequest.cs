using BITBackEndApp.Data_Access_Layer;
using System;
using System.Data;

namespace BITBackEndApp.Models
{
    class AvailableRequest
    {
        private int _contractorId;
        //private int _locationId;
        private string _startTime;
        private string _endTime;
        private string _weekdayName;
        private string _contFName;
        private string _contLName;
        private SQLHelper _db;

        public int ContractorId
        {
            get { return _contractorId; }
            set { _contractorId = value; }
        }

        public string StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }

        //public int LocationId
        //{
        //    get { return _locationId; }
        //    set { _locationId = value; }
        //}

        public string EndTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }

        public string WeekDayName
        {
            get { return _weekdayName; }
            set { _weekdayName = value; }
        }

        public string CFName
        {
            get { return _contFName; }
            set { _contFName = value; }
        }

        public string CLName
        {
            get { return _contLName; }
            set { _contLName = value; }
        }

        public AvailableRequest()
        {
            _db = new SQLHelper("BIT");
        }

        public AvailableRequest(DataRow dr)
        {
            ContractorId = Convert.ToInt32(dr["Contractor_Id"]);
            WeekDayName = dr["WeekDayName"].ToString();
            StartTime = dr["Start_Time"].ToString();
            //LocationId = Convert.ToInt32(dr["Location_Id"]);
            EndTime = dr["End_Time"].ToString();
            CFName = dr["Cont_FName"].ToString();
            CLName = dr["Cont_LName"].ToString();
        }
    }
}
