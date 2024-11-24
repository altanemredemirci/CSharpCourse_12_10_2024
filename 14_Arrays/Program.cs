using System;

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

            //string[] adlar = { "Mehmet", "Ercan", "Bahir", "Arhan", "Bahir", "Koray", "Altan", "Fatma", "Bahir" };

            //Console.WriteLine(Array.LastIndexOf(adlar, "Bahir"));


            //Console.WriteLine(Array.LastIndexOf(adlar, "Bahir", 7)); //3.param aramaya başlanacak Index


            #endregion

            #region Sort()
            // Dizinin elemanlarını 0->9 A->Z ye sıralar.
            //int[] sayilar = { 11, 2, 54, 3, 4,4, 1, 34, 23, 14 };

            //string[] ogrenciler = { "Safiye","Nil","Altan", "Eymen", "Bekir","Altay", "Rümeysa", "Berat", };


            //Array.Sort(ogrenciler);

            //foreach (string item in ogrenciler)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Reverse()
            //Dizinin elemanlarını tanımlı oldukları sıranın tam tersine çevirir.
            //string[] ogrenciler = { "Safiye", "Nil", "Altan", "Eymen", "Bekir", "Altay", "Rümeysa", "Berat", };

            //Array.Reverse(ogrenciler);

            //foreach (string item in ogrenciler)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Resize()
            //Dizinin boyutunu(kapasite) yeniden biçimlendirmeye yarar.

            //int[] sayilar = new int[3];

            //sayilar[0] = 11;
            //sayilar[1] = 12;
            //sayilar[2] = 13;
            //// Ref keyword ü daha önce tanımlanmış ve method ile revize olacak değeri tanımlar.
            //Array.Resize(ref sayilar, 5);
            //sayilar[3] = 14;


            #endregion
            #endregion

            #region Aşağıdaki dizinin elemanlarını Z->A doğru sıralayınız
            //string[] ogrenciler = { "Safiye", "Nil", "Altan", "Eymen", "Bekir", "Altay", "Rümeysa", "Berat", };

            //Array.Sort(ogrenciler);
            //Array.Reverse(ogrenciler);

            //foreach (string item in ogrenciler)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region İSTANBUL kelimesinin harflerini alt alta ekrana yazdırınız.
            //string sehir = "İSTANBUL";

            #region ELİF
            //for (int i = 0; i < sehir.Length; i++)
            //{
            //    Console.WriteLine(sehir[i]);
            //}
            #endregion

            //foreach (char item in sehir)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Bir dizinin eleman sayısı 10 ile 20 arasında olacak şekilde sistem tarafında otomatik atılmaktadır.
            //Bu dizinin elemanlarını da sistem 0,100 arasında otomatik atmaktadır.
            //Otomatik oluşturulan bu dizinin eleman sayısını ve elemanlarını kullanıcıya gösteriniz
            //Aynı sayılar tekrar atanmayacak
            //Dizideki en büyük ve en küçük sayılar sort() kullanılmadan bulup ekrana yazdırılacak 

            //Random r = new Random();
            //int uzunluk = r.Next(10, 20);

            //int[] sayilar = new int[uzunluk];
            //int index = 0;
            //while(index < sayilar.Length)
            //{
            //    int sayi =r.Next(0, 100);
            //    //Contains:verilen değerin koleksiyonda olup olmadığını kontrol eder. Var ise TRUE, yoksa FALSE döndürür.
            //    if (sayilar.Contains(sayi) == false) 
            //    {
            //        sayilar[index] = sayi;
            //        index++;
            //    }               
            //}
            //Console.WriteLine("Eleman Sayısı:"+sayilar.Length);
            //int enbuyuk = sayilar[0];
            //int enkucuk = sayilar[0];
            //foreach (int item in sayilar)
            //{
            //    if (enbuyuk < item)
            //    {
            //        enbuyuk = item;
            //    }
            //    if (enkucuk > item)
            //    {
            //        enkucuk = item;
            //    }
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("En Büyük:"+enbuyuk);
            //Console.WriteLine("En Küçük:"+enkucuk);
            #endregion

            #region 100 elemanlı bir dizi için 0-1000 arasında rastgele sayılar atayın.
            //Bu dizinin elemanlarının sayı ortalamasını, en küçük değerini ve en büyük değerini gösteriniz

            //Random r = new Random();

            //int[] sayilar = new int[100];
            //int toplam = 0;
            //int i;

            //for (i = 0; i < sayilar.Length; i++)
            //{
            //    sayilar[i] = r.Next(0, 1000);
            //    toplam += sayilar[i];
            //}

            //int enbuyuk = sayilar[0];
            //int enkucuk = sayilar[0];

            //foreach (int item in sayilar)
            //{
            //    if (enbuyuk < item)
            //    {
            //        enbuyuk = item;
            //    }
            //    if (enkucuk > item)
            //    {
            //        enkucuk = item;
            //    }
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("En büyük:" + enbuyuk);
            //Console.WriteLine("En küçük:" + enkucuk);

            //int ortalama = toplam / sayilar.Length;
            //Console.WriteLine($"ortalama:{ortalama}");
            #endregion

            #region Ehliyet alıp alamayacağı, alamadığında kaç sene gerektiği sonra ehliyet alabileceğini söyleyen program yazınız.

            //Console.WriteLine("Kaç Yaşındasın:");
            //int yas = Convert.ToInt32(Console.ReadLine());

            //if (yas < 18)
            //{
            //    int fark = 18 - yas;
            //    Console.WriteLine("Şu an ehliyet alamazsın.");
            //    Console.WriteLine((DateTime.Now.Year + fark) + " yıl sonra ehliyet alabilirsin");
            //}
            //else
            //{
            //    Console.WriteLine("Ehliyet alabilirsin");
            //}

            #endregion

            #region  Kullanıcıdan 4 ürün fiyatı isteyin fiyatı 1200 tl yi geçen ürünlere %32 indirim yapınız ve 
            //        her biri ürünün yeni fiyatını gösteriniz

            #region Gizem
            //double[] fiyatlar = new double[4];
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine($"urun{i + 1}'in fiyatını girin:");
            //    fiyatlar[i] = Convert.ToDouble(Console.ReadLine());
            //}


            //for (int i = 0; i < 4; i++)
            //{
            //    double yenifiyat = fiyatlar[i];
            //    if (yenifiyat > 1200)
            //    {
            //        fiyatlar[i] = yenifiyat * 0.68;
            //    }
            //}

            //foreach (double item in fiyatlar)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Selin
            //double[] fiyatlar = new double[4];

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine($"{i + 1}.ürünün fiyatını girin:");
            //    double fiyat = Convert.ToDouble(Console.ReadLine());

            //    if (fiyat > 1200)
            //    {
            //        fiyat = fiyat * 68 / 100;
            //    }
            //    fiyatlar[i] = fiyat;
            //    Console.WriteLine($"{i + 1}.ürünün fiyatı: {fiyat}");
            //}
            #endregion
            #endregion



            #region PROJE ÖDEVİ

            //string[] ogrenciler = { "Eymen", "Eymen", "Eymen", "Eymen", "Safiye", "Eymen", "Eymen", "Eymen", "Eymen", "Safiye", "Bekir", "Eymen", "Eymen", "Eymen", "Rümeysa", "Safiye", "Berat", "Eymen", "Eymen", "Eymen", "Eymen", "Eymen", "Eymen", "Eymen", "Eymen", "Eymen", "Safiye" };

            //Yukarıdaki dizinin içinde bulunan SAFİYE isimlerinin Index değerlerini ekrana bir döngü yardımı ile yazdırınız.

            //Düşününki dizi içinde 1Milyon isim olabilir. Oluşturulan döngü tek tek kontrol ederek 1 Milyon tur atmasın. Kodun başarılı olması en az tur da bütün indexleri yazdırmalısınız.

            //int count = 0;

            //int index = -1;
            //while (index< ogrenciler.Length) 
            //{
            //    count++;
            //    index = Array.IndexOf(ogrenciler, "Safiye",index+1);
            //    if (index == -1)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(index);
            //}

            //Console.WriteLine("Tur sayısı:"+count);
            #region SELİN BAYRAK
            //string[] ogrenciler = { "Safiye", "Eymen", "Safiye", "Bekir", "Rümeysa", "Safiye", "Berat", "Safiye" };
            //int count = 0;
            //int baslangicİndexi = Array.IndexOf(ogrenciler, "Safiye");
            //int sonucIndexi = Array.LastIndexOf(ogrenciler, "Safiye");

            //Console.WriteLine(baslangicİndexi);

            //while (baslangicİndexi != sonucIndexi)
            //{
            //    count++;
            //    int yenibaslangicindexi = Array.IndexOf(ogrenciler, "Safiye", baslangicİndexi + 1);

            //    Console.WriteLine(yenibaslangicindexi);

            //    baslangicİndexi = yenibaslangicindexi;

            //}

            //Console.WriteLine("Tur sayısı:" + count);
            #endregion

            #endregion






        }
    }
}
