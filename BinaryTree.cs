using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using arvore_binaria;

namespace arvore_binaria
{
    public class BinaryTree
    {
        public Node? root;

        public BinaryTree()
        {
            root = null;
        }

        public Node? Search(Node? root, int key)
        {
            if (root == null || root.value == key)
                return root;

            if (root.value > key)
                return Search(root.left, key);

            return Search(root.right, key);
        }

        public void Insert(int value)
        {
            root = InsertRecursive(root, value);
        }

        private Node? InsertRecursive(Node? root, int value)
        {
            if (root == null)
            {
                root = new Node(value);
                return root;
            }

            if (value < root.value)
                root.left = InsertRecursive(root.left, value);
            else if (value > root.value)
                root.right = InsertRecursive(root.right, value);

            return root;
        }

        public void InOrderTraversal(Node? node)
        {
            if (node != null)
            {
                InOrderTraversal(node.left);
                Console.Write(node.value + " ");
                InOrderTraversal(node.right);
            }
        }
    }
}