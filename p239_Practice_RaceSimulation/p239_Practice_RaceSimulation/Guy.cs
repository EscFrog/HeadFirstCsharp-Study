using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p239_Practice_RaceSimulation {
    public class Guy {
        public string Name; // 사람 이름
        public Bet MyBet;   // 베팅 내역을 저장할 Bet 인스턴스
        public int Cash;    // 지금 가지고 있는 현금 액수

        public RadioButton MyRadioButton;   // 해당 Guy 인스턴스의 라디오 버튼
        public Label MyLabel;               // 해당 Guy 인스턴스의 레이블

        public void UpdateLabels() {
            // Label에 베팅 내역을 표시하고 RadioButton에 붙일 Label에는 현재 현금 보유 금액을 표시
            // 현재 현금 보유액을 표시해 줍니다. ("Joe has 43 bucks" 같은 식으로)
            MyRadioButton.Text = Name + " has " + Cash + " bucks";
            if (MyBet != null) {
                MyLabel.Text = MyBet.GetDescription();
            }
            else {
                MyLabel.Text = Name + " hasn't placed a bet"; // 아직 베팅을 하지 않았을 경우, 그러니까 인스턴스가 생성되지 않았을 경우의 문자열
            }
            
        }

        public void ClearBet() {
            // MyBet을 다시 0으로 설정
            MyBet = null;
        }

        public bool PlaceBet(int BetAmount, int DogToWin) {
            // 새로 베팅을 하고 배팅 내역을 MyBet 인스턴스의 필드에 저장
            // 현재 인스턴스의 Cash 필드에 배팅에 필요한 만큼 현금을 보유하고 있으면 true 반환
            if (Cash >= BetAmount) {
                MyBet = new Bet() { Amount = BetAmount, Dog = DogToWin, Bettor = this };
                return true;
            }
            else {
                MessageBox.Show(Name + " has not enough money");
            }
            return false;
        }

        public void Collect(int Winner) {
            // 배팅 결과 처리. (MyBet을 초기화하고, MyLabel을 갱신하는 부분)
            Cash += MyBet.PayOut(Winner);
            ClearBet();
            UpdateLabels();
        }
    }
}
