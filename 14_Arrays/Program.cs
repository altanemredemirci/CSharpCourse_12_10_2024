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
                                               // * sayısal veri tutan koleksiyonlara değer ataması olmazsa default 0 değerini tutarlar.

            //Console.WriteLine(maaslar[2]);


            //Dolu Dizi Tanımı
            //int[] sayilar = { 1, 2, 3, 4, 5 };

            //Console.WriteLine(sayilar[5]); //IndexOutOfRangeException hatasını verir.


            //Console.WriteLine(sayilar.Length);



            #region DİZİ OKUMA
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            // FOREACH bir döngü tanımıdır. Koleksiyon içindeki elemanları döndürmek(yazdırmak-okumak) için kullanılır.
            //foreach (int item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region DİZİYE ELEMAN EKLEME
            //string veri tipinin default değeri null 'dur.
            //string[] ailem = new string[8];
            //ailem[0] = "Altan Emre";
            //ailem[2] = "Ceylan";
            //ailem[3] = "Uras";
            //ailem[4] = "Kıvanç";
            //ailem[5] = "Kerem";
            ////ailem[8] = "Barbara Palvin"; //Varolmayan index değerine 

            //ailem[5] = "Defne";

            #endregion

            #region Kullanıcıya kaç personeli olduğunu sorunuz. Verilen cevapdan sonra her personelin adını sorup bir diziye ekleyiniz. Dizi tamamlandığında personel isimlerini ekrana yazdırınız.

            //Console.WriteLine("Personel Sayınız:");
            //int personelSayisi = Convert.ToInt32(Console.ReadLine());

            //string[] personeller = new string[personelSayisi];

            //for (int i = 0; i < personelSayisi; i++)
            //{
            //    Console.WriteLine("Personel Adı:");
            //    string isim = Console.ReadLine();
            //    personeller[i] = isim;
            //}

            //// Yazdırma Yolları
            //foreach (string isim in personeller)
            //{
            //    Console.WriteLine(isim);
            //}

            //for (int i = 0; i < personelSayisi; i++)
            //{
            //    Console.WriteLine(personeller[i]);
            //}
            #endregion
            #region ARRAY SINIFININ METOTLARI

            #region Clear
            // Tanımlı elemanları siler

            //int[] sayilar = { 11, 22, 33, 44, 55 };

            //Array.Clear(sayilar);

            //Array.Clear(sayilar, 1, 2); // 1.param dizi, 2.param silmeye başlanacak index, 3.param kaç eleman silinecek


            #endregion

            #region Copy()
            // Belirli bir koleksiyondan bir diğer koleksiyona istenilen elemanları KOPYALAR.

            //int[] sayilar = new int[10];
            //sayilar[0] = 11;
            //sayilar[1] = 12;
            //sayilar[2] = 13;


            //int[] rakamlar = sayilar; 

            //sayilar[3] = 14; // aynı anda rakamlar dizisine de eklendi.Çünkü new (yeni adresleme) yapılmadığı için sayilar ile aynı ram adresini referans aldı.


            //int[] sayilar = new int[5];
            //sayilar[0] = 11;
            //sayilar[1] = 12;
            //sayilar[2] = 13;
            //sayilar[3] = 14;
            //sayilar[4] = 15;

            //int[] rakamlar = new int[10];

            ////Array.Copy(sayilar, rakamlar, 2);

            //Array.Copy(sayilar, 1, rakamlar, 5, 3);
            /*
            1.param kaynak dizi
            2.param kaynak diziden alınacak değerlerin başlangıç indexi
            3.param hedef(kopyalanacak) dizi
            4.param kopyalanan değerlerin konumlanmaya başlayacağı index
            5.param kaç değer kopyalanacak
             */

            //foreach (int item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n\n");
            //foreach (int item in rakamlar)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region IndexOf()
            // Aranacak değerin ilk görüldüğü index numarasını verir.

            //string[] adlar = { "Mehmet", "Ercan", "Bahir", "Arhan", "Bahir", "Koray", "Altan", "Fatma" };

            //Console.WriteLine(Array.IndexOf(adlar, "Bahir"));


            //Console.WriteLine(Array.IndexOf(adlar,"Bahir",3)); //3.param aramaya başlanacak Index


            //Console.WriteLine(Array.IndexOf(adlar,"Enes")); //Aranan değerin indexi bulunamazsa -1 verir.

            //int index = Array.IndexOf(adlar, "Koray");


            #endregion

            #region LastIndexOf()
            // Aranacak değerin son görüldüğü index numarasını verir.

            string[] adlar = { "Mehmet", "Ercan", "Bahir", "Arhan", "Bahir", "Koray", "Altan", "Fatma","Bahir" };

            Console.WriteLine(Array.LastIndexOf(adlar, "Bahir"));


            Console.WriteLine(Array.LastIndexOf(adlar,"Bahir",7)); //3.param aramaya başlanacak Index


            #endregion


            #endregion


            #region PROJE ÖDEVİ

            //string[] ogrenciler = { "Safiye", "Eymen", "Safiye", "Bekir", "Rümeysa", "Safiye", "Berat", "Safiye" };

            //Yukarıdaki dizinin içinde bulunan SAFİYE isimlerinin Index değerlerini ekrana bir döngü yardımı ile yazdırınız.

            //Düşününki dizi içinde 1Milyon isim olabilir. Oluşturulan döngü tek tek kontrol ederek 1 Milyon tur atmasın. Kodun başarılı olması en az tur da bütün indexleri yazdırmalısınız.

         

            #endregion
        }
    }
}
