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
            var asynctask = GetSkills();
            InitializeComponent();
            skill_combo.DataSource = await asynctask;
            name_combo.DataSource = await GetCompetitors();
        }
        public async Task<List<string>> GetSkills()
        {
            using (var db = new Session5Entities())
            {
                return (from s in db.Skills
                        select s.skillName).ToList();
            }
        }
        public async Task<List<string>> GetSessions()
        {
            using (var db = new Session5Entities())
            {
                var Skillid = (from s in db.Skills
                                  where s.skillName == skill_combo.SelectedItem.ToString()
                                  select s.skillId).First();
                return (from s in db.Competitions
                        where s.skillIdFK == Skillid
                        select s.sessionNo.ToString()).ToList();
            }
        }
        public void UpdateUI()
        {
            using (var db = new Session5Entities())
            {
                int totalcash = 0;
                int totalbonus = 0;
                session1_dgv.Visible = false;
                session2_dgv.Visible = false;
                session3_dgv.Visible = false;
                session4_dgv.Visible = false;
                session1_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                session2_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                session3_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                session4_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                var Skillid = (from s in db.Skills
                               where s.skillName == skill_combo.SelectedItem.ToString()
                               select s.skillId).First();
                var recordsID = (from c in db.Competitors
                                 where c.competitorName == name_combo.SelectedItem.ToString()
                                 select c.recordsId).First();
                var sessions = (from s in db.Competitions
                                where s.skillIdFK == Skillid
                                select s.sessionNo);
                if (sessions.Contains(1))
                {
                    session1_dgv.Visible = true;
                }
                if (sessions.Contains(2))
                {
                    session2_dgv.Visible = true;
                }
                if (sessions.Contains(3))
                {
                    session3_dgv.Visible = true;
                }
                if (sessions.Contains(4))
                {
                    session4_dgv.Visible = true;
                }
                var session1 = (from c in db.Competitions
                                where c.sessionNo == 1
                                where c.skillIdFK == Skillid
                                select c).First();
                int session1qns = 0;
                if (session1.q4MaxMarks != 0)
                {
                    session1qns = 4;
                }
                else if (session1.q3MaxMarks != 0)
                {
                    session1qns = 3;
                }
                else if (session1.q2MaxMarks != 0)
                {
                    session1qns = 2;
                }
                var session2 = (from c in db.Competitions
                                where c.sessionNo == 2
                                where c.skillIdFK == Skillid
                                select c).First();
                int session2qns = 0;
                if (session2.q4MaxMarks != 0)
                {
                    session2qns = 4;
                }
                else if (session2.q3MaxMarks != 0)
                {
                    session2qns = 3;
                }
                else if (session2.q2MaxMarks != 0)
                {
                    session2qns = 2;
                }
                var session3 = (from c in db.Competitions
                                where c.sessionNo == 3
                                where c.skillIdFK == Skillid
                                select c).First();
                int session3qns = 0;
                if (session3.q4MaxMarks != 0)
                {
                    session3qns = 4;
                }
                else if (session3.q3MaxMarks != 0)
                {
                    session3qns = 3;
                }
                else if (session3.q2MaxMarks != 0)
                {
                    session3qns = 2;
                }
                int session4qns = 0;
                if (session4_dgv.Visible == true)
                {
                    var session4 = (from c in db.Competitions
                                    where c.sessionNo == 4
                                    where c.skillIdFK == Skillid
                                    select c).First();
                    if (session4.q4MaxMarks != 0)
                    {
                        session4qns = 4;
                    }
                    else if (session4.q3MaxMarks != 0)
                    {
                        session4qns = 3;
                    }
                    if (session1.q2MaxMarks != 0)
                    {
                        session4qns = 2;
                    }
                }
                var dgvlist1 = new List<BonusCalculate>();
                var dgvlist2 = new List<BonusCalculate>();
                var dgvlist3 = new List<BonusCalculate>();
                var dgvlist4 = new List<BonusCalculate>();
                //fill up dgv1
                try
                {
                    for (int i = 0; i < session1qns; i++)
                    {
                        var sessioninfo = (from r in db.Results
                                           join c in db.Competitions on r.competitionIdFK equals c.competitionId
                                           where c.sessionNo == 1
                                           where r.recordsIdFK == recordsID
                                           select new { r, c }).First();
                        int questionmarks = 0;
                        if (i == 0)
                        {
                            //q1
                            questionmarks = (int)sessioninfo.r.q1Marks;
                        }
                        else if (i == 1)
                        {
                            //q2
                            questionmarks = (int)sessioninfo.r.q2Marks;
                        }
                        else if (i == 2)
                        {
                            //q3
                            questionmarks = (int)sessioninfo.r.q3Marks;
                        }
                        else if (i == 3)
                        {
                            //q4
                            questionmarks = (int)sessioninfo.r.q4Marks;
                        }
                        int maxmarks = 0;
                        if (i == 0)
                        {
                            //q1
                            maxmarks = sessioninfo.c.q1MaxMarks;
                        }
                        else if (i == 1)
                        {
                            //q2
                            maxmarks = sessioninfo.c.q2MaxMarks;
                        }
                        else if (i == 2)
                        {
                            //q3
                            maxmarks = sessioninfo.c.q3MaxMarks;
                        }
                        else if (i == 3)
                        {
                            //q4
                            maxmarks = sessioninfo.c.q4MaxMarks;
                        }
                        if(questionmarks / maxmarks > 0.75)
                        {
                            totalbonus += 5;
                        }
                        totalcash += (questionmarks / maxmarks) * 100;
                        try
                        {
                            var bon = new BonusCalculate()
                            {
                                Question = $"Question {i + 1}",
                                MarksRecieved = questionmarks,
                                MaximumPossibleMarks = maxmarks,
                                AmountRecieved = (questionmarks / maxmarks) * 100
                            };
                            dgvlist1.Add(bon);
                        }
                        catch
                        {
                            var bon = new BonusCalculate()
                            {
                                Question = $"Question {i + 1}",
                                MarksRecieved = questionmarks,
                                MaximumPossibleMarks = maxmarks,
                                AmountRecieved = 0
                            };
                            dgvlist1.Add(bon);
                        }

                    }
                }
                catch
                {

                }
                try
                {
                    //fill up dgv2
                    for (int i = 0; i < session2qns; i++)
                    {
                        var sessioninfo = (from r in db.Results
                                           join c in db.Competitions on r.competitionIdFK equals c.competitionId
                                           where c.sessionNo == 2
                                           where r.recordsIdFK == recordsID
                                           select new { r, c }).First();
                        int questionmarks = 0;
                        if (i == 0)
                        {
                            //q1
                            questionmarks = (int)sessioninfo.r.q1Marks;
                        }
                        else if (i == 1)
                        {
                            //q2
                            questionmarks = (int)sessioninfo.r.q2Marks;
                        }
                        else if (i == 2)
                        {
                            //q3
                            questionmarks = (int)sessioninfo.r.q3Marks;
                        }
                        else if (i == 3)
                        {
                            //q4
                            questionmarks = (int)sessioninfo.r.q4Marks;
                        }
                        int maxmarks = 0;
                        if (i == 0)
                        {
                            //q1
                            maxmarks = sessioninfo.c.q1MaxMarks;
                        }
                        else if (i == 1)
                        {
                            //q2
                            maxmarks = sessioninfo.c.q2MaxMarks;
                        }
                        else if (i == 2)
                        {
                            //q3
                            maxmarks = sessioninfo.c.q3MaxMarks;
                        }
                        else if (i == 3)
                        {
                            //q4
                            maxmarks = sessioninfo.c.q4MaxMarks;
                        }
                        if (questionmarks / maxmarks > 0.75)
                        {
                            totalbonus += 5;
                        }
                        totalcash += (questionmarks / maxmarks) * 100;
                        try
                        {
                            var bon = new BonusCalculate()
                            {
                                Question = $"Question {i + 1}",
                                MarksRecieved = questionmarks,
                                MaximumPossibleMarks = maxmarks,
                                AmountRecieved = (questionmarks / maxmarks) * 100
                            };
                            dgvlist2.Add(bon);
                        }
                        catch
                        {
                            var bon = new BonusCalculate()
                            {
                                Question = $"Question {i + 1}",
                                MarksRecieved = questionmarks,
                                MaximumPossibleMarks = maxmarks,
                                AmountRecieved = 0
                            };
                            dgvlist2.Add(bon);
                        }
                    }
                }
                catch
                {

                }
                try
                {
                    //fill up dgv3
                    for (int i = 0; i < session3qns; i++)
                    {
                        var sessioninfo = (from r in db.Results
                                           join c in db.Competitions on r.competitionIdFK equals c.competitionId
                                           where c.sessionNo == 3
                                           where r.recordsIdFK == recordsID
                                           select new { r, c }).First();
                        int questionmarks = 0;
                        if (i == 0)
                        {
                            //q1
                            questionmarks = (int)sessioninfo.r.q1Marks;
                        }
                        else if (i == 1)
                        {
                            //q2
                            questionmarks = (int)sessioninfo.r.q2Marks;
                        }
                        else if (i == 2)
                        {
                            //q3
                            questionmarks = (int)sessioninfo.r.q3Marks;
                        }
                        else if (i == 3)
                        {
                            //q4
                            questionmarks = (int)sessioninfo.r.q4Marks;
                        }
                        int maxmarks = 0;
                        if (i == 0)
                        {
                            //q1
                            maxmarks = sessioninfo.c.q1MaxMarks;
                        }
                        else if (i == 1)
                        {
                            //q2
                            maxmarks = sessioninfo.c.q2MaxMarks;
                        }
                        else if (i == 2)
                        {
                            //q3
                            maxmarks = sessioninfo.c.q3MaxMarks;
                        }
                        else if (i == 3)
                        {
                            //q4
                            maxmarks = sessioninfo.c.q4MaxMarks;
                        }
                        if (questionmarks / maxmarks > 0.75)
                        {
                            totalbonus += 5;
                        }
                        totalcash += (questionmarks / maxmarks) * 100;
                        try
                        {
                            var bon = new BonusCalculate()
                            {
                                Question = $"Question {i + 1}",
                                MarksRecieved = questionmarks,
                                MaximumPossibleMarks = maxmarks,
                                AmountRecieved = (questionmarks / maxmarks) * 100
                            };
                            dgvlist3.Add(bon);
                        }
                        catch
                        {
                            var bon = new BonusCalculate()
                            {
                                Question = $"Question {i + 1}",
                                MarksRecieved = questionmarks,
                                MaximumPossibleMarks = maxmarks,
                                AmountRecieved = 0
                            };
                            dgvlist3.Add(bon);
                        }
                    }
                }
                catch
                {

                }
                try
                {
                    if (session4_dgv.Visible == true)
                    {
                        //fill up dgv4
                        for (int i = 0; i < session4qns; i++)
                        {
                            var sessioninfo = (from r in db.Results
                                               join c in db.Competitions on r.competitionIdFK equals c.competitionId
                                               where c.sessionNo == 4
                                               where r.recordsIdFK == recordsID
                                               select new { r, c }).First();
                            int questionmarks = 0;
                            if (i == 0)
                            {
                                //q1
                                questionmarks = (int)sessioninfo.r.q1Marks;
                            }
                            else if (i == 1)
                            {
                                //q2
                                questionmarks = (int)sessioninfo.r.q2Marks;
                            }
                            else if (i == 2)
                            {
                                //q3
                                questionmarks = (int)sessioninfo.r.q3Marks;
                            }
                            else if (i == 3)
                            {
                                //q4
                                questionmarks = (int)sessioninfo.r.q4Marks;
                            }
                            int maxmarks = 0;
                            if (i == 0)
                            {
                                //q1
                                maxmarks = sessioninfo.c.q1MaxMarks;
                            }
                            else if (i == 1)
                            {
                                //q2
                                maxmarks = sessioninfo.c.q2MaxMarks;
                            }
                            else if (i == 2)
                            {
                                //q3
                                maxmarks = sessioninfo.c.q3MaxMarks;
                            }
                            else if (i == 3)
                            {
                                //q4
                                maxmarks = sessioninfo.c.q4MaxMarks;
                            }
                            if (questionmarks / maxmarks > 0.75)
                            {
                                totalbonus += 5;
                            }
                            totalcash += (questionmarks / maxmarks) * 100;
                            try
                            {
                                var bon = new BonusCalculate()
                                {
                                    Question = $"Question {i + 1}",
                                    MarksRecieved = questionmarks,
                                    MaximumPossibleMarks = maxmarks,
                                    AmountRecieved = (questionmarks / maxmarks) * 100
                                };
                                dgvlist4.Add(bon);
                            }
                            catch
                            {
                                var bon = new BonusCalculate()
                                {
                                    Question = $"Question {i + 1}",
                                    MarksRecieved = questionmarks,
                                    MaximumPossibleMarks = maxmarks,
                                    AmountRecieved = 0
                                };
                                dgvlist4.Add(bon);
                            }
                        }

                    }
                }
                catch
                {

                }
                totalcash += totalbonus;
                total_amount.Text = totalcash.ToString();
                total_bonus.Text = totalbonus.ToString();
                session1_dgv.DataSource = dgvlist1;
                session2_dgv.DataSource = dgvlist2;
                session3_dgv.DataSource = dgvlist3;
                session4_dgv.DataSource = dgvlist4;
            }
        }
        public async Task<List<string>> GetCompetitors()
        {
            using (var db = new Session5Entities())
            {
                var Skillid = (from s in db.Skills
                                  where s.skillName == skill_combo.SelectedItem.ToString()
                                  select s.skillId).First();
                return (from s in db.Competitors
                        where s.skillIdFK == Skillid
                        select s.competitorName).ToList();
            }
        }

        private async void skill_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            name_combo.DataSource = await GetCompetitors();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new MainMenu();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void CalculateBonus_Load(object sender, EventArgs e)
        {

        }

        private void name_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }
    }
    public class BonusCalculate
    {
        public string Question { get; set; }
        public int MarksRecieved { get; set; }
        public int MaximumPossibleMarks { get; set; }
        public int AmountRecieved { get; set; }
    }
}
