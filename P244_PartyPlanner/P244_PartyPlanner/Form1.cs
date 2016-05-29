using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P244_PartyPlanner {
    public partial class Form1 : Form {
        DinnerParty dinnerParty;

        public Form1() {
            InitializeComponent();
            dinnerParty = new DinnerParty();
            dinnerParty.SetHealthOption(healthyBox.Checked);
            dinnerParty.CalculateCostOfDecorations(fancyBox.Checked);
            DisplayDinnerPartyCost();
        }

        public void DisplayDinnerPartyCost() {  // 파티 비용을 계산해서 costLabel에 값을 집어넣는다
            dinnerParty.SetPartyOptions((int)numericUpDown1.Value, fancyBox.Checked);
            decimal Cost = dinnerParty.CalculateCost(healthyBox.Checked);
            costLabel.Text = Cost.ToString("c");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
            // dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e) {
            dinnerParty.CalculateCostOfDecorations(fancyBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void healthyBox_CheckedChanged(object sender, EventArgs e) {
            dinnerParty.SetHealthOption(healthyBox.Checked);
            DisplayDinnerPartyCost();
        }
    }
}
