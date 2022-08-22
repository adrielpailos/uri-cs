using System;
using System.Globalization;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempoGasto, velocidadeMedia, distancia;
            double litros;

            tempoGasto = int.Parse(Console.ReadLine());
            velocidadeMedia = int.Parse(Console.ReadLine());

            distancia = tempoGasto * velocidadeMedia;
            litros = distancia / 12.0;

            Console.WriteLine(litros.ToString("f3", CultureInfo.InvariantCulture));
        }
    }
}