using System;

namespace PatikaOdev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // * Kullanıcıdan 2 adet pozitif sayı girilmesini istiyoruz (m,n)
            // * Kullanıcının girdiği n sayısı kadar tekrar sayı girilmesini istiyoruz.
            // * Bu girilen sayılardan hangileri m sayısına eşit veya tam bölünüyorsa ekrana yazdırıyoruz.

            Console.Write("Lütfen Bir Sayı Giriniz :");
            int ilkSayi = int.Parse(Console.ReadLine());

            Console.Write("Lütfen İkinci Sayıyı Giriniz :");
            int sonSayi = int.Parse(Console.ReadLine());

            int[] array = new int[ilkSayi];

            if (ilkSayi > 0 || sonSayi>0)
            {

            for (int i = 0; i < array.Length ; i++)
            {
                    Console.Write("Sayı Giriniz :" , i+1);
                    int sayi = int.Parse(Console.ReadLine());
                    array[i] = sayi;
            }

            for (int i = 0; i < array.Length; i++)
            {
                    if (array[i] == sonSayi)
                    {
                        Console.WriteLine(array[i] + ". Sayısı Girilen Son Sayıya Eşitttr.");
                    }
                    else if (array[i] % sonSayi == 0)
                    {
                        Console.WriteLine(array[i] + "Sayısı Girilen Son Sayıya Tam Bölünebilir.");
                    }
                   

            }


            }

        }
    }
}
