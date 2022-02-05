using System;

namespace PatikaOdev1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            // * Kullanıcıdan pozitif bir sayı girmesini istiyoruz (n).
            // * Sonrasında ise kullanıcıdan n sayısı kadar pozitif sayı girmesini istiyoruz.
            // * Girilen bu sayıların içinden çift olanları ekrana yazdırıyoruz.

            Console.Write("Lütfen Pozitif Bir Sayı Giriniz :");
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                int[] array = new int[number];
                for (int i = 0; i < number; i++)
                {
                    Console.Write("Bir Sayı Giriniz :");
                    int sayi = int.Parse(Console.ReadLine());   
                    array[i] = sayi;
                }
                for (int j = 0; j < number ; j++)
                {
                    if (array[j] % 2 == 0)
                    {
                        Console.WriteLine("Çift Sayılar :" + array[j]);
                    }
                }
            }
        }
    }
}
