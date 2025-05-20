using System;
using System.Collections.Generic;

class Passageiro
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Passageiro(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Idade: {Idade}";
    }
}

class Program
{
    static void Main()
    {
        LinkedList<Passageiro> filaDePassageiros = new LinkedList<Passageiro>();

        // Adicionando passageiros à fila (ordem de chegada)
        filaDePassageiros.AddLast(new Passageiro("Renata", 30));
        filaDePassageiros.AddLast(new Passageiro("Paulo", 19));
        filaDePassageiros.AddLast(new Passageiro("Rodrigo", 19));

        Console.WriteLine("Passageiros na ordem de chegada:");
        ExibirPassageiros(filaDePassageiros);

        // Remover um passageiro específico
        Console.WriteLine("\nRemovendo passageiro: Paulo");
        RemoverPassageiro(filaDePassageiros, "Paulo");

        Console.WriteLine("\nPassageiros após remoção:");
        ExibirPassageiros(filaDePassageiros);

        // Adicionando um novo passageiro no início
        Console.WriteLine("\nAdicionando passageiro prioritário: Renata");
        filaDePassageiros.AddFirst(new Passageiro("Renata", 30));

        Console.WriteLine("\nFila atualizada:");
        ExibirPassageiros(filaDePassageiros);
    }

    static void ExibirPassageiros(LinkedList<Passageiro> fila)
    {
        foreach (var passageiro in fila)
        {
            Console.WriteLine(passageiro);
        }
    }

    static void RemoverPassageiro(LinkedList<Passageiro> fila, string nome)
    {
        var noAtual = fila.First;

        while (noAtual != null)
        {
            if (noAtual.Value.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
            {
                fila.Remove(noAtual);
                break;
            }
            noAtual = noAtual.Next;
        }
    }
}
