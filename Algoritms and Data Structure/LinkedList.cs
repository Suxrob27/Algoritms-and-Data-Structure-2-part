using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms_and_Data_Structure
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
    public class LinkedList
    {
        private Node head;
        private Node tail;
        private int length;

        public LinkedList(int value)
        {
            Node newNode = new Node(value);
            head = newNode;
            tail = newNode;
            length = 1;
        }

        public void printList()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.value);
                temp = temp.next;
            }

        }
        public Node getHeadofNode() { return head; }

        public Node getTailofNode() { return tail; }

        public int getLength() { return length; }


        public Node Append(Node newNode)
        {
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
            length++;
            return newNode;
        }
        public bool removeLast()
        {
            if(length == 0)
            {
                return false;
            }
            Node temp = head;
            Node pre = head;
            while (temp.next != null) 
            {
              pre = temp;  
              temp = temp.next; 
            }
            tail = pre;
            tail.next = null;
            length--;
            if (length == 0)
            {
                head = null;    
                tail = null;    
            }
            return true;
        }
        public Node Prepend(Node newNode)
        {
            if (length == 0)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;    
                head = newNode;
                length++;
            }
            return newNode; 
        }
        public bool RemoveFirst()
        {
            if (length == 0)
            {
                return false;   
            }
            else
            {
                Node temp = head;
                head = head.next;
                temp.next = null;
                length--;
            }
            if (length == 0)
            {
                tail = null;
            }
            return true; 
        }
        public Node get(int index)
        {
            Node temp = head;   
            if (index < 0 || index>= length)
            {
                return null;
            }

            for (int i = 0; i < index; i++)
            {
                temp = temp.next;   
            }
            return temp;
          }
        public bool set(int index, int value)
        {
            Node temp = get(index);
            if (temp != null)
            {
                temp.value = value;
                return true;
            }
            return false;

        }
        public bool insert(int index, int value)
        {
            if (index < 0 || index > length) return false;
            if (index == 0)
            {
                Prepend(new Node(value));
                return true;    
            }
            if (index == length)
            {
                Append(new Node(value));
                return true;    
            }
            Node newNode = new Node(value);
            Node temp = get(index - 1);
            newNode.next = temp.next;
            temp.next = newNode;
            length++;
            return true;
        }

        public bool Remove(int index) 
        {
            if (index < 0 || index >= length) { return false; }
            if (index == 0) { return RemoveFirst(); }

            if (index == length -1)
            {
                return removeLast();
            }
            Node temp = get(index - 1);
            temp.next = null;
            length--;
            return true;    
        }
        public void Reverse()
        {
            Node temp = head;
            head = tail;
            tail = temp;
            Node after = temp.next;
            Node before = null;
            for (int i = 0; i < length; i++)
            {
                after = temp.next;
                temp.next = before;
                before = temp;
                temp = after;
            }
        }

    }

}
