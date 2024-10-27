using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayı_Tahmin_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("*** Sayı Tahmin Uygulaması ****\n");

            int Rstsayı;
            int sayıtahmin=0;
            int sayac = 0;

            Random rastgele = new Random();
            Rstsayı = rastgele.Next(1, 70); 

            Console.WriteLine();
                  
            while (sayıtahmin!=Rstsayı) 
            {
                sayac++; 
                Console.Write("1 ve 69 Arası Bir Sayı Giriniz: ");
                sayıtahmin = Convert.ToInt32(Console.ReadLine());

                if (sayıtahmin>Rstsayı)
                {
                    Console.WriteLine("Daha Küçük Bir Sayı Giriniz: ");
                }
                else if (sayıtahmin<Rstsayı)
                {
                    Console.WriteLine("Daha Büyük Bir Sayı Giriniz: ");
                }
            }
            Console.Write("Tebrikler  " +sayac+ "  Denemede Dogru Bildiniz");
            Console.ReadKey();
        }
    }
}
