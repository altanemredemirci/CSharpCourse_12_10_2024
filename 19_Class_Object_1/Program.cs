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

            #region TSHIRT
            //List<Tshirt> tshirts = new List<Tshirt>();

            //tshirts.Add(Tshirt.Create());

            //tshirts.Add(Tshirt.Create());

            //tshirts.Add(Tshirt.Create());

            //tshirts.Add(Tshirt.Create());

            //tshirts.Add(Tshirt.Create());

            //Tshirt.List(tshirts);

            //Console.WriteLine(Tshirt.Delete(tshirts));

            //Tshirt.List(tshirts, i => i.Beden == "L");

            //Console.WriteLine("*******");
            //Tshirt.List(tshirts, i => i.Renk == "Sarı");

            //var tshirt = Tshirt.Find(tshirts);

            //if (tshirt != null)
            //{
            //    Console.WriteLine(tshirt.Beden + " " + tshirt.Renk);
            //}
            #endregion


            List<Buzdolabi> Properties_B = new List<Buzdolabi>();
            List<Camasir_Makinesi> Properties_C = new List<Camasir_Makinesi>();


            Console.WriteLine("Buzdolabi özellikleri:\n");

            Properties_B.Add(Buzdolabi.Ekle());

            Console.Clear();
            Console.WriteLine("Çamaşır makinesi özellikleri:\n");

            Properties_C.Add(Camasir_Makinesi.Ekle());

            Console.Clear();

            Buzdolabi.List(Properties_B);
            Camasir_Makinesi.List(Properties_C);
        }
    }

    // BeyazEsya:Buzdolabı(Id,Marka,Model,Enerji,Fiyat)
    // Çamaşır Makinesi(Id,Marka,Model,Kapasite,Fiyat)
}
