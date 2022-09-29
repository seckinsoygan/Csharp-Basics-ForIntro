// See https://aka.ms/new-console-template for more information
Console.WriteLine("karenin kosesi kac cm dir?");

int kose =Convert.ToInt32(Console.ReadLine());

int cevre = kose * 4;
int alan = kose * kose;

Console.WriteLine($"Alan = {alan},cevre = {cevre}");

Console.Read();
