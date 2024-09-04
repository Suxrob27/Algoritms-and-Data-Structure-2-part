using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Grpah2 
    {
        public int verticesl { get; set; }
        public int[,] adjMat { get; set; }

        public Grpah2(int n)
        {
                verticesl = n;  
              adjMat = new int[n,n];    
        }
        public void insertEdge(int u, int v, int x)
        {
            adjMat[u, v] = x;   
        }

        public void removeEdge(int u, int v)
        {
            adjMat[u, v] = 0;
        }

        public int vertexCount()
        {
            return verticesl;
        }
        public int edgeCount()
        {
            int count = 0;
            for (int i = 0; i < verticesl; i++)
            {
                for (int j = 0; j < verticesl; j++)
                {
                    if (adjMat[i, j] != 0)
                    {
                        count = count++;
                    }
                }
            }
            Console.WriteLine(count);
            return count;

        }
        public bool exsistEdge(int u, int v)
        {
            return adjMat[u, v] != 0;   
        }

        public int vertexcount()
        {
            return verticesl;
        }

        public void display()
        {
            for (int i = 0; i < verticesl; i++)
            {
                for (int j = 0; j < verticesl; j++)
                    Console.Write(adjMat[i, j] + "\t");
                Console.WriteLine();
            }
        }

        public void edges()
        {
            Console.WriteLine("Edges:");
            for (int i = 0; i < verticesl; i++)
            {
                for (int j = 0; j < verticesl; j++)
                {
                    if (adjMat[i,j] != 0)
                    {
                        Console.WriteLine(i + "--" + j);
                    }
                }
            }
        }

        public int outdegree(int v)
        {
            int count = 0;
            for (int i = 0; i < verticesl; i++)
            {
                if (adjMat[v,i] != 0)
                {
                    count++;
                }
            }
            return count;   
        }
        public int indegree(int v)
        {
            int count = 0;
            for (int i = 0; i < verticesl; i++)
            {
                if (adjMat[i, v] != 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
