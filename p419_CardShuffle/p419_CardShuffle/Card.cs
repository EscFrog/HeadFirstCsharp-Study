﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p419_CardShuffle {
    public enum Suit {
        Spades,
        Clubs,
        Diamonds,
        Hearts,
    }

    public enum Value {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
    }

    class Card {
        public Suit Suit { get; set; }
        public Value Value { get; set; }

        public Card (Suit suit, Value value) {
            this.Suit = suit;
            this.Value = value;
        }

        public string Name {
            get { return Value.ToString() + " of " + Suit.ToString(); }
        }

        public override string ToString() {
            return Name;
        }
    }
}
