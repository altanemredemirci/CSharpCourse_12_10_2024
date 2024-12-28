namespace _20_OOP_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               // INHERITANCE - KALITIM
            // Ortak özelliklere sahip classların tek bir class üzerinden miras alma yöntemi ile ortak olan özellikleri yazılmadan çekmesine ve sadece kendisine özel olan özellikleri tanımlamasına denir.

            *** Her class TEK BİR CLASS'tan miras(inheritance) alabilir.
            *

             */

            //ŞİRKET:MUH,IK,IT,PAZ
            //MUH: Id,Ad,Soyad,TC,SGKNo,Maas,HesapSayisi
            //PAZ: Id,Ad,Soyad,TC,SGKNo,Maas,TeklifSayisi
            //IT: Id,Ad,Soyad,TC,SGKNo,Maas,ProgramSayisi
            //IK: Id,Ad,Soyad,TC,SGKNo,Maas,PersonelSayisi

            IK ik = new IK();
            
        }
    }

    class Personel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public string SGKNo { get; set; }
        public double Maas { get; set; }
    }

    class IK:Personel
    {
        public int PersonelSayisi { get; set; }
    }
    class IT:Personel
    {
        public int ProgramSayisi { get; set; }
    }
    class PAZ:Personel
    {
        public int TeklifSayisi { get; set; }
    }
    class MUH: Personel
    {
        public int HesapSayisi { get; set; }
    }
}
