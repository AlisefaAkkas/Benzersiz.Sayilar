using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benzersiz.Sayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç adet sayı üretelim?");
            int adet = int.Parse(Console.ReadLine());
            int[] sayi = new int[adet];
            Random rnd = new Random();
            for (int i = 0; i > sayi.Length; i++)
            {

                sayi[i] = rnd.Next(1, 100);
            }

            Console.WriteLine("Dizi :");
            for (int i = 0; i < sayi.Length; i++)
            {
                Console.WriteLine($"{sayi[i]}-");
                sayi[i] = rnd.Next(1, 100);



            }
            for (int i = 0; i < sayi.Length; i++)
            {
                Console.WriteLine($"{sayi[i]}-");
            }


            Array.Sort(sayi);
            Console.WriteLine("Küçükten büyüğe sıralama :");
            for (int i = 0; i < sayi.Length; i++)
            {
                Console.Write($"{sayi[i]}-");
            }
            Console.ReadKey();
        }
    }
}
