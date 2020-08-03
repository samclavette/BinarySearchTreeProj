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
            else
            {
                Node currentNode = rootNode;

                while (currentNode != null)
                {
                    if (newNode.data > currentNode.data)
                    {
                        if (currentNode.rightChildNode == null)
                        {
                            currentNode.rightChildNode = newNode;
                        }
                        else
                            currentNode = currentNode.rightChildNode;
                    }
                    else if (newNode.data <= currentNode.data)
                    {
                        if (currentNode.leftChildNode == null)
                        {
                            currentNode.leftChildNode = newNode;
                        }
                        else
                            currentNode = currentNode.leftChildNode;
                    }
                }
            }           
        }

        public void Search()
        {

        }
    }
}
