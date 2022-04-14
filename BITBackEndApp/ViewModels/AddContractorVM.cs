using System;
using BITBackEndApp.Models;
using BITBackEndApp.Data_Access_Layer;
using System.Collections.ObjectModel;
using System.Windows;

namespace BITBackEndApp.ViewModels
{
    class AddContractorVM
    {
        private Contractor _contractor;
        private MyCommand _addCommand;



        public MyCommand AddCommand
        {
            get
            {
                if (_addCommand == null)//this is actually like a state, state is null meaning no command is running then run the Add()
                {
                    _addCommand = new MyCommand(this.AddMethod, true);
                }
                return _addCommand;
            }
            set
            {
                _addCommand = value;
            }
        }

        public void AddMethod()
        {
            string sqlinsertCont =
           "INSERT INTO CONTRACTOR (" +
           "Cont_FName," +
           "Cont_LName," +
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
            Contractor.FirstName + "', '" +
            Contractor.LastName + "', '" +
            Contractor.Street + "', '" +
            Contractor.Suburb + "', '" +
            Contractor.PostCode + "', '" +
            Contractor.State + "', '" +
            Contractor.Phone + "', '" +
            Contractor.Email + "', '" +
            Contractor.DOB.ToString("yyyy-MM-dd") + "', '" +
            Contractor.Password + "', '" +
            "Active ') ";
            SQLHelper objHelper = new SQLHelper("BIT");
            objHelper.ExecuteNonQuery(sqlinsertCont);

            MessageBox.Show("Contractor Has been added to the database");
        }

        public AddContractorVM()
        {
            _contractor = new Contractor();
        }

        public Contractor Contractor
        {
            get { return _contractor; }
            set { _contractor = value; }
        }
    }

}
