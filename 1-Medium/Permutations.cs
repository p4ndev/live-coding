﻿namespace Medium;

public class Node {
    
    public int          Index   { get; set; } = 0;
    public bool         Visited { get; set; } = false;
    public List<Node>   Child   { get; set; } = new();

    public Node(int index) => Index = index;

}

public class Permutations : IProblem{

    List<int[]> _lst = new();

    public void EntryPoint(){

        var input = new[] { 1, 2 };
        var permutation = new int[input.Length];

        Node[] graph = Create(input);
        DFS(graph, input, permutation, 0);

        Display.Out(_lst.Count + " permutations with [" + String.Join(',', input) + "]\n");
        _lst.ForEach(entry => Display.Out(String.Join(' ', entry)));

    }


    public Node[] Create(int[] arr) {
        
        int n = arr.Length;
        Node[] nodes = new Node[n];

        for (int i = 0; i < n; i++)
            nodes[i] = new Node(i);

        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (!i.Equals(j))
                    nodes[i].Child.Add(nodes[j]);

        return nodes;

    }

    public void DFS(Node[] graph, int[] arr, int[] permutation, int level){

        if (level.Equals(arr.Length)){

            var temp = new int[arr.Length];
            permutation.CopyTo(temp, 0);
            _lst.Add(temp);
            return;

        }

        for (int i = 0; i < graph.Length; i++){
            if (!graph[i].Visited){

                graph[i].Visited = true;
                permutation[level] = arr[graph[i].Index];
                DFS(graph, arr, permutation, level + 1);
                graph[i].Visited = false;

            }
        }

    }


}

