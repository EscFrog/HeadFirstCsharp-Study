﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p426_TwoDecks {
    class Deck {
        private List<Card> cards;
        private Random random = new Random();

        public Deck() {
            cards = new List<Card>();
            for (int suit = 0; suit <= 3; suit++) {
                for (int value = 1; value <= 13; value++) {
                    cards.Add(new Card((Suit)suit, (Value)value));
                }
            }
        }

        public Deck(IEnumerable<Card> initialCards) {
            cards = new List<Card>(initialCards);
        }

        public int Count { get { return cards.Count; } }

        public void Add(Card cardToAdd) {
            cards.Add(cardToAdd);
        }

        public Card Deal(int index) {
            Card CardToDeal = cards[index];
            cards.RemoveAt(index);
            return CardToDeal;
        }

        public void Shuffle() {
            List<Card> newCards = new List<Card>();
            while (cards.Count > 0) {
                int CardToMove = random.Next(cards.Count);
                newCards.Add(cards[CardToMove]);
                cards.RemoveAt(CardToMove);
            }
            cards = newCards;
        }

        public IEnumerable<string> GetCardNames() {
            string[] cardNames = new string[cards.Count];
            for (int i = 0; i < cardNames.Length; i++) {
                cardNames[i] = cards[i].Name;
            }
            return cardNames;
        }

        public void Sort() {
            cards.Sort(new CardComparer());
        }
    }
}
