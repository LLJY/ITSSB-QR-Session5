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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void assign_seating_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new AssignSeating();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void enter_marks_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new EnterMarks();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void view_results_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new ViewResults();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void analyze_results_Click(object sender, EventArgs e)
        {
            /*
            this.Hide();
            var form = new AnalyzeResults();
            form.Closed += (s, args) => this.Close();
            form.Show();
            */
        }

        private void calculate_bonus_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new CalculateBonus();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new LoginForm();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
