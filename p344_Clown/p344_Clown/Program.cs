using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p344_Clown {
    class Program {
        static void Main(string[] args) {
            //TallGuy tallGuy = new TallGuy() { Height = 74, Name = "Jimmy" };
            //tallGuy.TalkAboutYourself();
            //tallGuy.Honk();

            ScaryScary fingersTheClown = new ScaryScary("big shoes", 14);
            FunnyFunny someFunnyClown = fingersTheClown;
            IScaryClown someOtherScaryClown = someFunnyClown as ScaryScary;
            someOtherScaryClown.Honk();
            someOtherScaryClown.ScareLittleChildren();
            Console.ReadKey();
        }
    }
}
