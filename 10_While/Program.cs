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

            // ******** WHILE ********


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


            // Kullanıcıdan 0 girilene kadar pozitif sayılar girmesi istensin. 0 girilene kadar girilen pozitif sayılar toplansın ve ortalaması hesaplansın.
            // Kullanıcı 0 girdiğinde döngü bitsin ve toplam,ortalama ekrana yazdırılsın.
            // ** Kullanıcı ilk sayıyı 0 girerse tekrar sayı istensin
            // ** kullanıcı negatif sayı girerse "lütfen Pozitif Sayı Giriniz!!" uyarısını verilsin.
        }
    }
}
