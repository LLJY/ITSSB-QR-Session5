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
            SetPositions();
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
                var Skillid = (from s in db.Skills
                                  where s.skillName == comboBox1.SelectedItem.ToString()
                                  select s.skillId).First();
                var competitors = (from c in db.Competitors
                                   where c.skillIdFK == Skillid
                                   select c).ToList();
                number_sessions_label.Text = (from c in db.Competitions
                                     where c.skillIdFK == Skillid
                                     select c).Count().ToString();
                completed_sessions_label.Text = (from r in db.Results
                                         where r.totalMarks != 0
                                         where r.Competition.skillIdFK == Skillid
                                         select r.competitionIdFK).Distinct().Count().ToString();
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
                var Skillid = (from s in db.Skills
                                    where s.skillName == comboBox1.SelectedItem.ToString()
                                    select s.skillId).First();
                var comps = (from s in db.Competitions
                                where s.skillIdFK == Skillid
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
                        Console.WriteLine("Gold");
                        CountryPositions[0] = item;
                    }
                    else if ((item.TotalMarks / totalmarks) >= 0.75 && item.TotalMarks > CountryPositions[1].TotalMarks)
                    {
                        Console.WriteLine("Silver");
                        CountryPositions[1] = item;
                    }
                    else if ((item.TotalMarks / totalmarks) >= 0.75 && item.TotalMarks > CountryPositions[2].TotalMarks)
                    {
                        Console.WriteLine("Silver");
                        CountryPositions[2] = item;
                    }
                    else if ((item.TotalMarks / totalmarks) >= 0.71 && item.TotalMarks > CountryPositions[3].TotalMarks)
                    {
                        Console.WriteLine("Bronze");
                        CountryPositions[3] = item;
                    }
                }
                for (int i = 0; i <= 4; i++)
                {
                    try
                    {
                        if (i == 0)
                        {
                            gold_flag.Image = setFlag(CountryPositions[i].Country);
                        }
                        else if (i == 1)
                        {
                            silver_flag.Image = setFlag(CountryPositions[i].Country);
                        }
                        else if (i == 2)
                        {
                            silver2_flag.Image = setFlag(CountryPositions[i].Country);
                        }
                        else if (i == 3)
                        {
                            shit_flag.Image = setFlag(CountryPositions[i].Country);
                        }
                    }
                    catch
                    {

                    }

                }
            }
        }
        public Image setFlag(string country)
        {
            switch (country)
            {
                case "Singapore":
                    return Image.FromFile(@"C:\Images\singapore.png");
                    break;
                case "Malaysia":
                    return Image.FromFile(@"C:\Images\malaysia.png");
                    break;
                case "Indonesia":
                    return Image.FromFile(@"C:\Images\indonesia.png");
                    break;
                case "Philippines":
                    return Image.FromFile(@"C:\Images\phillipines.png");
                    break;
                case "Thailand":
                    return Image.FromFile(@"C:\Images\thailand.png");
                    break;
                case "Brunei":
                    return Image.FromFile(@"C:\Images\brunei.png");
                    break;
                case "Cambodia":
                    return Image.FromFile(@"C:\Images\cambodia.png");
                    break;
            }
            return null;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshDGV();
            gold_flag.Image = null;
            silver_flag.Image = null;
            silver2_flag.Image = null;
            shit_flag.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new MainMenu();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
    public class ResultsView
    {
        public string Competitor { get; set; }
        public string Country { get; set; }
        public double TotalMarks { get; set; }
    }
}
