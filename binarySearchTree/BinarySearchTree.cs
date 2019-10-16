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
        public Node Add(int data)
        {
            Node node = new Node(data);
            if(root == null)
            {
                root = node;
                return root;
            }
            else if(data <= root.data)
            {
                root.leftChild = node;
                return root;
            }
            else
            {
                root.rightChild = node;
                return root;
            }
        }
        public void Search(Node node)
        {
            if(node == null)
            {

            }
            Search(node.leftChild);
            Search(node.rightChild);
        }
    }
}
