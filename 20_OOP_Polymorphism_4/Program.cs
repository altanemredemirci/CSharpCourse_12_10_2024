namespace _20_OOP_Polymorphism_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = Math.PI;
            //Console.WriteLine(PI);

            DikDortgen dikDortgen = new DikDortgen(10,5);
            Console.WriteLine(dikDortgen.Alan());

            Daire daire = new Daire(10);
            Console.WriteLine(daire.Alan());

        }
    }
    public class Sekil
    {
        public const double PI = Math.PI; //Constant: Sabit değişken. Math C# da matematik kütüphanesidir.

        protected double x; //Sadece Şekil sınıfını miras alan sınıflar kendi içinde x ve y özelliklerine erişebilir.
        protected double y;

        public Sekil(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual double Alan()
        {
            return x * y;
        }
    }

    public class DikDortgen : Sekil
    {
        public DikDortgen(double a, double b) : base(a, b)
        {

        }
    }

    public class Daire : Sekil
    {
        public Daire(double r) : base(r, 0)
        {

        }

        public override double Alan()
        {
            return PI * x * x;
        }
    }

    public class Kure : Sekil
    {
        public Kure(double r) : base(r, 0)
        {

        }

        public override double Alan()
        {
            return 4 * PI * x * x;
        }
    }
}


