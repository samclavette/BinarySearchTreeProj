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

        public BinarySearchTree()
        {
            
        }

        public void AddNode(Node newNode)
        {
            if (rootNode == null)
            {
                rootNode = newNode;
            }
            // right side of BST
            else if (newNode.data > rootNode.data)
            {
                if (rootNode.rightChildNode == null)
                {
                    rootNode.rightChildNode = newNode;
                }
                else
                {
                    rootNode = rootNode.leftChildNode;
                    if (newNode.data > rootNode.data)
                    {
                        rootNode.rightChildNode = newNode;
                    }
                    else if (newNode.data <= rootNode.data)
                    {
                        rootNode.leftChildNode = newNode;
                    }
                }
            }
            // left side of BST
            else if (newNode.data <= rootNode.data)
            {
                if (rootNode.leftChildNode == null)
                {
                    rootNode.leftChildNode = newNode;
                }
                else
                {
                    rootNode = rootNode.leftChildNode;
                    if (newNode.data > rootNode.data)
                    {
                        rootNode.rightChildNode = newNode;
                    }
                    else if (newNode.data <= rootNode.data)
                    {
                        rootNode.leftChildNode = newNode;
                    }
                }
            }
        }

        public void Search()
        {

        }
    }
}
