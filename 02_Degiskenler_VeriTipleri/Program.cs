namespace _02_Degiskenler_VeriTipleri
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            #region DEĞİŞKENLER
            /*
             ******* DEĞİŞKENLER (VARIABLES) *******
            Kodlama alanında bir veriyi tutmayı,taşımayı ve işleme dahil etmeyi sağlayan yazılım yapılarıdır.
            Sadece TEK BİR DATA alabilir.
            Her değişken BENZERSİZ BİR İSME sahip olmalıdır.


            ** DEĞİŞKEN TANIMI
            
            veriTipi değişkenAdı = Değer;


            ** DEĞİŞKEN İSİMLENDİRME(case sensitive)
            yanlışlar: 1sayi,?sayi,sayi!,ad-soyad,ad soyad
            doğrular:  sayi1,_sayi,sayi_,ad_soyad,adsoyad

            ** Bütün yazılım dillerinde geçerli olan tek özel karakter '_' alt çizgidir.
            
            Yazılımda bir yapıya isim verirken kullanılan yöntemler:
            lowercase : adsoyad
            uppercase : ADSOYAD
            camelcase : sgkGirisTarihi
            kebabcase : ad-soyad
            snakecase : ad_soyad
            
             */

            // Yazılım dillerinde küçük harf BÜYÜK HARF duyarlılığı vardır. Bu sebeple yapı isimlendirirken bir karakter farklı ise unique(benzersiz-özel) olur.
            // int sayi = 12;
            // int Sayi = 12;

            // Her değişken ismi UNIQUE olmalıdır. bu sebeple farklı datalar tutacak değişkenler farklı isimlendirilmelidir.
            //İki kardeşin yaşlarını topla
            // int yas1 = 34;
            // int yas2 = 27;


            //Miray'ın Yaşi
            //int yas = 22;
            //yas = 23;
            //int yas3 = 44;

            //Console.WriteLine(yas);
            //Console.WriteLine(yas3);
            //Console.WriteLine(yas+"           "+yas3);


            //char harf = 'A';
            //char krkt = '?';
            //char rakam = '1';

            //Console.WriteLine(rakam);
            //!!! char değer bir işleme tabi tutulursa girilen değerin ASCII kodunu getirir. 
            //Console.WriteLine(12 + rakam);



            #endregion


            #region VERİ TİPLERİ

            /*
             ********* VERİ TİPLERİ (DATA TYPES) *********
            Sayısal Tipler:
                Tam Sayı Tipleri(INTEGER) : sbyte,byte,short,ushort,int,uint,long,ulong
                    short yas = 34;
                    int sayi = 121342331;
                    long sayi2 = 12345678909;

            Ondalıklı Sayı Tipleri(FLOAT): float,double
            DECIMAL : decimal
               //Değer atama işleminde = sağ ve sol tarafını karşılaştırır.

                    // = 150.50 tanım double bir ondalıklı sayıdır eğer float tipde bir değişkene atanacak ise sonuna 'F' konularak değerin float olduğu belirtilmelidir.
                    float bakiye = 150.50f;
                    double bakiye1 = 150.55;

            Console.WriteLine(bakiye+bakiye1);


            decimal sayi = 13242342432423;
            // = 150.50 tanım double bir ondalıklı sayıdır eğer decimal tipde bir değişkene atanacak ise sonuna 'M' konularak değerin decimal olduğu belirtilmelidir.
            decimal sayi2 = 150.50M;

            Sözel Tipler(STRING):
                char: Tek bir karakter ' tek tırnak ile tanımlanır.
                string: Ram bellek boyutunda karakter alır ve " çift tırnak ile tanımlanır.
                       //string bir değer '+' operatorü yardımıyla sayısal bir değer ile yanyana yazılırsa birleştirme(Concat) işlemi yapar. 
                       //string bir değer '+' operatorü yardımıyla string bir değer ile yanyana     yazılırsa birleştirme(Concat) işlemi yaar. 
                       //string rakam2 = "12";
                       //Console.WriteLine(12+rakam2);

                        //string ad = "Altan";
                        //string soyad = "Emre";
                        //Console.WriteLine(ad+" "+soyad);
            Mantıksal Tipler(BOOLEAN):
                bool: Sadece TRUE ve FALSE değerleri alır.
             */


            //bool cevap = true;
            //bool cevap2 = false;

            //bool sonuc = 5 > 3;

            #endregion


            #region KAPSAM - SCOPE
            //int b = 10;
            //{
            //    int a = 5;
            //    b = 15;
            //    Console.WriteLine(b); //15
            //}
            //{
            //    Console.WriteLine(b); // 15
            //}







            //{
            //    int a;
            //    {
            //        int b;
            //    }

            //    a = 20;
            //    b = 10;
            //}


            #endregion


            // CONSTANT - Sabit değişken: Tanımlandıktan sonra revizeye kapalı.

            const int sayi = 5; 
            //sayi = 19;
        }               
    }
}
