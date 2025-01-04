namespace _20_OOP_Polymorphism_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class Insan
    {
        public int Boy { get; set; }
        public int Agirlik { get; set; }

        public virtual void Kayit()
        {
            Console.WriteLine("Boy:");
            Boy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ağırlık:");
            Agirlik = Convert.ToInt32(Console.ReadLine());
        }
    }
    class Ogrenci:Insan
    {
        public int No { get; set; }
        public string Ad { get; set; }

        public override void Kayit()
        {
            base.Kayit();
            Console.WriteLine("No:");
            No = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ad:");
            Ad = Console.ReadLine();
        }
    }

    class Lise : Ogrenci
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
