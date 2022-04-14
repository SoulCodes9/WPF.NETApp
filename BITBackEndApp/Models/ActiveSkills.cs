using BITBackEndApp.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;

namespace BITBackEndApp.Models
{
    class ActiveSkills : List<Skill>
    {
        public ActiveSkills()
        {
            SQLHelper db = new SQLHelper("BIT");
            string sqlStr = "SELECT Skill_Name, IsActive from SKILL WHERE IsActive = 1 ";
            DataTable skillsListTable = db.ExecuteSQL(sqlStr);
            foreach (DataRow dr in skillsListTable.Rows)
            {
                Skill skill = new Skill(dr);
                this.Add(skill);
            }
        }
    }
}
