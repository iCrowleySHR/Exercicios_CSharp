using System;
using System.Collections.Generic;

class Restaurante
{
    public string nome { get; set; }
    public string prato { get; set; }
    public float preco { get; set; }

    public Restaurante(string nomeEnviado, string pratoEnviado, float precoEnviado)
    {
        nome = nomeEnviado;
        prato = pratoEnviado;
        preco = precoEnviado;
    }

    public override string ToString()
    {
        return $"Nome: {nome}, Prato: {prato}, Preço: {preco}";
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        LinkedList<Restaurante> filaDePedidos = new LinkedList<Restaurante>();

        // Adicionando passageiros à fila (ordem de chegada)
        filaDePedidos.AddLast(new Restaurante("Ricardo", "Filé de frango à parmegiana", 27.80f));
        filaDePedidos.AddLast(new Restaurante("Laura", "Filé de frango à parmegiana", 27.80f));
        filaDePedidos.AddLast(new Restaurante("Clóvis", "Bifé acebolado", 17.80f));
        filaDePedidos.AddLast(new Restaurante("Valéria", "Arroz com fritas e salada", 15.80f));
        filaDePedidos.AddLast(new Restaurante("Paulo", "Lasanha de molho branco", 15.80f));

        Console.WriteLine("Passageiros na ordem de chegada:");
        Show(filaDePedidos);

        // Remover um passageiro específico
        Console.WriteLine("\nRemovendo o pedido de: Paulo");
        Remove(filaDePedidos, "Paulo");

        Console.WriteLine("\nPassageiros após remoção:");
        Show(filaDePedidos);

        // Adicionando um novo passageiro no início
        Console.WriteLine("\nAdicionando passageiro prioritário: Renata");
        filaDePedidos.AddFirst(new Restaurante("Renata Gonçalves", "Filé de carne à parmegina", 30.25f));

        Console.WriteLine("\nFila atualizada:");
        Show(filaDePedidos);

        Console.WriteLine("Limpando toda a fila");
        filaDePedidos.Clear();

    }

    static void Show(LinkedList<Restaurante> fila)
    {
        foreach (var passageiro in fila)
        {
            Console.WriteLine(passageiro);
        }
    }

    static void Remove(LinkedList<Restaurante> fila, string nome)
    {
        var noAtual = fila.First;

        while (noAtual != null)
        {
            if (noAtual.Value.nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
            {
                fila.Remove(noAtual);
                break;
            }
            noAtual = noAtual.Next;
        }
    }

}