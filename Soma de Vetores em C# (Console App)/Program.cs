using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int tamanho = 5;
        double[] vetorA = new double[tamanho];
        double[] vetorB = new double[tamanho];
        double[] sum = new double[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            Console.WriteLine($"Digite o valor do Vetor A, na  posicao [{i}]:");
            vetorA[i] = double.Parse(Console.ReadLine()!);
        }

        for (int i = 0; i < tamanho; i++)
        {
            Console.WriteLine($"Digite o valor do Vetor B, na  posicao [{i}]:");
            vetorB[i] = double.Parse(Console.ReadLine()!);
        }

        for (int i = 0; i < tamanho; i++)
        {
            sum[i] = vetorA[i] + vetorB[i];
            Console.WriteLine($"A soma do Vetor A [{i}] e Vetor B [{i}]. [{vetorA[i]}] + [{vetorB[i]}] = [{sum[i]}]");
        }
    }
}