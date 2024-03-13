using System.Diagnostics;
using arvore_binaria;

public class Program
{
    public static void Main()
    {
        BinaryTree tree = new BinaryTree();

        tree.Insert(50);
        tree.Insert(30);
        tree.Insert(20);
        tree.Insert(40);
        tree.Insert(70);
        tree.Insert(60);
        tree.Insert(80);

        Console.WriteLine("Árvore binária após a inserção: ");
        tree.InOrderTraversal(tree.root);
        Console.WriteLine();

        Stopwatch stopwatch = Stopwatch.StartNew();
        int key = 150;
        Node? result = tree.Search(tree.root, key);
        stopwatch.Stop();

        if (result == null)
        {
            Console.WriteLine($"{key} não encontrado na árvore");
            Console.WriteLine($"Tempo de execução: {stopwatch.ElapsedMilliseconds} ms");
            return;
        }

        Console.WriteLine($"{key} encontrado na árvore");
        Console.WriteLine($"Tempo de execução: {stopwatch.ElapsedMilliseconds} ms");
        return;
    }
}