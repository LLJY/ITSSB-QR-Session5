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
    public partial class ViewResults : Form
    {
        List<ResultsView> DGVList;
        public ViewResults()
        {
            Initialize();
        }
        public async void Initialize()
        {
            var asynctask1 = getSkills();
            InitializeComponent();
            comboBox1.DataSource = await asynctask1;
            comboBox1.SelectedIndex = 0;
            DGVList = await GetResults();
            dataGridView1.DataSource = DGVList;
        }
        public async void refreshDGV()
        {
            var asynctask = GetResults();
            dataGridView1.DataSource = null;
            DGVList = await asynctask;
            dataGridView1.DataSource = DGVList;
        }
        public async Task<List<string>> getSkills()
        {
            using (var db = new Session5Entities())
            {
                return (from s in db.Skills
                        select s.skillName).ToList();
            }
        }
        public async Task<List<ResultsView>> GetResults()
        {
            using (var db = new Session5Entities())
            {
                var returnlist = new List<ResultsView>();
                var getSkillid = (from s in db.Skills
                                  where s.skillName == comboBox1.SelectedItem.ToString()
                                  select s.skillId).First();
                var competitors = (from c in db.Competitors
                                   where c.skillIdFK == getSkillid
                                   select c).ToList();
                foreach (var item in competitors)
                {

                    double mark = 0;
                    var results = (from r in db.Results
                                   where r.recordsIdFK == item.recordsId
                                   select r).ToList();
                    foreach (var item1 in results)
                    {
                        mark += item1.totalMarks;
                    }
                    var rv = new ResultsView()
                    {
                        Competitor = item.competitorName,
                        Country = item.competitorCountry,
                        TotalMarks = mark
                    };
                    returnlist.Add(rv);
                }
                return returnlist;
            }
        }
            
      
        private void SetPositions()
        {
            using (var db = new Session5Entities())
            {
                var CountryPositions = new List<ResultsView>();
                var rv = new ResultsView()
                {
                    Competitor = "Dummy",
                    Country = "Dummy",
                    TotalMarks = 0
                };
                CountryPositions.Add(rv);
                CountryPositions.Add(rv);
                CountryPositions.Add(rv);
                CountryPositions.Add(rv);
                var positions = (from a in DGVList
                                 orderby a.TotalMarks descending
                                 select a);
                var getSkillid = (from s in db.Skills
                                    where s.skillName == comboBox1.SelectedItem.ToString()
                                    select s.skillId).First();
                var comps = (from s in db.Competitions
                                where s.skillIdFK == getSkillid
                                select new { sum = s.q1MaxMarks + s.q2MaxMarks + s.q3MaxMarks + s.q4MaxMarks }).ToList();
                int totalmarks = 0;
                foreach (var item in comps)
                {
                    totalmarks += item.sum;
                }
                foreach (var item in positions)
                {
                    if((item.TotalMarks / totalmarks) >= 0.8 && item.TotalMarks > CountryPositions[0].TotalMarks)
                    {
                        CountryPositions[0] = item;
                    }
                    else if ((item.TotalMarks / totalmarks) >= 0.75 && item.TotalMarks > CountryPositions[1].TotalMarks)
                    {
                        CountryPositions[1] = item;
                    }
                    else if ((item.TotalMarks / totalmarks) >= 0.75 && item.TotalMarks > CountryPositions[2].TotalMarks)
                    {
                        CountryPositions[2] = item;
                    }
                    else if ((item.TotalMarks / totalmarks) >= 0.71 && item.TotalMarks > CountryPositions[2].TotalMarks)
                    {
                        CountryPositions[3] = item;
                    }
                }
                for (int i = 0; i <= 4; i++)
                {                    
                    if(i == 1)
                    {
                        gold_label.Text = CountryPositions[i].Country;
                    }
                    else if (i == 2)
                    {
                        silver_label1.Text = CountryPositions[i].Country;
                    }
                    else if(i == 3)
                    {
                        silver_label2.Text = CountryPositions[i].Country;
                    }
                    else if(i == 4)
                    {
                        black_label.Text = CountryPositions[i].Country;
                    }

                }
            }
        }
        private void setFlag(int pos)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshDGV();
        }
    }
    public class ResultsView
    {
        public string Competitor { get; set; }
        public string Country { get; set; }
        public double TotalMarks { get; set; }
    }
}
