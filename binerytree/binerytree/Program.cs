using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binerytree
{
    class Program
    {
        static void Main(string[] args)
        {

            binaryTree mytree = new binaryTree(19);
            Node searchNode = new Node();

            mytree.AddInOrder(mytree.Root(), 4);
            mytree.AddInOrder(mytree.Root(), 18);
            mytree.AddInOrder(mytree.Root(), 155);
            mytree.AddInOrder(mytree.Root(), 8);
            mytree.AddInOrder(mytree.Root(), 13);
            mytree.AddInOrder(mytree.Root(), 6);
            mytree.AddInOrder(mytree.Root(), 10);
            mytree.AddInOrder(mytree.Root(), 30);
            mytree.AddInOrder(mytree.Root(), 24);
            mytree.AddInOrder(mytree.Root(), 14);

            searchNode.data = mytree.search(mytree.Root(), 12);
            Console.WriteLine(searchNode.data);

            Console.WriteLine("\n\nInOrder");
            mytree.printInOrder(mytree.Root());
            Console.WriteLine("\n\nPostOrder");
            mytree.printPostOrder(mytree.Root());
            Console.WriteLine("\n\nPreOrder");
            mytree.printPreOrder(mytree.Root());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The Smallest: " + mytree.findSmallest(mytree.Root()));


            Console.WriteLine();
            Console.WriteLine("The Highest: " + mytree.findHighest(mytree.Root()));
            
            Console.WriteLine();
            Console.WriteLine("Is empty: " + mytree.isEmpty());

            Console.Read();
        }
    }
}
