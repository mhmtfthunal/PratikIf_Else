Console.WriteLine("Bir sayı giriniz.");

int sayi = Convert.ToInt32(Console.ReadLine());
int bolumdenKalan = sayi % 2;

if (sayi == 10)
{
    Console.WriteLine("Girilen sayı 10'a eşittir.");
}
else if (sayi < 10)
{
    Console.WriteLine("Girilen sayı 10'dan küçüktür.");
}
else
{
    Console.WriteLine("Girilen sayı 10'dan büyüktür.");
}
if (bolumdenKalan == 0)
{
    Console.WriteLine("Girilen sayı çifttir.");
}
else
{
    Console.WriteLine("Girilen sayı tektir.");
}