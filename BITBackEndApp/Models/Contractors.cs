using BITBackEndApp.Data_Access_Layer;
using System.Collections.Generic;
using System.Data;


namespace BITBackEndApp.Models
{
    class Contractors : List<Contractor>
    {
        public Contractors()
        {
            SQLHelper db = new SQLHelper("BIT");
            string sql =
                "SELECT * " +
                "FROM CONTRACTOR";
            DataTable contTable = db.ExecuteSQL(sql);
            foreach (DataRow dr in contTable.Rows)
            {
                Contractor contractor = new Contractor(dr);
                this.Add(contractor);
            }
        }
    }
}
