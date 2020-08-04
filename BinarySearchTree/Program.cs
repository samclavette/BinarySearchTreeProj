using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();

            Node nodeOne = new Node(10);
            Node nodeTwo = new Node(5);
            Node nodeThree = new Node(7);
            Node nodeFour = new Node(12);
            Node nodeFive = new Node(8);
            Node nodeSix = new Node(10);
            Node nodeSeven = new Node(22);

            tree.AddNode(nodeOne);
            tree.AddNode(nodeTwo);
            tree.AddNode(nodeThree);
            tree.AddNode(nodeFour);
            tree.AddNode(nodeFive);
            tree.AddNode(nodeSix);
            tree.AddNode(nodeSeven);
            tree.Search(10);

        }
    }
}
