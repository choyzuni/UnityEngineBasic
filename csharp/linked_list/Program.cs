using System;

namespace linked_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mylinkedlist<int> tlist= new mylinkedlist<int>();

            tlist.addfirst(30);

            tlist.addlast(50);

            tlist.addfirst(20);

            Console.WriteLine(tlist.count);
            
        }
    }
}
