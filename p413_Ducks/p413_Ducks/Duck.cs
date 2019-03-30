using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p413_Ducks {
    class Duck : Bird, IComparable<Duck> { // IComparable<T> 인터페이스를 구현해서 ICompareable<T> 객체를 매개변수로 받아들이는 List.Sort() 메서드에 인자로 넘겨줄 수 있도록 하자.
        public int Size;
        public KindOfDuck Kind;

        // List.Sort() 메서드에서 어떤 식으로 정렬할 것인지를 오버라이딩 해서 결정해주자
        public int CompareTo(Duck duckToCompare) { // IComparable<T> 인터페이스에 있는  CompareTo() 메서드를 오버라이딩 하는 부분임.
            if (this.Size > duckToCompare.Size)
                return 1;
            else if (this.Size < duckToCompare.Size)
                return -1;
            else
                return 0;
        }

        public override string ToString() {
            return "A " + Size + " inch " + Kind.ToString();
        }
    }

    enum KindOfDuck {
        Mallard,
        Muscovy,
        Decoy
    }
}
