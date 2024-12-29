namespace _19_Class_Object_5_Partial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Partial: Bir bütünün parçaları anlamına gelir. Tek başınada bir class gibi davranır.
            //Partial classlar aynı isimde olmak zorundadır.
            //Aynı isimdeki partiallar bir araya gelerek bir bütün oluşturur.
            Personel p = new Personel();
        }
    }

    partial class Personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Maas { get; set; }
    }
    
    partial class Personel
    {
        public string Departman { get; set; }
        public int CalismaSaati { get; set; }
    }
}
