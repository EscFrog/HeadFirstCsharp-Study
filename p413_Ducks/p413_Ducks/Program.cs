using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p413_Ducks {
    class Program {
        static void Main(string[] args) {
            List<Duck> ducks = new List<Duck>() {
                new Duck() {Kind = KindOfDuck.Mallard, Size = 17 },
                new Duck() {Kind = KindOfDuck.Muscovy, Size = 18 },
                new Duck() {Kind = KindOfDuck.Decoy, Size = 14 },
                new Duck() {Kind = KindOfDuck.Muscovy, Size = 11 },
                new Duck() {Kind = KindOfDuck.Mallard, Size = 14 },
                new Duck() {Kind = KindOfDuck.Decoy, Size = 13 },
            };
            IEnumerable<Bird> upcastDucks = ducks; // List<Duck> 유형의 ducks 객체를 IEnumerable<Bird> 유형의 객체로 업캐스팅 

            List<Bird> birds = new List<Bird>();

            birds.Add(new Bird() { Name = "Feathers" });
            birds.AddRange(upcastDucks); // List<Duck> 유형에서 IEnumerable<Bird> 유형으로 업캐스팅 된 컬렉션을 List<Bird> 유형의 컬렉션 객체에 추가할 수 있다.
            birds.Add(new Penguin() { Name = "George" });

            foreach (Bird bird in birds) {
                Console.WriteLine(bird);
            }

            // Duck 클래스가 직접 IComparable<T>를 구현하고(비교가능) 그 멤버인 CompareTo() 메서드를 오버라이딩 해서 정렬방법을 정의한 후 정렬하는 방법
            ducks.Sort();
            PrintDucks(ducks);
            
            // IComparer<T>를 구현하며(비교자) 그 멤버인 Compare() 메서드를 오버라이딩 해서 정렬방법을 정의한 클래스를 따로 만들고 그 인스턴스를 List.Sort() 메서드에 인자로 전달해서 정렬하는 방법
            DuckCompareBySize sizeComparer = new DuckCompareBySize(); // 비교자 인스턴스 생성
            ducks.Sort(sizeComparer); // List.Sort() 메서드는 IComparer<T> 인터페이스를 구현하는 객체를 인자로 받는다.
            PrintDucks(ducks);
            
            DuckCompareByKind kindComparer = new DuckCompareByKind(); // 비교자 인스턴스 생성
            ducks.Sort(kindComparer);
            PrintDucks(ducks);

            //복잡한 정렬자
            //DuckComparer comparer = new DuckComparer(SortCriteria.KindThenSize);
            DuckComparer comparer = new DuckComparer();
            comparer.SortBy = SortCriteria.KindThenSize;
            ducks.Sort(comparer);
            PrintDucks(ducks);

            comparer.SortBy = SortCriteria.SizeThenKind;
            ducks.Sort(comparer);
            PrintDucks(ducks);

            Console.ReadKey();
        }

        public static void PrintDucks(List<Duck> ducks) {
            foreach (Duck duck in ducks)
                Console.WriteLine(duck);
            Console.WriteLine("End of ducks!\r\n");
        }
    }
}
