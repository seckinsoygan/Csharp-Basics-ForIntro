// See https://aka.ms/new-console-template for more information


Console.WriteLine("Birinci sayi giriniz: ");
int sayi1 = Convert.ToInt32(Console.ReadLine()); //Readline String okur o yüzden int okuması için Convert yapmamız gerekiyor.

Console.WriteLine("Birinci sayi giriniz: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

int toplam = sayi1 + sayi2;
Console.WriteLine($"Toplam = {toplam}"); 

