﻿using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double A, B, media;
        A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        media = ((A * 3.5) + (B * 7.5)) / 11;
        Console.WriteLine("MEDIA = " + media.ToString("f5", CultureInfo.InvariantCulture));
        Console.ReadLine();
    }
}