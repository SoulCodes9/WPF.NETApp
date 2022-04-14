using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BITBackEndApp.Models;
using BITBackEndApp.Data_Access_Layer;
using System.Windows;
using System.Windows.Controls;

namespace BITBackEndApp.ViewModels
{
    class AddClientVM
    {
        private Client _client;

        private MyCommand _addCmd;
       
        public MyCommand AddCommand
        {
            get
            {
                if (_addCmd == null)
                {
                    _addCmd = new MyCommand(this.AddMethod, true);
                }
                return _addCmd;
            }
            set
            {
                _addCmd = value;
            }
        }

        /// <summary>
        /// This Method creates a new record
        /// </summary>
        public void AddMethod()
        {
            //Logic 
            string sqlString =
           "INSERT INTO CLIENT (" +
           "Client_FName," +
           "Client_LName," +
           "Street," +
           "Suburb," +
           "PostCode," +
           "State," +
           "Phone," +
           "Email," +
           "Date_Of_Birth, " +
           "Password, " +
           "Status )" +
           " VALUES ('" +
            Client.FirstName + "', '" +
            Client.LastName + "', '" +
            Client.Street + "', '" +
            Client.Suburb + "', '" +
            Client.PostCode + "', '" +
            Client.State + "', '" +
            Client.Phone + "', '" +
            Client.Email + "', '" +
            Client.DOB.ToString("yyyy-MM-dd") + "', '" +
            Client.Password + "', '" +
            "Active ') ";

            SQLHelper sqlHelp = new SQLHelper("BIT");
            sqlHelp.ExecuteNonQuery(sqlString);

            MessageBox.Show("New Client has been successfully added.");

        }


        public AddClientVM()
        {
            _client = new Client();
        }

        public Client Client
        {
            get { return _client; }
            set { _client = value; }
        }

    }
}
