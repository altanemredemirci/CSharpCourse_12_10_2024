namespace _20_OOP_Inheritance_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            C c = new C("0 Rh(-)");



            //Temel Sınıf: Kalıtım alınan ve ortak özellikleri barındıran sınıftır. base keyword ile temsil edilir.
            //Türeyen Sınıf: Temel sınıftan miras alma işlemi ile temek sınıfın özelliklerine ve kendisine ait özelliklere sahip bir sınıftır.

            //base class:A
            //türeyen class:B

            //B b = new B();
            //Console.WriteLine(b.kanGrubu);

            Ogretmen ogretmen = new Ogretmen();
        }
    }

    class Vatandas
    {
        public int Tc { get; set; }

        public Vatandas(int Tc)
        {
            this.Tc = Tc;
        }

        //overload
        public Vatandas()
        {
            
        }
    }

    class Ogretmen:Vatandas
    {
        public int Maas { get; set; }
    }
    class Mudur:Ogretmen
    {
        
    }
}
