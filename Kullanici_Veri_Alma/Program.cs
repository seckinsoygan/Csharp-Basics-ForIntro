using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String x, y;

            Console.Write("X degerini giriniz: ");

            x = Console.ReadLine();

            Console.Write("y değerini giriniz: ");

            y = Console.ReadLine();

            Console.WriteLine($"Hoşgeldiniz {x} ve {y}");

            Console.Read();

            int sayi1 = 3;
            int sayi2 = 6;

            int toplam = sayi1 + sayi2;

            Console.Write(toplam);
            Console.Read();
        }
    }
}