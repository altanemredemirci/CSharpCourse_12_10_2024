namespace _19_Class_Object_2_Enum
{
    //Enum : Sabit Veri Tipi
    enum Markalar { Mercedes=1,BMW,Mazda,Ford,Renault}

    // Enum olarak tanımlanan veri tipleri default olarak 0 dan başlayarak 1'er 1'er artarak numalandırılırlar ama istenilirse başlangıç değeri verilebilir.

    class Araba
    {
        public string Plaka { get; set; }
        public double Fiyat { get; set; }
        public Markalar Marka { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba(); //Instance - Örneklem

            araba.Marka = Markalar.Mazda;
            araba.Fiyat = 1000000;
            araba.Plaka = "34 TE 2447";

            Console.WriteLine(araba.Marka);
        }
    }

    
}
