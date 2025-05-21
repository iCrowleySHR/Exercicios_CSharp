using System; // Importa o namespace básico do .NET
using System.Collections.Generic; // Importa as coleções genéricas, incluindo LinkedList

class Program
{
    static void Main()
    {
        // Configura o console para usar codificação UTF-8
        // Isso permite que caracteres especiais (como acentos) sejam exibidos corretamente
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        // Criação de uma lista ligada (LinkedList) de inteiros
        LinkedList<int> lista = new LinkedList<int>();

        Console.WriteLine("=== Lista Ligada em C# ===\n");

        // Adiciona elementos no início da lista (AddFirst insere no começo)
        lista.AddFirst(10);  // Lista: 10
        lista.AddFirst(17);  // Lista: 17 -> 10

        // Adiciona elementos no final da lista (AddLast insere no final)
        lista.AddLast(20);   // Lista: 17 -> 10 -> 20
        lista.AddLast(30);   // Lista: 17 -> 10 -> 20 -> 30

        // Mais elementos adicionados no início
        lista.AddFirst(21);  // Lista: 21 -> 17 -> 10 -> 20 -> 30
        lista.AddFirst(7);   // Lista: 7 -> 21 -> 17 -> 10 -> 20 -> 30

        Console.WriteLine("Lista atualmente após adicionar elementos:");
        ImprimirLista(lista); // Imprime o estado atual da lista

        // Remove elementos do início e do final da lista
        lista.RemoveFirst(); // Remove 7
        lista.RemoveFirst(); // Remove 21
        lista.RemoveLast();  // Remove 30
        lista.RemoveFirst(); // Remove 17
        lista.RemoveFirst(); // Remove 10
        lista.RemoveFirst(); // Remove 20

        // A lista agora está vazia
        Console.WriteLine("\nLista após remoções:");
        ImprimirLista(lista); // Deve exibir apenas "null"

        // Verifica se um valor específico está presente na lista
        int valorProcurado = 10;
        if (lista.Contains(valorProcurado))
        {
            Console.WriteLine($"\nO valor {valorProcurado} está na lista.");
        }
        else
        {
            Console.WriteLine($"\nO valor {valorProcurado} não está na lista.");
        }
    }

    // Método auxiliar para imprimir os elementos da lista ligada
    static void ImprimirLista(LinkedList<int> lista)
    {
        foreach (int item in lista)
        {
            Console.Write(item + " -> "); // Imprime cada item seguido de uma seta
        }
        Console.WriteLine("null"); // Indica o fim da lista
    }
}
