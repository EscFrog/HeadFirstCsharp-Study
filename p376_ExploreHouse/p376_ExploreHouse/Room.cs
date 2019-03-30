using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p376_ExploreHouse {
    class Room : Location {
        private string decoration;

        public Room (string name, string decoration) : base(name) {
            this.decoration = decoration;
        }

        public override string Description
        {
            get
            {
                return base.Description + "\r\n\r\n이 곳은 '" + decoration + "'(으)로 장식되어 있습니다.";
            }
        }
    }
}
