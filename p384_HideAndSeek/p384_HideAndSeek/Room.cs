using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p384_HideAndSeek {
    class Room : Location {
        private string decoration;

        public Room (string name, string decoration) : base(name) {
            this.decoration = decoration;
        }

        public override string Description
        {
            get
            {
                return base.Description + "\r\n\r\n이곳엔 '" + decoration + "'(이)가 있습니다.";
            }
        }
    }
}
