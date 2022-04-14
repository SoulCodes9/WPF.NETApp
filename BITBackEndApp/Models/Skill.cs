using BITBackEndApp.Data_Access_Layer;
using System;
using System.ComponentModel;
using System.Data;


namespace BITBackEndApp.Models
{
    class Skill
    {
        private string _skillName;
        private bool _active;
        private string _skillState;
        private SQLHelper _db;
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
        public string SkillName
        {
            get { return _skillName; }
            set { _skillName = value; }
        }
        public bool Active
        {
            get { return _active; }
            set { _active = value; }
        }
        public Skill()
        {
            _db = new SQLHelper("BIT");
        }
        public Skill(DataRow dr)
        {
            SkillName = dr["Skill_Name"].ToString();
            Active = Convert.ToBoolean(dr["IsActive"]);
        }
    }
}
