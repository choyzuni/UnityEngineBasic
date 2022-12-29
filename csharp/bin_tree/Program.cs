using System;

namespace bin_tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            my_bin_tree<int> bintree = new my_bin_tree<int>();

            /*
            bintree.add(30);
            bintree.add(30);

            bintree.add(20);
            bintree.add(20);

            bintree.add(15);
            bintree.add(10);
            bintree.add(25);
            bintree.add(45);

            bintree.add(47);
            bintree.add(47);

            bintree.add(40);
            bintree.add(35);
            bintree.add(50);
            bintree.add(55);
            bintree.add(22);
            bintree.add(17);

            Console.WriteLine("---------------------------");

            bintree.InorderTravers(bintree.getroot());

            Console.WriteLine("---------------------------");

            bintree.remove(25);
            bintree.remove(20);
            bintree.remove(15);
            bintree.remove(50);
            bintree.remove(47);
            bintree.remove(30);

            bintree.InorderTravers(bintree.getroot());
            */

            bintree.add(20);
            bintree.add(10);
            bintree.add(30);
            bintree.add(40);
            bintree.add(50);
            bintree.add(60);
            bintree.add(70);

            bintree.InorderTravers(bintree.getroot());

            Console.WriteLine();

            bintree.remove(20);

            bintree.InorderTravers(bintree.getroot());

        }
    }
}
