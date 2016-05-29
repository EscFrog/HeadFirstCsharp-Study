using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p310_jewelTest {
    class MySubclass : MyBaseClass {
        public MySubclass (string baseClassNeedsThis, int anotherValue) : base ("뭐라도 넣어야한다고") {
            Console.WriteLine("This is the subclass : " + baseClassNeedsThis + " and " + anotherValue);
        }
    }
}
