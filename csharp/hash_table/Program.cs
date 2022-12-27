using System;

namespace hash_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            my_hash_T ht = new my_hash_T();

            ht.add("choy", 95);
            ht.add('A', "알파벳");
            ht.add(1, 3.0f);

            // object ( 객체 타입 )
            // boxing - object 로 변환하는 과정 ( object 타입으로 바꿔서 힙 영역에 새로운 객체 할당 )
            // unboxing - object 에서 원래 타입으로 변환하는 과정

            string temp = (string)ht['A'];
            int score = (int)ht["choy"];

            Console.WriteLine(temp);
            Console.WriteLine(score);

            my_hash_T<string, int> htT = new my_hash_T<string, int>();

            htT.add("철수", 95);
            htT.add("남생", 100);
        }
    }
}
