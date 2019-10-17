using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Add(100);
            binarySearchTree.Add(60);
            binarySearchTree.Add(120);
            binarySearchTree.Add(40);
            binarySearchTree.Add(130);
            binarySearchTree.Search(115);
        }
    }
}
