namespace _15_Methods_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 11;
            int sayi2 = 12;
            int sonuc = Matematik.Topla(sayi1,sayi2);
            Console.WriteLine(sonuc);

            Console.WriteLine(Matematik.Topla());
        }
    }

    class Matematik
    {
        /// <summary>
        /// İki sayının toplam işlemi
        /// </summary>
        /// <param name="s1">1.int sayı</param>
        /// <param name="s2">2.int sayı</param>
        /// <returns>İki sayının toplamındaki int sonuç</returns>
        /// 
        internal static int Topla(int s1, int s2)
        {     
            int toplam = s1 + s2;
            return toplam;
        }




        internal static int Topla()
        {
            Console.WriteLine("1.sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

           int toplam= sayi1 + sayi2;
            return toplam;
        }

           
        internal int Cikar()
        {
            Console.WriteLine("1.sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            return sayi1 - sayi2;
        }
    }


}
