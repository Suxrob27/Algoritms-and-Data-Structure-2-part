using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMap
{
    public class HashMap
    {
        private int size = 10;
        private Node[] dataMap;
        class Node
        {
            public string key { get; set; }
            public int value { get; set; }
            public Node next { get; set; }

            public Node(string key, int value)
            {
                this.key = key;
                this.value = value;
            }
        };
        public HashMap()
        {
            dataMap = new Node[size];
        }

        public void printTable()
        {
            for (int i = 0; i < dataMap.Length; i++)
            {
                Console.WriteLine(i + ":");
                Node temp = dataMap[i];
                while (temp != null)
                {
                    Console.WriteLine(temp.key + "=" + temp.value);
                }
            }
        }
        private int hash(string key)
        {
            int hash = 0;
            char[] keyChars = key.ToCharArray();
            for (int i = 0; i < keyChars.Length; i++)
            {
                int asciiValue = keyChars[i];
                hash = (hash + asciiValue * 23) % dataMap.Length;
            }
            return hash;
        }
        public void set(string key, int value)
        {
            int index = hash(key);
            Node newNode = new Node(key, value);
            if (dataMap[index] == null)
            {
                dataMap[index] = newNode;
            }
            else
            {
                Node temp = dataMap[index];
                while (temp != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }
        public int Get(string key)
        {
            int index = hash(key);
            Node temp = dataMap[index];
            if (temp != null)
            {
                if (temp.key == key)
                {
                    return temp.value;
                }
                temp = temp.next;
            }
            return 0;
        }


        public ArrayList key()
        {
            ArrayList result = new ArrayList();
            for (int i = 0; i < dataMap.Length; i++)
            {
                Node temp = dataMap[i];
                while (temp != null) 
                {
                 result.Add(temp.key);  
                temp = temp.next;   
                }
            }
            return result;
        }
    }
}
