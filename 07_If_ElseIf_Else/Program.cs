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


            //Console.WriteLine("Birinci ürün fiyatını giriniz");
            //double fiyat1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("İkinci ürün fiyatını giriniz");
            //double fiyat2 = Convert.ToDouble(Console.ReadLine());


            //if ((fiyat1 + fiyat2) > 2500)
            //{
            //    if (fiyat1 > fiyat2)
            //    {
            //        fiyat2 = fiyat2 * 0.75;
            //    }
            //    else
            //    {
            //        fiyat1 = fiyat1 * 0.75;
            //    }
            //}
            //Console.WriteLine("Ödeme:" + (fiyat1 + fiyat2));

            #endregion

            #region // Aylık geliri 40000 üstünde ise %12 vergi kesilecek,
            // 40000 ve altında ise %9 vergi kesimi yapılarak 
            // kullanıcıya yeni gelirini bu hesaplamalar sonucunda gösteriniz

            //Console.WriteLine("Aylik gelirinizi giriniz");
            //double aylikgelir = Convert.ToDouble(Console.ReadLine());

            //if (aylikgelir > 40000)
            //{
            //    aylikgelir = aylikgelir * 0.88;                
            //}
            //else 
            //{
            //    double vergi = aylikgelir * 0.09;
            //    aylikgelir = aylikgelir - vergi;

            //    //aylikgelir = aylikgelir * 0.91;               
            //}
            //Console.WriteLine("Yeni geliriniz:" + aylikgelir);

            #endregion

            #region Öğrenciden vize ve final notlarını alınız ve vize %40 final %60 alınarak ortalamasını hesaplayınız. 
            //ortalamaya göre 
            /*
            0,24   FF
            25,44  DD
            45,54  CC
            55,69  CB
            70,84  BB
            85,100 AA

             */
            //BASLA:
            //    Console.WriteLine("Öğrencinin vize notunu giriniz.");
            //    int vizenotu = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Öğrencinin final notunu giriniz.");
            //    int finalnotu = Convert.ToInt32(Console.ReadLine());


            //    if(vizenotu<0 || vizenotu>100 || finalnotu>100 || finalnotu < 0)
            //    {
            //        Console.WriteLine("Hatalı Not Girişi!!");
            //        goto BASLA;
            //    }

            //double ortalamanot = vizenotu * 0.4 + finalnotu * 0.6;


            // if (ortalamanot >= 0 && ortalamanot <= 24)
            //{

            //    Console.WriteLine("FF");
            //}

            //else if (ortalamanot >= 25 && ortalamanot <= 44)
            //{

            //    Console.WriteLine("DD");
            //}

            //else if (ortalamanot >= 45 && ortalamanot <= 54)
            //{

            //    Console.WriteLine("CC");
            //}

            //else if (ortalamanot >= 55 && ortalamanot <= 69)
            //{

            //    Console.WriteLine("CB");
            //}

            //else if (ortalamanot >= 70 && ortalamanot <= 84)
            //{

            //    Console.WriteLine("BB");
            //}
            //else
            //{

            //    Console.WriteLine("AA");
            //}


            //goto BASLA;


            #region Deniz
            //Console.WriteLine("Vize Puanınızı Giriniz");
            //double vize = Convert.ToDouble(Console.ReadLine());

            //if (vize >= 0 && vize <= 100)
            //{
            //    Console.WriteLine("Final Notunuzu Giriniz");
            //    double final = Convert.ToDouble(Console.ReadLine());

            //    if (final >= 0 && final <= 100)
            //    {
            //        double ortalama = vize * 0.4 + final * 0.6;
            //        if (ortalama < 25)
            //            Console.WriteLine("FF");
            //        else if (ortalama < 45)
            //            Console.WriteLine("DD");
            //        else if (ortalama < 55)
            //            Console.WriteLine("CC");
            //        else if (ortalama < 70)
            //            Console.WriteLine("CB");
            //        else if (ortalama < 85)
            //            Console.WriteLine("BB");
            //        else
            //            Console.WriteLine("AA");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Lütfen Geçerli Final Notu Giriniz");
            //    }

            //}

            //else Console.WriteLine("Lütfen Geçerli Vize Not Giriniz");
            #endregion
            #endregion

            #region  1-50 arasındaki sayıların içinde 7'e tam bölünenleri ekrana teker teker yazdırınız.

            //int i = 1;

            //DON:
            //if (i < 51)
            //{
            //    if (i % 7 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //    goto DON;
            //}

            #endregion

            #region   Kullanıcıdan isim, yaş, maaş ve çocuk sayısı alınsın.
            /*
                Eğer kulanıcının yaşı 45'in altındaysa;
                    Çocuk sayısına bakılacak.Ve çocuk sayısı 3'ten az ise çocuk başına 2500₺,
                                                          3 ve 3'ten çok ise çocuk başına 2000₺ 
                                                                maaşa ekleme yapılacak.
                45 ve 45'in üzerinde ise çocuk başına para verilmeyecek ancak 5000₺ ekleme yapılacak.
                Son olarak ekrana: "Nesrin Yılmaz, Maaşınız: 40000₺" yazılacak.
             */


            Console.WriteLine("İsminiz:");
            string isim = Console.ReadLine();

            Console.WriteLine("Yaş:");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Maaş:");
            double maas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Çocuk Sayısı:");
            int cocukSayisi = Convert.ToInt32(Console.ReadLine());

            if (yas < 45 && yas>17) 
            {
                if (cocukSayisi < 3)
                {
                    maas += cocukSayisi * 2500; //maas = maas + (cocukSayisi*2500)
                }
                else
                {
                    maas += cocukSayisi * 2000;
                }
                Console.WriteLine($"Sayın {isim} Maaşınız: {maas}");
            }
            else if(yas<70 && yas>44) 
            {
                maas += 5000;
                Console.WriteLine($"Sayın {isim} Maaşınız: {maas}");
            }
            else
            {
                Console.WriteLine("Senin yazacağın yaş bu olmamalı!!");
            }
            
            #endregion


        }
    }
}
