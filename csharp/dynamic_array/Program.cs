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

            Console.WriteLine(da.length() ); 

            da.find(biggerthan20);
            
            dynamic_arr<double> da_double = new dynamic_arr<double>();

            da_double.add(3.5);
            Console.WriteLine(da_double[0]);

            Console.WriteLine(da_double.length());

            da_double.add(0.5);
            Console.WriteLine(da_double[1]);
            Console.WriteLine(da_double.length());

            dynamic_arr<double>.dynamicarr_enum<double> enumerator = da_double.GetEnumerator();

            while (enumerator.movenext())
            {
                Console.WriteLine(enumerator.current);
            }
            enumerator.reset();


        }

        public static bool biggerthan20(int value)
        {
            return value > 20;
        }
    }
}
