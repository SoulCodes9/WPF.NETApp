using System.Data;
using System.Collections.Generic;
using BITBackEndApp.Data_Access_Layer;

namespace BITBackEndApp.Models
{
    public class Requests : List<Request>
    {
        public Requests()
        {
            SQLHelper db = new SQLHelper("BIT");
            string sqlString =
                "SELECT DISTINCT r.Request_Id, " +
                "r.Coordinator_Id, " +
                "r.Date_Of_Job, " +
                "r.Start_Time, " +
                "r.End_Time, " +
                "c.Cont_FName, " +
                "c.Cont_lName, " +
                "cl.Client_Id, " +
                "cl.Client_FName, " +
                "cl.Client_LName, " +
                "r.Location_Id, " +
                "l.Address, " +
                "l.Suburb_Name, " +
                "l.PostCode, " +
                "r.Status, " +
                "r.Km_Travelled " +
                "FROM REQUEST r, AVAILABILITY a, CLIENT cl, CONTRACTOR c, LOCATION l " +
                "WHERE a.Contractor_Id = r.Contractor_Id " +
                "AND r.Client_Id = cl.Client_Id " +
                "AND r.Contractor_Id = c.Contractor_ID " +
                "AND l.Location_Id = r.Location_Id " +
                "AND cl.Client_Id = r.Client_Id";
            DataTable requestTable = db.ExecuteSQL(sqlString);
            foreach (DataRow dr in requestTable.Rows)
            {
                Request request = new Request(dr);
                this.Add(request);
            }
        }
    }
}
