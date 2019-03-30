using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch {
    class Program {
        static void Main(string[] args) {
            Console.Write("요일을 입력하세요. (일,월,화,수,목,금,토) : ");
            string day = Console.ReadLine();

            switch(day) {
                case "일":
                    Console.WriteLine("Sunday");
                    break;
                case "월":
                    Console.WriteLine("Monday");
                    break;
                case "화":
                    Console.WriteLine("Tuesday");
                    break;
                case "수":
                    Console.WriteLine("Wednesday");
                    break;
                case "목":
                    Console.WriteLine("Thursday");
                    break;
                case "금":
                    Console.WriteLine("Friday");
                    break;
                case "토":
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("{0}는(은) 요일이 아닙니다.", day);
                    break;
            }
            Console.Write("달을 입력하세요. (1 ~ 12) : ");
                    string month = Console.ReadLine();

            switch (month) {
                case "1":
                    Console.WriteLine("January");
                    break;
                case "2":
                    Console.WriteLine("February");
                    break;
                case "3":
                    Console.WriteLine("March");
                    break;
                case "4":
                    Console.WriteLine("April");
                    break;
                case "5":
                    Console.WriteLine("May");
                    break;
                case "6":
                    Console.WriteLine("June");
                    break;
                case "7":
                    Console.WriteLine("July");
                    break;
                case "8":
                    Console.WriteLine("August");
                    break;
                case "9":
                    Console.WriteLine("September");
                    break;
                case "10":
                    Console.WriteLine("October");
                    break;
                case "11":
                    Console.WriteLine("November");
                    break;
                case "12":
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("{0}은(는) 월이 아닙니다.", month);
                    break;
            }
            Random random = new Random();
            int quiz = random.Next(1,13);

            Console.WriteLine(quiz);
        }
    }
}
