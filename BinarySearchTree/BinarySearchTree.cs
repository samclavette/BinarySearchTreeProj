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
                            break;
                        }
                        else
                            currentNode = currentNode.rightChildNode;
                    }
                    else if (newNode.data <= currentNode.data)
                    {
                        if (currentNode.leftChildNode == null)
                        {
                            currentNode.leftChildNode = newNode;
                            break;
                        }
                        else
                            currentNode = currentNode.leftChildNode;
                    }
                }
            }           
        }

        public bool Search(int number)
        {
            if (rootNode.data == number)
            {
                return true;
            }
            else
            {
                Node currentNode = rootNode;

                while (currentNode.data != number)
                {
                    if (number > currentNode.data)
                    {
                        if (currentNode.rightChildNode.data == number)
                        {
                            return true;
                        }
                        else if (currentNode.rightChildNode == null)
                        {
                            return false;
                        }
                        else
                            currentNode = currentNode.rightChildNode;
                    }
                    else if (number <= currentNode.data)
                    {
                        if (currentNode.leftChildNode.data == number)
                        {
                            return true;
                        }
                        else if (currentNode.leftChildNode == null)
                        {
                            return false;
                        }
                        else
                            currentNode = currentNode.leftChildNode;
                    }
                }
            }
            return false;
        }
    }
}
