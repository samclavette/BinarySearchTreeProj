using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        public Node rootNode;
        public Node leftChildNode;
        public Node rightChildNode;

        public BinarySearchTree()
        {
            Node rootNode = new Node(100);
            Node leftChildNode = new Node(80);
            Node rightChildNode = new Node(120);
        }

        public void AddNode(Node newNode)
        {
            if (newNode.value > rootNode.value)
            {
                if (newNode.value > rightChildNode.value)
                {

                }
                else if (newNode.value <= rightChildNode.value)
                {

                }
            }
            else if (newNode.value <= rootNode.value)
            {
                if (newNode.value > leftChildNode.value)
                {

                }
                else if (newNode.value <= leftChildNode.value)
                {

                }
            }
        }

        public void Search()
        {

        }
    }
}
