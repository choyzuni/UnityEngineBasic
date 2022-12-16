using System;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrint = new int[2];

            arrint[0] = 375;
            arrint[1] = 75;

            int[] arrint_1 = { 1, 2, 3 };

            int[][] arrarrint = new int[3][];

            arrarrint[0] = new int[2];
            arrarrint[1] = new int[2];
            arrarrint[2] = new int[2];

            arrarrint[0][0] = 35;

            Console.WriteLine(arrarrint[0][0]);

            string name = "choy";
            char first = name[0];
            Console.WriteLine(name[0]);
            char[] arrchar = { 'k', 'i', 'm', '\0' };
            Console.WriteLine(arrchar[0]);

        }
    }
}
