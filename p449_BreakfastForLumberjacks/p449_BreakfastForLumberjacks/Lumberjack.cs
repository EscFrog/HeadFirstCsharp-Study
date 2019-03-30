using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p449_BreakfastForLumberjacks {
    enum Flapjack {
        Crispy,
        Soggy,
        Browned,
        Banana
    }

    class Lumberjack {
        private string name;
        public string Name { get { return name; } }
        private Stack<Flapjack> meal;
        public Stack<Flapjack> Meal { get { return meal; } }

        public Lumberjack (string name) {
            this.name = name;
            meal = new Stack<Flapjack>();
        }
        public int FlapjackCount { get { return meal.Count; } }

        public void TakeFlapjacks(Flapjack food, int howMany) {
            // meal 스택에 추가된 개수만큼의 팬케이크를 추가합니다
            for (int i = 0; i < howMany; i++) {
                meal.Push(food);
            }
        }

        public void EatFlapjacks() {
            // 콘솔에 결과를 출력합니다.
            //Console.WriteLine(name + "가 팬케익을 먹는 중입니다.");
            if (meal.Count <= 0)
                return;
            string result = name + "가 팬케익을 먹는 중입니다." + Environment.NewLine;
            while (meal.Count > 0) {
                //Console.WriteLine(name + "가 " + meal.Pop().ToString().ToLower() + " 팬케익을 먹습니다.");
                result += name + "가 " + meal.Pop().ToString().ToLower() + " 팬케익을 먹습니다." + Environment.NewLine;
            }
            MessageBox.Show(result);
        }
    }
}
