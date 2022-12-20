using System;
using System.Collections;
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

namespace horse_racing
{
    internal class Program
    {
        class horse
        {
            public string name;
            private int totaldistance = 0;
            public bool finished = false;

            public void run(int distance)
            {
                if (goalpos <= totaldistance)
                {
                    if (finished == false && goalcheck < 5)
                    {
                        strings[goalcheck] = name;
                        goalcheck++;
                        finished = true;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    totaldistance += distance;
                }
            }

            public void display()
            {
                if (goalpos <= totaldistance)
                {
                    Console.WriteLine($"\n\t{name}  〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓 ||  Finished !!");
                }
                else if (190 <= totaldistance)
                {
                    Console.WriteLine($"\n\t{name}  〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓▶ ||  {totaldistance}");
                }
                else if (180 <= totaldistance)
                {
                    Console.WriteLine($"\n\t{name}  〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓▶〓 ||  {totaldistance}");
                }
                else if (170 <= totaldistance)
                {
                    Console.WriteLine($"\n\t{name}  〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓▶〓〓 ||  {totaldistance}");
                }
                else if (160 <= totaldistance)
                {
                    Console.WriteLine($"\n\t{name}  〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓▶〓〓〓 ||  {totaldistance}");
                }
                else if (150 <= totaldistance)
                {
                    Console.WriteLine($"\n\t{name}  〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓▶〓〓〓〓 ||  {totaldistance}");
                }
                else if (140 <= totaldistance)
                {
                    Console.WriteLine($"\n\t{name}  〓〓〓〓〓〓〓〓〓〓〓〓〓〓▶〓〓〓〓〓 ||  {totaldistance}");
                }
                else if (130 <= totaldistance)
                {
                    Console.WriteLine($"\n\t{name}  〓〓〓〓〓〓〓〓〓〓〓〓〓▶〓〓〓〓〓〓 ||  {totaldistance}");
                }
                else if (120 <= totaldistance)
                {
                    Console.WriteLine($"\n\t{name}  〓〓〓〓〓〓〓〓〓〓〓〓▶〓〓〓〓〓〓〓 ||  {totaldistance}");
                }
                else if (110 <= totaldistance)
                {
                    Console.WriteLine($"\n\t{name}  〓〓〓〓〓〓〓〓〓〓〓▶〓〓〓〓〓〓〓〓 ||  {totaldistance}");
                }
                else if (100 <= totaldistance)
                {
                    Console.WriteLine($"\n\t{name}  〓〓〓〓〓〓〓〓〓〓▶〓〓〓〓〓〓〓〓〓 ||  {totaldistance}");
                }
                else if (90 <= totaldistance)
                {
                    Console.WriteLine($"\n\t{name}  〓〓〓〓〓〓〓〓〓▶〓〓〓〓〓〓〓〓〓〓 ||  {totaldistance}");
                }
                else if (80 <= totaldistance)
                {
                    Console.WriteLine($"\n\t{name}  〓〓〓〓〓〓〓〓▶〓〓〓〓〓〓〓〓〓〓〓 ||  {totaldistance}");
                }
                else if (70 <= totaldistance)
                {
                    Console.WriteLine($"\n\t{name}  〓〓〓〓〓〓〓▶〓〓〓〓〓〓〓〓〓〓〓〓 ||  {totaldistance}");
                }
                else if (60 <= totaldistance)
                {
                    Console.WriteLine($"\n\t{name}  〓〓〓〓〓〓▶〓〓〓〓〓〓〓〓〓〓〓〓〓 ||  {totaldistance}");
                }
                else if (50 <= totaldistance)
                {
                    Console.WriteLine($"\n\t{name}  〓〓〓〓〓▶〓〓〓〓〓〓〓〓〓〓〓〓〓〓 ||  {totaldistance}");
                }
                else if (40 <= totaldistance)
                {
                    Console.WriteLine($"\n\t{name}  〓〓〓〓▶〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓 ||  {totaldistance}");
                }
                else if (30 <= totaldistance)
                {
                    Console.WriteLine($"\n\t{name}  〓〓〓▶〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓 ||  {totaldistance}");
                }
                else if (20 <= totaldistance)
                {
                    Console.WriteLine($"\n\t{name}  〓〓▶〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓 ||  {totaldistance}");
                }
                else if (10 <= totaldistance)
                {
                    Console.WriteLine($"\n\t{name}  〓▶〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓 ||  {totaldistance}");
                }
                else if (0 <= totaldistance)
                {
                    Console.WriteLine($"\n\t{name}  ▶〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓 ||  {totaldistance}");
                }
            }
        }

        static Random random;
        static int minspeed = 1;
        static int maxspeed = 30;
        static int goalpos = 200;
        static int goalcheck = 0;
        static string[] strings = new string[5];

        static void gamerank()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t\t경기 종료!!!");
            Console.WriteLine("\n");
            Console.WriteLine($"\t\t     ★★★★★  1등 :  {strings[0]}\n");
            Console.WriteLine($"\t\t      ★★★★  2등 :  {strings[1]}\n");
            Console.WriteLine($"\t\t       ★★★  3등 :  {strings[2]}\n");
            Console.WriteLine($"\t\t        ★★  4등 :  {strings[3]}\n");
            Console.WriteLine($"\t\t         ★  5등 :  {strings[4]}\n\n\n");
        }

        static void Main(string[] args)
        {
            bool gamefinished = false;

            horse[] horses = new horse[5];

            for (int ti = 0; ti < horses.Length; ti++)
            {
                horses[ti] = new horse();
                horses[ti].name = $"{ti + 1}번마";
                horses[ti].display();
            }

            while (gamefinished == false)
            {
                random = new Random();

                Thread.Sleep(1000); // 이 와일문은 1초에 한번씩 수행한다

                Console.Clear();

                for (int ti = 0; ti < horses.Length; ti++)
                {
                    int tpspeed = random.Next(minspeed, maxspeed + 1);
                    horses[ti].run(tpspeed);
                    horses[ti].display();
                }

                if (horses[0].finished && horses[1].finished && horses[2].finished && horses[3].finished && horses[4].finished)
                {
                    gamefinished = true;
                }
            }

            Console.Clear();

            gamerank();
        }
    }
}