namespace _15_Methods_5
{
    internal class Program
    {
        string soyisim = "Bayrak";
        static void Main(string[] args)
        {
            Yazdir("Berat", "Efe");
            Yazdir("Altan");
        }

        //soyisim parametresine default olarak Demirci datası verildi. Eğer metot çağrılırken soyisim gönderilmezse Demirci, gönderilirse gönderilen değer alınır.
        static void Yazdir(string isim, string soyisim="Demirci")
        {
            Console.WriteLine(isim+" "+soyisim);
        }
    }
}
