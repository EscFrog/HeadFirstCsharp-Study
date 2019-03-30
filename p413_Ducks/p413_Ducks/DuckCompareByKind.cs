using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p413_Ducks {
    class DuckCompareByKind : IComparer<Duck> {
        public int Compare(Duck x, Duck y) {
            if (x.Kind < y.Kind) // enum 의 인덱스를 기준으로 비교함
                return -1;
            else if (x.Kind > y.Kind)
                return 1;
            else
                return 0;
        }
    }
}
