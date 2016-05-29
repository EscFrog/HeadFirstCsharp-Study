using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p239_Practice_RaceSimulation {
    public partial class Form1 : Form {

        //public Guy joe;
        //public Guy bob;
        //public Guy al;

        public Guy[] guys = new Guy[3];

        public Greyhound[] dogs = new Greyhound[4];

        public Form1() {
            InitializeComponent();
            
            guys[0] = new Guy() { Name = "Joe", Cash = 50, MyRadioButton = player1RadioButton, MyLabel = joeBetLabel };
            guys[1] = new Guy() { Name = "Bob", Cash = 75, MyRadioButton = player2RadioButton, MyLabel = bobBetLabel };
            guys[2] = new Guy() { Name = "Al", Cash = 45, MyRadioButton = player3RadioButton, MyLabel = alBetLabel };

            for (int i = 0; i < guys.Length; i++) {
                guys[i].UpdateLabels();
            }

            Random randomizer = new Random();

            for (int i = 0; i < dogs.Length; i++) {
                dogs[i] = new Greyhound() { StartingPosition = background.Left + 10, RacetrackLength = background.Width, Randomizer = randomizer };
            }
            dogs[0].MyPictureBox = pictureBox_dog1;
            dogs[1].MyPictureBox = pictureBox_dog2;
            dogs[2].MyPictureBox = pictureBox_dog3;
            dogs[3].MyPictureBox = pictureBox_dog4;

            for (int i = 0; i < 4; i++) {
                dogs[i].TakeStartingPosition();
            }

        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e) {
            checkedNameLabel.Text = guys[0].Name;
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e) {
            checkedNameLabel.Text = guys[1].Name;
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e) {
            checkedNameLabel.Text = guys[2].Name;
        }

        private void button_bet_Click(object sender, EventArgs e) {
            if (player1RadioButton.Checked) {
                if(guys[0].PlaceBet((int) numericUpDown_amount.Value, (int)numericUpDown_dogNumber.Value -1)) {
                    guys[0].UpdateLabels();
                }
            }
            else if (player2RadioButton.Checked) {
                if(guys[1].PlaceBet((int)numericUpDown_amount.Value, (int)numericUpDown_dogNumber.Value -1)){
                    guys[1].UpdateLabels();
                }
            }
            else if (player3RadioButton.Checked) {
                if(guys[2].PlaceBet((int)numericUpDown_amount.Value, (int)numericUpDown_dogNumber.Value -1)) {
                    guys[2].UpdateLabels();
                }
            }
        }


        /// <summary>
        /// 레이스 시작
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_race_Click(object sender, EventArgs e) {
            groupBox1.Enabled = false;
            timer1.Enabled = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e) {
            for (int i = 0; i < dogs.Length; i++) {
                if (dogs[i].Run()) {
                    timer1.Enabled = false;
                    MessageBox.Show("Winner is dog #" + (i + 1));
                    for (int j = 0; j < guys.Length; j++) {
                        if (guys[j].MyBet != null) {
                            guys[j].Collect(i);
                        }
                    }
                    for (int k = 0; k < dogs.Length; k++) {
                        dogs[k].TakeStartingPosition();
                    }
                    groupBox1.Enabled = true;
                }
            }
        }
    }
}
