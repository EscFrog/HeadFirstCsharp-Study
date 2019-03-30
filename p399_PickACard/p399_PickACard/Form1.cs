using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p399_PickACard {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private Random random = new Random();

        private void pickButton_Click(object sender, EventArgs e) {
            Card card = new Card((Suit) random.Next(4), (Value) random.Next(1, 14));
            MessageBox.Show(card.Name);
        }
    }
}
