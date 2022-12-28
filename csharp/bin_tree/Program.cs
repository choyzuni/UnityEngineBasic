using System;

namespace bin_tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            my_bin_tree<int> bintree = new my_bin_tree<int>();

            bintree.find(30);

            bintree.add(30);

            bintree.find(30);
            bintree.find(25);
            bintree.find(35);




        }
    }
}
