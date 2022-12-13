using CustomTypes;
using DataStructures.Graph.AdjancncySet;
using DataStructures.Heap;
using DataStructures.Set;
using DataStructures.Stack;
using DataStructures.Tree.BinaryTree;
using DataStructures.Tree.BST;
using System;

namespace Apps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new Student[] 
            {
                new Student(14,"Mehmet",2.40),
                new Student(10,"Ahmet",3.40),
                new Student(85,"Filiz",2.90),
                new Student(54,"Hakan",1.90),
                new Student(18,"Selvi",2.50),
                new Student(27,"Mert",2.80)
            };
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }



            //var graph = new Graph<int>();

            //for (int i = 0; i < 12; i++)
            //{
            //    graph.AddVertex(i);
            //}

            //graph.AddEdge(1, 0);
            //graph.AddEdge(1, 4);
            //graph.AddEdge(0, 4);
            //graph.AddEdge(0, 2);
            //graph.AddEdge(2, 5);
            //graph.AddEdge(2, 10);
            //graph.AddEdge(10, 11);
            //graph.AddEdge(11, 9);
            //graph.AddEdge(2, 9);
            //graph.AddEdge(5, 7);
            //graph.AddEdge(8, 7);
            //graph.AddEdge(5, 8);
            //graph.AddEdge(5, 6);

            //var algoritm = new DataStructures.Graph.Search.BreadthFirst<int>();

            //var has = algoritm.Find(graph, 23);

            //Console.WriteLine("{0}", has ? "Yes" : "No");

            //var graph = new WeightedDiGraph<char, int>(new char[] { 'A', 'B', 'C', 'D', 'E' });
            //graph.AddEdge('A', 'C', 12);
            //graph.AddEdge('A', 'D', 60);
            //graph.AddEdge('B', 'A', 10);
            //graph.AddEdge('C', 'B', 20);
            //graph.AddEdge('C', 'D', 32);
            //graph.AddEdge('E', 'A', 37);

            //foreach (var vertexKey in graph)
            //{
            //    Console.WriteLine(vertexKey);
            //    foreach (char key in graph.GetVertex(vertexKey))
            //    {
            //        var nodeU = graph.GetVertex(vertexKey);
            //        var nodeV = graph.GetVertex(key);
            //        var w = nodeU.GetEdge(nodeV).Weight<int>();
            //        Console.WriteLine("\t" + key+" "+ nodeU.GetEdge(nodeV).Weight<int>());
            //    }
            //}

            //var diGraph = new DiGraph<char>(new char[] { 'A', 'B', 'C', 'D', 'E' });
            //diGraph.AddEdge('B', 'A');
            //diGraph.AddEdge('A', 'D');
            //diGraph.AddEdge('D', 'E');
            //diGraph.AddEdge('C', 'D');
            //diGraph.AddEdge('C', 'E');
            //diGraph.AddEdge('C', 'A');
            //diGraph.AddEdge('C', 'B');
            //diGraph.RemoveVertex('C');

            //foreach (var vertex in diGraph)
            //{
            //    Console.WriteLine(vertex);
            //    foreach (char key in diGraph.GetVertex(vertex))
            //    {
            //        Console.WriteLine("\t" + key);
            //    }
            //}

            //var graph = new WeightedGraph<char, double>(new char[] { 'A', 'B', 'C', 'D' });

            //graph.AddEdge('A', 'B', 1.2);
            //graph.AddEdge('A', 'D', 2.3);
            //graph.AddEdge('D', 'C', 5.5);
            //foreach (char vertex in graph)
            //{
            //    Console.WriteLine(vertex);
            //    foreach (char key in graph.GetVertex(vertex))
            //    {
            //        var node = graph.GetVertex(key);
            //        Console.WriteLine("\t" + key + " " + node.GetEdge(graph.GetVertex(vertex)).Weight<double>());
            //    }
            //}

            //var graph = new Graph<char>(new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G' });
            //graph.AddEdge('A', 'B');
            //graph.AddEdge('A', 'D');
            //graph.AddEdge('C', 'D');
            //graph.AddEdge('C', 'E');
            //graph.AddEdge('D', 'E');
            //graph.AddEdge('E', 'F');
            //graph.AddEdge('F', 'G');
            //foreach (var vertex in graph)
            //{
            //    Console.WriteLine(vertex);
            //}
            //Console.WriteLine($"Number of graph : {graph.Count}");


            //var disjointSet = new DisjointSet<int>(new int[] { 0, 1, 2, 3, 4, 5, 6 });
            //disjointSet.Union(5, 6);
            //disjointSet.Union(1, 2);
            //disjointSet.Union(0, 2);
            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine($"Find({i}) = {disjointSet.FindSet(i)}");
            //}
            //Console.Read();

            // var heap = new BinaryHeap<int>(DataStructures.Shared.SortDirection.Desceding, new int[] { 54, 45, 36, 27, 29, 18, 21, 99 });
            //// heap.DeleteMinMax();
            // foreach (var item in heap)
            //     Console.Write(item+" ");


            //var bst = new BST<int>(new int[] { 23, 16, 45, 3, 22, 37, 99 });

            //foreach (var item in bst)
            //{
            //    Console.Write(item + " ");
            //}

            //bst.Remove(bst.Root, 22);
            //new BinaryTree<int>().PrintPaths(bst.Root);
            //Console.WriteLine(BinaryTree<int>.MaxDepth(bst.Root));
            //Console.WriteLine(BinaryTree<int>.NumberOfLeafs(bst.Root));
            //Console.WriteLine(BinaryTree<int>.NumberOfFullNodes(bst.Root));
            //Console.WriteLine(BinaryTree<int>.NumberOfHalfNodes(bst.Root));


            //var arr = new int[] { 60, 40, 70, 20, 45, 65, 85 };
            //var BST = new BST<int>(arr);
            //var bt = new BinaryTree<int>(); 
            //bt.InOrder(BST.Root).ForEach(node => Console.Write(node + " "));
            //bt.ClearList();
            //Console.WriteLine();
            //BST.Remove(BST.Root, 20);
            //BST.Remove(BST.Root, 40);
            //BST.Remove(BST.Root, 60);
            //bt.InOrder(BST.Root).ForEach(node => Console.Write(node + " "));

            //bt.InOrder(BST.Root).ForEach(node => Console.Write($"{node, -3} "));
            //Console.WriteLine();
            //bt.InOrderNonRecursiveTraversal(BST.Root).ForEach(node => Console.Write($"{node, -3} "));
            //Console.WriteLine();
            //Console.WriteLine();
            //bt.ClearList();
            //bt.PreOrder(BST.Root).ForEach(node => Console.Write($"{node,-3} "));
            //Console.WriteLine();
            //bt.PreOrderNonRecursiveTraversal(BST.Root).ForEach(node => Console.Write($"{node,-3} "));
            //Console.WriteLine();
            //Console.WriteLine();
            //bt.ClearList();
            //bt.PostOrder(BST.Root).ForEach(node => Console.Write($"{node,-3} "));
            //Console.WriteLine();
            //bt.PostOrderNonRecursiveTraversal(BST.Root).ForEach(node => Console.Write($"{node,-3} "));
            //Console.WriteLine();
            //Console.WriteLine();
            //bt.LevelOrderNonRecursiveTraversal(BST.Root).ForEach(node => Console.Write($"{node,-3} "));

            //Console.WriteLine();
            //Console.WriteLine(BST.FindMin(BST.Root));
            //Console.WriteLine(BST.FindMax(BST.Root));
            //BST.Find(BST.Root, 16);

            //var charset = new char[] { 'a', 'b', 'c', 'd', 'e' };
            //var stack1 = new Stack<char>();
            //var stack2 = new Stack<char>(StackType.LinkedList);

            //foreach (var item in charset)
            //{
            //    Console.WriteLine(item);
            //    stack1.Push(item);
            //    stack2.Push(item);
            //}
            //Console.WriteLine("Peek");
            //Console.WriteLine($"{stack1.Count}");
            //Console.WriteLine($"{stack2.Count}");

            //var stack = new Stack<int>();
            //stack.Pop();
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}


            //var list = new DoublyLinkedList<int>();
            //list.Addfirst(12);
            //list.Addfirst(23);

            //list.AddLast(44);
            //list.AddLast(55);

            //list.AddAfter(list.Head.Next, new DoublyLinkedListNode<int>(13));
            //list.AddBefore(list.Head.Next, new DoublyLinkedListNode<int>(11));

            //foreach (var item in list)
            //{            //    Console.WriteLine(item);
            //}

            //var arr = new int[] { 1, 2, 3 };

            //var list = new SinglyLinkedList<int>(arr);
            //list.AddAfter(list.Head, new SinglyLinkedListNode<int>(4));

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadKey();
            
        }
    }
}
