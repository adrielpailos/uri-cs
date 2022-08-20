using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int x;
        double y, kmPorLitro;

        x = int.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        kmPorLitro = x / y;

        Console.WriteLine(kmPorLitro.ToString("f3", CultureInfo.InvariantCulture) + " km/l");
    }
}