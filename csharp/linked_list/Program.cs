using System;

namespace linked_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mylinkedlist<int> tlist= new mylinkedlist<int>();

            tlist.addlast(40);
            tlist.addfirst(30);
            tlist.addlast(50);
            tlist.addfirst(20);
            tlist.addfirst(10);
            tlist.addlast(60);

            mylinkedlist<int>.linkedlist_enum<int> enumerator = tlist.GetEnum();

            while (enumerator.movenext())
            {
                Console.WriteLine(enumerator.current);
            }
            enumerator.reset();
        }

    }
}
