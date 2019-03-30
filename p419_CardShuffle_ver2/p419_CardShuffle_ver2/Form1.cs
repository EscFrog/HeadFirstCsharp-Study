using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p419_CardShuffle_ver2 {
    public partial class Form1 : Form {

        Random random = new Random();
        List<Card> pickedCards = new List<Card>();

        public Form1() {
            InitializeComponent();
            shuffleButton.Visible = false;
        }

        private void pickButton_Click(object sender, EventArgs e) {
            int pickAmount = (int)cardAmount.Value;

            pickedCards.Clear();
            suffleResult.Clear();

            for (int i = 0; i < pickAmount; i++) {
                pickedCards.Add(new Card((Suit)random.Next(4), (Value)random.Next(1, 14)));
            }

            string result = "";
            foreach (Card card in pickedCards) {
                result += card + "\r\n"; // Card 클래스에서 ToString() 메서드를 오버라이딩 했기 때문에 card.ToString() 을 가져와도 card.Name 속성이 반환된다. (+ 연산자는 문자열로 변환하기 위해 ToString() 메서드를 알아서 호출한다.)
            }
            pickResult.Text = result;

            shuffleButton.Visible = true;
        }

        private void shuffleButton_Click(object sender, EventArgs e) {
            pickedCards.Sort(new CardComparer_byValue()); // 이렇게 참조변수를 할장하지 않고 바로 new 키워드를 사용해 넣을 수 도 있음.
            string result = "";
            foreach (Card card in pickedCards) {
                result += card + "\r\n"; // Card 클래스에서 ToString() 메서드를 오버라이딩 했기 때문에 card.ToString() 을 가져와도 card.Name 속성이 반환된다. (+ 연산자는 문자열로 변환하기 위해 ToString() 메서드를 알아서 호출한다.)
            }
            suffleResult.Text = result;
        }
    }
}
