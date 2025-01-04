namespace _20_OOP_Polymorphism_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Tekstil    : Ad,Fiyat,KumasTuru,Beden,UreticiFirma - KDVUygula(%20)
            CepTelefonu: Ad,Fiyat,Ozellikler,Marka - KDVUygula(%120)
            Ekmek      : Ad,Fiyat,EkmekTuru,Gramaj - KDVUygula(%20)

            Nesne ozelliklerini Contructor method ile alın.

            Sepet : Alınan urunleri bir listeye kaydetsin, Toplamtutarı söylesin

             */

            Ekmek ekmek = new Ekmek("Çavdar", 150, "ekmek", 100);
            CepTelefonu cepTelefonu = new CepTelefonu("Bluetooth", "Huawei", "Huawei", 30000);

            Sepet s = new Sepet(); //s object 
            s.Ekle(ekmek);
            s.Ekle(cepTelefonu);

            Console.WriteLine(s.ToplamTutar());

        }
    }

    class Urun
    {
        public string Ad { get; set; }
        public double Fiyat { get; set; }

        public Urun(string ad, double fiyat)
        {
            Console.WriteLine("");
            Ad = ad;
            Fiyat = fiyat;
        }

        public virtual double KdvUygula()
        {
            return Fiyat * 1.2;
        }
    }

    class Tekstil : Urun
    {
        public string KumasTuru { get; set; }
        public string Beden { get; set; }
        public string UreticiFirma { get; set; }

        public Tekstil(string kumasTuru, string beden, string ureticiFirma,string isim, double deger):base(isim, deger)
        {
            KumasTuru = kumasTuru;
            Beden = beden;
            UreticiFirma = ureticiFirma;
        }
    }

    class CepTelefonu : Urun
    {
        public string Ozellikler { get; set; }
        public string Marka { get; set; }

        public CepTelefonu(string ozellikler, string marka, string ad, double fiyat) : base(ad, fiyat)
        {
            Ozellikler = ozellikler;
            Marka = marka;
        }

        public override double KdvUygula()
        {
            return Fiyat * 2.2;
        }
    }

    class Ekmek : Urun
    {
        public string EkmekTuru { get; set; }
        public int Gramaj { get; set; }

        public Ekmek(string ekmekTuru, int gramaj,string ad, double fiyat) : base(ad, fiyat)
        {
            EkmekTuru = ekmekTuru;
            Gramaj = gramaj;
        }
    }

    class Sepet
    {
        private List<Urun> urunler = new List<Urun>();

        public double ToplamTutar()
        {
            double toplam = 0;

            foreach (Urun urun in urunler)
            {
                toplam += urun.Fiyat;
            }

            return toplam;
        }

        public void Ekle(Urun urun)
        {
            urun.Fiyat = urun.KdvUygula();
            urunler.Add(urun);
        }
    }
}
