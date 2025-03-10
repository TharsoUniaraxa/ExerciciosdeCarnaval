double valorHora;
int horasTrabalhadas;
double salarioBase;
double horasExtras;
double salarioTotal;

Console.WriteLine("Digite o valor recebido por hora: ");
valorHora = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de horas trabalhadas no mês: ");
horasTrabalhadas = int.Parse(Console.ReadLine());

salarioBase = valorHora * 160;

if (horasTrabalhadas <= 160)
{
    salarioTotal = valorHora * horasTrabalhadas;
}
else
{
    horasExtras = horasTrabalhadas - 160;
    salarioTotal = salarioBase + (horasExtras * (valorHora * 1.5));
}

Console.WriteLine("O salário total do mês é: R$ " + salarioTotal.ToString("F2"));
