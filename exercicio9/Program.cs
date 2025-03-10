using System;
using System.Linq;

class Program
{
    static void Main()
    {
        const int NUM_JUIZES = 6;
        double[] notas = new double[NUM_JUIZES];

        for (int i = 0; i < NUM_JUIZES; i++)
        {
            Console.Write($"Digite a nota do juiz {i + 1} (0 a 10): ");
            while (!double.TryParse(Console.ReadLine(), out notas[i]) || notas[i] < 0 || notas[i] > 10)
            {
                Console.Write("Nota inválida! Digite um valor entre 0 e 10: ");
            }
        }

        Array.Sort(notas);

        double notaFinal = notas.Skip(1).Take(NUM_JUIZES - 2).Sum();

        Console.WriteLine($"A nota final do atleta é: {notaFinal:F2}");
    }
}
