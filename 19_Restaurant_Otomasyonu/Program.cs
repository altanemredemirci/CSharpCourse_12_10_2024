using System.Collections;

namespace _19_Restaurant_Otomasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Masa> masas = new List<Masa>();

            Masa m1 = new Masa();
            m1.Kapasite = 5;
            m1.Id = 1;

            masas.Add(m1);
            
            List<Masa> masalar = new List<Masa>()
            {
                new Masa(){Id=1,Kapasite=5},
                new Masa(){Id=2,Kapasite=6},
                new Masa(){Id=3,Kapasite=7},
                new Masa(){Id=4,Kapasite=3},
                new Masa(){Id=5,Kapasite=4}
            };

            Menu menu1 = new Menu()
            {
                Id=1,
                Ad="Çorbalar",
                Yemekler=new List<Yemek>() 
                { 
                    new Yemek(){Id=1,Ad="Mercimek",Fiyat=100},
                    new Yemek(){Id=2,Ad="Yayla",Fiyat=80},
                    new Yemek(){Id=3,Ad="Ezogelin",Fiyat=105}
                }
            };
            Menu menu2 = new Menu()
            {
                Id = 2,
                Ad = "Makarnalar",
                Yemekler = new List<Yemek>()
                {
                    new Yemek(){Id=1,Ad="Bolanezli Soslu",Fiyat=1000},
                    new Yemek(){Id=2,Ad="Spagetti",Fiyat=450},
                    new Yemek(){Id=3,Ad="Köri Soslu",Fiyat=850}
                }
            };
            Menu menu3 = new Menu()
            {
                Id = 3,
                Ad = "Salatalar",
                Yemekler = new List<Yemek>()
                {
                    new Yemek(){Id=1,Ad="Sezar",Fiyat=300},
                    new Yemek(){Id=2,Ad="Mevsim",Fiyat=450},
                    new Yemek(){Id=3,Ad="Çoban",Fiyat=550.50}
                }
            };
            Menu menu4 = new Menu()
            {
                Id = 4,
                Ad = "Etler",
                Yemekler = new List<Yemek>()
                {
                    new Yemek(){Id=1,Ad="Biftek",Fiyat=2000},
                    new Yemek(){Id=2,Ad="Pirzola",Fiyat=2450},
                    new Yemek(){Id=3,Ad="Lokum",Fiyat=5500}
                }
            };
            Menu menu5 = new Menu()
            {
                Id = 5,
                Ad = "Balıklar",
                Yemekler = new List<Yemek>()
                {
                    new Yemek(){Id=1,Ad="Çupra",Fiyat=2000},
                    new Yemek(){Id=2,Ad="Levrek",Fiyat=2450},
                    new Yemek(){Id=3,Ad="Somon",Fiyat=5500}
                }
            };
            Menu menu6 = new Menu()
            {
                Id = 6,
                Ad = "İçecekler",
                Yemekler = new List<Yemek>()
                {
                    new Yemek(){Id=1,Ad="Ayran",Fiyat=2000},
                    new Yemek(){Id=2,Ad="Şalgam",Fiyat=2450},
                    new Yemek(){Id=3,Ad="Rakı",Fiyat=5500}
                }
            };
            List<Menu> menuler = new List<Menu>() { menu1, menu2, menu3, menu4, menu5, menu6 };

            while (true)
            {
                Console.WriteLine("1-Sipariş Al\n2-Hesap Al\nSeçim:");
                string anaSecim = Console.ReadLine();

                if (anaSecim == "1")
                {
                    Console.WriteLine("Müşteri Kaç Kişi?");
                    int kisiSayisi = Convert.ToInt32(Console.ReadLine());
                    Masa musteriMasa = new Masa();
                    foreach (var masa in masalar)
                    {
                        if (masa.BosMu && masa.Kapasite >= kisiSayisi)
                        {
                            masa.BosMu = false;
                            musteriMasa = masa;
                            break;
                        }
                    }
                    if (musteriMasa.BosMu)
                    {
                        Console.WriteLine("Bütün masalar dolu!");
                        continue;
                    }
                    
                    while(kisiSayisi>0)
                    {
                        foreach (Menu menu in menuler)
                        {
                            Console.WriteLine(menu.Id+"-"+menu.Ad);
                        }
                        Console.WriteLine("Menü Seç:");
                        int id = Convert.ToInt32(Console.ReadLine());

                        var menuSecim = menuler.Where(i => i.Id == id).FirstOrDefault();

                        if (menuSecim == null)
                        {
                          
                            continue;
                        }

                        foreach (Yemek yemek in menuSecim.Yemekler)
                        {
                            Console.WriteLine(yemek.Id+"-"+yemek.Ad+":"+yemek.Fiyat);
                        }

                        Console.WriteLine("Yemek Seçimi:");
                        int yemekId = Convert.ToInt32(Console.ReadLine());

                        var yemekSecim = menuSecim.Yemekler.FirstOrDefault(i => i.Id == yemekId);
                        if (yemekSecim == null)
                        {
                            Console.WriteLine("Hatalı Yemek Seçimi!!");
                            continue;
                        }

                        musteriMasa.Siparis.Add(yemekSecim);
                        musteriMasa.Hesap += yemekSecim.Fiyat;
                        Console.WriteLine("Başka bir arzunuz var mı?(E/H)");
                        string arzu = Console.ReadLine().ToUpper();
                        if (arzu == "E")
                        {
                            continue;
                        }
                        kisiSayisi--;
                    }

                }
                else if (anaSecim == "2") 
                {
                    foreach (var masa in masalar)
                    {
                        if (masa.BosMu == false)
                        {
                            Console.WriteLine(masa.Id+".Masa:"+masa.Hesap);
                        }
                    }

                    Console.WriteLine("Hangi Masanın Hesabı Alınacak?");
                    int id = Convert.ToInt32(Console.ReadLine());
                    var musteriMasasi = masalar.Where(i => i.Id == id).FirstOrDefault();
                    Console.WriteLine("Hesap:"+musteriMasasi.Hesap);
                    Console.WriteLine("Ödendi Mi?");
                    string odeme = Console.ReadLine().ToUpper();

                    if (odeme == "E")
                    {
                        musteriMasasi.Hesap = 0;
                        musteriMasasi.BosMu = true;
                        musteriMasasi.Siparis.Clear();
                    }

                }
                else
                {
                    Console.WriteLine("Hatalı Tuşlama!");
                }
            }
          
        }
    }
}

/*
 ******** RESTAURANT OTOMASYONU *********
 * Toplam 5 masa olacak. Masalarda kişi sınırlaması YOK. Her masa kendinden önceki masa dolu ise müşteri oturtulacak
 * Çorbalar:Mercimek:40, Yayla: 45, Ezogelin:54.5 gibi 5 menü yazılacak.
 * Merhaba hoşgeldiniz ifadesi kaç müşteri olduğunu öğrenilecek. Her grupdaki müşterilere ayrı ayrı menüler listelenecek ve seçim sonrası başka arzunuz var mı? sorusu sorulacak. 
    * Evet ise yeniden menüler listlenecek ve seçim istenecek. 
    * Hayır cevabı alınırsa diğer müşteriye geçilecek.
 * Sipariş alma işlemi bittiğinde yeni müşteri var mı? veya Hesap Al
  
 *** Z Raporu
 *** En Fazla Tercih Edilen Ürün
 */
