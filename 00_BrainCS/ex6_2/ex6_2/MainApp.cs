﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6_2 {
    class MainApp {
        static void Main(string[] args) {
            double mean = 0;

            Mean(1, 2, 3, 4, 5, ref mean);

            Console.WriteLine("평균 : {0}", mean);
            Console.ReadKey();
        }

        public static void Mean(
            double a, double b, double c,
            double d, double e, ref double mean) {
            mean = (a + b + c + d + e) / 5;
        }
    }
}
