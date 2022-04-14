using BITBackEndApp.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace BITBackEndApp.Models
{
    class Skills : List<Skill>
    {
        public Skills()
        {
            SQLHelper db = new SQLHelper("BIT");
            string sqlStr = "SELECT Skill_Name, IsActive from SKILL ";
            DataTable skillsListTable = db.ExecuteSQL(sqlStr);
            foreach (DataRow dr in skillsListTable.Rows)
            {
                Skill skill = new Skill(dr);
                this.Add(skill);
            }
        }
    }
}
