namespace _15_Methods_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rastgele 1-100 arasında 15 değer tutan bir dizideki tek ve çiftleri ayrı ayrı dizilere atayan metot 
            //1- 15 elemanlı dizi tanımla
            //2- 1,100 arasıdan rastgele değerleri bu diziye ekleyen bir döngü yazıyorsunuz.
            //3- bu diziyi parametre olarak alan ve içerisinde tek mi çift mi diye kontrol eden bir metot yazıyorsunuz.

            #region HARİKA INSAN ALTAN
            //int[] sayilar = new int[15];
            //int tek = 0;
            //int cift = 0;

            //Random r = new Random(); //Instance

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    int sayi = r.Next(1, 100);
            //    sayilar[i] = sayi;
            //    if (sayi % 2 == 0) cift++;
            //    else tek++;
            //}


            //int[] ciftsayilar = new int[cift];
            //int[] teksayilar = new int[tek];


            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 2 == 0)
            //    {
            //        ciftsayilar[cift] = sayilar[i];
            //        cift--;
            //    }
            //    else
            //    {
            //        teksayilar[tek] = sayilar[i];
            //        tek--;
            //    }
            //}

            #endregion

            #region ali
            int[] sayilar = new int[15];
            
          

            Random r = new Random(); //Instance

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = r.Next(1, 100);
            }

          

            #endregion


        }

        static void TekCiftKontrol(int[] sayilar)
        {
            int[] ciftler = new int[0];
            int[] tekler = new int[0];
            foreach (int sayi in sayilar)
            {
                if (sayi % 2 == 0)
                {
                    Array.Resize(ref ciftler, ciftler.Length + 1);
                    ciftler[ciftler.Length - 1] = sayi;
                }
                else
                {
                    Array.Resize(ref tekler, tekler.Length + 1);
                    tekler[tekler.Length - 1] = sayi;
                }
            }
        }
    }
}
