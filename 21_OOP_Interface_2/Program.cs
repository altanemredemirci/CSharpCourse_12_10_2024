namespace _21_OOP_Interface_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Şirket:
            // Personel: Id,Departman,ToplamCalismaSaati,AdSoyad,Adres,Maas
            // Robot : Id,Departman,ToplamCalismaSaati
            // Mudur: Id,Departman,ToplamCalismaSaati,AdSoyad,Adres,Maas,PersonelSayisi
        }
    }


    //Interface her entity ulaşabileceği,içinde bir değer ataması veya metot gövdesi tanımlanmayan bir programlama arayüzüdür. Bu sebeple herkese açık olduğu için private gibi kısıtlamaları kabul etmez.
    interface ICalisan
    {
        protected int Id { get; set; }
        string Departman { get; set; }
        long ToplamCalismaSaati { get; set; }
    }

    interface IKisi
    {
        string AdSoyad { get; set; }
        string Adres { get; set; }
        long Maas { get; set; }
    }

    class Robot : ICalisan
    {
        public int Id { get; set; }
        public string Departman { get; set; }
        public long ToplamCalismaSaati { get; set; }
    }

    class Personel : ICalisan, IKisi
    {
        public int Id { get; set; }
        public string Departman { get; set; }
        public long ToplamCalismaSaati { get; set; }
        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public long Maas { get; set; }
    }

    class Mudur : ICalisan, IKisi
    {
        public int Id { get; set; }
        public string Departman { get; set; }
        public long ToplamCalismaSaati { get; set; }
        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public long Maas { get; set; }
        public int personelSayisi { get; set; }
    }
}
