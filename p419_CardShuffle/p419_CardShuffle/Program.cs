using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p419_CardShuffle {
    class Program {
        //static Random = new Random();
        static void Main(string[] args) {
            Random random = new Random();
            
            List<Card> pickedCards = new List<Card>();

            for (int i = 0; i < 5; i++) {
                pickedCards.Add(new Card((Suit)random.Next(4), (Value)random.Next(1, 14)));
            }

            Console.WriteLine("임의로 뽑은 다섯장의 카드 :\r");
            foreach (Card card in pickedCards) {
                Console.WriteLine(card);
            }

            // CardComparer_byValue comparer = new CardComparer_byValue();
            // pickedCards.Sort(comparer);
            pickedCards.Sort(new CardComparer_byValue()); // 이렇게 참조변수를 할장하지 않고 바로 new 키워드를 사용해 넣을 수 도 있음.
            Console.WriteLine("\r\n값을 기준으로 섞은 결과 :\r");
            foreach(Card card in pickedCards) {
                Console.WriteLine(card);
            }
            Console.ReadKey();

        }
    }
}
