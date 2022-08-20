using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int funcionario, horasTrabalhadas;
        double valorPorHora, salario;

        funcionario = int.Parse(Console.ReadLine());
        horasTrabalhadas = int.Parse(Console.ReadLine());
        valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        salario = horasTrabalhadas * valorPorHora;

        Console.WriteLine("NUMBER = " + funcionario);
        Console.WriteLine("SALARY = U$ " + salario.ToString("f2", CultureInfo.InvariantCulture));
    }
}