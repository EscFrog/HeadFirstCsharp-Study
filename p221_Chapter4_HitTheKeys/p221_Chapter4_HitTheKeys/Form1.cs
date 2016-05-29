using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p221_Chapter4_HitTheKeys {
    public partial class Form1 : Form {

        Random random = new Random();
        Stats stats = new Stats();

        public Form1() {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            // 랜덤키를 리스트 박스에 추가한다
            listBox1.Items.Add((Keys)random.Next(65, 90));
            if (listBox1.Items.Count > 7) {
                listBox1.Items.Clear();
                listBox1.Items.Add("Game over");
                timer1.Stop();
                button_restart.Visible = true;
                button_restart.Enabled = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            if (listBox1.Items.Contains(e.KeyCode)) {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();
                if (timer1.Interval > 400)
                    timer1.Interval -= 10;
                if (timer1.Interval > 250)
                    timer1.Interval -= 7;
                if (timer1.Interval > 100)
                    timer1.Interval -= 2;
                difficultyProgressBar.Value = 800 - timer1.Interval;

                stats.Update(true);
            }
            else {
                stats.Update(false);
            }

            UpdateLabels();  
        }
        
        private void button_restart_Click(object sender, EventArgs e) {
            button_restart.Enabled = false;
            button_restart.Visible = false;
            listBox1.Items.Clear();
            stats = new Stats();
            UpdateLabels();
            timer1.Interval = 800;
            timer1.Start();
        }

        private void UpdateLabels() {
            correctLabel.Text = "Correct : " + stats.Correct;
            missedLabel.Text = "Missed : " + stats.Missed;
            totalLabel.Text = "Total : " + stats.Total;
            accuracyLabel.Text = "Accuracy : " + stats.Accuracy + "%";
        }
    }
}
