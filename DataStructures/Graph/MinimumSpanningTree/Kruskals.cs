using DataStructures.Set;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Graph.MinimumSpanningTree
{
    public class Kruskals<T,TW> where T : IComparable where TW : IComparable
    {
        public List<MSTEdge<T, TW>> FindMinimumSpanningTree(IGraph<T> graph)
        {
            // 1. kenar listesi (dfs)
            var edges = new List<MSTEdge<T, TW>>();
            dfs(graph.ReferenceVertex,
                new HashSet<T>(), 
                new Dictionary<T, HashSet<T>>(), 
                edges);

            // 2.Kenar sıralama
            var heap = new Heap.BinaryHeap<MSTEdge<T, TW>>(Shared.SortDirection.Asceding);
            foreach (var edge in edges)
            {
                heap.Add(edge);
            }

            var SortedEdgeArr = new MSTEdge<T, TW>[edges.Count];
            for (int i = 0; i < edges.Count; i++)
            {
                SortedEdgeArr[i] = heap.DeleteMinMax();
            }

            //3. MakeSet - FindeSet- Union

            var disjointSet = new DisjointSet<T>();
            foreach (var vertex in graph.VerticesAsEnumerable)
            {
                disjointSet.MakeSet(vertex.Key);
            }

            var resultEdgeList = new List<MSTEdge<T, TW>>();
            for (int i = 0; i < edges.Count; i++)
            {
                var currentEdge = SortedEdgeArr[i];
                var setA = disjointSet.FindSet(currentEdge.Source);
                var setB = disjointSet.FindSet(currentEdge.Destination);

                if (setA.Equals(setB))
                {
                    continue;
                }
                resultEdgeList.Add(currentEdge);
                disjointSet.Union(setA, setB);
            }

            return resultEdgeList;
        }

        private void dfs(IGraphVertex<T> currentVertex, HashSet<T> visitedVertices, Dictionary<T, HashSet<T>> visitedEdges, List<MSTEdge<T, TW>> edges)
        {
            if (!visitedEdges.ContainsKey(currentVertex.Key))
            {
                visitedVertices.Add(currentVertex.Key);
                foreach (var edge in currentVertex.Edges)
                {
                    if (!visitedEdges.ContainsKey(currentVertex.Key) || !visitedEdges[currentVertex.Key].Contains(edge.TargetVertexKey))
                    {
                        // kenar ekleme
                        edges.Add(new MSTEdge<T, TW>(currentVertex.Key, edge.TargetVertexKey, edge.Weight<TW>()));

                        // kenar güncelleme (visted edges) - source
                        if (!visitedEdges.ContainsKey(currentVertex.Key))
                        {
                            visitedEdges.Add(currentVertex.Key, new HashSet<T>());
                        }

                        visitedEdges[currentVertex.Key].Add(edge.TargetVertexKey);


                        // kenar güncelleme (visted edges) - desttination
                        if (!visitedEdges.ContainsKey(edge.TargetVertexKey))
                        {
                            visitedEdges.Add(edge.TargetVertexKey, new HashSet<T>());
                        }

                        visitedEdges[edge.TargetVertexKey].Add(currentVertex.Key);

                        dfs(edge.TargetVertex, visitedVertices, visitedEdges, edges);
                    }
                }
            }
        }
    }
}
