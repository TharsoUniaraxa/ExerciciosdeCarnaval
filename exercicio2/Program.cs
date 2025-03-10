double h;
char s;
char homem = 'm';
char mulher = 'f';
double peso = 0;

Console.WriteLine("Qual é a altura?");
h = double.Parse(Console.ReadLine());

Console.WriteLine("Sexo (homem ou mulher)");
s = char.Parse(Console.ReadLine());

if (s == homem)
{
    peso = (72.7 * h) - 58;
}

else if (s == mulher)
{
    peso = (62.1 * h) - 44.7;
}

Console.WriteLine($"{peso:F2}");