using System.ComponentModel;
using BITBackEndApp.Data_Access_Layer;
using System.Data;

namespace BITBackEndApp.Models
{
    public class PreferredSkill : INotifyPropertyChanged
    {
        private string _skillName;
        private int _contId;
        private SQLHelper _db;
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string prop)
        {
            if (PropertyChanged != null) //this is checking if we do have an event handler
            {
                //PropertyChanged() is a delegate that will call an EventHandler
                //depending on who is Subscribed to listen to this event
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }

        public string SkillName
        {
            get { return _skillName; }
            set { _skillName = value; }
        }
        public int ContractorId
        {
            get { return _contId; }
            set { _contId = value; }
        }
        public PreferredSkill()
        {
            _db = new SQLHelper("BIT");
        }
        public PreferredSkill(DataRow dr)
        {
            SkillName = dr["Skill_Name"].ToString();
        }
    }
}