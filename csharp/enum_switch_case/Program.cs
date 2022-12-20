using System;
using System.Runtime.Intrinsics.Arm;

namespace enum_switch_case
{
    internal class Program
    {
        // enum 열거형 ( 사용자 정의 자료형 )
        // 32 bit 정수형 - 특정 요소에 값이 할당되어있지 않으면 이전 요소의 값에 + 1
        // 첫 요소에 값이 할당되어있지 않으면 0 이다
        enum state
        { 
            idle,
            walk,
            run,
            jump,
            atk
        }

        static state state_0;



        static void Main(string[] args)
        {

            string tB;
            tB = Console.ReadLine();

            switch (tB)
            {
                case "banana":
                    {
                        Console.WriteLine("모두 바나나를 들어요~");
                    }
                    break;
                case "water melon":
                    {
                        Console.WriteLine("수박도에 나와있다");
                    }
                    break;

                default:
                    {
                        Console.WriteLine("훌쩍훌쩍");
                    }
                    break;
            }

            int tA;
            tA = Convert.ToInt32(Console.ReadLine());
            // int tA = Int32.Parse(Console.ReadLine()); 으로도 사용 가능

            switch (tA)
            {
                case 0:
                    {
                        Console.WriteLine("대기상태");
                    }
                    break;
                case 1:
                    {
                        Console.WriteLine("걷기");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("달리기");
                    }
                    break;

                default:
                    {
                        Console.WriteLine("무슨 말인지 모르겠어요");
                    }
                    break;
            }


            while (true)
            {
                // state_0 = (state)Int32.Parse(Console.ReadLine());
                state_0 = (state)Enum.Parse(typeof(state), Console.ReadLine());
                // enum.parse 는 조금 더 복잡한 형태

                switch (state_0)
                {
                    case state.idle:
                        Console.WriteLine("idle");
                        break;
                    case state.walk:
                        Console.WriteLine("walk");
                        break;
                    case state.run:
                        Console.WriteLine("run");
                        break;
                    case state.jump:
                        Console.WriteLine("jump");
                        break;
                    case state.atk:
                        Console.WriteLine("atk");
                        break;
                    default:
                        Console.WriteLine("아무 상태도 아닙니다");
                        break;
                        
                }
            }



        }
    }
}
