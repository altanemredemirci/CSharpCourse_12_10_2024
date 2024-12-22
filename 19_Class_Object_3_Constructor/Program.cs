namespace _19_Class_Object_3_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GARBAGE COLLECTOR : C# diline ait bir özelliktir. Bütün kodlar,değişkenler,metotlar her yapı RAM bellekte tutulur. Ram bellek belirli bir doluluğa ulaştığında en eski veya en az kullanılan tanımlanmış yapıyı veya yapıları bellekten siler. Bu ram bellekte hem yer açar hemde program daha performanslı çalışır.

            //CONSTRUCTOR METHOD
            /*
            Class ile aynı isme sahiptir.
            Herhangi bir değer döndürme veya void keyword lerini almaz.
            Default olarak boş tanımlıdır ve gizlidir.
            Classtan Instance alındığında çalışır.
             */

            //Customer customer = new Customer();
            Customer customer = new Customer(1, "Altan", "Emre");

            Console.WriteLine(customer.Isim);
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }

        public Customer()
        {
            Kayit();
        }

        public Customer(int no,string ad,string soyad)
        {
            Id = no;
            Isim = ad;
            Soyisim = soyad;
        }

        internal void Kayit()
        {
            Console.WriteLine("Id:");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Isim:");
            Isim = Console.ReadLine();
            Console.WriteLine("Soyisim:");
            Soyisim = Console.ReadLine();
        }
    }
}
