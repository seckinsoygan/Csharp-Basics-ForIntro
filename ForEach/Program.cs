int[] sayilar = { 5, 8, 12, 34, 8, 95 };
int toplam = 0;

foreach (var sayi in sayilar)
{
    toplam += sayi;
}

// Array.Sort(dizi);  --Diziyi küçükten büyüğe şekilde sıralar.
// Array.Reverse(dizi) --Diziyi büyükten küçüğe şekilde sıralar.


Console.Write($"Sayilarin toplamı = {toplam}");
Console.Read();
