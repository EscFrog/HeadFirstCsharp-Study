using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p310_jewelTest {
    class Program {
        static void Main(string[] args) {
            //Owner owner = new Owner();
            //Safe safe = new Safe();
            //JewelThief jewelThief = new JewelThief();
            //jewelThief.OpenSafe(safe, owner);
            //Console.ReadKey();

            MySubclass subclass = new MySubclass("이거지?", 8);
            Console.ReadKey();
            
        }
    }
}
