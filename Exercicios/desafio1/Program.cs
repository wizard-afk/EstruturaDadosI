using System;

class Program
{
    static void Main(string[] args)
    {
        // Criação do vetor com 10 números aleatórios
        int[] vetor = new int[10];
        Random random = new Random();
        for (int i = 0; i < vetor.Length; i++)
            vetor[i] = random.Next(1, 101);

        // Exibição do vetor original
        Console.WriteLine("Vetor original:");
        PrintArray(vetor);

        // Ordenação dos valores do vetor
        Array.Sort(vetor);

        // Exibição do vetor ordenado
        Console.WriteLine("\nVetor ordenado:");
        PrintArray(vetor);
    }

    // Função auxiliar para imprimir um vetor
    static void PrintArray(int[] vetor)
    {
        foreach (int num in vetor)
            Console.Write($"{num} ");
        Console.WriteLine();
    }
}