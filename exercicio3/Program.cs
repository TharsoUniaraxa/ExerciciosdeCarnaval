int diaEscolhido;

Console.WriteLine("Digite um número de 1 a 7:");
diaEscolhido = int.Parse(Console.ReadLine());

switch (diaEscolhido)
{
    case 1:
        Console.WriteLine("Domingo - dia de descanso!");
        break;
    case 2:
        Console.WriteLine("Segunda-feira - início da semana!");
        break;
    case 3:
        Console.WriteLine("Terça-feira - vamos em frente!");
        break;
    case 4:
        Console.WriteLine("Quarta-feira - metade da semana!");
        break;
    case 5:
        Console.WriteLine("Quinta-feira - quase lá!");
        break;
    case 6:
        Console.WriteLine("Sexta-feira - fim de semana chegando!");
        break;
    case 7:
        Console.WriteLine("Sábado - dia de curtir!");
        break;
    default:
        Console.WriteLine("Número inválido! Digite um valor entre 1 e 7.");
        break;
}
