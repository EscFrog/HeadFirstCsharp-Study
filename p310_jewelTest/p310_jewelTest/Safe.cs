using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p310_jewelTest {
    class Safe {
        private Jewels contents = new Jewels();
        private string safeConbination = "12345";
        public Jewels Open (string conbination) {
            if (conbination == safeConbination)
                return contents;
            else
                return null;
        }
        public void PickLock (Locksmith lockpicker) {
            lockpicker.WriteDownCombination(safeConbination);
        }
    }
}
