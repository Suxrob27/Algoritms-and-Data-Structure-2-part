using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Queue
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
        private Node fisrt;
        private Node last;
        private int length;
        public Queue(int value)
        {
            Node newNode = new Node(value);
            fisrt = newNode;    
            last = newNode;
            length = 1;
        }
        public Node getFisrt() { return fisrt; }
        public Node getLast() { return last; }  
        public int getLength() { return length; } 
        
        public void enqueue(int value)
        {
            Node newNode = new Node(value);
            if (length == 0)
            {
                fisrt = newNode; last = newNode;
            }
            last.next = newNode;
            last = newNode;
            length++;   
        }
        public Node dequeue()
        {
            if (length == 0) { return null; }
            Node temp = fisrt;
            if (length ==1)
            {
                fisrt = null;
                last = null;    
            }

            else
            {
                fisrt = fisrt.next;
                temp.next = null;
            }
            length--;
            return temp;

        }
    }
}