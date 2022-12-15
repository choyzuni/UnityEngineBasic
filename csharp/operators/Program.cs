using System;

namespace operators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int ta = 14;
            int tb = 5;
            int tc;

            tc = ta + tb;
            Console.WriteLine(tc);

            tc = ta - tb;
            Console.WriteLine(tc);

            tc = ta / tb;
            Console.WriteLine(tc);

            tc = ta * tb;
            Console.WriteLine(tc);

            tc = ta % tb;
            Console.WriteLine(tc);


            Console.WriteLine(++tc); // 전위 연산
            Console.WriteLine(tc++); // 후위 연산
            Console.WriteLine(tc);


            Console.WriteLine(ta == tb);
            Console.WriteLine(ta != tb);
            Console.WriteLine(ta > tb);
            Console.WriteLine(ta < tb);
            Console.WriteLine(ta >= tb);
            Console.WriteLine(ta <= tb);


            // 대입 연산

            tc = 20;
            Console.WriteLine($"TC의 값은 {tc} 입니다.");
            tc += tb;
            Console.WriteLine($"TC의 값은 {tc} 입니다.");
            tc -= tb;
            Console.WriteLine($"TC의 값은 {tc} 입니다.");
            tc /= tb;
            Console.WriteLine($"TC의 값은 {tc} 입니다.");
            tc *= tb;
            Console.WriteLine($"TC의 값은 {tc} 입니다.");
            tc %= tb;
            Console.WriteLine($"TC의 값은 {tc} 입니다.");


            // 논리 연산

            bool a = true;
            bool b = false;


            // 논리 연산
            
            Console.WriteLine(a|b); // or - 둘 중 하나만 트루여도 트루 반환
            Console.WriteLine(a&b); // and - 둘 다 트루여야 트루 반환
            Console.WriteLine(a^b); // xor - 둘중 하나만 트루일 경우 트루 반환
            Console.WriteLine(!a); // not - bool 값을 반전 시킴


            // 조건부 논리 연산
            // 왼쪽 피연산자에 따라서 오른쪽 피연산자와 비교연산을 수행할지 말지 평가한 후에 연산함

            Console.WriteLine(a||b); // or - a가 트루이므로 b는 안보고 true 반환
            Console.WriteLine(a&&b); // and - a가 false 일 경우 b는 안보고 false 반환


            // 비트 연산 - 정수형에 대해서만 수행함

            Console.WriteLine(ta|tb);
            Console.WriteLine(ta&tb);
            Console.WriteLine(ta^tb);
            Console.WriteLine(~ta); // 2의 보수 : 이진법에서 모든 자릿수를 반전하고 + 1
            Console.WriteLine(ta<<1);
            Console.WriteLine(ta>>1);

        }




    }

}
