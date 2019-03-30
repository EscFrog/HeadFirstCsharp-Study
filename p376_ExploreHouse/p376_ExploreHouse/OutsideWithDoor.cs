using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p376_ExploreHouse {
    class OutsideWithDoor : Outside, IHasExteriorDoor {
        public OutsideWithDoor(string name, bool hot, string doorDescription) : base(name, hot) {
            this.DoorDescription = doorDescription;
        }
                
        public string DoorDescription { get; private set; }

        public Location DoorLocation { get; set; }

        public override string Description
        {
            get
            {
                return base.Description + "\r\n\r\n[" + DoorLocation.Name + "](으)로 통하는 '" + DoorDescription + "'이 보입니다";
            }
        }


    }
}
