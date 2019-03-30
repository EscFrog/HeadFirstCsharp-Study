using System;


namespace Nullable {
    class MainApp {
        static void Main(string[] args) {
            int? a = null;

            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null); // 논리연산자가 사용됨. True or False 값이 출력됨.

            a = 3;

            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null); // 논리연산자가 사용됨. True or False 값이 출력됨.
            Console.WriteLine(a.Value);

            Console.ReadKey(); // 키 입력시까지 대기
        }
    }
}
