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
        Node currentNode;
        public BinarySearchTree()
        {
            root = null;
            currentNode = null;
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
                while(root.leftChild == null)
                {
                    root.leftChild = node;
                }
                temp.leftChild = node;
                return node;

            }
            else
            {
                while(root.rightChild == null)
                {
                    root.rightChild = node;
                }
                temp.rightChild = node;
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
