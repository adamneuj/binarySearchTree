using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySearchTree
{
    class Node
    {
        public int data;
        public Node root;
        public Node rightChild;
        public Node leftChild;

        public Node(int value)
        {
            data = value;
        }
    }
}
