using System.Collections.Generic;
using System.Data;
using BITBackEndApp.Data_Access_Layer;

namespace BITBackEndApp.Models
{
    public class Coordinators : List<Coordinator>
    {
        public Coordinators()
        {
            SQLHelper db = new SQLHelper("BIT");
            string sqlStr =
                "SELECT Coordinator_ID, " +
                "Coord_FName, " +
                "Coord_LName, " +
                "Street," +
                "Suburb," +
                "PostCode," +
                "State," +
                "Phone," +
                "Email," +
                "Date_Of_Birth, " +
                "User_Name," +
                "Password," +
                "Status " + 
                "FROM Coordinator";
            DataTable coordTable = db.ExecuteSQL(sqlStr);

            foreach (DataRow dataRow in coordTable.Rows)
            {
                Coordinator coordinator = new Coordinator(dataRow);
                this.Add(coordinator);
            }
        }
    }
}
