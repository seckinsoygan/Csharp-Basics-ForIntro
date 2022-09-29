int i;
int fakt = 1;

Console.Write("Faktöriyeli hesaplanacak sayiyi giriniz: ");
int sayi =Convert.ToInt32(Console.ReadLine());

for(i=1; i <= sayi; i++)
{
    fakt *= i;
}
Console.WriteLine($"Sonuc = {fakt}");
Console.Read();