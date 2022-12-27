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

            tlist.addafter(10, 5);

            tlist.addbefore(10, 15);

            tlist.addafter(60, 55);

            tlist.addbefore(60, 65);

            tlist.display();

            Console.WriteLine("---------------------");

            tlist.remove(5);
            tlist.remove(10);
            tlist.remove(15);
            tlist.remove(20);
            tlist.remove(50);
            tlist.remove(55);
            tlist.remove(60);
            tlist.remove(65);

            tlist.display();
        }

    }
}
