using System;

// Delegate : 대리자
//
// Methods 에 대한 참조를 나타내는 형식

namespace Delegate
{
    internal class Program
    {
        // 대리자 형식 선언
        public delegate int OPHandler(int a, int b);
        public static OPHandler op;

        static void Main(string[] args)
        {
            int result = 0;

            op += Sum; // 구독
            op += Sub;
            op += Div;
            op += Mul;

            op(3, 3);
        }

        static int Sum(int a, int b)
        {
            Console.WriteLine(a + b);
            return a + b;
        }

        static int Sub(int a, int b)
        {
            Console.WriteLine(a - b);
            return a - b;
        }

        static int Div(int a, int b)
        {
            Console.WriteLine(a / b);
            return a / b;
        }

        static int Mul(int a, int b)
        {
            Console.WriteLine(a * b);
            return a * b;
        }
    }
}
