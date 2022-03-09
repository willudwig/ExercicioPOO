using System;

namespace Exercicio07.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            SalarioVendedor salario = new();

            salario.TotalVendas = 2300.45;
            salario.PercentualComissao = 15;

            Console.WriteLine($"O salário total do vendedor é: {salario.CalcularSalarioTotal():N2}");
            Console.ReadKey();
        }
    }
}
