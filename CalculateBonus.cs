using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session5
{
    public partial class CalculateBonus : Form
    {
        public CalculateBonus()
        {
            Initialize();
        }
        public async void Initialize()
        {
            var asynctask = getSkills();
            InitializeComponent();
            skill_combo.DataSource = await asynctask;
            name_combo.DataSource = await getCompetitors();
        }
        public async Task<List<string>> getSkills()
        {
            using (var db = new Session5Entities())
            {
                return (from s in db.Skills
                        select s.skillName).ToList();
            }
        }
        public async Task<List<string>> getSession()
        {
            using (var db = new Session5Entities())
            {
                var getSkillid = (from s in db.Skills
                                  where s.skillName == skill_combo.SelectedItem.ToString()
                                  select s.skillId).First();
                return (from s in db.Competitions
                        where s.skillIdFK == getSkillid
                        select s.sessionNo.ToString()).ToList();
            }
        }
        public async Task<List<string>> getCompetitors()
        {
            using (var db = new Session5Entities())
            {
                var getSkillid = (from s in db.Skills
                                  where s.skillName == skill_combo.SelectedItem.ToString()
                                  select s.skillId).First();
                return (from s in db.Competitors
                        where s.skillIdFK == getSkillid
                        select s.competitorName).ToList();
            }
        }

        private async void skill_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            name_combo.DataSource = await getCompetitors();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new MainMenu();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
