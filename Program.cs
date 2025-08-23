using System.Collections.Generic;

class Program
{
    // Inversão de pilha usando 1 fila auxiliar
    static void InverterPilha<T>(Stack<T> pilha)
    {
        Queue<T> fila = new Queue<T>();

        // Desimpilhar e Enfileirar
        while (pilha.Count > 0)
        {
            fila.Enqueue(pilha.Pop());
        }

        // Desinfileirar e Empilhar
        while (fila.Count > 0)
        {
            pilha.Push(fila.Dequeue());
        }

    }

    // Imprimir a pilha do topo para a base
    static void Imprimir<T>(Stack<T> pilha)
    {
        foreach (var item in pilha)
        {
            Console.WriteLine($"{item}");
        }
    }

    static void Main()
    {
        // Declara a pilha com os elementos
        Stack<string> pilha = new Stack<string>(new[] { "D", "C", "B", "A" });

        // Imrpime a pilha
        Console.WriteLine("Pilha original:");
        Imprimir(pilha);

        // Inverte a pilha utilizando o metodo da classe
        InverterPilha(pilha);

        // Imprime a pilha invertida
        Console.WriteLine("\nPilha invertida");
        Imprimir(pilha);

    }
}