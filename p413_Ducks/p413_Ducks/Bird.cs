using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p413_Ducks {
    class Bird {
        public string Name { get; set; }
        public virtual void Fly() {
            Console.WriteLine("Flip, flap");
        }

        public override string ToString() {
            return "A bird named " + Name;
        }
    }
}
