using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BITBackEndApp.Data_Access_Layer;

namespace BITBackEndApp.Models
{
    public class Clients : List<Client>
    {
        public Clients()
        {
            SQLHelper dbase = new SQLHelper("BIT");
            string sql = "SELECT Client_Id, Client_FName, Client_LName, Street, Suburb, PostCode, State, Phone, Email, Date_Of_Birth, Password, Status FROM CLIENT";
            DataTable clientTable = dbase.ExecuteSQL(sql);
            foreach (DataRow data in clientTable.Rows)
            {
                Client client = new Client(data);
                this.Add(client); //adding clients to the list
            }
        }
    }
}


