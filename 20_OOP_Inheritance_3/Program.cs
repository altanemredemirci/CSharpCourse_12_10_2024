namespace _20_OOP_Inheritance_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci o = new Ogrenci();
            o.Ad = "Altan Emre";
            o.Soyad = "Demirci";
            o.OkulAd = "Kemal Hasoğlu İ.Ö.O";

            o.Yaz();
        }
    }
    class Insan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public void Yaz()
        {
            Console.WriteLine(Ad+" "+Soyad);
        }
    }
    
    class Ogrenci : Insan
    {
        public string OkulAd { get; set; }

        //Base den alınan bir miras özelliğinin türeyen sınıfta tekrardan tanımlanması için base den gelen özelliğin gizlenmesi gerekir.Bunun için ise 'new' keyword kullanılır. Bu Varolan göz'e lens takmak gibi bir durum.
        public new void Yaz() // NameHiding
        {
            Console.WriteLine(Ad + " " + Soyad + " " + OkulAd);
        }
    }
}
