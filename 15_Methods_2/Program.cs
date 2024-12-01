namespace _15_Methods_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //static: Bir tanımın class üzerinden direk erişilebilir kılar.

            Matematik.Topla();

            Matematik m = new Matematik(); //Instance - Örneklem
            m.Cikar();

        }
    }

    class Matematik
    {
        //Static Method
        internal static void Topla()
        {
            Console.WriteLine("1.sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sonuç:" + (sayi1 + sayi2));
        }

        //NonStatic Method
        internal void Cikar()
        {
            Console.WriteLine("1.sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sonuç:" + (sayi1 - sayi2));
        }

    }


}
