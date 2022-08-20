using System;
using System.Globalization;

class program
{
    static void Main(string[] args)
    {
        int raio;
        double pi, volume;

        raio = int.Parse(Console.ReadLine());
        pi = 3.14159;
        volume = 4.0 / 3.0 * pi * raio * raio * raio;
        Console.WriteLine("VOLUME = " + volume.ToString("f3", CultureInfo.InvariantCulture));
    }
}

