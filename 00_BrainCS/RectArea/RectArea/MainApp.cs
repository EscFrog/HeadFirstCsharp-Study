using System;

namespace RectArea {
    class MainApp {
        static void Main(string[] args) {
            Console.WriteLine("사각형의 너비를 입력하세요.");
            string width = Console.ReadLine();

            Console.WriteLine("사각형의 높이를 입력하세요.");
            string height = Console.ReadLine();

            int widthInt = int.Parse(width);    // string 형식을 int 형식으로 변환
            int heightInt = int.Parse(height);  // string 형식을 int 형식으로 변환

            int area = widthInt * heightInt;

            Console.WriteLine("사각형의 넓이는 : {0}", area);
            
            // var a = 2020;
            // Console.WriteLine("{0}", a.GetType().ToString());

            Console.ReadKey();  // 대기를 위한 코드
        }
    }
}
