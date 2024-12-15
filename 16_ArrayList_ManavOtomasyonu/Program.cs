using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace _16_ArrayList_ManavOtomasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Meyve: Id,Ad,Stok,Fiyat
            //Sebze: Id,Ad,Stok,Fiyat
            #region 1.Yol
            //List<Meyve> meyves = new List<Meyve>();

            //Meyve m = new Meyve();
            //m.Id = 1;
            //m.Ad = "Elma";
            //m.Fiyat = 30;
            //m.Stok = 100;

            //Meyve m1 = new Meyve();
            //m1.Id = 2;
            //m1.Ad = "Armut";
            //m1.Fiyat = 40;
            //m1.Stok = 100;

            //meyves.Add(m);
            //meyves.Add(m1);
            #endregion

            #region 2.Yol

            List<Meyve> meyves = new List<Meyve>()
            {
                new Meyve(){Id=1,Ad="Elma",Stok=100,Fiyat=30},
                new Meyve(){Id=2,Ad="Armut",Stok=100,Fiyat=35},
                new Meyve(){Id=3,Ad="Kiraz",Stok=100,Fiyat=37.5},
                new Meyve(){Id=4,Ad="Muz",Stok=100,Fiyat=42.5},
                new Meyve(){Id=5,Ad="Karpuz",Stok=100,Fiyat=50}
            };

            List<Sebze> sebzes = new List<Sebze>()
            {
                new Sebze(){Id=1,Ad="Biber",Stok=100,Fiyat=30},
                new Sebze(){Id=2,Ad="Domates",Stok=100,Fiyat=35},
                new Sebze(){Id=3,Ad="Patates",Stok=100,Fiyat=37.5},
                new Sebze(){Id=4,Ad="Soğan",Stok=100,Fiyat=42.5},
                new Sebze(){Id=5,Ad="Patlıcan",Stok=100,Fiyat=50}
            };

            #region Object Oluşturma Yöntemi-1
            //Meyve m = new Meyve();
            //m.Id = 1;
            //m.Ad = "Elma";
            //m.Fiyat = 30;
            //m.Stok = 100;
            #endregion

            #region Object Oluşturma Yöntemi-2
            //Meyve m1 = new Meyve()
            //{
            //    Id = 2,
            //    Ad = "Armut",
            //    Fiyat = 40,
            //    Stok = 100
            //};

            #endregion

            #endregion

            List<Meyve> manavMeyves = new List<Meyve>();
            List<Sebze> manavSebzes = new List<Sebze>();
            List<Meyve> musteri = new List<Meyve>();

            while (true)
            {
                Console.WriteLine("    HALE HOŞGELDİNİZ    ");
                string anaSecim = MeyveSebzeSecim();

                if (anaSecim == "M")
                {
                    Meyve.UrunSatis(meyves, manavMeyves);
                }
                else
                {
                    Sebze.UrunSatis(sebzes, manavSebzes);
                }

                Console.WriteLine("Başka Arzunuz Var mı?(E/H)");
                string cevap = Console.ReadLine().ToLower();
                if (cevap != "e")
                {
                    break;
                }
            }
            while (true)
            {
                Console.WriteLine("    MANAVA HOŞGELDİNİZ    ");
                string anaSecim = MeyveSebzeSecim();

                if (anaSecim == "M")
                {
                    if (manavMeyves.Count == 0)
                    {
                        Console.WriteLine("Meyveler Tükenmiştir.");
                    }
                    else
                    {
                        foreach (Meyve meyve in manavMeyves)
                        {
                            Console.WriteLine($"{meyve.Id}-{meyve.Ad}:{meyve.Fiyat}");
                        }

                        Console.WriteLine("İstenilen Ürün Kodu:");
                        int secim = Convert.ToInt32(Console.ReadLine());

                        Meyve urun = new Meyve();
                        foreach (Meyve meyve in manavMeyves)
                        {
                            if (meyve.Id == secim)
                            {
                                urun = meyve;
                            }
                        }

                        if (urun == null)
                        {
                            Console.WriteLine("Hatalı Seçim!!");
                        }
                        else
                        {
                            Console.WriteLine("Kaç kilo");
                            int kilo = Convert.ToInt32(Console.ReadLine());

                            if (urun.Stok >= kilo)
                            {
                                urun.Stok -= kilo;
                                Meyve alinanUrun = new Meyve();
                                alinanUrun.Ad = urun.Ad;
                                alinanUrun.Stok = kilo;
                                alinanUrun.Fiyat = urun.Fiyat;
                                alinanUrun.Id = urun.Id;
                                musteri.Add(alinanUrun);
                            }
                            else
                            {
                                Console.WriteLine($"Elimizde {urun.Stok} kg {urun.Ad} var.");
                            }
                        }
                    }
                }
                else
                {

                }

                Console.WriteLine("Başka Arzunuz Var mı?(E/H)");
                string cevap = Console.ReadLine().ToLower();
                if (cevap != "e")
                {
                    break;
                }
            }  
        }

        static string MeyveSebzeSecim()
        {
            Console.WriteLine("Meyve mi Sebze mi(M/S)?");
            string anaSecim = Console.ReadLine().ToUpper();
            
            if(anaSecim=="M" || anaSecim=="S")
            {
                return anaSecim;
            }            
            Console.WriteLine("Hatalı Seçim!!");
            return MeyveSebzeSecim();
        }

      
    }

    class Meyve
    {
        internal int Id;
        internal string Ad;
        internal int Stok;
        internal double Fiyat;

        internal static void UrunSatis(List<Meyve> meyveList, List<Meyve> manavMeyve)
        {
            foreach (Meyve meyve in meyveList)
            {
                Console.WriteLine($"{meyve.Id}-{meyve.Ad}:{meyve.Fiyat}");
            }

            Console.WriteLine("İstenilen Ürün Kodu:");
            int secim = Convert.ToInt32(Console.ReadLine());

            #region LINQ-İleriSorgulamaTekniği
            //var urun;
            //foreach (var i in meyves)
            //{
            //    if (i.Id == secim)
            //    {
            //        urun = i;
            //    }
            //}
            #endregion

            Meyve urun = meyveList.FirstOrDefault(i => i.Id == secim);

            if (urun != null)
            {
                Console.WriteLine("Kaç Kilo?");
                int kilo = Convert.ToInt32(Console.ReadLine());

                if (urun.Stok >= kilo)
                {
                    urun.Stok -= kilo;

                    Meyve alinanUrun = new Meyve();
                    alinanUrun.Ad = urun.Ad;
                    alinanUrun.Stok = kilo;
                    alinanUrun.Fiyat = urun.Fiyat * 1.10;
                    alinanUrun.Id = urun.Id;

                    manavMeyve.Add(alinanUrun);
                }
                else
                {
                    Console.WriteLine($"Elimizde {urun.Stok} kg {urun.Ad} var.");
                }
            }
            else
            {
                Console.WriteLine("Yanlış Ürün Seçimi!!");
            }

            Console.WriteLine("Tekrar Seçmek İster misiniz?(E/H)");
            string cevap = Console.ReadLine().ToLower();
            if (cevap == "e")
            {
                UrunSatis(meyveList, manavMeyve);
            }

        }


    }

    class Sebze
    {
        internal int Id;
        internal string Ad;
        internal int Stok;
        internal double Fiyat;

        internal static void UrunSatis(List<Sebze> sebzeList, List<Sebze> manavSebze)
        {
            foreach (Sebze sebze in sebzeList)
            {
                Console.WriteLine($"{sebze.Id}-{sebze.Ad}:{sebze.Fiyat}"); //1-Patlıcan:55
            }

            Console.WriteLine("İstenilen Ürün Kodu:");
            int secim = Convert.ToInt32(Console.ReadLine());

            Sebze urun = sebzeList.FirstOrDefault(i => i.Id == secim);

            if (urun != null)
            {
                Console.WriteLine("Kaç Kilo?");
                int kilo = Convert.ToInt32(Console.ReadLine());

                if (urun.Stok >= kilo)
                {
                    urun.Stok -= kilo;

                    Sebze alinanUrun = new Sebze();
                    alinanUrun.Ad = urun.Ad;
                    alinanUrun.Stok = kilo;
                    alinanUrun.Fiyat = urun.Fiyat * 1.10;
                    alinanUrun.Id = urun.Id;

                    manavSebze.Add(alinanUrun);

                }
                else
                {
                    Console.WriteLine($"Elimizde {urun.Stok} kg {urun.Ad} var.");
                }
            }
            else
            {
                Console.WriteLine("Yanlış Ürün Seçimi!!");
            }

            Console.WriteLine("Tekrar Almak İster misiniz?(E/H)");
            string cevap = Console.ReadLine().ToLower();
            if (cevap == "e")
            {
                UrunSatis(sebzeList, manavSebze); //recursive method
            }

        }

    }
}
