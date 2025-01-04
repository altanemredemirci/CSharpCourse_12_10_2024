namespace _20_OOP_Inheritance_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lise lise = new Lise();
            //lise.

            //Ogrenci ogrenci = new Ogrenci();
            //ogrenci.
        }
    }

    class Ogrenci
    {
        public int No { get; set; }
        protected string Ad { get; set; } // Kendi tanımlı olduğu class ve o classtan türeyen classlarda kullanılabilir.

        public void Kaydet()
        {
            Console.WriteLine(No+"-"+Ad);
        }
    }

    class Lise:Ogrenci
    {
        public string Bolum { get; set; }

        public void Yaz()
        {
            Console.WriteLine("Ad:"+Ad);
        }
    }
}
