using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p256_CowCalculator {
    class Farmer {
        // public int BagsOfFeed;
        public int BagsOfFeed { get; private set; }
        // public const int FeedMultiplier = 30;
        private int feedMultiplier;
        public int FeedMultiplier { get { return feedMultiplier; } }

        private int numberOfCows;
        public int NumberOfCows {
            get {
                return numberOfCows;
            }
            set {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMultiplier;
            }
        }

        // 이 아래는 생성자임
        public Farmer(int numberOfCows, int feedMultiplier) {
            this.feedMultiplier = feedMultiplier;
            NumberOfCows = numberOfCows;
        }
    }
}
