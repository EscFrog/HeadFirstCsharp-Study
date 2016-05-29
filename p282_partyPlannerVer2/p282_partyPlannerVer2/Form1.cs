using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p282_partyPlannerVer2 {
    public partial class Form1 : Form {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;

        public Form1() {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value, fancyBox.Checked, healthBox.Checked);

            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int)numberBirthday.Value, fancyBirthday.Checked, cakeWriting.Text);

            DisplayBirthdayPartyCost();
        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e) {
            dinnerParty.FancyDecorations = fancyBox.Checked;
            DisplayDinnerPartyCost();
        }

        private void healthBox_CheckedChanged(object sender, EventArgs e) {
            dinnerParty.HealthyOption = healthBox.Checked;
            DisplayDinnerPartyCost();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
            dinnerParty.NumberOfPeople = (int) numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        public void DisplayDinnerPartyCost() {
            costLabel.Text = dinnerParty.Cost.ToString("c");
        }

        private void numberBirthday_ValueChanged(object sender, EventArgs e) {
            birthdayParty.NumberOfPeople = (int)numberBirthday.Value;
            DisplayBirthdayPartyCost();
        }

        private void fancyBirthday_CheckedChanged(object sender, EventArgs e) {
            birthdayParty.FancyDecorations = fancyBirthday.Checked;
            DisplayBirthdayPartyCost();
        }

        private void DisplayBirthdayPartyCost() {
            tooLongLabel.Visible = birthdayParty.CakeWritingTooLong;
            birthdayCost.Text = birthdayParty.cost.ToString("c");
        }

        private void cakeWriting_TextChanged(object sender, EventArgs e) {
            birthdayParty.CakeWriting = cakeWriting.Text;
            DisplayBirthdayPartyCost();
        }
    }
}
