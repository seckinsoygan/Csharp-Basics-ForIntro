Console.WriteLine("Başlangıç değerini giriniz: ");
int baslangic = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Bitiş değerini giriniz:  ");
int bitis = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Artış değerini giriniz: ");
int artis = Convert.ToInt32(Console.ReadLine());

for (int i = baslangic; i <= bitis; i += artis)
{
    Console.Write($"{i} - ");
}

Console.Read();

