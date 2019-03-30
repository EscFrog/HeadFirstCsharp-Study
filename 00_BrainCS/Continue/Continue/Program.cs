using System;

namespace Continue {
    class Program {
        static void Main(string[] args) {
            for (int i = 0; i < 10; i++) {
                if (i % 2 == 0)
                    continue;

                Console.WriteLine("{0} : 홀수", i);
            }

            Console.ReadKey();
        }
    }
}
