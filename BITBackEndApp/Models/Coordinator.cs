using System;
using BITBackEndApp.Data_Access_Layer;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;

namespace BITBackEndApp.Models
{
    public class Coordinator : INotifyPropertyChanged, IDataErrorInfo
    {
        private int _coordinatorId;
        private string _firstName;
        private string _lastName;
        private string _street;
        private string _suburb;
        private string _postcode;
        private string _state;
        private string _phone;
        private string _email;
        private DateTime _dob;
        private string _username;
        private string _password;
        private string _status;
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

        public string Error { get { return null; } }

        public Dictionary<string, string> ErrorCollection { get; private set; } = new Dictionary<string, string>();

        public string this[string propertyName]
        {
            get
            {
                string result = null;
                switch (propertyName)
                {
                    case "FirstName":
                        if (string.IsNullOrWhiteSpace(FirstName))
                        {
                            result = "First name cannot be empty";
                        }
                        break;
                    case "LastName":
                        if (string.IsNullOrWhiteSpace(LastName))
                        {
                            result = "Last name cannot be left empty";
                        }
                        break;
                    case "Street":
                        if (string.IsNullOrWhiteSpace(Street))
                        {
                            result = "Street Address cannot be empty";
                        }
                        break;
                    case "Suburb":
                        if (string.IsNullOrWhiteSpace(Suburb))
                        {
                            result = "Suburb cannot be left empty";
                        }
                        break;
                    case "PostCode":
                        if (string.IsNullOrWhiteSpace(PostCode))
                        {
                            result = "Postcode cannot be empty";
                        }
                        break;
                    case "State":
                        if (string.IsNullOrWhiteSpace(State))
                        {
                            result = "State cannot be empty";
                        }
                        break;
                    case "Phone":
                        if (string.IsNullOrWhiteSpace(Phone))
                        {
                            result = "Phone cannot be empty";
                        }
                        break;
                    case "Email":
                        if (string.IsNullOrWhiteSpace(Email))
                        {
                            result = "Email cannot be empty";
                        }
                        break;
                    case "Password":
                        if (string.IsNullOrWhiteSpace(Password))
                        {
                            result = "Password cannot be empty";
                        }
                        break;
                    case "UserName":
                        if (string.IsNullOrWhiteSpace(UserName))
                        {
                            result = "Username cannot be empty";
                        }
                        break;

                }
                if (result != null)
                {
                    ErrorCollection.Add(propertyName, result);
                }
                OnPropertyChanged("ErrorCollection");
                return result;
            }
        }

        public int CoordinatorId
        {
            get { return _coordinatorId; }
            set { _coordinatorId = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                //when the firstname is set (once when it reads from database other, when
                //the firstname is changed to something else
                OnPropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        public string Street
        {
            get { return _street; }
            set
            {
                _street = value;
                OnPropertyChanged("Street");
            }
        }

        public string Suburb
        {
            get { return _suburb; }
            set
            {
                _suburb = value;
                OnPropertyChanged("Suburb");
            }
        }

        public string PostCode
        {
            get { return _postcode; }
            set
            {
                _postcode = value;
                OnPropertyChanged("PostCode");
            }
        }

        public string State
        {
            get { return _state; }
            set
            {
                _state = value;
                OnPropertyChanged("State");
            }
        }

        public string Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
                OnPropertyChanged("Phone");
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged("Email");
            }
        }

        public DateTime DOB
        {
            get { return _dob; }
            set
            {
                _dob = value;
                OnPropertyChanged("DOB");
            }
        }

        public string UserName
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged("UserName");
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged("Password");
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

        public Coordinator()
        {
            _db = new SQLHelper("BIT");
        }

        public Coordinator(DataRow dr)
        {
            CoordinatorId = Convert.ToInt32(dr["Coordinator_Id"]);
            FirstName = dr["Coord_FName"].ToString();
            LastName = dr["Coord_LName"].ToString();
            Street = dr["Street"].ToString();
            Suburb = dr["Suburb"].ToString();
            PostCode = dr["PostCode"].ToString();
            State = dr["State"].ToString();
            Phone = dr["Phone"].ToString();
            Email = dr["Email"].ToString();
            DOB = Convert.ToDateTime(dr["Date_Of_Birth"]);
            UserName = dr["User_Name"].ToString();
            Password = dr["Password"].ToString();
            Status = dr["Status"].ToString();
            _db = new SQLHelper("BIT");
        }
    }
}
