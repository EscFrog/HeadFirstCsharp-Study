using System;

namespace Ex10_2_matrixCalculator
{
    public class MatrixCalculator
    {
        int Arow;
        int AcolBrow;
        int Bcol;

        int[,] arrayA;
        int[,] arrayB;
        int[,] Result;

        /// <summary>
        /// 생성자에서 행렬 A 와 행렬 B의 크기를 입력받고 두 행렬을 곱한 결과가 될 행렬의 크기를 결정합니다. (필드 초기화)
        /// </summary>
        public void SetMatrix()
        {
            Console.Write("행렬 A의 행의 갯수(세로 길이)를 입력하세요 : ");
            Arow = Int32.Parse(Console.ReadLine());

            Console.Write("행렬 A의 열의 갯수(가로 길이)를 입력하세요 (행렬 A의 열의 갯수 = 행렬B의 행의 갯수) : ");
            AcolBrow = Int32.Parse(Console.ReadLine());

            Console.Write("행렬 B의 열의 갯수(가로 길이)를 입력하세요: ");
            Bcol = Int32.Parse(Console.ReadLine());

            arrayA = new int[Arow, AcolBrow];
            arrayB = new int[AcolBrow, Bcol];
            Result = new int[Arow, Bcol];

            Console.WriteLine("\r\n행렬 A의 크기는 {0} * {1} 입니다.", arrayA.GetLength(0), arrayA.GetLength(1));
            Console.WriteLine("\r\n행렬 B의 크기는 {0} * {1} 입니다.", arrayB.GetLength(0), arrayB.GetLength(1));
            Console.WriteLine("\r\n결과 행렬의 크기는 {0} * {1} 입니다.", Result.GetLength(0), Result.GetLength(1));
        }

        /// <summary>
        /// 행렬 A와 B의 각 값을 입력받습니다.
        /// </summary>
        public void SetMatrixValue()
        {
            // 행렬 A의 값 입력
            for (int i = 0; i < Arow; i++)
            {
                for (int j = 0; j < AcolBrow; j++)
                {
                    Console.Write("\n행렬 A의 {0} , {1} 칸에 넣을 값을 입력하세요: ", i, j);
                    arrayA[i, j] = Int32.Parse(Console.ReadLine());
                }
            }

           // PrintArrayA(); // 행렬 A의 값 출력

            // 행렬 B의 값 입력
            for (int i = 0; i < AcolBrow; i++)
            {
                for (int j = 0; j < Bcol; j++)
                {
                    Console.Write("\n행렬 B의 {0} , {1} 칸에 넣을 값을 입력하세요: ", i, j);
                    arrayB[i, j] = Int32.Parse(Console.ReadLine());
                }
            }

            // PrintArrayB(); // 행렬 B의 값 출력
        }

        /// <summary>
        /// 입력받은 두 행렬을 곱합니다.
        /// </summary>
        public void Calculate()
        {
            int result = 0;

            for (int i = 0; i < Arow; i++)
            {
                for (int j = 0; j < Bcol; j++)
                {
                    for (int k = 0; k < AcolBrow; k++)
                    {
                        result += arrayA[i, k] * arrayB[k, j];
                    }
                    Result[i, j] = result;
                    result = 0;
                }
            }
        }

        /// <summary>
        /// 행렬 A의 값을 출력합니다.
        /// </summary>
        public void PrintArrayA()
        {
            Console.WriteLine("\r\n행렬 A의 값 :");
            for (int i = 0; i < arrayA.GetLength(0); i++)
            {
                for (int j = 0; j < arrayA.GetLength(1); j++)
                {
                    Console.Write("{0} ", arrayA[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        /// <summary>
        /// 행렬 B의 값을 출력합니다.
        /// </summary>
        public void PrintArrayB()
        {
            Console.WriteLine("\r\n행렬 B의 값 :");
            for (int i = 0; i < arrayB.GetLength(0); i++)
            {
                for (int j = 0; j < arrayB.GetLength(1); j++)
                {
                    Console.Write("{0} ", arrayB[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        /// <summary>
        /// 행렬을 곱한 결과를 출력합니다.
        /// </summary>
        public void PrintResult()
        {
            Console.WriteLine("\r\n두 행렬의 곱 :");
            for (int i = 0; i < Result.GetLength(0); i++)
            {
                for (int j = 0; j < Result.GetLength(1); j++)
                {
                    Console.Write("{0} ", Result[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            MatrixCalculator cal = new MatrixCalculator();
            cal.SetMatrix();
            cal.SetMatrixValue();
            cal.Calculate();

            cal.PrintArrayA();
            cal.PrintArrayB();
            cal.PrintResult();

            Console.ReadKey();
        }
    }
}
