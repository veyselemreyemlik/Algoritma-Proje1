using System;

namespace PatikaOdev3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *Kullanıcıdan pozitif bir sayı girmesini istiyoruz (n).
            // *Sonrasında kullanıcıdan n sayısı kadar kelime girmesini istiyoruz.
            // *Girilen kelimeleri ekrana sondan başa yazdırıyoruz.

            Console.Write("Bir Sayı Giriniz : ");
            int number = int.Parse(Console.ReadLine());
            string[] words = new string[number];

            if (number > 0)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    
                    Console.WriteLine("Kelime Giriniz.", i+1);
                    words[i] = Console.ReadLine();
                }

                for (int i = 0; i < words.Length; i++)
                {
                    char[] dizi= words[i].ToCharArray();
                    Array.Reverse(dizi);
                    string returnmetin = new string(dizi);
                    Console.WriteLine(returnmetin);
                }

                Array.Reverse(words);

                foreach (var item in words)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("LÜTFEN POZİTİF BİR SAYI GİRİNİZ!");
            }

        }

    }
}
