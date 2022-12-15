using System;

namespace if_statement
{
    internal class Program
    {
        static bool conditional_0 = false;
        static bool conditional_1 = true;

        static void Main(string[] args)
        {

            if (conditional_0)
            {
                Console.WriteLine("조건 0 은 참입니다");
            }
            else if (conditional_1)
            {
                Console.WriteLine("조건 0은 거짓이고 조건 1 이 참입니다");
            }
            else
            {
                Console.WriteLine("조건 0, 조건 1 모두 거짓입니다");
            }

        }
    }
}
