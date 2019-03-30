using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p426_TwoDecks {
    public partial class Form1 : Form {
        Deck deck1;
        Deck deck2;

        Random random = new Random();

        public Form1() {
            InitializeComponent();
            ResetDeck(1);
            ResetDeck(2);
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void moveToDeck2_Click(object sender, EventArgs e) {
            if (listBoxDeck1.SelectedIndex >= 0) {
                if (deck1.Count > 0) {
                    deck2.Add(deck1.Deal(listBoxDeck1.SelectedIndex));
                }
            }
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void moveToDeck1_Click(object sender, EventArgs e) {
            if (listBoxDeck2.SelectedIndex >= 0) {
                if (deck2.Count>0) {
                    deck1.Add(deck2.Deal(listBoxDeck2.SelectedIndex));
                }
            }
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void resetDeck1_Click(object sender, EventArgs e) {
            ResetDeck(1);
            RedrawDeck(1);
        }

        private void resetDeck2_Click(object sender, EventArgs e) {
            ResetDeck(2);
            RedrawDeck(2);
        }

        private void shuffleDeck1_Click(object sender, EventArgs e) {
            deck1.Shuffle();
            RedrawDeck(1);
        }

        private void shuffleDeck2_Click(object sender, EventArgs e) {
            deck2.Shuffle();
            RedrawDeck(2);
        }

        private void ResetDeck(int deckNumber) {
            if (deckNumber == 1) {
                int numberOfCards = random.Next(1, 11);
                deck1 = new Deck(new Card[] { });
                for (int i = 0; i < numberOfCards; i++)
                    deck1.Add(new Card((Suit)random.Next(4), (Value)random.Next(1, 14)));
                deck1.Sort();
            }else {
                deck2 = new Deck();
                deck2.Sort();
            }
        }

        public void RedrawDeck(int deckNumber) {
            if (deckNumber == 1) {
                listBoxDeck1.Items.Clear();
                foreach (string cardName in deck1.GetCardNames())
                    listBoxDeck1.Items.Add(cardName);
                labelDeck1.Text = "Deck #1 (" + deck1.Count + " cards)";
            }
            else {
                listBoxDeck2.Items.Clear();
                foreach (string cardName in deck2.GetCardNames())
                    listBoxDeck2.Items.Add(cardName);
                labelDeck2.Text = "Deck #2 (" + deck2.Count + " cards)";
            }
        }
    }
}
