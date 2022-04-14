using System.Data;
using System.Collections.Generic;
using BITBackEndApp.Data_Access_Layer;

namespace BITBackEndApp.Models
{
    public class PreferredSkills : List<PreferredSkill>
    {
        public PreferredSkills(int contractorId)
        {
            SQLHelper db = new SQLHelper("BIT");
            string sqlStr =
                "SELECT Skill_Name " +
                "from CONTRACTOR_SKILL " +
                "WHERE Contractor_Id = " + contractorId;
            DataTable skillsTable = db.ExecuteSQL(sqlStr);
            foreach (DataRow dr in skillsTable.Rows)
            {
                PreferredSkill preferredSkill = new PreferredSkill(dr);
                this.Add(preferredSkill);
            }
        }
    }
}
