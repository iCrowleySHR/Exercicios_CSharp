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

        lista.AddFirst(10);
        lista.AddFirst(17);
        
        lista.AddLast(20);
        lista.AddLast(30);
        
        lista.AddFirst(21);
        lista.AddFirst(7);
        
        Console.WriteLine("Lista atualmente adicionar elementos no final:");
        ImprimirLista(lista);

        lista.RemoveFirst();
        lista.RemoveFirst();
        lista.RemoveLast();
        lista.RemoveFirst();
        lista.RemoveFirst();
        lista.RemoveFirst();

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