using BITBackEndApp.Data_Access_Layer;
using BITBackEndApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BITBackEndApp.ViewModels
{
    class SkillsVM
    {
        private PreferredSkill _selectedPreferredSkill;
        private ObservableCollection<PreferredSkill> _contractorSkills;
        private Contractor _selectedContractor;
        private ObservableCollection<Contractor> _contractors;
        private Skill _selectedSkillToAdd;
        private ObservableCollection<Skill> _activeSkills;
        private MyCommand _addCommand;
        private MyCommand _removeCommand;

        public MyCommand RemoveCommand
        {
            get
            {
                if (_removeCommand == null)
                {
                    _removeCommand = new MyCommand(this.RemoveMethod, true);
                }
                return _removeCommand;
            }
            set
            {
                _removeCommand = value;
            }
        }
        public MyCommand AddCommand
        {
            get
            {
                if (_addCommand == null)//this is actually like a active, active is null meaning no command is running then run the Add()
                {
                    _addCommand = new MyCommand(this.AddMethod, true);
                }
                return _addCommand;
            }
            set
            {
                _addCommand = value;
            }
        }

        public void RemoveMethod()
        {
            string sqlStr = "delete from contractorskills where contractorid = " + SelectedContractor.ContractorId + " and skillid = " + SelectedPreferredSkill.SkillName;
            SQLHelper objHelper = new SQLHelper("BIT");
            objHelper.ExecuteNonQuery(sqlStr);
        }

        public void AddMethod()
        {
            string sqlstring = "INSERT INTO CONTRACTOR_SKILL VALUES (" + SelectedContractor.ContractorId + ", '" + SelectedSkillToAdd.SkillName + "')";
            SQLHelper objHelper = new SQLHelper("BIT");
            objHelper.ExecuteNonQuery(sqlstring);
        }
        public ObservableCollection<PreferredSkill> ContractorSkills
        {
            get { return _contractorSkills; }
            set { _contractorSkills = value; }
        }
        public ObservableCollection<Contractor> Contractors
        {
            get { return _contractors; }
            set { _contractors = value; }
        }
        public PreferredSkill SelectedPreferredSkill
        {
            get { return _selectedPreferredSkill; }
            set { _selectedPreferredSkill = value; }
        }
        public Contractor SelectedContractor
        {
            get { return _selectedContractor; }
            set { _selectedContractor = value; }
        }
        public Skill SelectedSkillToAdd
        {
            get { return _selectedSkillToAdd; }
            set { _selectedSkillToAdd = value; }
        }
        public ObservableCollection<Skill> ActiveSkills
        {
            get { return _activeSkills; }
            set { _activeSkills = value; }
        }
        public SkillsVM()
        {
            Contractors contractorList = new Contractors();
            Contractors = new ObservableCollection<Contractor>(contractorList);
            ActiveSkills activeSkillList = new ActiveSkills();
            ActiveSkills = new ObservableCollection<Skill>(activeSkillList);
        }
    }
}
