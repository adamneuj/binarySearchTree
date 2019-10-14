using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySearchTree
{
    class BinarySearchTree
    {
        Node start;
        public BinarySearchTree()
        {
            
        }
        public void Add(int data)
        {
            Node node = new Node(data);
            if(start == null)
            {
                start = node;
                return;
            }

        }
    }
}
