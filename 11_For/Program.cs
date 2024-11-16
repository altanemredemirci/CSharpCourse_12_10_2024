namespace _11_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //while (i < 11) //1,2,3,4,5,6,7,8,9,10
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            /*
            1-sayaç(i) tanımlanır.
            2-while içerisinde koşul kontrol ediliyor ve true olduğu durumda tur dönüyor. T->3 F->6
            3-işlem kod bloğu çalışıyor.
            4-i manipüle ediliyor.(arttırma,azaltma)
            5-2.adıma dön 
            6-Bitti
             */

            // *********** FOR LOOP ***********

            #region FOR LOOP
            //for (int i=1; i<11; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Kullanıcının girmiş olduğu 5 pozitif sayıyı toplayınız.

            //int toplam = 0;

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi >= 0)
            //    {
            //        toplam += sayi;
            //    }
            //    else
            //    {
            //        i--;
            //    }
            //}

            //int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine("Sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi >= 0)
            //    {
            //        toplam += sayi;
            //        i++;
            //    }

            //}

            //Console.WriteLine("Toplam:" + toplam);
            #endregion

            #region 20'den 0 a kadar olan sayıları ekrana yazdırınız.

            //for(int i=20; i>0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Kullanıcıdan alınan başlangıç ve bitiş değerlerinin arasındaki sayılardan 3'ün katı olanları ekrana yazdıran For Loop
            /*
            Console.WriteLine("Başlangıç:");
            int basla = Convert.ToInt32(Console.ReadLine()); //10

            Console.WriteLine("Bitiş:");
            int bitis = Convert.ToInt32(Console.ReadLine()); //30

            if (basla > bitis)
            {
                int t = basla;
                basla = bitis;
                bitis = t;
            }

            bool varMi = false; // burada girilen aralıkta 3'ün katı sayıların olup olmadığını kontrol etmek için bir değişken tanımladık.
            for (int i = basla; i < bitis; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                    varMi = true; //Herhangi bir sayı 3'ün katı olması durumunda değişken true ya döner.
                }

            }

            //for döngüsü bittiğinde eğer hala varMi değişkeni false ise o zaman aralıktaki sayılardan hiç biri 3'ün katı değildir.
            if (!varMi) //(varMi == false)
            {
                Console.WriteLine("Girilen aralıkta 3'ün katı yoktur.");
            }
            */

            #endregion

            #region Kullanıcıdan alınan bir sayının faktörüyeli hesaplayan for döngüsünü yazınız.
            // 5 => 5*4*3*2*1 => 120

            //Console.WriteLine("Faktöriyeli hesaplanacak sayı:");
            //int sayi = Convert.ToInt32(Console.ReadLine()); //5
            //int sonuc = 1;
            //for (int i = 1; i <=sayi; i++) //i:1,2,3,4,5
            //{
            //    sonuc *= i; //sonuc=sonuc*i;      //1*1=1 1*2=2 2*3=6 6*4=24...
            //}
            //Console.WriteLine("Faktöriyel:"+sonuc);
            #endregion

            #region 1-500 arasındaki sayıların içinden 13 katlarının sayısını ve toplamlarını hesaplayınız

            int adet = 0;
            int toplam = 0;
            for (int i = 1; i < 500; i++)
            {
                if (i % 13 == 0)
                {
                    Console.WriteLine(i);
                    toplam += i; // toplam = toplam+i;
                    adet++;
                }
                   
            }
            Console.WriteLine("Toplam:"+toplam);
            Console.WriteLine("Adet:"+adet);

            #endregion


            #region  PASCAL ÜÇGENİ
            /*
            
            *
            **
            ***
            ****
            *****
            ******
            
             */
            #endregion

            #region KARE
            /*
             
            *********
            *       *
            *       *
            *       *
            *       *
            *       *
            *********
               
             */

            #endregion

            #region Yılbaşı Ağacı
            /*
             
                    *
                   ***
                  *****
                 *******
                *********
               ***********
              
             */
            #endregion

            #region Çarpım Tablosu

            /*
             
            1*1=1  2*1=2 3*1=3 ...
            1*2=2
            1*3=3
            
             */

            #endregion


        }
    }
}
