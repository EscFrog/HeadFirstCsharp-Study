using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P207_Chapter4_ElephantSwap {
    public partial class Form1 : Form {
        Elephant lloyd;
        Elephant lucinda;
        
        public Form1() {
            InitializeComponent();
            lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
        }

        private void button_Lloyd_Click(object sender, EventArgs e) {
            lloyd.WhoAmI();
        }

        private void button_Lucinda_Click(object sender, EventArgs e) {
            lucinda.WhoAmI();
        }

        private void button_Swap_Click(object sender, EventArgs e) {
            Elephant swap;
            swap = lloyd;
            lloyd.TellMe("Hi", lucinda);
            lloyd.SpeakTo(lucinda, "Hello");
            lloyd = lucinda;
            lucinda = swap;
            MessageBox.Show("Objects swapped");
        }
        // 이 아래는 p218 코드자석을 푸는 부분
        private void button1_Click(object sender, EventArgs e) {
                        
            String[] islands = new String[4];

            islands[0] = "Bermuda";
            islands[1] = "Fiji";
            islands[2] = "Azores";
            islands[3] = "Cozumel";

            int[] index = new int[4];

            index[0] = 1;
            index[1] = 3;
            index[2] = 0;
            index[3] = 2;

            int y = 0;

            String result = "";

            int refNum;

            while (y < 4) {
                refNum = index[y];
                result += "\nisland = ";
                result += islands[refNum];
                y = y + 1;
            }

            MessageBox.Show(result);
        }
    }
}
