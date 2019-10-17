using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySearchTree
{
    class BinarySearchTree
    {
        Node root;
        public BinarySearchTree()
        {
            root = null;
        }
        public Node Add(int data) //needs to rework
        {
            Node node = new Node(data);
            if(root == null)
            {
                root = node;
                return root;
            }
            Node temp = root;
            if(data <= root.data)
            {
                while(temp.leftChild == null)
                {
                    temp.leftChild = node;
                }
                node = temp;
                return node;

            }
            else
            {
                while(temp.rightChild == null)
                {
                    temp.rightChild = node;
                }
                node = temp;
                return node;
            }
        }
        public void Search(Node node) //still need to finish
        {
            if(node == null)
            {

            }
            Search(node.leftChild);
            Search(node.rightChild);
        }
    }
}
