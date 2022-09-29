// See https://aka.ms/new-console-template for more information

int toplam = 0;
for(int i = 0; i < 5; i++)
{
    Console.Write($" {i}. Sayiyi giriniz: ");
    int sayi=Convert.ToInt32(Console.ReadLine());

    toplam += sayi; 
}
Console.WriteLine($"Toplam = {toplam}");
Console.Read();
