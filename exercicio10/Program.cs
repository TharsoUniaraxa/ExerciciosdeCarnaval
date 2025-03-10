using System;

class Program
{
    static void Main()
    {
        const int N = 4;
        double[,] A = new double[N, N];

        Console.WriteLine("Digite os valores da matriz 4x4:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write($"A[{i},{j}]: ");
                A[i, j] = double.Parse(Console.ReadLine());
            }
        }

        double somaA = 0;
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                somaA += A[i, j];
            }
        }

        double somaB = 0;
        for (int i = 2; i < 4; i++)
        {
            for (int j = 2; j < 4; j++)
            {
                somaB += A[i, j];
            }
        }

        double somaC = 0;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (i > j)
                {
                    somaC += A[i, j];
                }
            }
        }

        double somaD = 0;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (i < j) 
                {
                    somaD += A[i, j];
                }
            }
        }

        Console.WriteLine($"\nSoma (a) - canto sup. esquerdo 2x2: {somaA}");
        Console.WriteLine($"Soma (b) - canto inf. direito 2x2: {somaB}");
        Console.WriteLine($"Soma (c) - abaixo da diagonal principal: {somaC}");
        Console.WriteLine($"Soma (d) - acima da diagonal principal: {somaD}");
    }
}
