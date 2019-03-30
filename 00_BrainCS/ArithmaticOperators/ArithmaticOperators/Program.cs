using System;

namespace ArithmaticOperators {
    class Program {
        static void Main(string[] args) {
            int i = 10;
            i = i + 1;
            Console.WriteLine(i);

            i = 10;
            i++;
            Console.WriteLine(i);

            i = 10;
            ++i;
            Console.WriteLine(i);

            i = 10;
            i += 1;
            Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
