using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen sayıya kadar tek sayılarını ekrana yazdır.
            Console.Write("Lütfen Bir Sayı Giriniz: ");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();
            // 1 ile 1000 arasındaki tek ve çift sayıların kendi kendi içlerinde toplamını hesaplayalım
            int CiftToplam = 0;
            int TekToplam = 0;
            for (int j = 0; j <= 1000; j++)
            {
                if (j % 2 == 0)
                {
                    CiftToplam += j;
                }
                else
                {
                    TekToplam += j;
                }
            }

            Console.WriteLine("******************************");
            Console.WriteLine();
            Console.WriteLine("Çift Toplam: " + CiftToplam);
            Console.WriteLine();
            Console.WriteLine("Tek Toplam: " + TekToplam);
            Console.WriteLine();
            Console.WriteLine("******************************");
            
            // break, continue
            for(int k=1; k<10; k++)
            {

                if (k == 4)
                {
                    break;

                }
             
                Console.WriteLine();
                if (k == 5)
                {
                    Console.WriteLine(k);
                    continue;
                }

            }
            Console.ReadLine();
        }
    }
}
