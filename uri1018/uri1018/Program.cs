using System;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, menorNuDnotas, nota, resto;

            n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);

            resto = n;

            nota = 100;
            menorNuDnotas = resto / nota;
            Console.WriteLine(menorNuDnotas + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 50;
            menorNuDnotas = resto / nota;
            Console.WriteLine(menorNuDnotas + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 20;
            menorNuDnotas = resto / nota;
            Console.WriteLine(menorNuDnotas + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 10;
            menorNuDnotas = resto / nota;
            Console.WriteLine(menorNuDnotas + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 5;
            menorNuDnotas = resto / nota;
            Console.WriteLine(menorNuDnotas + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 2;
            menorNuDnotas = resto / nota;
            Console.WriteLine(menorNuDnotas + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            Console.WriteLine(resto + " nota(s) de R$ 1,00");
        }
    }
}