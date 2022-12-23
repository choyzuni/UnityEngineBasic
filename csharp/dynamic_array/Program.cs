using System;

namespace dynamic_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            arr[0] = 1;

            dynamic_arr da = new dynamic_arr();

            da.add(1);
            Console.WriteLine(da[0]);

            da.find(biggerthan20);
            

        }

        public static bool biggerthan20(int value)
        {
            return value > 20;
        }
    }
}
