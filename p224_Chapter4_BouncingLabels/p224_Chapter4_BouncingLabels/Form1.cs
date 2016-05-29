using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p224_Chapter4_BouncingLabels {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        LabelBouncer[] bouncers = new LabelBouncer[3];

        private void ToggleBouncing (int index, Label labelToBounce) {
            if (bouncers[index] == null) {
                bouncers[index] = new LabelBouncer();
                bouncers[index].MyLabel = labelToBounce;
            }
            else {
                bouncers[index] = null;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            ToggleBouncing(0, label1);
            if (bouncers[0] != null) {
                button1.Text = "Label1 Stop!";
            }
            else {
                button1.Text = "Label1 Move!";
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            ToggleBouncing(1, label2);
            if (bouncers[1] != null) {
                button1.Text = "Label2 Stop!";
            }
            else {
                button1.Text = "Label2 Move!";
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            ToggleBouncing(2, label3);
            if (bouncers[2] != null) {
                button1.Text = "Label3 Stop!";
            }
            else {
                button1.Text = "Label3 Move!";
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            for (int i = 0; i < 3; i++) {
                if (bouncers[i] != null) {
                    bouncers[i].Move();
                }
            }
        }
    }
}
