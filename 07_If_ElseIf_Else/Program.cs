namespace _07_If_ElseIf_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region *** KARAR YAPILARI(AKIŞ KONTROL - CONDITION) ***
            /* 
           1-IF - ELSE IF - ELSE
           2-Switch Case

           ***** IF ELSEIF ELSE *****

           Bir karar verme durumunda birden fazla karşılaştırma(olasılık) var ise her zaman ilk if(1.durum) ile başlanır. 2. veya sonraki karşılaştırmalar(olasılık) için else if(2.durum) kullanılır. Kontrol edilecek bütün durumlar if ve elseif ile kontrol edildikten sonra geriye kalan durumlar için else kullanılır. Geriye kalan bütün durumlar için else yazdığımız için KOŞUL VERİLMEZ.


            */

            //Kullanıcıdan bir sayı alınız ve 100'den büyük ise "BÜYÜK" değilse "küçük" bilgisi konsola yazsın
            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi > 100) //koşul true ise if kod bloğu çalışır.
            //{
            //    Console.WriteLine("BÜYÜK");
            //}
            //else if (sayi == 100)
            //{
            //    Console.WriteLine("Sayı 100'dür");
            //}
            //else //değilse anlamına geldiği için KOŞUL VERİLMEZ.
            //{
            //    Console.WriteLine("küçük");
            //}
            #endregion

            #region Kullanıcıdan 1 sayı alınız ve Negatif mi Pozitif mi ekrana yazdırınız.
            //Console.WriteLine("Sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi > 0)
            //{
            //    Console.WriteLine("Pozitif");
            //}
            //else if (sayi == 0)
            //{
            //    Console.WriteLine("Sayı 0");                
            //}
            //else
            //{
            //    Console.WriteLine("Negatif");
            //}


            #endregion

            #region Haftanın hangi gününde olduğumuzu kullanıcıdan rakam olarak alınız ve gün adını yazdırınız.

            #region 1.Yöntem
            //Console.WriteLine("Haftanın kaçıncı günündeyiz?");
            //int gun = Convert.ToInt32(Console.ReadLine());

            //if (gun == 1)
            //{
            //    Console.WriteLine("Pazartesi");
            //}
            //else if (gun == 2)
            //{
            //    Console.WriteLine("Salı");
            //}
            //else if (gun == 3)
            //{
            //    Console.WriteLine("Çarşamba");
            //}
            //else if (gun == 4)
            //{
            //    Console.WriteLine("Perşembe");
            //}
            //else if (gun == 5)
            //{
            //    Console.WriteLine("Cuma");
            //}
            //else if (gun == 6)
            //{
            //    Console.WriteLine("Cumartesi");
            //}
            //else if (gun == 7)
            //{
            //    Console.WriteLine("Pazar");
            //}
            //else // 1 küçük, 7den büyük her gün bilgisi için
            //{
            //    Console.WriteLine("Gün bilgisi hatalı. Lütfen 1-7 arasında bir sayı giriniz!!");
            //}
            #endregion


            #region 2.Yöntem

            //Console.WriteLine("Haftanın kaçıncı günündeyiz?");
            //int gun = Convert.ToInt32(Console.ReadLine());

            //if(gun<1 || gun > 7)
            //{
            //    Console.WriteLine("Gün bilgisi hatalı. Lütfen 1-7 arasında bir sayı giriniz!!");
            //}

            //else if (gun == 1)
            //{
            //    Console.WriteLine("Pazartesi");
            //}
            //else if (gun == 2)
            //{
            //    Console.WriteLine("Salı");
            //}
            //else if (gun == 3)
            //{
            //    Console.WriteLine("Çarşamba");
            //}
            //else if (gun == 4)
            //{
            //    Console.WriteLine("Perşembe");
            //}
            //else if (gun == 5)
            //{
            //    Console.WriteLine("Cuma");
            //}
            //else if (gun == 6)
            //{
            //    Console.WriteLine("Cumartesi");
            //}
            //else
            //{
            //    Console.WriteLine("Pazar");
            //}
            #endregion

            #region 3.Yöntem
            //BASLA:
            //Console.WriteLine("Haftanın kaçıncı günündeyiz?");
            //int gun = Convert.ToInt32(Console.ReadLine());

            //if (gun == 1)
            //{
            //    Console.WriteLine("Pazartesi");
            //}
            //else if (gun == 2)
            //{
            //    Console.WriteLine("Salı");
            //}
            //else if (gun == 3)
            //{
            //    Console.WriteLine("Çarşamba");
            //}
            //else if (gun == 4)
            //{
            //    Console.WriteLine("Perşembe");
            //}
            //else if (gun == 5)
            //{
            //    Console.WriteLine("Cuma");
            //}
            //else if (gun == 6)
            //{
            //    Console.WriteLine("Cumartesi");
            //}
            //else if (gun == 7)
            //{
            //    Console.WriteLine("Pazar");
            //}
            //else // 1 küçük, 7den büyük her gün bilgisi için
            //{
            //    Console.WriteLine("Gün bilgisi hatalı. Lütfen 1-7 arasında bir sayı giriniz!!");
            //    goto BASLA;
            //}

            #endregion

            #endregion
            #region Kullanıcıdan iki ürün fiyatı isteyin, ürün fiyat toplamları 2500 tl geçerse ucuz ürüne  % 25 indirim uygulayınız

            #region 1.yol
            //Console.WriteLine("Birinci ürün fiyatını giriniz");
            //double fiyat1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("İkinci ürün fiyatını giriniz");
            //double fiyat2 = Convert.ToDouble(Console.ReadLine());

            //double toplam = fiyat1 + fiyat2;

            //if (toplam > 2500) 
            //{
            //    if (fiyat1 > fiyat2)
            //    {
            //        fiyat2 = fiyat2 * 0.75;
            //    }
            //    else
            //    {
            //        fiyat1 = fiyat1 * 0.75;
            //    }
            //    toplam = fiyat1 + fiyat2;
            //    Console.WriteLine("Ödeme:"+toplam);
            //}
            //else
            //{
            //    Console.WriteLine("Ödeme:"+toplam);
            //}
            #endregion


            Console.WriteLine("Birinci ürün fiyatını giriniz");
            double fiyat1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("İkinci ürün fiyatını giriniz");
            double fiyat2 = Convert.ToDouble(Console.ReadLine());


            if ((fiyat1 + fiyat2) > 2500)
            {
                if (fiyat1 > fiyat2)
                {
                    fiyat2 = fiyat2 * 0.75;
                }
                else
                {
                    fiyat1 = fiyat1 * 0.75;
                }
            }
            Console.WriteLine("Ödeme:" + (fiyat1 + fiyat2));






            #endregion
        }
    }
}
