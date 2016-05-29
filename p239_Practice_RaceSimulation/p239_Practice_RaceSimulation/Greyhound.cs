using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p239_Practice_RaceSimulation {
    public class Greyhound {
        public int StartingPosition;    // PictureBox 시작 위치
        public int RacetrackLength;     // 경주 트랙 길이
        public PictureBox MyPictureBox = null; // 개의 PictureBox 객체
        public int Location = 0;                // 경주 트랙에서의 위치
        public Random Randomizer;               // Random 객체 인스턴스

        public bool Run() {
            // 한칸~네칸을 무작위로 전진
            // 폼에서 PictureBox의 위치를 갱신
            //  MyPictureBox.Left = StartingPosition + Location;
            // 경주에서 우승한 경우에는 true 반환
            if (MyPictureBox.Left<RacetrackLength-MyPictureBox.Width) {
                Location += Randomizer.Next(3, 10);
                MyPictureBox.Left = StartingPosition + Location;
                return false;
            }
            else {
                return true;
            }
        }

        public void TakeStartingPosition() {
            // MyPictureBox 위치를 0으로 설정해서 경주 시작 위치로 돌아갑니다.
            MyPictureBox.Left = StartingPosition;
            Location = 0;
    }
}
}
