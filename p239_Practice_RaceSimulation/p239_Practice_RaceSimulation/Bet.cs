using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p239_Practice_RaceSimulation {
    public class Bet {
        public int Amount;  // 배팅한 금액
        public int Dog;     // 배팅한 개의 번호
        public Guy Bettor;  // 배팅한 사람에 해당하는 Guy 객체

        public string GetDescription() {
            // 누가 얼만큼 어떤 개에게 걸었는지 나타내는 문자열 반환
            if (Amount > 0) {
                return Bettor.Name + " bets " + Amount + " bucks on dog #" + (Dog + 1);
            }
            return Bettor.Name + " hasn't placed a bet";
        }

        public int PayOut(int Winner) {
            // 우승한 개의 번호가 매개변수로 전달됨
            // 배팅한 개가 우승했으면 배팅 액수 반환
            // 우승하지 못했다면 배팅 액수에 마이너스를 붙여서 반환
            if (Winner == Dog) {
                return Amount;
            }
            else {
                return -Amount;
            }
        }
    }
}
