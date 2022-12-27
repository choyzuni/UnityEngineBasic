using System;

namespace linked_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mylinkedlist<int> tlist= new mylinkedlist<int>();

            tlist.display();

            Console.WriteLine("---------------------");

            tlist.addlast(40);
            tlist.addfirst(30);
            tlist.addlast(50);
            tlist.addfirst(20);
            tlist.addfirst(10);
            tlist.addlast(60);

            tlist.display();

            Console.WriteLine("---------------------");

            tlist.remove(30);

            tlist.removelast(40);

            tlist.display();

            Console.WriteLine("---------------------");

            tlist.addbefore(20, 25);

            tlist.addafter(20, 15);

            tlist.display();

            Console.WriteLine("---------------------");
        }
    }
}
