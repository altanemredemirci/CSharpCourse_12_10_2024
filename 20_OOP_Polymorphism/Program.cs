namespace _20_OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             POLYMORPHISM NEDİR? 

            Çokbiçimlilik (Polymorphism) bir nesnenin farklı amaçlar için de kullanılabileceği anlamına gelir ve statik, dinamik olmak üzere ikiye ayrılır.

                * Statik çokbiçimlilik; metot ve operatörlerin aşırı yüklenmesi (overload) olarak belirtilir.
                * Dinamik çokbiçimlilik; özet sınıflardan miras alma yoluyla işlemlerin gerçekleştirilmesi işlemine verilen isimdir.

            Statik çokbiçimlilik türünden, metotların aşırı yüklenmesine yönelik bir çalışma yapacağız.
                                  
            Dinamik çokbiçimlilik türünden, metodu override etmeliyiz.

            VIRTUAL() METODU

            *Temel sınıfa ait bir metodun bazen türemiş sınıfta farklı bir şekilde kullanılması gerekebilir. Bu durumda temel sınıfın söz konusu metodu türemiş sınıfın değiştirip kullanabileceği yönünde izin vermesi gerekir. Bu izin, metodun temel sınıfta “virtual” olarak tanımlanması sonucu verilmektedir. Diğer bir ifadeyle temel sınıfta “virtual” olarak tanımlanmış bir metodun türemiş sınıfta yeniden yazılabileceği belirtilmiş olunuyor.


            METODU OVERRIDE ETMEK, OVERRIDE NEDİR?METOTUN EZİLMESİ

            *Temel sınıfta “virtual” tanımlanmış bir metodun türemiş sınıfta yeniden yazılması için (geçersiz kılma) “override” sözcüğü kullanılır. 
             *Temel sınıfta “virtual” tanımlanmamış ya da “static” tanımlanmış olan üyeler (metot, özellik, dizinleyici ya da olay) türemiş sınıfta yeniden yazılamaz (Geçersiz kılınamaz.).

            Ayrıca temel sınıfta “virtual”, “abstract” ya da “override” olarak tanımlanmış
            metotlar türemiş sınıfta geçersiz kılınabilir.
            Bir diğer önemli nokta da “override” metotlar “new”, “static” ya da “virtual”
            sözcükleri ile tanımlanamaz.

            Son olarak “virtual” metodun erişim belirteci “override” sırasında değiştirilemez.
            Yani temel sınıfta metot “public” ise türemiş sınıfta da “public”, “protected” ise “protected” kalmalıdır.
            */

            Lise lise = new Lise();
            lise.Kayit();

        }
        #region Statik Polimorfizm
        static void Topla()
        {
            Console.WriteLine("1.Sayı:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Toplam:"+(sayi+sayi2));
        }

        static int Topla(int sayi, int sayi2)
        {
            return sayi + sayi2;
        }

        static int Topla(int sayi, int sayi2, int sayi3)
        {
            return sayi + sayi2 + sayi3;
        }
        #endregion
    }

    class Ogrenci
    {
        public int No { get; set; }
        public string Ad { get; set; }

        public virtual void Kayit()
        {
            Console.WriteLine("No:");
            No = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ad:");
            Ad = Console.ReadLine();
        }
    }

    class Lise:Ogrenci
    {
        public string Bolum { get; set; }

        public override void Kayit() //override(ezme): Bir tanımı yeniden biçimlendirmek anlamına gelir.
        {
            base.Kayit();
            Console.WriteLine("Bölüm:");
            Bolum = Console.ReadLine();
        }
    }
}
