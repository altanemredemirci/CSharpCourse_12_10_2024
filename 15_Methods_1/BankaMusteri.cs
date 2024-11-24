using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Methods_1
{
    internal class BankaMusteri
    {
        //Default olarak tanımlanan özellikler PRIVATE olur. genellikle private tanımın amacı kullanıcı direk erişmesin kontrolle kullanabilsin.
        static string iban;
        static string Ad;
        static string Soyad;


        internal static void MusteriKaydet()
        {
            Console.WriteLine("Ad:");
            Ad = Console.ReadLine();
            Console.WriteLine("Soyad:");
            Soyad = Console.ReadLine();
            Console.WriteLine("IBAN:");
            string Iban = Console.ReadLine();

            IbanKontrol(Iban);
        }

        internal static void Yaz()
        {
            Console.WriteLine(Ad+" "+Soyad+" "+iban);
        }

        //Bu metot Sadece bu class içerisinde müşteri kaydedilirken IBAN bilgisinin kontrolünü yapmak için kullanılır. Bu sebeple private tanımlayarak sadece bu class a özel hale getiriyoruz. Böylece Başka bir dosyadan çağrılamaz.
        private static void IbanKontrol(string IBAN)
        {
            if (IBAN[0]=='T' && IBAN[1]=='R' && IBAN.Substring(2).Length == 12)
            {
                iban= IBAN;                
            }
            else
            {
                Console.WriteLine("Hata!!");
               // IbanKontrol(); //Recursive Metot: Kendi içinde kendini çağıran metot
            }

        }
    }
}
