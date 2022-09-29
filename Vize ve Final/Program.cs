
Console.Write("Vize notunuzu giriniz: ");
double vize = Convert.ToDouble(Console.ReadLine());

Console.Write("Final notunuzu giriniz: ");
double final = Convert.ToDouble(Console.ReadLine());

double Ortalama = ((vize * 40) / 100) + ((final * 60) / 100);

Console.WriteLine($"Ortalama not={Ortalama}");

if (Ortalama > 60)
{

    Console.WriteLine("Geçtiniz tebrikler...");
    Console.Read();
}
else
{
    Console.WriteLine("Maalesef Kaldınız...");
    Console.Read();
}

