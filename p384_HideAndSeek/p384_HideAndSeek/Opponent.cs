using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p384_HideAndSeek {
    class Opponent {
        private Random random;
        private Location myLocation;

        public Opponent(Location startingLocation) {
            myLocation = startingLocation;
            random = new Random();
        }


        public void Move() {
            bool hidden = false;
            while (!hidden) {
                if (myLocation is IHasExteriorDoor) {   // 나갈 문이 있으면
                    IHasExteriorDoor locationWithDoor = myLocation as IHasExteriorDoor;
                    if (random.Next(2) == 1) {  // 문으로 나갈지 말지 50% 확률로 결정
                        myLocation = locationWithDoor.DoorLocation;
                    }
                }
                myLocation = myLocation.Exits[random.Next(myLocation.Exits.Length)]; // 이도 저도 아니면 통하는 곳 중에서 한 곳을 랜덤으로 정해서 이동
                if (myLocation is IHidingPlace)
                    hidden = true;
            }
        }

        public bool Check(Location locationToCheck) {
            if (locationToCheck != myLocation)
                return false;
            else
                return true;
        }
    }
}
