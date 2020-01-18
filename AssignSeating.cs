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
        List<Competitors> UnassignedList= new List<Competitors>();
        List<Competitors> assignedlist = new List<Competitors>();
        SwapState StateSwap = SwapState.Off;
        int firstswap = 0;
        int secondswap = 0;
        public AssignSeating()
        {
            Initialize();
        }
        public async void Initialize()
        {
            var asynctask = GetSkills();
            InitializeComponent();
            skill_combo.DataSource = await asynctask;
            swap_button.Visible = false;

        }
        private void UpdateUI()
        {
            using (var db = new Session5Entities())
            {
                UnassignedList.Clear();
                unassigned_listbox.Items.Clear();
                var selectedskill = skill_combo.SelectedItem.ToString();
                var skillid = (from s in db.Skills
                               where s.skillName == selectedskill
                               select s.skillId).First();
                var comps = (from c in db.Competitors
                             where c.skillIdFK == skillid
                             select c).ToList();
                foreach (var item in comps)
                {
                    unassigned_listbox.Items.Add($"{item.competitorName}, {item.competitorCountry}");
                    var c = new Competitors()
                    {
                        Country = item.competitorCountry,
                        CountryAbbr = item.competitorId,
                        ID = item.recordsId,
                        Name = item.competitorName,
                        SeatNumber = 0
                    };
                    UnassignedList.Add(c);
                    Console.WriteLine(c);
                }
                if(comps.Count < 8)
                {
                    seat7.Visible = false;
                    seat8.Visible = false;
                }

            }
        }
        public async Task<List<string>> GetSkills()
        {
            using (var db = new Session5Entities())
            {
                return (from s in db.Skills
                        select s.skillName).ToList();
            }
        }

        private void Skill_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }
        private bool AssignSeat(int seatnumber, Competitors selected)
        {
            if(seatnumber > 2)
            {
                switch (seatnumber)
                {
                    case 3:
                        if (!seat1.Text.Contains(selected.CountryAbbr.Substring(0, 2)))
                        {
                            seat3.Text = $"3 \n{selected.CountryAbbr}";
                            seat3.BackColor = Color.LightBlue;
                            selected.SeatNumber = 3;
                            assignedlist.Add(selected);
                            UnassignedList.Remove(selected);
                            foreach (var item in UnassignedList)
                            {
                                unassigned_listbox.Items.Add($"{item.Name}, {item.Country}");
                            }
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    case 4:
                        if (!seat2.Text.Contains(selected.CountryAbbr.Substring(0, 2)))
                        {
                            seat4.Text = $"4 \n{selected.CountryAbbr}";
                            seat4.BackColor = Color.LightBlue;
                            selected.SeatNumber = 4;
                            assignedlist.Add(selected);
                            UnassignedList.Remove(selected);
                            foreach (var item in UnassignedList)
                            {
                                unassigned_listbox.Items.Add($"{item.Name}, {item.Country}");
                            }
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    case 5:
                        if (!seat3.Text.Contains(selected.CountryAbbr.Substring(0, 2)))
                        {
                            seat5.Text = $"5 \n{selected.CountryAbbr}";
                            seat5.BackColor = Color.LightBlue;
                            selected.SeatNumber = 5;
                            assignedlist.Add(selected);
                            UnassignedList.Remove(selected);
                            foreach (var item in UnassignedList)
                            {
                                unassigned_listbox.Items.Add($"{item.Name}, {item.Country}");
                            }
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    case 6:
                        if (!seat4.Text.Contains(selected.CountryAbbr.Substring(0, 2)))
                        {
                            seat6.Text = $"6 \n{selected.CountryAbbr}";
                            seat6.BackColor = Color.LightBlue;
                            selected.SeatNumber = 6;
                            assignedlist.Add(selected);
                            UnassignedList.Remove(selected);
                            foreach (var item in UnassignedList)
                            {
                                unassigned_listbox.Items.Add($"{item.Name}, {item.Country}");
                            }
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    case 7:
                        if (!seat5.Text.Contains(selected.CountryAbbr.Substring(0, 2)))
                        {
                            seat7.Text = $"7 \n{selected.CountryAbbr}";
                            seat7.BackColor = Color.LightBlue;
                            selected.SeatNumber = 7;
                            assignedlist.Add(selected);
                            UnassignedList.Remove(selected);
                            foreach (var item in UnassignedList)
                            {
                                unassigned_listbox.Items.Add($"{item.Name}, {item.Country}");
                            }
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    case 8:
                        if (!seat6.Text.Contains(selected.CountryAbbr.Substring(0, 2)))
                        {
                            seat8.Text = $"8 \n{selected.CountryAbbr}";
                            seat8.BackColor = Color.LightBlue;
                            selected.SeatNumber = 8;
                            assignedlist.Add(selected);
                            UnassignedList.Remove(selected);
                            foreach (var item in UnassignedList)
                            {
                                unassigned_listbox.Items.Add($"{item.Name}, {item.Country}");
                            }
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                        break;
                }
            }
            else
            {
                switch (seatnumber)
                {
                    case 1:
                        seat1.Text = $"1 \n{selected.CountryAbbr}";
                        seat1.BackColor = Color.LightBlue;
                        selected.SeatNumber = 1;
                        assignedlist.Add(selected);
                        UnassignedList.Remove(selected);
                        foreach (var item in UnassignedList)
                        {
                            unassigned_listbox.Items.Add($"{item.Name}, {item.Country}");
                        }
                        break;
                    case 2:
                        seat2.Text = $"2 \n{selected.CountryAbbr}";
                        seat2.BackColor = Color.LightBlue;
                        selected.SeatNumber = 2;
                        assignedlist.Add(selected);
                        UnassignedList.Remove(selected);
                        foreach (var item in UnassignedList)
                        {
                            unassigned_listbox.Items.Add($"{item.Name}, {item.Country}");
                        }
                        break;
                }
                foreach (var item in UnassignedList)
                {
                    unassigned_listbox.Items.Add($"{item.Name}, {item.Country}");
                }
                    return true;
            }
            return false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //assign
            var selected = UnassignedList[unassigned_listbox.SelectedIndex];
            if (seat1.BackColor == Color.Yellow)
            {
                AssignSeat(1, selected);
            }
            else if (seat2.BackColor == Color.Yellow)
            {
                AssignSeat(2, selected);
            }
            else if (seat3.BackColor == Color.Yellow)
            {
                if(!AssignSeat(3, selected))
                {
                    MessageBox.Show("Wait, that's illegal!");
                }
            }
            else if (seat4.BackColor == Color.Yellow)
            {
                if (!AssignSeat(4, selected))
                {
                    MessageBox.Show("Wait, that's illegal!");
                }
            }
            else if (seat5.BackColor == Color.Yellow)
            {
                if (!AssignSeat(5, selected))
                {
                    MessageBox.Show("Wait, that's illegal!");
                }
            }
            else if (seat6.BackColor == Color.Yellow)
            {
                if (!AssignSeat(6, selected))
                {
                    MessageBox.Show("Wait, that's illegal!");
                }
            }
            else if (seat7.BackColor == Color.Yellow)
            {
                if (!AssignSeat(7, selected))
                {
                    MessageBox.Show("Wait, that's illegal!");
                }
            }
            else if (seat8.BackColor == Color.Yellow)
            {
                if (!AssignSeat(8, selected))
                {
                    MessageBox.Show("Wait, that's illegal!");
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //swap 
            //first step, select first seat.
            if (StateSwap == SwapState.Off)
            {
                int firstseat = 0;
                int secondseat = 0;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                MessageBox.Show("Swap mode is on, select two seats!");
                StateSwap = SwapState.First;
            }
            else
            {
                StateSwap = SwapState.Off;
                firstswap = 1;
                secondswap = 2;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                try
                {
                    var firstperson = (from f in assignedlist
                                       where f.SeatNumber == firstswap
                                       select f).First();
                    var secondperson = (from f in assignedlist
                                        where f.SeatNumber == secondswap
                                        select f).First();
                    assignedlist.Remove(firstperson);
                    assignedlist.Remove(secondperson);
                    UnassignedList.Add(firstperson);
                    UnassignedList.Add(secondperson);
                    if (AssignSeat(secondswap, firstperson) && AssignSeat(firstswap, secondperson))
                    {

                    }
                    else
                    {
                        //if something goes wrong, assign back to original.
                        AssignSeat(secondswap, secondperson);
                        AssignSeat(firstswap, firstperson);
                        MessageBox.Show("Wait, that's illegal!");
                    }
                }
                catch(Exception err)
                {
                    throw err;
                    MessageBox.Show("An Error has occured!");
                }
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            //random
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //confirm
        }

        private void Seat1_Click(object sender, EventArgs e)
        {
            if (StateSwap == SwapState.Off)
            {
                if (seat1.BackColor != Color.LightBlue)
                {
                    seat1.BackColor = Color.Yellow;
                    seat2.BackColor = Color.White;
                    seat3.BackColor = Color.White;
                    seat4.BackColor = Color.White;
                    seat5.BackColor = Color.White;
                    seat6.BackColor = Color.White;
                    seat7.BackColor = Color.White;
                    seat8.BackColor = Color.White;
                }
            }
            else if(StateSwap == SwapState.First)
            {
                seat1.BackColor = Color.Red;
                seat2.BackColor = Color.White;
                seat3.BackColor = Color.White;
                seat4.BackColor = Color.White;
                seat5.BackColor = Color.White;
                seat6.BackColor = Color.White;
                seat7.BackColor = Color.White;
                seat8.BackColor = Color.White;
                firstswap = 1;
                StateSwap = SwapState.Second;
            }
            else if (StateSwap == SwapState.Second && seat1.BackColor != Color.Red)
            {
                seat1.BackColor = Color.Green;
                secondswap = 1;
                Button3_Click(null, null);
            }
        }

        private void Seat2_Click(object sender, EventArgs e)
        {
            if (StateSwap == SwapState.Off)
            {
                if (seat2.BackColor != Color.LightBlue)
                {
                    seat1.BackColor = Color.White;
                    seat2.BackColor = Color.Yellow;
                    seat3.BackColor = Color.White;
                    seat4.BackColor = Color.White;
                    seat5.BackColor = Color.White;
                    seat6.BackColor = Color.White;
                    seat7.BackColor = Color.White;
                    seat8.BackColor = Color.White;
                }
            }
            else if (StateSwap == SwapState.First)
            {
                seat1.BackColor = Color.White;
                seat2.BackColor = Color.Red;
                seat3.BackColor = Color.White;
                seat4.BackColor = Color.White;
                seat5.BackColor = Color.White;
                seat6.BackColor = Color.White;
                seat7.BackColor = Color.White;
                seat8.BackColor = Color.White;
                firstswap = 2;
                StateSwap = SwapState.Second;
            }
            else if (StateSwap == SwapState.Second && seat2.BackColor != Color.Red)
            {
                seat2.BackColor = Color.Green;
                secondswap = 2;
                Button3_Click(null, null);
            }
        }

        private void Seat3_Click(object sender, EventArgs e)
        {
            if (StateSwap == SwapState.Off)
            {
                if (seat3.BackColor != Color.LightBlue)
                {
                    seat1.BackColor = Color.White;
                    seat2.BackColor = Color.White;
                    seat3.BackColor = Color.Yellow;
                    seat4.BackColor = Color.White;
                    seat5.BackColor = Color.White;
                    seat6.BackColor = Color.White;
                    seat7.BackColor = Color.White;
                    seat8.BackColor = Color.White;
                }
            }
            else if (StateSwap == SwapState.First)
            {
                seat1.BackColor = Color.White;
                seat2.BackColor = Color.White;
                seat3.BackColor = Color.Red;
                seat4.BackColor = Color.White;
                seat5.BackColor = Color.White;
                seat6.BackColor = Color.White;
                seat7.BackColor = Color.White;
                seat8.BackColor = Color.White;
                firstswap = 3;
                StateSwap = SwapState.Second;
            }
            else if (StateSwap == SwapState.Second && seat3.BackColor != Color.Red)
            {
                seat3.BackColor = Color.Green;
                secondswap = 3;
                Button3_Click(null, null);
            }
        }

        private void Seat4_Click(object sender, EventArgs e)
        {
            if (StateSwap == SwapState.Off)
            {
                if (seat4.BackColor != Color.LightBlue)
                {
                    seat1.BackColor = Color.White;
                    seat2.BackColor = Color.White;
                    seat3.BackColor = Color.White;
                    seat4.BackColor = Color.Yellow;
                    seat5.BackColor = Color.White;
                    seat6.BackColor = Color.White;
                    seat7.BackColor = Color.White;
                    seat8.BackColor = Color.White;
                }
            }
            else if (StateSwap == SwapState.First)
            {
                seat1.BackColor = Color.White;
                seat2.BackColor = Color.White;
                seat3.BackColor = Color.White;
                seat4.BackColor = Color.Red;
                seat5.BackColor = Color.White;
                seat6.BackColor = Color.White;
                seat7.BackColor = Color.White;
                seat8.BackColor = Color.White;
                firstswap = 4;
                StateSwap = SwapState.Second;
            }
            else if (StateSwap == SwapState.Second && seat4.BackColor != Color.Red)
            {
                seat4.BackColor = Color.Green;
                secondswap = 4;
                Button3_Click(null, null);
            }
        }

        private void Seat5_Click(object sender, EventArgs e)
        {
            if (StateSwap == SwapState.Off)
            {
                if (seat5.BackColor != Color.LightBlue)
                {
                    seat1.BackColor = Color.White;
                    seat2.BackColor = Color.White;
                    seat3.BackColor = Color.White;
                    seat4.BackColor = Color.White;
                    seat5.BackColor = Color.Yellow;
                    seat6.BackColor = Color.White;
                    seat7.BackColor = Color.White;
                    seat8.BackColor = Color.White;
                }
            }
            else if (StateSwap == SwapState.First)
            {
                seat1.BackColor = Color.White;
                seat2.BackColor = Color.White;
                seat3.BackColor = Color.White;
                seat4.BackColor = Color.White;
                seat5.BackColor = Color.Red;
                seat6.BackColor = Color.White;
                seat7.BackColor = Color.White;
                seat8.BackColor = Color.White;
                firstswap = 5;
                StateSwap = SwapState.Second;
            }
            else if (StateSwap == SwapState.Second && seat5.BackColor != Color.Red)
            {
                seat5.BackColor = Color.Green;
                secondswap = 5;
                Button3_Click(null, null);
            }
        }
        private void Seat6_Click(object sender, EventArgs e)
        {
            if (StateSwap == SwapState.Off)
            {
                if (seat6.BackColor != Color.LightBlue)
                {
                    seat1.BackColor = Color.White;
                    seat2.BackColor = Color.White;
                    seat3.BackColor = Color.White;
                    seat4.BackColor = Color.White;
                    seat5.BackColor = Color.White;
                    seat6.BackColor = Color.Yellow;
                    seat7.BackColor = Color.White;
                    seat8.BackColor = Color.White;
                }
            }
            else if (StateSwap == SwapState.First)
            {
                seat1.BackColor = Color.White;
                seat2.BackColor = Color.White;
                seat3.BackColor = Color.White;
                seat4.BackColor = Color.White;
                seat5.BackColor = Color.White;
                seat6.BackColor = Color.Red;
                seat7.BackColor = Color.White;
                seat8.BackColor = Color.White;
                firstswap = 6;
                StateSwap = SwapState.Second;
            }
            else if (StateSwap == SwapState.Second && seat6.BackColor != Color.Red)
            {
                seat6.BackColor = Color.Green;
                secondswap = 6;
                Button3_Click(null, null);
            }
        }

        private void Seat7_Click(object sender, EventArgs e)
        {
            if (StateSwap == SwapState.Off)
            {
                if (seat7.BackColor != Color.LightBlue)
                {
                    seat1.BackColor = Color.White;
                    seat2.BackColor = Color.White;
                    seat3.BackColor = Color.White;
                    seat4.BackColor = Color.White;
                    seat5.BackColor = Color.White;
                    seat6.BackColor = Color.White;
                    seat7.BackColor = Color.Yellow;
                    seat8.BackColor = Color.White;
                }
            }
            else if (StateSwap == SwapState.First)
            {
                seat1.BackColor = Color.Red;
                seat2.BackColor = Color.White;
                seat3.BackColor = Color.White;
                seat4.BackColor = Color.White;
                seat5.BackColor = Color.White;
                seat6.BackColor = Color.White;
                seat7.BackColor = Color.Red;
                seat8.BackColor = Color.White;
                firstswap = 7;
                StateSwap = SwapState.Second;
            }
            else if (StateSwap == SwapState.Second && seat7.BackColor != Color.Red)
            {
                seat7.BackColor = Color.Green;
                secondswap = 7;
                Button3_Click(null, null);
            }
        }

        private void Seat8_Click(object sender, EventArgs e)
        {
            if (StateSwap == SwapState.Off)
            {
                if (seat8.BackColor != Color.LightBlue)
                {
                    seat1.BackColor = Color.White;
                    seat2.BackColor = Color.White;
                    seat3.BackColor = Color.White;
                    seat4.BackColor = Color.White;
                    seat5.BackColor = Color.White;
                    seat6.BackColor = Color.White;
                    seat7.BackColor = Color.White;
                    seat8.BackColor = Color.Yellow;
                }
            }
            else if (StateSwap == SwapState.First)
            {
                seat1.BackColor = Color.White;
                seat2.BackColor = Color.White;
                seat3.BackColor = Color.White;
                seat4.BackColor = Color.White;
                seat5.BackColor = Color.White;
                seat6.BackColor = Color.White;
                seat7.BackColor = Color.White;
                seat8.BackColor = Color.Red;
                firstswap = 8;
                StateSwap = SwapState.Second;
            }
            else if (StateSwap == SwapState.Second && seat8.BackColor != Color.Red)
            {
                seat8.BackColor = Color.Green;
                secondswap = 8;
                Button3_Click(null, null);
            }
        }

        private void Swap_button_Click(object sender, EventArgs e)
        {

        }
    }
    public class Competitors
    {
        public int ID { get; set; }
        public int SeatNumber { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string CountryAbbr { get; set; }
    }
    public enum SwapState
    {
        Off,
        First,
        Second
    }
}
