using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthQuiz {
    class Program {
        static void Main(string[] args) {
            Random random = new Random();

            string answer = string.Empty;
            string retry = "y";


            do {
                int quiz = random.Next(1, 13);

                switch (quiz) {
                    case 1:
                        answer = "january";
                        break;
                    case 2:
                        answer = "february";
                        break;
                    case 3:
                        answer = "march";
                        break;
                    case 4:
                        answer = "april";
                        break;
                    case 5:
                        answer = "may";
                        break;
                    case 6:
                        answer = "june";
                        break;
                    case 7:
                        answer = "july";
                        break;
                    case 8:
                        answer = "august";
                        break;
                    case 9:
                        answer = "september";
                        break;
                    case 10:
                        answer = "october";
                        break;
                    case 11:
                        answer = "november";
                        break;
                    case 12:
                        answer = "december";
                        break;
                    default:
                        answer = string.Empty;
                        break;
                }

                Console.Write("{0}월의 이름을 영어로 입력하시오 : ", quiz);
                string input = Console.ReadLine();

                if (!String.IsNullOrEmpty(input))
                {
                    if (input.ToLower() == answer)
                        Console.WriteLine("'{0}' 정답입니다.", input);
                    else
                        Console.WriteLine("틀렸습니다. 정답은 '{0}'가 아니라 '{1}' 입니다.", input, answer);
                }
                else
                    Console.WriteLine("문자를 입력해주세요.");
                

                Console.Write("다시 하시겠습니까? (y/n) : ");
                retry = Console.ReadLine();
            }
            while (retry.ToLower() == "y" || retry.ToLower() == string.Empty);
            Console.WriteLine("수고하셨습니다.");
        }
    }
}
