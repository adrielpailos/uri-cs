using System;

class Program
{
    static void Main(string[] args)
    {
        int a, b, c, maiorAb, maior;

        string[] val = Console.ReadLine().Split(' ');
        a = int.Parse(val[0]);
        b = int.Parse(val[1]);
        c = int.Parse(val[2]);

        maiorAb = (a + b + Math.Abs(a - b)) / 2;
        maior = (maiorAb + c + Math.Abs(maiorAb - c)) / 2;

        Console.WriteLine(maior + " eh o maior");
    }
}