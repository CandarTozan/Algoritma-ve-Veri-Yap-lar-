using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Graph.Search
{
    public class BreadthFirst<T>
    {
        public bool Find(IGraph<T> graphi, T vertexKey)
        {
            return bfs(graphi.ReferenceVertex, new HashSet<T>(), vertexKey);
        }

        private bool bfs(IGraphVertex<T> referenceVertex,HashSet<T> visited, T searchVertexKey)
        {
            var Q = new Queue<IGraphVertex<T>>();
            Q.Enqueue(referenceVertex);
            visited.Add(referenceVertex.Key);

            while(Q.Count > 0)
            {
                var current = Q.Dequeue();
                if (current.Key.Equals(searchVertexKey))
                    return true;

                foreach (var edge in current.Edges)
                {
                    if (visited.Contains(edge.TargetVertexKey))
                        continue;
                    visited.Add(edge.TargetVertexKey);
                    Q.Enqueue(edge.TargetVertex);

                }
            }
            return false;
        }
    }
}
