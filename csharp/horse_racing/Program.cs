using System;
using System.Threading;

// 진행 방식
// 
// 말 클래스 필요
// 
// 말 클래스는 달린 거리, 이동하기 ( 달리기 ) 라는 멤버 함수를 가진다
// 
// 프로그램 시작시 말 5마리 만들고
// 각 말은 초당 10 ~ 20 ( 정수형 ) 범위의 거리를 랜덤하게 전진
// 각각의 말은 거리 200 에 도달하면 도착해서 더이상 전진하지 않고
// 매초 각 말들이 아직 달리고 있다면 달린 거리를
// 도착했다면 도착 상태를 콘솔창에 출력
//
// 모든 말이 도착했다면 경주를 끝내고
// 등수 순서대로 말들의 이름을 콘솔창에 출력한다
// 


namespace horse_racing
{
    internal class Program
    {
        class horse
        {
            public string name;
            public int totaldistance = 0;
            public int speed;
            public bool finished;

            public void run(int distance)
            {
                this.totaldistance = this.totaldistance + distance;
            }

        }

        static Random random;
        static int minspeed = 10;
        static int maxspeed = 20;
        static int goalpos = 200;

        static void Main(string[] args)
        {
            bool gamefinished = false;

            // 말 5마리 만들고 이름 설정 ( 이름 패턴은 경주마 1,2,3,4~~~~ )

            horse[] horses = new horse[5];

            for (int ti = 0; ti < horses.Length; ti++)
            {
                horses[ti] = new horse();
                horses[ti].name = $"경주마 {ti + 1}";
            }

            for (int ti = 0; ti < horses.Length; ti++)
            {
                Console.WriteLine(horses[ti].name);                
            }




            while (gamefinished == false)
            {
                

                // 말 다섯마리 각각 아래처럼 랜덤한 스피드로 전진시키면서
                // 각 말은 초당 10 ~ 20 ( 정수형 ) 범위의 거리를 랜덤하게 전진
                // 각각의 말은 거리 200 에 도달하면 도착해서 더이상 전진하지 않고
                // 매초 각 말들이 아직 달리고 있다면 달린 거리를 도착했다면 도착 상태를 콘솔창에 출력
                // 모든 말이 도착했으면 게임 끝냄


                random = new Random();

                

                
                Thread.Sleep(1000); // 이 와일문은 1초에 한번씩 수행한다

                Console.Clear();


                for (int ti = 0; ti < horses.Length; ti++)
                {
                    int tpspeed = random.Next(minspeed, maxspeed + 1);
                    horses[ti].run(tpspeed);
                    Console.WriteLine($"경주마 {ti + 1} \t" + horses[ti].totaldistance);
                }


                


                
                
            }

            Console.Clear();


            // 각 말들 등수 순서대로 이름 출력
        }

        static void allrun()
        { 
        
        }

    }
}
