namespace _04_Tur_Donusturme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  

             ****** VERİ TÜRÜ DÖNÜŞTERME ******

             * Bilinçsiz Tür Dönüşümü => küçük veritipi -> BÜYÜK VERİTİPİ
             * Biliçli Tür Dönüşümü
             * Boxing


             */

            #region Bilinçsiz Tür Dönüşümü
            // Küçük tipin Büyük tipe dönüşmesi
            //int sayi = 1;
            //decimal sayi2 = sayi;

            //char harf = 'A'; // char ASCII değer tutuğu için string tipe bilinçsiz dönüştürülemez.
            //string isim = harf;

            //float bakiye = 500.5f;
            //double bakiye2 = bakiye;
            #endregion



            // '+' operatörü sayısal değerleri toplar ama iki değerden biri veya ikisi string tipinde ise Concat-birleştirme yapar. 

            #region Bilinçli Tür Dönüşümü 
            // Kullanıcıdan alınan her data STRING FORMAT da gelir. STRING gelen veya herhangi bir tipi başka bir tipe dönüştürmek için 'Convert' kütüphanesi kullanılır.

            //Console.WriteLine("1.kardeşin yaşı:");
            //int yas1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2.kardeşin yaşı:");
            //int yas2 = int.Parse(Console.ReadLine());

            //Console.WriteLine(yas1+yas2);



            //int yas = 34;

            //string y = Convert.ToString(yas);
            //string y2 = yas.ToString();


            //string sayi = "12,5f";
            //double sayi2 = Convert.ToDouble(sayi);
            //Console.WriteLine(sayi2);

            //double a = 12.5;
            //Console.WriteLine(a);

            #endregion

            #region BOXING

            //decimal sayi = 1;
            //int sayi2 = (int)sayi;

            //Console.WriteLine(sayi2);


            // Boxing yapıldığında büyük bir değer küçük bir değer olarak ifade edilirse taşma olur. Sayı long 11 basamaklı atadığımız int max10 basamak alabilir. Değer taştığı(overflow) için veri kaybı yaşandı.
            //long sayi = 123456;
            //int sayi2 = (int)sayi;

            //Console.WriteLine(sayi2);
            #endregion


            //object a = 12; 
            //int b = (int)a; 
            //Console.WriteLine(b);


            //object a2 = "12";
            ////int b2 = (int)a2; //HATA
            //int b2 = Convert.ToInt32(a2);
            //Console.WriteLine(b2);


            //object a3 = 12.5;
            //object a4 = 12.5f;
            //object a5 = 'A';
            //object a6 = 1000m;




        }
    }
}
