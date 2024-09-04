using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Program
    {
        static void Main(string[] args)
        {
            Grpah2 grpah2 = new Grpah2(5);
            grpah2.insertEdge(1,1,8);
   
            grpah2.edgeCount();
            
        }
    }
}
