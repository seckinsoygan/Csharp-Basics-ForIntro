Random rastgele=new Random();

int a = rastgele.Next(1, 11);
int b = rastgele.Next(1, 11);
int c = rastgele.Next(1, 11);

Console.WriteLine($"a={a} , b={b} , c={c}");

int[] dizi = {a,b,c};
int max = 0;

for(int i = 0; i < 3; i++)
{
    if (dizi[i] > max)
    {
        max = dizi[i];
    }

}
double d = Math.Pow(max, 2);

Console.WriteLine($"d nin degeri = {d}");

Console.Read();
