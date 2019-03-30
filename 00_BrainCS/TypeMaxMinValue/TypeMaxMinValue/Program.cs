using System;

namespace TypeMaxMinValue {
    class Program {
        static void Main(string[] args) {

            int intMin = int.MinValue;
            int intMax = int.MaxValue;

            uint uintMin = uint.MinValue;
            uint uintMax = uint.MaxValue;
            
            long longMin = long.MinValue;
            long longMax = long.MaxValue;

            ulong ulongMin = ulong.MinValue;
            ulong ulongMax = ulong.MaxValue;



            Console.WriteLine("int 형식의 값 범위 : {0} ~ {1}", intMin, intMax);
            Console.WriteLine("uint 형식의 값 범위 : {0} ~ {1}", uintMin, uintMax);
            Console.WriteLine("long 형식의 값 범위 : {0} ~ {1}", longMin, longMax);
            Console.WriteLine("ulong 형식의 값 범위 : {0} ~ {1}", ulongMin, ulongMax);
            
            Console.ReadKey();
        }
    }
}
