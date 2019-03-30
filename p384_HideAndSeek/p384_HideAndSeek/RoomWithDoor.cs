using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p384_HideAndSeek {
    class RoomWithDoor : RoomWithHidingPlace, IHasExteriorDoor {
        public RoomWithDoor(string name, string decoration, string doorDescription, string hidingPlaceName) : base(name, decoration, hidingPlaceName) {
            DoorDescription = doorDescription;
        }

        public string DoorDescription { get; private set; } // IHasExteriorDoor 인터페이스에서는 get 접근자만 있었지만 오버라이딩 해서 private set 접근자를 추가할 수 있다.

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
