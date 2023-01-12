using System;
using System.Collections.Generic;

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

            dynamic_arr<double>.dynamicarr_enum<double> enumerator = da_double.GetEnumerator();

            while (enumerator.movenext())
            {
                Console.WriteLine(enumerator.current);
            }
            enumerator.reset();
            enumerator.Dispose();

            // using : Dispose() 호출을 보장하는 구문
            using (IEnumerator<int> enumerator_int = new dynamic_arr<int>.GetEnumerator())
            {
                while (enumerator_int.MoveNext()) ;
                Console.WriteLine(enumerator_int.Current);
                enumerator.reset();
            }

        }

        public static bool biggerthan20(int value)
        {
            return value > 20;
        }
    }
}
