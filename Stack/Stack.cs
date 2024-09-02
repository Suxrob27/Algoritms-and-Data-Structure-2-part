using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{

    public class Stacki
    {
        public class Node
        {
            public int value { get; set; }
            public Node next { get; set; }
            public Node(int value)
            {
                this.value = value;
            }
        }

        private Node top;
        private int height;

        public Stacki(int value)
        {
            Node newNode = new Node(value);
            top = newNode;
            height = 1;
        }

        public Node getTop() { return top; }
        public int getHeight() { return height; }
        public void printStack()
        {
            Node temp = top;
            while (temp != null)

            {
                Console.WriteLine(temp.value);
                temp = temp.next;
            }
        }

        // Fix: Add a return type of 'Node' to the pop() method
        public Node pop()
        {
            if (height == 0)
            {
                return null;
            }
            Node temp = top;
            top.next = null;
            top = top.next;
            temp.next = null;

            height--;
            return temp;
        }
    }

}
