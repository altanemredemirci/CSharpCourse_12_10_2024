using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Methods_1
{
    internal class Matematik
    {
        static int yas = 10;
        
        internal static void Toplam() //erişim belirteci verilmeyen fields(metot,değişkenler) default olarak PRIVATE alırlar.
        {
            Console.WriteLine("1.sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sonuç:" + (sayi1 + sayi2));
        }

        static void DortIslem()
        {
            Toplam();
        }
    }
}
