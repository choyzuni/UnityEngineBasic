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

            public void reset()
            {
                totaldistance = 0;
                finished = false;
                goalcheck = 0;
            }

            public void display()
            {
                if (goalpos <= totaldistance)
                {
                    Console.WriteLine($"\n{name}  〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓 ||  Finished !!");
                }
                else if (190 <= totaldistance)
                {
                    Console.WriteLine($"\n{name}  〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓▶ ||  {totaldistance}");
                }
                else if (180 <= totaldistance)
                {
                    Console.WriteLine($"\n{name}  〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓▶〓 ||  {totaldistance}");
                }
                else if (170 <= totaldistance)
                {
                    Console.WriteLine($"\n{name}  〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓▶〓〓 ||  {totaldistance}");
                }
                else if (160 <= totaldistance)
                {
                    Console.WriteLine($"\n{name}  〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓▶〓〓〓 ||  {totaldistance}");
                }
                else if (150 <= totaldistance)
                {
                    Console.WriteLine($"\n{name}  〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓▶〓〓〓〓 ||  {totaldistance}");
                }
                else if (140 <= totaldistance)
                {
                    Console.WriteLine($"\n{name}  〓〓〓〓〓〓〓〓〓〓〓〓〓〓▶〓〓〓〓〓 ||  {totaldistance}");
                }
                else if (130 <= totaldistance)
                {
                    Console.WriteLine($"\n{name}  〓〓〓〓〓〓〓〓〓〓〓〓〓▶〓〓〓〓〓〓 ||  {totaldistance}");
                }
                else if (120 <= totaldistance)
                {
                    Console.WriteLine($"\n{name}  〓〓〓〓〓〓〓〓〓〓〓〓▶〓〓〓〓〓〓〓 ||  {totaldistance}");
                }
                else if (110 <= totaldistance)
                {
                    Console.WriteLine($"\n{name}  〓〓〓〓〓〓〓〓〓〓〓▶〓〓〓〓〓〓〓〓 ||  {totaldistance}");
                }
                else if (100 <= totaldistance)
                {
                    Console.WriteLine($"\n{name}  〓〓〓〓〓〓〓〓〓〓▶〓〓〓〓〓〓〓〓〓 ||  {totaldistance}");
                }
                else if (90 <= totaldistance)
                {
                    Console.WriteLine($"\n{name}  〓〓〓〓〓〓〓〓〓▶〓〓〓〓〓〓〓〓〓〓 ||  {totaldistance}");
                }
                else if (80 <= totaldistance)
                {
                    Console.WriteLine($"\n{name}  〓〓〓〓〓〓〓〓▶〓〓〓〓〓〓〓〓〓〓〓 ||  {totaldistance}");
                }
                else if (70 <= totaldistance)
                {
                    Console.WriteLine($"\n{name}  〓〓〓〓〓〓〓▶〓〓〓〓〓〓〓〓〓〓〓〓 ||  {totaldistance}");
                }
                else if (60 <= totaldistance)
                {
                    Console.WriteLine($"\n{name}  〓〓〓〓〓〓▶〓〓〓〓〓〓〓〓〓〓〓〓〓 ||  {totaldistance}");
                }
                else if (50 <= totaldistance)
                {
                    Console.WriteLine($"\n{name}  〓〓〓〓〓▶〓〓〓〓〓〓〓〓〓〓〓〓〓〓 ||  {totaldistance}");
                }
                else if (40 <= totaldistance)
                {
                    Console.WriteLine($"\n{name}  〓〓〓〓▶〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓 ||  {totaldistance}");
                }
                else if (30 <= totaldistance)
                {
                    Console.WriteLine($"\n{name}  〓〓〓▶〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓 ||  {totaldistance}");
                }
                else if (20 <= totaldistance)
                {
                    Console.WriteLine($"\n{name}  〓〓▶〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓 ||  {totaldistance}");
                }
                else if (10 <= totaldistance)
                {
                    Console.WriteLine($"\n{name}  〓▶〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓 ||  {totaldistance}");
                }
                else if (0 <= totaldistance)
                {
                    Console.WriteLine($"\n{name}  ▶〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓 ||  {totaldistance}");
                }
            }
        }

        class batt
        {
            private double totalmoney = 20000;
            private double battmoney;
            private string battname;
            public bool battendcheck = false;
            private double battper = 0;

            public void battstart()
            {
                int tbatt;
                Console.WriteLine($"\n\t배팅 금액 : 0원   /   총 금액 : {totalmoney}원");
                Console.WriteLine($"\n\t배팅할 말의 번호를 고르세요.");

                do
                {
                    tbatt = Convert.ToInt32(Console.ReadLine());
                    if (tbatt > 5 || tbatt < 1)
                    {
                        Console.WriteLine("\n\t1번부터 5번 중에 한가지 숫자를 고르세요.");
                    }
                } while (tbatt > 5 || tbatt < 1);

                battname = $"{tbatt}번마";
                Console.WriteLine($"\n\t배팅할 금액을 설정하세요 / 최소 배팅 금액 : 500원");

                moneybatt();

                totalmoney -= battmoney;
            }

            private void moneybatt()
            {
                battmoney = Convert.ToInt32(Console.ReadLine());

                if (battmoney > totalmoney)
                {
                    Console.WriteLine($"\n\t현재 가진 금액인 {totalmoney}원 이내로만 걸 수 있습니다.");
                    moneybatt();
                }
                if (battmoney < 500)
                {
                    Console.WriteLine($"\n\t최소 배팅 금액인 500원 이상 걸 수 있습니다.");
                    moneybatt();
                }
            }

            public void batting()
            {
                Console.WriteLine($"\n\t배팅 금액 : {battmoney}   /   총 금액 : {totalmoney}");
                Console.WriteLine($"\n\t배팅한 말 : {battname}");
            }

            public void battend()
            {

                if (strings[4] == battname)
                {
                    Console.WriteLine($"\n\t당신의 말은 5등입니다");
                    Console.WriteLine($"\n\t환급금은 없습니다.");
                    Console.WriteLine($"\n\t총 금액 : {totalmoney}원\n");
                    battendcheck = true;
                }
                else if (strings[3] == battname)
                {
                    if (battendcheck == false)
                    {
                        battper = battmoney * 0.2;
                        totalmoney = totalmoney + battper;
                    }
                    Console.WriteLine($"\n\t당신의 말은 4등입니다.");
                    Console.WriteLine($"\n\t환급금은 {battper}원 입니다.");
                    Console.WriteLine($"\n\t총 금액 : {totalmoney}원\n");
                    battendcheck = true;
                }
                else if (strings[2] == battname)
                {
                    if (battendcheck == false)
                    {
                        battper = battmoney * 0.4;
                        totalmoney = totalmoney + battper;
                    }
                    Console.WriteLine($"\n\t당신의 말은 3등입니다.");
                    Console.WriteLine($"\n\t환급금은 {battper}원 입니다.");
                    Console.WriteLine($"\n\t총 금액 : {totalmoney}원\n");
                    battendcheck = true;
                }
                else if (strings[1] == battname)
                {
                    if (battendcheck == false)
                    {
                        battper = battmoney * 0.8;
                        totalmoney = totalmoney + battper;
                    }
                    Console.WriteLine($"\n\t당신의 말은 2등입니다.");
                    Console.WriteLine($"\n\t환급금은 {battper}원 입니다.");
                    Console.WriteLine($"\n\t총 금액 : {totalmoney}원\n");
                    battendcheck = true;
                }
                else if (strings[0] == battname)
                {
                    if (battendcheck == false)
                    {
                        battper = battmoney * 1.5;
                        totalmoney = totalmoney + battper;
                    }
                    Console.WriteLine($"\n\t당신의 말은 1등입니다.");
                    Console.WriteLine($"\n\t환급금은 {battper}원 입니다.");
                    Console.WriteLine($"\n\t총 금액 : {totalmoney}원\n");
                    battendcheck = true;
                }
            }

            public double getmoney()
            {
                return totalmoney;
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
            Console.WriteLine("\n\n\t경기 종료!!!\n");
            Console.WriteLine($"     ★★★★★  1등 :  {strings[0]}\n");
            Console.WriteLine($"      ★★★★  2등 :  {strings[1]}\n");
            Console.WriteLine($"       ★★★  3등 :  {strings[2]}\n");
            Console.WriteLine($"        ★★  4등 :  {strings[3]}\n");
            Console.WriteLine($"         ★  5등 :  {strings[4]}\n");
        }

        static void Main(string[] args)
        {
            // bool gamefinished = false;

            horse[] horses = new horse[5];

            batt batts = new batt();

            for (int ti = 0; ti < horses.Length; ti++)
            {
                horses[ti] = new horse();
                horses[ti].name = $"{ti + 1}번마";
                horses[ti].display();
            }

            batts.battstart();

            while (true)
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

                batts.batting();

                if (horses[0].finished && horses[1].finished && horses[2].finished && horses[3].finished && horses[4].finished)
                {
                    Console.Clear();

                    gamerank();

                    batts.battend();

                    if (batts.getmoney() < 500)
                    {
                        Console.WriteLine("\t남은 금액이 없으므로 더 이상 게임을 진행할 수 없습니다.\n\n");
                        return;
                    }

                    Console.WriteLine("\n\t게임을 계속 진행하시겠습니까?   /   y or n");
                    string endcheck = Console.ReadLine();

                    switch (endcheck)
                    {
                        case "y":
                            {
                                Console.Clear();

                                for (int ti = 0; ti < horses.Length; ti++)
                                {
                                    horses[ti].reset();
                                    horses[ti].display();
                                }

                                batts.battendcheck = false;

                                batts.battstart();
                            }
                            break;
                        case "n":
                            {
                                Console.WriteLine("\n\t게임을 종료합니다.");
                                return;
                            }

                        default:
                            batts.battendcheck = true;
                            break;
                    }
                }
            }
        }
    }
}