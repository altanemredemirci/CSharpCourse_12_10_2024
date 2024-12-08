namespace _19_Class_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bir okul sisteminde öğrenci kaydı yapan bir otomasyon geliştiriniz.
            // Öğrenci: No,Ad,Soyad,Sınıf,TC,Adres bilgileri alınarak kayıt yapılacak.

            Ogrenci o = new Ogrenci();
            o.Ad = "Altan Emre";
            o.Soyad = "Demirci";
            o.TC = "123";




        }
    }
    class Ogrenci
    {
        internal int No;
        internal string Ad;
        internal string Soyad;
        internal string TC;
        internal string Sinif;
        internal string Adres;
    }



}
