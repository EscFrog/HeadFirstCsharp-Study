using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p413_Ducks {
    enum SortCriteria {
        SizeThenKind,
        KindThenSize,
    }

    class DuckComparer : IComparer<Duck> {
        public SortCriteria SortBy;
        /*
        public DuckComparer(SortCriteria sortBy) {
            SortBy = sortBy;
        }
        */

        public int Compare(Duck x, Duck y) {
            if (SortBy == SortCriteria.SizeThenKind) {
                if (x.Size > y.Size)
                    return 1;
                else if (x.Size < y.Size)
                    return -1;
                else {
                    if (x.Kind > y.Kind)
                        return 1;
                    else if (x.Kind < y.Kind)
                        return -1;
                    else
                        return 0;
                }
            }
            else {
                if (x.Kind > y.Kind)
                    return 1;
                else if (x.Kind < y.Kind)
                    return -1;
                else {
                    if (x.Size > y.Size)
                        return 1;
                    else if (x.Size < y.Size)
                        return -1;
                    else
                        return 0;
                }
            }
        }
    }
}
