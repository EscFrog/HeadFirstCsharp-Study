using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return {
    class MainApp {
        static int Fibonacci(int n) {
            if (n < 2)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2); // 피보나치 수는 바로 앞 두 개의 피보나치 수의 합.
            // 나중에 이렇게 재귀함수를 써서 피보나치 수를 구하는 방법 말고 다른 방법을 찾아보자.
        }

        static void PrintProfile(string name, string phone) {
            if (name == "") {
                Console.WriteLine("이름을 입력해주세요.");
                return;
            }

            Console.WriteLine("Name : {0}, Phone : {1}", name, phone);
        }

        static void Main(string[] args) {
            Console.Write("몇 번째 피보나치 수를 알고 싶나요? : ");
            string input = Console.ReadLine();
            int number = Int32.Parse(input);
            Console.WriteLine("{0}번째 피보나치 수 : {1}", number, Fibonacci(number));

            PrintProfile("", "123-4567");
            PrintProfile("박상현", "456-1230");

            Console.ReadKey();
        }
    }
}
