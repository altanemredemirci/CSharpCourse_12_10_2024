namespace _15_Methods_6_Overload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Overload:Aşırı Yüklenme
            //Aynı isimde farklı işlemler yapan methodlara overload
            //Overload metotların metot imzaları farklı olmalıdır.
            //Metot İmzası: Parametre veri tipi ve Parametre sayısı

            Topla();
           
        }

        static void Topla(int s1,int s2)
        {
            Console.WriteLine(s1 + s2);
        }
         
        static void Topla(double s1, int s2)
        {
            Console.WriteLine(s1 + s2);
        }

        static void Topla(int s1, double s2)
        {
            Console.WriteLine(s1 + s2);
        }

        static void Topla(double s1, double s2)
        {
            Console.WriteLine(s1 + s2);
        }

        static void Topla(int s1, int s2, int s3)
        {
            Console.WriteLine(s1 + s2 + s3);
        }

    }
}
