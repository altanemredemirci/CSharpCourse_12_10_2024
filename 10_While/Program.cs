namespace _10_While
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* *** LOOPS - DÖNGÜLER *** 
             
            * While
            * For
            * Do-While
            * Foreach
            
            bir kod bloğunun belirli bir koşul sağlanana kadar veya belirli bir tur sayısı kadar tekrar çalıştırılması isteniyorsa yazılım yapılarından LOOPS kullanılır.             
             */

            #region ******** WHILE ********


            //1-10 arasındaki sayıları ekrana yazdırınız.
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);

            //int i = 1;
            //while (i < 11)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //Sonsuz Döngü: While true koşula sahip olduğu sürece tekrar tekrar çalışır.
            //while (true)
            //{
            //    Console.WriteLine("Altan Hoca ÇOK MÜKEMMEL BİR İNSANDIR");
            //}


            //** BREAK KOMUTU: Döngünü kırılmasını sağlar.

            //while (true)
            //{
            //    while (true)
            //    {
            //        Console.WriteLine("Notunuz:");
            //        int not = Convert.ToInt32(Console.ReadLine());

            //        if (not >= 0 && not <= 100) //0-100 arasında ise TRUE olur.
            //        {
            //            break; // KENDİ İÇİNDE bulunduğu döngüyü kırar. 
            //        }
            //    }

            //    Console.WriteLine("while bitti");
            //    break;
            //}


            //** CONTINUE KOMUTU: Döngünün continue satırdan koşul satırına geri dönmesini sağlar.

            // 1-10 arasındaki sayıları yazdırırken 7 rakamını atlayınız.
            //int i = 1;
            //while (i<11)
            //{
            //    if (i == 7)
            //    {
            //        i++;
            //        continue;                  
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //        i++; //i+=1;
            //    }

            //}
            #endregion

            #region 200 den başlayarak 0 a kadar olan ve 3'ün katı olan sayıları ekrana yazdırınız.

            /*
             1-başla
             2-sayi=200
             3-sayi 0'dan büyük mü? T->4 F->7
             4-sayi 3'ün katı mı? T->5 F->6
             5-sayiyi ekrana yaz
             6-sayiyi 1 azalt -> 3
             7-Bitti
             */

            //int sayi = 200;

            //while (sayi > 0)
            //{
            //    if (sayi % 3 == 0)
            //    {
            //        Console.WriteLine(sayi);

            //    }
            //    sayi--;
            //}

            #endregion

            #region SELİN
            //int i = 200;
            //while (i > 0)
            //{

            //    if (i % 3 != 0)
            //    {
            //        i--;
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //        i--;
            //    }
            //}
            #endregion


            #region Kullanıcıdan 0 girilene kadar pozitif sayılar girmesi istensin. 0 girilene kadar girilen pozitif sayılar toplansın ve ortalaması hesaplansın.
            // Kullanıcı 0 girdiğinde döngü bitsin ve toplam,ortalama ekrana yazdırılsın.
            // ** Kullanıcı ilk sayıyı 0 girerse tekrar sayı istensin
            // ** kullanıcı negatif sayı girerse "lütfen Pozitif Sayı Giriniz!!" uyarısını verilsin.


            //int toplam=0;
            //int adet = 0;
            //while (true)
            //{
            //    Console.WriteLine("Pozitif sayı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if(sayi==0 && adet == 0)
            //    {
            //        continue;
            //    }
            //    else if (sayi == 0)
            //    {
            //        break;
            //    }
            //    else if (sayi < 0)
            //    {
            //        Console.WriteLine("Lütfen pozitif bir sayı giriniz!!");
            //        continue;
            //    }

            //    toplam += sayi;
            //    adet++;
            //}

            //Console.WriteLine(toplam);
            //Console.WriteLine("Ortalama:"+(toplam/adet));
            #endregion
            #region Kullanıcıya kayıtlı username ve şifre giriş paneli için 3 hak veriniz ve 3 hak giriş yapamaz ise sistemi 10 saniye kitleyiniz. Kullanıcıya gerekli bütün uyarıları yapınız.
            //string kullaniciAdi = "altanemre";
            //string sifre = "123";

            //int hak = 3;

            //while (hak > 0)
            //{
            //    Console.WriteLine("Username:");
            //    string username = Console.ReadLine();

            //    Console.WriteLine("Password:");
            //    string password = Console.ReadLine();

            //    hak--;

            //    if (username==kullaniciAdi && password == sifre)
            //    {
            //        Console.WriteLine("Giriş Başarılı");
            //        break;
            //    }
            //    else if (hak == 0)
            //    {
            //        Console.WriteLine("Hakkınız Doldu.");
            //        Thread.Sleep(4000);
            //        hak = 3;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Giriş Başarısız!!");
            //    }
            //}
            #endregion

            #region // Müşteriye kaç ürün aldığını soralım.
            // Aldığı ürünlerin sırayla fiyatlarını girmesini isteyelim.
            // Girilen ürün fiyatlarını toplayarak ödeme miktarı müşteriye söyleyelim.

            //Console.WriteLine("Kaç Ürün Aldınız:");
            //int urunSayisi = Convert.ToInt32(Console.ReadLine());

            //double toplam = 0;

            //int i = 1;
            //while (i <= urunSayisi) //i=1,2,3
            //{
            //    Console.Write($"{i}.Ürün fiyatını giriniz: ");
            //    double fiyat = Convert.ToDouble(Console.ReadLine());
            //    toplam += fiyat;
            //    i++;
            //}
            //Console.WriteLine($"Fiyat: {toplam} TL");


            #endregion

            //System: Kütüphane
            //Console: Class
            //WriteLine():Metot
            //Console.WriteLine();

            #region ***** RANDOM *****

            // Rastgele sayı üretmeye yarayan bir C# kütüphanesidir.
            // Sadece sayısal değerler döner.


            //Random rnd = new Random();

            //Random: bir classtır.
            //Bu işleme INSTANCE - Örneklem
            //rnd   : nesne anlamına gelir.
            //new   : türetmek için kullanılır.

            //Console.WriteLine(rnd.Next(5)); //0 ile MaxValue arasında rastgele tam sayı verir. MaxValue dahil edilmez.

            //Console.WriteLine(rnd.Next()); //Pozitif çok basamaklı bir rastgele tam sayı verir.

            //Console.WriteLine(rnd.Next(10, 20));

            //int rast = rnd.Next(1, 100);

            #region  Kullanıcıya 5 kez hak vererek bilgisayar tarafında daha önce  1-100 aralığında oluşturulmuş rastgele sayıyı tahmin etmesini isteyelim. Kullanıcıyı tahmininizi büyültünüz, küçültünüz gibi yönlendirelim.

            //Random r = new Random();
            //int rastgele = r.Next(1, 100);
            //Console.WriteLine(rastgele);

            //int hak = 5;

            //while (hak > 0)
            //{
            //    Console.WriteLine("Tahmininiz:");
            //    int tahmin = Convert.ToInt32(Console.ReadLine());

            //    if (tahmin == rastgele)
            //    {
            //        Console.WriteLine("Tebrikler Bildiniz.");
            //        break;
            //    }
            //    else if (hak == 1)
            //    {
            //        Console.WriteLine("Hakkınız Bitti");
            //    }
            //    else if (tahmin > rastgele)
            //    {
            //        Console.WriteLine("Tahmininizi Küçültünüz.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Tahmininizi Büyültünüz.");
            //    }
            //    hak--;
            //}

           


            #endregion
            #endregion
        }
    }
}
