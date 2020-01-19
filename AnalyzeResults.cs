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
    public partial class AnalyzeResults : Form
    {
        public AnalyzeResults()
        {
            Initialize();
        }
        private async void Initialize()
        {
            var asynctask = GetSkills();
            InitializeComponent();
            skill_combo.DataSource = await asynctask;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private async Task<List<string>> GetSkills()
        {
            using (var db = new Session5Entities())
            {
                return (from s in db.Skills
                        select s.skillName).ToList();
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
        public double GetMedian(double[] array)
        {
            double[] tempArray = array;
            int count = tempArray.Length;

            Array.Sort(tempArray);

            double medianValue = 0;

            if (count % 2 == 0)
            {
                // count is even, need to get the middle two elements, add them together, then divide by 2
                double middleElement1 = tempArray[(count / 2) - 1];
                double middleElement2 = tempArray[(count / 2)];
                medianValue = (middleElement1 + middleElement2) / 2;
            }
            else
            {
                // count is odd, simply get the middle element.
                medianValue = tempArray[(count / 2)];
            }

            return medianValue;
        }
        private async void UpdateUI()
        {
            toughestsession_label.Text = "No Data";
            easiestsession_label.Text = "No Data";
            pictureBox1.Image = null;

            try
            {
                using (var db = new Session5Entities())
                {

                    var Skillid = (from s in db.Skills
                                   where s.skillName == skill_combo.SelectedItem.ToString()
                                   select s.skillId).First();
                    var best = (from b in db.Results
                                join c in db.Competitors on b.recordsIdFK equals c.recordsId
                                where c.skillIdFK == Skillid
                                orderby b.totalMarks descending
                                select new
                                {
                                    Compet = c.recordsId,
                                    Country = c.competitorCountry,
                                    Session = b.Competition.sessionNo,
                                    Score = b.totalMarks
                                });
                    var groupbest = (from b in best
                                     group b by new { b.Country } into u
                                     select new
                                     {
                                         u,
                                         TotalMarks = u.Sum(a => a.Score)
                                     }).ToList();
                    var orderedlist = (from b in groupbest
                                       orderby b.TotalMarks
                                       select b).ToList();
                    var results = (from b in db.Results
                                   group b by new { b.competitionIdFK } into u
                                   select new
                                   {
                                       CompID = u.Key,
                                       TotalMarks = u.Sum(a => a.totalMarks)
                                   }).ToList();
                    pictureBox1.Image = setFlag(orderedlist.FirstOrDefault().u.Key.Country.ToString());
                    var SessionsAsc = (from r in results
                                    orderby r.TotalMarks ascending
                                    select r.CompID).ToList();
                    var SessionsDsc = (from r in results
                                       orderby r.TotalMarks descending
                                       select r.CompID).ToList();
                    var toughestcompID = SessionsAsc.First().competitionIdFK;
                    var theToughestSession = (from c in db.Results
                                      where c.competitionIdFK == toughestcompID
                                      select c).ToList();
                    toughestsession_label.Text = $"{(from d in db.Competitions where d.competitionId == toughestcompID select d.sessionNo).First().ToString()} ({theToughestSession.First().totalMarks} - {theToughestSession.Last().totalMarks})";
                    var easycompID = SessionsDsc.First().competitionIdFK;
                    var theEasiestSession = (from c in db.Results
                                              where c.competitionIdFK == easycompID
                                             select c).ToList();
                    easiestsession_label.Text = $"{(from d in db.Competitions where d.competitionId == easycompID select d.sessionNo).First().ToString()} ({theEasiestSession.First().totalMarks} - {theEasiestSession.Last().totalMarks})";
                    chart1.Series.Clear();
                    /*
                    var groupcompetitor = (from b in best
                                     group b by new { b.Compet } into u
                                     select new
                                     {
                                         CompetitorID = u.Key.Compet,
                                         SessionNo = u.Select(a => a.Session),
                                         TotalMarks = u.Select(a => a.Score)
                                     }).ToList();
                                     */
                    var listofmarks = (from r in db.Results
                                       where r.Competition.skillIdFK == Skillid
                                       select r.totalMarks).ToArray();
                    medianmark_session.Text = GetMedian(listofmarks).ToString();
                    var gc = (from b in db.Competitors
                              join c in db.Results on b.recordsId equals c.recordsIdFK
                              join cs in db.Competitions on c.competitionIdFK equals cs.competitionId
                              group new { b, c, cs } by new { b.competitorId, c.totalMarks, cs.sessionNo } into u
                              select new
                              {
                                  TotalMarks = u.Key.totalMarks,
                                  SessionNo = u.Key.sessionNo,
                                  CompetitorID = u.Key.competitorId
                              }).ToList();
                    foreach (var item in gc)
                    {
                        chart1.Series.Add($"Competitor {item.CompetitorID}");
                        chart1.Series[$"Competitor {item.CompetitorID}"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        chart1.Series[$"Competitor {item.CompetitorID}"].Points.AddXY($"Session {item.SessionNo}", item.TotalMarks);
                    }
                }
            }
            catch
            {

            }
        }

        private void skill_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new MainMenu();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
