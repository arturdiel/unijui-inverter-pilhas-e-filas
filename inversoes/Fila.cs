public class Fila
{
    // Inversão de fila usando 1 pilha auxiliar
    static void InverterFila<T>(Queue<T> fila)
    {
        Stack<T> pilha = new();

        // Desinfileirar e Empilhar
        while (fila.Count > 0)
        {
            pilha.Push(fila.Dequeue());
        }

        // Desimpilhar e Enfileirar
        while (pilha.Count > 0)
        {
            fila.Enqueue(pilha.Pop());
        }
    }

    public static void Executar()
    {
        // Declara a fila com os elementos
        Queue<string> fila = new(new[] { "A", "B", "C", "D" });

        // Imprime a fila
        Console.WriteLine("\nFila antes da inversão:");
        Console.WriteLine(string.Join(" - ", fila));

        // Inverte a fila utilizando o metodo da classe
        InverterFila(fila);

        // Imprime a fila invertida
        Console.WriteLine("\nFila depois da inversão:");
        Console.WriteLine(string.Join(" - ", fila));
    }
}