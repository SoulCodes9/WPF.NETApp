using BITBackEndApp.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;

namespace BITBackEndApp.Models
{
    class AvailableRequests : List<AvailableRequest>
    {
        public AvailableRequests(string suburb, string dayname, string startTime, string endTime, string skill)
        {
            string sqlStr =
              "SELECT DISTINCT c.Contractor_Id, " +
              "a.Start_Time, " +
              " a.End_Time, " +
              "a.WeekDayName, " +
              "c.Cont_FName, " +
              "c.Cont_LName " +
              "FROM " +
              "AVAILABILITY a, " +
              "CONTRACTOR c, " +
              "CONTRACTOR_SKILL cs, " +
              "REQUEST r, " +
              "LOCATION l " +
              " WHERE " +
              "c.Contractor_Id = a.Contractor_Id " +
              "AND a.Contractor_Id = r.Contractor_Id " +
              "AND a.WeekDayName = '" + dayname +
              "' AND ( '" + startTime + "' >= a.Start_Time AND '" + startTime + "' <= a.End_Time) " +
              " OR ( '" + endTime + "' >= a.Start_Time AND '" + endTime + "' <= a.End_Time) " +
              " or ( '" + startTime + "' < a.Start_Time AND '" + endTime + "' > a.End_Time) " +
              " AND cs.Skill_Name = '" + skill + "' AND c.Status = 'Active' " +
              " AND l.Suburb_Name = '" + suburb + "'";
            //string sqlStr =
            //   "SELECT c.Contractor_Id, " +
            //   "a.Start_Time, " +
            //   " a.End_Time, " +
            //   "a.WeekDayName, " +
            //   "c.Cont_FName, " +
            //   "c.Cont_LName, " +
            //   "l.Location_Id " +
            //   "FROM " +
            //   "AVAILABILITY a, " +
            //   "CONTRACTOR c, " +
            //   "CONTRACTOR_SKILL cs, " +
            //   "REQUEST r, " +
            //   "LOCATION l " +
            //   " WHERE " +
            //   "c.Contractor_Id = a.Contractor_Id " +
            //   "AND a.Contractor_Id = r.Contractor_Id " +
            //   "AND a.WeekDayName = '" + dayname +
            //   "' AND ( '" + startTime + "' >= r.Start_Time AND '" + startTime + "' <= r.End_Time) " +
            //   " OR ( '" + endTime + "' >= r.Start_Time AND '" + endTime + "' <= r.End_Time) " +
            //   " or ( '" + startTime + "' < r.Start_Time AND '" + endTime + "' > r.End_Time) " +
            //   " AND cs.Skill_Name = '" + skill + "' AND c.Status = 'Active' " +
            //   " AND l.Suburb_Name = '" + suburb + "'";
            SQLHelper objHelper = new SQLHelper("BIT");
            DataTable sesTable = objHelper.ExecuteSQL(sqlStr);
            foreach (DataRow dr in sesTable.Rows)
            {
                AvailableRequest request = new AvailableRequest(dr);
                this.Add(request);
            }
        }
    }
}
