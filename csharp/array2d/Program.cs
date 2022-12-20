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

            public void resetdisplay()
            {
                reset();

                Console.WriteLine();
                Console.WriteLine("막힌 길입니다.");
                Console.WriteLine();
            }

            public int getpos()
            {
                return map[my, mx];
            }

            public void setpos(int tx, int ty)
            {
                // map[my, mx] = map_0[my, mx]; // 이전 위치 롤백
                // 이런식으로도 이전 위치 롤백이 가능함

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
                    resetdisplay();

                    return;
                }

                // 지나갈 수 없는 벽인지 체크
                if (map[my + 1, mx] == 1)
                {
                    resetdisplay();

                    return;
                }

                setpos(mx, my + 1);
            }

            public void moveup()
            {
                // 움직이면 맵의 경계를 벗어나는지 체크
                if (my <= map.GetLength(0) - map.GetLength(0))
                {
                    resetdisplay();

                    return;
                }

                // 지나갈 수 없는 벽인지 체크
                if (map[my - 1, mx] == 1)
                {
                    resetdisplay();

                    return;
                }

                setpos(mx, my - 1);
            }

            public void movert()
            {
                // 움직이면 맵의 경계를 벗어나는지 체크
                if (mx >= map.GetLength(1) - 1)
                {
                    resetdisplay();

                    return;
                }

                // 지나갈 수 없는 벽인지 체크
                if (map[my, mx + 1] == 1)
                {
                    resetdisplay();

                    return;
                }

                setpos(mx + 1, my);
            }

            public void movelt()
            {
                // 움직이면 맵의 경계를 벗어나는지 체크
                if (mx <= map.GetLength(1) - map.GetLength(1))
                {
                    resetdisplay();

                    return;
                }

                // 지나갈 수 없는 벽인지 체크
                if (map[my , mx - 1] == 1)
                {
                    resetdisplay();

                    return;
                }

                setpos(mx - 1, my);
            }
        }

        // 2차원 배열
        static int[,] map = new int[5, 5]
            {
                { 0,1,1,1,1 },
                { 0,1,1,1,1 },
                { 0,0,0,1,1 },
                { 1,1,0,1,1 },
                { 1,1,0,0,2 },
            };

        //static int[,] map_0 = new int[5, 5]
        //{
        //        { 0,1,1,1,1 },
        //        { 0,1,1,1,1 },
        //        { 0,0,0,1,1 },
        //        { 1,1,0,1,1 },
        //        { 1,1,0,0,2 },
        //};

        static void Main(string[] args)
        {
            player player = new player();
            player.setpos(0, 0);

            string tc = string.Empty;
            while (true)
            {
                tc = Console.ReadLine();

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
                else
                {
                    player.reset();
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
