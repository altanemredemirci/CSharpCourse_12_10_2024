namespace _01_Algoritma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tek satır açıklama

            /*
             Çoklu
                Satır
                    Açıklama
             */
            /* 
             C# => Microsoft firmasına ait bir OOP dilidir.
             OOP => Object Orientend Programming (Nesne Yönelimli Programlama)
            
             .NET => C# ile geliştirilen birden fazla tipdeki projeyi tek bir platform üzerinde yazmamızı ve aynı platform olduğu için farklı projelerin birbiri ile iletişim kurmasını sağlar.
              Framework => Yazılımcılar tarafından kullanıcılara sunulan hazır kod kütüphanesidir.


            BUILD: Kodlar yazılırken syntax(yazım kuralı) kontrolü yapar. Bağlı bulunduğu veya referans aldığı yapılar,tanımlar veya class'lar var ise erişilebiliyor mu? kontrollerini yapar.
            DEBUG: 
                - Build Kod hatası veya Yazım hatası
                - Kodu çalıştıracak donanımsal yeterlilik kontrolü
                - Compile -> Kod Makine koduna dönüştürülür.
                - Execute 
                - Result


            COMPILER - DERLEYİCİ : Koddaki hataları ayıklama ve önerilerde bulunma işlemi yapar.
            Visual Studio 2022

             */

            /*
             ALGORİTMA
            1- Giriş ve Çıkış belirli olmalıdır.
            2- Sonluluk: Her olasılık bir sonuca varmalıdır.
            3- Kesinlik: her işlem net ve açık bir dille belirtilmelidir.
            4- Etkinlik: Genellebilir ve modüler yazılmalıdır.
            5- Yüksek Performans,Düşük Maliyet,Zamandan Tasarruf
            */

            #region ÇAY DEMLEME
            /*
            1-Başla
            2-Mutfağa Git
            3-Çaydanlığa Su Koy
            4-Ocağı Yak
            5-Su Kaynadı Mı? T->7 F->6
            6-Bekle ->5
            7-Demliğe Çay Koy
            8-Çay Demlendi Mi? T->10 F->9
            9-Bekle -> 8
            10-Servis Et
            11-Bitti


            ** Su Kesikse
            ** Çay Yoksa
            ** Bakkal Kapalı
            
            1-Başla
            2-Mutfağa Git
            3-Su ve Çay var mı? T->9 F->4
            4-Bakkala Git
            5-Bakkal Açık Mı? T->7 F->6
            6-Başka Bakkala Git -> 5
            7-Eksikleri Al
            8-Eve Dön -> 2
            9-Çaydanlığa Su Koy
            10-Ocağı Yak
            11-Su Kaynadı Mı? T->13 F->12
            12-Bekle ->5
            13-Demliğe Çay Koy
            14-Çay Demlendi Mi? T->16 F->15
            15-Bekle -> 14
            16-Servis Et
            17-Bitti
            
             */
            #endregion

            #region Örnek2
            /*
          Kullanıcıdan iki sayı alın ve 2 sayının toplamını ekrana yazdırınız
         1-Başla
         2-Birinci sayıyı rakam olarak al
         3-ikinci sayıyı rakam olarak al
         4-Birinci ve ikinci sayıyı topla
         5-Ekrana yaz
         6-Bitti
          */
            //Console.WriteLine("1.sayıyı gir:");
            //int sayi1 =Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.sayıyı gir:");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(sayi2+sayi1);
            #endregion


            /*  Evden ÜÇÜNCÜ BİNYIL AKADEMİ ye gelme algoritması 
            1-Başla
            2-Daire Çık
            3-Asansör Mü? Merdiven Mi? A->4 M-12
            4-Asansör katta mı? T->7 F->5
            5-Asansörü Çağır
            6-Bekle -> 4
            7-Asansöre Bin
            8-istenilen kat tuşuna Bas
            9-istenilen kata geldi mi? T->11 F->10
            10-Bekle ->9
            11-Asansörden İn ->14
            12-Bir Kat İn
            13-istenilen katta mıyız? F->12 T->14
            14-Binadan Çık



            15-Akbil Dolu Mu? T->17 F->16
            16-Telefondan Doldur.
            17-Toplu Taşıma Durağına Git
            18-Toplu Taşıma geldi mi? T->20 F->19
            19-Bekle -> 18
            20-Toplu Taşımaya Bin
            21-Akbil bas
            22-Boş yer var mı? F->23 T->24
            23-Ayakta Git -> 25 
            24-Otur
            25-İnilecek durağa geldik mi? T->27 F->26
            26-Bekle ->25
            27-Toplu Taşımadan in
            28-Akademiye yürü
            29-Bitti
             */
        }
    }
}
