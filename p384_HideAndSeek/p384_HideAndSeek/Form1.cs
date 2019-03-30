using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p384_HideAndSeek {
    public partial class Form1 : Form {

        int Moves;

        Location currentLocation;

        RoomWithDoor livingRoom;
        RoomWithHidingPlace diningRoom;
        RoomWithDoor kitchen;
        Room stairs;
        RoomWithHidingPlace hallway;
        RoomWithHidingPlace bathroom;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secondBedroom;

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        OutsideWithHidingPlace garden;
        OutsideWithHidingPlace driveway;

        Opponent opponent;

        public Form1() {
            InitializeComponent();
            CreateObject();
            opponent = new Opponent(frontYard); // 상대방은 앞마당에서 시작
            ResetGame(false);
        }

        private void MoveToANewLocation (Location newLocation) {
            currentLocation = newLocation;
            RedrawForm();
        }

        private void RedrawForm() {
            exits.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++) {
                exits.Items.Add(currentLocation.Exits[i].Name);
            }
            exits.SelectedIndex = 0;
            // 이동횟수 표시
            descriptionBox.Text = currentLocation.Description + "\r\n\r\n(술래찾기 시도 횟수 : " + Moves + "회)";
            // 조사하기 버튼 처리
            if (currentLocation is IHidingPlace) {
                IHidingPlace hidingPlace = currentLocation as IHidingPlace;
                checkButton.Text = hidingPlace.HidingPlaceName + "을(를) 조사해보자";
                checkButton.Visible = true;
            }
            else
                checkButton.Visible = false;

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

        public void CreateObject() {
            // 방 생성
            livingRoom = new RoomWithDoor("거실", "고풍스런 양탄자", "황동 손잡이가 달린 참나무 문", "옷장 속");
            diningRoom = new RoomWithHidingPlace("식당", "크리스탈 샹들리에", "높은 장식장 속");
            kitchen = new RoomWithDoor("부엌", "스테인리스 스틸 주방가전", "방충망 달린 문", "캐비닛 속");
            stairs = new Room("계단", "나무 난간");
            hallway = new RoomWithHidingPlace("위층 복도", "강아지 그림", "옷장 속");
            bathroom = new RoomWithHidingPlace("화장실", "세면대와 변기", "샤워실 안");
            masterBedroom = new RoomWithHidingPlace("큰 침실", "큰 침대", "침대 밑");
            secondBedroom = new RoomWithHidingPlace("작은 침실", "작은 침대", "침대 밑");
            
            frontYard = new OutsideWithDoor("앞마당", false, "황동 손잡이가 달린 참나무 문");
            backYard = new OutsideWithDoor("뒷마당", true, "방충망 달린 문");
            garden = new OutsideWithHidingPlace("정원", false, "창고 안");
            driveway = new OutsideWithHidingPlace("차고 입구", false, "차고 안");


            // 방들 연결
            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            livingRoom.Exits = new Location[] { diningRoom, stairs };
            kitchen.Exits = new Location[] { diningRoom };
            stairs.Exits = new Location[] { livingRoom, hallway };
            hallway.Exits = new Location[] { stairs, bathroom, masterBedroom, secondBedroom };
            bathroom.Exits = new Location[] { hallway };
            masterBedroom.Exits = new Location[] { hallway };
            secondBedroom.Exits = new Location[] { hallway };
            
            frontYard.Exits = new Location[] { backYard, garden, driveway };
            backYard.Exits = new Location[] { frontYard, garden, driveway };
            garden.Exits = new Location[] { backYard, frontYard };
            driveway.Exits = new Location[] { backYard, frontYard };

            // 외부와 연결된 문 설정
            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }

        private void ResetGame(bool success) {
            if (success) {
                MessageBox.Show(Moves + "번 만에 나를 찾았네!");
                IHidingPlace foundLocation = currentLocation as IHidingPlace;
                descriptionBox.Text = Moves + "번 만에 술래를 찾았습니다.\r\n술래는 <" + foundLocation.HidingPlaceName + ">에 숨어 있었습니다.";
            }
            Moves = 0;
            hideButton.Visible = true;
            goHere.Visible = false;
            checkButton.Visible = false;
            goThroughTheDoor.Visible = false;
            exits.Visible = false;
        }

        private void goHere_click(object sender, EventArgs e) {
            MoveToANewLocation(currentLocation.Exits[exits.SelectedIndex]);
        }

        private void goThroughTheDoor_Click(object sender, EventArgs e) {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }

        private void checkButton_Click(object sender, EventArgs e) {
            Moves++;
            if (opponent.Check(currentLocation))
                ResetGame(true);
            else {
                IHidingPlace hidingPlace = currentLocation as IHidingPlace;
                MessageBox.Show("<" + hidingPlace.HidingPlaceName + ">에는 아무도 없다.");
                RedrawForm();
            }
        }

        private void hideButton_Click(object sender, EventArgs e) {
            hideButton.Visible = false;

            for (int i = 1; i <= 10; i++) {
                opponent.Move();
                descriptionBox.Text = i + "...";
                Application.DoEvents();
                System.Threading.Thread.Sleep(500);
            }
            
            descriptionBox.Text = "준비해! 내가 간다!";
            Application.DoEvents();
            System.Threading.Thread.Sleep(1000);

            goHere.Visible = true;
            exits.Visible = true;
            MoveToANewLocation(livingRoom);
        }
    }
}
