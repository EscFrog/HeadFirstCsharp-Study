using System;

namespace EventTest
{
    delegate void EventHandler(string message);

    class Notifier    // 통보기
    {
        public event EventHandler SomethingHappened;

        public int HowManyNotify
        {
            get;
            private set;
        }

        public int HowManyClap
        {
            get;
            private set;
        }

        public void DoSomething(int number)
        {
            int temp = number;
            int remainder;
            string clapSound = String.Empty;

            while(temp != 0)
            {
                remainder = temp % 10; // 10으로 나눈 나머지
                if (remainder != 0 && remainder % 3 == 0) // 0이 아니고 3의 배수면
                {
                    clapSound += "짝";
                    HowManyClap += 1;
                }
                temp = temp / 10;   // 제일 마지막 자리수를 날려버린다.
            }

            if (!String.IsNullOrEmpty(clapSound))
            {
                SomethingHappened(String.Format("{0} : {1}", number, clapSound));    // SomethingHappened 이벤트 호출. 이벤트를 선언한 클래스 내부에 있으므로 호출할 수 있다. (여기는 콘솔에 출력하라는 선언문이 없다.)
                HowManyNotify += 1;
            }
            else
            {
                Console.WriteLine(number); // 이벤트는 발생시키지 않고 그냥 숫자만 출력
            }
        }
    }

    class Program
    {
        public static void MyHandler(string message)
        {
            Console.WriteLine(message); // 전달받은 메세지를 콘솔에 출력
        }

        static void Main(string[] args)
        {
            Notifier myNotifier = new Notifier();
            myNotifier.SomethingHappened += new EventHandler(MyHandler);    // MyHandler 메소드를 참조하는 EventHandler 이벤트 델리게이트 형식의 객체를 SomethingHappened 변수에 할당한다.
            // 이벤트가 선언된 클래스 외부에서는 메소드를 할당할 수는 있어도 이벤트를 호출할 수는 없다.


            //string limit = Console.ReadLine();
            int limit;

            while (true)
            {
                Console.WriteLine("삼! 육구! 삼육구! 삼! 육구! 삼육구!");
                Console.Write("몇까지 삼육구를 할래? : ");
                if (int.TryParse(Console.ReadLine(), out limit))   // 문자열을 입력받고 그게 int 형식으로 변환이 가능한지 판단
                {
                    Console.WriteLine(Environment.NewLine);
                    for (int i = 1; i <= limit; i++)
                    {
                        myNotifier.DoSomething(i);
                    }
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("삼육구 끝!");
                    Console.WriteLine("숫자 대신 박수 친 타이밍 : {0}회", myNotifier.HowManyNotify);
                    Console.WriteLine("박수를 친 총 횟수 : {0}회", myNotifier.HowManyClap);
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("제대로 된 숫자를 입력할 때까지 프로그램은 끝나지 않아 boy~");
                    Console.WriteLine(Environment.NewLine);
                }
            }
        }
    }
}
