using System;

namespace array2d
{
    internal class Program
    {
        // inner class
        // 클래스 내에 정의된 클래스
        class player
        {
            private int mx;
            private int my;

            public void reset()
            {
                map[my, mx] = 5;

                Console.Clear();

                display();

                Console.WriteLine();

                map[my, mx] = 0;
            }

            public int getpos()
            {
                return map[my, mx];
            }

            public void setpos(int tx, int ty)
            {
                mx = tx;
                my = ty;

                map[ty, tx] = 5;

                Console.Clear();

                display();



                Console.WriteLine();

                map[ty, tx] = 0;
            }

            public void movedown()
            {
                // 움직이면 맵의 경계를 벗어나는지 체크
                if (my >= map.GetLength(0) - 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("막힌 길입니다.");
                    Console.WriteLine();
                    return;
                }

                // 지나갈 수 없는 벽인지 체크
                if (map[my + 1, mx] == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("막힌 길입니다.");
                    Console.WriteLine();
                    return;
                }

                setpos(mx, my + 1);
            }

            public void moveup()
            {
                // 움직이면 맵의 경계를 벗어나는지 체크
                if (my <= map.GetLength(0) - 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("막힌 길입니다.");
                    Console.WriteLine();
                    return;
                }

                // 지나갈 수 없는 벽인지 체크
                if (map[my - 1, mx] == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("막힌 길입니다.");
                    Console.WriteLine();
                    return;
                }

                setpos(mx, my - 1);
            }

            public void movert()
            {
                // 움직이면 맵의 경계를 벗어나는지 체크
                if (mx >= map.GetLength(1) - 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("막힌 길입니다.");
                    Console.WriteLine();
                    return;
                }

                // 지나갈 수 없는 벽인지 체크
                if (map[my, mx + 1] == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("막힌 길입니다.");
                    Console.WriteLine();
                    return;
                }

                setpos(mx + 1, my);
            }

            public void movelt()
            {
                // 움직이면 맵의 경계를 벗어나는지 체크
                if (mx <= map.GetLength(1) - 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("막힌 길입니다.");
                    Console.WriteLine();
                    return;
                }

                // 지나갈 수 없는 벽인지 체크
                if (map[my , mx - 1] == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("막힌 길입니다.");
                    Console.WriteLine();
                    return;
                }

                setpos(mx - 1, my);
            }
        }

        // 2차원 배열
        static int[,] map = new int[5, 5]
            {
                // 0 : 열린 길이고
                // 1 : 막힌 길
                // 2 : 도착 지점
                // 5 : 플레이어
                { 0,1,1,1,1 },
                { 0,1,1,1,1 },
                { 0,0,0,1,1 },
                { 1,1,0,1,1 },
                { 1,1,0,0,2 },
            };

        static void Main(string[] args)
        {
            player player = new player();
            player.setpos(0, 0);

            while (true)
            {
                string tc = Console.ReadLine();

                if (tc == "a")
                {
                    player.movelt();
                }
                else if (tc == "d")
                {
                    player.movert();
                }
                else if (tc == "w")
                {
                    player.moveup();
                }
                else if (tc == "s")
                {
                    player.movedown();
                }
                else if (tc == "r")
                {
                    player.reset();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("사용할 수 없는 키입니다.");
                    Console.WriteLine();
                }

                if (player.getpos() == map[4, 4])
                {
                    Console.WriteLine("클리어 하셨습니다!");
                    break;
                }
            }
        }

        static void display()
        {
            for (int ti = 0; ti < map.GetLength(0);ti++)
            {
                for (int ta = 0; ta < map.GetLength(1); ta++)
                {
                    if (map[ti, ta] == 0)
                    {
                        Console.Write("□");
                    }
                    else if (map[ti, ta] == 1)
                    {
                        Console.Write("■");
                    }
                    else if (map[ti, ta] == 2)
                    {
                        Console.Write("☆");
                    }
                    else if (map[ti, ta] == 5)
                    {
                        Console.Write("▣");
                    }
                }
                    Console.WriteLine();
            }
        }
    }
}
