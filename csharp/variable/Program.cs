

// 변수
// 아직 정해지지 않은 값

// 변수를 사용하겠다고 선언 할때는
// 해당 변수의 형태 ( 타입/형태 ) 를 알려줘야한다

// bit : 한자리 이진수 ( 0과 1로 표현, 정보처리의 최소단위 )
// byte : 8 bit ( 데이터 처리의 최소단위 )


using System;
using System.Collections.Specialized;

namespace variable
{
    internal class Program
    {
        // 변수 선언의 의미 : 해당 타입만큼의 메모리공간을 확보하겠다
        int index = 777;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class human
    {
        int age = 30; // 4 바이트
        float height = 170.5f; // 4 바이트
        double weight = 73.8; // 8 바이트
        bool rest = false; // 1 바이트
        char gender = 'M'; // 2 바이트
        string name = "choyzuniski"; // n * 2 바이트 + 1 바이트 (null)
        // c 계통 언어에서는 모두 문자열의 끝을 인식하기 위해 null byte 를 사용
    }
}
