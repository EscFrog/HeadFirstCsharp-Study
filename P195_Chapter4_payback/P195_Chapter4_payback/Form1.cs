using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P195_Chapter4_payback {
    public partial class Form1 : Form {

        public int startingMileage;
        public int endingMileage;

        public double milesTraveled;
        public double reimburseRate = 0.39;
        public double amountOwed;

        public Form1() {
            InitializeComponent();
            startingMileage = (int)numericUpDown1.Value;
            endingMileage = (int)numericUpDown2.Value;
        }
        
        private void button1_Click(object sender, EventArgs e) {
            if (startingMileage < endingMileage) {
                milesTraveled = endingMileage - startingMileage;
                amountOwed = milesTraveled * reimburseRate;
                label4.Text = "$" + amountOwed;
            }
            else {
                MessageBox.Show("The starting mileage must be less than the ending mileage","Cannot Calculate Mileage");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
            startingMileage = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e) {
            endingMileage = (int)numericUpDown2.Value;
        }

        private void button2_Click(object sender, EventArgs e) {
            MessageBox.Show(milesTraveled + " miles", "Miles Traveled");
        }
    }
}
