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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using(var db = new Session5Entities())
                {
                    var user = (from u in db.Users
                                where u.userId == user_box.Text
                                where u.passwd == password_box.Text
                                select u).First();
                    this.Hide();
                    var form = new MainMenu();
                    form.Closed += (s, args) => this.Close();
                    form.Show();
                }
            }
            catch
            {
                MessageBox.Show("Invalid Login");
            }
        }
    }
}
