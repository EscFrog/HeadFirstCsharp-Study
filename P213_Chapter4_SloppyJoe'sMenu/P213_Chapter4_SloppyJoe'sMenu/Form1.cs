using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P213_Chapter4_SloppyJoe_sMenu {
    public partial class Form1 : Form {

        MenuMaker menu;

        public Form1() {
            InitializeComponent();

            menu = new MenuMaker() { Randomizer = new Random() };
            DisplayMenu();
        }

        private void button1_Click(object sender, EventArgs e) {
            DisplayMenu();
        }

        private void DisplayMenu() {
            label1.Text = menu.GetMenuItem();
            label2.Text = menu.GetMenuItem();
            label3.Text = menu.GetMenuItem();
            label4.Text = menu.GetMenuItem();
            label5.Text = menu.GetMenuItem();
            label6.Text = menu.GetMenuItem();
        }
    }
}
