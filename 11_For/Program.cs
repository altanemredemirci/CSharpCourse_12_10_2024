namespace _11_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //while (i < 11)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            /*
            1-sayaç(i) tanımlanır.
            2-while içerisinde koşul kontrol ediliyor ve true olduğu durumda tur dönüyor. T->3 F->6
            3-işlem kod bloğu çalışıyor.
            4-i manipüle ediliyor.(arttırma,azaltma)
            5-2.adıma dön 
            6-Bitti
             */

            // *********** FOR LOOP ***********
            #region FOR LOOP

            #endregion
            //for (int i=1; i<11; i++)
            //{
            //    Console.WriteLine(i);
            //}


            #region Kullanıcının girmiş olduğu 5 pozitif sayıyı toplayınız.

            int toplam = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Sayı giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi >= 0)
                {
                    toplam += sayi;
                }
                else
                {
                    i--;
                }
            }

            //int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine("Sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi >= 0)
            //    {
            //        toplam += sayi;
            //        i++;
            //    }

            //}

            Console.WriteLine("Toplam:" + toplam);
            #endregion
        }
    }
}
