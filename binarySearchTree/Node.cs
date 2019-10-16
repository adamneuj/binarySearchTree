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
        public Node parent;
        public Node rightChild;
        public Node leftChild;

        public Node(int data)
        {
            this.data = data;
        }
    }
}
