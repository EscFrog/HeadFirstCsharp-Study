using System;
using System.Windows.Forms;

namespace p256_CowCalculator {
    public partial class Form1 : Form {
        Farmer farmer;
        public Form1() {
            InitializeComponent();
            farmer = new Farmer(15,30); //초기값을 15로 설정해서 생성
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
            farmer.NumberOfCows = (int)numericUpDown1.Value;
        }

        private void calculate_Click(object sender, EventArgs e) {
            Console.WriteLine("I need {0} bags of feed for {1} cows", farmer.BagsOfFeed, farmer.NumberOfCows);
        }

        // private void testButton_Click(object sender, EventArgs e) {
        //    farmer.BagsOfFeed = 5;
       // }
    }
}
