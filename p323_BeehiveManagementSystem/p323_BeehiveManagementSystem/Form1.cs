using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p323_BeehiveManagementSystem {
    public partial class Form1 : Form {
        private Queen queen;

        public Form1() {
            InitializeComponent();
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new String[] { "Nectar collector", "Honey manufacturing" }, 175);
            workers[1] = new Worker(new String[] { "Egg care", "Baby bee tutoring" }, 114);
            workers[2] = new Worker(new String[] { "Hive maintenance", "Sting patrol" }, 149);
            workers[3] = new Worker(new String[] { "Nectar collector", "Honey manufacturing", "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" }, 155);

            queen = new Queen(workers, 275);
        }

        private void assignJob_Click(object sender, EventArgs e) {
            if (queen.AssignWork(workerBeeJob.Text, (int)shifts.Value) == false)
                MessageBox.Show("'" + workerBeeJob.Text + "' 를 할 벌이 없습니다.", "여왕벌이 말하길...");
            else
                MessageBox.Show("일벌 #" + queen.BeeNumber + "가 '" + workerBeeJob.Text + "' 업무를 " + shifts.Value + " 턴 동안 할 예정입니다", "여왕벌이 말하길...");
        }

        private void nextShift_Click(object sender, EventArgs e) {
            reportText.Text = queen.WorkTheNextShift();
        }
    }
}
