using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inflearn_exam_calculator {
    public enum Operators { None, Add, Sub, Multi, Div, }

    public partial class Calculator : Form {
        public int Result = 0;
        public bool isNewNum = true;
        public Operators Opt = Operators.None;

        public Calculator() {
            InitializeComponent();
        }

        private void numButton_Click(object sender, EventArgs e) {
            Button clickedButton = sender as Button;
            SetNum(clickedButton.Text);
        }

        public void SetNum(string num) {
            if (isNewNum) {
                numScreen.Text = num;
                isNewNum = false;
            }
            else if (numScreen.Text == "0") {
                numScreen.Text = num;
            }
            else {
                numScreen.Text += num;
            }
        }

        public int Add(int number1, int number2) {
            int sum = number1 + number2;
            return sum;
        }

        public int Sub(int number1, int number2) {
            int sub = number1 - number2;
            return sub;
        }

        public int Multi(int number1, int number2) {
            int multi = number1 * number2;
            return multi;
        }

        public int Div(int number1, int number2) {
            int div = number1 / number2;
            return div;
        }

        private void operatorButton_Click(object sender, EventArgs e) {
            if (isNewNum == false) {
                int currentNum = int.Parse(numScreen.Text);

                if (Opt == Operators.Add)
                    Result = Add(Result, currentNum);
                else if (Opt == Operators.Sub)
                    Result = Sub(Result, currentNum);
                else if (Opt == Operators.Multi)
                    Result = Multi(Result, currentNum);
                else if (Opt == Operators.Div)
                    Result = Div(Result, currentNum);
                else
                    Result = currentNum;
                renewalScreen();
            }
            // 연산자 enum 값을 현재 눌려진 버튼의 기호와 같은 값으로 변경
            Button optButton = sender as Button;
            if (optButton.Text == "+")
                Opt = Operators.Add;
            else if (optButton.Text == "-")
                Opt = Operators.Sub;
            else if (optButton.Text == "*")
                Opt = Operators.Multi;
            else if (optButton.Text == "/")
                Opt = Operators.Div;
            else
                Opt = Operators.None;
        }

        private void clearButton_Click(object sender, EventArgs e) {
            Result = 0;
            Opt = Operators.None;
            renewalScreen();
        }

        private void renewalScreen() {
            numScreen.Text = Result.ToString();
            isNewNum = true;
        }
    }
}
