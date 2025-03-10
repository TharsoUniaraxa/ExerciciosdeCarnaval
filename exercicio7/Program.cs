using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> gabarito = new HashSet<int>();
        int[] aposta = new int[10];
        int acertos = 0;

        Console.WriteLine("Digite os 5 números do gabarito:");
        while (gabarito.Count < 5)
        {
            Console.Write("Número: ");
            int numero = int.Parse(Console.ReadLine());

            if (gabarito.Contains(numero))
            {
                Console.WriteLine("Número já inserido! Digite outro.");
            }
            else
            {
                gabarito.Add(numero);
            }
        }

        Console.WriteLine("Digite os 10 números da aposta:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Número: ");
            aposta[i] = int.Parse(Console.ReadLine());
        }

        foreach (int numero in aposta)
        {
            if (gabarito.Contains(numero))
            {
                acertos++;
            }
        }

        Console.WriteLine($"Você acertou {acertos} números!");
    }
}
