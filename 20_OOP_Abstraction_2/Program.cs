namespace _20_OOP_Abstraction_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
        }
    }

    abstract class ElektronikEsya
    {
        public decimal AlisFiyat { get; set; }
        public decimal KarYuzdesi { get; set; }

        public abstract decimal FiyatHesapla();
    }

    class Telefon : ElektronikEsya
    {
        public decimal LisansUcreti { get; set; }

        public override decimal FiyatHesapla()
        {
            return AlisFiyat + (AlisFiyat * KarYuzdesi) + LisansUcreti;
        }
    }

    class Buzdolabi : ElektronikEsya
    {
        public override decimal FiyatHesapla()
        {
            return AlisFiyat + (AlisFiyat * KarYuzdesi);
        }
    }
}
