using System;
 
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b;
 
            Console.WriteLine("A sayisini giriniz : ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("B sayisini giriniz : ");
            b = double.Parse(Console.ReadLine());
 
             if (a > b)
                Console.WriteLine("Girdiginiz A sayisi olan {0} degeri en buyuktur", a);
 
            else if (b > a)
 
                Console.WriteLine("Girdiginiz B sayisi olan {0} degeri en buyuktur", b);
 
            else if (a == b)
                Console.WriteLine("Girdiginiz A sayisi olan {0} ile Girdiginiz B sayisi olan {1} degerleri birbirine esittir", a, b);
 
            else
                Console.WriteLine("Hatali giris yapildi program kapatilacak");
 
        }
    }
 
 
}
