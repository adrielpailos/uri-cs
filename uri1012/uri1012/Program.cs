using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double A, B, C, pi;
        double aTriangulo, aCirculo, aTrapezio, aQuadrado, aRetangulo;

        pi = 3.14159;

        string[] valores = Console.ReadLine().Split(' ');
        A = double.Parse(valores[0], CultureInfo.InvariantCulture);
        B = double.Parse(valores[1], CultureInfo.InvariantCulture);
        C = double.Parse(valores[2], CultureInfo.InvariantCulture);


        aTriangulo = A * C / 2.0;
        aCirculo = pi * C * C;
        aTrapezio = (A + B) * C / 2;
        aQuadrado = B * B;
        aRetangulo = A * B;


        Console.WriteLine("TRIANGULO: " + aTriangulo.ToString("f3", CultureInfo.InvariantCulture));
        Console.WriteLine("CIRCULO: " + aCirculo.ToString("f3", CultureInfo.InvariantCulture));
        Console.WriteLine("TRAPEZIO: " + aTrapezio.ToString("f3", CultureInfo.InvariantCulture));
        Console.WriteLine("QUADRADO: " + aQuadrado.ToString("f3", CultureInfo.InvariantCulture));
        Console.WriteLine("RETANGULO: " + aRetangulo.ToString("f3", CultureInfo.InvariantCulture));
    }
}