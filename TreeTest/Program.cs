using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinarySearchTree;
using static System.Console;
using static Utils.Generator;
using static Utils.ArrayExtension;

namespace TreeTest
{

    class Program
    {

        static void Main(string[] args)
        {
            int[] array = GenerateIntArray(20);
            array.Print();

            BinaryTree<int> tree = new BinaryTree<int>(new List<int>(array));

            foreach(ValueType value in tree) 
				Write(value + " ");
			WriteLine();
			

            WriteLine(tree.length);
            WriteLine("\n");

            tree.Add(6);
            tree.Add(6);
            tree.Add(6);
            tree.Add(2);
            tree.Add(1);
            tree.Add(-9);

            WriteLine(tree.Add(6));
            WriteLine(tree.Find(2));
            WriteLine(tree.Find(16));
            WriteLine("\n");

            WriteLine(tree);
            WriteLine(tree.length);
            WriteLine("\n");

            tree.Delete(2);

            WriteLine(tree);
            WriteLine(tree.length);
            WriteLine("\n");

            tree.Delete(666);

            WriteLine(tree);
            WriteLine(tree.length);
            WriteLine("\n");

            ReadKey();
        }
    }
}
