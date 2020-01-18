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
    public partial class EnterMarks : Form
    {
        List<int> questionmaxmarks = new List<int>();
        List<MarksEnter> dgvdata;
        public EnterMarks()
        {
            Initialize();
        }
        public async void Initialize()
        {
            var asynctask = getSkills();
            InitializeComponent();
            skill_combo.DataSource = await asynctask;
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
        public void GetData()
        {
            using (var db = new Session5Entities())
            {
                var returnlist = new List<MarksEnter>();
                var getSkillid = (from s in db.Skills
                                  where s.skillName == skill_combo.SelectedItem.ToString()
                                  select s.skillId).First();
                var getSession = int.Parse(session_combo.SelectedItem.ToString());
                var competitions = (from c in db.Competitions
                                    where c.skillIdFK == getSkillid
                                    where c.sessionNo == getSession
                                    select c).First();
                questionmaxmarks.Clear();
                questionmaxmarks.Add(competitions.q1MaxMarks);
                questionmaxmarks.Add(competitions.q2MaxMarks);
                questionmaxmarks.Add(competitions.q3MaxMarks);
                questionmaxmarks.Add(competitions.q4MaxMarks);
                var me1 = new MarksEnter()
                {
                    Question = "Question 1",
                    Grade = "Poor",
                    Marks = 0
                };
                var me2 = new MarksEnter()
                {
                    Question = "Question 2",
                    Grade = "Poor",
                    Marks = 0
                };
                returnlist.Add(me1);
                returnlist.Add(me2);
                if (competitions.q3MaxMarks != 0)
                {
                    var me3 = new MarksEnter()
                    {
                        Question = "Question 3",
                        Grade = "Poor",
                        Marks = 0
                    };
                    returnlist.Add(me3);
                }
                if (competitions.q4MaxMarks != 0)
                {
                    var me4 = new MarksEnter()
                    {
                        Question = "Question 4",
                        Grade = "Poor",
                        Marks = 0
                    };
                    returnlist.Add(me4);
                }
                dgvdata = returnlist;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dgvdata;
            }
        }
        public void generateDGV()
        {
            dataGridView1.DataSource = null;
            foreach (var item in dgvdata)
            {
                
            }
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            using (var db = new Session5Entities())
            {
                var getSkillid = (from s in db.Skills
                                  where s.skillName == skill_combo.SelectedItem.ToString()
                                  select s.skillId).First();
                var getSession = int.Parse(session_combo.SelectedItem.ToString());
                var competitions = (from c in db.Competitions
                                    where c.skillIdFK == getSkillid
                                    where c.sessionNo == getSession
                                    select c).First();
                var user = name_combo.SelectedItem.ToString();
                var getUserID = (from u in db.Competitors
                                 where u.competitorName == user
                                 select u.recordsId).First();
                var r = new Result()
                {
                    competitionIdFK = competitions.competitionId,
                    recordsIdFK = getUserID,
                    q1Marks = 0,
                    q2Marks = 0,
                    q3Marks = 0,
                    q4Marks = 0,
                    totalMarks = 00,
                };
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                   if(i == 0)
                    {
                        r.q1Marks = double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    }else if (i == 1)
                    {
                        r.q2Marks = double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    }
                    else if (i == 2)
                    {
                        r.q3Marks = double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    }
                    if (i == 3)
                    {
                        r.q4Marks = double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    }
                }
                r.totalMarks = r.q1Marks + r.q2Marks + r.q3Marks + r.q4Marks;
                db.Results.Add(r);
                db.SaveChanges();
                MessageBox.Show("Done");
                
            }
        }

        private async void skill_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            session_combo.DataSource = await getSession();
        }

        private async void session_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            name_combo.DataSource = await getCompetitors();
        }

        private void name_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int totalmarks = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if(dataGridView1.Rows[i].Cells[1].Value.ToString() == "Good")
                {
                    dataGridView1.Rows[i].Cells[2].Value = questionmaxmarks[i]; 
                }
                else if (dataGridView1.Rows[i].Cells[1].Value.ToString() == "Average")
                {
                    dataGridView1.Rows[i].Cells[2].Value = questionmaxmarks[i]*0.65;
                }
                else if (dataGridView1.Rows[i].Cells[1].Value.ToString() == "Poor")
                {
                    dataGridView1.Rows[i].Cells[2].Value = questionmaxmarks[i]*0.20;
                }
                totalmarks += int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
            }
            total_label.Text = totalmarks.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new MainMenu();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
    public class MarksEnter
    {
        public string Question { get; set; }
        public string Grade { get; set; }
        public double Marks { get; set; }
    }
}
