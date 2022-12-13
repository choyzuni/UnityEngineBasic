using System;

// function : 연산을 수행할 수 있는 기능
// method : 객체 또는 클래스 단위로 호출되는 function ( 멤버 함수가 메똘드에 포함 )

// 함수 형태 3가지

//  함수 선언, 정의, 호출
// 

namespace method
{
    internal class Program
    {
        // 전역 변수
        // 초기화 값이 있을 경우 데이터 영역에 저장되고
        // 초기화 값이 없을 경우 BSS 영역에 할당된다
        // BSS 영역에선 모든 비트가 0 으로 세팅된다
        static bool HelloworldPrinted;

        static void Main(string[] args)
        {
            bool somethingprinted = true;
            // 지역변수는 함수 호출 스택에 같이 할당됨
            // 해당 변수 공간에 어떤 데이터가 쓰여져 있는지 알 수 없기 때문에
            // 데이터를 할당한 후에 접근해야 한다

            Console.WriteLine(HelloworldPrinted);
            Console.WriteLine(somethingprinted);

            PrintHelloworld();
            string name = "울랄랄라";
            
            PrintSomething(name);
        }

        static void PrintHelloworld()
        {
            Console.WriteLine("Hello World!");
            HelloworldPrinted = true;
        }

        static void PrintSomething(string something)
        {
            Console.WriteLine(something);
        }
    }
}
