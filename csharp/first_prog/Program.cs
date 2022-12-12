
// 파란색 : 키워드 ( 예약어 )
// 흰색 : 식별문자 ( 이름 )
// 청록색 : 클래스 타입 이름
// 노란색 : 함수
// 하늘색 : 매개변수 ( 파라미터 )
// 주황색 : 문자 / 문자열 상수
// 회색 : 필요없다고 컴파일러가 판단하고 있음


// 키워드 : 예약어
// 미리 예약되어있는 단어
// 이미 시스템에서 정의되어있기 때문에 사용자가 임의로 동일한 이름을 사용할 수 없다

// using 키워드 : 무언가 ( namespace ) 를 사용하겠다 라고 선언하는 키워드
using System;

// namespace 키워드
// 이름으로 공간을 분리하는 키워드
namespace first_prog
{
    // internal - 접근 제한자
    // 동일 어셈블리 내에서만 접근 가능한 제한자

    // class - class 타입 정의 키워드
    // class 의 멤버들을 정의함

    // 형식
    // class 이름
    // {
    //    멤버 정의
    // }

    internal class Program
    {
        // main 함수

        // args : argument ( 인자 ) : 매개변수에 대입할 값

        // static : 정적 키워드 - dynamic 과 반대
        // static 의 의미 : 런타임 중에 메모리에 할당할 수 없다
        // 동적 ( 런타임 중 ) 으로 생성할 수 없다 = 객체화가 불가능
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
