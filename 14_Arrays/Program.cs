namespace _14_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            *****  ARRAYS - DİZİLER  *****
            * Değişkenler tek bir veri tutarken, diziler birden fazla veri tutabilen koleksiyon tipidir.
            * Index adı verilen numaralandırma yöntemi ile verileri sıralı şekilde tutarlar. Bu sayede çok veri içinden istenilene INDEX numarası ile ulaşılabilir.
            * Index numaraları default olarak 0 dan başlar ve 1'er 1'er artarak devam eder.
            * Diziler kendilerine ait metotlara sahiptirler.
            * Dizi tanımlanırken tutacağı elemanların veri tipi ve kaç eleman tutacağını belirtmek zorunludur.
            * Tek veri tipinde verilen uzunluk kadar eleman tutarlar.                         
             */


            // ***** DİZİ TANIMLAMA ******

            //Boş Dizi Tanımı
            double[] maaslar = new double[10]; // maksimum 10 double değer alabilir.
            
            //Dolu Dizi Tanımı
            int[] sayilar = { 1, 2, 3, 4, 5 };

            Console.WriteLine(sayilar[5]);

            //Console.WriteLine(sayilar.Length);

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}



            //foreach (var item in collection)
            //{

            //}

        }
    }
}
