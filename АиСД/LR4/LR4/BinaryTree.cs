using System;
using System.Net.Sockets;

namespace LR4
{
    public class BinaryNode
    {
        public BinaryNode left { get; set; }
        public BinaryNode right { get; set; }

        public int value;

        public BinaryNode(int value)
        {
            this.value = value;
            left = null;
            right = null;
        }
    }

    public class BinaryTree
    {
        private BinaryNode root;

        public BinaryTree(int value)
        {
            root = new BinaryNode(value);
        }

        public void Add(int value) => Add_(value, root);

        public bool Find(int value) => Find_(value, root);

        public void AddIfNotExist(int value)
        {
            if (!Find(value)) Add(value);
        }

        private void Add_(int value, BinaryNode node)
        {
            if (value > node.value)
            {
                if (node.right == null)
                {
                    node.right = new BinaryNode(value);
                }
                else
                {
                    Add_(value, node.right);
                }
            }
            else if (value < node.value)
            {
                if (node.left == null)
                {
                    node.left = new BinaryNode(value);
                }
                else
                {
                    Add_(value, node.left);
                }
            }
        }

        private bool Find_(int value, BinaryNode node)
        {
            if (node.value == value) return true;
            else if (node.value < value)
            {
                if (node.right == null) return false;
                else if (node.right.value == value) return true;
                else
                {
                    return Find_(value, node.right);
                }
            }
            else
            {
                if (node.left == null) return false;
                else if (node.left.value == value) return true;
                else
                {
                    return Find_(value, node.left);
                }
            }
        }

    }
}