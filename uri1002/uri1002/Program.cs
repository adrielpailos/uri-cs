using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double pi, area, raio;

        pi = 3.14159;
        raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        area = pi * raio * raio;

        Console.WriteLine("A=" + area.ToString("f4", CultureInfo.InvariantCulture));

        Console.ReadLine();
    }
}
