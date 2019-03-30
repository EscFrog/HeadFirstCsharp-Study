using System;
using System.Linq;

namespace Join
{
    class Profile
    {
        public string Name
        {
            get;
            set;
        }
        public int Height
        {
            get;
            set;
        }
    }

    class Product
    {
        public string Title
        {
            get;
            set;
        }
        public string Star
        {
            get;
            set;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile() { Name="정우성", Height=186 },
                new Profile() { Name="김태희", Height=158 },
                new Profile() { Name="고현정", Height=172 },
                new Profile() { Name="이문세", Height=178 },
                new Profile() { Name="하하", Height=171 },
            };

            Product[] arrProduct =
            {
                new Product() { Title="비트", Star="정우성" },
                new Product() { Title="CF 다수", Star="김태희" },
                new Product() { Title="아이리스", Star="김태희" },
                new Product() { Title="모레시계", Star="고현정" },
                new Product() { Title="Solo 예찬", Star="이문세" },
            };
            // 여기서부터 내부 조인
            var listProfile = from profile in arrProfile
                              join product in arrProduct on profile.Name equals product.Star    // arrProduct 배열에 있는 데이터 요소를 하나씩 product로 꺼내서 profile과 비교하되 profile.Name 과 product.Star 를 비교해서 같은 것만 담아라
                              select new
                              {
                                  Name = profile.Name,
                                  Work = product.Title,
                                  Height = profile.Height
                              };

            Console.WriteLine("-- 내부 조인 결과 --");
            foreach (var profile in listProfile)
            {
                Console.WriteLine("이름:{0}, 작품:{1}, 키:{2}cm", profile.Name, profile.Work, profile.Height);
            }

            /// 여기서부터 외부 조인
            listProfile = from profile in arrProfile
                          join product in arrProduct on profile.Name equals product.Star into ps
                          from product in ps.DefaultIfEmpty(new Product() { Title = "그런 거 없음" })    // 공백일 때 기본지정으로 Title속성을 가진 Product 객채를 생성해서 product를 채운다.
                          select new
                          {
                              Name = profile.Name,
                              Work = product.Title,
                              Height = profile.Height
                          };

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("-- 외부 조인 결과 --");
            foreach (var profile in listProfile)
            {
                Console.WriteLine("이름:{0}, 작품:{1}, 키:{2}cm", profile.Name, profile.Work, profile.Height);
            }


            Console.ReadKey();
        }
    }
}
