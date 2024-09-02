using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    public class BST
    {
        public Node root;
        public class Node
        {
            public int value { get; set; }
            public Node left { get; set; }
            public Node right { get; set; }
            public Node(int value)
            {
                this.value = value;
            }
        }

        public bool insert(int value)
        {
            Node newNode = new Node(value);
            if (root == null)
            {
                root = newNode;
                return true;
            }
            Node temp = root;
            while (true)
            {
                if (newNode.value == temp.value) return false;
                if (newNode.value < temp.value)
                {
                    if (temp.left == null)
                    {
                        temp.left = newNode;
                        return true;
                    }
                    temp = temp.left;
                }
                else
                {
                    if (temp.right == null)
                    {
                        temp.right = newNode;
                        return true;
                    }
                    temp = temp.right;
                }
            }

        }
        public bool contains(int value)
        {
            Node searchedElement = new Node(value);

            if (root == null)
            {
                return false;
            }
            Node temp = root;
            while (temp != null)
            {
            
                 if (searchedElement.value < temp.value)
                {
                    temp = temp.left;
                }
                else if(searchedElement.value > temp.value)
                {
                    temp = temp.right;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
