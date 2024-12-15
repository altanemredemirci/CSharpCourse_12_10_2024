namespace _19_Class_Object_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Senaryo
            /*
           * TShirt:
              *Barkod
              *Beden
              *Renk
              *Fiyat

           * Tshirt ekleme()
           * Tshirt silme()
           * Tshirt günceleme()
           * Tshirt listele()
           * Tshirt listele(Expression) Expression i=> i.Id==1
           * Tshirt bulma()

           */
            #endregion

            List<Tshirt> tshirts = new List<Tshirt>();

            tshirts.Add(Tshirt.Create());

            tshirts.Add(Tshirt.Create());

            tshirts.Add(Tshirt.Create());
            
            tshirts.Add(Tshirt.Create());

            tshirts.Add(Tshirt.Create());

            Tshirt.List(tshirts);

            Console.WriteLine(Tshirt.Delete(tshirts));

            Tshirt.List(tshirts, i => i.Beden == "L");

            Console.WriteLine("*******");
            Tshirt.List(tshirts, i => i.Renk == "Sarı");

            var tshirt = Tshirt.Find(tshirts);

            if (tshirt != null)
            {
                Console.WriteLine(tshirt.Beden+ " "+tshirt.Renk);
            }
        }
    }


}
