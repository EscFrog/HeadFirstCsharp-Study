using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p376_ExploreHouse {
    public partial class Form1 : Form {
        Location currentLocation;

        RoomWithDoor livingRoom;
        Room diningRoom;
        RoomWithDoor kitchen;

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        Outside garden;

        
        public Form1() {
            InitializeComponent();
            CreateObject();
            // currentLocation = livingRoom; // 시작은 거실에서
            MoveToANewLocation(livingRoom); // 시작은 거실에서
        }

        public void CreateObject() {
            livingRoom = new RoomWithDoor("거실", "고풍스런 양탄자", "황동 손잡이가 달린 참나무 문");
            diningRoom = new Room("식당", "크리스탈 샹들리에");
            kitchen = new RoomWithDoor("부엌", "스테인리스 스틸 주방가전", "방충망 달린 문");

            frontYard = new OutsideWithDoor("앞마당", false, "황동 손잡이가 달린 참나무 문");
            backYard = new OutsideWithDoor("뒷마당", true, "방충망 달린 문");
            garden = new Outside("정원", false);

            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            livingRoom.Exits = new Location[] { diningRoom };
            kitchen.Exits = new Location[] { diningRoom };
            frontYard.Exits = new Location[] { backYard, garden };
            backYard.Exits = new Location[] { frontYard, garden };
            garden.Exits = new Location[] { backYard, frontYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }

        private void MoveToANewLocation (Location newLocation) {
            currentLocation = newLocation;
            exits.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++) {
                exits.Items.Add(currentLocation.Exits[i].Name);
            }
            exits.SelectedIndex = 0;

            descriptionBox.Text = currentLocation.Description;

            if (currentLocation is IHasExteriorDoor) {
                goThroughTheDoor.Visible = true;
                // 이 아래는 버튼의 텍스트 바꿔주기 위해 임의로 넣은 선언문
                IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
                goThroughTheDoor.Text = "문을 통해 " + hasDoor.DoorLocation.Name + "(으)로 가자.";
            }
            else {
                goThroughTheDoor.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            MoveToANewLocation(currentLocation.Exits[exits.SelectedIndex]);
        }

        private void goThroughTheDoor_Click(object sender, EventArgs e) {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }
    }
}
