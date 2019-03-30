using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p373_swimmingPool {
    class Program {
        static void Main(string[] args) {
            string result = "";
            Nose[] i = new Nose[3];
            i[0] = new Acts();
            i[1] = new Clowns();
            i[2] = new Of76();
            for (int x = 0; x < 3; x++) {
                result += i[x].Ear() + " " + i[x].Face + "\n";
            }
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }

    /// <summary>
    /// Nose 인터페이스
    /// </summary>
    interface Nose {
        int Ear();
        string Face { get; }
    }

    /// <summary>
    /// Piccasso 추상 클래스
    /// </summary>
    abstract class Piccasso : Nose {
        public virtual int Ear() {
            return 7;
        }

        public Piccasso (string face) {
            this.face = face;
        }

        public virtual string Face { get { return face; } }

        string face;
    }

    /// <summary>
    /// Clowns 클래스
    /// </summary>
    class Clowns : Piccasso {
        public Clowns() : base("Clowns") { }
    }

    /// <summary>
    /// Acts 클래스
    /// </summary>
    class Acts : Piccasso {
        public Acts() : base("Acts") { }
        public override int Ear() {
            return 5;
        }
    }

    /// <summary>
    /// Of76 클래스
    /// </summary>
    class Of76 : Clowns {
        public override string Face
        {
            get { return "Of76"; }
        }
    }

}
