﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p413_Ducks {
    class DuckCompareBySize : IComparer<Duck> {
        public int Compare(Duck x, Duck y) {
            if (x.Size < y.Size)
                return -1;
            else if (x.Size > y.Size)
                return 1;
            else
                return 0;
        }
    }
}
