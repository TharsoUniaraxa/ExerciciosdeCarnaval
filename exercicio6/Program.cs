using System;

class Program
{
    static void Main()
    {
        double S = 0;
        int numerador = 1;

        for (int denominador = 1; denominador <= 50; denominador++)
        {
            S += (double)numerador / denominador;
            numerador += 2;
        }

        Console.WriteLine("O valor de S é: " + S);
    }
}
