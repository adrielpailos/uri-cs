using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int codigo1, nDePecas1, codigo2, nDePecas2 ;
        double valorUnitario1, valorUnitario2, valorFinal;

        string[] total = Console.ReadLine().Split(' ');
        codigo1 = int.Parse(total[0]);
        nDePecas1 = int.Parse(total[1]);
        valorUnitario1 = double.Parse(total[2], CultureInfo.InvariantCulture);

        total = Console.ReadLine().Split(' ');
        codigo2 = int.Parse(total[0]);
        nDePecas2 = int.Parse(total[1]);
        valorUnitario2 = double.Parse(total[2], CultureInfo.InvariantCulture);
        valorFinal = nDePecas2 * valorUnitario1 + nDePecas2 * valorUnitario2;

        Console.WriteLine("VALOR A PAGAR: R$ " + valorFinal.ToString("f2", CultureInfo.InvariantCulture));
    }
}