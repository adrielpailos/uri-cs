using System;
using System.Globalization;

class UProgram
{
    static void Main(string[] args)
    {
        string nome;
        double salarioFixo, totalDeVendas, comicaoDeVendas;

        nome = Console.ReadLine();
        salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        totalDeVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        comicaoDeVendas = totalDeVendas * 15 / 100 + salarioFixo;

        Console.WriteLine("TOTAL = R$ " + comicaoDeVendas.ToString("f2", CultureInfo.InvariantCulture));
    }
}