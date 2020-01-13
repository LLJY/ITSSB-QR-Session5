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
    public partial class AssignSeating : Form
    {
        public AssignSeating()
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

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Done");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new MainMenu();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
