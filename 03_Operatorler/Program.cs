using System.Drawing;

namespace _03_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ARİTMATİK OPERATORLER(+,-,*,/,%)

            //int sayi1 = 10;
            //int sayi2 = 4;
            //int sonuc = sayi1 + sayi2;
            //int sonuc2 = sayi1 - sayi2;
            //int sonuc3 = sayi1 * sayi2;
            //int sonuc4 = sayi1 / sayi2;

            //Console.WriteLine(sonuc);
            //Console.WriteLine(sonuc2);
            //Console.WriteLine(sonuc3);
            //Console.WriteLine(sonuc4);

            // Mod Alma(%): bir sayının başka bir sayıya bölümünden KALANI verir.
            //Console.WriteLine(sayi1%sayi2);

            //Console.WriteLine(sayi1/sayi2);
            //double sonuc5 = sayi1 / sayi2;

            #endregion

            #region Bir Arttırma Bir Azaltma

            //int sayi = 5;
            //sayi++; //sayi = sayi + 1;
            //sayi--;          
            //Console.WriteLine(sayi);



            //int a = 5;
            //int b = a++;
            //int c = ++a;
            //Console.WriteLine("a:"+a);
            //Console.WriteLine("b:"+b);
            //Console.WriteLine("c:"+c);


            #endregion

            #region İŞLEMLİ ATAMA OPERATORLERİ

            //int sayi = 5;
            //sayi += 1;   //sayi = sayi + 1;
            //sayi -= 2;  //sayi = sayi - 2;
            //sayi *= 2;  //sayi = sayi * 2;
            //sayi /= 2;  //sayi = sayi / 2;

            #endregion

            #region KARŞILAŞTIRMA OPERATÖRLERİ
            /*
            <
            >
            <=
            >=
            == eşittir
            != eşitdeğildir
            */

            //int sayi = 5;
            //int sayi2 = 6;

            //bool sonuc = sayi > sayi2;
            //Console.WriteLine(sayi == sayi2);
            //Console.WriteLine(sayi != sayi2);
            #endregion

            #region MANTIKSAL OPERATÖRLER (&&, ||, !)

            // && - AND : Birden fazla karşılaştırma - kontrol' ların sonucun True olması durumunda Program TRUE verecek ise AND kullanılır.

            /*
             1Koşul 2Koşul  Sonuç
               0        0       0
                1       0       0
                0       1       0
                1       1       1



            string username = "altanemre";
            string password = "123";

            Console.WriteLine("Kullanıcı Adınız:");
            string kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifreniz:");
            string sifre = Console.ReadLine();

            Console.WriteLine(username==kullaniciAdi && password == sifre);


             */

            // || - OR: Birden fazla karşılaştırmada bir koşulun doğru olması yeterli ise OR || kullanılır.
            /*
              1Koşul 2Koşul   Sonuç
                0       0       0
                1       0       1
                0       1       1
                1       1       1

            */

            //string email = "altanemre@gmail.com";
            //string phone = "5366295132";
            //string password = "123";

            //Instagram Login: email/phone
            //                 password


            //Console.WriteLine("Email / Phone:");
            //string kullanici = Console.ReadLine();
            //Console.WriteLine("Şifreniz:");
            //string sifre = Console.ReadLine();

            //Console.WriteLine((email==kullanici || phone==kullanici) && password == sifre);


            // ! - DEĞİL : True => False   False => True

            //bool sonuc = 5 > 3;
            //Console.WriteLine(sonuc);
            //Console.WriteLine(!sonuc);
            #endregion

            #region ERİŞİM OPERATORU

            //Console.ReadLine();

            //Matematik.Topla();

            #endregion


            //int a = 5;
            //int b = 6;
            //int c = 7;
            //string isim = "altan";


            // Console.WriteLine kullanım şekilleri 
            //1:
            //Console.WriteLine("A:" + a + " B:" + b);
            //2:Cw içinde , ile değerleri sıralayabilir.0'dan başlayarak 1'er 1'er artan numaralandırılır.
            // {} içerisine yazılan index numarasına göre değer taşınır.
            //Console.WriteLine("A:{0} B:{2}", a, b, isim);
            //3:string tanım başına konulan '$' ifadesi string içerisinde C# komutları veya tanımları yazmayı sağlar.
            //Console.WriteLine($"A:{a} B:{b}"); 

        }
    }
}
