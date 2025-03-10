using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] d = new int[20];
        List<int> maioresQueN = new List<int>();
        int n;

        Console.WriteLine("Digite 20 números:");
        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Número {i + 1}: ");
            d[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Digite o valor de N: ");
        n = int.Parse(Console.ReadLine());

        foreach (int numero in d)
        {
            if (numero > n)
            {
                maioresQueN.Add(numero);
            }
        }

        if (maioresQueN.Count > 0)
        {
            Console.WriteLine("\nNúmeros maiores que N:");
            Console.WriteLine(string.Join(", ", maioresQueN));
        }
        else
        {
            Console.WriteLine("\nNenhum número maior que N foi encontrado.");
        }
    }
}
