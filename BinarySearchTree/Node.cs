﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        public int data;
        public Node rightChildNode;
        public Node leftChildNode;

        public Node(int data)
        {
            this.data = data;
        }
    }
}
