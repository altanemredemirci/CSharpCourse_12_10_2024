namespace _20_OOP_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // OOP(Object Oriented Programming) -  Nesne Yönelimli Programlama

            // OOP 4 Temeli
            /* Encapsulation - Kapsülleme
             * Inheritance - Kalıtım
             * Polymorphism - Çok Biçimlilik
             * Abstraction - Soyutlama

             */

            /*
             Encapsulation amacı, Bir nesneye ait ana property nin kontrolsüz değer almasını engellemek.Çünkü ana property ler Veritabanında ve Program akışında güvenilir data sağlar.
               Bir nesnenin propertylerinde doğruluk kontrolü yapılması gerektiğinde kullanılan bir OOP yapısıdır.

            Property PRIVATE olarak tanımlanır ve dışarıdan direk kullanıma kapatılır.
            Aynı property'in benzer isimde PUBLIC olarak bir tanımı yapılır ve kullanıcıdan bu property'e data girişi yapması istenir. 
            Girilen Data SET keyword ile kontrol edilerek asıl property e atanır.
            Get keyword ü ile de asıl property okunur.
             */

            //Vatandas vatandas = new Vatandas();
            //vatandas._TC = 12345678932;

            //Console.WriteLine(vatandas._TC);


            // Bir Üniversite öğrencisinin vize ve final notları alınacaktır. Alınan notların 0-100 aralığı encapsulation ile kontrol edilecektir. Doğru girilene kadar notlar istenecektir.Doğru girilen not bir daha istenmeyecektir.İki notunda doğru girilmesi durumunda OrtalamaHesapla() metodu ile vizenin %40 final%60 alınarak ortalama öğrenciye gösterilecek.

            Universite universite = new Universite();
            Console.WriteLine("Vize:");
            universite._Vize = Convert.ToInt32(Console.ReadLine());
            universite._Final = 100;

            universite.OrtalamaHesapla();
        }
    }

    class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        private long TC;


        public long _TC
        {
            get { return TC; }
            set
            {
                if (value.ToString().Length == 11)
                {
                    TC = value;
                }
                else
                {
                    TC = 0;
                }
            }
        }
    }

    class Universite
    {
        private int Vize { get; set; }
        private int Final { get; set; }

        public int _Vize
        {
            get { return Vize; }
            set
            {
                if (value >= 0 && value < 101)
                {
                    Vize = value;
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine("Hatalı Not Aralığı!!");

                        Console.WriteLine("Vize notunuz:");
                        int vize = Convert.ToInt32(Console.ReadLine());

                        if (vize >= 0 && vize < 101)
                        {
                            Vize = vize;
                            break;
                        }
                    }
                }
            }
        }
        public int _Final
        {
            get { return Final; }
            set
            {
                if (value >= 0 && value < 101)
                {
                    Final = value;
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine("Hatalı Not Aralığı!!");

                        Console.WriteLine("Final notunuz:");
                        int final = Convert.ToInt32(Console.ReadLine());

                        if (final >= 0 && final < 101)
                        {
                            Final = final;
                            break;
                        }
                    }
                }
            }
        }

        public void OrtalamaHesapla()
        {
            Console.WriteLine("ORTALAMA:"+(Final*0.6+Vize*0.4));
        }
    }
}