using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace arvore_binaria
{
    public class Node
    {
        public int value;
        public Node? left, right;

        public Node(int item)
        {
            value = item;
            left = null;
            right = null;
        }
    }
}