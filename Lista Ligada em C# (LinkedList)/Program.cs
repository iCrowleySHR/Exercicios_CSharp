using System;
using System.Collections.Generic;
 
class Program
{
    static void Main()
    {
        // Habilita a acentuação no console (UTF-8)
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        // Criação da lista ligada de inteiros
        LinkedList<int> lista = new LinkedList<int>();
 
        Console.WriteLine("=== Lista Ligada em C# ===\n");
 
        // Adicionando elementos no final
        lista.AddLast(10);
        lista.AddLast(20);
        lista.AddLast(30);
        Console.WriteLine("Lista após adicionar elementos no final:");
        ImprimirLista(lista);
 
        // Adicionando elementos no início
        lista.AddFirst(5);
        lista.AddFirst(1);
        Console.WriteLine("\nLista após adicionar elementos no início:");
        ImprimirLista(lista);
 
        // Removendo elementos
        lista.Remove(20); // Remove o valor 20
        Console.WriteLine("\nLista após remover o elemento 20:");
        ImprimirLista(lista);
 
        // Remover o primeiro e o último elementos
        lista.RemoveFirst();
        lista.RemoveLast();
        Console.WriteLine("\nLista após remover o primeiro e o último elementos:");
        ImprimirLista(lista);
 
        // Verificando se um valor está na lista
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
 
    // Método para imprimir os elementos da lista ligada
    static void ImprimirLista(LinkedList<int> lista)
    {
        foreach (int item in lista)
        {
            Console.Write(item + " -> ");
        }
        Console.WriteLine("null");
    }
}