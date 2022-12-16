using System;
using System.Runtime.ExceptionServices;

namespace loop_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[100];
            int ti = 0;
            while (ti < 100)
            {
                arr[ti] = ti;
                Console.WriteLine(arr[ti]);
                ti++;
            }

            Console.WriteLine();

            do
            {
                Console.WriteLine($"do while : {ti}");
            } while (ti < 100);

            Console.WriteLine();

            string name = "choyjuniski";
            for (ti = 0; ti < name.Length; ti++)
            {
                Console.WriteLine(name[ti]);
            }

            int[][] arrint = new int[3][];
            arrint[0] = new int[3];
            arrint[1] = new int[3];
            arrint[2] = new int[3];

            Console.WriteLine();

            int tb = 0;

            for (ti = 0; ti < arrint.Length; ti++)
            {
                for (int ta = 0; ta < arrint[ti].Length; ta++)
                {
                    arrint[ti][ta] = ++tb;
                    Console.WriteLine(arrint[ti][ta]);
                }
            }

        }
    }
}
