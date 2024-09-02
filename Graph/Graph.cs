using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Graph
    {
        private Dictionary<string, List<string>> graph =new Dictionary<string, List<string>>();
        public bool addVertex(String vertex)
        {
            if (graph[vertex] != null)
            {
                graph.Add(vertex, new List<string>());
                return true;
            }
            return false;
        }
        public bool addedge(String vertex, String vertex2)
        {
            if (graph[vertex] != null && graph[vertex2] != null)
            {
                graph[vertex2].Add(vertex);
                graph[vertex].Add(vertex2);
                return true;
            }
            return false;
        }
        public bool removeEdge(String vertex, String vertex2)
        {
            if (graph[vertex] != null && graph[vertex2] != null)
            {
                graph[vertex2].Remove(vertex);
                graph[vertex].Remove(vertex2);
                return true;
            }
            return false;
        }

        public bool removeVertext(string vertex)
        {
            if (graph[vertex] == null) { return true;}
            foreach (var neighbor in graph[vertex])
            {
                graph[neighbor].Remove(vertex);
            }
            graph.Remove(vertex);
            return true;
        }

        public void BFS(string stratVertex)
        {
            if(!graph.ContainsKey(stratVertex))
            {
                Console.WriteLine("Start vertex not found");
                return;
            }
            HashSet<string> visited = new HashSet<string>();    
            Queue<string> queue = new Queue<string>();  
            visited.Add(stratVertex);
            queue.Enqueue(stratVertex); 
            while(queue.Count > 0)
            {
                string currentVertex = queue.Dequeue();
                Console.WriteLine(currentVertex + " ");
                foreach (var neighbor in graph[currentVertex]) 
                {
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        queue.Enqueue(neighbor);    
                    }
                }
            }
        }
    }
}
