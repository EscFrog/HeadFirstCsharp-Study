using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p449_BreakfastForLumberjacks {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            RedrawList();
        }

        Queue<Lumberjack> breakfastLine = new Queue<Lumberjack>();
                
        private void button_addLumberjack_Click(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(textBox_name.Text)) {
                breakfastLine.Enqueue(new Lumberjack(textBox_name.Text));
            }
            else
                MessageBox.Show("나무꾼의 이름을 입력하세요");
            textBox_name.Text = "";
            RedrawList();
        }

        private void button_addFlapjacks_Click(object sender, EventArgs e) {
            if (breakfastLine.Count == 0)
                return;
            Flapjack food;
            if (crispy.Checked == true)
                food = Flapjack.Crispy;
            else if (soggy.Checked == true)
                food = Flapjack.Soggy;
            else if (browned.Checked == true)
                food = Flapjack.Browned;
            else
                food = Flapjack.Banana;

            Lumberjack currentLumberjack = breakfastLine.Peek();
            currentLumberjack.TakeFlapjacks(food, (int) howMany.Value);
            RedrawList();
        }

        private void button_nextLumberjack_Click(object sender, EventArgs e) {
            if (breakfastLine.Count == 0)
                return;
            // Lumberjack nextLumberjack = breakfastLine.Dequeue();
            Lumberjack currentLumberjack = breakfastLine.Peek();
            if (currentLumberjack.Meal.Count > 0) {
                breakfastLine.Dequeue().EatFlapjacks();
                nextInLine.Text = "";
            }
            else
                MessageBox.Show("먹을 팬케잌이 없습니다");
            RedrawList();
        }

        private void RedrawList() {
            int number = 1;
            listBox_line.Items.Clear();
            foreach (Lumberjack lumberjack in breakfastLine) {
                listBox_line.Items.Add(number + ". " + lumberjack.Name);
                number++;
            }
            if (breakfastLine.Count == 0) {
                groupBox1.Enabled = false;
                nextInLine.Text = "";
            }
            else {
                groupBox1.Enabled = true;
                Lumberjack currentLumberjack = breakfastLine.Peek();
                nextInLine.Text = currentLumberjack.Name + "은 " + currentLumberjack.FlapjackCount + "개의 팬케익을 가지고 있음.";
            }
        }
    }
}
