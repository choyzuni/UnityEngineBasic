using System;

// 구조체 : 사용자 정의 자료형
// 멤버들을 캡슐화하는 자료형
// 멤버 변수, 프로퍼티, 함수...
//
// 프로퍼티
// public


// 구조체는 값 타입
// new 키워드를 쓰지만 heap에 할당은 아님

// 그렇다면 언제 클래스를 쓰고
// 언제 구조체를 쓰느냐?
//
// 1. 멤버들의 크기 총합이 16 byte 초과일때는 일반적으로 클래스를 쓴다
// 
//    참조 타입으로 값을 읽고 쓰는것보다 값 타입을 읽고 쓰는게 빠르다
//    하지만 16 byte 를 초과할 경우 레지스터가 두번 이상 값을 읽어야 하기 때문에
//    값 타입이여도 참조 타입보다 느려진다
//
// 2. 값을 쓰고 읽는 것이 빈번하게 일어날 경우 ( 예시로 함수의 인자로 넘겨주는 횟수가 잦을 경우 )
//    구조체를 사용하는 것이 효율적이다



namespace structure
{

    // 구조체는 new 를 사용하지만 heap 영역에 할당되지 않는다
    // 그러므로 구조체는 값 타입이다
    public struct stats
    {

        // 프로퍼티
        // getter / setter 를 구현할 수 있는 속성
        public int str_0
        {
            get
            {
                return str;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                str = value;
            }
        }

        public static stats zero
        {
            get
            {
                return new stats(0, 0, 0, 0);
            }
        }

        // 위 구문을 아래 구문으로 쓸 수도 있다
        public static stats getten => new stats(10,10,10,10);


        private int str;
        private int dex;
        private int Int;
        private int luk;

        // 생성자 오버로드
        // 구조체의 생성자에서는 모든 멤버를 초기화 해야함
        public stats(int tstats)
        {
            str = tstats;
            dex = tstats;
            Int = tstats;
            luk = tstats;
        }

        public stats(int tstr, int tdex, int tInt, int tluk)
        {
            str = tstr;
            dex = tdex;
            Int = tInt;
            luk = tluk;
        }

        public void setInt(int tInt)
        {
            Int = tInt;
        }

        public static stats getten_()
        {
            return new stats(10, 10, 10, 10);
        }

        public static stats getzero_()
        {
            return new stats(0, 0, 0, 0);
        }

        public int combatpower()
        {
            return str + dex + Int + luk;
        }
    }

    // 클래스는 참조 타입
    public class slime
    {
        public stats stats;
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            slime slime_0 = new slime();
            slime_0.stats = stats.getten_();
            Console.WriteLine($"슬라임의 전투력은 {slime_0.stats.combatpower()}");

            slime_0.stats = stats.getzero_();
            Console.WriteLine($"슬라임의 전투력은 {slime_0.stats.combatpower()}");

            // 프로퍼티 사용 방법
            slime_0.stats.str_0 = 20;
            Console.WriteLine($"슬라임의 전투력은 {slime_0.stats.str_0}");





        }
    }
}
