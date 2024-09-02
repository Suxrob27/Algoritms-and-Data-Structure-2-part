using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms_and_Data_Structure
{
    public  class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList(5);
            linkedList.Append(new Node(4));
            linkedList.Append(new Node(3));
            linkedList.Append(new Node(6));
            linkedList.removeLast();
            linkedList.removeLast();
            linkedList.removeLast();

            linkedList.printList();
        }
    }
}
